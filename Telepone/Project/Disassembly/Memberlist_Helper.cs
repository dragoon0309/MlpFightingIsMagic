// Type: Memberlist_Helper
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Runtime.InteropServices;

internal class Memberlist_Helper
{
  [return: MarshalAs(UnmanagedType.U1)]
  public static bool ByMemberID(MemberInfo mi, int search_id)
  {
    return (int) mi.ID == search_id;
  }
}
