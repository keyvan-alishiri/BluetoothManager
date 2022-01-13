using System.Collections.ObjectModel;
using DeviceManagment.MVVM;
using MahApps.Metro.IconPacks;

namespace DeviceManagment.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private ObservableCollection<MenuItemViewModel> _menuItems;
        private ObservableCollection<MenuItemViewModel> _menuOptionItems;

        public MainViewModel()
        {
            this.CreateMenuItems();
        }

        public void CreateMenuItems()
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>
            {
                new PrinterViewModel(this)
                {
                    Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Printer },
                    Label = "Devices and Printers",
                    ToolTip = "Devices and Printers"
                },
                new CustomViewModel(this)
                {
                    Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.BluetoothSettings },
                    Label = "Custome Device Paring",
                    ToolTip = "Custome Device Paring"
                },
                new BasicViewModel(this)
                {
                    Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Bluetooth },
                    Label = "Basic Device Paring",
                    ToolTip = "Basic Device Paring"
                }
            };

            //MenuOptionItems = new ObservableCollection<MenuItemViewModel>
            //{
            //    new SettingsViewModel(this)
            //    {
            //        Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Cog },
            //        Label = "Settings",
            //        ToolTip = "The App settings"
            //    }
            //};
        }

        public ObservableCollection<MenuItemViewModel> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }

        public ObservableCollection<MenuItemViewModel> MenuOptionItems
        {
            get => _menuOptionItems;
            set => SetProperty(ref _menuOptionItems, value);
        }
    }
}