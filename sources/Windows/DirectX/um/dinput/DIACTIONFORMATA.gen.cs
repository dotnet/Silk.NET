// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;

namespace Silk.NET.DirectX;

/// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA"]/*' />
public unsafe partial struct DIACTIONFORMATA
{
    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwActionSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwActionSize;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwDataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDataSize;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwNumActions"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumActions;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.rgoAction"]/*' />
    [NativeTypeName("LPDIACTIONA")]
    public DIACTIONA* rgoAction;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.guidActionMap"]/*' />
    public Guid guidActionMap;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwGenre"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGenre;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.lAxisMin"]/*' />
    [NativeTypeName("LONG")]
    public int lAxisMin;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.lAxisMax"]/*' />
    [NativeTypeName("LONG")]
    public int lAxisMax;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.hInstString"]/*' />
    public HINSTANCE hInstString;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.ftTimeStamp"]/*' />
    public FILETIME ftTimeStamp;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.dwCRC"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCRC;

    /// <include file='DIACTIONFORMATA.xml' path='doc/member[@name="DIACTIONFORMATA.tszActionMap"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszActionMap[260];
}
