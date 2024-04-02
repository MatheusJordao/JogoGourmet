using JogoGourmet.Model;

namespace JogoGourmet.Service
{
    public class PalpiteService(List<Palpite> palpites)
    {
        private List<Palpite> _palpites = palpites;

        public List<Palpite> ListarRaiz()
        {
            return _palpites.Where(o => o.Pai == null).ToList();
        }
        public static List<Palpite> ListarPalpitesPorPai(Palpite palpite)
        {
            return [.. palpite.Filhos];
        }
        public void Adicionar(string palpiteComparativo, Palpite? palpitePai)
        {
            string descricaoNovoPrato = Dialog.CapturarPrato();
            string descricaoPratoPai = Dialog.CapturarPratoPai(descricaoNovoPrato, palpiteComparativo);

            if (!string.IsNullOrEmpty(descricaoNovoPrato) && !string.IsNullOrEmpty(descricaoPratoPai))
            {
                var novoElemento = new Palpite(descricaoPratoPai, palpitePai);
                AdicionarPenultimaPosicao(novoElemento.Filhos, new Palpite(descricaoNovoPrato, novoElemento));

                if (palpitePai != null)
                {
                    //Add no meio da árvore
                    AdicionarPenultimaPosicao(palpitePai.Filhos, novoElemento);
                }
                else
                {
                    //Add direto na raiz
                    AdicionarPenultimaPosicao(_palpites, novoElemento);
                }   
            }
        }

        private static void AdicionarPenultimaPosicao(List<Palpite> palpites, Palpite novoPalpite)
        {
            int posicaoInsert = 0;

            if (palpites.Count >= 1)
                posicaoInsert = palpites.Count - 1;

            palpites.Insert(posicaoInsert, novoPalpite);
        }
    }
}
