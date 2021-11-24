using MyToDo.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MyToDo.ViewModels
{
    public class MainPageViewModel
    {
        INavigationService _navigationService;
        public ObservableCollection<TextValue> ItemList { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            

        

        ItemList = new ObservableCollection<TextValue>();
            ItemList.Add(new TextValue { Text = "First text" });
            ItemList.Add(new TextValue { Text = "Second text" });
            ItemList.Add(new TextValue { Text = "Third text" });
            ItemList.Add(new TextValue { Text = "Fourth text" });
        }

        public void SelectedValue(TextValue value)
        {
            string Text = value.Text;

            var navigationParameters = new NavigationParameters
            {
                {"Title", Text  }
            };

            _navigationService.NavigateAsync("EditPage", navigationParameters);
        }
    }
}
