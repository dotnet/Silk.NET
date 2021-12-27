// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Statiq.ApiReference;

/// <summary>
/// Represents documentation for an API of some description. This is left purposely abstract so that it can be used for
/// multiple languages, but typical usage for a C# project might look like:<br />
/// - Category: Namespace<br />
/// - Title: Silk.NET.OpenGL<br />
/// - Markdown: null<br />
/// - Children:<br />
///     - Category: Class<br />
///     - Title: GL
///     - Markdown: "## Summary\nAPI summary goes here."
/// etc...
/// <param name="Category"></param>
/// <param name="Title"></param>
/// <param name="Markdown"></param>
/// <param name="Children"></param>
public record ApiDocumentation
(
    string? Category,
    string Title,
    string Markdown,
    ApiDocumentation[]? Children,
    Dictionary<string, string?>? Metadata = null
);
