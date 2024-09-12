using CommandButton.Model;

namespace CommandButton.ViewModel
{
    public class ItemViewModel : ObservableItem
    {
        private readonly Item _item;

		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		private string _serialNumber;
		public string SerialNumber
		{
			get
			{
				return _serialNumber;
			}
			set
			{
				_serialNumber = value;
				OnPropertyChanged(nameof(SerialNumber));
			}
		}

		private string _quantity;
		public string Quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				_quantity = value;
				OnPropertyChanged(nameof(Quantity));
			}
		}

		public ItemViewModel(Item item)
        {
            _item = item;
			_name = _item.Name;
			_serialNumber = _item.SerialNumber.ToString();
			_quantity = _item.Quantiry.ToString();
        }
    }
}