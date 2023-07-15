// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus"]/*'/>
public enum OfflineFolderStatus
{
    /// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus.OFS_INACTIVE"]/*'/>
    OFS_INACTIVE = -1,
    /// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus.OFS_ONLINE"]/*'/>
    OFS_ONLINE = (OFS_INACTIVE + 1),
    /// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus.OFS_OFFLINE"]/*'/>
    OFS_OFFLINE = (OFS_ONLINE + 1),
    /// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus.OFS_SERVERBACK"]/*'/>
    OFS_SERVERBACK = (OFS_OFFLINE + 1),
    /// <include file='OfflineFolderStatus.xml' path='doc/member[@name="OfflineFolderStatus.OFS_DIRTYCACHE"]/*'/>
    OFS_DIRTYCACHE = (OFS_SERVERBACK + 1),
}