public class Telefone
{
    public string Tipo { get; set; }
    public string Numero { get; set; }
    public bool Principal { get; set; }

    public Telefone(string tipo, string numero, bool principal)
    {
        this.Tipo = tipo;
        this.Numero = numero;
        this.Principal = principal;
    }
}
