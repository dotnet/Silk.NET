// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_PREFETCH_EX.xml' path='doc/member[@name="FILE_PREFETCH_EX"]/*' />
public unsafe partial struct FILE_PREFETCH_EX
{
    /// <include file='FILE_PREFETCH_EX.xml' path='doc/member[@name="FILE_PREFETCH_EX.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='FILE_PREFETCH_EX.xml' path='doc/member[@name="FILE_PREFETCH_EX.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='FILE_PREFETCH_EX.xml' path='doc/member[@name="FILE_PREFETCH_EX.Context"]/*' />
    [NativeTypeName("PVOID")]
    public void* Context;

    /// <include file='FILE_PREFETCH_EX.xml' path='doc/member[@name="FILE_PREFETCH_EX.Prefetch"]/*' />
    [NativeTypeName("DWORDLONG[1]")]
    public fixed ulong Prefetch[1];
}
