using MAUIGoogleAuth.GoogleAuth;
using Microsoft.Extensions.Logging;

#if ANDROID
using MAUIGoogleAuth.Platforms.Android;
#elif IOS
using MAUIGoogleAuth.Platforms.iOS;
#endif

namespace MAUIGoogleAuth;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IGoogleAuthService, GoogleAuthService>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}

