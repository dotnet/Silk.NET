// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON"]/*'/>
public enum STORAGE_OPERATIONAL_STATUS_REASON
{
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonUnknown"]/*'/>
    DiskOpReasonUnknown = 0,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonScsiSenseCode"]/*'/>
    DiskOpReasonScsiSenseCode,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonMedia"]/*'/>
    DiskOpReasonMedia,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonIo"]/*'/>
    DiskOpReasonIo,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonThresholdExceeded"]/*'/>
    DiskOpReasonThresholdExceeded,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonLostData"]/*'/>
    DiskOpReasonLostData,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonEnergySource"]/*'/>
    DiskOpReasonEnergySource,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonConfiguration"]/*'/>
    DiskOpReasonConfiguration,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonDeviceController"]/*'/>
    DiskOpReasonDeviceController,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonMediaController"]/*'/>
    DiskOpReasonMediaController,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonComponent"]/*'/>
    DiskOpReasonComponent,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonNVDIMM_N"]/*'/>
    DiskOpReasonNVDIMM_N,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonBackgroundOperation"]/*'/>
    DiskOpReasonBackgroundOperation,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonInvalidFirmware"]/*'/>
    DiskOpReasonInvalidFirmware,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonHealthCheck"]/*'/>
    DiskOpReasonHealthCheck,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonLostDataPersistence"]/*'/>
    DiskOpReasonLostDataPersistence,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonDisabledByPlatform"]/*'/>
    DiskOpReasonDisabledByPlatform,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonLostWritePersistence"]/*'/>
    DiskOpReasonLostWritePersistence,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonDataPersistenceLossImminent"]/*'/>
    DiskOpReasonDataPersistenceLossImminent,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonWritePersistenceLossImminent"]/*'/>
    DiskOpReasonWritePersistenceLossImminent,
    /// <include file='STORAGE_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="STORAGE_OPERATIONAL_STATUS_REASON.DiskOpReasonMax"]/*'/>
    DiskOpReasonMax,
}