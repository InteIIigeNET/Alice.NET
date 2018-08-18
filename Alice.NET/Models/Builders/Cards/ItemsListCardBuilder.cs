using System;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class ItemsListCardBuilder : BaseBuilder<ItemsListCard>, IItemsListCardBuilder
	{
		private readonly IHeaderBuilder _delaultHeaderBuilder;
		private readonly IFooterBuilder _delaultFooterBuilder;

		public ItemsListCardBuilder Create(params ImageCard[] cardItems)
		{
			foreach (var image in cardItems)
			{
				image.Type = null;
			}
			BuildingModel = new ItemsListCard() {CardItems = cardItems};
			return this;
		}

		public ItemsListCardBuilder WithHeader(Header header)
		{
			BuildingModel.Header = header;
			return this;
		}

		public ItemsListCardBuilder WithHeader(Func<IHeaderBuilder, Header> headerBuildFunc, 
											   IHeaderBuilder builder = null)
		{
			builder = builder ?? _delaultHeaderBuilder;
			BuildingModel.Header = headerBuildFunc(builder);
			return this;
		}

		public ItemsListCardBuilder WithFooter(Footer footer)
		{
			BuildingModel.Footer = footer;
			return this;
		}

		public ItemsListCardBuilder WithFooter(Func<IFooterBuilder, Footer> footerBuildFunc,
											   IFooterBuilder builder = null)
		{
			builder = builder ?? _delaultFooterBuilder;
			BuildingModel.Footer = footerBuildFunc(builder);
			return this;
		}
	}
}