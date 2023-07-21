// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS"]/*' />
public enum TRUSTED_INFORMATION_CLASS
{
    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainNameInformation"]/*' />
    TrustedDomainNameInformation = 1,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedControllersInformation"]/*' />
    TrustedControllersInformation,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedPosixOffsetInformation"]/*' />
    TrustedPosixOffsetInformation,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedPasswordInformation"]/*' />
    TrustedPasswordInformation,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainInformationBasic"]/*' />
    TrustedDomainInformationBasic,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainInformationEx"]/*' />
    TrustedDomainInformationEx,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainAuthInformation"]/*' />
    TrustedDomainAuthInformation,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainFullInformation"]/*' />
    TrustedDomainFullInformation,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainAuthInformationInternal"]/*' />
    TrustedDomainAuthInformationInternal,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainFullInformationInternal"]/*' />
    TrustedDomainFullInformationInternal,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainInformationEx2Internal"]/*' />
    TrustedDomainInformationEx2Internal,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainFullInformation2Internal"]/*' />
    TrustedDomainFullInformation2Internal,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainSupportedEncryptionTypes"]/*' />
    TrustedDomainSupportedEncryptionTypes,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainAuthInformationInternalAes"]/*' />
    TrustedDomainAuthInformationInternalAes,

    /// <include file='TRUSTED_INFORMATION_CLASS.xml' path='doc/member[@name="TRUSTED_INFORMATION_CLASS.TrustedDomainFullInformationInternalAes"]/*' />
    TrustedDomainFullInformationInternalAes,
}
