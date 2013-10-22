// Type: USER_STATS
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.IO;

public class USER_STATS
{
  public ulong VS_Time = 0UL;
  public uint Joins = 0U;
  public ulong FirstSeen = 0UL;
  public uint AvgPing = 0U;
  public uint FirstIP = 0U;
  public uint WinLoss = 0U;
  public string Name;
  public uint Reserved5;

  public USER_STATS()
  {
    this.Name = "Null";
  }

  public void WriteSelf(BinaryWriter bw)
  {
    bw.Write(this.Name);
    bw.Write(this.VS_Time);
    bw.Write(this.Joins);
    bw.Write(this.FirstSeen);
    bw.Write(this.AvgPing);
    bw.Write(this.FirstIP);
    bw.Write(this.WinLoss);
    bw.Write(this.Reserved5);
  }

  public void ReadFromFile(string newname, BinaryReader br)
  {
    this.Name = newname;
    this.VS_Time = (ulong) br.ReadInt64();
    this.Joins = (uint) br.ReadInt32();
    this.FirstSeen = (ulong) br.ReadInt64();
    this.AvgPing = (uint) br.ReadInt32();
    this.FirstIP = (uint) br.ReadInt32();
    this.WinLoss = (uint) br.ReadInt32();
    this.Reserved5 = (uint) br.ReadInt32();
  }
}
