// Type: PacketScheduler
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

public class PacketScheduler
{
  private static int MAX_QUEUE_SIZE = 50;
  private static int MAX_LIST_SIZE = 25;
  public uint LastWarningMessageTime;
  public List<int> Expecting;
  public Queue<int> PacketIDs;

  static PacketScheduler()
  {
  }

  public PacketScheduler()
  {
    this.LastWarningMessageTime = 0U;
    this.PacketIDs = new Queue<int>(PacketScheduler.MAX_QUEUE_SIZE);
    this.Expecting = new List<int>(PacketScheduler.MAX_LIST_SIZE);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsDuplicatePacket(int ID)
  {
    bool flag;
    if (Monitor.TryEnter((object) this.PacketIDs, 300))
    {
      try
      {
        flag = this.PacketIDs.Contains(ID);
      }
      finally
      {
        Monitor.Exit((object) this.PacketIDs);
      }
    }
    else
      flag = false;
    return flag;
  }

  public void MarkReceived(int ID)
  {
    if (!Monitor.TryEnter((object) this.PacketIDs, 500))
      return;
    try
    {
      while (this.PacketIDs.Count >= PacketScheduler.MAX_QUEUE_SIZE)
      {
        this.PacketIDs.Dequeue();
        this.PacketIDs.Dequeue();
      }
      this.PacketIDs.Enqueue(ID);
    }
    finally
    {
      Monitor.Exit((object) this.PacketIDs);
    }
  }

  public void Schedule(int packhead)
  {
    if (!Monitor.TryEnter((object) this.Expecting, 300))
      return;
    try
    {
      this.Expecting.Add(packhead);
      if (this.Expecting.Count < PacketScheduler.MAX_LIST_SIZE)
        return;
      this.Expecting.RemoveAt(0);
    }
    finally
    {
      Monitor.Exit((object) this.Expecting);
    }
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool IsScheduled(MT_SP_PACKET_HEADER ph, [MarshalAs(UnmanagedType.U1)] bool remove)
  {
    bool flag;
    if (ph != (MT_SP_PACKET_HEADER) 36 && ph != (MT_SP_PACKET_HEADER) 34)
      flag = true;
    else if (Monitor.TryEnter((object) this.Expecting, 300))
    {
      try
      {
        if (this.Expecting.Contains((int) ph))
        {
          if (remove)
            this.Expecting.Remove((int) ph);
          flag = true;
        }
        else
          flag = false;
      }
      finally
      {
        Monitor.Exit((object) this.Expecting);
      }
    }
    else
      flag = false;
    return flag;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool TryWarningMessage(int ms)
  {
    bool flag;
    if (Module.timeGetTime() - this.LastWarningMessageTime > (uint) ms)
    {
      this.LastWarningMessageTime = Module.timeGetTime();
      flag = true;
    }
    else
      flag = false;
    return flag;
  }
}
