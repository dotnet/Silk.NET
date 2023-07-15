// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_SERVICE_CANCEL_REASON.xml' path='doc/member[@name="WS_SERVICE_CANCEL_REASON"]/*'/>
public enum WS_SERVICE_CANCEL_REASON
{
    /// <include file='WS_SERVICE_CANCEL_REASON.xml' path='doc/member[@name="WS_SERVICE_CANCEL_REASON.WS_SERVICE_HOST_ABORT"]/*'/>
    WS_SERVICE_HOST_ABORT = 0,
    /// <include file='WS_SERVICE_CANCEL_REASON.xml' path='doc/member[@name="WS_SERVICE_CANCEL_REASON.WS_SERVICE_CHANNEL_FAULTED"]/*'/>
    WS_SERVICE_CHANNEL_FAULTED = 1,
}