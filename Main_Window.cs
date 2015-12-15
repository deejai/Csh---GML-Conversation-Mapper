using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GML_Conversation_Mapper
{
    public partial class Main_Window : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);
        
        private int n_index = -1;
        private int r_index = -1;

        public Main_Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GML_Field.Text = "";
            (new FileInfo("C:\\GMLM\\backup.gmlm")).Directory.Create();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] row = { "Description", "Speech" };
            Node_List.Items.Add("" + Node_List.Items.Count).SubItems.AddRange(row);
        }

        private void Node_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_n_index();
            bool n_selected;

            if (n_index >= 0)
            {
                n_selected = true;

                ID_Field.Text = Node_List.SelectedItems[0].SubItems[0].Text;
                Description_Field.Text = Node_List.SelectedItems[0].SubItems[1].Text;
                Speech_Field.Text = Node_List.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                n_selected = false;

                ID_Field.Text = "";
                Description_Field.Text = "";
                Speech_Field.Text = "";
            }

            displayResponses();

            Description_Field.Enabled = n_selected;
            Speech_Field.Enabled = n_selected;
            Response_List.Enabled = n_selected;
            Add_Response.Enabled = n_selected;
        }

        private void ID_Field_TextChanged(object sender, EventArgs e)
        {
        }

        private void Description_Field_TextChanged(object sender, EventArgs e)
        {
            update_n_index();
            if (n_index >= 0)
                Node_List.SelectedItems[0].SubItems[1].Text = Description_Field.Text;
        }

        private void Speech_Field_TextChanged(object sender, EventArgs e)
        {
            update_n_index();
            if (n_index >= 0)
                Node_List.SelectedItems[0].SubItems[2].Text = Speech_Field.Text;
        }

        private void GML_Field_TextChanged(object sender, EventArgs e)
        {
        }

        private void Response_Field_TextChanged(object sender, EventArgs e)
        {
            editResponse(2, ResponseText_Field.Text);
        }

        private void Delete_Node_Click(object sender, EventArgs e)
        {
            update_n_index();
            if (n_index < 0)
                return;

            Node_List.Items[n_index].Remove();

            for(int i=0; i<Node_List.Items.Count; i++)
            {
                Node_List.Items[i].SubItems[0].Text = "" + i;
            }
        }

        private void Add_Response_Click(object sender, EventArgs e)
        {
            addResponse("Description", "Response", "scr_conv_goto", "arg");
        }

        private void ResponseList_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Response_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_r_index();
            bool r_selected;

            if (r_index >= 0)
            {
                r_selected = true;

                ResponseID_Field.Text = "" + r_index;
                ResponseDescription_Field.Text = Node_List.Items[n_index].SubItems[3 + (r_index * 4)].Text;
                ResponseText_Field.Text = Node_List.Items[n_index].SubItems[4 + (r_index * 4)].Text;
                Script_Field.Text = Node_List.Items[n_index].SubItems[5 + (r_index * 4)].Text;
                ScriptArgs_Field.Text = Node_List.Items[n_index].SubItems[6 + (r_index * 4)].Text;
            }
            else
            {
                r_selected = false;

                ResponseID_Field.Text = "";
                ResponseDescription_Field.Text = "";
                ResponseText_Field.Text = "";
                Script_Field.Text = "";
                ScriptArgs_Field.Text = "";
            }

            ResponseDescription_Field.Enabled = r_selected;
            ResponseText_Field.Enabled = r_selected;
            Script_Field.Enabled = r_selected;
            ScriptArgs_Field.Enabled = r_selected;
            Delete_Response.Enabled = r_selected;
            ResponseMove_Up.Enabled = r_selected;
            ResponseMove_Down.Enabled = r_selected;

        }

        private void generate_GML()
        {
            try
            {
                LockWindowUpdate(GML_Field.Handle);

                int k;
                GML_Field.Text = "";
                for (int i = 0; i < Node_List.Items.Count; i++)
                {
                    GML_Field.Text += "convo[" + i + ", 0] = \"" + Node_List.Items[i].SubItems[1].Text + "\";\r\n";
                    GML_Field.Text += "convo[" + i + ", 1] = \"" + Node_List.Items[i].SubItems[2].Text + "\";\r\n";
                    k = 3;
                    for (int j = 3; j < Node_List.Items[i].SubItems.Count; j += 4, k += 2)
                    {
                        GML_Field.Text += "convo[" + i + ", " + (k - 1) + "] = \"" + Node_List.Items[i].SubItems[j + 1].Text + "\";\r\n";
                        GML_Field.Text += "convo[" + i + ", " + (k + 0) + "] = ds_list_create(); ds_list_add(convo[" + i + ", " + (k + 0) + "]";
                        GML_Field.Text += ", \r\n              " + Node_List.Items[i].SubItems[j + 2].Text;
                        if (Node_List.Items[i].SubItems[j + 3].Text.Length > 0)
                            GML_Field.Text += ", " + Node_List.Items[i].SubItems[j + 3].Text;
                        GML_Field.Text += ");\r\n";
                    }
                    if( i != Node_List.Items.Count-1 )
                        GML_Field.Text += "\r\n";
                }
                File.WriteAllText("C:\\GMLM\\backup.gmlm", GML_Field.Text);
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        private void ResponseID_Field_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResponseDescription_Field_TextChanged(object sender, EventArgs e)
        {
            editResponse(1, ResponseDescription_Field.Text);
        }

        private void Script_Field_TextChanged(object sender, EventArgs e)
        {
            editResponse(3, Script_Field.Text);
        }

        private void addResponse(string Description, string Text, string Script, string Args)
        {
            update_n_index();
            if (n_index < 0)
                return;

            Node_List.Items[n_index].SubItems.AddRange(new string[] { Description, Text, Script, Args });
            displayResponses();
        }

        private void displayResponses()
        {
            Response_List.Items.Clear();

            ResponseID_Field.Text = "";
            ResponseDescription_Field.Text = "";
            ResponseText_Field.Text = "";
            Script_Field.Text = "";
            ScriptArgs_Field.Text = "";

            ResponseDescription_Field.Enabled = false;
            ResponseText_Field.Enabled = false;
            Script_Field.Enabled = false;
            ScriptArgs_Field.Enabled = false;

            Delete_Response.Enabled = false;
            ResponseMove_Up.Enabled = false;
            ResponseMove_Down.Enabled = false;

            update_n_index();
            if (n_index < 0)
                return;

            for (int i = 3; i < Node_List.Items[n_index].SubItems.Count; i += 4)
                Response_List.Items.Add("" + Response_List.Items.Count).SubItems.AddRange(new string[] {
                                                                Node_List.Items[n_index].SubItems[i + 0].Text,
                                                                Node_List.Items[n_index].SubItems[i + 1].Text,
                                                                Node_List.Items[n_index].SubItems[i + 2].Text,
                                                                Node_List.Items[n_index].SubItems[i + 3].Text });
        }

        private void editResponse(int field, string value)
        {
            update_r_index();
            if (r_index < 0)
                return;

            Response_List.Items[r_index].SubItems[field].Text = value;
            Node_List.Items[n_index].SubItems[2 + field + (r_index * 4)].Text = value;
        }

        private void ScriptArgs_Field_TextChanged(object sender, EventArgs e)
        {
            editResponse(4, ScriptArgs_Field.Text);
        }

        private void Node_List_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void NodeMove_Up_Click(object sender, EventArgs e)
        {
            update_n_index();
            if (n_index < 1)
                return;

            int moveto = n_index - 1;

            Node_List.Items[n_index].SubItems[0].Text = "" + (moveto);
            Node_List.Items[moveto].SubItems[0].Text = "" + (n_index);

            ListViewItem temp = Node_List.Items[moveto];
            Node_List.Items[moveto].Remove();
            Node_List.Items.Insert(moveto + 1, temp);

            n_index = Node_List.SelectedIndices[0];
            ID_Field.Text = "" + n_index;
        }

        private void NodeMove_Down_Click(object sender, EventArgs e)
        {
            update_n_index();
            if (n_index >= Node_List.Items.Count - 1 || n_index < 0)
                return;

            int moveto = n_index + 1;

            Node_List.Items[n_index].SubItems[0].Text = "" + (moveto);
            Node_List.Items[moveto].SubItems[0].Text = "" + (n_index);

            ListViewItem temp = Node_List.Items[moveto];
            Node_List.Items[moveto].Remove();
            Node_List.Items.Insert(moveto - 1, temp);

            n_index = Node_List.SelectedIndices[0];
            ID_Field.Text = "" + n_index;
        }

        private void Delete_Response_Click(object sender, EventArgs e)
        {
            update_r_index();
            if (r_index < 0)
                return;

            int r_temp = r_index - 1;

            Node_List.Items[n_index].SubItems.RemoveAt(3 + (r_index * 4));
            Node_List.Items[n_index].SubItems.RemoveAt(3 + (r_index * 4));
            Node_List.Items[n_index].SubItems.RemoveAt(3 + (r_index * 4));
            Node_List.Items[n_index].SubItems.RemoveAt(3 + (r_index * 4));

            displayResponses();

            if (r_temp >= 0)
                Response_List.Items[r_temp].Selected = true;

            r_index = r_temp;
        }

        private void ResponseMove_Up_Click(object sender, EventArgs e)
        {
            update_n_index();
            update_r_index();
            if (r_index < 1)
                return;

            int r_temp = r_index - 1;
            int moveto = 3 + ((r_index - 1) * 4);

            ListViewItem.ListViewSubItem temp0 = Node_List.Items[n_index].SubItems[moveto + 0];
            ListViewItem.ListViewSubItem temp1 = Node_List.Items[n_index].SubItems[moveto + 1];
            ListViewItem.ListViewSubItem temp2 = Node_List.Items[n_index].SubItems[moveto + 2];
            ListViewItem.ListViewSubItem temp3 = Node_List.Items[n_index].SubItems[moveto + 3];

            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);

            Node_List.Items[n_index].SubItems.Insert(moveto + 4 + 0, temp0);
            Node_List.Items[n_index].SubItems.Insert(moveto + 4 + 1, temp1);
            Node_List.Items[n_index].SubItems.Insert(moveto + 4 + 2, temp2);
            Node_List.Items[n_index].SubItems.Insert(moveto + 4 + 3, temp3);

            displayResponses();

            Response_List.Items[r_temp].Selected = true;
            r_index = r_temp;
        }

        private void ResponseMove_Down_Click(object sender, EventArgs e)
        {
            update_n_index();
            update_r_index();
            if (r_index >= Response_List.Items.Count - 1 || r_index < 0)
                return;

            int r_temp = r_index + 1;
            int moveto = 3 + ((r_index + 1) * 4);

            ListViewItem.ListViewSubItem temp0 = Node_List.Items[n_index].SubItems[moveto + 0];
            ListViewItem.ListViewSubItem temp1 = Node_List.Items[n_index].SubItems[moveto + 1];
            ListViewItem.ListViewSubItem temp2 = Node_List.Items[n_index].SubItems[moveto + 2];
            ListViewItem.ListViewSubItem temp3 = Node_List.Items[n_index].SubItems[moveto + 3];

            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);
            Node_List.Items[n_index].SubItems.RemoveAt(moveto);

            Node_List.Items[n_index].SubItems.Insert(moveto - 4 + 0, temp0);
            Node_List.Items[n_index].SubItems.Insert(moveto - 4 + 1, temp1);
            Node_List.Items[n_index].SubItems.Insert(moveto - 4 + 2, temp2);
            Node_List.Items[n_index].SubItems.Insert(moveto - 4 + 3, temp3);

            displayResponses();

            Response_List.Items[r_temp].Selected = true;
            r_index = r_temp;
        }

        private int update_r_index()
        {
            if (Response_List.SelectedItems.Count > 0)
                r_index = Response_List.SelectedIndices[0];
            else
                r_index = -1;

            return r_index;
        }

        private int update_n_index()
        {
            if (Node_List.SelectedItems.Count > 0)
                n_index = Node_List.SelectedIndices[0];
            else
                n_index = -1;

            return n_index;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.Filter = "GML Mapper Files (*.gmlm)|*.txt|All files (*.*)|*.*";
            File.WriteAllText(saveFileDialog1.FileName, GML_Field.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Filter = "GML Mapper Files (*.gmlm)|*.txt|All files (*.*)|*.*";
            GML_Field.Text = File.ReadAllText(openFileDialog1.FileName);
            // PARSE TEXT
        }

        private void GenerateGML_Button_Click(object sender, EventArgs e)
        {
            if (Node_List.Items.Count < 1)
                GML_Field.Text = " ";
            else
                generate_GML();

            Clipboard.SetText(GML_Field.Text);
        }
    }
}
