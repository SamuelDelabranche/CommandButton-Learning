using CommandButton.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandButton.ViewModel
{
    public class MainWindowViewModel : ObservableItem
    {
        private readonly ObservableCollection<ItemViewModel> _items;
        public IEnumerable<ItemViewModel> Items => _items;

        private ItemViewModel _selectedItem;
        public ItemViewModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public MainWindowViewModel()
        {
            _items = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel(new Item("Samuel", 4561, 91)),
                new ItemViewModel(new Item("Taysir", 7845, 8)),
                new ItemViewModel(new Item("Sacha", 8924, 2))
            };
        }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => RemoveItem(), canExecute => _selectedItem != null);

        public void AddItem()
        {
            _items.Add(new ItemViewModel(new Item("", 0, 0)));
        }

        public void RemoveItem()
        {
            _items.Remove(_selectedItem);
        }
    }
}
