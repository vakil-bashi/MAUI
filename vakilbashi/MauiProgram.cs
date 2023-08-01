using Microsoft.Extensions.Logging;
using vakilbashi.Data;

namespace vakilbashi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("yekan-R.ttf", "yekan-R");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		string dbPath = DataTest.GetLocalPath("news.db3");


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

