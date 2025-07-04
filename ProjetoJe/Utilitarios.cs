using System.Windows.Forms;

namespace ProjetoJe
{
    public class Utilitarios : Form
    {
        //Se tem algo que aprendi é usar o conceito de DRY (Don't Repeat Yourself)
        //Então criei esse método para limpar todos os TextBoxes de um Form ou de um controle específico
        //Por ser um metodo simples eu uso como heranca, herdando o form e passando para as outras classes que herdar essa classe
        protected void LimparTodosTextBox(Control controlePai = null)
        {
            if (controlePai == null)
                controlePai = this;

            foreach (Control controle in controlePai.Controls)
            {
                if (controle is TextBox tb)
                {
                    tb.Clear();
                }
                else if (controle.HasChildren)
                {
                    //Recursivamente limpa os TextBoxes dentro de GroupBoxes, Panels, etc.
                    LimparTodosTextBox(controle);
                }
            }
        }
    }
}

