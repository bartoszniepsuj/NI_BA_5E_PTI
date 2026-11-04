using NotatkiMobilne.Models;
using NotatkiMobilne.PageModels;
using System.Collections.ObjectModel;

namespace NotatkiMobilne.Pages
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notatki { get; set; }
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;

            Notatki = new ObservableCollection<string>
            {
                "Kupić mleko i chleb",
                "Wymienić olej w samochodzie",
                "Trening na siłowni o 18:00"
            };
            NotatkiListView.ItemsSource = Notatki;

           

        }
        private void OnPrzyciskDodajClicked(object sender, EventArgs e)
        {
            string nowaNotatka = NotatkiEntry.Text?.Trim();

            if (!string.IsNullOrEmpty(nowaNotatka))
            {
                Notatki.Add(nowaNotatka);
                NotatkiEntry.Text = string.Empty; 
            }
        }
    }
}