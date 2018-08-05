using Alice.Models.Buttons;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// ���� �����������
	/// </summary>
	public class BigImageCard : Card
	{
		public BigImageCard() : base(CardType.BigImage)
		{ }

		/// <summary>
		/// ������������� �����������, ������� ������������ � ����� �� ������ ��������
		/// </summary>
		[JsonProperty("image_id")]
		public string ImageId { get; set; }

		/// <summary>
		/// ��������� ��� �����������
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// �������� �����������
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// �������� �����������, �� ������� ����� ������
		/// </summary>
		[JsonProperty("button")]
		public Button Button { get; set; }
	}
}