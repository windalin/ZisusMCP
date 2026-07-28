namespace ZisusMCP.Functions.FileSystem;

public static class Endpoints {
	public static void MapZisusMCPFileSystem(this WebApplication app) {
		app.MapGet("/filesystem/list", (string path) => {
			if (!Directory.Exists(path)) {
				return Results.NotFound($"Directory does not exist: {path}");
			}

			var contents = Directory
				.EnumerateFileSystemEntries(path)
				.Select(Path.GetFileName)
				.ToList();

			return Results.Ok(contents);
		});
	}
}