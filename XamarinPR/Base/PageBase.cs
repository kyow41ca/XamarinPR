using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamarinPR.Base
{
    public class PageBase : ContentPage
    {
        public PageBase()
        {
            // iOS用のSetUseSafeArea設定
            On<iOS>().SetUseSafeArea(true);
        }
    }
}
