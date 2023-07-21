// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_FAULT_ERROR_PROPERTY_ID.xml' path='doc/member[@name="WS_FAULT_ERROR_PROPERTY_ID"]/*' />
public enum WS_FAULT_ERROR_PROPERTY_ID
{
    /// <include file='WS_FAULT_ERROR_PROPERTY_ID.xml' path='doc/member[@name="WS_FAULT_ERROR_PROPERTY_ID.WS_FAULT_ERROR_PROPERTY_FAULT"]/*' />
    WS_FAULT_ERROR_PROPERTY_FAULT = 0,

    /// <include file='WS_FAULT_ERROR_PROPERTY_ID.xml' path='doc/member[@name="WS_FAULT_ERROR_PROPERTY_ID.WS_FAULT_ERROR_PROPERTY_ACTION"]/*' />
    WS_FAULT_ERROR_PROPERTY_ACTION = 1,

    /// <include file='WS_FAULT_ERROR_PROPERTY_ID.xml' path='doc/member[@name="WS_FAULT_ERROR_PROPERTY_ID.WS_FAULT_ERROR_PROPERTY_HEADER"]/*' />
    WS_FAULT_ERROR_PROPERTY_HEADER = 2,
}
