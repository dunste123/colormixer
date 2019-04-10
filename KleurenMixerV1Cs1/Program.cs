using System;
using System.Windows.Forms;
using DMXControl;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new ColorMixerV2());
    }
}