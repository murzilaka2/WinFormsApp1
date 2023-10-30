using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int matrixSize = 3;
        private TableLayoutPanel leftTable;
        private TableLayoutPanel rightTable;
        private Panel centerPanel;
        public Form1()
        {
            InitializeComponent();
            (Height, Width) = (400, 480);
            (FormBorderStyle, MaximizeBox) = (FormBorderStyle.Fixed3D, false);
            matrixComboBox.Items.AddRange(new string[]
            {
                "3 x 3",
                "6 x 6",
                "9 x 9"
            });
            matrixComboBox.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddTables();
            AddNumericsToTable(leftTable);
            AddNumericsToTable(rightTable);
        }

        private void AddNumericsToTable(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = matrixSize;
            tableLayoutPanel.ColumnCount = matrixSize;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    NumericUpDown numericUpDown = new NumericUpDown()
                    {
                        Width = 60,
                        Maximum = int.MaxValue,
                        Minimum = int.MinValue
                    };
                    tableLayoutPanel.Controls.Add(numericUpDown);
                }
            }
        }

        private void AddTables()
        {
            leftTable = new TableLayoutPanel()
            {
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = this.ClientSize.Width / 2 - 20
            };
            rightTable = new TableLayoutPanel()
            {
                Dock = DockStyle.Right,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = this.ClientSize.Width / 2 - 20
            };
            centerPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(255, 255, 218),
                Width = 20
            };
            panel1.Controls.Add(leftTable);
            panel1.Controls.Add(rightTable);
            panel1.Controls.Add(centerPanel);

            centerPanel.Controls.Add(new Label()
            {
                Text = "+",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point((centerPanel.Width - 100) / 2, (centerPanel.Height - 20) / 2)
            });
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var leftMatrix = leftTable.Controls.OfType<NumericUpDown>().Select(e => e.Value).ToArray();
            var rightMatrix = rightTable.Controls.OfType<NumericUpDown>().Select(e => e.Value).ToArray();

            var st = new StringBuilder("\t");
            for (int i = 0; i < leftMatrix.Length; i++)
            {
                st.Append(leftMatrix[i] + rightMatrix[i] + ", ");
                if ((i + 1) % matrixSize == 0)
                {
                    st.Remove(st.Length - 2, 2);
                    st.Append(Environment.NewLine);
                    st.Append("\t");
                }
            }
            MessageBox.Show(st.ToString(), "Результат сложения матриц");
        }

        private void matrixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size = matrixComboBox.SelectedItem.ToString();
            matrixSize = size switch
            {
                "3 x 3" => 3,
                "6 x 6" => 6,
                "9 x 9" => 9
            };

            Width = matrixSize switch
            {
                3 => 480,
                6 => 880,
                9 => 1280
            };

            if (leftTable is not null)
            {
                panel1.Controls.Clear();
                AddTables();
                AddNumericsToTable(leftTable);
                AddNumericsToTable(rightTable);
            }
        }
    }
}