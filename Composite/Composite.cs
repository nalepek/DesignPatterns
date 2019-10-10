namespace Composite
{
    /// <summary>
    /// Composite class
    /// </summary>
    public class Cola : Drink
    {
        public Cola(decimal price) : base(price) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class Pepsi : Drink
    {
        public Pepsi(decimal price) : base(price) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class Schweeppes : Drink
    {
        public Schweeppes(decimal price) : base(price) { }
    }
}