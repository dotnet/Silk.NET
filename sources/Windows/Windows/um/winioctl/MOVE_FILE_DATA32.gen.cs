// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MOVE_FILE_DATA32.xml' path='doc/member[@name="MOVE_FILE_DATA32"]/*'/>
public partial struct MOVE_FILE_DATA32
{
    /// <include file='MOVE_FILE_DATA32.xml' path='doc/member[@name="MOVE_FILE_DATA32.FileHandle"]/*'/>
    [NativeTypeName("UINT32")]
    public uint FileHandle;
    /// <include file='MOVE_FILE_DATA32.xml' path='doc/member[@name="MOVE_FILE_DATA32.StartingVcn"]/*'/>
    public LARGE_INTEGER StartingVcn;
    /// <include file='MOVE_FILE_DATA32.xml' path='doc/member[@name="MOVE_FILE_DATA32.StartingLcn"]/*'/>
    public LARGE_INTEGER StartingLcn;
    /// <include file='MOVE_FILE_DATA32.xml' path='doc/member[@name="MOVE_FILE_DATA32.ClusterCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ClusterCount;
}