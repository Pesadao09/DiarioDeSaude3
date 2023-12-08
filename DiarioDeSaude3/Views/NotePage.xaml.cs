using DiarioDeSaude3.Models;
using Microsoft.Maui.Storage;

namespace DiarioDeSaude3.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NotePage : ContentPage

{
    public string ItemId
    {
        set
        {
            LoadNote(value);
        }
    }
    //string fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");


    public NotePage()
    {
        InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
        
    }

    private void LoadNote(string fileName)
    {
        Note note = new Note();
        note.Filename = fileName;

        if (File.Exists(fileName))
        {
            note.Date = File.GetCreationTime(fileName);
            note.Text = File.ReadAllText(fileName);
        }
        BindingContext = note;
    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Note note)
        {
            File.WriteAllText(note.Filename, TextEditor.Text);
        }
        
        {
            await Shell.Current.GoToAsync("..");

        }
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {

        if(BindingContext is Note note)
        {
            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

        
        }
        await Shell.Current.GoToAsync("..");
        //TextEditor.Text = string.Empty;
    }
}




    

    






