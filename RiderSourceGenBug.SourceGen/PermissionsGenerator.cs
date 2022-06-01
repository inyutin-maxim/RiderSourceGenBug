using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace RiderSourceGenBug.SourceGen;

/// <inheritdoc />
[Generator]
public class PermissionsGenerator : IIncrementalGenerator
{
	public const string PermissionConstantsFileName = "PermissionsConstants.g.cs";

	/// <inheritdoc />
	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var filesProvider = context.AdditionalTextsProvider.Where(x => x.Path.EndsWith("permissions.json"));

		context.RegisterSourceOutput(filesProvider, static (productionContext, file) =>
		{
			var definitions = JsonConvert.DeserializeObject<ConstantDefinition[]>(file.GetText()
																					?.ToString()
																				?? string.Empty);

			if (definitions == null)
			{
				return;
			}

			var code = new PermissionsConstantGenerator().Generate(definitions);
			productionContext.AddSource(PermissionConstantsFileName, code);
		});
	}
}