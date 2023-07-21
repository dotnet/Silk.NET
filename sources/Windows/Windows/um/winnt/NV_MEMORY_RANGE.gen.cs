// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NV_MEMORY_RANGE.xml' path='doc/member[@name="NV_MEMORY_RANGE"]/*' />
public unsafe partial struct NV_MEMORY_RANGE
{
    /// <include file='NV_MEMORY_RANGE.xml' path='doc/member[@name="NV_MEMORY_RANGE.BaseAddress"]/*' />
    public void* BaseAddress;

    /// <include file='NV_MEMORY_RANGE.xml' path='doc/member[@name="NV_MEMORY_RANGE.Length"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint Length;
}
