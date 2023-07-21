// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE"]/*' />
public enum STORAGE_COUNTER_TYPE
{
    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeUnknown"]/*' />
    StorageCounterTypeUnknown = 0,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeTemperatureCelsius"]/*' />
    StorageCounterTypeTemperatureCelsius,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeTemperatureCelsiusMax"]/*' />
    StorageCounterTypeTemperatureCelsiusMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeReadErrorsTotal"]/*' />
    StorageCounterTypeReadErrorsTotal,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeReadErrorsCorrected"]/*' />
    StorageCounterTypeReadErrorsCorrected,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeReadErrorsUncorrected"]/*' />
    StorageCounterTypeReadErrorsUncorrected,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWriteErrorsTotal"]/*' />
    StorageCounterTypeWriteErrorsTotal,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWriteErrorsCorrected"]/*' />
    StorageCounterTypeWriteErrorsCorrected,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWriteErrorsUncorrected"]/*' />
    StorageCounterTypeWriteErrorsUncorrected,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeManufactureDate"]/*' />
    StorageCounterTypeManufactureDate,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeStartStopCycleCount"]/*' />
    StorageCounterTypeStartStopCycleCount,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeStartStopCycleCountMax"]/*' />
    StorageCounterTypeStartStopCycleCountMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeLoadUnloadCycleCount"]/*' />
    StorageCounterTypeLoadUnloadCycleCount,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeLoadUnloadCycleCountMax"]/*' />
    StorageCounterTypeLoadUnloadCycleCountMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWearPercentage"]/*' />
    StorageCounterTypeWearPercentage,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWearPercentageWarning"]/*' />
    StorageCounterTypeWearPercentageWarning,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWearPercentageMax"]/*' />
    StorageCounterTypeWearPercentageMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypePowerOnHours"]/*' />
    StorageCounterTypePowerOnHours,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeReadLatency100NSMax"]/*' />
    StorageCounterTypeReadLatency100NSMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeWriteLatency100NSMax"]/*' />
    StorageCounterTypeWriteLatency100NSMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeFlushLatency100NSMax"]/*' />
    StorageCounterTypeFlushLatency100NSMax,

    /// <include file='STORAGE_COUNTER_TYPE.xml' path='doc/member[@name="STORAGE_COUNTER_TYPE.StorageCounterTypeMax"]/*' />
    StorageCounterTypeMax,
}
