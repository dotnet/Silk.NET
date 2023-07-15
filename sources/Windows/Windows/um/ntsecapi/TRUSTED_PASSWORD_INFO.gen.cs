// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRUSTED_PASSWORD_INFO.xml' path='doc/member[@name="TRUSTED_PASSWORD_INFO"]/*'/>
public partial struct TRUSTED_PASSWORD_INFO
{
    /// <include file='TRUSTED_PASSWORD_INFO.xml' path='doc/member[@name="TRUSTED_PASSWORD_INFO.Password"]/*'/>
    public LSA_UNICODE_STRING Password;
    /// <include file='TRUSTED_PASSWORD_INFO.xml' path='doc/member[@name="TRUSTED_PASSWORD_INFO.OldPassword"]/*'/>
    public LSA_UNICODE_STRING OldPassword;
}