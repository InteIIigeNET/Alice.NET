using System;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IItemsListCardBuilder
	{
		ItemsListCardBuilder Create(params ImageCard[] cardItems);
		ItemsListCardBuilder WithFooter(Footer footer);
		ItemsListCardBuilder WithFooter(Func<IFooterBuilder, Footer> footerBuildFunc, IFooterBuilder builder = null);
		ItemsListCardBuilder WithHeader(Func<IHeaderBuilder, Header> headerBuildFunc, IHeaderBuilder builder = null);
		ItemsListCardBuilder WithHeader(Header header);
	}
}