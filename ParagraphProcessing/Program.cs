public class OutputString
{
    public string[] ModifyParagraph(string paragraph)
    {
        string updatedParagraph = paragraph.Replace("Javascript", "javascript"); // replaces "Javascript" with "javascript"
        string[] sentences = updatedParagraph.Split('.').ToArray(); // splits every sentence by the period character


        foreach (string sentence in sentences) // iterates through each sentence in the array
        {
            Console.WriteLine(sentence); // displays each sentence to the console

        }
        return sentences; // completes the method by returning the sentences in the array
    }

    public static void Main()
    {
        string paragraph = "Lodash is a JavaScript library that helps programmers write more concise and maintainable JavaScript. It can be broken down into several main areas: Utilities - for simplifying common programming tasks such as determining type as well as simplifying math operations.";
        var processor = new OutputString(); // creates an instance of the outputString class
        string[] result = processor.ModifyParagraph(paragraph); // calls and applies the ModifyParagraph method onn the string paragraph
    }
}
