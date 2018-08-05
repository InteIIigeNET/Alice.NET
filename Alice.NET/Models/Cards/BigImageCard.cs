using Alice.Models.Buttons;

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
		public string ImageId { get; set; }

		/// <summary>
		/// ��������� ��� �����������
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// �������� �����������
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// �������� �����������, �� ������� ����� ������
		/// </summary>
		public Button Button { get; set; }
	}
}