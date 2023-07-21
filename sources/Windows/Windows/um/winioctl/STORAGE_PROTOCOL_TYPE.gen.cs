// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum STORAGE_PROTOCOL_TYPE
{
    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeUnknown"]/*' />
    ProtocolTypeUnknown = 0x00,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeScsi"]/*' />
    ProtocolTypeScsi,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeAta"]/*' />
    ProtocolTypeAta,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeNvme"]/*' />
    ProtocolTypeNvme,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeSd"]/*' />
    ProtocolTypeSd,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeUfs"]/*' />
    ProtocolTypeUfs,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeProprietary"]/*' />
    ProtocolTypeProprietary = 0x7E,

    /// <include file='STORAGE_PROTOCOL_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_TYPE.ProtocolTypeMaxReserved"]/*' />
    ProtocolTypeMaxReserved = 0x7F,
}
