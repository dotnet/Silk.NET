// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SHUFFLE_FILE_DATA.xml' path='doc/member[@name="SHUFFLE_FILE_DATA"]/*'/>
public partial struct SHUFFLE_FILE_DATA
{
    /// <include file='SHUFFLE_FILE_DATA.xml' path='doc/member[@name="SHUFFLE_FILE_DATA.StartingOffset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long StartingOffset;
    /// <include file='SHUFFLE_FILE_DATA.xml' path='doc/member[@name="SHUFFLE_FILE_DATA.Length"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Length;
    /// <include file='SHUFFLE_FILE_DATA.xml' path='doc/member[@name="SHUFFLE_FILE_DATA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}