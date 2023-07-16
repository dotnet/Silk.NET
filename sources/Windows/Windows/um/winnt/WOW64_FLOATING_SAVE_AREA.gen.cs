// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA"]/*'/>
public unsafe partial struct WOW64_FLOATING_SAVE_AREA
{
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ControlWord"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ControlWord;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.StatusWord"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StatusWord;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.TagWord"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TagWord;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ErrorOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ErrorOffset;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ErrorSelector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ErrorSelector;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.DataOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataOffset;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.DataSelector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSelector;
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.RegisterArea"]/*'/>
    [NativeTypeName("BYTE[80]")]
    public fixed byte RegisterArea[80];
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.Cr0NpxState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Cr0NpxState;
}