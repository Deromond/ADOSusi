using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5.TranslateText
{
    class Translate: INotifyPropertyChanged
    {
        public string name = "Name";
        public string weight = "Weight";
        public string price = "Price";
        public string image = "Image";
        public string create = "Create";
        public string update = "Update";
        public string delete = "Delete";
        public string option = "Option";
        public string fontsize = "Fontsize";
        public string fontcolor = "Fontcolor";
        public string imagesize = "Imagesize";
        public string theme = "Theme";
        public string desc = "Descending";

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
