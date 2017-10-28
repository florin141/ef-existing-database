using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AwDataLayer;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwDataLayer.Mapping
{
	public class SalesOrderDetailMap : EntityTypeConfiguration<SalesOrderDetail>
	{
		public SalesOrderDetailMap()
		{
			// Primary Key
			this.HasKey(t => new { t.SalesOrderID, t.SalesOrderDetailID });

			// Properties
			this.Property(t => t.SalesOrderID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SalesOrderDetailID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				
			// Table & Column Mappings
			this.ToTable("SalesOrderDetail");
			this.Property(t => t.SalesOrderID).HasColumnName("SalesOrderID");
			this.Property(t => t.SalesOrderDetailID).HasColumnName("SalesOrderDetailID");
			this.Property(t => t.OrderQty).HasColumnName("OrderQty");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
			this.Property(t => t.UnitPriceDiscount).HasColumnName("UnitPriceDiscount");
			this.Property(t => t.LineTotal).HasColumnName("LineTotal");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Product)
				.WithMany(t => t.SalesOrderDetails)
				.HasForeignKey(d => d.ProductID);
				
			this.HasRequired(t => t.SalesOrderHeader)
				.WithMany(t => t.SalesOrderDetails)
				.HasForeignKey(d => d.SalesOrderID);
				
		}
	}
}

