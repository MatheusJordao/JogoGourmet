using JogoGourmet.Model;

namespace JogoGourmet.Service
{
    public class PalpiteService(List<Palpite> palpites)
    {
        private List<Palpite> _palpites = palpites;

        public List<Palpite> ListarPalpitesBase()
        {
            return _palpites.Where(o => string.IsNullOrEmpty(o.PalpitePai)).ToList();
        }
        public List<Palpite> ListarPalpitesPorPai(string palpitePai)
        {
            return _palpites.Where(o => !string.IsNullOrEmpty(o.PalpitePai) && o.PalpitePai.Equals(palpitePai)).ToList();
        }
        public void Adicionar(string palpiteComparativo, string? pratoAvo)
        {
            string novoPrato = Dialog.CapturarPrato();
            string pratoPai = Dialog.CapturarPratoPai(novoPrato, palpiteComparativo);

            if (!string.IsNullOrEmpty(novoPrato) && !string.IsNullOrEmpty(pratoPai))
            {
                _palpites.Add(new Palpite(pratoPai, pratoAvo));
                _palpites.Add(new Palpite(novoPrato, pratoPai));
            }
        }
    }
}
