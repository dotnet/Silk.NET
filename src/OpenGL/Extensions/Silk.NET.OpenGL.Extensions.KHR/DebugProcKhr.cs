// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenGL.Extensions.KHR
{
    public delegate void DebugProcKhr(KHR source, KHR type, int id, KHR severity, int length, IntPtr message, IntPtr userParam);
}
