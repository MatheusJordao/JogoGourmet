using JogoGourmet.Model;

namespace JogoGourmet.Service
{
    public class PalpiteService(List<Palpite> palpites)
    {
        private List<Palpite> _palpites = palpites;

        public List<Palpite> ListarCaracteristicas()
        {
            return _palpites.Where(o => string.IsNullOrEmpty(o.Caracteristica)).ToList();
        }
        public List<Palpite> ListarPalpitesPorCaracteristica(string caracteristica)
        {
            return _palpites.Where(o => !string.IsNullOrEmpty(o.Caracteristica) && o.Caracteristica.Equals(caracteristica)).ToList();
        }
        public void Adicionar(string palpiteComparativo, string? categoria)
        {
            string novoPrato = Dialog.CapturarPrato();
            string pratoPai = Dialog.CapturarPratoPai(novoPrato, palpiteComparativo);

            if (!string.IsNullOrEmpty(novoPrato) && !string.IsNullOrEmpty(pratoPai))
            {
                var ultimoIndex = _palpites.Count() - 1;

                _palpites.Insert(ultimoIndex - 1, new Palpite(pratoPai, categoria));
                _palpites.Insert(ultimoIndex - 1, new Palpite(novoPrato, pratoPai));
            }
        }
    }
}
