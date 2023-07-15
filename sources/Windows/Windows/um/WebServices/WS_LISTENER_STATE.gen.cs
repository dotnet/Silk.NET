// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE"]/*'/>
public enum WS_LISTENER_STATE
{
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_CREATED"]/*'/>
    WS_LISTENER_STATE_CREATED = 0,
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_OPENING"]/*'/>
    WS_LISTENER_STATE_OPENING = 1,
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_OPEN"]/*'/>
    WS_LISTENER_STATE_OPEN = 2,
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_FAULTED"]/*'/>
    WS_LISTENER_STATE_FAULTED = 3,
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_CLOSING"]/*'/>
    WS_LISTENER_STATE_CLOSING = 4,
    /// <include file='WS_LISTENER_STATE.xml' path='doc/member[@name="WS_LISTENER_STATE.WS_LISTENER_STATE_CLOSED"]/*'/>
    WS_LISTENER_STATE_CLOSED = 5,
}