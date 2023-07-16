// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE"]/*'/>
public enum WS_CHANNEL_STATE
{
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_CREATED"]/*'/>
    WS_CHANNEL_STATE_CREATED = 0,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_OPENING"]/*'/>
    WS_CHANNEL_STATE_OPENING = 1,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_ACCEPTING"]/*'/>
    WS_CHANNEL_STATE_ACCEPTING = 2,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_OPEN"]/*'/>
    WS_CHANNEL_STATE_OPEN = 3,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_FAULTED"]/*'/>
    WS_CHANNEL_STATE_FAULTED = 4,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_CLOSING"]/*'/>
    WS_CHANNEL_STATE_CLOSING = 5,
    /// <include file='WS_CHANNEL_STATE.xml' path='doc/member[@name="WS_CHANNEL_STATE.WS_CHANNEL_STATE_CLOSED"]/*'/>
    WS_CHANNEL_STATE_CLOSED = 6,
}