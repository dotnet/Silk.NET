// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL"]/*'/>
[Flags]
public enum WS_SECURE_PROTOCOL
{
    /// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL.WS_SECURE_PROTOCOL_SSL2"]/*'/>
    WS_SECURE_PROTOCOL_SSL2 = 0x1,
    /// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL.WS_SECURE_PROTOCOL_SSL3"]/*'/>
    WS_SECURE_PROTOCOL_SSL3 = 0x2,
    /// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL.WS_SECURE_PROTOCOL_TLS1_0"]/*'/>
    WS_SECURE_PROTOCOL_TLS1_0 = 0x4,
    /// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL.WS_SECURE_PROTOCOL_TLS1_1"]/*'/>
    WS_SECURE_PROTOCOL_TLS1_1 = 0x8,
    /// <include file='WS_SECURE_PROTOCOL.xml' path='doc/member[@name="WS_SECURE_PROTOCOL.WS_SECURE_PROTOCOL_TLS1_2"]/*'/>
    WS_SECURE_PROTOCOL_TLS1_2 = 0x10,
}