// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.OpenGL.Legacy
{
    public delegate void DebugProc(GLEnum source, GLEnum type, int id, GLEnum severity, int length, nint message, nint userParam);
}
