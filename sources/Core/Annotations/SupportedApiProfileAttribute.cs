namespace Silk.NET.Core;

/// <summary>
/// Indicates that the annotated API is supported using a specific API profile.
/// </summary>
/// <param name="profile">The API profile supported.</param>
[AttributeUsage(
    AttributeTargets.Assembly
        | AttributeTargets.Class
        | AttributeTargets.Constructor
        | AttributeTargets.Enum
        | AttributeTargets.Event
        | AttributeTargets.Field
        | AttributeTargets.Interface
        | AttributeTargets.Method
        | AttributeTargets.Module
        | AttributeTargets.Property
        | AttributeTargets.Struct,
    AllowMultiple = true,
    Inherited = false
)]
public class SupportedApiProfileAttribute(string profile) : Attribute
{
    /// <summary>
    /// The API profile supported e.g. gl, glcore, gles2, vulkan, vulkansc, etc.
    /// </summary>
    public string Profile { get; } = profile;

    /// <summary>
    /// The API extension required (in its native form).
    /// </summary>
    public string? Extension { get; init; }

    /// <summary>
    /// The minimum version of this API profile required in order to be supported.
    /// </summary>
    public string? MinVersion { get; init; }

    /// <summary>
    /// The maximum version of this API profile required in order to be supported.
    /// </summary>
    public string? MaxVersion { get; init; }
}
