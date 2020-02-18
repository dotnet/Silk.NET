// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.EGL.Extensions.KHR
{
    public delegate void DebugProcKhr
        (EGLEnum error, IntPtr command, int messageType, IntPtr threadLabel, IntPtr objectLabel, IntPtr message);
}
