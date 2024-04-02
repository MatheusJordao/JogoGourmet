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
            var massa = new Palpite("Massa");
            massa.Filhos.Add(new Palpite("Lasanha", massa));

            List<Palpite> dadosIniciais = [
                    massa,
                    new Palpite("Bolo de chocolate")
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
            var listaRaiz = _palpiteService.ListarRaiz();

            foreach (var raiz in listaRaiz)
            {
                bool acertou = Dialog.Perguntar(raiz.Descricao);
                if (acertou)
                {
                    Adivinhar(raiz);
                    return;
                }
            }

            _palpiteService.Adicionar(listaRaiz.Last().Descricao, null);
        }

        private void Adivinhar(Palpite raiz)
        {
            var palpites = PalpiteService.ListarPalpitesPorPai(raiz);

            if (palpites.Count != 0)
            {
                foreach (var palpite in palpites)
                {
                    bool acertou = Dialog.Perguntar(palpite.Descricao);
                    if (acertou)
                    {
                        Adivinhar(palpite);
                        return;
                    }
                }

                _palpiteService.Adicionar(palpites.Last().Descricao, raiz);
            }
            else
            {
                _vitoriaService.MensagemVitoria();
                return;
            }
        }
    }
}
