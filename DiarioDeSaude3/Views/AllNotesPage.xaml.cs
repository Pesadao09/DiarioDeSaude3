using DiarioDeSaude3.Models;
namespace DiarioDeSaude3.Views;


public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();

		BindingContext = new AllNotes();
	}

	protected override void OnAppearing()
	{
		((Models.AllNotes)BindingContext).LoadNotes();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private async void ItemAdd_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(NotePage));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if (e.CurrentSelection.Count != 0 )
		{
			var note = (Note)e.CurrentSelection[0];
			await Shell.Current.GoToAsync($"{nameof(NotePage)}?{nameof(NotePage.ItemId)}={note.Filename}");

			notesCollection.SelectedItems = null;
		}
    }
}