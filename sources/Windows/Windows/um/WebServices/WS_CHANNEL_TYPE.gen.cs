// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE"]/*'/>
[Flags]
public enum WS_CHANNEL_TYPE
{
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_INPUT"]/*'/>
    WS_CHANNEL_TYPE_INPUT = 0x1,
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_OUTPUT"]/*'/>
    WS_CHANNEL_TYPE_OUTPUT = 0x2,
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_SESSION"]/*'/>
    WS_CHANNEL_TYPE_SESSION = 0x4,
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_INPUT_SESSION"]/*'/>
    WS_CHANNEL_TYPE_INPUT_SESSION = (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_SESSION),
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_OUTPUT_SESSION"]/*'/>
    WS_CHANNEL_TYPE_OUTPUT_SESSION = (WS_CHANNEL_TYPE_OUTPUT | WS_CHANNEL_TYPE_SESSION),
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_DUPLEX"]/*'/>
    WS_CHANNEL_TYPE_DUPLEX = (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_OUTPUT),
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_DUPLEX_SESSION"]/*'/>
    WS_CHANNEL_TYPE_DUPLEX_SESSION = (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_OUTPUT | WS_CHANNEL_TYPE_SESSION),
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_REQUEST"]/*'/>
    WS_CHANNEL_TYPE_REQUEST = 0x8,
    /// <include file='WS_CHANNEL_TYPE.xml' path='doc/member[@name="WS_CHANNEL_TYPE.WS_CHANNEL_TYPE_REPLY"]/*'/>
    WS_CHANNEL_TYPE_REPLY = 0x10,
}