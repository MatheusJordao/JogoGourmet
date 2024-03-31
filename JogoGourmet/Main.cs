using JogoGourmet.Model;
using JogoGourmet.Service;

namespace JogoGourmet
{
    public partial class Main : Form
    {
        public PalpiteService _palpiteService;
        public VitoriaService _vitoriaService;
        public Main()
        {
            List<Palpite> dadosIniciais = [
                    new Palpite("Massa"),
                    new Palpite("Bolo de chocolate"),
                    new Palpite("Lasanha", "Massa")
                ];

            _palpiteService = new PalpiteService(dadosIniciais);
            _vitoriaService = new VitoriaService(0);

            InitializeComponent();
        }

        private void buttonIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            var listaPalpitesBase = _palpiteService.ListarPalpitesBase();

            foreach (var palpiteBase in listaPalpitesBase)
            {
                bool acertou = Dialog.Perguntar(palpiteBase.Descricao);
                if (acertou)
                {
                    Adivinhar(palpiteBase);
                    return;
                }
            }

            _palpiteService.Adicionar(listaPalpitesBase.Last().Descricao, null);
        }

        private void Adivinhar(Palpite palpite)
        {
            var palpitesFilhos = _palpiteService.ListarPalpitesPorPai(palpite.Descricao);

            if (palpitesFilhos.Count != 0)
            {
                foreach (var palpiteFilho in palpitesFilhos)
                {
                    bool acertou = Dialog.Perguntar(palpiteFilho.Descricao);
                    if (acertou)
                    {
                        Adivinhar(palpiteFilho);
                        return;
                    }
                }

                _palpiteService.Adicionar(palpitesFilhos.Last().Descricao, palpite.Descricao);
            }
            else
            {
                _vitoriaService.MensagemVitoria();
                return;
            }
        }
    }
}
