namespace WooliesX.Domain
{
	public class SimpleSortFactory
	{
		public static ISortOption Create(SortOption sortOption)
		{
			switch (sortOption)
			{
				case SortOption.Low: return new SortByLowerPrice();
				case SortOption.High: return new SortByHigherPrice();
				case SortOption.Ascending: return new SortByAscendingName();
				case SortOption.Descending: return new SortByDescendingName();
				case SortOption.Recommended: return new SortByMostRecommended();
			}
			return null;
		}
	}

}
