using System.Security.AccessControl;
using gft_4_dotNET_series_register_project.Enum;

namespace gft_4_dotNET_series_register_project.Classes;

public class Streams : BaseEntities
{
    private Genres Genre { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Date { get; set; }

    private bool Removed { get; set; }

    public Streams(int id, Genres genre, string title, string description, int date)
    {
        this.Id = id;
        this.Genre = genre;
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Removed = false;
    }

    public override string ToString()
    {
        string returnString = "";
        returnString += "Genre: " + this.Genre + Environment.NewLine;
        returnString += "Title: " + this.Title + Environment.NewLine;
        returnString += "Description: " + this.Description + Environment.NewLine;
        returnString += "Date: " + this.Date + Environment.NewLine;
        return returnString;

    }

    public string ReturnTitle()
    {
        return this.Title;
    }

    public int ReturnId()
    {
        return this.Id;
    }

    public void Remove()
    {
        this.Removed = true;
    }
    
}