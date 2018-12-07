using System;
using System.Collections.Generic;
using System.Text;


public class Rootobject
{
    public BookModelJson[] Property1 { get; set; }
}

public class BookModelJson
{
    public string Title { get; set; }
    public object Author { get; set; }
    public string Genre { get; set; }
    public string SubGenre { get; set; }
    public string Height { get; set; }
    public object Publisher { get; set; }
}
