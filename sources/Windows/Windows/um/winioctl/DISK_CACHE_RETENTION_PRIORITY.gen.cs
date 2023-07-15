// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISK_CACHE_RETENTION_PRIORITY.xml' path='doc/member[@name="DISK_CACHE_RETENTION_PRIORITY"]/*'/>
public enum DISK_CACHE_RETENTION_PRIORITY
{
    /// <include file='DISK_CACHE_RETENTION_PRIORITY.xml' path='doc/member[@name="DISK_CACHE_RETENTION_PRIORITY.EqualPriority"]/*'/>
    EqualPriority,
    /// <include file='DISK_CACHE_RETENTION_PRIORITY.xml' path='doc/member[@name="DISK_CACHE_RETENTION_PRIORITY.KeepPrefetchedData"]/*'/>
    KeepPrefetchedData,
    /// <include file='DISK_CACHE_RETENTION_PRIORITY.xml' path='doc/member[@name="DISK_CACHE_RETENTION_PRIORITY.KeepReadData"]/*'/>
    KeepReadData,
}