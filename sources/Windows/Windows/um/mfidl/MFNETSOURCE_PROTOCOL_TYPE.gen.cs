// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE"]/*' />
public enum MFNETSOURCE_PROTOCOL_TYPE
{
    /// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE.MFNETSOURCE_UNDEFINED"]/*' />
    MFNETSOURCE_UNDEFINED = 0,

    /// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE.MFNETSOURCE_HTTP"]/*' />
    MFNETSOURCE_HTTP = 0x1,

    /// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE.MFNETSOURCE_RTSP"]/*' />
    MFNETSOURCE_RTSP = 0x2,

    /// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE.MFNETSOURCE_FILE"]/*' />
    MFNETSOURCE_FILE = 0x3,

    /// <include file='MFNETSOURCE_PROTOCOL_TYPE.xml' path='doc/member[@name="MFNETSOURCE_PROTOCOL_TYPE.MFNETSOURCE_MULTICAST"]/*' />
    MFNETSOURCE_MULTICAST = 0x4,
}
