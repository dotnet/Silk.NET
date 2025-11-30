// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.OpenGL;

public static class ContextSourceExtensions
{
    private static ConditionalWeakTable<IGlContext, IGl> _cwt = new();

    public static IGl CreateOpenGl(this IGlContextSource src)
    {
        if (src.GlContext is not { } ctx)
        {
            throw new ArgumentException(
                "The given context source does not have an OpenGL context",
                nameof(src)
            );
        }

        return Gl.Create(ctx);
    }

    public static IGl CreateOpenGl(this IGlContext ctx) => Gl.Create(ctx);

    public static void MakeCurrent(this IGlContextSource src) => src.GlContext?.MakeCurrent();

    public static void MakeCurrent(this IGlContext ctx) =>
        Gl.ThisThread.MakeCurrent(_cwt.GetValue(ctx, c => c.CreateOpenGl()));
}
