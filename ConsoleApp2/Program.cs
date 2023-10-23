

//36


string sentence = "My name is Alican Dağıdır";

var result = sentence.Length;
//  var result2 = sentence.Clone();
//   sentence = "My name is Can Dağıdır"
Console.WriteLine(result);
//   Console.WriteLine(result2);
Console.ReadLine();

bool result3 = sentence.EndsWith("r");
bool result4 = sentence.StartsWith("My name");
var result5 = sentence.IndexOf("name");

var result6 = sentence.IndexOf(" ");

var result7 = sentence.LastIndexOf(" ");
Console.WriteLine(result7);

var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,4);

//37

static void Main(string[] args)
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add();
    customerManager.Update();
}
    ProductManager productManager = new ProductManager();
    productManager.Add();
    productManager.Update();

    Console.ReadLine();

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }
    public void Update()
    { 
        Console.WriteLine("Customer Updated!")
    }
}
class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }
    public void Update()
    {
        Console.WriteLine("Product Updated!")
    }
}




