namespace ShopLambda.API.Entities;

public class Address
{
	public string? Logradouro { get; set; }
	public int? Numero { get; set; }
	public string? Complemento { get; set; }
	public string? Cidade { get; set; }
	public string? Estado { get; set; }
}