// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='QUERY_FILE_LAYOUT_OUTPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_OUTPUT"]/*'/>
public partial struct QUERY_FILE_LAYOUT_OUTPUT
{
    /// <include file='QUERY_FILE_LAYOUT_OUTPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_OUTPUT.FileEntryCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileEntryCount;
    /// <include file='QUERY_FILE_LAYOUT_OUTPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_OUTPUT.FirstFileOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FirstFileOffset;
    /// <include file='QUERY_FILE_LAYOUT_OUTPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='QUERY_FILE_LAYOUT_OUTPUT.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_OUTPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}