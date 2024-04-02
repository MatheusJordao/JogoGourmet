namespace JogoGourmet.Model
{
    public class Palpite(string descricao, Palpite? pai = null)
    {
        public string Descricao = descricao;
        public Palpite? Pai = pai;
        public List<Palpite> Filhos { get; set; } = [];
    }
}
