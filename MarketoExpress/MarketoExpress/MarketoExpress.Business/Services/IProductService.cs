using MarketoExpress.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketoExpress.Business.Services
{
	public interface IProductService
	{
		void AddProduct(AddProductDto addProductDto);
		List<ListProductDto> GetProducts();
		List<ListProductDto> GetProductsByCategoryId(int? categoryId);
		UpdateProductDto GetProductById(int id);
        void UpdateProduct(UpdateProductDto updateProductDto);
		void DeleteProduct(int id);

    }
}
