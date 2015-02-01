namespace Company
{
    using System.Collections;

    public interface ISalesEmployee
    {
        IList Sales { get; }
        void AddSale(Sale s);
    }
}
