namespace JogoGourmet
{
    public static class Dialog
    {
        public static bool Perguntar(string descricaoPrato)
        {
            DialogResult result = MessageBox.Show($"O prato que você pensou é {descricaoPrato}?", "Confirmação", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        public static string CapturarPrato()
        {
            string userInput = string.Empty;
            var dialog = new InputDialog("Desisto", "Qual prato você pensou?");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                userInput = dialog.UserInput;
            }

            return userInput;
        }

        public static string CapturarPratoPai(string novoPrato, string primeiroFilho)
        {
            string userInput = string.Empty;
            var dialog = new InputDialog("Complete", $"{novoPrato} é __________, mas {primeiroFilho} não.");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                userInput = dialog.UserInput;
            }

            return userInput;
        }
    }
}
