// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP"]/*'/>
public partial struct MIB_IPADDRROW_XP
{
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.dwAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAddr;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.dwIndex"]/*'/>
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.dwBCastAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBCastAddr;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.dwReasmSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmSize;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.unused1"]/*'/>
    [NativeTypeName("unsigned short")]
    public ushort unused1;
    /// <include file='MIB_IPADDRROW_XP.xml' path='doc/member[@name="MIB_IPADDRROW_XP.wType"]/*'/>
    [NativeTypeName("unsigned short")]
    public ushort wType;
}