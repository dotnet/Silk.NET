// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG"]/*' />
[Flags]
public enum D3D10_RESOURCE_MISC_FLAG
{
    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_GENERATE_MIPS"]/*' />
    D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x1,

    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_SHARED"]/*' />
    D3D10_RESOURCE_MISC_SHARED = 0x2,

    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_TEXTURECUBE"]/*' />
    D3D10_RESOURCE_MISC_TEXTURECUBE = 0x4,

    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX"]/*' />
    D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 0x10,

    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_GDI_COMPATIBLE"]/*' />
    D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 0x20,
}
