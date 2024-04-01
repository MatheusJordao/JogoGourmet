namespace JogoGourmet.Model
{
    public class Palpite(string descricao, string? caracteristica = null)
    {
        public string Descricao = descricao;
        public string? Caracteristica = caracteristica;
    }
}
