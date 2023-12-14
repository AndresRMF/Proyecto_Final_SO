using System.Text;
using System.Text.RegularExpressions;
using SimFinalOP;
using static SimFinalOP.Form1;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;




namespace SimFinalOP
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public class AgregarInstruccionesForm : Form
        {
            private Label label1;
            private Label label2;
            private Label label3;
            private TextBox txtProcess;
            private TextBox txtBurst;
            private TextBox txtArrivalTime;
            private Button btnOK;
            private Button btnCancel;

            public string Process => txtProcess.Text;
            public string Burst => txtBurst.Text;
            public string ArrivalTime => txtArrivalTime.Text;

            public AgregarInstruccionesForm()
            {
                InitializeComponent();

            }

            private void InitializeComponent()
            {
                label1 = new Label();
                label1.Text = "Process:";
                label1.Location = new Point(12, 15);
                label1.AutoSize = true;

                txtProcess = new TextBox();
                txtProcess.Location = new Point(100, 12);
                txtProcess.Size = new Size(150, 20);

                label2 = new Label();
                label2.Text = "Burst Time:";
                label2.Location = new Point(12, 45);
                label2.AutoSize = true;

                txtBurst = new TextBox();
                txtBurst.Location = new Point(100, 42);
                txtBurst.Size = new Size(150, 20);

                label3 = new Label();
                label3.Text = "Arrival Time:";
                label3.Location = new Point(12, 75);
                label3.AutoSize = true;

                txtArrivalTime = new TextBox();
                txtArrivalTime.Location = new Point(100, 72);
                txtArrivalTime.Size = new Size(150, 20);

                btnOK = new Button();
                btnOK.Location = new Point(15, 110);
                btnOK.Size = new Size(75, 23);
                btnOK.Text = "OK";
                btnOK.DialogResult = DialogResult.OK;

                btnCancel = new Button();
                btnCancel.Location = new Point(100, 110);
                btnCancel.Size = new Size(75, 23);
                btnCancel.Text = "Cancelar";
                btnCancel.DialogResult = DialogResult.Cancel;

                Controls.Add(label1);
                Controls.Add(txtProcess);
                Controls.Add(label2);
                Controls.Add(txtBurst);
                Controls.Add(label3);
                Controls.Add(txtArrivalTime);
                Controls.Add(btnOK);
                Controls.Add(btnCancel);

            }
        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            LoadFileButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ProcessIdentifier = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Simtittle = new Label();
            comboBox1 = new ComboBox();
            ExecButton = new Button();
            listView1 = new ListView();
            richTextBox1 = new RichTextBox();
            chart1 = new Chart();
            numericUpDownQuantum = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantum).BeginInit();
            SuspendLayout();
            // 
            // LoadFileButton
            // 
            LoadFileButton.Location = new Point(193, 85);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(161, 23);
            LoadFileButton.TabIndex = 0;
            LoadFileButton.Text = "Abrir Archivo";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(434, 85);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(515, 85);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(596, 85);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProcessIdentifier, BurstTime, ArrivalTime, Priority });
            dataGridView1.Location = new Point(33, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 159);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProcessIdentifier
            // 
            ProcessIdentifier.HeaderText = "Process";
            ProcessIdentifier.Name = "ProcessIdentifier";
            ProcessIdentifier.ReadOnly = true;
            ProcessIdentifier.Width = 180;
            // 
            // BurstTime
            // 
            BurstTime.HeaderText = "BurstTime";
            BurstTime.Name = "BurstTime";
            BurstTime.ReadOnly = true;
            BurstTime.Width = 180;
            // 
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.ReadOnly = true;
            ArrivalTime.Width = 180;
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.Name = "Priority";
            Priority.Width = 180;
            // 
            // Simtittle
            // 
            Simtittle.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            Simtittle.Location = new Point(424, 8);
            Simtittle.Name = "Simtittle";
            Simtittle.Size = new Size(495, 43);
            Simtittle.TabIndex = 8;
            Simtittle.Text = "SIMULADOR DE PROCESOS";
            Simtittle.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FCFS", "RR", "SJN", "MLQ", "MLFQ" });
            comboBox1.Location = new Point(994, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // ExecButton
            // 
            ExecButton.Location = new Point(970, 233);
            ExecButton.Name = "ExecButton";
            ExecButton.Size = new Size(177, 23);
            ExecButton.TabIndex = 10;
            ExecButton.Text = "Ejecutar Algoritmo";
            ExecButton.UseVisualStyleBackColor = true;
            ExecButton.Click += btnEjecutarAlgoritmo_Click;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.SnapToGrid;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(691, 470);
            listView1.Name = "listView1";
            listView1.Size = new Size(498, 152);
            listView1.TabIndex = 11;
            listView1.TileSize = new Size(600, 200);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.UseWaitCursor = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(691, 313);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(492, 150);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(33, 313);
            chart1.Name = "chart1";
            chart1.Size = new Size(652, 308);
            chart1.TabIndex = 13;
            chart1.Text = "chart1";
            // 
            // numericUpDownQuantum
            // 
            numericUpDownQuantum.Location = new Point(995, 178);
            numericUpDownQuantum.Name = "numericUpDownQuantum";
            numericUpDownQuantum.Size = new Size(120, 23);
            numericUpDownQuantum.TabIndex = 14;
            numericUpDownQuantum.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(985, 93);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 15;
            label1.Text = "Seleccione un Algoritmo: ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1004, 149);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 16;
            label2.Text = "Quantum para RR:";
            // 
            // Form1
            // 
            ClientSize = new Size(1273, 693);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownQuantum);
            Controls.Add(chart1);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Controls.Add(ExecButton);
            Controls.Add(comboBox1);
            Controls.Add(Simtittle);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(LoadFileButton);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        // Declaracion elementos
        private Label Simtittle;
        private ListView listView1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button LoadFileButton;
        private Button ExecButton;
        private DataGridViewTextBoxColumn ProcessIdentifier;
        private DataGridViewTextBoxColumn BurstTime;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private int quantumRR;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownQuantum;



        private void button2_Click(object sender, EventArgs e) // EDITAR Button
        {
            // Columns edit
            dataGridView1.Columns["ProcessIdentifier"].ReadOnly = !dataGridView1.Columns["ProcessIdentifier"].ReadOnly;
            dataGridView1.Columns["BurstTime"].ReadOnly = !dataGridView1.Columns["BurstTime"].ReadOnly;
            dataGridView1.Columns["ArrivalTime"].ReadOnly = !dataGridView1.Columns["ArrivalTime"].ReadOnly;

            //Change text inside edition mode
            button2.Text = dataGridView1.Columns["ProcessIdentifier"].ReadOnly ? "Editar" : "Guardar";

        }
        private void button4_Click(object sender, EventArgs e) // Agregar Button
        {
            using (AgregarInstruccionesForm agregarInstruccionesForm = new AgregarInstruccionesForm())
            {
                if (agregarInstruccionesForm.ShowDialog() == DialogResult.OK)
                {
                    string process = agregarInstruccionesForm.Process;
                    string burst = agregarInstruccionesForm.Burst;
                    string arrivalTime = agregarInstruccionesForm.ArrivalTime;

                    AgregarInstrucciones($"{process} {burst} {arrivalTime}");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                Task.Run(() => CargarTareasDesdeArchivo(rutaArchivo))
                    .ContinueWith(task =>
                    {
                        if (task.Exception != null)
                        {
                            MessageBox.Show($"Error al cargar el archivo: {task.Exception.InnerException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
        private void CargarTareasDesdeArchivo(string rutaArchivo)
        {
            try
            {
                // Lee todas las líneas del archivo
                string[] lines = File.ReadAllLines(rutaArchivo);

                // Limpia la lista antes de cargar nuevas tareas
                this.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.Rows.Clear();
                });

                // Ahora puedes procesar cada tarea
                foreach (string line in lines)
                {
                    // Divide la línea en partes usando el espacio como delimitador
                    string[] parts = line.Split(' ');

                    // Asegura que haya al menos tres partes (número de tarea, burst time, arrival time)
                    if (parts.Length >= 4)
                    {
                        string processIdentifier = parts[0].Trim();
                        string burstTime = parts[1].Trim();
                        string arrivalTime = parts[2].Trim();
                        string priority = parts[3].Trim();

                        // Agrega la tarea a la lista
                        this.Invoke((MethodInvoker)delegate
                        {
                            dataGridView1.Rows.Add(processIdentifier, burstTime, arrivalTime, priority);
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AgregarInstrucciones(string nuevasInstrucciones)
        {
            // Divide las instrucciones en líneas
            string[] lineas = nuevasInstrucciones.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Agrega las nuevas instrucciones al DataGridView
            foreach (string linea in lineas)
            {
                // Divide la línea en partes usando el espacio como delimitador
                string[] partes = linea.Split(' ');

                // Asegura que haya al menos tres partes (número de tarea, burst time, arrival time)
                if (partes.Length >= 3)
                {
                    string numeroTarea = partes[0].Trim();
                    string burstTime = partes[1].Trim();
                    string arrivalTime = partes[2].Trim();

                    // Agrega la tarea al DataGridView
                    dataGridView1.Rows.Add(numeroTarea, burstTime, arrivalTime);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e) //Eliminar Button
        {
            // Verifica si hay al menos una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Itera a través de todas las filas seleccionadas y las elimina
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Selecciona al menos una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Switch ComboBox
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el algoritmo seleccionado
            string algoritmoSeleccionado = comboBox1.SelectedItem.ToString();

        }
        private void btnEjecutarAlgoritmo_Click(object sender, EventArgs e)
        {
            // Obtener el algoritmo seleccionado
            string algoritmoSeleccionado = comboBox1.SelectedItem.ToString();

            // Ejecutar el algoritmo correspondiente
            switch (algoritmoSeleccionado)
            {
                case "FCFS":
                    EjecutarFCFS();
                    break;
                case "RR":
                    EjecutarRR();
                    break;
                case "SJN":
                    EjecutarSJN();
                    break;
                case "MLQ":
                    EjecutarMLQ();
                    break;
                case "MLFQ":
                    EjecutarMLFQ();
                    break;
                default:
                    MessageBox.Show("Escoga una opcion valida.");
                    break;
            }
        }
        private Color ObtenerColorAleatorio()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarGrafico(double tiempoRetornoPromedio, double tiempoEsperaPromedio, double utilizacionCPU, int tiempoTotalEjecucion)
        {
            // Verificar si las series existen; si no, crearlas
            if (chart1.Series.IndexOf("Tiempo de Espera") == -1)
                chart1.Series.Add("Tiempo de Espera");

            if (chart1.Series.IndexOf("Tiempo de Retorno") == -1)
                chart1.Series.Add("Tiempo de Retorno");

            if (chart1.Series.IndexOf("Uso de CPU") == -1)
                chart1.Series.Add("Uso de CPU");

            if (chart1.Series.IndexOf("Tiempo Total de Ejecución") == -1)
                chart1.Series.Add("Tiempo Total de Ejecución");

            // Limpiar las series antes de agregar nuevos datos
            chart1.Series["Tiempo de Espera"].Points.Clear();
            chart1.Series["Tiempo de Retorno"].Points.Clear();
            chart1.Series["Uso de CPU"].Points.Clear();
            chart1.Series["Tiempo Total de Ejecución"].Points.Clear();

            // Agregar datos al gráfico
            chart1.Series["Tiempo de Espera"].Points.AddXY("FCFS", tiempoEsperaPromedio);
            chart1.Series["Tiempo de Retorno"].Points.AddXY("FCFS", tiempoRetornoPromedio);
            chart1.Series["Uso de CPU"].Points.AddXY("FCFS", utilizacionCPU);
            chart1.Series["Tiempo Total de Ejecución"].Points.AddXY("FCFS", tiempoTotalEjecucion);

            // Actualizar el gráfico
            chart1.Update();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int quantum = (int)numericUpDownQuantum.Value;

        }


        List<(int id, int arrivalTime, int burstTime, int waitingTime, int turnaroundTime)> tareasInfo = new List<(int id, int arrivalTime, int burstTime, int waitingTime, int turnaroundTime)>();

       // TAREAS POR ALGORITMO

        public interface ITarea
        {
            int NumeroTarea { get; }
            int BurstTime { get; }
            int ArrivalTime { get; }
        }

        public class TareaFCFS : ITarea
        {
            public int NumeroTarea { get; set; }
            public int BurstTime { get; set; }
            public int ArrivalTime { get; set; }
        }

        public class TareaSJN : ITarea
        {
            public int NumeroTarea { get; set; }
            public int BurstTime { get; set; }
            public int ArrivalTime { get; set; }
            public int TiempoRestante { get; set; }
            public int TiempoEspera { get; set; }
            public int TiempoRetorno { get; set; }
        }

        private async Task<int> EjecutarTareaSimuladaListView<T>(T tarea) where T : ITarea
        {
            ListViewItem item = new ListViewItem($"Tarea {tarea.NumeroTarea}");
            item.SubItems.Add($"Tiempo de ejecución: 0");
            item.BackColor = ObtenerColorAleatorio();
            listView1.Items.Add(item);

            for (int tiempoTranscurrido = 1; tiempoTranscurrido <= tarea.BurstTime; tiempoTranscurrido++)
            {
                await Task.Delay(100); 

                item.SubItems[1].Text = $"Tiempo de ejecución: {tiempoTranscurrido}";
            }

            richTextBox1.AppendText($"Tarea {tarea.NumeroTarea} completada - Tiempo de ejecución total: {tarea.BurstTime}\n");

            return tarea.BurstTime;
        }

        public class TareaMLQ : ITarea
        {
            public int NumeroTarea { get; set; }
            public int BurstTime { get; set; }
            public int ArrivalTime { get; set; }
            public int Prioridad { get; set; }
        }

        internal class TareaInfo
        {
            public int NumeroTarea { get; set; }
            public int WaitingTime { get; set; }
            public int TurnaroundTime { get; set; }
            public int BurstTime { get; set; }
        }
        internal class TareaMLFQ : ITarea
        {
            public int NumeroTarea { get; set; }
            public int BurstTime { get; set; }
            public int ArrivalTime { get; set; }
            public int Prioridad { get; set; }
        }

        public class TareaRR : ITarea
        {
            public int NumeroTarea { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int RemainingBurstTime { get; set; }
            public int TiempoEjecucionTotal { get; set; } = 0;


            public bool IsCompleted => RemainingBurstTime <= 0;
            public int TiempoEspera { get; set; } = 0;
            public int TiempoRetorno { get; set; } = 0;



            public TareaRR(int burstTime)
            {
                BurstTime = burstTime;
                RemainingBurstTime = burstTime;
            }
        }


        public class PriorityQueue<T>
        {
            private List<(T item, int priority)> elements = new List<(T, int)>();

            public int Count => elements.Count;

            public void Enqueue(T item, int priority)
            {
                elements.Add((item, priority));
                elements.Sort((x, y) => x.priority.CompareTo(y.priority));
            }

            public T Dequeue()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                T item = elements[0].item;
                elements.RemoveAt(0);
                return item;
            }

            public bool TryPeek(out T item)
            {
                if (Count > 0)
                {
                    item = elements[0].item;
                    return true;
                }

                item = default(T);
                return false;
            }

            // Nueva función para acceder a los elementos
            public IReadOnlyList<(T item, int priority)> Elements => elements.AsReadOnly();
        }
        //ALGORITMOS
        private async void EjecutarFCFS()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                listView1.Items.Clear();
                richTextBox1.Clear();

                int tiempoTotal = 0;

                // Ordenar tareas por tiempo de llegada
                List<TareaFCFS> tareasOrdenadas = new List<TareaFCFS>();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int numeroTarea = Convert.ToInt32(fila.Cells["ProcessIdentifier"].Value);
                    int burstTime = Convert.ToInt32(fila.Cells["BurstTime"].Value);
                    int arrivalTime = Convert.ToInt32(fila.Cells["ArrivalTime"].Value);

                    tareasOrdenadas.Add(new TareaFCFS
                    {
                        NumeroTarea = numeroTarea,
                        BurstTime = burstTime,
                        ArrivalTime = arrivalTime
                    });
                }

                tareasOrdenadas = tareasOrdenadas.OrderBy(t => t.ArrivalTime).ToList();

                // Ejecutar tareas ordenadas
                foreach (var tareaFCFS in tareasOrdenadas)
                {
                    int numeroTarea = tareaFCFS.NumeroTarea;
                    int burstTime = tareaFCFS.BurstTime;
                    int arrivalTime = tareaFCFS.ArrivalTime;

                    int waitingTime = tiempoTotal;
                    int turnaroundTime = tiempoTotal + burstTime;

                    tareasInfo.Add((numeroTarea, arrivalTime, burstTime, waitingTime, turnaroundTime));

                    richTextBox1.AppendText($"Iniciando tarea {numeroTarea} - Tiempo de llegada: {arrivalTime}\n");
                    tiempoTotal += await EjecutarTareaSimuladaListView(tareaFCFS);
                }

                // Calcular métricas
                int totalWT = tareasInfo.Sum(tarea => tarea.waitingTime);
                int totalTAT = tareasInfo.Sum(tarea => tarea.turnaroundTime);

                double promedioWT = Math.Round((double)totalWT / tareasInfo.Count, 2);
                double promedioTAT = Math.Round((double)totalTAT / tareasInfo.Count, 2);

                double totalTiempoCPU = tareasInfo.Sum(tarea => tarea.burstTime);
                double totalTiempoEspera = tareasInfo.Sum(tarea => tarea.waitingTime);
                double usoCPU = Math.Round((totalTiempoCPU / (totalTiempoCPU + totalTiempoEspera)) * 100, 2);

                // Mostrar resultados
                richTextBox1.AppendText($"\n=== Resultados FCFS ===\n");
                richTextBox1.AppendText($"Tiempo total de ejecución: {tiempoTotal}\n");
                richTextBox1.AppendText($"Uso de la CPU: {usoCPU}%\n");
                richTextBox1.AppendText($"Tiempo promedio de espera (WT): {promedioWT}\n");
                richTextBox1.AppendText($"Tiempo promedio de retorno (TAT): {promedioTAT}\n");
                richTextBox1.AppendText($"=== Fin de Resultados ===\n");

                // Actualizar gráfico
                ActualizarGrafico(promedioWT, promedioTAT, usoCPU, tiempoTotal);

                MessageBox.Show("Ejecución FCFS completada.", "Resultado FCFS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay tareas para ejecutar FCFS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void EjecutarSJN()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                listView1.Items.Clear();
                richTextBox1.Clear();

                int tiempoTotal = 0;
                List<TareaSJN> tareasList = new List<TareaSJN>();

                PriorityQueue<TareaSJN> colaPrioridad = new PriorityQueue<TareaSJN>();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int numeroTarea = Convert.ToInt32(fila.Cells["ProcessIdentifier"].Value);
                    int burstTime = Convert.ToInt32(fila.Cells["BurstTime"].Value);
                    int arrivalTime = Convert.ToInt32(fila.Cells["ArrivalTime"].Value);

                    TareaSJN tareaSJN = new TareaSJN
                    {
                        NumeroTarea = numeroTarea,
                        BurstTime = burstTime,
                        ArrivalTime = arrivalTime,
                        TiempoRestante = burstTime, 
                        TiempoEspera = 0, 
                        TiempoRetorno = 0 
                    };

                    tareasList.Add(tareaSJN);
                    colaPrioridad.Enqueue(tareaSJN, tareaSJN.BurstTime); // Agregar a la cola de prioridad

                    richTextBox1.AppendText($"Iniciando tarea {numeroTarea} - Tiempo de llegada: {arrivalTime}\n");
                }

                while (colaPrioridad.Count > 0)
                {
                    // Obtener la tarea con el tiempo de rafaga mas corto
                    TareaSJN tareaActual = colaPrioridad.Dequeue();

                    foreach (var tareaPendiente in colaPrioridad.Elements)
                    {
                        tareaPendiente.item.TiempoEspera += tareaActual.TiempoRestante; 
                    }


                    foreach (var tareaPendiente in colaPrioridad.Elements)
                    {
                        tareaPendiente.item.TiempoEspera += tareaActual.TiempoRestante;
                    }


                    tareaActual.TiempoEspera += tiempoTotal; 
                    tareaActual.TiempoRetorno = tareaActual.TiempoEspera + tareaActual.BurstTime; 

                    tiempoTotal += await EjecutarTareaSimuladaListView(tareaActual);


                    ActualizarGrafico(0, 0, 0, tiempoTotal);

                }
                int totalWT = tareasList.Sum(t => t.TiempoEspera);
                int totalTAT = tareasList.Sum(t => t.TiempoRetorno);

                double promedioWT = Math.Round((double)totalWT / tareasList.Count, 2);
                double promedioTAT = (double)totalTAT / tareasList.Count;

                double totalTiempoCPU = tareasList.Sum(t => t.BurstTime);
                double totalTiempoEspera = tareasList.Sum(t => t.TiempoEspera);
                double usoCPU = Math.Round((totalTiempoCPU / (totalTiempoCPU + totalTiempoEspera)) * 100, 2);

                richTextBox1.AppendText($"Uso de la CPU: {usoCPU}%\n");
                richTextBox1.AppendText($"Tiempo promedio de espera (WT): {promedioWT}\n");
                richTextBox1.AppendText($"Tiempo promedio de retorno (TAT): {promedioTAT}\n");

                ActualizarGrafico(promedioWT, promedioTAT, usoCPU, tiempoTotal);

                richTextBox1.AppendText($"Tiempo total de ejecución: {tiempoTotal}\n");
                MessageBox.Show("Ejecución SJN completada.", "Resultado SJN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay tareas para ejecutar SJN.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task EjecutarMLQ()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                listView1.Items.Clear();
                richTextBox1.Clear();

                List<TareaInfo> tareasInfo = new List<TareaInfo>();

                // Crear colas para MLQ
                Dictionary<int, Queue<ITarea>> colasMLQ = new Dictionary<int, Queue<ITarea>>();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int numeroTarea = Convert.ToInt32(fila.Cells["ProcessIdentifier"].Value);
                    int burstTime = Convert.ToInt32(fila.Cells["BurstTime"].Value);
                    int arrivalTime = Convert.ToInt32(fila.Cells["ArrivalTime"].Value);
                    int prioridad = Convert.ToInt32(fila.Cells["Priority"].Value);

                    ITarea tareaMLQ = new TareaMLQ
                    {
                        NumeroTarea = numeroTarea,
                        BurstTime = burstTime,
                        ArrivalTime = arrivalTime,
                        Prioridad = prioridad
                    };

                    if (!colasMLQ.ContainsKey(prioridad))
                    {
                        colasMLQ[prioridad] = new Queue<ITarea>();
                    }

                    colasMLQ[prioridad].Enqueue(tareaMLQ);

                    richTextBox1.AppendText($"Iniciando tarea {numeroTarea} - Tiempo de llegada: {arrivalTime} - Prioridad: {prioridad}\n");

                }

                int tiempoTotal = 0;

                foreach (var cola in colasMLQ.Values)
                {
                    tiempoTotal += await ProcesarCola(cola, tareasInfo);
                }

                int totalWT = tareasInfo.Sum(tarea => tarea.WaitingTime);
                int totalTAT = tareasInfo.Sum(tarea => tarea.TurnaroundTime);

                int tiempoTotalEjecucion = tareasInfo.Sum(tarea => tarea.BurstTime);

                double promedioWT = tareasInfo.Count > 0 ? Math.Round((double)totalWT / tareasInfo.Count, 2) : 0;
                double promedioTAT = tareasInfo.Count > 0 ? Math.Round((double)totalTAT / tareasInfo.Count, 2) : 0;

                if (tareasInfo.Count > 0)
                {
                    double usoCPU = Math.Round((tiempoTotalEjecucion / (double)tiempoTotal) * 100, 2);

                    richTextBox1.AppendText($"=== Resultados MLQ ===\n");
                    richTextBox1.AppendText($"Tiempo total de ejecución: {tiempoTotal}\n");
                    richTextBox1.AppendText($"Uso de la CPU: {usoCPU}%\n");
                    richTextBox1.AppendText($"Tiempo promedio de espera (WT): {promedioWT}\n");
                    richTextBox1.AppendText($"Tiempo promedio de retorno (TAT): {promedioTAT}\n");
                    richTextBox1.AppendText($"=== Fin de Resultados ===\n");
                }
                else
                {
                    richTextBox1.AppendText("No hay datos disponibles. No se completaron tareas.\n");
                }
            }
        }
        private async Task<int> ProcesarCola(Queue<ITarea> cola, List<TareaInfo> tareasInfo)
        {
            int tiempoTotalCola = 0;

            while (cola.Count > 0)
            {
                ITarea tareaActual = cola.Dequeue();

                int tiempoEjecucion = await EjecutarTareaSimuladaListView(tareaActual);

                int tiempoLlegada = tareaActual.ArrivalTime;
                int tiempoEspera = Math.Max(0, tiempoTotalCola - tiempoLlegada);  // Evitar tiempos de espera negativos
                int tiempoRetorno = tiempoTotalCola + tiempoEjecucion;

                tareasInfo.Add(new TareaInfo
                {
                    NumeroTarea = tareaActual.NumeroTarea,
                    BurstTime = tareaActual.BurstTime,
                    WaitingTime = tiempoEspera,
                    TurnaroundTime = tiempoRetorno
                });

                tiempoTotalCola += tiempoEjecucion;
            }

            return tiempoTotalCola;
        }

        private async void EjecutarMLFQ()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                listView1.Items.Clear();
                richTextBox1.Clear();

                List<TareaInfo> tareasInfo = new List<TareaInfo>();

                
                int cantidadPrioridades = 10; // Cantidad maxima de nivel de prioridad

                Queue<ITarea>[] colasMLFQ = new Queue<ITarea>[cantidadPrioridades];

                for (int i = 0; i < colasMLFQ.Length; i++)
                {
                    colasMLFQ[i] = new Queue<ITarea>();
                }

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int numeroTarea = Convert.ToInt32(fila.Cells["ProcessIdentifier"].Value);
                    int burstTime = Convert.ToInt32(fila.Cells["BurstTime"].Value);
                    int arrivalTime = Convert.ToInt32(fila.Cells["ArrivalTime"].Value);
                    int prioridad = Convert.ToInt32(fila.Cells["Priority"].Value);

                    ITarea tareaMLFQ = new TareaMLFQ
                    {
                        NumeroTarea = numeroTarea,
                        BurstTime = burstTime,
                        ArrivalTime = arrivalTime,
                        Prioridad = prioridad
                    };

                    colasMLFQ[prioridad].Enqueue(tareaMLFQ);

                    richTextBox1.AppendText($"Iniciando tarea {numeroTarea} - Tiempo de llegada: {arrivalTime} - Prioridad: {prioridad}\n");

                }

                int tiempoTotal = 0;
                Queue<int> colaPrioridades = new Queue<int>();

                for (int i = 0; i < cantidadPrioridades; i++)
                {
                    if (colasMLFQ[i].Count > 0)
                    {
                        colaPrioridades.Enqueue(i);
                    }
                }

                while (colaPrioridades.Count > 0)
                {
                    int prioridadActual = colaPrioridades.Dequeue();

                    while (colasMLFQ[prioridadActual].Count > 0)
                    {
                        ITarea tareaActual = colasMLFQ[prioridadActual].Dequeue();

                        int tiempoEjecucion = await EjecutarTareaSimuladaListView(tareaActual);

                        tiempoTotal += tiempoEjecucion;

                        //  la tarea a la cola general de resultados
                        tareasInfo.Add(new TareaInfo
                        {
                            NumeroTarea = tareaActual.NumeroTarea,
                            WaitingTime = tiempoTotal - tareaActual.ArrivalTime - tareaActual.BurstTime,
                            TurnaroundTime = tiempoTotal - tareaActual.ArrivalTime,
                            BurstTime = tareaActual.BurstTime
                        });
                    }

                    // Verificar y agregar la próxima prioridad a la cola de prioridades
                    for (int i = 0; i < cantidadPrioridades; i++)
                    {
                        if (colasMLFQ[i].Count > 0)
                        {
                            colaPrioridades.Enqueue(i);
                        }
                    }
                }

                // Calcular el tiempo promedio de espera (WT) y el tiempo promedio de retorno (TAT)
                int totalWT = tareasInfo.Sum(tarea => tarea.WaitingTime);
                int totalTAT = tareasInfo.Sum(tarea => tarea.TurnaroundTime);

                // Calcular promedios y otros datos
                double promedioWT = tareasInfo.Count > 0 ? Math.Round((double)totalWT / tareasInfo.Count, 2) : 0;
                double promedioTAT = tareasInfo.Count > 0 ? Math.Round((double)totalTAT / tareasInfo.Count, 2) : 0;

                if (tareasInfo.Count > 0)
                {
                    double usoCPU = Math.Round((tiempoTotal / (double)tiempoTotal) * 100, 2);

                    // Mostrar resultados de manera estructurada en el RichTextBox
                    richTextBox1.AppendText($"=== Resultados MLFQ ===\n");
                    richTextBox1.AppendText($"Tiempo total de ejecución: {tiempoTotal}\n");
                    richTextBox1.AppendText($"Uso de la CPU: {usoCPU}%\n");
                    richTextBox1.AppendText($"Tiempo promedio de espera (WT): {promedioWT}\n");
                    richTextBox1.AppendText($"Tiempo promedio de retorno (TAT): {promedioTAT}\n");
                    richTextBox1.AppendText($"=== Fin de Resultados ===\n");
                }
                else
                {
                    richTextBox1.AppendText("No hay datos disponibles. No se completaron tareas.\n");
                }
            }
            else
            {
                MessageBox.Show("No hay tareas para ejecutar MLFQ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task EjecutarRR()
        {

            if (dataGridView1.Rows.Count > 0)
            {

                listView1.Items.Clear();
                richTextBox1.Clear();

                int quantum = Convert.ToInt32(numericUpDownQuantum.Value);

                Queue<ITarea> colaRR = new Queue<ITarea>();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int numeroTarea = Convert.ToInt32(fila.Cells["ProcessIdentifier"].Value);
                    int burstTime = Convert.ToInt32(fila.Cells["BurstTime"].Value);

                    ITarea tareaRR = new TareaRR(burstTime)
                    {
                        NumeroTarea = numeroTarea
                    };

                    colaRR.Enqueue(tareaRR);

                    richTextBox1.AppendText($"Iniciando tarea {numeroTarea}\n");

                }
                await ProcesarColaRR(colaRR, quantum, 0);
                MessageBox.Show("Ejecución RR completada.", "Resultado RR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
            }
        }
        private async Task<int> ProcesarColaRR(Queue<ITarea> cola, int quantum, int tiempoTotal)
        {
            int tiempoEsperaTotal = 0;
            double tiempoRetornoTotal = 0;
            int tareasCompletadas = 0;

            while (cola.Count > 0)
            {
                ITarea tareaActual = cola.Dequeue();

                if (tareaActual != null && tareaActual is TareaRR)
                {
                    TareaRR tareaRR = (TareaRR)tareaActual;

                    (tiempoTotal, tareaRR.TiempoRetorno) = await EjecutarTareaSimulada(tareaRR, quantum, tiempoTotal);

                    tiempoEsperaTotal += tareaRR.TiempoEspera;
                    tiempoRetornoTotal += tareaRR.TiempoRetorno;

                    if (!tareaRR.IsCompleted)
                    {
                        cola.Enqueue(tareaRR);
                    }
                    else
                    {
                        tareasCompletadas++;
                        richTextBox1.AppendText($"Tarea {tareaRR.NumeroTarea} completada - Tiempo de ejecución total: {tareaRR.TiempoEjecucionTotal}\n");
                    }
                }
            }
            int numeroTareas = tareasCompletadas; 
            double tiempoPromedioEspera = numeroTareas > 0 ? (double)tiempoEsperaTotal / numeroTareas : 0;
            double tiempoPromedioRetorno = numeroTareas > 0 ? tiempoRetornoTotal / numeroTareas : 0;
            double utilizacionCPU = tiempoTotal > 0 ? (double)tiempoTotal / tiempoTotal : 0;


            richTextBox1.AppendText($"\n=== Resultados   RR  ===\n");
            richTextBox1.AppendText($"Tiempo total de ejecución: {tiempoTotal}\n");
            richTextBox1.AppendText($"Tiempo promedio de espera(WT): {tiempoPromedioEspera.ToString("F2")}\n");
            richTextBox1.AppendText($"Tiempo promedio de retorno(TAT): {tiempoPromedioRetorno.ToString("F2")}\n");
            richTextBox1.AppendText($"Utilización de CPU: {utilizacionCPU.ToString("P2")}\n");
            richTextBox1.AppendText($"=== Resultados     RR  ===\n");

            ActualizarGraficoRR(tiempoPromedioEspera, tiempoPromedioRetorno, utilizacionCPU, tiempoTotal);

            return tiempoTotal;
        }

        private void ActualizarGraficoRR(double tiempoPromedioEspera, double tiempoPromedioRetorno, double utilizacionCPU, int tiempoTotalEjecucion)
        {
            if (chart1.Series.IndexOf("Tiempo de Espera") == -1)
                chart1.Series.Add("Tiempo de Espera");

            if (chart1.Series.IndexOf("Tiempo de Retorno") == -1)
                chart1.Series.Add("Tiempo de Retorno");

            if (chart1.Series.IndexOf("Uso de CPU") == -1)
                chart1.Series.Add("Uso de CPU");

            if (chart1.Series.IndexOf("Tiempo Total de Ejecución") == -1)
                chart1.Series.Add("Tiempo Total de Ejecución");

            chart1.Series["Tiempo de Espera"].Points.Clear();
            chart1.Series["Tiempo de Retorno"].Points.Clear();
            chart1.Series["Uso de CPU"].Points.Clear();
            chart1.Series["Tiempo Total de Ejecución"].Points.Clear();

            chart1.Series["Tiempo de Espera"].Points.AddXY("RR", tiempoPromedioEspera);
            chart1.Series["Tiempo de Retorno"].Points.AddXY("RR", tiempoPromedioRetorno);
            chart1.Series["Uso de CPU"].Points.AddXY("RR", utilizacionCPU);
            chart1.Series["Tiempo Total de Ejecución"].Points.AddXY("RR", tiempoTotalEjecucion);

            chart1.Update();
        }

        private async Task<(int TiempoTotal, int TiempoRetorno)> EjecutarTareaSimulada(TareaRR tareaRR, int quantum, int tiempoTotal)
        {
            try
            {
                int tiempoEjecucion = Math.Min(quantum, tareaRR.RemainingBurstTime);

                await Task.Delay(tiempoEjecucion * 100);

                tareaRR.RemainingBurstTime -= tiempoEjecucion;

                if (!tareaRR.IsCompleted)
                {
                    tareaRR.TiempoEspera += tiempoEjecucion;
                }
                else
                {
                    tareaRR.TiempoRetorno = tiempoTotal + tiempoEjecucion; 
                    AgregarElementoListView(tareaRR);
                }

                tareaRR.TiempoEjecucionTotal += tiempoEjecucion;

                return (tiempoTotal + tiempoEjecucion, tareaRR.TiempoRetorno);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error durante la ejecución simulada: {ex.Message}");
                return (tiempoTotal, 0);
            }
        }

        private void AgregarElementoListView(TareaRR tareaRR)
        {
            ListViewItem item = ObtenerItemListView(tareaRR);

            listView1.Items.Add(item);
        }

        private ListViewItem ObtenerItemListView(TareaRR tareaRR)
        {
            ListViewItem item = new ListViewItem($"Tarea {tareaRR.NumeroTarea}");
            item.SubItems.Add($"Tiempo de ejecución acumulado: {tareaRR.TiempoEjecucionTotal}");
            item.SubItems.Add($"Tiempo de retorno: {tareaRR.TiempoRetorno}");
            item.BackColor = ObtenerColorAleatorio();

            return item;
        }

     
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
