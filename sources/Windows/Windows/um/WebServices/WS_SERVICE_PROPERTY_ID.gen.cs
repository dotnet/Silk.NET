// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID"]/*' />
public enum WS_SERVICE_PROPERTY_ID
{
    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_HOST_USER_STATE"]/*' />
    WS_SERVICE_PROPERTY_HOST_USER_STATE = 0,

    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_FAULT_DISCLOSURE"]/*' />
    WS_SERVICE_PROPERTY_FAULT_DISCLOSURE = 1,

    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_FAULT_LANGID"]/*' />
    WS_SERVICE_PROPERTY_FAULT_LANGID = 2,

    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_HOST_STATE"]/*' />
    WS_SERVICE_PROPERTY_HOST_STATE = 3,

    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_METADATA"]/*' />
    WS_SERVICE_PROPERTY_METADATA = 4,

    /// <include file='WS_SERVICE_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_ID.WS_SERVICE_PROPERTY_CLOSE_TIMEOUT"]/*' />
    WS_SERVICE_PROPERTY_CLOSE_TIMEOUT = 5,
}
