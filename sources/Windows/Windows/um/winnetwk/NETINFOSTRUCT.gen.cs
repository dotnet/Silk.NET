// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT"]/*'/>
public partial struct NETINFOSTRUCT
{
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwProviderVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProviderVersion;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwCharacteristics"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCharacteristics;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwHandle"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwHandle;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.wNetType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wNetType;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwPrinters"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPrinters;
    /// <include file='NETINFOSTRUCT.xml' path='doc/member[@name="NETINFOSTRUCT.dwDrives"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDrives;
}