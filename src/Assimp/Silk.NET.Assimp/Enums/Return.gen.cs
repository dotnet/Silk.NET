// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiReturn")]
    public enum Return : int
    {
        [Obsolete("Deprecated in favour of \"Success\"")]
        [NativeName("Name", "aiReturn_SUCCESS")]
        ReturnSuccess = 0x0,
        [Obsolete("Deprecated in favour of \"Failure\"")]
        [NativeName("Name", "aiReturn_FAILURE")]
        ReturnFailure = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Outofmemory\"")]
        [NativeName("Name", "aiReturn_OUTOFMEMORY")]
        ReturnOutofmemory = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "aiReturn_SUCCESS")]
        Success = 0x0,
        [NativeName("Name", "aiReturn_FAILURE")]
        Failure = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "aiReturn_OUTOFMEMORY")]
        Outofmemory = unchecked((int) 0xFFFFFFFFFFFFFFFD),
    }
}
