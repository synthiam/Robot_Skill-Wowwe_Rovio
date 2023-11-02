namespace WowweeRovio {
  partial class MainForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnRight = new System.Windows.Forms.Button();
      this.btnReverse = new System.Windows.Forms.Button();
      this.btnLeft = new System.Windows.Forms.Button();
      this.btnForward = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.nsSpeed = new ARC.UCForms.UCNumberSelector();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.White;
      this.textBox1.Location = new System.Drawing.Point(6, 97);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(128, 15);
      this.textBox1.TabIndex = 50;
      this.textBox1.Text = "Click For Arrow Key Control";
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // btnRight
      // 
      this.btnRight.BackColor = System.Drawing.Color.White;
      this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRight.ForeColor = System.Drawing.Color.Black;
      this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
      this.btnRight.Location = new System.Drawing.Point(102, 33);
      this.btnRight.Name = "btnRight";
      this.btnRight.Size = new System.Drawing.Size(30, 30);
      this.btnRight.TabIndex = 49;
      this.btnRight.UseVisualStyleBackColor = false;
      this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
      // 
      // btnReverse
      // 
      this.btnReverse.BackColor = System.Drawing.Color.White;
      this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReverse.ForeColor = System.Drawing.Color.Black;
      this.btnReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnReverse.Image")));
      this.btnReverse.Location = new System.Drawing.Point(53, 62);
      this.btnReverse.Name = "btnReverse";
      this.btnReverse.Size = new System.Drawing.Size(30, 30);
      this.btnReverse.TabIndex = 48;
      this.btnReverse.UseVisualStyleBackColor = false;
      this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
      // 
      // btnLeft
      // 
      this.btnLeft.BackColor = System.Drawing.Color.White;
      this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLeft.ForeColor = System.Drawing.Color.Black;
      this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
      this.btnLeft.Location = new System.Drawing.Point(6, 33);
      this.btnLeft.Name = "btnLeft";
      this.btnLeft.Size = new System.Drawing.Size(30, 30);
      this.btnLeft.TabIndex = 47;
      this.btnLeft.UseVisualStyleBackColor = false;
      this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
      // 
      // btnForward
      // 
      this.btnForward.BackColor = System.Drawing.Color.White;
      this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnForward.ForeColor = System.Drawing.Color.Black;
      this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
      this.btnForward.Location = new System.Drawing.Point(53, 4);
      this.btnForward.Name = "btnForward";
      this.btnForward.Size = new System.Drawing.Size(30, 30);
      this.btnForward.TabIndex = 46;
      this.btnForward.UseVisualStyleBackColor = false;
      this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
      // 
      // btnStop
      // 
      this.btnStop.BackColor = System.Drawing.Color.White;
      this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStop.ForeColor = System.Drawing.Color.Black;
      this.btnStop.Location = new System.Drawing.Point(33, 33);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(71, 30);
      this.btnStop.TabIndex = 45;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = false;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // nsSpeed
      // 
      this.nsSpeed.BackColor = System.Drawing.Color.White;
      this.nsSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.nsSpeed.DragDirection = ARC.UCForms.UCNumberSelector.DragDirectionEnum.Vertical;
      this.nsSpeed.ForeColor = System.Drawing.Color.Black;
      this.nsSpeed.Location = new System.Drawing.Point(147, 4);
      this.nsSpeed.Margin = new System.Windows.Forms.Padding(0);
      this.nsSpeed.Maximum = 100;
      this.nsSpeed.Minimum = 0;
      this.nsSpeed.Name = "nsSpeed";
      this.nsSpeed.Size = new System.Drawing.Size(64, 55);
      this.nsSpeed.Steps = 1;
      this.nsSpeed.TabIndex = 53;
      this.nsSpeed.Value = 0;
      this.nsSpeed.OnChangeRelease += new ARC.UCForms.UCNumberSelector.OnChangeHandler(this.nsSpeed_OnChangeRelease);
      // 
      // textBox2
      // 
      this.tbLog.Location = new System.Drawing.Point(6, 118);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "textBox2";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(205, 53);
      this.tbLog.TabIndex = 54;
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(230, 183);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.nsSpeed);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnRight);
      this.Controls.Add(this.btnReverse);
      this.Controls.Add(this.btnLeft);
      this.Controls.Add(this.btnForward);
      this.Controls.Add(this.btnStop);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnRight;
    private System.Windows.Forms.Button btnReverse;
    private System.Windows.Forms.Button btnLeft;
    private System.Windows.Forms.Button btnForward;
    private System.Windows.Forms.Button btnStop;
    private ARC.UCForms.UCNumberSelector nsSpeed;
    private System.Windows.Forms.TextBox tbLog;
  }
}