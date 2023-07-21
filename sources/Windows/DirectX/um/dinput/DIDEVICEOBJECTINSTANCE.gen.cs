// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE"]/*' />
public unsafe partial struct DIDEVICEOBJECTINSTANCE
{
    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.guidType"]/*' />
    public Guid guidType;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwOfs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOfs;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.tszName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszName[260];

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwFFMaxForce"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFFMaxForce;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwFFForceResolution"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFFForceResolution;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wCollectionNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort wCollectionNumber;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wDesignatorIndex"]/*' />
    [NativeTypeName("WORD")]
    public ushort wDesignatorIndex;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wUsagePage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wUsage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsage;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.dwDimension"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDimension;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wExponent"]/*' />
    [NativeTypeName("WORD")]
    public ushort wExponent;

    /// <include file='DIDEVICEOBJECTINSTANCE.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCE.wReportId"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReportId;
}
