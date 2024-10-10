// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using Microsoft.CodeAnalysis;

namespace Silk.NET.Core.Analyzers;

/// <summary>
/// Helpers used in the construction of Silk.NET's analyzers and generators.
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Registers sources embedded in the calling assembly with the given embedded resource names as post-initialization
    /// output.
    /// </summary>
    /// <param name="ctx">The generator context.</param>
    /// <param name="embeddedResourceNames">The embedded resource names.</param>
    public static void RegisterPostInitializationEmbeddedSource(
        this IncrementalGeneratorInitializationContext ctx,
        params string[] embeddedResourceNames
    )
    {
        var caller = Assembly.GetCallingAssembly();
        ctx.RegisterPostInitializationOutput(x =>
        {
            foreach (var res in embeddedResourceNames)
            {
                using var stream = caller.GetManifestResourceStream(res);
                if (stream is null)
                {
                    continue;
                }

                using var sr = new StreamReader(stream);
                x.AddSource(res, sr.ReadToEnd());
            }
        });
    }
}
