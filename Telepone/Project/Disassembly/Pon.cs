// Type: Pon
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Drawing;

internal class Pon
{
  public static int BR_ADJUST = 1710618;

  static Pon()
  {
  }

  public static Color GetMainColor(FAVORITE_PONY favpon)
  {
    FAVORITE_PONY favoritePony = favpon;
    --favoritePony;
    Color color;
    switch (favoritePony)
    {
      case (FAVORITE_PONY) 0:
        color = Color.FromArgb(16087096 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 1:
        color = Color.FromArgb(15683217 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 2:
        color = Color.FromArgb(11385022 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 3:
        color = Color.FromArgb(10119343 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 4:
        color = Color.FromArgb(14924072 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 5:
        color = Color.FromArgb(6987226 - Pon.BR_ADJUST);
        break;
      default:
        color = Color.Black;
        break;
    }
    return color;
  }

  public static Color GetSecondaryColor(FAVORITE_PONY favpon)
  {
    FAVORITE_PONY favoritePony = favpon;
    --favoritePony;
    Color color;
    switch (favoritePony)
    {
      case (FAVORITE_PONY) 0:
        color = Color.FromArgb(15324768 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 1:
        color = Color.FromArgb(15105461 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 2:
        color = Color.FromArgb(7750292 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 3:
        color = Color.FromArgb(3554163 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 4:
        color = Color.FromArgb(15105715 - Pon.BR_ADJUST);
        break;
      case (FAVORITE_PONY) 5:
        color = Color.FromArgb(15614005 - Pon.BR_ADJUST);
        break;
      default:
        color = Color.Black;
        break;
    }
    return color;
  }
}
