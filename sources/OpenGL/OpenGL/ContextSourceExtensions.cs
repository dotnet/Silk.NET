// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenGL;

public static class ContextSourceExtensions
{
    public static IGL CreateOpenGL(this IGLContextSource src)
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

    public static IGL CreateOpenGL(this IGLContext ctx) => GL.Create(ctx);

    public static void MakeCurrent(this IGLContextSource src) =>
        GL.ThisThread.MakeCurrent(src.CreateOpenGL());

    public static void MakeCurrent(this IGLContext ctx) =>
        GL.ThisThread.MakeCurrent(ctx.CreateOpenGL());
}
