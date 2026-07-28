namespace ZisusMCP.Functions.Samples;

public static class Samples {
	public static void MapZisusMCPSamples(this WebApplication app) {
		app.MapGet("/datetime", () => {
			return DateTime.Now.ToString("O");
		});
	}
}