// Type: PacketPacker
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Runtime.InteropServices;

public class PacketPacker : IDisposable
{
  public int Length;
  public byte[] Packet;

  public PacketPacker()
  {
    this.Length = 0;
    this.Packet = new byte[1020];
  }

  private void PacketPacker()
  {
    if (this.Packet == null)
      return;
    this.Packet = (byte[]) null;
  }

  public void Pack(ref byte[] data)
  {
    Array.Copy((Array) data, 0, (Array) this.Packet, this.Length, data.Length);
    this.Length += data.Length;
  }

  public void Pack(byte data)
  {
    this.Packet[this.Length] = data;
    ++this.Length;
  }

  public void Pack32(uint data)
  {
    Array.Copy((Array) BitConverter.GetBytes(data), 0, (Array) this.Packet, this.Length, 4);
    this.Length += 8;
  }

  public void Pack64(ulong data)
  {
    Array.Copy((Array) BitConverter.GetBytes(data), 0, (Array) this.Packet, this.Length, 8);
    this.Length += 8;
  }

  public void Clear()
  {
    this.Length = 0;
    Array.Clear((Array) this.Packet, 0, 1020);
  }

  protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
  {
    if (param0)
    {
      this.PacketPacker();
    }
    else
    {
      // ISSUE: explicit finalizer call
      this.Finalize();
    }
  }

  public virtual void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }
}
