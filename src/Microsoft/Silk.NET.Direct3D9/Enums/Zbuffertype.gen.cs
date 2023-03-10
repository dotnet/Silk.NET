// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DZBUFFERTYPE")]
    public enum Zbuffertype : int
    {
        [Obsolete("Deprecated in favour of \"False\"")]
        [NativeName("Name", "D3DZB_FALSE")]
        ZBFalse = 0x0,
        [Obsolete("Deprecated in favour of \"True\"")]
        [NativeName("Name", "D3DZB_TRUE")]
        ZBTrue = 0x1,
        [Obsolete("Deprecated in favour of \"Usew\"")]
        [NativeName("Name", "D3DZB_USEW")]
        ZBUsew = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DZB_FORCE_DWORD")]
        ZBForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DZB_FALSE")]
        False = 0x0,
        [NativeName("Name", "D3DZB_TRUE")]
        True = 0x1,
        [NativeName("Name", "D3DZB_USEW")]
        Usew = 0x2,
        [NativeName("Name", "D3DZB_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
