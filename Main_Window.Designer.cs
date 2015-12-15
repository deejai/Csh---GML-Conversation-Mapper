namespace GML_Conversation_Mapper
{
    partial class Main_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResponseText_Label = new System.Windows.Forms.Label();
            this.ResponseText_Field = new System.Windows.Forms.TextBox();
            this.Script_Label = new System.Windows.Forms.Label();
            this.Script_Field = new System.Windows.Forms.TextBox();
            this.Speech_Label = new System.Windows.Forms.Label();
            this.Speech_Field = new System.Windows.Forms.TextBox();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_Field = new System.Windows.Forms.TextBox();
            this.GML_Label = new System.Windows.Forms.Label();
            this.Add_Node = new System.Windows.Forms.Button();
            this.GML_Field = new System.Windows.Forms.TextBox();
            this.Speech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete_Node = new System.Windows.Forms.Button();
            this.Node_List = new System.Windows.Forms.ListView();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID_Field = new System.Windows.Forms.TextBox();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Delete_Response = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.ResponseList_Label = new System.Windows.Forms.Label();
            this.ResponseID_Label = new System.Windows.Forms.Label();
            this.ResponseID_Field = new System.Windows.Forms.TextBox();
            this.Form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResponseMove_Down = new System.Windows.Forms.Button();
            this.ResponseMove_Up = new System.Windows.Forms.Button();
            this.Add_Response = new System.Windows.Forms.Button();
            this.NodeMove_Up = new System.Windows.Forms.Button();
            this.NodeMove_Down = new System.Windows.Forms.Button();
            this.ScriptArgs_Label = new System.Windows.Forms.Label();
            this.ScriptArgs_Field = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Response_List = new System.Windows.Forms.ListView();
            this.Response_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResponseDescription_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResponseDescription_Label = new System.Windows.Forms.Label();
            this.ResponseDescription_Field = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GenerateGML_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Form1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResponseText_Label
            // 
            this.ResponseText_Label.AutoSize = true;
            this.ResponseText_Label.Location = new System.Drawing.Point(178, 457);
            this.ResponseText_Label.Name = "ResponseText_Label";
            this.ResponseText_Label.Size = new System.Drawing.Size(34, 13);
            this.ResponseText_Label.TabIndex = 16;
            this.ResponseText_Label.Text = "Text: ";
            // 
            // ResponseText_Field
            // 
            this.ResponseText_Field.Enabled = false;
            this.ResponseText_Field.Location = new System.Drawing.Point(181, 473);
            this.ResponseText_Field.Multiline = true;
            this.ResponseText_Field.Name = "ResponseText_Field";
            this.ResponseText_Field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseText_Field.Size = new System.Drawing.Size(195, 68);
            this.ResponseText_Field.TabIndex = 17;
            this.ResponseText_Field.TextChanged += new System.EventHandler(this.Response_Field_TextChanged);
            // 
            // Script_Label
            // 
            this.Script_Label.AutoSize = true;
            this.Script_Label.Location = new System.Drawing.Point(178, 544);
            this.Script_Label.Name = "Script_Label";
            this.Script_Label.Size = new System.Drawing.Size(40, 13);
            this.Script_Label.TabIndex = 18;
            this.Script_Label.Text = "Script: ";
            // 
            // Script_Field
            // 
            this.Script_Field.Enabled = false;
            this.Script_Field.Location = new System.Drawing.Point(181, 560);
            this.Script_Field.Name = "Script_Field";
            this.Script_Field.Size = new System.Drawing.Size(85, 20);
            this.Script_Field.TabIndex = 19;
            this.Script_Field.TextChanged += new System.EventHandler(this.Script_Field_TextChanged);
            // 
            // Speech_Label
            // 
            this.Speech_Label.AutoSize = true;
            this.Speech_Label.Location = new System.Drawing.Point(12, 307);
            this.Speech_Label.Name = "Speech_Label";
            this.Speech_Label.Size = new System.Drawing.Size(50, 13);
            this.Speech_Label.TabIndex = 10;
            this.Speech_Label.Text = "Speech: ";
            // 
            // Speech_Field
            // 
            this.Speech_Field.Enabled = false;
            this.Speech_Field.Location = new System.Drawing.Point(15, 323);
            this.Speech_Field.Multiline = true;
            this.Speech_Field.Name = "Speech_Field";
            this.Speech_Field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Speech_Field.Size = new System.Drawing.Size(361, 84);
            this.Speech_Field.TabIndex = 11;
            this.Speech_Field.TextChanged += new System.EventHandler(this.Speech_Field_TextChanged);
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(79, 262);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(66, 13);
            this.Description_Label.TabIndex = 8;
            this.Description_Label.Text = "Description: ";
            // 
            // Description_Field
            // 
            this.Description_Field.Enabled = false;
            this.Description_Field.Location = new System.Drawing.Point(82, 278);
            this.Description_Field.Name = "Description_Field";
            this.Description_Field.Size = new System.Drawing.Size(294, 20);
            this.Description_Field.TabIndex = 9;
            this.Description_Field.TextChanged += new System.EventHandler(this.Description_Field_TextChanged);
            // 
            // GML_Label
            // 
            this.GML_Label.AutoSize = true;
            this.GML_Label.Location = new System.Drawing.Point(385, 31);
            this.GML_Label.Name = "GML_Label";
            this.GML_Label.Size = new System.Drawing.Size(58, 13);
            this.GML_Label.TabIndex = 28;
            this.GML_Label.Text = "GML Code";
            // 
            // Add_Node
            // 
            this.Add_Node.Location = new System.Drawing.Point(12, 227);
            this.Add_Node.Name = "Add_Node";
            this.Add_Node.Size = new System.Drawing.Size(98, 23);
            this.Add_Node.TabIndex = 2;
            this.Add_Node.Text = "Add Node";
            this.Add_Node.UseVisualStyleBackColor = true;
            this.Add_Node.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GML_Field
            // 
            this.GML_Field.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GML_Field.Location = new System.Drawing.Point(388, 48);
            this.GML_Field.Multiline = true;
            this.GML_Field.Name = "GML_Field";
            this.GML_Field.ReadOnly = true;
            this.GML_Field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GML_Field.Size = new System.Drawing.Size(470, 496);
            this.GML_Field.TabIndex = 29;
            this.GML_Field.TextChanged += new System.EventHandler(this.GML_Field_TextChanged);
            // 
            // Speech
            // 
            this.Speech.Text = "Speech";
            this.Speech.Width = 203;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 91;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 37;
            // 
            // Delete_Node
            // 
            this.Delete_Node.Location = new System.Drawing.Point(115, 227);
            this.Delete_Node.Name = "Delete_Node";
            this.Delete_Node.Size = new System.Drawing.Size(98, 23);
            this.Delete_Node.TabIndex = 3;
            this.Delete_Node.Text = "Delete Node";
            this.Delete_Node.UseVisualStyleBackColor = true;
            this.Delete_Node.Click += new System.EventHandler(this.Delete_Node_Click);
            // 
            // Node_List
            // 
            this.Node_List.AutoArrange = false;
            this.Node_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Description,
            this.Speech});
            this.Node_List.FullRowSelect = true;
            this.Node_List.GridLines = true;
            this.Node_List.HideSelection = false;
            this.Node_List.Location = new System.Drawing.Point(12, 34);
            this.Node_List.MultiSelect = false;
            this.Node_List.Name = "Node_List";
            this.Node_List.Size = new System.Drawing.Size(363, 187);
            this.Node_List.TabIndex = 1;
            this.Node_List.UseCompatibleStateImageBehavior = false;
            this.Node_List.View = System.Windows.Forms.View.Details;
            this.Node_List.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Node_List_ItemSelectionChanged);
            this.Node_List.SelectedIndexChanged += new System.EventHandler(this.Node_List_SelectedIndexChanged);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(12, 262);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(24, 13);
            this.ID_Label.TabIndex = 6;
            this.ID_Label.Text = "ID: ";
            // 
            // ID_Field
            // 
            this.ID_Field.Enabled = false;
            this.ID_Field.Location = new System.Drawing.Point(15, 278);
            this.ID_Field.Name = "ID_Field";
            this.ID_Field.Size = new System.Drawing.Size(47, 20);
            this.ID_Field.TabIndex = 7;
            this.ID_Field.TextChanged += new System.EventHandler(this.ID_Field_TextChanged);
            // 
            // Delete_Response
            // 
            this.Delete_Response.Enabled = false;
            this.Delete_Response.Location = new System.Drawing.Point(59, 558);
            this.Delete_Response.Name = "Delete_Response";
            this.Delete_Response.Size = new System.Drawing.Size(34, 23);
            this.Delete_Response.TabIndex = 25;
            this.Delete_Response.Text = "Del";
            this.Delete_Response.UseVisualStyleBackColor = true;
            this.Delete_Response.Click += new System.EventHandler(this.Delete_Response_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ResponseList_Label
            // 
            this.ResponseList_Label.AutoSize = true;
            this.ResponseList_Label.Location = new System.Drawing.Point(12, 417);
            this.ResponseList_Label.Name = "ResponseList_Label";
            this.ResponseList_Label.Size = new System.Drawing.Size(66, 13);
            this.ResponseList_Label.TabIndex = 22;
            this.ResponseList_Label.Text = "Responses: ";
            // 
            // ResponseID_Label
            // 
            this.ResponseID_Label.AutoSize = true;
            this.ResponseID_Label.Location = new System.Drawing.Point(178, 418);
            this.ResponseID_Label.Name = "ResponseID_Label";
            this.ResponseID_Label.Size = new System.Drawing.Size(24, 13);
            this.ResponseID_Label.TabIndex = 12;
            this.ResponseID_Label.Text = "ID: ";
            // 
            // ResponseID_Field
            // 
            this.ResponseID_Field.Enabled = false;
            this.ResponseID_Field.Location = new System.Drawing.Point(181, 434);
            this.ResponseID_Field.Name = "ResponseID_Field";
            this.ResponseID_Field.Size = new System.Drawing.Size(47, 20);
            this.ResponseID_Field.TabIndex = 13;
            this.ResponseID_Field.TextChanged += new System.EventHandler(this.ResponseID_Field_TextChanged);
            // 
            // ResponseMove_Down
            // 
            this.ResponseMove_Down.Enabled = false;
            this.ResponseMove_Down.Location = new System.Drawing.Point(136, 558);
            this.ResponseMove_Down.Name = "ResponseMove_Down";
            this.ResponseMove_Down.Size = new System.Drawing.Size(23, 23);
            this.ResponseMove_Down.TabIndex = 27;
            this.ResponseMove_Down.Text = "▼";
            this.ResponseMove_Down.UseVisualStyleBackColor = true;
            this.ResponseMove_Down.Click += new System.EventHandler(this.ResponseMove_Down_Click);
            // 
            // ResponseMove_Up
            // 
            this.ResponseMove_Up.Enabled = false;
            this.ResponseMove_Up.Location = new System.Drawing.Point(103, 558);
            this.ResponseMove_Up.Name = "ResponseMove_Up";
            this.ResponseMove_Up.Size = new System.Drawing.Size(23, 23);
            this.ResponseMove_Up.TabIndex = 26;
            this.ResponseMove_Up.Text = "▲";
            this.ResponseMove_Up.UseVisualStyleBackColor = true;
            this.ResponseMove_Up.Click += new System.EventHandler(this.ResponseMove_Up_Click);
            // 
            // Add_Response
            // 
            this.Add_Response.Enabled = false;
            this.Add_Response.Location = new System.Drawing.Point(15, 558);
            this.Add_Response.Name = "Add_Response";
            this.Add_Response.Size = new System.Drawing.Size(34, 23);
            this.Add_Response.TabIndex = 24;
            this.Add_Response.Text = "Add";
            this.Add_Response.UseVisualStyleBackColor = true;
            this.Add_Response.Click += new System.EventHandler(this.Add_Response_Click);
            // 
            // NodeMove_Up
            // 
            this.NodeMove_Up.Location = new System.Drawing.Point(218, 227);
            this.NodeMove_Up.Name = "NodeMove_Up";
            this.NodeMove_Up.Size = new System.Drawing.Size(76, 23);
            this.NodeMove_Up.TabIndex = 4;
            this.NodeMove_Up.Text = "Move Up";
            this.NodeMove_Up.UseVisualStyleBackColor = true;
            this.NodeMove_Up.Click += new System.EventHandler(this.NodeMove_Up_Click);
            // 
            // NodeMove_Down
            // 
            this.NodeMove_Down.Location = new System.Drawing.Point(299, 227);
            this.NodeMove_Down.Name = "NodeMove_Down";
            this.NodeMove_Down.Size = new System.Drawing.Size(76, 23);
            this.NodeMove_Down.TabIndex = 5;
            this.NodeMove_Down.Text = "Move Down";
            this.NodeMove_Down.UseVisualStyleBackColor = true;
            this.NodeMove_Down.Click += new System.EventHandler(this.NodeMove_Down_Click);
            // 
            // ScriptArgs_Label
            // 
            this.ScriptArgs_Label.AutoSize = true;
            this.ScriptArgs_Label.Location = new System.Drawing.Point(278, 544);
            this.ScriptArgs_Label.Name = "ScriptArgs_Label";
            this.ScriptArgs_Label.Size = new System.Drawing.Size(34, 13);
            this.ScriptArgs_Label.TabIndex = 20;
            this.ScriptArgs_Label.Text = "Args: ";
            // 
            // ScriptArgs_Field
            // 
            this.ScriptArgs_Field.Enabled = false;
            this.ScriptArgs_Field.Location = new System.Drawing.Point(281, 560);
            this.ScriptArgs_Field.Name = "ScriptArgs_Field";
            this.ScriptArgs_Field.Size = new System.Drawing.Size(95, 20);
            this.ScriptArgs_Field.TabIndex = 21;
            this.ScriptArgs_Field.TextChanged += new System.EventHandler(this.ScriptArgs_Field_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // Response_List
            // 
            this.Response_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Response_ID,
            this.ResponseDescription_Col});
            this.Response_List.Enabled = false;
            this.Response_List.FullRowSelect = true;
            this.Response_List.GridLines = true;
            this.Response_List.HideSelection = false;
            this.Response_List.LabelWrap = false;
            this.Response_List.Location = new System.Drawing.Point(15, 434);
            this.Response_List.Name = "Response_List";
            this.Response_List.Size = new System.Drawing.Size(144, 118);
            this.Response_List.TabIndex = 23;
            this.Response_List.UseCompatibleStateImageBehavior = false;
            this.Response_List.View = System.Windows.Forms.View.Details;
            this.Response_List.SelectedIndexChanged += new System.EventHandler(this.Response_List_SelectedIndexChanged);
            // 
            // Response_ID
            // 
            this.Response_ID.Text = "ID";
            this.Response_ID.Width = 25;
            // 
            // ResponseDescription_Col
            // 
            this.ResponseDescription_Col.Text = "Description";
            this.ResponseDescription_Col.Width = 95;
            // 
            // ResponseDescription_Label
            // 
            this.ResponseDescription_Label.AutoSize = true;
            this.ResponseDescription_Label.Location = new System.Drawing.Point(245, 418);
            this.ResponseDescription_Label.Name = "ResponseDescription_Label";
            this.ResponseDescription_Label.Size = new System.Drawing.Size(66, 13);
            this.ResponseDescription_Label.TabIndex = 14;
            this.ResponseDescription_Label.Text = "Description: ";
            // 
            // ResponseDescription_Field
            // 
            this.ResponseDescription_Field.Enabled = false;
            this.ResponseDescription_Field.Location = new System.Drawing.Point(248, 434);
            this.ResponseDescription_Field.Name = "ResponseDescription_Field";
            this.ResponseDescription_Field.Size = new System.Drawing.Size(128, 20);
            this.ResponseDescription_Field.TabIndex = 15;
            this.ResponseDescription_Field.TextChanged += new System.EventHandler(this.ResponseDescription_Field_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // GenerateGML_Button
            // 
            this.GenerateGML_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateGML_Button.Location = new System.Drawing.Point(388, 547);
            this.GenerateGML_Button.Name = "GenerateGML_Button";
            this.GenerateGML_Button.Size = new System.Drawing.Size(470, 34);
            this.GenerateGML_Button.TabIndex = 30;
            this.GenerateGML_Button.Text = "Generate and Copy to Clipboard";
            this.GenerateGML_Button.UseVisualStyleBackColor = true;
            this.GenerateGML_Button.Click += new System.EventHandler(this.GenerateGML_Button_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 589);
            this.Controls.Add(this.GenerateGML_Button);
            this.Controls.Add(this.ResponseDescription_Label);
            this.Controls.Add(this.ResponseDescription_Field);
            this.Controls.Add(this.Response_List);
            this.Controls.Add(this.ScriptArgs_Label);
            this.Controls.Add(this.ScriptArgs_Field);
            this.Controls.Add(this.NodeMove_Down);
            this.Controls.Add(this.NodeMove_Up);
            this.Controls.Add(this.ResponseMove_Down);
            this.Controls.Add(this.ResponseMove_Up);
            this.Controls.Add(this.ResponseID_Label);
            this.Controls.Add(this.ResponseID_Field);
            this.Controls.Add(this.ResponseList_Label);
            this.Controls.Add(this.ResponseText_Label);
            this.Controls.Add(this.Delete_Response);
            this.Controls.Add(this.ResponseText_Field);
            this.Controls.Add(this.Add_Response);
            this.Controls.Add(this.Script_Label);
            this.Controls.Add(this.Script_Field);
            this.Controls.Add(this.Speech_Label);
            this.Controls.Add(this.Speech_Field);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Description_Field);
            this.Controls.Add(this.GML_Label);
            this.Controls.Add(this.Add_Node);
            this.Controls.Add(this.GML_Field);
            this.Controls.Add(this.Delete_Node);
            this.Controls.Add(this.Node_List);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.ID_Field);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "GML Conversation Mapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingSource Form1BindingSource;
        internal System.Windows.Forms.Label ResponseText_Label;
        internal System.Windows.Forms.TextBox ResponseText_Field;
        internal System.Windows.Forms.Label Script_Label;
        internal System.Windows.Forms.TextBox Script_Field;
        internal System.Windows.Forms.Label Speech_Label;
        internal System.Windows.Forms.TextBox Speech_Field;
        internal System.Windows.Forms.Label Description_Label;
        internal System.Windows.Forms.TextBox Description_Field;
        internal System.Windows.Forms.Label GML_Label;
        internal System.Windows.Forms.Button Add_Node;
        internal System.Windows.Forms.TextBox GML_Field;
        internal System.Windows.Forms.ColumnHeader Speech;
        internal System.Windows.Forms.ColumnHeader Description;
        internal System.Windows.Forms.ColumnHeader ID;
        internal System.Windows.Forms.Button Delete_Node;
        internal System.Windows.Forms.ListView Node_List;
        internal System.Windows.Forms.Label ID_Label;
        internal System.Windows.Forms.TextBox ID_Field;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.Button Delete_Response;
        private System.Diagnostics.Process process1;
        internal System.Windows.Forms.Label ResponseID_Label;
        internal System.Windows.Forms.TextBox ResponseID_Field;
        internal System.Windows.Forms.Label ResponseList_Label;
        internal System.Windows.Forms.Button ResponseMove_Down;
        internal System.Windows.Forms.Button ResponseMove_Up;
        internal System.Windows.Forms.Button Add_Response;
        internal System.Windows.Forms.Button NodeMove_Down;
        internal System.Windows.Forms.Button NodeMove_Up;
        internal System.Windows.Forms.Label ScriptArgs_Label;
        internal System.Windows.Forms.TextBox ScriptArgs_Field;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ListView Response_List;
        private System.Windows.Forms.ColumnHeader Response_ID;
        private System.Windows.Forms.ColumnHeader ResponseDescription_Col;
        internal System.Windows.Forms.Label ResponseDescription_Label;
        internal System.Windows.Forms.TextBox ResponseDescription_Field;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button GenerateGML_Button;
    }
}

