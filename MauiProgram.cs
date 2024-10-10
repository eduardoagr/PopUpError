using SkiaSharp.Views.Maui.Controls.Hosting;

namespace PopUpError {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransientPopup<PopUp, PopUpViewModel>();

            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
