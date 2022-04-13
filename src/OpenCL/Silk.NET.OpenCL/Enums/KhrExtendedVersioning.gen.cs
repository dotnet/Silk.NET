// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_khr_extended_versioning")]
    public enum KhrExtendedVersioning : int
    {
        [NativeName("Name", "CL_VERSION_MAJOR_BITS_KHR")]
        VersionMajorBitsKhr = 0x10,
        [NativeName("Name", "CL_VERSION_MINOR_BITS_KHR")]
        VersionMinorBitsKhr = 0x10,
        [NativeName("Name", "CL_VERSION_PATCH_BITS_KHR")]
        VersionPatchBitsKhr = 0x12,
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE_KHR")]
        NameVersionMaxNameSizeKhr = 0x64,
    }
}
