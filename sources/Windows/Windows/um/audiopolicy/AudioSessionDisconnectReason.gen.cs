// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason"]/*'/>
public enum AudioSessionDisconnectReason
{
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonDeviceRemoval"]/*'/>
    DisconnectReasonDeviceRemoval = 0,
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonServerShutdown"]/*'/>
    DisconnectReasonServerShutdown = (DisconnectReasonDeviceRemoval + 1),
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonFormatChanged"]/*'/>
    DisconnectReasonFormatChanged = (DisconnectReasonServerShutdown + 1),
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonSessionLogoff"]/*'/>
    DisconnectReasonSessionLogoff = (DisconnectReasonFormatChanged + 1),
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonSessionDisconnected"]/*'/>
    DisconnectReasonSessionDisconnected = (DisconnectReasonSessionLogoff + 1),
    /// <include file='AudioSessionDisconnectReason.xml' path='doc/member[@name="AudioSessionDisconnectReason.DisconnectReasonExclusiveModeOverride"]/*'/>
    DisconnectReasonExclusiveModeOverride = (DisconnectReasonSessionDisconnected + 1),
}