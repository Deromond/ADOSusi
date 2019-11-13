using Homework_5.Goods;
using Homework_5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Homework_5.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        ResourceDictionary Temp;
        TranslateText.Translate t = new TranslateText.Translate();
        private void SortMethod(object obj)
        {
            string sortBy = obj.ToString();

            switch (sortBy)
            {
                case "Name":
                    Eat = SortDesc ? new ObservableCollection<Susi>(Eat.OrderByDescending(x => x.Name))
                                    : new ObservableCollection<Susi>(Eat.OrderBy(x => x.Name));
                    break;
                case "Weight":
                    Eat = SortDesc ? new ObservableCollection<Susi>(Eat.OrderByDescending(x => x.Weight))
                                    : new ObservableCollection<Susi>(Eat.OrderBy(x => x.Weight));
                    break;
                case "Price":
                    Eat = SortDesc ? new ObservableCollection<Susi>(Eat.OrderByDescending(x => x.Price))
                                    : new ObservableCollection<Susi>(Eat.OrderBy(x => x.Price));
                    break;
            }
        }
        #region Commands
        RelayCommand sortCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        void Notify([CallerMemberName]string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ICommand SortCommand
        {
            get => sortCommand ?? (sortCommand = new RelayCommand(SortMethod));
        }
        #endregion
        public bool SortDesc { get; set; }
        ObservableCollection<Susi> eat;
        public ObservableCollection<Susi> Eat
        {
            get => eat;
            set
            {
                eat = value;
                Notify();
            }
        }
        public Susi SelectedSusi { get; set; }
        public ICommand Save { get; set; }
        public ICommand DeleteSusi { get; set; }
        public ICommand AddEat { get; set;}
        public ICommand TranslateRus { get; set; }
        public ICommand TranslateEng { get; set; }
        public ViewModel()
        {
            Temp = new ResourceDictionary();
            Eat = Susi.GetGoods();
            DeleteSusi = new RelayCommand(x => eat.Remove(SelectedSusi));
            AddEat = new RelayCommand(x => Eat.Add(new Susi { Name=Name, Weight=Weight, Price = Price, Image=Image }));
            Save = new RelayCommand(x => KillMePls.Save(Eat));
            TranslateRus = new RelayCommand(x => TransRus());
            TranslateEng = new RelayCommand(x => TransEng());
        }
        public string Name {get; set;}
        public uint Weight { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        #region Translate
        public string TName { get => t.name; set { t.name = value;Notify(); } }
        public string TWeight { get => t.weight; set { t.weight = value; Notify(); } }
        public string TPrice { get => t.price; set { t.price = value; Notify(); } }
        public string TImage{ get => t.image; set { t.image = value; Notify(); } }
        public string TCreate { get => t.create; set { t.create = value; Notify(); } }
        public string TUpdate { get => t.update; set { t.update = value; Notify(); } }
        public string TOption { get => t.option; set { t.option = value; Notify(); } }
        public string TDelete { get => t.delete; set { t.delete = value; Notify(); } }
        public string TTheme{ get => t.theme; set { t.theme = value; Notify(); } }
        public string TFonts{ get => t.fontsize; set { t.fontsize = value; Notify(); } }
        public string TFontc{ get => t.fontcolor; set { t.fontcolor = value; Notify(); } }
        public string TImages { get => t.imagesize; set { t.imagesize = value; Notify(); } }
        public string TDesc { get => t.desc; set { t.desc = value; Notify(); } }

        public void TransRus()
        {
            TName = "Имя";
            TWeight = "Вес";
            TPrice = "Цена";
            TImage = "Картинка";
            TCreate = "Создать";
            TUpdate = "Обновить";
            TOption = "Опции";
            TDelete = "Удалить";
            TTheme = "Тема";
            TFonts = "Размер шрифта";
            TFontc = "Цвет текста";
            TImages = "Размер картинки";
            TDesc = "По убыванию";
        }
        public void TransEng()
        {
            TName = "Name";
            TWeight = "Weight";
            TPrice = "Price";
            TImage = "Image";
            TCreate = "Create";
            TUpdate = "Update";
            TOption = "Option";
            TDelete = "Delete";
            TTheme = "Theme";
            TFonts = "Font size";
            TFontc = "Font color";
            TImages = "Image size";
            TDesc = "Descending";
        }
        #endregion
    }
}
