class Episodio
{
    private List<string> convidados = new List<string>();
    public int Ordem { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(",", convidados)}";
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}