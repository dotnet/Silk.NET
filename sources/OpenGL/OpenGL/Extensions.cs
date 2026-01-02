// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenGL;

public partial class GL
{
    public static void ThrowError()
    {
        var err = GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenGLException(err);
            Throw(err);
        }
    }
}

public static class Extensions
{
    public static void ThrowError(this IGL gl)
    {
        var err = gl.GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenGLException(err);
            Throw(err);
        }
    }
}
