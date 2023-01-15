// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiDefaultLogStream")]
    public enum DefaultLogStream : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"File\"")]
        [NativeName("Name", "aiDefaultLogStream_FILE")]
        DefaultLogStreamFile = 0x1,
        [Obsolete("Deprecated in favour of \"Stdout\"")]
        [NativeName("Name", "aiDefaultLogStream_STDOUT")]
        DefaultLogStreamStdout = 0x2,
        [Obsolete("Deprecated in favour of \"Stderr\"")]
        [NativeName("Name", "aiDefaultLogStream_STDERR")]
        DefaultLogStreamStderr = 0x4,
        [Obsolete("Deprecated in favour of \"Debugger\"")]
        [NativeName("Name", "aiDefaultLogStream_DEBUGGER")]
        DefaultLogStreamDebugger = 0x8,
        [NativeName("Name", "aiDefaultLogStream_FILE")]
        File = 0x1,
        [NativeName("Name", "aiDefaultLogStream_STDOUT")]
        Stdout = 0x2,
        [NativeName("Name", "aiDefaultLogStream_STDERR")]
        Stderr = 0x4,
        [NativeName("Name", "aiDefaultLogStream_DEBUGGER")]
        Debugger = 0x8,
    }
}
