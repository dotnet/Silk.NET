// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_STRING_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_USERNAME_CREDENTIAL"]/*'/>
public partial struct WS_STRING_USERNAME_CREDENTIAL
{
    /// <include file='WS_STRING_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_USERNAME_CREDENTIAL.credential"]/*'/>
    public WS_USERNAME_CREDENTIAL credential;
    /// <include file='WS_STRING_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_USERNAME_CREDENTIAL.username"]/*'/>
    public WS_STRING username;
    /// <include file='WS_STRING_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_USERNAME_CREDENTIAL.password"]/*'/>
    public WS_STRING password;
}