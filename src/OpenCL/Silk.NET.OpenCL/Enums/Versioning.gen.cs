// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "Versioning")]
    public enum Versioning : int
    {
        [NativeName("Name", "CL_VERSION_MAJOR_BITS")]
        VersionMajorBits = 0x10,
        [NativeName("Name", "CL_VERSION_MINOR_BITS")]
        VersionMinorBits = 0x10,
        [NativeName("Name", "CL_VERSION_PATCH_BITS")]
        VersionPatchBits = 0x12,
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE")]
        NameVersionMaxNameSize = 0x64,
    }
}
