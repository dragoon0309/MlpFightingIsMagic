// Type: MTSP.CustomRTB
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Windows.Forms;

namespace MTSP
{
  internal class CustomRTB : RichTextBox
  {
    public void ScrollToEnd()
    {
      CustomRTB customRtb = this;
      int length = customRtb.Text.Length;
      customRtb.SelectionStart = length;
      Message m = Message.Create(this.Handle, 277, (IntPtr) 7, IntPtr.Zero);
      this.WndProc(ref m);
    }
  }
}
