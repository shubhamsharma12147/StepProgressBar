using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {

        private List<ImageSource> sources;

        public List<ImageSource> SelectedImageList
        {
            get { return sources; }
            set
            {
                sources = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
        InitializeComponent();
            BindingContext = this;
        
    }
}
