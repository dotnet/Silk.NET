// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "BufferAccessARB")]
    public enum BufferAccessARB : int
    {
        [NativeName("Name", "GL_READ_ONLY")]
        ReadOnly = 0x88B8,
        [NativeName("Name", "GL_WRITE_ONLY")]
        WriteOnly = 0x88B9,
        [NativeName("Name", "GL_READ_WRITE")]
        ReadWrite = 0x88BA,
    }
}
