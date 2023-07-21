// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_FAULT_DISCLOSURE.xml' path='doc/member[@name="WS_FAULT_DISCLOSURE"]/*' />
public enum WS_FAULT_DISCLOSURE
{
    /// <include file='WS_FAULT_DISCLOSURE.xml' path='doc/member[@name="WS_FAULT_DISCLOSURE.WS_MINIMAL_FAULT_DISCLOSURE"]/*' />
    WS_MINIMAL_FAULT_DISCLOSURE = 0,

    /// <include file='WS_FAULT_DISCLOSURE.xml' path='doc/member[@name="WS_FAULT_DISCLOSURE.WS_FULL_FAULT_DISCLOSURE"]/*' />
    WS_FULL_FAULT_DISCLOSURE = 1,
}
