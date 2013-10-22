// Type: VersusInfo
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Drawing;
using System.Net;
using System.Text;

internal class VersusInfo
{
  public int LastSyncFrame = -1;
  public int DesyncCount = 0;
  public uint SEQUENCE;
  public bool SLEEPING;
  public int WAITING;
  public uint START_UP;
  public IPEndPoint IP_EP;
  public uint[] PING;
  public uint[] PONG;
  public uint DELAY;
  public uint INTERVAL;
  public uint INTERVAL2;
  public byte[] SEND;
  public ushort[] LOCAL;
  public uint L_FRAME;
  public int L_READ;
  public ushort[] REMOTE;
  public uint R_FRAME;
  public int R_READ;
  public Point P1Pos;
  public Point P2Pos;

  public VersusInfo()
  {
    this.P1Pos.X = -1;
    this.P1Pos.Y = -1;
    this.P2Pos.X = -1;
    this.P2Pos.Y = -1;
  }

  public string DumpAll()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(string.Format("SEQUENCE: {0}\n", (object) this.SEQUENCE));
    stringBuilder.Append(string.Format("SLEEPING: {0}\n", (object) (bool) (this.SLEEPING ? 1 : 0)));
    switch (this.WAITING)
    {
      case 1:
        stringBuilder.Append("WAITING: wait\n");
        break;
      case 2:
        stringBuilder.Append("WAITING: sleep\n");
        break;
      default:
        stringBuilder.Append("WAITING: none\n");
        break;
    }
    stringBuilder.Append(string.Format("START TIME: {0}\n", (object) this.START_UP));
    stringBuilder.Append(string.Format("IP: {0}\n", (object) this.IP_EP));
    stringBuilder.Append("PING: ");
    int index = 0;
    foreach (uint num in this.PONG)
    {
      stringBuilder.Append((string) (object) (uint) ((int) this.PONG[index] - (int) num) + (object) " ");
      ++index;
    }
    stringBuilder.Append("\n");
    stringBuilder.Append(string.Format("DELAY: {0}\n", (object) this.DELAY));
    stringBuilder.Append(string.Format("INTERVAL: {0}\n", (object) this.INTERVAL));
    stringBuilder.Append(string.Format("INTERVAL2: {0}\n", (object) this.INTERVAL2));
    stringBuilder.Append("SEND: ");
    foreach (byte num in this.SEND)
      stringBuilder.Append((string) (object) num + (object) " ");
    stringBuilder.Append("\n");
    stringBuilder.Append(string.Format("DELAY: {0}\n", (object) this.DELAY));
    stringBuilder.Append("LOCAL: ");
    foreach (ushort num in this.LOCAL)
      stringBuilder.Append((string) (object) num + (object) " ");
    stringBuilder.Append("\n");
    stringBuilder.Append(string.Format("L_FRAME: {0}\n", (object) this.L_FRAME));
    stringBuilder.Append(string.Format("L_READ: {0}\n", (object) this.L_READ));
    stringBuilder.Append(string.Format("R_FRAME: {0}\n", (object) this.R_FRAME));
    stringBuilder.Append(string.Format("R_READ: {0}\n", (object) this.R_READ));
    stringBuilder.Append("REMOTE: ");
    foreach (ushort num in this.REMOTE)
      stringBuilder.Append((string) (object) num + (object) " ");
    stringBuilder.Append("\n");
    return stringBuilder.ToString();
  }
}
