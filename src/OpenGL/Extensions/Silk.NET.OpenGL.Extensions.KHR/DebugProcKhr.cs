// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.OpenGL.Extensions.KHR
{
    public delegate void DebugProcKhr(KHR source, KHR type, int id, KHR severity, int length, nint message, nint userParam);
}
