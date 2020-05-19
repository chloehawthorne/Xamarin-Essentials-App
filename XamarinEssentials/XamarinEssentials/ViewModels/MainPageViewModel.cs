using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinEssentials.Model;

namespace XamarinEssentials.ViewModels
{
    public class MainPageViewModel :INotifyPropertyChanged
    {
        //ObservableCollection<ButtonModel> measurement;

        public ObservableCollection<ButtonModel> ButtonsList { get; set; } = new ObservableCollection<ButtonModel>();

        ButtonModel selectedButton;

        public ButtonModel SelectedButton
        {
            get
            {
                return selectedButton;
            }
            set
            {
                if (selectedButton !=value)
                {
                    selectedButton = value;
                }
            }
        }
          
        public MainPageViewModel()
        {

        }

        public void CreateButtons()
        {
            ObservableCollection<ButtonModel> buttons = new ObservableCollection<ButtonModel>();

            buttons.Add(new ButtonModel() { Name = $"{convertToEnum}" })
        }
    public event PropertyChangedEventHandler PropertyChanged;
    }
}
