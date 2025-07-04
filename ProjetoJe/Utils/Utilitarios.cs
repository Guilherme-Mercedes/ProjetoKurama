using System.Windows.Forms;

namespace ProjetoJe
{
    public static class Utilitarios
    {
        //Se tem algo que aprendi é usar o conceito de DRY (Don't Repeat Yourself)
        //Então criei esse método para limpar todos os TextBoxes de um Form ou de um controle específico
        //Eu tentei usar como heranca porem como outras classes não herdam o Form dessa classe, acabei optando por um método estático
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

