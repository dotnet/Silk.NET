// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K"]/*'/>
public unsafe partial struct MIB_IPNETROW_W2K
{
    /// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K.dwIndex"]/*'/>
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;
    /// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K.dwPhysAddrLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;
    /// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K.bPhysAddr"]/*'/>
    [NativeTypeName("UCHAR[8]")]
    public fixed byte bPhysAddr[8];
    /// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K.dwAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAddr;
    /// <include file='MIB_IPNETROW_W2K.xml' path='doc/member[@name="MIB_IPNETROW_W2K.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
}