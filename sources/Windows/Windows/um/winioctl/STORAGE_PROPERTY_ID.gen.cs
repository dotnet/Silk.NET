// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID"]/*' />
public enum STORAGE_PROPERTY_ID
{
    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceProperty"]/*' />
    StorageDeviceProperty = 0,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterProperty"]/*' />
    StorageAdapterProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceIdProperty"]/*' />
    StorageDeviceIdProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceUniqueIdProperty"]/*' />
    StorageDeviceUniqueIdProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceWriteCacheProperty"]/*' />
    StorageDeviceWriteCacheProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageMiniportProperty"]/*' />
    StorageMiniportProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAccessAlignmentProperty"]/*' />
    StorageAccessAlignmentProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceSeekPenaltyProperty"]/*' />
    StorageDeviceSeekPenaltyProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceTrimProperty"]/*' />
    StorageDeviceTrimProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceWriteAggregationProperty"]/*' />
    StorageDeviceWriteAggregationProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceDeviceTelemetryProperty"]/*' />
    StorageDeviceDeviceTelemetryProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceLBProvisioningProperty"]/*' />
    StorageDeviceLBProvisioningProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDevicePowerProperty"]/*' />
    StorageDevicePowerProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceCopyOffloadProperty"]/*' />
    StorageDeviceCopyOffloadProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceResiliencyProperty"]/*' />
    StorageDeviceResiliencyProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceMediumProductType"]/*' />
    StorageDeviceMediumProductType,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterRpmbProperty"]/*' />
    StorageAdapterRpmbProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterCryptoProperty"]/*' />
    StorageAdapterCryptoProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceIoCapabilityProperty"]/*' />
    StorageDeviceIoCapabilityProperty = 48,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterProtocolSpecificProperty"]/*' />
    StorageAdapterProtocolSpecificProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceProtocolSpecificProperty"]/*' />
    StorageDeviceProtocolSpecificProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterTemperatureProperty"]/*' />
    StorageAdapterTemperatureProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceTemperatureProperty"]/*' />
    StorageDeviceTemperatureProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterPhysicalTopologyProperty"]/*' />
    StorageAdapterPhysicalTopologyProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDevicePhysicalTopologyProperty"]/*' />
    StorageDevicePhysicalTopologyProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceAttributesProperty"]/*' />
    StorageDeviceAttributesProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceManagementStatus"]/*' />
    StorageDeviceManagementStatus,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageAdapterSerialNumberProperty"]/*' />
    StorageAdapterSerialNumberProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceLocationProperty"]/*' />
    StorageDeviceLocationProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceNumaProperty"]/*' />
    StorageDeviceNumaProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceZonedDeviceProperty"]/*' />
    StorageDeviceZonedDeviceProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceUnsafeShutdownCount"]/*' />
    StorageDeviceUnsafeShutdownCount,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceEnduranceProperty"]/*' />
    StorageDeviceEnduranceProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceLedStateProperty"]/*' />
    StorageDeviceLedStateProperty,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageDeviceSelfEncryptionProperty"]/*' />
    StorageDeviceSelfEncryptionProperty = 64,

    /// <include file='STORAGE_PROPERTY_ID.xml' path='doc/member[@name="STORAGE_PROPERTY_ID.StorageFruIdProperty"]/*' />
    StorageFruIdProperty,
}
