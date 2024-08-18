namespace Tablero_Ajedrez
{
    public partial class Form1 : Form
    {
        private const int Size = 8; // Tamaño del tablero 8x8
        private Button[,] botones = new Button[Size, Size];
        public Form1()
        {
            InitializeComponent();
            CrearTablero();
        }
        private void CrearTablero()
        {
            int tamañoCasilla = 50; // Tamaño de cada casilla en píxeles

            for (int fila = 0; fila < Size; fila++)
            {
                for (int columna = 0; columna < Size; columna++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(tamañoCasilla, tamañoCasilla);
                    btn.Location = new Point(columna * tamañoCasilla, fila * tamañoCasilla);
                    btn.BackColor = (fila + columna) % 2 == 0 ? Color.White : Color.Black;
                    btn.ForeColor = (fila + columna) % 2 == 0 ? Color.Black : Color.White;
                    btn.Click += new EventHandler(BtnCasilla_Click);

                    botones[fila, columna] = btn;
                    Controls.Add(btn);
                }
            }

            this.ClientSize = new Size(Size * tamañoCasilla, Size * tamañoCasilla);
            this.Text = "Tablero de Ajedrez";
        }

        private void BtnCasilla_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int fila = btn.Top / btn.Height;
                int columna = btn.Left / btn.Width;
                MessageBox.Show($"Coordenadas: ({fila}, {columna})");
            }
        }
    }
}
