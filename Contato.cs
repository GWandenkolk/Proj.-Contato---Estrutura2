public class Contato
{
    public string Email { get; set; }
    public string Nome { get; set; }
    public Data DtNasc { get; set; }
    public List<Telefone> Telefones { get; set; }

    public Contato(string nome, string email, Data dtNasc)
    {
        this.Nome = nome;
        this.Email = email;
        this.DtNasc = dtNasc;
        this.Telefones = new List<Telefone>();
    }

    public void AdicionarTelefone(Telefone t)
    {
        Telefones.Add(t);
    }

    public string GetTelefonePrincipal()
    {
        var telefonePrincipal = Telefones.FirstOrDefault(t => t.Principal);
        return telefonePrincipal != null ? telefonePrincipal.Numero : "Nenhum telefone principal definido.";
    }

    public override string ToString()
    {
        string telefonesStr = string.Join(", ", Telefones.Select(t => $"{t.Tipo}: {t.Numero}"));
        return $"Nome: {Nome}, Email: {Email}, Nascimento: {DtNasc}, Telefones: {telefonesStr}, Principal: {GetTelefonePrincipal()}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Contato)
        {
            Contato outroContato = obj as Contato;
            return this.Email.Equals(outroContato.Email);
        }
        return false;
    }
}
