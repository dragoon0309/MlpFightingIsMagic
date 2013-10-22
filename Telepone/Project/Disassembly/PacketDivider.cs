// Type: PacketDivider
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Runtime.InteropServices;

public class PacketDivider
{
  public int Length;
  public byte[] Packet;

  public PacketDivider(ref byte[] datagram)
  {
    this.Length = 0;
    this.Packet = datagram;
  }

  public byte[] Divide(int length)
  {
    byte[] numArray = new byte[length];
    Array.Copy((Array) this.Packet, this.Length, (Array) numArray, 0, length);
    this.Length += length;
    return numArray;
  }

  public byte Divide()
  {
    byte num = this.Packet[this.Length];
    ++this.Length;
    return num;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool HasMore()
  {
    return this.Length < this.Packet.Length;
  }
}
