// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvLinkageType_")]
    public enum LinkageType : int
    {
        [NativeName("Name", "SpvLinkageTypeExport")]
        Export = 0x0,
        [NativeName("Name", "SpvLinkageTypeImport")]
        Import = 0x1,
        [NativeName("Name", "SpvLinkageTypeLinkOnceODR")]
        LinkOnceOdr = 0x2,
        [NativeName("Name", "SpvLinkageTypeMax")]
        Max = 0x7FFFFFFF,
    }
}
