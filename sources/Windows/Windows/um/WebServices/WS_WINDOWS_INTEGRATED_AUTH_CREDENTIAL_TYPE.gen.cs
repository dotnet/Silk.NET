// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE"]/*'/>
public enum WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE
{
    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE"]/*'/>
    WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE = 1,
    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE"]/*'/>
    WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE = 2,
    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE.WS_OPAQUE_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE"]/*'/>
    WS_OPAQUE_WINDOWS_INTEGRATED_AUTH_CREDENTIAL_TYPE = 3,
}