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
            var listaCaracteristicas = _palpiteService.ListarCaracteristicas();

            foreach (var caracteristica in listaCaracteristicas)
            {
                bool acertou = Dialog.Perguntar(caracteristica.Descricao);
                if (acertou)
                {
                    Adivinhar(caracteristica);
                    return;
                }
            }

            _palpiteService.Adicionar(listaCaracteristicas.Last().Descricao, null);
        }

        private void Adivinhar(Palpite caracteristica)
        {
            var palpitesPorCaracteristica = _palpiteService.ListarPalpitesPorCaracteristica(caracteristica.Descricao);

            if (palpitesPorCaracteristica.Count != 0)
            {
                foreach (var palpite in palpitesPorCaracteristica)
                {
                    bool acertou = Dialog.Perguntar(palpite.Descricao);
                    if (acertou)
                    {
                        Adivinhar(palpite);
                        return;
                    }
                }

                _palpiteService.Adicionar(palpitesPorCaracteristica.Last().Descricao, caracteristica.Descricao);
            }
            else
            {
                _vitoriaService.MensagemVitoria();
                return;
            }
        }
    }
}
