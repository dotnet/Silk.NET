// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE"]/*' />
public enum STORAGE_PROTOCOL_UFS_DATA_TYPE
{
    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeUnknown"]/*' />
    UfsDataTypeUnknown = 0,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeQueryDescriptor"]/*' />
    UfsDataTypeQueryDescriptor,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeQueryAttribute"]/*' />
    UfsDataTypeQueryAttribute,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeQueryFlag"]/*' />
    UfsDataTypeQueryFlag,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeQueryDmeAttribute"]/*' />
    UfsDataTypeQueryDmeAttribute,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeQueryDmePeerAttribute"]/*' />
    UfsDataTypeQueryDmePeerAttribute,

    /// <include file='STORAGE_PROTOCOL_UFS_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_UFS_DATA_TYPE.UfsDataTypeMax"]/*' />
    UfsDataTypeMax,
}
