// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SHARED_VIRTUAL_DISK_SUPPORT.xml' path='doc/member[@name="SHARED_VIRTUAL_DISK_SUPPORT"]/*'/>
public partial struct SHARED_VIRTUAL_DISK_SUPPORT
{
    /// <include file='SHARED_VIRTUAL_DISK_SUPPORT.xml' path='doc/member[@name="SHARED_VIRTUAL_DISK_SUPPORT.SharedVirtualDiskSupport"]/*'/>
    public SharedVirtualDiskSupportType SharedVirtualDiskSupport;
    /// <include file='SHARED_VIRTUAL_DISK_SUPPORT.xml' path='doc/member[@name="SHARED_VIRTUAL_DISK_SUPPORT.HandleState"]/*'/>
    public SharedVirtualDiskHandleState HandleState;
}