using CanadianHolidays.ViewModel;

namespace CanadianHolidays;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        BindingContext = new HolidaysViewModel();

    }
}


