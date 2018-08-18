using System;
using Alice.Models.Builders.Cards;
using Alice.Models.Buttons;
using Alice.Models.Cards;
using Alice.Models.Enums;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Responses
{
	public class ResponseBuilder : BaseBuilder<Response>, IResponseBuilder
	{
		private readonly IBigImageCardBuilder _defaultImageCardBuilder;
		private readonly IItemsListCardBuilder _defaultItemsListCardBuilder;

		public IResponseBuilder Create(string text) //возможно, тут придётся добавить bool useDefaultTts
		{
			BuildingModel = new Response {Text = text};
			return this;
		}

		public IResponseBuilder WithTts(string tts) 
		{
			BuildingModel.Tts = tts;
			return this;
		}

		public IResponseBuilder WithCard<TCard>(TCard card)
			where TCard : Card
		{
			BuildingModel.Card = card;
			return this;
		}

		public IResponseBuilder WithBigImageCard(ImageCard card)
		{
			return WithCard(card);
		}

		public IResponseBuilder WithBigImageCard(Func<IBigImageCardBuilder, ImageCard> cardBuildFunc, 
												 IBigImageCardBuilder builder = null)
		{
			builder = builder ?? _defaultImageCardBuilder;
			BuildingModel.Card = cardBuildFunc(builder);
			return this;
		}

		public IResponseBuilder WithItemsListCard(ItemsListCard card)
		{
			return WithCard(card);
		}

		public IResponseBuilder WithItemsListCard(Func<IItemsListCardBuilder, ItemsListCard> cardBuildFunc,
			IItemsListCardBuilder builder)
		{
			builder = builder ?? _defaultItemsListCardBuilder;
			BuildingModel.Card = cardBuildFunc(builder);
			return this;
		}

		public IResponseBuilder WithButtons(params TipButton[] buttons)
		{
			BuildingModel.Buttons = buttons;
			return this;
		}

		public IResponseBuilder EndSession()
		{
			BuildingModel.EndSession = true;
			return this;
		}
	}
}