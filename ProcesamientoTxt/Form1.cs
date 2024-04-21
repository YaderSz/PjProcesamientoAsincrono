using ProcesamientoTxt;
using System.Windows.Forms;

namespace ProcesamientoTxt
{
    public partial class Form1 : Form
    {
        Repository rs = new Repository();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            List<FileDatos> datos = new List<FileDatos>();


            string fileName;
            DialogResult result;
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.Multiselect = true;

                fileChooser.Filter = "(*.txt)|*.txt";

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
                // obtiene el nombre de archivo

                // se asegura de que el usuario haga clic en "Abrir"
                if (result == DialogResult.OK)
                {
                    // muestra error si el usuario especifica un archivo inválido
                    if (string.IsNullOrEmpty(fileName))
                    {
                        MessageBox.Show("Nombre de archivo inválido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (string inputFilePath in fileChooser.FileNames)
                        {
                            string outputFilePath = Path.ChangeExtension(inputFilePath, "_mayus.txt");
                            string Contenido = await rs.ReadFileAsync(inputFilePath);
                            string processedContent = await rs.ProcessTextAsync(Contenido);
                            await rs.WriteFileAsync(outputFilePath, processedContent);
                            string contenidoCambio = await rs.ReadFileAsync(outputFilePath);
                            MessageBox.Show("Archivo procesado y Guardado con Mayusculas.");
                            datos.Add(new FileDatos { NombreArchivo = inputFilePath, contenido = Contenido, contenidoMayus = contenidoCambio });
                        };

                        dgvArchivos.DataSource = datos;
                        dgvArchivos.Columns["NombreArchivo"].Width = 300;
                        dgvArchivos.Columns["contenido"].Width = 200;
                        dgvArchivos.Columns["contenidoMayus"].Width = 200;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
