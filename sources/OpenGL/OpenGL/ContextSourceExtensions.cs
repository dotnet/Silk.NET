// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.OpenGL;

public static class ContextSourceExtensions
{
    private static ConditionalWeakTable<IGLContext, IGL> _cwt = new();

    public static IGL CreateOpenGl(this IGLContextSource src)
    {
        if (src.GLContext is not { } ctx)
        {
            throw new ArgumentException(
                "The given context source does not have an OpenGL context",
                nameof(src)
            );
        }

        return GL.Create(ctx);
    }

    public static IGL CreateOpenGl(this IGLContext ctx) => GL.Create(ctx);

    public static void MakeCurrent(this IGLContextSource src) => src.GLContext?.MakeCurrent();

    public static void MakeCurrent(this IGLContext ctx) =>
        GL.ThisThread.MakeCurrent(_cwt.GetValue(ctx, c => c.CreateOpenGl()));
}
