using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowweeRovio {

  public partial class ConfigForm : Form {

    private ARC.Config.Sub.PluginV1 _cf;

    public ConfigForm() {

      InitializeComponent();
    }

    public void SetConfiguration(ARC.Config.Sub.PluginV1 config) {

      try {

        _cf = config;

        tbUsername.Text = _cf.STORAGE[ConfigTitles.Username].ToString();
        tbPassword.Text = _cf.STORAGE[ConfigTitles.Password].ToString();
        tbIPAddress.Text = _cf.STORAGE[ConfigTitles.IPAddress].ToString();

      } catch (Exception ex) {

        MessageBox.Show(ex.Message, "Error loading configuration");
      }
    }

    public ARC.Config.Sub.PluginV1 GetConfiguration() {
    
      return _cf;
    }

    private void btnSave_Click(object sender, EventArgs e) {

      try {

        _cf.STORAGE[ConfigTitles.Username] = tbUsername.Text;
        _cf.STORAGE[ConfigTitles.Password] = tbPassword.Text;
        _cf.STORAGE[ConfigTitles.IPAddress] = tbIPAddress.Text;
      } catch (Exception ex) {

        MessageBox.Show(ex.Message, "Error saving configuration");

        return;
      }

      DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e) {

      DialogResult = DialogResult.Cancel;
    }
  }
}
