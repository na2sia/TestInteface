using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
   public class TV: WhiteGoods, ICollection<ITV>
    {
       private ICollection<ITV> tvGoods = new List<ITV>();
       public ScreenType ScreenType { get; set; }
       public int ScreenSize { get; set; }
       public HDFormat HDFormat { get; set; }
       #region
       public void Add(ITV item)
       {
           tvGoods.Add(item);
       }

       public void Clear()
       {
           tvGoods.Clear();
       }

       public bool Contains(ITV item)
       {
           return tvGoods.Contains(item);
       }

       public void CopyTo(ITV[] array, int arrayIndex)
       {
           tvGoods.CopyTo(array,arrayIndex);
       }

       public int Count
       {
           get { return tvGoods.Count; }
       }

       public bool IsReadOnly
       {
           get { return IsReadOnly; }
       }

       public bool Remove(ITV item)
       {
           return tvGoods.Remove(item);
       }

       public IEnumerator<ITV> GetEnumerator()
       {
          return tvGoods.GetEnumerator();
       }

       System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
       {
           return this.GetEnumerator();
       }
       #endregion
    }
}
