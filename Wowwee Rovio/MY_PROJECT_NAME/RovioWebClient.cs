using System;
using System.Net;

namespace WowweeRovio {

  /// <summary>
  /// Class for performing http requests
  /// </summary>
  public class RovioWebClient {

    private RovioSettings settings;

    /// <summary>
    /// Constructor for RovioWebClient
    /// </summary>
    /// <param name="settings"></param>
    public RovioWebClient(RovioSettings settings) {

      this.settings = settings;
    }

    private class MyWebClient : WebClient {

      int _timeout;

      public MyWebClient(int timeout) {

        _timeout = timeout;
      }

      protected override WebRequest GetWebRequest(Uri uri) {

        WebRequest w = base.GetWebRequest(uri);

        w.Timeout = _timeout;

        return w;
      }
    }

    /// <summary>
    /// Web request for string data to the Rovio API 
    /// </summary>
    /// <param name="cmd">Command of the Rovio API to execute</param>
    /// <returns></returns>
    public string RequestString(string cmd) {

      if (settings.RovioAddress.Length < 1)
        throw new Exception("Invalid IP Address for Rovio");

      using (WebClient wc = new MyWebClient(2500)) {

        wc.Credentials = settings.RovioCredentials;
        wc.BaseAddress = $"http://{settings.RovioAddress}";
        Uri targetUri = new Uri(new Uri(wc.BaseAddress), cmd);

        return wc.DownloadString(targetUri);
      }
    }

    /// <summary>
    /// Web request for byte data to the Rovio API 
    /// </summary>
    /// <param name="cmd">Command of the Rovio API to execute</param>
    /// <returns></returns>
    public byte[] RequestData(string cmd) {

      if (settings.RovioAddress.Length < 1)
        throw new Exception("Invalid IP Address for Rovio");

      using (WebClient wc = new MyWebClient(2500)) {

        wc.Credentials = settings.RovioCredentials;
        wc.BaseAddress = $"http://{settings.RovioAddress}";
        Uri targetUri = new Uri(new Uri(wc.BaseAddress), cmd);

        return wc.DownloadData(targetUri);
      }
    }
  }
}
