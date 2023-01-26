using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ContextMenuCustomApp.View.Common
{
    public static class Alert
    {
        public static async void InfoAsync(string content, string title = "提示")
        {
            var dialog = new ContentDialog
            {
                Title = title,
                PrimaryButtonText = "",
                CloseButtonText = "取消",
                DefaultButton = ContentDialogButton.Close,
                Content = content
            };
            await dialog.ShowAsync();
        }

        public static async Task<bool> ChooseAsync(string content, string title = "")
        {
            var dialog = new ContentDialog
            {
                Title = title,
                PrimaryButtonText = "确定",
                CloseButtonText = "取消",
                DefaultButton = ContentDialogButton.Primary,
                Content = content
            };
            var result = await dialog.ShowAsync();
            return result == ContentDialogResult.Primary;
        }
    }
}
