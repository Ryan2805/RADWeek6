using Microsoft.AspNetCore.Components;
using Rad302Week6Lab2025.DataModel.S00237889;
using System.Net.Http.Json;

namespace RAD302Week6BlazorClient2025.S00237889.Pages
{
    public partial class SupplierView
    {

        [Inject]
        HttpClient Http { get; set; }

        private Supplier[] suppliers;
        private Product[] products;



        protected override async Task OnInitializedAsync()
        {
            if (SupplierStaticContext.Suppliers == null)
            {
                SupplierStaticContext.Suppliers =
                        suppliers = await Http.GetFromJsonAsync<Supplier[]>("sample-data/Supplier.json");
                SupplierStaticContext.Products = products = await Http.GetFromJsonAsync<Product[]>("sample-data/Product.json");
                InitialiseSupplierProducts();
            }
            else
            {
                suppliers = SupplierStaticContext.Suppliers;
            }
            await base.OnInitializedAsync();
        }

        private void InitialiseSupplierProducts()
        {
            foreach (var item in suppliers)
            {
                List<Product> toadd =
                    products.OrderBy(o => new Random().Next(2372))
                    .Take(3).ToList();
                item.SupplierProducts = new List<Product>();
                item.SupplierProducts.AddRange(toadd);


            }

        }
    }

}
