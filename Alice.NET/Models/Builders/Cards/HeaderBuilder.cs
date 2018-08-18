using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class HeaderBuilder : IHeaderBuilder
	{
		private Header _header;

		public IHeaderBuilder Create(string text)
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