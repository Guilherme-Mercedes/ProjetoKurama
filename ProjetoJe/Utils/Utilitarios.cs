using System.Globalization;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public static class Utilitarios
    {
        //Se tem algo que aprendi é usar o conceito de DRY (Don't Repeat Yourself)
        //Então criei esse método para limpar todos os TextBoxes de um Form ou de um controle específico
        //Eu tentei usar como heranca porem como outras classes não herdam o Form dessa classe, acabei optando por um método estático
        //Como só tinha um método, decidi adicionar mais um metodo que valida os campos de texto
        public static bool CampoPreenchido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        public static bool CampoDecimalValido(string texto)
        {
            var culturaBR = new CultureInfo("pt-BR");
            string textoFormatado = texto.Replace('.', ','); // Troca ponto por vírgula

            return decimal.TryParse(textoFormatado, NumberStyles.Number, culturaBR, out _);
        }

        public static bool CampoInteiroValido(string texto)
        {
            return int.TryParse(texto, out _);
        }

        public static bool TodosPreenchidos(params string[] campos)
        {
            foreach (var campo in campos)
            {
                if (!CampoPreenchido(campo))
                    return false;
            }
            return true;
        }

        public static void BloquearCaractere(KeyPressEventArgs e)
        {       // Se o caractere não for número nem tecla de controle (como backspace), bloqueia
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void LimparTodosTextBox(Control controlePai = null)
        {
            foreach (Control controle in controlePai.Controls)
            {
                if (controle is TextBox tb)
                {
                    tb.Clear();
                }
                else if (controle.HasChildren)
                {
                    //limpa os TextBoxes dentro de GroupBoxes, Panels, etc.
                    LimparTodosTextBox(controle);
                }
            }
        }

    }
}

