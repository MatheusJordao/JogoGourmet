namespace JogoGourmet.Service
{
    public class VitoriaService(int contadorInicio)
    {
        private int _numVitorias = contadorInicio;

        public void MensagemVitoria()
        {
            _numVitorias++;

            if (_numVitorias == 1)
                _ = MessageBox.Show("Acertei!", "Confirmação", MessageBoxButtons.OK);
            else
                _ = MessageBox.Show($"Acertei de novo! {_numVitorias}ª vez!", "Confirmação", MessageBoxButtons.OK);
        }
    }
}
