// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_SECURITY_KEY_ENTROPY_MODE.xml' path='doc/member[@name="WS_SECURITY_KEY_ENTROPY_MODE"]/*'/>
public enum WS_SECURITY_KEY_ENTROPY_MODE
{
    /// <include file='WS_SECURITY_KEY_ENTROPY_MODE.xml' path='doc/member[@name="WS_SECURITY_KEY_ENTROPY_MODE.WS_SECURITY_KEY_ENTROPY_MODE_CLIENT_ONLY"]/*'/>
    WS_SECURITY_KEY_ENTROPY_MODE_CLIENT_ONLY = 1,
    /// <include file='WS_SECURITY_KEY_ENTROPY_MODE.xml' path='doc/member[@name="WS_SECURITY_KEY_ENTROPY_MODE.WS_SECURITY_KEY_ENTROPY_MODE_SERVER_ONLY"]/*'/>
    WS_SECURITY_KEY_ENTROPY_MODE_SERVER_ONLY = 2,
    /// <include file='WS_SECURITY_KEY_ENTROPY_MODE.xml' path='doc/member[@name="WS_SECURITY_KEY_ENTROPY_MODE.WS_SECURITY_KEY_ENTROPY_MODE_COMBINED"]/*'/>
    WS_SECURITY_KEY_ENTROPY_MODE_COMBINED = 3,
}