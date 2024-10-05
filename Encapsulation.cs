public class Scripture
{
    private string text;        // Private attribute
    private string reference;   // Private attribute

    // Constructor to initialize the scripture
    public Scripture(string text, string reference)
    {
        this.text = text;      // Setting the text attribute
        this.reference = reference; // Setting the reference attribute
    }

    // Public method to access the text attribute
    public string GetText()      
    {
        return text;            // Returns the scripture text
    }

    // Public method to access the reference attribute
    public string GetReference() 
    {
        return reference;       // Returns the scripture reference
    }
}
