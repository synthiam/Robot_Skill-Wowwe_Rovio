using System.Net;

namespace WowweeRovio {

  /// <summary>
  /// Class for stroring connection settings
  /// </summary>
  public class RovioSettings {

    /// <summary>
    ///  Network Credential to access Rovio
    /// </summary>
    public NetworkCredential RovioCredentials;

    /// <summary>
    /// Address to acces Rovio
    /// </summary>
    public string RovioAddress;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="username">Username to access Rovio</param>
    /// <param name="password">Password to access Rovio</param>
    /// <param name="address">Address to acces Rovio</param>
    public RovioSettings(string username, string password, string address) {

      this.RovioCredentials = new NetworkCredential(username, password);
      this.RovioAddress = address;
    }
  }
}
