// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_READ_TRACK_ADDRESS_TYPE.xml' path='doc/member[@name="IMAPI_READ_TRACK_ADDRESS_TYPE"]/*' />
public enum IMAPI_READ_TRACK_ADDRESS_TYPE
{
    /// <include file='IMAPI_READ_TRACK_ADDRESS_TYPE.xml' path='doc/member[@name="IMAPI_READ_TRACK_ADDRESS_TYPE.IMAPI_READ_TRACK_ADDRESS_TYPE_LBA"]/*' />
    IMAPI_READ_TRACK_ADDRESS_TYPE_LBA = 0,

    /// <include file='IMAPI_READ_TRACK_ADDRESS_TYPE.xml' path='doc/member[@name="IMAPI_READ_TRACK_ADDRESS_TYPE.IMAPI_READ_TRACK_ADDRESS_TYPE_TRACK"]/*' />
    IMAPI_READ_TRACK_ADDRESS_TYPE_TRACK = 1,

    /// <include file='IMAPI_READ_TRACK_ADDRESS_TYPE.xml' path='doc/member[@name="IMAPI_READ_TRACK_ADDRESS_TYPE.IMAPI_READ_TRACK_ADDRESS_TYPE_SESSION"]/*' />
    IMAPI_READ_TRACK_ADDRESS_TYPE_SESSION = 2,
}
