using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Entity
    {
        public int Id;
        public int ParentId;
        public string Name;
        public static Dictionary<int, List<Entity>> ToDictionary(List<Entity> list)
        {
            var dict = list
                .GroupBy(item => item.ParentId)
                .ToDictionary(g => g.Key, g => g.ToList());

            return dict;
        }
    }
}
