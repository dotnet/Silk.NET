// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CREDENTIAL_PROVIDER_STATUS_ICON.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_STATUS_ICON"]/*'/>
public enum CREDENTIAL_PROVIDER_STATUS_ICON
{
    /// <include file='CREDENTIAL_PROVIDER_STATUS_ICON.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_STATUS_ICON.CPSI_NONE"]/*'/>
    CPSI_NONE = 0,
    /// <include file='CREDENTIAL_PROVIDER_STATUS_ICON.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_STATUS_ICON.CPSI_ERROR"]/*'/>
    CPSI_ERROR = (CPSI_NONE + 1),
    /// <include file='CREDENTIAL_PROVIDER_STATUS_ICON.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_STATUS_ICON.CPSI_WARNING"]/*'/>
    CPSI_WARNING = (CPSI_ERROR + 1),
    /// <include file='CREDENTIAL_PROVIDER_STATUS_ICON.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_STATUS_ICON.CPSI_SUCCESS"]/*'/>
    CPSI_SUCCESS = (CPSI_WARNING + 1),
}