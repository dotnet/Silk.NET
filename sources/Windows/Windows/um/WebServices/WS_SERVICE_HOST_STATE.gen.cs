// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE"]/*'/>
public enum WS_SERVICE_HOST_STATE
{
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_CREATED"]/*'/>
    WS_SERVICE_HOST_STATE_CREATED = 0,
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_OPENING"]/*'/>
    WS_SERVICE_HOST_STATE_OPENING = 1,
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_OPEN"]/*'/>
    WS_SERVICE_HOST_STATE_OPEN = 2,
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_CLOSING"]/*'/>
    WS_SERVICE_HOST_STATE_CLOSING = 3,
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_CLOSED"]/*'/>
    WS_SERVICE_HOST_STATE_CLOSED = 4,
    /// <include file='WS_SERVICE_HOST_STATE.xml' path='doc/member[@name="WS_SERVICE_HOST_STATE.WS_SERVICE_HOST_STATE_FAULTED"]/*'/>
    WS_SERVICE_HOST_STATE_FAULTED = 5,
}