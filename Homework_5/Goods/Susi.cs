using Homework_5;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_5.Goods
{
    class Susi
    {
        
        
        public string Name { get; set; }
        public uint Weight { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public static ObservableCollection<Susi> GetGoods()
        {
            return KillMePls.Set();
        }
        public override string ToString() => $"{Name} {Weight} {Price} {Image}";
    }
}
