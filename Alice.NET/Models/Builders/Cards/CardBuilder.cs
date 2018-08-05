using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class CardBuilder<TCard> 
		where TCard : Card, new()
	{
		protected TCard Card;

		public TCard Build()
		{
			return Card;
		}
	}
}