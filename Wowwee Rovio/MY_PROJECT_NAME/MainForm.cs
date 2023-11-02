using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ARC;

namespace WowweeRovio {

  public partial class MainForm : ARC.UCForms.FormPluginMaster {

    RovioController _rc;

    public MainForm() {

      InitializeComponent();

      // show a config button in the title bar. Set this to false if you do not have a config form.
      ConfigButton = true;

      nsSpeed.Minimum = MovementManager.MIN_SPEED;
      nsSpeed.Maximum = MovementManager.MAX_SPEED;
    }

    private void MainForm_Load(object sender, EventArgs e) {

      FormMain.MovementPanel = this;

      EZBManager.MovementManager.OnMovement2 += Movement_OnMovement2;
      EZBManager.MovementManager.OnSpeedChanged += Movement_OnSpeedChanged;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {

      FormMain.MovementPanel = null;

      EZBManager.MovementManager.OnMovement2 -= Movement_OnMovement2;
      EZBManager.MovementManager.OnSpeedChanged -= Movement_OnSpeedChanged;

      ARC.Scripting.ScriptManager.RemoveExecutor(Text);
    }

    public override void SetConfiguration(ARC.Config.Sub.PluginV1 cf) {

      cf.STORAGE.AddIfNotExist(ConfigTitles.Username, string.Empty);
      cf.STORAGE.AddIfNotExist(ConfigTitles.Password, string.Empty);
      cf.STORAGE.AddIfNotExist(ConfigTitles.IPAddress, "192.168.0.1");

      _rc = new RovioController(
        cf.STORAGE[ConfigTitles.Username].ToString(),
        cf.STORAGE[ConfigTitles.Password].ToString(),
        cf.STORAGE[ConfigTitles.IPAddress].ToString());

      base.SetConfiguration(cf);
    }

    /// <summary>
    /// The user pressed the config button in the title bar. Show the config menu and handle the changes to the config.
    /// </summary>
    public override void ConfigPressed() {

      using (var form = new ConfigForm()) {

        form.SetConfiguration(_cf);

        if (form.ShowDialog() != DialogResult.OK)
          return;

        SetConfiguration(form.GetConfiguration());
      }
    }

    void Movement_OnSpeedChanged(int speedLeft, int speedRight) {

      nsSpeed.Value = speedLeft;
    }

    /// <summary>
    /// 1 forward
    ///2 backward
    ///3 striaght left
    ///4 straight right
    ///5 rotate left
    ///6 rotate right
    ///7 forward left
    ///8 forward right
    ///9 backward left
    ///10 backward right
    ///11 camera up
    ///12 camera down
    ///13 camera middle
    /// </summary>
    void Movement_OnMovement2(MovementManager.MovementDirectionEnum direction, byte speedLeft, byte speedRight) {

      try {

        nsSpeed.Value = speedLeft;

        switch (direction) {

          case MovementManager.MovementDirectionEnum.Stop:
            Invokers.SetBackColor(btnForward, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnRight, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnLeft, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnReverse, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnStop, Common.ChangeColorBrightness(btnForward.Parent.BackColor, -0.3f));
            _rc.ManualDrive(0, 0);
            break;
          case MovementManager.MovementDirectionEnum.Forward:
            Invokers.SetBackColor(btnForward, Common.ChangeColorBrightness(btnForward.Parent.BackColor, -0.3f));
            Invokers.SetBackColor(btnRight, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnLeft, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnReverse, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnStop, btnForward.Parent.BackColor);
            _rc.ManualDrive(1, speedLeft);
            break;
          case MovementManager.MovementDirectionEnum.Right:
            Invokers.SetBackColor(btnForward, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnRight, Common.ChangeColorBrightness(btnForward.Parent.BackColor, -0.3f));
            Invokers.SetBackColor(btnLeft, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnReverse, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnStop, btnForward.Parent.BackColor);
            _rc.ManualDrive(6, speedLeft);
            break;
          case MovementManager.MovementDirectionEnum.Reverse:
            Invokers.SetBackColor(btnForward, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnRight, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnLeft, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnReverse, Common.ChangeColorBrightness(btnForward.Parent.BackColor, -0.3f));
            Invokers.SetBackColor(btnStop, btnForward.Parent.BackColor);
            _rc.ManualDrive(2, speedLeft);
            break;
          case MovementManager.MovementDirectionEnum.Left:
            Invokers.SetBackColor(btnForward, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnRight, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnLeft, Common.ChangeColorBrightness(btnForward.Parent.BackColor, -0.3f));
            Invokers.SetBackColor(btnReverse, btnForward.Parent.BackColor);
            Invokers.SetBackColor(btnStop, btnForward.Parent.BackColor);
            _rc.ManualDrive(5, speedLeft);
            break;
        }
      } catch (Exception ex) {

        log(ex.Message);
      }
    }

    private void btnStop_Click(object sender, EventArgs e) {

      EZBManager.MovementManager.GoStop();
    }

    private void btnForward_Click(object sender, EventArgs e) {

      EZBManager.MovementManager.GoForward();
    }

    private void btnRight_Click(object sender, EventArgs e) {

      EZBManager.MovementManager.GoRight();
    }

    private void btnReverse_Click(object sender, EventArgs e) {

      EZBManager.MovementManager.GoReverse();
    }

    private void btnLeft_Click(object sender, EventArgs e) {

      EZBManager.MovementManager.GoLeft();
    }

    private void nsSpeed_OnChangeRelease(int value) {

      EZBManager.MovementManager.SetSpeedLeft((byte)value);
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e) {

      if (EZBManager.MovementManager.GetCurrentDirection != MovementManager.MovementDirectionEnum.Stop)
        return;

      if (e.KeyCode == Keys.Up)
        btnForward_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Right)
        btnRight_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Down)
        btnReverse_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Left)
        btnLeft_Click(this, new EventArgs());
      else
        btnStop_Click(this, new EventArgs());
    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e) {

      btnStop_Click(this, new EventArgs());
    }

    string getControlCommandForMethod(MethodInfo method) {

      StringBuilder args = new StringBuilder();

      foreach (var arg in method.GetParameters()) {

        string t = $"({arg.ParameterType.ToString().Replace("System.", string.Empty)})";

        if (arg.ParameterType.ToString().Contains("int", StringComparison.InvariantCultureIgnoreCase))
          args.Append($", {arg.Name}[int]");
        else if (arg.ParameterType.ToString().Contains("bool", StringComparison.InvariantCultureIgnoreCase))
          args.Append($", {arg.Name}[true|false]");
        else
          args.Append($", \"{arg.Name}[{t}]\"");
      }

      return $"\"{method.Name}\"{args}";
    }

    public override object[] GetSupportedControlCommands() {

      var ms = new List<string>();

      foreach (var m in _rc.GetType().GetMethods())
        ms.Add(getControlCommandForMethod(m));

      return ms.ToArray();
    }

    public override void SendCommand(string windowCommand, params string[] values) {

      var method = _rc.GetType().GetMethods().FirstOrDefault(x => x.Name.Equals(windowCommand, StringComparison.InvariantCultureIgnoreCase));

      if (method == null) {

        base.SendCommand(windowCommand, values);

        return;
      }

      if (method.GetParameters().Length != values.Length)
        throw new Exception($"{windowCommand} syntax is: {getControlCommandForMethod(method)}");

      var args = new List<object>();

      int i = 0;
      foreach (var value in values) {

        var arg = method.GetParameters()[i];

        if (arg.ParameterType.ToString().Contains("int64", StringComparison.InvariantCultureIgnoreCase))
          args.Add(Convert.ToInt64(value));
        else if (arg.ParameterType.ToString().Contains("int32", StringComparison.InvariantCultureIgnoreCase))
          args.Add(Convert.ToInt32(value));
        else if (arg.ParameterType.ToString().Contains("int16", StringComparison.InvariantCultureIgnoreCase))
          args.Add(Convert.ToInt16(value));
        else if (arg.ParameterType.ToString().Contains("bool", StringComparison.InvariantCultureIgnoreCase))
          args.Add(Convert.ToBoolean(value));
        else
          args.Add(value.ToString());

        i++;
      }

      try {

        log($"{method.Name}");

        var resp = method.Invoke(_rc, args.ToArray());

        if (resp != null) {

          ARC.Scripting.VariableManager.SetVariable("$RovioResponse", resp);

          log(resp.ToString());
        }
      } catch (Exception ex) {

        if (ex.InnerException != null)
          throw ex.InnerException;
        else
          throw ex;
      }
    }

    void log(string txt) {

      Invokers.SetAppendText(tbLog, true, txt);
    }
  }
}
