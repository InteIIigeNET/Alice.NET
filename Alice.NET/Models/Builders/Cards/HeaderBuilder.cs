using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class HeaderBuilder
	{
		private Header _header;

		public HeaderBuilder Create(string text)
		{
			_header = new Header()
			{
				Text = text
			};
			return this;
		}

		public Header Build()
		{
			return _header;
		}
	}
}