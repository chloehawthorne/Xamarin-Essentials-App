using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using XamarinEssentials.Model;

namespace XamarinEssentials.ViewModels
{
    public class MainPageViewModel :INotifyPropertyChanged
    {
        //ObservableCollection<ButtonModel> measurement;

        public ObservableCollection<ButtonModel> Measurement { get; set; } = new ObservableCollection<ButtonModel>();

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
          
        
    public event PropertyChangedEventHandler PropertyChanged;
    }
}
