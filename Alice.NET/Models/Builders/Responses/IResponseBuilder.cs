using System;
using Alice.Models.Builders.Cards;
using Alice.Models.Buttons;
using Alice.Models.Cards;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Responses
{
	public interface IResponseBuilder : IModelBuilder<Response>
	{
		IResponseBuilder Create(string text);
		IResponseBuilder EndSession();
		IResponseBuilder WithButtons(params TipButton[] buttons);
		IResponseBuilder WithCard<TCard>(TCard card) where TCard : Card;
		IResponseBuilder WithBigImageCard(ImageCard card);
		IResponseBuilder WithBigImageCard(Func<IBigImageCardBuilder, ImageCard> cardBuildFunc, 
										  IBigImageCardBuilder builder = null);
		IResponseBuilder WithItemsListCard(ItemsListCard card);
		IResponseBuilder WithItemsListCard(Func<IItemsListCardBuilder, ItemsListCard> cardBuildFunc,
										   IItemsListCardBuilder builder);
		IResponseBuilder WithTts(string tts);
	}
}