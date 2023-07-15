// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SharedVirtualDiskSupportType.xml' path='doc/member[@name="SharedVirtualDiskSupportType"]/*'/>
public enum SharedVirtualDiskSupportType
{
    /// <include file='SharedVirtualDiskSupportType.xml' path='doc/member[@name="SharedVirtualDiskSupportType.SharedVirtualDisksUnsupported"]/*'/>
    SharedVirtualDisksUnsupported = 0,
    /// <include file='SharedVirtualDiskSupportType.xml' path='doc/member[@name="SharedVirtualDiskSupportType.SharedVirtualDisksSupported"]/*'/>
    SharedVirtualDisksSupported = 1,
    /// <include file='SharedVirtualDiskSupportType.xml' path='doc/member[@name="SharedVirtualDiskSupportType.SharedVirtualDiskSnapshotsSupported"]/*'/>
    SharedVirtualDiskSnapshotsSupported = 3,
    /// <include file='SharedVirtualDiskSupportType.xml' path='doc/member[@name="SharedVirtualDiskSupportType.SharedVirtualDiskCDPSnapshotsSupported"]/*'/>
    SharedVirtualDiskCDPSnapshotsSupported = 7,
}