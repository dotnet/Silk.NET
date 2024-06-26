// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProc(GLEnum source, GLEnum type, int id, GLEnum severity, int length, nint message, nint userParam);
}
