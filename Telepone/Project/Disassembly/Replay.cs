// Type: Replay
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class Replay : IComparer<Replay>
{
  public static char[] mReplayHeader = new char[5]
  {
    'T',
    'Y',
    'M',
    'T',
    'R'
  };
  public static char[] mRepDataEnder = new char[4]
  {
    '#',
    'E',
    'N',
    'D'
  };
  public static char[] mReplayFooter = new char[9]
  {
    'R',
    'E',
    'P',
    'F',
    'O',
    'O',
    'T',
    'E',
    'R'
  };
  public byte m_HeaderVersion;
  public string m_P1Name;
  public string m_P2Name;
  public int m_RandSeed;
  public byte m_MaxStage;
  public byte m_StageSelect;
  public byte m_Round;
  public byte m_Timer;
  public string m_FullFilepath;
  public string m_FullFilename;
  public string m_SavedWithVersion;
  public int m_SecondaryHeaderStart;
  public int m_SecondaryHeaderItemCount;
  public bool m_LightLoad;
  public bool m_Marked;
  public string m_Comment;
  public string m_GameExeName;
  public DateTime m_CreationTime;
  public string m_ErrorString;
  public bool m_Init;
  public bool m_NotFound;
  public bool m_NotAReplay;
  public bool m_HasSecondaryHeader;
  public byte[] m_Data;
  private FileStream m_ReplayFile;
  public REP_CMP_TYPE compare_type;

  static Replay()
  {
  }

  public Replay(string path, [MarshalAs(UnmanagedType.U1)] bool light_loading)
  {
    BinaryReader br1 = (BinaryReader) null;
    // ISSUE: explicit constructor call
    base.ctor();
    this.m_Init = false;
    this.m_NotFound = false;
    this.m_NotAReplay = false;
    this.m_SavedWithVersion = "Unknown";
    this.m_HasSecondaryHeader = false;
    this.m_SecondaryHeaderStart = -1;
    this.m_FullFilename = "";
    this.m_LightLoad = light_loading;
    this.m_Data = new byte[0];
    this.m_Comment = "";
    this.m_GameExeName = "";
    this.m_ErrorString = "No error";
    this.compare_type = (REP_CMP_TYPE) 0;
    if (path == (string) null)
      return;
    if (path.Length <= 1)
      return;
    try
    {
      this.m_ReplayFile = new FileStream(path, FileMode.Open);
      br1 = new BinaryReader((Stream) this.m_ReplayFile);
      if (!this.CheckHeader(br1.ReadChars(Replay.mReplayHeader.Length)))
      {
        this.m_NotAReplay = true;
      }
      else
      {
        Replay replay1 = this;
        string name = replay1.m_ReplayFile.Name;
        replay1.m_FullFilepath = name;
        this.m_FullFilename = Path.GetFileName(path);
        this.m_CreationTime = File.GetCreationTime(path);
        this.m_HeaderVersion = br1.ReadByte();
        Replay replay2 = this;
        BinaryReader br2 = br1;
        string str1 = replay2.ReadString(br2);
        replay2.m_P1Name = str1;
        Replay replay3 = this;
        BinaryReader br3 = br1;
        string str2 = replay3.ReadString(br3);
        replay3.m_P2Name = str2;
        if ((int) this.m_HeaderVersion >= 51)
        {
          this.m_RandSeed = (int) br1.ReadUInt32();
          this.m_MaxStage = br1.ReadByte();
          this.m_StageSelect = br1.ReadByte();
          this.m_Round = br1.ReadByte();
          this.m_Timer = br1.ReadByte();
        }
        else
        {
          this.m_RandSeed = -1;
          this.m_MaxStage = byte.MaxValue;
          this.m_StageSelect = byte.MaxValue;
          this.m_Round = byte.MaxValue;
          this.m_Timer = byte.MaxValue;
        }
        Replay replay4 = this;
        BinaryReader br4 = br1;
        int num1 = replay4.LookForFooter(br4);
        replay4.m_SecondaryHeaderStart = num1;
        int num2 = (int) br1.BaseStream.Position;
        int num3 = (int) br1.BaseStream.Length;
        if (this.m_SecondaryHeaderStart != -1)
          num3 = this.m_SecondaryHeaderStart - Replay.mRepDataEnder.Length;
        if (!light_loading)
        {
          this.m_Data = new byte[num3 - num2];
          br1.BaseStream.Position = (long) num2;
          int index = 0;
          while (br1.BaseStream.Position != (long) num3 && br1.BaseStream.Position != (long) this.m_SecondaryHeaderStart)
          {
            this.m_Data[index] = br1.ReadByte();
            ++index;
          }
        }
        if (this.m_SecondaryHeaderStart != -1)
        {
          int num4 = (int) br1.BaseStream.Position;
          this.ReadSecondaryHeader(br1);
          br1.BaseStream.Position = (long) num4;
        }
        br1.Close();
        this.m_ReplayFile.Close();
        this.m_Init = true;
      }
    }
    catch (FileNotFoundException ex)
    {
      this.m_NotFound = true;
    }
    catch (IOException ex)
    {
      this.m_Init = false;
      Module.WriteErrorLog(ex.ToString(), "ReplayCTOR");
    }
    catch (OutOfMemoryException ex)
    {
      this.m_Init = false;
      Module.WriteErrorLog(ex.ToString(), "ReplayCTOR");
    }
    catch (ArgumentException ex)
    {
      Module.WriteErrorLog(ex.ToString(), "ReplayCTOR");
      this.m_Init = false;
      this.m_FullFilepath = "";
      this.m_FullFilename = "";
    }
    catch (Exception ex)
    {
      this.m_Init = false;
    }
    finally
    {
      if (br1 != null)
        br1.Close();
      if (this.m_ReplayFile != null)
        this.m_ReplayFile.Close();
    }
  }

  public string GetInfoString([MarshalAs(UnmanagedType.U1)] bool nonverbose)
  {
    string str1;
    if (!this.m_Init)
      str1 = "File couldn't be read or validated.";
    else if (this.m_NotAReplay)
      str1 = "Not a replay.";
    else if (this.m_NotFound)
    {
      str1 = "File not found.";
    }
    else
    {
      StringBuilder stringBuilder = new StringBuilder();
      string str2 = !(this.m_P2Name == "") ? " vs " + this.m_P2Name : " (Single player)";
      stringBuilder.Append(this.m_P1Name + " " + str2);
      stringBuilder.Append("\n");
      byte num1 = this.m_HeaderVersion;
      stringBuilder.Append(string.Format("Replay type: {0}\n", (object) num1.ToString()));
      stringBuilder.Append(string.Format("Created: {0}", (object) this.m_CreationTime.ToString()));
      if (!nonverbose && !this.m_LightLoad)
      {
        stringBuilder.Append(string.Format("\nTimer: {0}", (object) this.m_Timer));
        if (this.m_Data.Length > 1 && (int) this.m_HeaderVersion == 51)
        {
          int num2 = this.m_Data.Length / 4;
          int num3 = num2 / 100;
          int num4 = num3 > 0 ? num3 / 60 : 1;
          int num5 = num4 > 0 ? num4 : 1;
          stringBuilder.Append(string.Format("\nEst. frames: {0} / {1}m", (object) num2, (object) num5));
        }
        if (this.m_HasSecondaryHeader)
        {
          stringBuilder.Append("\nSaved with: " + this.m_SavedWithVersion);
          stringBuilder.Append("\nGame: " + this.m_GameExeName);
        }
      }
      if (this.m_Comment.Length > 1)
        stringBuilder.Append("\n\n--Comment--\n " + this.m_Comment);
      str1 = stringBuilder.ToString();
    }
    return str1;
  }

  public void SetCompareType(REP_CMP_TYPE type)
  {
    this.compare_type = type;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool StateOK()
  {
    return this.GetState() != (REP_FILE_STATE) 0;
  }

  public string IsCompressed()
  {
    return (int) this.m_HeaderVersion != 51 ? ((int) this.m_HeaderVersion != 52 ? "Old format" : "Compressed") : "Uncompressed";
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsWatchable()
  {
    return this.GetState() != (REP_FILE_STATE) 0 && !this.m_LightLoad && this.m_Data.Length >= 1;
  }

  public string EstimateFrames()
  {
    string str;
    if (this.m_Data.Length > 1 && (int) this.m_HeaderVersion == 51)
    {
      int num1 = this.m_Data.Length / 4;
      int num2 = num1 / 100;
      int num3 = num2 > 0 ? num2 / 60 : 1;
      int num4 = num3 > 0 ? num3 : 1;
      str = string.Format("{0} / {1}m", (object) num1, (object) num4);
    }
    else
      str = "Unknown";
    return str;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool UpdateSecondaryHeaderInfo()
  {
    this.m_SecondaryHeaderItemCount = 0;
    this.m_HasSecondaryHeader = true;
    this.m_SavedWithVersion = "2.06b";
    Replay replay1 = this;
    string str1 = replay1.m_Comment;
    replay1.m_Comment = str1;
    ++this.m_SecondaryHeaderItemCount;
    Replay replay2 = this;
    int num = replay2.m_Marked ? 1 : 0;
    replay2.m_Marked = num != 0;
    ++this.m_SecondaryHeaderItemCount;
    Replay replay3 = this;
    string str2 = replay3.m_GameExeName;
    replay3.m_GameExeName = str2;
    ++this.m_SecondaryHeaderItemCount;
    return true;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool HasSecondaryHeader()
  {
    return this.m_HasSecondaryHeader;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool ToggleMarked()
  {
    this.m_Marked = !this.m_Marked;
    return this.m_Marked;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool Save(string path, [MarshalAs(UnmanagedType.U1)] bool with_secondary_header)
  {
    bool flag;
    if (this.GetState() == (REP_FILE_STATE) 0 || this.m_FullFilepath.Length <= 1)
    {
      this.m_ErrorString = "Bad replay state or bad file path.";
      flag = false;
    }
    else if (this.m_LightLoad)
    {
      this.m_ErrorString = "Cannot save replays that were loaded with fast load.";
      flag = false;
    }
    else
    {
      BinaryWriter bw = !(path == (string) null) ? new BinaryWriter((Stream) File.Create(path)) : new BinaryWriter((Stream) File.Create(this.m_FullFilepath));
      this.UpdateSecondaryHeaderInfo();
      bw.Write(Replay.mReplayHeader);
      bw.Write(this.m_HeaderVersion);
      this.WriteString(bw, this.m_P1Name);
      this.WriteString(bw, this.m_P2Name);
      bw.Write(this.m_RandSeed);
      bw.Write(this.m_MaxStage);
      bw.Write(this.m_StageSelect);
      bw.Write(this.m_Round);
      bw.Write(this.m_Timer);
      bw.Write(this.m_Data);
      if (with_secondary_header)
      {
        bw.Write(Replay.mRepDataEnder);
        int num = (int) bw.BaseStream.Position;
        this.WriteString(bw, this.m_SavedWithVersion);
        bw.Write(this.m_SecondaryHeaderItemCount);
        bw.Write(this.m_Marked);
        if (this.m_Comment.Length > 254)
        {
          Replay replay = this;
          string str = replay.m_Comment.Remove(254);
          replay.m_Comment = str;
        }
        this.WriteString(bw, this.m_Comment);
        this.WriteString(bw, this.m_GameExeName);
        bw.Write(num);
        bw.Write(Replay.mReplayFooter);
      }
      bw.Close();
      flag = true;
    }
    return flag;
  }

  public uint GetFileEndPos()
  {
    return this.StateOK() ? (uint) (this.m_SecondaryHeaderStart - sizeof (char[])) : uint.MaxValue;
  }

  public REP_FILE_STATE GetState()
  {
    return !this.m_Init || this.m_NotAReplay || this.m_NotFound ? (REP_FILE_STATE) 0 : (!this.m_Marked ? (REP_FILE_STATE) 1 : (REP_FILE_STATE) 2);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  private bool CheckHeader(char[] read)
  {
    bool flag;
    for (int index = 0; index < Replay.mReplayHeader.Length; ++index)
    {
      if ((int) read[index] != (int) Replay.mReplayHeader[index])
      {
        flag = false;
        goto label_6;
      }
    }
    flag = true;
label_6:
    return flag;
  }

  private int LookForFooter(BinaryReader br)
  {
    int num1 = (int) br.BaseStream.Position;
    br.BaseStream.Position = br.BaseStream.Length - (long) Replay.mReplayFooter.Length;
    char[] chArray = br.ReadChars(Replay.mReplayFooter.Length);
    int num2;
    for (int index = 0; index < Replay.mReplayFooter.Length; ++index)
    {
      if ((int) chArray[index] != (int) Replay.mReplayFooter[index])
      {
        br.BaseStream.Position = (long) num1;
        num2 = -1;
        goto label_6;
      }
    }
    br.BaseStream.Position = br.BaseStream.Length - (long) Replay.mReplayFooter.Length - 4L;
    int num3 = (int) br.ReadUInt32();
    br.BaseStream.Position = (long) num1;
    num2 = num3;
label_6:
    return num2;
  }

  private void ReadSecondaryHeader(BinaryReader br)
  {
    if (this.m_SecondaryHeaderStart == -1)
      return;
    br.BaseStream.Position = (long) this.m_SecondaryHeaderStart;
    this.m_HasSecondaryHeader = true;
    Replay replay1 = this;
    BinaryReader br1 = br;
    string str1 = replay1.ReadString(br1);
    replay1.m_SavedWithVersion = str1;
    this.m_SecondaryHeaderItemCount = (int) br.ReadUInt32();
    int num1 = 0;
    int num2 = this.m_SecondaryHeaderItemCount;
    int num3 = num1;
    int num4 = num1 + 1;
    int num5 = num3;
    if (num2 <= num5)
      return;
    this.m_Marked = br.ReadBoolean();
    int num6 = this.m_SecondaryHeaderItemCount;
    int num7 = num4;
    int num8 = num4 + 1;
    int num9 = num7;
    if (num6 <= num9)
      return;
    Replay replay2 = this;
    BinaryReader br2 = br;
    string str2 = replay2.ReadString(br2);
    replay2.m_Comment = str2;
    int num10 = this.m_SecondaryHeaderItemCount;
    int num11 = num8;
    int num12 = num8 + 1;
    int num13 = num11;
    if (num10 <= num13)
      return;
    Replay replay3 = this;
    BinaryReader br3 = br;
    string str3 = replay3.ReadString(br3);
    replay3.m_GameExeName = str3;
  }

  private string ReadString(BinaryReader br)
  {
    int count = (int) br.ReadByte();
    return new string(br.ReadChars(count));
  }

  private void WriteString(BinaryWriter bw, string writeme)
  {
    byte num = (byte) writeme.Length;
    bw.Write(num);
    bw.Write(writeme.ToCharArray());
  }

  public override string ToString()
  {
    return !this.m_Init || this.m_NotAReplay || this.m_NotFound ? "(invalid replay)" : this.m_FullFilename;
  }

  public virtual int Compare(Replay lhs, Replay rhs)
  {
    return this.compare_type != (REP_CMP_TYPE) 0 ? (this.compare_type != (REP_CMP_TYPE) 1 || lhs.GetState() == (REP_FILE_STATE) 0 || rhs.GetState() == (REP_FILE_STATE) 0 ? (this.compare_type != (REP_CMP_TYPE) 2 || lhs.GetState() == (REP_FILE_STATE) 0 || rhs.GetState() == (REP_FILE_STATE) 0 ? 0 : (!lhs.m_Marked || !rhs.m_Marked ? (!lhs.m_Marked || rhs.m_Marked ? (lhs.m_Marked || !rhs.m_Marked ? DateTime.Compare(lhs.m_CreationTime, rhs.m_CreationTime) : 1) : -1) : DateTime.Compare(lhs.m_CreationTime, rhs.m_CreationTime))) : DateTime.Compare(lhs.m_CreationTime, rhs.m_CreationTime)) : (lhs.GetState() != (REP_FILE_STATE) 0 || rhs.GetState() != (REP_FILE_STATE) 0 ? (lhs.GetState() != (REP_FILE_STATE) 0 ? (rhs.GetState() != (REP_FILE_STATE) 0 ? string.Compare(lhs.m_FullFilename, rhs.m_FullFilename) : 1) : -1) : 0);
  }
}
