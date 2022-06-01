using Newtonsoft.Json;

namespace RiderSourceGenBug.SourceGen;

/// <summary>
/// Объект с описанием констант
/// </summary>
public class ConstantDefinition
{
	/// <summary>
	/// Наименование права доступа
	/// </summary>
	[JsonProperty("permissionName")]
	public string PermissionName { get; set; }

	/// <summary>
	/// Текстовое описание права
	/// </summary>
	[JsonProperty("description")]
	public string Description { get; set; }

	/// <summary>
	/// Значение константы
	/// </summary>
	[JsonProperty("value")]
	public string Value { get; set; }
}