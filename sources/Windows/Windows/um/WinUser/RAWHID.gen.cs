// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RAWHID.xml' path='doc/member[@name="RAWHID"]/*'/>
public unsafe partial struct RAWHID
{
    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.dwSizeHid"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSizeHid;
    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.dwCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCount;
    /// <include file='RAWHID.xml' path='doc/member[@name="RAWHID.bRawData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bRawData[1];
}