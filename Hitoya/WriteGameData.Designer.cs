namespace Hitoya
{
    partial class WriteGameData
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
            this.radio_Character = new System.Windows.Forms.RadioButton();
            this.radio_Battle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectbox_Life = new System.Windows.Forms.ComboBox();
            this.selectbox_Rotate = new System.Windows.Forms.ComboBox();
            this.selectbox_Chaos = new System.Windows.Forms.ComboBox();
            this.selectbox_Death = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textbox_Name = new System.Windows.Forms.TextBox();
            this.selectbox_Discard = new System.Windows.Forms.ComboBox();
            this.selectbox_Draw = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.selectbox_North = new System.Windows.Forms.ComboBox();
            this.selectbox_East = new System.Windows.Forms.ComboBox();
            this.selectbox_South = new System.Windows.Forms.ComboBox();
            this.selectbox_West = new System.Windows.Forms.ComboBox();
            this.checkbox_Occupyable = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_Character
            // 
            this.radio_Character.AutoSize = true;
            this.radio_Character.Location = new System.Drawing.Point(194, 25);
            this.radio_Character.Name = "radio_Character";
            this.radio_Character.Size = new System.Drawing.Size(96, 17);
            this.radio_Character.TabIndex = 0;
            this.radio_Character.TabStop = true;
            this.radio_Character.Text = "Character Card";
            this.radio_Character.UseVisualStyleBackColor = true;
            // 
            // radio_Battle
            // 
            this.radio_Battle.AutoSize = true;
            this.radio_Battle.Location = new System.Drawing.Point(514, 25);
            this.radio_Battle.Name = "radio_Battle";
            this.radio_Battle.Size = new System.Drawing.Size(69, 17);
            this.radio_Battle.TabIndex = 1;
            this.radio_Battle.TabStop = true;
            this.radio_Battle.Text = "BattleTile";
            this.radio_Battle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Type:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.selectbox_Draw);
            this.panel1.Controls.Add(this.selectbox_Discard);
            this.panel1.Controls.Add(this.textbox_Name);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.selectbox_Death);
            this.panel1.Controls.Add(this.selectbox_Chaos);
            this.panel1.Controls.Add(this.selectbox_Rotate);
            this.panel1.Controls.Add(this.selectbox_Life);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(108, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 271);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkbox_Occupyable);
            this.panel2.Controls.Add(this.selectbox_West);
            this.panel2.Controls.Add(this.selectbox_South);
            this.panel2.Controls.Add(this.selectbox_East);
            this.panel2.Controls.Add(this.selectbox_North);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(405, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 271);
            this.panel2.TabIndex = 4;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(608, 360);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 5;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(363, 427);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 6;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(108, 360);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discard:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Draw:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Power Tokens:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Life:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rotate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chaos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Death:";
            // 
            // selectbox_Life
            // 
            this.selectbox_Life.FormattingEnabled = true;
            this.selectbox_Life.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Life.Location = new System.Drawing.Point(125, 150);
            this.selectbox_Life.Name = "selectbox_Life";
            this.selectbox_Life.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Life.TabIndex = 9;
            // 
            // selectbox_Rotate
            // 
            this.selectbox_Rotate.FormattingEnabled = true;
            this.selectbox_Rotate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Rotate.Location = new System.Drawing.Point(125, 175);
            this.selectbox_Rotate.Name = "selectbox_Rotate";
            this.selectbox_Rotate.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Rotate.TabIndex = 10;
            // 
            // selectbox_Chaos
            // 
            this.selectbox_Chaos.FormattingEnabled = true;
            this.selectbox_Chaos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Chaos.Location = new System.Drawing.Point(125, 199);
            this.selectbox_Chaos.Name = "selectbox_Chaos";
            this.selectbox_Chaos.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Chaos.TabIndex = 11;
            // 
            // selectbox_Death
            // 
            this.selectbox_Death.FormattingEnabled = true;
            this.selectbox_Death.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Death.Location = new System.Drawing.Point(125, 225);
            this.selectbox_Death.Name = "selectbox_Death";
            this.selectbox_Death.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Death.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name:";
            // 
            // textbox_Name
            // 
            this.textbox_Name.Location = new System.Drawing.Point(54, 22);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.Size = new System.Drawing.Size(178, 20);
            this.textbox_Name.TabIndex = 14;
            // 
            // selectbox_Discard
            // 
            this.selectbox_Discard.FormattingEnabled = true;
            this.selectbox_Discard.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Discard.Location = new System.Drawing.Point(125, 62);
            this.selectbox_Discard.Name = "selectbox_Discard";
            this.selectbox_Discard.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Discard.TabIndex = 15;
            // 
            // selectbox_Draw
            // 
            this.selectbox_Draw.FormattingEnabled = true;
            this.selectbox_Draw.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectbox_Draw.Location = new System.Drawing.Point(125, 91);
            this.selectbox_Draw.Name = "selectbox_Draw";
            this.selectbox_Draw.Size = new System.Drawing.Size(55, 21);
            this.selectbox_Draw.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "North Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "East Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "South Value:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "West Value:";
            // 
            // selectbox_North
            // 
            this.selectbox_North.FormattingEnabled = true;
            this.selectbox_North.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "shield",
            "arrow"});
            this.selectbox_North.Location = new System.Drawing.Point(125, 70);
            this.selectbox_North.Name = "selectbox_North";
            this.selectbox_North.Size = new System.Drawing.Size(117, 21);
            this.selectbox_North.TabIndex = 17;
            // 
            // selectbox_East
            // 
            this.selectbox_East.FormattingEnabled = true;
            this.selectbox_East.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "shield",
            "arrow"});
            this.selectbox_East.Location = new System.Drawing.Point(125, 94);
            this.selectbox_East.Name = "selectbox_East";
            this.selectbox_East.Size = new System.Drawing.Size(117, 21);
            this.selectbox_East.TabIndex = 18;
            // 
            // selectbox_South
            // 
            this.selectbox_South.FormattingEnabled = true;
            this.selectbox_South.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "shield",
            "arrow"});
            this.selectbox_South.Location = new System.Drawing.Point(125, 118);
            this.selectbox_South.Name = "selectbox_South";
            this.selectbox_South.Size = new System.Drawing.Size(117, 21);
            this.selectbox_South.TabIndex = 19;
            // 
            // selectbox_West
            // 
            this.selectbox_West.FormattingEnabled = true;
            this.selectbox_West.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "shield",
            "arrow"});
            this.selectbox_West.Location = new System.Drawing.Point(125, 142);
            this.selectbox_West.Name = "selectbox_West";
            this.selectbox_West.Size = new System.Drawing.Size(117, 21);
            this.selectbox_West.TabIndex = 20;
            // 
            // checkbox_Occupyable
            // 
            this.checkbox_Occupyable.AutoSize = true;
            this.checkbox_Occupyable.Location = new System.Drawing.Point(125, 176);
            this.checkbox_Occupyable.Name = "checkbox_Occupyable";
            this.checkbox_Occupyable.Size = new System.Drawing.Size(83, 17);
            this.checkbox_Occupyable.TabIndex = 22;
            this.checkbox_Occupyable.Text = "Occupyable";
            this.checkbox_Occupyable.UseVisualStyleBackColor = true;
            // 
            // WriteGameData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 475);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_Battle);
            this.Controls.Add(this.radio_Character);
            this.Name = "WriteGameData";
            this.Text = "WriteGameData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_Character;
        private System.Windows.Forms.RadioButton radio_Battle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox selectbox_Draw;
        private System.Windows.Forms.ComboBox selectbox_Discard;
        private System.Windows.Forms.TextBox textbox_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectbox_Death;
        private System.Windows.Forms.ComboBox selectbox_Chaos;
        private System.Windows.Forms.ComboBox selectbox_Rotate;
        private System.Windows.Forms.ComboBox selectbox_Life;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectbox_West;
        private System.Windows.Forms.ComboBox selectbox_South;
        private System.Windows.Forms.ComboBox selectbox_East;
        private System.Windows.Forms.ComboBox selectbox_North;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkbox_Occupyable;
    }
}