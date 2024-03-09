using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;
using System;

namespace MenuBuilderApp
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip1;

        public Form1()
        {
            InitializeComponent();
            // ������������� �����
            InitializeForm();
        }

        public TextBox TopLevelMenu { get; private set; }
        public TextBox SubItem { get; private set; }

        private void InitializeForm()
        {
            // ��������� ���������� �����
            this.Text = "���� � �������";
            this.Size = new System.Drawing.Size(800, 900);

            // ���������� ��������� �� �����
            Label labelTopLevelMenu = new Label();
            labelTopLevelMenu.Text = "������� �������� �������� ������ ����:";
            labelTopLevelMenu.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(labelTopLevelMenu);

            TopLevelMenu = new TextBox();
            TopLevelMenu.Location = new System.Drawing.Point(20, 50);
            this.Controls.Add(TopLevelMenu);

            Label labelSubItem = new()
            {
                Text = "������� �������� ��������� ����:",
                Location = new System.Drawing.Point(20, 80)
            };
            this.Controls.Add(labelSubItem);

            SubItem = new TextBox();
            SubItem.Location = new System.Drawing.Point(20, 110);
            this.Controls.Add(SubItem);

            Button btnAddTopLevelMenu = new()
            {
                Text = "�������� ����� ����",
                Location = new System.Drawing.Point(20, 140)
            };
            btnAddTopLevelMenu.Click += new System.EventHandler(btnAddTopLevelMenu_Click);
            this.Controls.Add(btnAddTopLevelMenu);

            Button btnAddSubMenu = new()
            {
                Text = "�������� �������",
                Location = new System.Drawing.Point(20, 170)
            };
            btnAddSubMenu.Click += new System.EventHandler(btnAddSubMenu_Click);
            this.Controls.Add(btnAddSubMenu);

            menuStrip1 = new MenuStrip();
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
        }

        private void btnAddSubMenu_Click(object? sender, EventArgs e)
        {
            string subMenuItemName = SubItem.Text;
        string parentMenuName = TopLevelMenu.Text;

        foreach (ToolStripMenuItem item in menuStrip1.Items)
        {
            if (item.Text == parentMenuName)
            {
                ToolStripMenuItem subMenuItem = new ToolStripMenuItem(subMenuItemName);
                item.DropDownItems.Add(subMenuItem);
                break;
            }
        }
        }

        private void btnAddTopLevelMenu_Click(object? sender, EventArgs e)
        {
            string menuName = TopLevelMenu.Text;
            ToolStripMenuItem topLevelMenuItem = new ToolStripMenuItem(menuName);
            menuStrip1.Items.Add(topLevelMenuItem);
        }
    }
}
