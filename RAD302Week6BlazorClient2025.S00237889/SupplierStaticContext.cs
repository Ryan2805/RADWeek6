using Rad302Week6Lab2025.DataModel.S00237889;

namespace RAD302Week6BlazorClient2025.S00237889
{
    public class SupplierStaticContext
    {
        public static Supplier CurrentSupplier { get; set; }
        public static Product[] Products { get; set; }
        public static Supplier[] Suppliers { get; set; }
        public static Supplier GetNewSupplier(int supplierID)
        {
            return CurrentSupplier = Suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
        }
    }

}