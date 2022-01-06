// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DZBUFFERTYPE")]
    public enum Zbuffertype : int
    {
        [NativeName("Name", "D3DZB_FALSE")]
        ZBFalse = 0x0,
        [NativeName("Name", "D3DZB_TRUE")]
        ZBTrue = 0x1,
        [NativeName("Name", "D3DZB_USEW")]
        ZBUsew = 0x2,
        [NativeName("Name", "D3DZB_FORCE_DWORD")]
        ZBForceDword = 0x7FFFFFFF,
    }
}
