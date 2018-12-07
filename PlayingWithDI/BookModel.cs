
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class root
{

    private BookModel[] rowField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("row")]
    public BookModel[] row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class BookModel
{

    private string titleField;

    private string authorField;

    private string genreField;

    private string subGenreField;

    private int heightField;

    private string publisherField;

    public BookModel(string title, string author, string genre, string subGenre, int height, string publisher)
    {
        Title = title;
        Author = author;
        Genre = genre;
        SubGenre = subGenre;
        Height = height;
        Publisher = publisher;
    }

    /// <remarks/>
    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string Author
    {
        get
        {
            return this.authorField;
        }
        set
        {
            this.authorField = value;
        }
    }

    /// <remarks/>
    public string Genre
    {
        get
        {
            return this.genreField;
        }
        set
        {
            this.genreField = value;
        }
    }

    /// <remarks/>
    public string SubGenre
    {
        get
        {
            return this.subGenreField;
        }
        set
        {
            this.subGenreField = value;
        }
    }

    /// <remarks/>
    public int Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    public string Publisher
    {
        get
        {
            return this.publisherField;
        }
        set
        {
            this.publisherField = value;
        }
    }
}

