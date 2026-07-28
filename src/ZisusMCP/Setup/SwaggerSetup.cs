namespace ZisusMCP.Setup;

public static class Swagger {
	public static IServiceCollection AddSwaggerSetup(this IServiceCollection services) {
		services.AddEndpointsApiExplorer();
		services.AddSwaggerGen();

		return services;
	}

	public static WebApplication UseSwaggerSetup(this WebApplication app) {
		if (app.Environment.IsDevelopment()) {
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		return app;
	}
}