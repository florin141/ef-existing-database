using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AwDataLayer;

namespace AwDataLayer.Mapping
{
	public class AddressMap : EntityTypeConfiguration<Address>
	{
		public AddressMap()
		{
			// Primary Key
			this.HasKey(t => t.AddressId);

			// Properties
			this.Property(t => t.AddressLine1)
				.IsRequired()
				.HasMaxLength(60);
				
			this.Property(t => t.AddressLine2)
				.HasMaxLength(60);
				
			this.Property(t => t.City)
				.IsRequired()
				.HasMaxLength(30);
				
			this.Property(t => t.StateProvince)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.CountryRegion)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.PostalCode)
				.IsRequired()
				.HasMaxLength(15);
				
			// Table & Column Mappings
			this.ToTable("Address");
			this.Property(t => t.AddressId).HasColumnName("AddressID");
			this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
			this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.StateProvince).HasColumnName("StateProvince");
			this.Property(t => t.CountryRegion).HasColumnName("CountryRegion");
			this.Property(t => t.PostalCode).HasColumnName("PostalCode");
			this.Property(t => t.Rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

