public class Contatos
{
    private List<Contato> agenda = new List<Contato>();

    public bool Adicionar(Contato c)
    {
        if (!agenda.Contains(c))
        {
            agenda.Add(c);
            return true;
        }
        return false;
    }

    public Contato Pesquisar(Contato c)
    {
        return agenda.FirstOrDefault(contato => contato.Equals(c));
    }

    public bool Alterar(Contato c)
    {
        Contato contato = Pesquisar(c);
        if (contato != null)
        {
            int index = agenda.IndexOf(contato);
            agenda[index] = c;
            return true;
        }
        return false;
    }

    public bool Remover(Contato c)
    {
        return agenda.Remove(c);
    }

    public List<Contato> ListarContatos()
    {
        return agenda;
    }
}
