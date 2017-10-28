using System;
using System.Collections.Generic;

namespace AwDataLayer
{
	public class Product
	{
	    public Product()
		{
			this.SalesOrderDetails = new List<SalesOrderDetail>();
		}

		public string NewProp { get; set; }
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string ProductNumber { get; set; }
		public string Color { get; set; }
		public decimal StandardCost { get; set; }
		public decimal ListPrice { get; set; }
		public string Size { get; set; }
		public Nullable<decimal> Weight { get; set; }
		public Nullable<int> ProductCategoryID { get; set; }
		public Nullable<int> ProductModelID { get; set; }
		public DateTime SellStartDate { get; set; }
		public Nullable<DateTime> SellEndDate { get; set; }
		public Nullable<DateTime> DiscontinuedDate { get; set; }
		public byte[] ThumbNailPhoto { get; set; }
		public string ThumbnailPhotoFileName { get; set; }
		public System.Guid rowguid { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual ProductCategory ProductCategory { get; set; }
		public virtual ProductModel ProductModel { get; set; }
		public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
	}
}

