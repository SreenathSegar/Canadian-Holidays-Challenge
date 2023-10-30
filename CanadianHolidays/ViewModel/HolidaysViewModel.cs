namespace CanadianHolidays.ViewModel;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CanadianHolidays.Model;

public class HolidaysViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Holiday> holidays;

    public ObservableCollection<Holiday> Holidays
    {
        get => holidays;
        set
        {
            holidays = value;
            OnPropertyChanged();
        }
    }

    public HolidaysViewModel()
    {
        LoadHolidays();
    }

    private void LoadHolidays()
    {
        Holidays = new ObservableCollection<Holiday>
        {
            new Holiday("New Year's Day", new DateTime(2023, 1, 1)),
            new Holiday("Family Day", new DateTime(2023, 2, 20)),
            new Holiday("Good Friday", new DateTime(2023, 4, 7)),
            new Holiday("Easter Monday", new DateTime(2023, 4, 10)),
            new Holiday("Victoria Day", new DateTime(2023, 5, 22)),
            new Holiday("Canada Day", new DateTime(2023, 7, 1)),
            new Holiday("Civic Holiday", new DateTime(2023, 8, 7)),
            new Holiday("Labour Day", new DateTime(2023, 9, 4)),
            new Holiday("Thanksgiving Day", new DateTime(2023, 10, 9)),
            new Holiday("Remembrance Day", new DateTime(2023, 11, 11)),
            new Holiday("Christmas Day", new DateTime(2023, 12, 25)),
            new Holiday("Boxing Day", new DateTime(2023, 12, 26))
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
