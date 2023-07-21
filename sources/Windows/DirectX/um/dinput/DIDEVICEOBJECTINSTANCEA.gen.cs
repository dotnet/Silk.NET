// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA"]/*' />
public unsafe partial struct DIDEVICEOBJECTINSTANCEA
{
    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.guidType"]/*' />
    public Guid guidType;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwOfs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOfs;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.tszName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszName[260];

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwFFMaxForce"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFFMaxForce;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwFFForceResolution"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFFForceResolution;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wCollectionNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort wCollectionNumber;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wDesignatorIndex"]/*' />
    [NativeTypeName("WORD")]
    public ushort wDesignatorIndex;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wUsagePage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wUsage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsage;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.dwDimension"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDimension;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wExponent"]/*' />
    [NativeTypeName("WORD")]
    public ushort wExponent;

    /// <include file='DIDEVICEOBJECTINSTANCEA.xml' path='doc/member[@name="DIDEVICEOBJECTINSTANCEA.wReportId"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReportId;
}
