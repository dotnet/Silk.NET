// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS"]/*'/>
public enum STORAGE_DISK_OPERATIONAL_STATUS
{
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusNone"]/*'/>
    DiskOpStatusNone = 0,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusUnknown"]/*'/>
    DiskOpStatusUnknown,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusOk"]/*'/>
    DiskOpStatusOk,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusPredictingFailure"]/*'/>
    DiskOpStatusPredictingFailure,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusInService"]/*'/>
    DiskOpStatusInService,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusHardwareError"]/*'/>
    DiskOpStatusHardwareError,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusNotUsable"]/*'/>
    DiskOpStatusNotUsable,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusTransientError"]/*'/>
    DiskOpStatusTransientError,
    /// <include file='STORAGE_DISK_OPERATIONAL_STATUS.xml' path='doc/member[@name="STORAGE_DISK_OPERATIONAL_STATUS.DiskOpStatusMissing"]/*'/>
    DiskOpStatusMissing,
}