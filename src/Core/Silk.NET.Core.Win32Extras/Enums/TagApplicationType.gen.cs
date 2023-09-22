// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagApplicationType")]
    public enum TagApplicationType : int
    {
        [NativeName("Name", "ServerApplication")]
        ServerApplication = 0x0,
        [NativeName("Name", "LibraryApplication")]
        LibraryApplication = 0x1,
    }
}
