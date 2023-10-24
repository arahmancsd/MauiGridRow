using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}


public sealed partial class MainPageViewModel : ObservableObject
{
	public ObservableCollection<Person> People { get; private set; } = [];

	public MainPageViewModel()
	{
		AddPersons();
	}

	private void AddPersons()
	{
		for (int index = 1; index < 100; index++)
		{
			People.Add(new Person() { Id = index, Name = $"Random Person {index}" });
		}
	}
}


public sealed record Person
{
	public int Id { get; init; }
	public string Name { get; init; }
}