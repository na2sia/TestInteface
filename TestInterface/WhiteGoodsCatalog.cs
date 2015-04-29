using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
   public class WhiteGoodsCatalog: ICollection<IWhiteGoods>
   {
       private ICollection<IWhiteGoods> whiteGoods = new List<IWhiteGoods>();
       #region ICollection<IWhiteGoods>
       public void Add(IWhiteGoods item)
        {
            whiteGoods.Add(item);
        }

        public void Clear()
        {
            whiteGoods.Clear();
        }

        public bool Contains(IWhiteGoods item)
        {
           return whiteGoods.Contains(item);
        }

        public void CopyTo(IWhiteGoods[] array, int arrayIndex)
        {
            whiteGoods.CopyTo(array,arrayIndex);
        }

        public int Count
        {
            get { return whiteGoods.Count; }
        }

        public bool IsReadOnly
        {
            get { return whiteGoods.IsReadOnly; }
        }

        public bool Remove(IWhiteGoods item)
        {
            return whiteGoods.Remove(item);
        }

        public IEnumerator<IWhiteGoods> GetEnumerator()
        {
            return whiteGoods.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
       #endregion
        protected void Sort(IComparer<IWhiteGoods> comparer)
        {
            var newList = whiteGoods.ToList();
            newList.Sort(comparer);
            whiteGoods = newList;
        }
        public void SortByPrice()
        {
            this.Sort(new ComparerByPrice());
        }

        public void SortByClassEnergy()
        {
            this.Sort(new ComparerByClassEnergy());
        }

        public void SortByCreationDate()
        {
            this.Sort(new ComparerByYearP());
        }

        public IEnumerable<IWhiteGoods> GetWhiteGoods(DateTime startYaer, DateTime endYear)
        {
            foreach (var i in whiteGoods)
            {
                if (i.DateProduction >= startYaer && i.DateProduction <= endYear)
                {
                    yield return i;
                }
            }
        }
        public IEnumerable<IWhiteGoods> GetWhiteGoods(double startPrice, double endPrice)
        {
            foreach (var i in whiteGoods)
            {
                if (i.Price >= startPrice && i.Price <= endPrice)
                {
                    yield return i;
                }
            }
        }
   }
}
