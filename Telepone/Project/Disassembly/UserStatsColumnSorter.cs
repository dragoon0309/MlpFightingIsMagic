// Type: UserStatsColumnSorter
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Windows.Forms;

public class UserStatsColumnSorter : ListViewColumnSorter
{
  public override int Compare(object lhs, object rhs)
  {
    this.listviewL = (ListViewItem) lhs;
    this.listviewR = (ListViewItem) rhs;
    string text1 = this.listviewL.SubItems[this.SortColumn].Text;
    string text2 = this.listviewR.SubItems[this.SortColumn].Text;
    int num1;
    if (text1 == "" && text2 != "")
      num1 = -1;
    else if (text2 == "" && text1 != "")
      num1 = 1;
    else if (text1 == "" && text2 == "")
    {
      num1 = 0;
    }
    else
    {
      int num2;
      switch (this.SortColumn)
      {
        case 0:
        case 1:
          num2 = string.Compare(text1, text2);
          break;
        case 2:
        case 3:
          int num3 = int.Parse(text1);
          int num4 = int.Parse(text2);
          num2 = num3 <= num4 ? -1 : 1;
          if (num3 == num4)
          {
            num2 = 0;
            break;
          }
          else
            break;
        case 4:
          DateTime t2 = DateTime.Parse(text2);
          num2 = DateTime.Compare(DateTime.Parse(text1), t2);
          break;
        case 6:
          string[] separator = new string[2]
          {
            " ",
            "/"
          };
          string[] strArray1 = text1.Split(separator, StringSplitOptions.RemoveEmptyEntries);
          string[] strArray2 = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
          int num5 = int.Parse(strArray1[0]);
          int.Parse(strArray1[1]);
          int num6 = int.Parse(strArray2[0]);
          int.Parse(strArray2[1]);
          num2 = num5 <= num6 ? -1 : 1;
          if (num5 == num6)
          {
            num2 = 0;
            break;
          }
          else
            break;
        default:
          num2 = 0;
          break;
      }
      num1 = this.Order != SortOrder.Ascending ? (this.Order != SortOrder.Descending ? 0 : -num2) : num2;
    }
    return num1;
  }
}
