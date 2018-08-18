using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public abstract class CardBuilder<TCard> : IModelBuilder<TCard>
		where TCard : Card
	{
		protected TCard Card;

		public TCard Build()
		{
			return Card;
		}
	}
}