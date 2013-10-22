// Type: USER_RELATIONS
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

public class USER_RELATIONS
{
  public bool IgnoresLoaded;
  public bool DeclinesLoaded;
  public bool BlacklistLoaded;
  public bool UserStatsLoaded;
  public List<string> Ignoring;
  public List<string> Declining;
  public Dictionary<string, string> Blacklist;
  public Dictionary<string, USER_STATS> UserStats;

  public USER_RELATIONS()
  {
    this.IgnoresLoaded = false;
    this.DeclinesLoaded = false;
    this.BlacklistLoaded = false;
    this.UserStatsLoaded = false;
    this.Ignoring = new List<string>();
    this.Declining = new List<string>();
    this.Blacklist = new Dictionary<string, string>();
    this.UserStats = new Dictionary<string, USER_STATS>();
  }

  public int LoadList(string path, RELATION_TYPE reltype)
  {
    string str1 = (string) null;
    string str2 = (string) null;
    string str3 = (string) null;
    string str4 = (string) null;
    string str5 = (string) null;
    FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
    StreamReader streamReader = new StreamReader((Stream) fileStream);
    BinaryReader br = new BinaryReader((Stream) fileStream);
    int num1 = 0;
    int num2;
    switch (reltype)
    {
      case (RELATION_TYPE) 0:
        this.Ignoring.Clear();
        this.Ignoring.Capacity = 10;
        str1 = (string) null;
        while (true)
        {
          string str6 = streamReader.ReadLine();
          if (str6 != (string) null)
          {
            this.Ignoring.Add(str6);
            ++num1;
          }
          else
            break;
        }
        this.IgnoresLoaded = true;
        goto default;
      case (RELATION_TYPE) 1:
        this.Declining.Clear();
        this.Declining.Capacity = 75;
        str2 = (string) null;
        int num3 = 0;
        while (true)
        {
          string str6 = streamReader.ReadLine();
          if (str6 != (string) null)
          {
            this.Declining.Add(str6);
            ++num3;
          }
          else
            break;
        }
        this.DeclinesLoaded = true;
        goto default;
      case (RELATION_TYPE) 2:
        this.Blacklist.Clear();
        str3 = (string) null;
        str4 = (string) null;
        while (true)
        {
          string key = streamReader.ReadLine();
          if (key != (string) null)
          {
            string str6 = streamReader.ReadLine();
            if (!(str6 == (string) null))
            {
              this.Blacklist.Add(key, str6);
              ++num1;
            }
            else
              break;
          }
          else
            goto label_14;
        }
        this.BlacklistLoaded = true;
label_14:
        this.BlacklistLoaded = true;
        goto default;
      case (RELATION_TYPE) 3:
        this.UserStats.Clear();
        str5 = (string) null;
        int num4;
        try
        {
          while (1 != 0)
          {
            string str6 = br.ReadString();
            USER_STATS userStats = new USER_STATS();
            userStats.ReadFromFile(str6, br);
            this.UserStats.Add(str6, userStats);
            ++num1;
          }
          goto default;
        }
        catch (EndOfStreamException ex)
        {
          this.UserStatsLoaded = true;
          num4 = num1;
        }
        num2 = num4;
        break;
      default:
        try
        {
          br.Close();
          IDisposable disposable = (IDisposable) br;
          int num5;
          if (disposable != null)
          {
            disposable.Dispose();
            num5 = 0;
          }
          else
            num5 = 0;
        }
        catch (Exception ex)
        {
        }
        try
        {
          streamReader.Close();
          IDisposable disposable = (IDisposable) streamReader;
          int num5;
          if (disposable != null)
          {
            disposable.Dispose();
            num5 = 0;
          }
          else
            num5 = 0;
        }
        catch (Exception ex)
        {
        }
        try
        {
          fileStream.Close();
          IDisposable disposable = (IDisposable) fileStream;
          int num5;
          if (disposable != null)
          {
            disposable.Dispose();
            num5 = 0;
          }
          else
            num5 = 0;
        }
        catch (Exception ex)
        {
        }
        num2 = num1;
        break;
    }
    return num2;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsIgnored(string name)
  {
    bool flag;
    for (int index = 0; index < this.Ignoring.Count; ++index)
    {
      if (this.Ignoring[index] == name)
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsDeclining(string name)
  {
    bool flag;
    for (int index = 0; index < this.Declining.Count; ++index)
    {
      if (this.Declining[index] == name)
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsBlacklisted(IPEndPoint ep)
  {
    string str = (string) null;
    str = ep.Address.ToString();
    return this.Blacklist.ContainsKey(ep.Address.ToString());
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsBlacklisted(string name)
  {
    return this.Blacklist.ContainsValue(name);
  }

  public void ToggleIgnore(string name, [MarshalAs(UnmanagedType.U1)] bool on_off)
  {
    if (on_off)
      this.Ignoring.Add(name);
    else
      this.Ignoring.Remove(name);
  }

  public void ToggleDecline(string name, [MarshalAs(UnmanagedType.U1)] bool on_off)
  {
    if (on_off)
      this.Declining.Add(name);
    else
      this.Declining.Remove(name);
  }

  public void UserJoined(string name, IPEndPoint IP_EP, DateTime join_time)
  {
    if (this.UserStats.ContainsKey(name))
    {
      bool flag = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (!flag)
          return;
        ++this.UserStats[name].Joins;
        if ((int) this.UserStats[name].FirstIP != 0 || IP_EP == null || (int) Module.IPToInt32(IP_EP) == 0)
          return;
        this.UserStats[name].FirstIP = Module.IPToInt32(IP_EP);
      }
      finally
      {
        if (flag)
          Monitor.Exit((object) this.UserStats);
      }
    }
    else
      this.AddNewUser(name, IP_EP, join_time);
  }

  public void AddNewUser(string name, IPEndPoint IP_EP, DateTime join_time)
  {
    if (this.UserStats.ContainsKey(name))
      return;
    USER_STATS userStats = new USER_STATS();
    userStats.Name = name;
    userStats.Joins = 1U;
    userStats.FirstSeen = (ulong) join_time.ToBinary();
    userStats.FirstIP = Module.IPToInt32(IP_EP);
    bool flag = Monitor.TryEnter((object) this.UserStats, 300);
    try
    {
      if (!flag)
        return;
      this.UserStats.Add(name, userStats);
    }
    finally
    {
      Monitor.Exit((object) this.UserStats);
    }
  }

  public void AddVsTime(string name, TimeSpan difference)
  {
    if (!this.UserStats.ContainsKey(name))
      return;
    bool flag = Monitor.TryEnter((object) this.UserStats, 300);
    try
    {
      if (!flag)
        return;
      this.UserStats[name].VS_Time += (ulong) difference.Ticks;
    }
    finally
    {
      Monitor.Exit((object) this.UserStats);
    }
  }

  public ulong GetVsTime(string name)
  {
    ulong num1 = 0UL;
    ulong num2;
    if (!this.UserStats.ContainsKey(name))
    {
      num2 = 0UL;
    }
    else
    {
      bool flag = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (flag)
          num1 = this.UserStats[name].VS_Time;
      }
      finally
      {
        Monitor.Exit((object) this.UserStats);
      }
      num2 = num1;
    }
    return num2;
  }

  public void UpdatePingInfo(string name, int pingsample)
  {
    if (!this.UserStats.ContainsKey(name) || pingsample > 600)
      return;
    bool flag = Monitor.TryEnter((object) this.UserStats, 100);
    try
    {
      if (!flag)
        return;
      int num1 = (int) this.UserStats[name].AvgPing;
      if (num1 == 0)
      {
        this.UserStats[name].AvgPing = (uint) pingsample;
      }
      else
      {
        int num2 = num1 + pingsample;
        this.UserStats[name].AvgPing = (uint) (num2 / 2);
      }
    }
    finally
    {
      Monitor.Exit((object) this.UserStats);
    }
  }

  public void AddWinLoss(string name, int wins, int losses)
  {
    if (!this.UserStats.ContainsKey(name))
      return;
    bool flag = Monitor.TryEnter((object) this.UserStats, 100);
    try
    {
      if (!flag)
        return;
      int num = (int) this.UserStats[name].WinLoss + ((wins << 16) + losses);
      this.UserStats[name].WinLoss = (uint) num;
    }
    finally
    {
      Monitor.Exit((object) this.UserStats);
    }
  }

  public int GetWins(string name)
  {
    int num1 = -1;
    int num2;
    if (!this.UserStats.ContainsKey(name))
    {
      num2 = -1;
    }
    else
    {
      bool flag = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (flag)
          num1 = (int) (this.UserStats[name].WinLoss >> 16);
      }
      finally
      {
        Monitor.Exit((object) this.UserStats);
      }
      num2 = num1;
    }
    return num2;
  }

  public int GetLosses(string name)
  {
    int num1 = -1;
    int num2;
    if (!this.UserStats.ContainsKey(name))
    {
      num2 = -1;
    }
    else
    {
      bool flag = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (flag)
          num1 = (int) this.UserStats[name].WinLoss & (int) ushort.MaxValue;
      }
      finally
      {
        Monitor.Exit((object) this.UserStats);
      }
      num2 = num1;
    }
    return num2;
  }

  public int GetAveragePing(string name)
  {
    int num1 = -1;
    int num2;
    if (!this.UserStats.ContainsKey(name))
    {
      num2 = -1;
    }
    else
    {
      bool flag = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (flag)
          num1 = (int) this.UserStats[name].AvgPing;
      }
      finally
      {
        Monitor.Exit((object) this.UserStats);
      }
      num2 = num1;
    }
    return num2;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool MatchesSavedIP(string name, IPEndPoint ep)
  {
    bool flag1 = false;
    bool flag2;
    if (!this.UserStats.ContainsKey(name))
    {
      flag2 = false;
    }
    else
    {
      bool flag3 = Monitor.TryEnter((object) this.UserStats, 300);
      try
      {
        if (flag3)
        {
          flag1 = (int) this.UserStats[name].FirstIP == (int) Module.IPToInt32(ep);
          if ((int) this.UserStats[name].FirstIP == 0)
            flag1 = true;
        }
      }
      finally
      {
        if (flag3)
          Monitor.Exit((object) this.UserStats);
      }
      flag2 = flag1;
    }
    return flag2;
  }

  public USER_STATS GetStats(string lookup_name)
  {
    USER_STATS userStats;
    if (!this.UserStats.ContainsKey(lookup_name))
      userStats = (USER_STATS) null;
    else if (Monitor.TryEnter((object) this.UserStats, 500))
    {
      try
      {
        userStats = this.UserStats[lookup_name];
      }
      finally
      {
        Monitor.Exit((object) this.UserStats);
      }
    }
    else
      userStats = (USER_STATS) null;
    return userStats;
  }

  public void RemoveStatRecord(string lookup_name)
  {
    if (lookup_name == (string) null)
      return;
    Monitor.Enter((object) this.UserStats);
    try
    {
      this.UserStats.Remove(lookup_name);
    }
    finally
    {
      Monitor.Exit((object) this.UserStats);
    }
  }

  public void SaveList(string path, RELATION_TYPE reltype)
  {
    FileStream fileStream = (FileStream) null;
    StreamWriter streamWriter = (StreamWriter) null;
    BinaryWriter binaryWriter = (BinaryWriter) null;
    string str = (string) null;
    BinaryWriter bw;
    try
    {
      fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
      streamWriter = new StreamWriter((Stream) fileStream);
      bw = new BinaryWriter((Stream) fileStream);
    }
    catch (Exception ex1)
    {
      if (binaryWriter != null)
        binaryWriter.Close();
      IDisposable disposable1 = (IDisposable) binaryWriter;
      int num1;
      if (disposable1 != null)
      {
        disposable1.Dispose();
        num1 = 0;
      }
      else
        num1 = 0;
      try
      {
        if (streamWriter != null)
          streamWriter.Close();
        IDisposable disposable2 = (IDisposable) streamWriter;
        int num2;
        if (disposable2 != null)
        {
          disposable2.Dispose();
          num2 = 0;
        }
        else
          num2 = 0;
      }
      catch (ObjectDisposedException ex2)
      {
      }
      if (fileStream != null)
        fileStream.Close();
      IDisposable disposable3 = (IDisposable) fileStream;
      int num3;
      if (disposable3 != null)
      {
        disposable3.Dispose();
        num3 = 0;
        return;
      }
      else
      {
        num3 = 0;
        return;
      }
    }
    switch (reltype)
    {
      case (RELATION_TYPE) 0:
        if (this.IgnoresLoaded)
        {
          for (int index = 0; index < this.Ignoring.Count; ++index)
          {
            str = this.Ignoring[index];
            streamWriter.WriteLine(this.Ignoring[index]);
          }
          streamWriter.Flush();
          streamWriter.Close();
          break;
        }
        else
          break;
      case (RELATION_TYPE) 1:
        if (this.DeclinesLoaded)
        {
          for (int index = 0; index < this.Declining.Count; ++index)
            streamWriter.WriteLine(this.Declining[index]);
          streamWriter.Flush();
          streamWriter.Close();
          break;
        }
        else
          break;
      case (RELATION_TYPE) 3:
        if (this.UserStatsLoaded)
        {
          bool flag = Monitor.TryEnter((object) this.UserStats, 300);
          try
          {
            if (flag)
            {
              Dictionary<string, USER_STATS>.Enumerator enumerator = this.UserStats.GetEnumerator();
              while (enumerator.MoveNext())
                enumerator.Current.Value.WriteSelf(bw);
            }
          }
          finally
          {
            Monitor.Exit((object) this.UserStats);
          }
          bw.Flush();
          bw.Close();
          break;
        }
        else
          break;
    }
    if (fileStream == null)
      return;
    fileStream.Close();
  }

  public void SaveAll()
  {
    this.SaveList("mtspfim_ignores.txt", (RELATION_TYPE) 0);
    this.SaveList("mtspfim_declines.txt", (RELATION_TYPE) 1);
    this.SaveList(".\\files\\stats.pon", (RELATION_TYPE) 3);
  }
}
