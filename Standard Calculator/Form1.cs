namespace Standard_Calculator;

public partial class Form1 : Form
{
        private decimal primeiroNumero;
        private string operacao;
        
    public Form1()
    {
        InitializeComponent();
        
    }
    
    private void ClicouNumero(object sender, EventArgs e)
    {
        // Descobre qual botão foi clicado
        Button botaoClicado = (Button)sender;

        // Pega o texto do botão (ex: "7", "8", etc.)
        string numero = botaoClicado.Text;

        // Aplica a mesma lógica de antes, mas agora com o número do botão
        if (visorTextBox.Text == "0")
        {
            visorTextBox.Text = numero;
        }
        else
        {
            visorTextBox.Text = visorTextBox.Text + numero;
        }
    }



    private void ClicouOperador(object sender, EventArgs e)
    {
        Button botaoClicado = (Button)sender;
        operacao = botaoClicado.Text; // Pega o texto do botão: "+", "-", "×" ou "÷"
        primeiroNumero = Convert.ToDecimal(visorTextBox.Text);
        visorTextBox.Text = "0";
    }
    
    private void botaoIgual_Click(object sender, EventArgs e)
    {
        decimal segundoNumero = Convert.ToDecimal(visorTextBox.Text);
        decimal resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = primeiroNumero + segundoNumero;
                break;
            case "-":
                resultado = primeiroNumero - segundoNumero;
                break;
            case "×":
                resultado = primeiroNumero * segundoNumero;
                break;
            case "÷":
                if (segundoNumero == 0)
                {
                    visorTextBox.Text = "Erro";
                    return; // Sai do método para não continuar
                }
                resultado = primeiroNumero / segundoNumero;
                break;
        }

        visorTextBox.Text = Convert.ToString(resultado);
    }
    
    private void botaoLimpar_Click(object sender, EventArgs e)
    {
        visorTextBox.Text = "0";
        primeiroNumero = 0;
        operacao = ""; // Limpa a operação guardada
    }
    
    
}