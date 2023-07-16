// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MOVE_FILE_DATA.xml' path='doc/member[@name="MOVE_FILE_DATA"]/*'/>
public partial struct MOVE_FILE_DATA
{
    /// <include file='MOVE_FILE_DATA.xml' path='doc/member[@name="MOVE_FILE_DATA.FileHandle"]/*'/>
    public HANDLE FileHandle;
    /// <include file='MOVE_FILE_DATA.xml' path='doc/member[@name="MOVE_FILE_DATA.StartingVcn"]/*'/>
    public LARGE_INTEGER StartingVcn;
    /// <include file='MOVE_FILE_DATA.xml' path='doc/member[@name="MOVE_FILE_DATA.StartingLcn"]/*'/>
    public LARGE_INTEGER StartingLcn;
    /// <include file='MOVE_FILE_DATA.xml' path='doc/member[@name="MOVE_FILE_DATA.ClusterCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ClusterCount;
}