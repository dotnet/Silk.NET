// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct EXP_PROPERTYSTORAGE
{
    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.dwSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignature;

    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.abPropertyStorage"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte abPropertyStorage[1];
}
