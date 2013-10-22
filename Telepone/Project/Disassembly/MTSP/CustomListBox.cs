// Type: MTSP.CustomListBox
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Windows.Forms;

namespace MTSP
{
  public class CustomListBox : ListBox
  {
    public CustomListBox()
    {
      // ISSUE: fault handler
      try
      {
        this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      }
      __fault
      {
        this.Dispose(true);
      }
    }
  }
}
