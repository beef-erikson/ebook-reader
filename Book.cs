/// Book class - used to define properties of the book the pdf is based off of.

public class Book 
{
    
    #region Properties

    // Title
    private string title;
    public string Title
    {
        get { return title;}
        set { title = value;}
    }

    // Creation date
    private string creationDate;
    public string CreationDate
    {
        get { return creationDate;}
        set { creationDate = value;}
    }
    
    // Creator
    private string creator;
    public string Creator
    {
        get { return creator;}
        set { creator = value;}
    }

    // Producer
    private string producer;
    public string Producer
    {
        get { return producer;}
        set { producer = value;}
    }
    
    // Subject
    private string subject;
    public string Subject
    {
        get { return subject;}
        set { subject = value;}
    }
    
    // Keywords
    private string keywords;
    public string Keywords
    {
        get { return keywords;}
        set { keywords = value;}
    }
    
    // Last Modified
    private string lastModified;
    public string LastModified
    {
        get { return lastModified;}
        set { lastModified = value;}
    }
    
    #endregion

    #region Constructors

    public Book() 
    {
    }

    public Book(string title)
    {
        this.title = title;
    }

    #endregion

    #region Methods

    #endregion
}