﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WooliesX.Domain
{
	public class SortByLowerPrice : ISortOption
	{
		public IEnumerable<Product> Selected(IEnumerable<Product> Products)
		{
			if (Products == null) throw new ArgumentNullException(nameof(Products));

			return Products.OrderBy(p => p.price).ToList();
		}
	}
}
