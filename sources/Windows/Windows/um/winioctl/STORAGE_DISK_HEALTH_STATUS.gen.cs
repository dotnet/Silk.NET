// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS"]/*'/>
public enum STORAGE_DISK_HEALTH_STATUS
{
    /// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS.DiskHealthUnknown"]/*'/>
    DiskHealthUnknown = 0,
    /// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS.DiskHealthUnhealthy"]/*'/>
    DiskHealthUnhealthy,
    /// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS.DiskHealthWarning"]/*'/>
    DiskHealthWarning,
    /// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS.DiskHealthHealthy"]/*'/>
    DiskHealthHealthy,
    /// <include file='STORAGE_DISK_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_DISK_HEALTH_STATUS.DiskHealthMax"]/*'/>
    DiskHealthMax,
}