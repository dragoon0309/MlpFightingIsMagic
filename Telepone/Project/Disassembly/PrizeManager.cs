// Type: PrizeManager
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

public class PrizeManager
{
  public List<Prize> m_PrizeList;
  public List<string> m_Characters;
  public List<string> m_Adjectives;
  public List<string> m_Nouns;
  public bool m_PrizesLoaded;
  public uint LastPrizeGenerateTime;

  public PrizeManager()
  {
    this.m_PrizeList = new List<Prize>();
    this.m_Characters = new List<string>();
    this.m_Adjectives = new List<string>();
    this.m_Nouns = new List<string>();
    this.LoadPrizes("./files/misc/artifacts.txt");
    PrizeManager prizeManager1 = this;
    List<string> list1 = prizeManager1.m_Characters;
    string path1 = "./files/misc/chr.txt";
    prizeManager1.LoadList(list1, path1);
    PrizeManager prizeManager2 = this;
    List<string> list2 = prizeManager2.m_Adjectives;
    string path2 = "./files/misc/adj.txt";
    prizeManager2.LoadList(list2, path2);
    PrizeManager prizeManager3 = this;
    List<string> list3 = prizeManager3.m_Nouns;
    string path3 = "./files/misc/n.txt";
    prizeManager3.LoadList(list3, path3);
    this.LastPrizeGenerateTime = 0U;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool LoadList(List<string> list, string path)
  {
    string str1 = (string) null;
    FileStream fileStream = (FileStream) null;
    bool flag = false;
    try
    {
      fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
      StreamReader streamReader = new StreamReader((Stream) fileStream);
      str1 = (string) null;
      while (true)
      {
        string str2 = streamReader.ReadLine();
        if (str2 != (string) null)
          list.Add(str2);
        else
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
    }
    finally
    {
      if (fileStream != null)
        fileStream.Close();
    }
    return flag;
  }

  public int LoadPrizes(string path)
  {
    string str1 = (string) null;
    string str2 = (string) null;
    string str3 = (string) null;
    FileStream fileStream = (FileStream) null;
    try
    {
      fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
      StreamReader streamReader = new StreamReader((Stream) fileStream);
      str1 = (string) null;
      str2 = (string) null;
      str3 = streamReader.ReadLine();
      while (true)
      {
        string str4 = streamReader.ReadLine();
        if (str4 != (string) null)
        {
          string str5 = streamReader.ReadLine();
          if (!(str5 == (string) null))
          {
            this.m_PrizeList.Add(new Prize()
            {
              PrizeName = str4,
              Owner = str5
            });
            this.m_PrizesLoaded = true;
          }
          else
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
    }
    finally
    {
      if (fileStream != null)
        fileStream.Close();
    }
    return this.m_PrizeList.Count;
  }

  public void SavePrizes(string path)
  {
    if (this.m_PrizeList.Count < 1)
      return;
    FileStream fileStream = (FileStream) null;
    try
    {
      fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
      StreamWriter streamWriter = new StreamWriter((Stream) fileStream);
      streamWriter.WriteLine("1");
      List<Prize>.Enumerator enumerator = this.m_PrizeList.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Prize current = enumerator.Current;
        streamWriter.WriteLine(current.PrizeName);
        streamWriter.WriteLine(current.Owner);
      }
      streamWriter.Flush();
    }
    catch (Exception ex)
    {
    }
    finally
    {
      if (fileStream != null)
        fileStream.Close();
    }
  }

  public Prize GeneratePrize(string owner)
  {
    Prize prize1;
    if (this.m_Characters.Count < 1 || this.m_Adjectives.Count < 1 || this.m_Nouns.Count < 1)
    {
      prize1 = (Prize) null;
    }
    else
    {
      Module.timeGetTime();
      Prize prize2;
      try
      {
        Random random = new Random((int) Module.timeGetTime());
        string str1 = this.m_Characters[random.Next(this.m_Characters.Count - 1)];
        string str2 = this.m_Adjectives[random.Next(this.m_Adjectives.Count - 1)];
        string str3 = this.m_Nouns[random.Next(this.m_Nouns.Count - 1)];
        prize1 = new Prize()
        {
          Owner = owner,
          PrizeName = str1 + " " + str2 + " " + str3
        };
        goto label_6;
      }
      catch (Exception ex)
      {
        prize2 = (Prize) null;
      }
      prize1 = prize2;
    }
label_6:
    return prize1;
  }

  public void AddPrize(Prize prize)
  {
    this.m_PrizeList.Add(prize);
  }

  public int CountOwnersItems(string owner)
  {
    int num = 0;
    List<Prize>.Enumerator enumerator = this.m_PrizeList.GetEnumerator();
    while (enumerator.MoveNext())
    {
      if (enumerator.Current.Owner == owner)
        ++num;
    }
    return num;
  }
}
