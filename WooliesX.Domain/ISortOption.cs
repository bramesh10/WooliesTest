using System.Collections.Generic;

namespace WooliesX.Domain
{
	public interface ISortOption
	{
        IEnumerable<Product> Selected(IEnumerable<Product> Products);
	}
}
