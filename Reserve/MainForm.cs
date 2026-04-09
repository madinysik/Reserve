using Reserve.Models;
using Reserve.Properties;
using System.Data;
using System.Text.Json;
using System.Xml.Serialization;

namespace Reserve
{
    public partial class MainForm : Form
    {
        private ReserveData currentData;
        public MainForm()
        {
            InitializeComponent();
            btnLoadXML.Click += BtnLoadXML_Click;
            btnLoadJSON.Click += BtnLoadJSON_Click;
            btnShow.Click += BtnShow_Click;
            btnClose.Click += BtnClose_Click;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnLoadXML_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.FileName;

                    if (!File.Exists(path))
                    {
                        MessageBox.Show(Resources.ErrorAccess);
                        return;
                    }
                    try
                    {
                        var rawData = new MemoryStream(File.ReadAllBytes(path));
                        var xmls = new XmlSerializer(typeof(ReserveData));
                        currentData = (ReserveData)xmls.Deserialize(rawData);

                        LoadTree();
                        LoadTable();
                        MessageBox.Show(Resources.LoadXML);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Resources.ErrorXML);
                    }
                }
            }
        }
        private void BtnLoadJSON_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.FileName;

                    if (!File.Exists(path))
                    {
                        MessageBox.Show(Resources.ErrorAccess);
                        return;
                    }
                    try
                    {
                        var rawData = new MemoryStream(File.ReadAllBytes(path));
                        currentData = JsonSerializer.Deserialize<ReserveData>(rawData);

                        LoadTree();
                        LoadTable();
                        MessageBox.Show(Resources.LoadJSON);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Resources.ErrorJSON);
                    }
                }
            }
        }
        private void LoadTree()
        {
            treeView.Nodes.Clear();
            var root = new TreeNode(Resources.TreeRoot);

            var animals = new TreeNode(Resources.Animals);
            foreach (var a in currentData.Animals)
                animals.Nodes.Add(new TreeNode($"{a.Id}: {a.Name}") { Tag = a });

            var employees = new TreeNode(Resources.Employees);
            foreach (var e in currentData.Employees)
                employees.Nodes.Add(new TreeNode($"{e.Id}: {e.Name}") { Tag = e });

            var feedings = new TreeNode(Resources.Feedings);
            foreach (var f in currentData.Feedings)
                feedings.Nodes.Add(new TreeNode($"{f.Id}: {f.Animal.AnimalName}") { Tag = f });

            root.Nodes.AddRange([animals, employees, feedings]);
            treeView.Nodes.Add(root);
            treeView.ExpandAll();
        }
        private void LoadTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(Resources.Type, typeof(string));
            table.Columns.Add(Resources.ID, typeof(int));
            table.Columns.Add(Resources.Name, typeof(string));

            foreach (var a in currentData.Animals)
                table.Rows.Add(Resources.Animals, a.Id, a.Name);

            foreach (var e in currentData.Employees)
                table.Rows.Add(Resources.Employees, e.Id, e.Name);

            foreach (var f in currentData.Feedings)
                table.Rows.Add(Resources.Feedings, f.Id, f.Animal.AnimalName);

            tableInfo.DataSource = table;
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (currentData == null)
            {
                MessageBox.Show(Resources.LoadFileFirst);
                return;
            }
            if (treeView.SelectedNode?.Tag is IDetails selected)
            {
                var details = new DetailsForm(selected);
                details.ShowDialog();
            }
            else
            {
                MessageBox.Show(Resources.SelectElement);
            }
        }
    }
}