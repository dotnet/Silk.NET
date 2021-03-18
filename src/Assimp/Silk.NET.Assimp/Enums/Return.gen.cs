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
        [NativeName("Name", "aiReturn_SUCCESS")]
        ReturnSuccess = 0x0,
        [NativeName("Name", "aiReturn_FAILURE")]
        ReturnFailure = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "aiReturn_OUTOFMEMORY")]
        ReturnOutofmemory = unchecked((int) 0xFFFFFFFFFFFFFFFD),
    }
}
