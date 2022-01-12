// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


List<Author> a1 = new List<Author> ();
List <int> IDs = new List<int> ();
List <string> names = new List<string> { "Dayat", "Saul", "Kasmin", "Erwin", "Qomarr"};

for (int i = 0; i < names.Count; i++) {

    IDs.Add(i);
}

for (int i = 0; i < names.Count; i++)
{
    a1.Add (new Author { ID = IDs[i].ToString(), Name = names[i] });
}

Console.WriteLine("Before removal\n");

foreach (Author item in a1)
{
    Console.WriteLine (item.Name+" -- "+item.ID);
}

foreach (Author item in a1)
{
    if (item.ID == "1")
    {
        a1.Remove (item);
        break;
        //continue;

    }
}

Console.WriteLine("\nAFTER removal");

foreach (Author item in a1)
{
    Console.WriteLine(item.Name + " -- " + item.ID);
}




public class Author
{
    public string Name { get; set; }
    public string ID { get; set; }
}