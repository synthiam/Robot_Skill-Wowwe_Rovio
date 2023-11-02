namespace WowweeRovio {
  partial class ConfigForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.ucHelpHover1 = new ARC.UCForms.UC.UCHelpHover();
      this.ucHelpHover2 = new ARC.UCForms.UC.UCHelpHover();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ucHelpHover3 = new ARC.UCForms.UC.UCHelpHover();
      this.tbIPAddress = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover3)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 120);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(439, 62);
      this.panel1.TabIndex = 0;
      // 
      // btnCancel
      // 
      this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Location = new System.Drawing.Point(100, 0);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(99, 62);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Location = new System.Drawing.Point(0, 0);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 62);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 22);
      this.label1.TabIndex = 1;
      this.label1.Text = "Username:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbUsername
      // 
      this.tbUsername.Location = new System.Drawing.Point(150, 9);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(255, 22);
      this.tbUsername.TabIndex = 2;
      // 
      // ucHelpHover1
      // 
      this.ucHelpHover1.Image = ((System.Drawing.Image)(resources.GetObject("ucHelpHover1.Image")));
      this.ucHelpHover1.Location = new System.Drawing.Point(408, 9);
      this.ucHelpHover1.Margin = new System.Windows.Forms.Padding(0);
      this.ucHelpHover1.Name = "ucHelpHover1";
      this.ucHelpHover1.SetHelpText = "";
      this.ucHelpHover1.Size = new System.Drawing.Size(22, 22);
      this.ucHelpHover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ucHelpHover1.TabIndex = 3;
      this.ucHelpHover1.TabStop = false;
      // 
      // ucHelpHover2
      // 
      this.ucHelpHover2.Image = ((System.Drawing.Image)(resources.GetObject("ucHelpHover2.Image")));
      this.ucHelpHover2.Location = new System.Drawing.Point(408, 37);
      this.ucHelpHover2.Margin = new System.Windows.Forms.Padding(0);
      this.ucHelpHover2.Name = "ucHelpHover2";
      this.ucHelpHover2.SetHelpText = "";
      this.ucHelpHover2.Size = new System.Drawing.Size(22, 22);
      this.ucHelpHover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ucHelpHover2.TabIndex = 6;
      this.ucHelpHover2.TabStop = false;
      // 
      // tbPassword
      // 
      this.tbPassword.Location = new System.Drawing.Point(150, 37);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.Size = new System.Drawing.Size(255, 22);
      this.tbPassword.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(13, 37);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(130, 22);
      this.label2.TabIndex = 4;
      this.label2.Text = "Password:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ucHelpHover3
      // 
      this.ucHelpHover3.Image = ((System.Drawing.Image)(resources.GetObject("ucHelpHover3.Image")));
      this.ucHelpHover3.Location = new System.Drawing.Point(408, 65);
      this.ucHelpHover3.Margin = new System.Windows.Forms.Padding(0);
      this.ucHelpHover3.Name = "ucHelpHover3";
      this.ucHelpHover3.SetHelpText = "";
      this.ucHelpHover3.Size = new System.Drawing.Size(22, 22);
      this.ucHelpHover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ucHelpHover3.TabIndex = 9;
      this.ucHelpHover3.TabStop = false;
      // 
      // tbIPAddress
      // 
      this.tbIPAddress.Location = new System.Drawing.Point(150, 65);
      this.tbIPAddress.Name = "tbIPAddress";
      this.tbIPAddress.Size = new System.Drawing.Size(255, 22);
      this.tbIPAddress.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(13, 65);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(130, 22);
      this.label3.TabIndex = 7;
      this.label3.Text = "IP Address:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 182);
      this.Controls.Add(this.ucHelpHover3);
      this.Controls.Add(this.tbIPAddress);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.ucHelpHover2);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ucHelpHover1);
      this.Controls.Add(this.tbUsername);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "ConfigForm";
      this.ShowIcon = false;
      this.Text = "Configuration";
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ucHelpHover3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private ARC.UCForms.UC.UCHelpHover ucHelpHover1;
    private ARC.UCForms.UC.UCHelpHover ucHelpHover2;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label label2;
    private ARC.UCForms.UC.UCHelpHover ucHelpHover3;
    private System.Windows.Forms.TextBox tbIPAddress;
    private System.Windows.Forms.Label label3;
  }
}