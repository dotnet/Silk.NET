// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT"]/*'/>
public unsafe partial struct FIND_BY_SID_OUTPUT
{
    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.NextEntryOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;
    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileIndex;
    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileNameLength;
    /// <include file='FIND_BY_SID_OUTPUT.xml' path='doc/member[@name="FIND_BY_SID_OUTPUT.FileName"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}