// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagBIND_FLAGS")]
    public enum BindFlags : int
    {
        [Obsolete("Deprecated in favour of \"Maybotheruser\"")]
        [NativeName("Name", "BIND_MAYBOTHERUSER")]
        BindMaybotheruser = 0x1,
        [Obsolete("Deprecated in favour of \"Justtestexistence\"")]
        [NativeName("Name", "BIND_JUSTTESTEXISTENCE")]
        BindJusttestexistence = 0x2,
        [NativeName("Name", "BIND_MAYBOTHERUSER")]
        Maybotheruser = 0x1,
        [NativeName("Name", "BIND_JUSTTESTEXISTENCE")]
        Justtestexistence = 0x2,
    }
}
