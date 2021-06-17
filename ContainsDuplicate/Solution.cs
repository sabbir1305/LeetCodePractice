using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Solution
    {
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    var hashtable = new Hashtable();
        //    foreach (var item in nums)
        //    {
        //        if (hashtable.ContainsKey(item))
        //            return true;
        //        hashtable.Add(item, item);
        //    }
        //    return false;

        //}
        public bool ContainsDuplicate(int[] nums)
        {
            var hasSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (hasSet.Contains(item))
                    return true;
                hasSet.Add(item);
            }
            return false;

        }
    }
}
