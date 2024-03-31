namespace JogoGourmet
{
    public partial class Main : Form
    {
        public List<Palpite> _palpites;
        public Main()
        {
            _palpites =
            [
                new Palpite("Massa"),
                new Palpite("Bolo de chocolate"),
                new Palpite("Lasanha", "Massa")
            ];

            InitializeComponent();
        }

        private void buttonIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            var listaPalpitesBase = _palpites.Where(o => string.IsNullOrEmpty(o.PalpitePai)).ToList();
            
            foreach (var palpiteBase in listaPalpitesBase)
            {
                bool acertou = Dialog.Perguntar(palpiteBase.Descricao);
                if (acertou)
                {
                    Adivinhar(palpiteBase);
                    return;
                }
            }

            string novoPrato = Dialog.CapturarPrato();
            string pratoPai = Dialog.CapturarPratoPai(novoPrato, listaPalpitesBase.Last().Descricao);

            if (!string.IsNullOrEmpty(novoPrato) && !string.IsNullOrEmpty(pratoPai))
            {
                _palpites.Add(new Palpite(novoPrato, pratoPai));
            }
        }

        private void Adivinhar(Palpite palpite)
        {
            var palpitesFilhos = _palpites.Where(o => !string.IsNullOrEmpty(o.PalpitePai) && o.PalpitePai.Equals(palpite.Descricao)).ToList();

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

                string novoPrato = Dialog.CapturarPrato();
                string pratoPai = Dialog.CapturarPratoPai(novoPrato, palpitesFilhos.Last().Descricao);

                if (!string.IsNullOrEmpty(novoPrato) && !string.IsNullOrEmpty(pratoPai))
                {
                    _palpites.Add(new Palpite(pratoPai, palpite.Descricao));
                    _palpites.Add(new Palpite(novoPrato, pratoPai));
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Acertei de novo!", "Confirmação", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
