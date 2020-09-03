namespace Login
{
    partial class Users
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
            this.BTNUser1 = new System.Windows.Forms.Button();
            this.BTNUser2 = new System.Windows.Forms.Button();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNUser1
            // 
            this.BTNUser1.BackColor = System.Drawing.Color.Transparent;
            this.BTNUser1.BackgroundImage = global::Login.Properties.Resources.botaosds12;
            this.BTNUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNUser1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNUser1.Location = new System.Drawing.Point(172, 12);
            this.BTNUser1.Name = "BTNUser1";
            this.BTNUser1.Size = new System.Drawing.Size(123, 97);
            this.BTNUser1.TabIndex = 0;
            this.BTNUser1.UseVisualStyleBackColor = false;
            this.BTNUser1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNUser2
            // 
            this.BTNUser2.BackColor = System.Drawing.Color.Transparent;
            this.BTNUser2.BackgroundImage = global::Login.Properties.Resources.botaonovos21;
            this.BTNUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNUser2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNUser2.Location = new System.Drawing.Point(341, 12);
            this.BTNUser2.Name = "BTNUser2";
            this.BTNUser2.Size = new System.Drawing.Size(123, 97);
            this.BTNUser2.TabIndex = 1;
            this.BTNUser2.UseVisualStyleBackColor = false;
            this.BTNUser2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNFechar
            // 
            this.BTNFechar.BackColor = System.Drawing.Color.Transparent;
            this.BTNFechar.BackgroundImage = global::Login.Properties.Resources.close_icon;
            this.BTNFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNFechar.Location = new System.Drawing.Point(581, 12);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(33, 29);
            this.BTNFechar.TabIndex = 2;
            this.BTNFechar.UseVisualStyleBackColor = false;
            this.BTNFechar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.selcuser;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 324);
            this.ControlBox = false;
            this.Controls.Add(this.BTNFechar);
            this.Controls.Add(this.BTNUser2);
            this.Controls.Add(this.BTNUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNUser1;
        private System.Windows.Forms.Button BTNUser2;
        private System.Windows.Forms.Button BTNFechar;
    }
}