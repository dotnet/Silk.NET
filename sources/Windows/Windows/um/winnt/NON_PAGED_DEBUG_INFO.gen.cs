// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct NON_PAGED_DEBUG_INFO
{
    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Signature"]/*' />
    [NativeTypeName("WORD")]
    public ushort Signature;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Flags"]/*' />
    [NativeTypeName("WORD")]
    public ushort Flags;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Machine"]/*' />
    [NativeTypeName("WORD")]
    public ushort Machine;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Characteristics"]/*' />
    [NativeTypeName("WORD")]
    public ushort Characteristics;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.SizeOfImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;

    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.ImageBase"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ImageBase;
}
