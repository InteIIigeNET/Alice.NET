using System;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IItemsListCardBuilder : IModelBuilder<ItemsListCard>
	{
		ItemsListCardBuilder Create(params ImageCard[] cardItems);
		ItemsListCardBuilder WithHeader(Header header);
		ItemsListCardBuilder WithHeader(Func<IHeaderBuilder, Header> headerBuildFunc, IHeaderBuilder builder = null);
		ItemsListCardBuilder WithFooter(Footer footer);
		ItemsListCardBuilder WithFooter(Func<IFooterBuilder, Footer> footerBuildFunc, IFooterBuilder builder = null);
	}
}