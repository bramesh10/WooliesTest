using System;
using System.Collections.Generic;
using System.Linq;

namespace WooliesX.Domain
{
	public class SortByDescendingName : ISortOption
	{
		public IEnumerable<Product> Selected(IEnumerable<Product> Products)
		{
			if (Products == null) throw new ArgumentNullException(nameof(Products));

			return Products.OrderByDescending(p => p.name).ToList();
		}
	}
}
