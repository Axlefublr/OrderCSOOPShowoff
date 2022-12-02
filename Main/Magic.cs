using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Main;
internal static class Magic
{
   internal static void TrustMeAndRunThis()
   {
      RunLink("https://www.youtube.com/@Axlefublr");
   }

   private static void RunLink(string url)
   {
      try
      {
         Process.Start(url);
      }
      catch
      {
         if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
         {
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
         {
            Process.Start("xdg-open", url);
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
         {
            Process.Start("open", url);
         }
         else
         {
            throw;
         }
      }
   }
}