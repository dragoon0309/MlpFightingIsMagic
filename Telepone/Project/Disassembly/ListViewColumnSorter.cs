// Type: ListViewColumnSorter
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
  public SortOrder Order;
  public int SortColumn;
  public ListViewItem listviewL;
  public ListViewItem listviewR;

  public ListViewColumnSorter(int column)
  {
    this.SortColumn = column;
    this.Order = SortOrder.None;
  }

  public ListViewColumnSorter()
  {
    this.SortColumn = 0;
    this.Order = SortOrder.None;
  }

  public virtual int Compare(object lhs, object rhs)
  {
    this.listviewL = (ListViewItem) lhs;
    this.listviewR = (ListViewItem) rhs;
    int num = string.Compare(this.listviewL.SubItems[this.SortColumn].Text, this.listviewR.SubItems[this.SortColumn].Text);
    return this.Order != SortOrder.Ascending ? (this.Order != SortOrder.Descending ? 0 : -num) : num;
  }
}
