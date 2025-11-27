// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Indicates that the annotated API is supported using a specific API profile.
/// </summary>
/// <param name="profile">The API profile supported.</param>
/// <param name="apiSets">The API sets in which the API is supported in this profile.</param>
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
        | AttributeTargets.Struct
        | AttributeTargets.Delegate,
    AllowMultiple = true,
    Inherited = false
)]
public class SupportedApiProfileAttribute(string profile, string[]? apiSets = null) : Attribute
{
    /// <summary>
    /// The API profile supported e.g. gl, glcore, gles2, vulkan, vulkansc, etc.
    /// </summary>
    public string Profile { get; init; } = profile;

    /// <summary>
    /// A list of API sets (i.e. feature or extension names) in which the API is supported. If any of the elements
    /// contains a <c>+</c>, then this attribute value is interpreted to mean &quot;this API requires <b>any</b> of the
    /// <b>combinations</b> of API sets&quot;. If not, this attribute value is interpreted to mean &quot;this API
    /// requires <b>any</b> of the API sets to be supported&quot;.
    /// </summary>
    /// <remarks>
    /// By default, the API is deemed supported if any of the sets in this array are supported. However, this can be
    /// changed using <see cref="RequireAll"/>.
    /// </remarks>
    public string[]? ApiSets { get; init; } = apiSets;

    /// <summary>
    /// The minimum (inclusive) version number (for illustration purposes only) wherein the API is supported by default.
    /// </summary>
    /// <remarks>
    /// This is non-normative, please rely only on <see cref="ApiSets"/> to determine whether an API is supported for a
    /// given configuration. For instance, this does not preclude extensions being in <see cref="ApiSets"/>, which may
    /// support this API earlier or regardless of the version listed in this property.
    /// </remarks>
    public string? MinVersion { get; init; }

    /// <summary>
    /// The maximum (exclusive) version number (for illustration purposes only) wherein the API is no longer supported
    /// by default.
    /// </summary>
    /// <remarks>
    /// This is non-normative, please rely only on <see cref="ApiSets"/> to determine whether an API is supported for a
    /// given configuration. For instance, this does not preclude extensions being in <see cref="ApiSets"/>, which may
    /// support this API later or regardless of the version listed in this property.
    /// </remarks>
    public string? MaxVersion { get; init; }

    /// <summary>
    /// If this <see cref="SupportedApiProfileAttribute"/> evaluates to indicate that the annotated API is supported,
    /// the support for the given API sets are also implied. If any of the implications contains a <c>+</c>, then this
    /// attribute value is interpreted to mean &quot;this API being supported may imply <b>one or more</b> of the
    /// following API set <b>combinations</b>&quot;. If not, this attribute value is interpreted to mean &quot;this API
    /// being supported implies <b>all</b> of the following API sets are also supported&quot;
    /// </summary>
    /// <remarks>
    /// This is primarily used to declare dependencies between API sets. It is not expected for this property to vary at
    /// an API-by-API level.
    /// </remarks>
    public string[]? ImpliesSets { get; init; }

    /// <summary>
    /// Requires all of the sets in <see cref="ApiSets"/> to be supported to support using the annotated API.
    /// </summary>
    public bool RequireAll { get; init; }
}
