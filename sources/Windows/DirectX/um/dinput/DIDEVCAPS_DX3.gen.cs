// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3"]/*'/>
public partial struct DIDEVCAPS_DX3
{
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwDevType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevType;
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwAxes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAxes;
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwButtons"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwButtons;
    /// <include file='DIDEVCAPS_DX3.xml' path='doc/member[@name="DIDEVCAPS_DX3.dwPOVs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPOVs;
}