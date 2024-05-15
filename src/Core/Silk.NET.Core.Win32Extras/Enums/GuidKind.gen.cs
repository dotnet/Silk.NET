// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagGUIDKIND")]
    public enum GuidKind : int
    {
        [NativeName("Name", "GUIDKIND_DEFAULT_SOURCE_DISP_IID")]
        GuidkindDefaultSourceDispIid = 0x1,
    }
}
