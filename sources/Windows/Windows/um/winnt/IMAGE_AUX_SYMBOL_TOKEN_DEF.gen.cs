// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_AUX_SYMBOL_TOKEN_DEF.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_TOKEN_DEF"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public unsafe partial struct IMAGE_AUX_SYMBOL_TOKEN_DEF
{
    /// <include file='IMAGE_AUX_SYMBOL_TOKEN_DEF.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_TOKEN_DEF.bAuxType"]/*'/>
    public byte bAuxType;
    /// <include file='IMAGE_AUX_SYMBOL_TOKEN_DEF.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_TOKEN_DEF.bReserved"]/*'/>
    public byte bReserved;
    /// <include file='IMAGE_AUX_SYMBOL_TOKEN_DEF.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_TOKEN_DEF.SymbolTableIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SymbolTableIndex;
    /// <include file='IMAGE_AUX_SYMBOL_TOKEN_DEF.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_TOKEN_DEF.rgbReserved"]/*'/>
    [NativeTypeName("BYTE[12]")]
    public fixed byte rgbReserved[12];
}