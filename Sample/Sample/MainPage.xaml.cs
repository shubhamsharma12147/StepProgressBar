using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {

        private List<ImageSource> selectlist;

        public List<ImageSource> SelectedImageList
        {
            get { return selectlist; }
            set
            {
                selectlist = value;
                OnPropertyChanged();
            }
        }
        private List<ImageSource> unSelectedImageList;

        public List<ImageSource> UnSelectedImageList
        {
            get { return unSelectedImageList; }
            set { unSelectedImageList = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            SelectedImageList = new List<ImageSource>()
            {
                "Star.png",
                "Star.png",
                "Star.png",
                "Star.png",
                "Star.png"
            };
            UnSelectedImageList = new List<ImageSource>
            {
                "Star_blank",
                "Star_blank",
                "Star_blank",
                "Star_blank",
                "Star_blank",
                "Star_blank",
            };

        }

        private void StepProgressBar_TabEventHandler(object sender, StepProgressBar.Views.TabEventArgs e)
        {
            var index = e.TabIndex;
        }
    }
}
