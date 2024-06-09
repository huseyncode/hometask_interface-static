class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Yeni məhsullar yaradırıq
        Product product1 = new Product("Laptop", 1500m, ProductType.Electronics);
        Product product2 = new Product("T-shirt", 20m, ProductType.Clothing);
        Product product3 = new Product("Harry Potter", 10m, ProductType.Books);
        Product product4 = new Product("Apple", 1m, ProductType.Groceries);

        // Yeni bir məhsul kataloqu yaradırıq
        ProductCatalog catalog = new ProductCatalog();

        // Məhsulları kataloqa əlavə edirik
        catalog.Add(product1);
        catalog.Add(product2);
        catalog.Add(product3);
        catalog.Add(product4);

        // Bütün məhsulları göstəririk
        List<Product> allProducts = catalog.GetAll();
        Console.WriteLine("Bütün məhsullar:");
        foreach (Product product in allProducts)
        {
            Console.WriteLine($"Adı: {product.Name}, Qiyməti: {product.Price}, Növü: {product.Type}");
        }

        // Yalnız elektronika məhsullarını göstəririk
        List<Product> electronics = catalog.GetAllProductsByType(ProductType.Electronics);
        Console.WriteLine("\nElektronika məhsulları:");
        foreach (Product product in electronics)
        {
            Console.WriteLine($"Adı: {product.Name}, Qiyməti: {product.Price}, Növü: {product.Type}");
        }
    }
}

public enum ProductType
{
    Electronics,
    Clothing,
    Books,
    Groceries
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }

    public Product(string name, decimal price, ProductType type)
    {
        Name = name;
        Price = price;
        Type = type;
    }
}

public class ProductCatalog
{
    private List<Product> products = new List<Product>();

    public void Add(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public List<Product> GetAllProductsByType(ProductType type)
    {
        return products.Where(p => p.Type == type).ToList();
    }
}
