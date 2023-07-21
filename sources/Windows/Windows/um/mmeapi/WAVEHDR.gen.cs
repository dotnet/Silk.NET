// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEHDR
{
    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.lpData"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpData;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.dwBufferLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferLength;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.dwBytesRecorded"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBytesRecorded;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.dwUser"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.dwLoops"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLoops;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.lpNext"]/*' />
    [NativeTypeName("struct wavehdr_tag *")]
    public WAVEHDR* lpNext;

    /// <include file='WAVEHDR.xml' path='doc/member[@name="WAVEHDR.reserved"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint reserved;
}
