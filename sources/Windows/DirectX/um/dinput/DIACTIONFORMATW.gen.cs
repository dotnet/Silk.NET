// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;

namespace Silk.NET.DirectX;

/// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW"]/*' />
public unsafe partial struct DIACTIONFORMATW
{
    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwActionSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwActionSize;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwDataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDataSize;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwNumActions"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumActions;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.rgoAction"]/*' />
    [NativeTypeName("LPDIACTIONW")]
    public DIACTIONW* rgoAction;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.guidActionMap"]/*' />
    public Guid guidActionMap;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwGenre"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGenre;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.lAxisMin"]/*' />
    [NativeTypeName("LONG")]
    public int lAxisMin;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.lAxisMax"]/*' />
    [NativeTypeName("LONG")]
    public int lAxisMax;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.hInstString"]/*' />
    public HINSTANCE hInstString;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.ftTimeStamp"]/*' />
    public FILETIME ftTimeStamp;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.dwCRC"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCRC;

    /// <include file='DIACTIONFORMATW.xml' path='doc/member[@name="DIACTIONFORMATW.tszActionMap"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszActionMap[260];
}
