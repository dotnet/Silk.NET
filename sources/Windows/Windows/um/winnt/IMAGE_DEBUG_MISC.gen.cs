// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC"]/*'/>
public unsafe partial struct IMAGE_DEBUG_MISC
{
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.DataType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataType;
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Unicode"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Unicode;
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Reserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];
    /// <include file='IMAGE_DEBUG_MISC.xml' path='doc/member[@name="IMAGE_DEBUG_MISC.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}