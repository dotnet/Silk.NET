// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiDefaultLogStream")]
    public enum DefaultLogStream : int
    {
        [NativeName("Name", "aiDefaultLogStream_FILE")]
        DefaultLogStreamFile = 0x1,
        [NativeName("Name", "aiDefaultLogStream_STDOUT")]
        DefaultLogStreamStdout = 0x2,
        [NativeName("Name", "aiDefaultLogStream_STDERR")]
        DefaultLogStreamStderr = 0x4,
        [NativeName("Name", "aiDefaultLogStream_DEBUGGER")]
        DefaultLogStreamDebugger = 0x8,
    }
}
