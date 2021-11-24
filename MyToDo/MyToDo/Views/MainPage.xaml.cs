
using MyToDo.Model;
using MyToDo.ViewModels;
using Xamarin.Forms;

namespace MyToDo.Views
{
    public partial class MainPage

    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem == null)
                return;

            (BindingContext as MainPageViewModel).SelectedValue((TextValue)((ListView)sender).SelectedItem);
            ((ListView)sender).SelectedItem = null;
        }
    }
}
