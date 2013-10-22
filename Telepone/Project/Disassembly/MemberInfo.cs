// Type: MemberInfo
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Net;

public class MemberInfo
{
  public IPEndPoint IP_EP;
  public string NAME;
  public string COMMENT;
  public string LOOKINGFOR;
  public string NOTLOOKING;
  public PLAYER_REGION REGION;
  public ushort ID;
  public uint TYPE;
  public uint STATE;
  public uint NUM_VS;
  public uint VERSION;
  public uint RESPONSE;
  public FAVORITE_PONY FAVPON;
  public uint SILENTPINGTIME;
  public ulong SECURITYCODE;
  public uint SEEKING;

  public MemberInfo()
  {
    this.FAVPON = (FAVORITE_PONY) 0;
    this.SEEKING = 0U;
    this.NAME = string.Empty;
    this.COMMENT = string.Empty;
    this.LOOKINGFOR = string.Empty;
    this.NOTLOOKING = string.Empty;
    this.REGION = PLAYER_REGION.NODATA;
    this.SILENTPINGTIME = Module.timeGetTime();
    this.SECURITYCODE = ulong.MaxValue;
  }
}
