using Homework_5.Goods;
using Homework_5.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class KillMePls
    {
        public static ObservableCollection<Susi> Set()
        {
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.Auto;
            string str = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\susi.json");
            return JsonConvert.DeserializeObject<ObservableCollection<Susi>>(str, set);
        }
        public static void Save(ObservableCollection<Susi> s)
        {
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\susi.json", JsonConvert.SerializeObject(s));
        }
    }
}
