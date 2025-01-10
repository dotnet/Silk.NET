// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificate =
        "Windows.Security.Cryptography.Certificates.ICertificate";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificate2 =
        "Windows.Security.Cryptography.Certificates.ICertificate2";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificate3 =
        "Windows.Security.Cryptography.Certificates.ICertificate3";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateChain =
        "Windows.Security.Cryptography.Certificates.ICertificateChain";

    [NativeTypeName("const WCHAR[80]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateEnrollmentManagerStatics =
        "Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics";

    [NativeTypeName("const WCHAR[81]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateEnrollmentManagerStatics2 =
        "Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics2";

    [NativeTypeName("const WCHAR[81]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateEnrollmentManagerStatics3 =
        "Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics3";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateExtension =
        "Windows.Security.Cryptography.Certificates.ICertificateExtension";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateFactory =
        "Windows.Security.Cryptography.Certificates.ICertificateFactory";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateKeyUsages =
        "Windows.Security.Cryptography.Certificates.ICertificateKeyUsages";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateQuery =
        "Windows.Security.Cryptography.Certificates.ICertificateQuery";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateQuery2 =
        "Windows.Security.Cryptography.Certificates.ICertificateQuery2";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateRequestProperties =
        "Windows.Security.Cryptography.Certificates.ICertificateRequestProperties";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateRequestProperties2 =
        "Windows.Security.Cryptography.Certificates.ICertificateRequestProperties2";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateRequestProperties3 =
        "Windows.Security.Cryptography.Certificates.ICertificateRequestProperties3";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateRequestProperties4 =
        "Windows.Security.Cryptography.Certificates.ICertificateRequestProperties4";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateStore =
        "Windows.Security.Cryptography.Certificates.ICertificateStore";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateStore2 =
        "Windows.Security.Cryptography.Certificates.ICertificateStore2";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateStoresStatics =
        "Windows.Security.Cryptography.Certificates.ICertificateStoresStatics";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICertificateStoresStatics2 =
        "Windows.Security.Cryptography.Certificates.ICertificateStoresStatics2";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IChainBuildingParameters =
        "Windows.Security.Cryptography.Certificates.IChainBuildingParameters";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IChainValidationParameters =
        "Windows.Security.Cryptography.Certificates.IChainValidationParameters";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsAttachedSignature =
        "Windows.Security.Cryptography.Certificates.ICmsAttachedSignature";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsAttachedSignatureFactory =
        "Windows.Security.Cryptography.Certificates.ICmsAttachedSignatureFactory";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsAttachedSignatureStatics =
        "Windows.Security.Cryptography.Certificates.ICmsAttachedSignatureStatics";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsDetachedSignature =
        "Windows.Security.Cryptography.Certificates.ICmsDetachedSignature";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsDetachedSignatureFactory =
        "Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureFactory";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsDetachedSignatureStatics =
        "Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureStatics";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsSignerInfo =
        "Windows.Security.Cryptography.Certificates.ICmsSignerInfo";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ICmsTimestampInfo =
        "Windows.Security.Cryptography.Certificates.ICmsTimestampInfo";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyAlgorithmNamesStatics =
        "Windows.Security.Cryptography.Certificates.IKeyAlgorithmNamesStatics";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyAlgorithmNamesStatics2 =
        "Windows.Security.Cryptography.Certificates.IKeyAlgorithmNamesStatics2";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyAttestationHelperStatics =
        "Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyAttestationHelperStatics2 =
        "Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics2";

    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyStorageProviderNamesStatics =
        "Windows.Security.Cryptography.Certificates.IKeyStorageProviderNamesStatics";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IKeyStorageProviderNamesStatics2 =
        "Windows.Security.Cryptography.Certificates.IKeyStorageProviderNamesStatics2";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IPfxImportParameters =
        "Windows.Security.Cryptography.Certificates.IPfxImportParameters";

    [NativeTypeName("const WCHAR[81]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IStandardCertificateStoreNamesStatics =
        "Windows.Security.Cryptography.Certificates.IStandardCertificateStoreNamesStatics";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ISubjectAlternativeNameInfo =
        "Windows.Security.Cryptography.Certificates.ISubjectAlternativeNameInfo";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_ISubjectAlternativeNameInfo2 =
        "Windows.Security.Cryptography.Certificates.ISubjectAlternativeNameInfo2";

    [NativeTypeName("const WCHAR[77]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IUserCertificateEnrollmentManager =
        "Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager";

    [NativeTypeName("const WCHAR[78]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IUserCertificateEnrollmentManager2 =
        "Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager2";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Security_Cryptography_Certificates_IUserCertificateStore =
        "Windows.Security.Cryptography.Certificates.IUserCertificateStore";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_Certificate =
        "Windows.Security.Cryptography.Certificates.Certificate";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateChain =
        "Windows.Security.Cryptography.Certificates.CertificateChain";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateEnrollmentManager =
        "Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateExtension =
        "Windows.Security.Cryptography.Certificates.CertificateExtension";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateKeyUsages =
        "Windows.Security.Cryptography.Certificates.CertificateKeyUsages";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateQuery =
        "Windows.Security.Cryptography.Certificates.CertificateQuery";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateRequestProperties =
        "Windows.Security.Cryptography.Certificates.CertificateRequestProperties";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateStore =
        "Windows.Security.Cryptography.Certificates.CertificateStore";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CertificateStores =
        "Windows.Security.Cryptography.Certificates.CertificateStores";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_ChainBuildingParameters =
        "Windows.Security.Cryptography.Certificates.ChainBuildingParameters";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_ChainValidationParameters =
        "Windows.Security.Cryptography.Certificates.ChainValidationParameters";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CmsAttachedSignature =
        "Windows.Security.Cryptography.Certificates.CmsAttachedSignature";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CmsDetachedSignature =
        "Windows.Security.Cryptography.Certificates.CmsDetachedSignature";

    [NativeTypeName("const WCHAR[57]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CmsSignerInfo =
        "Windows.Security.Cryptography.Certificates.CmsSignerInfo";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_CmsTimestampInfo =
        "Windows.Security.Cryptography.Certificates.CmsTimestampInfo";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_KeyAlgorithmNames =
        "Windows.Security.Cryptography.Certificates.KeyAlgorithmNames";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_KeyAttestationHelper =
        "Windows.Security.Cryptography.Certificates.KeyAttestationHelper";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_KeyStorageProviderNames =
        "Windows.Security.Cryptography.Certificates.KeyStorageProviderNames";

    [NativeTypeName("const WCHAR[63]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_PfxImportParameters =
        "Windows.Security.Cryptography.Certificates.PfxImportParameters";

    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_StandardCertificateStoreNames =
        "Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames";

    [NativeTypeName("const WCHAR[70]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_SubjectAlternativeNameInfo =
        "Windows.Security.Cryptography.Certificates.SubjectAlternativeNameInfo";

    [NativeTypeName("const WCHAR[76]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_UserCertificateEnrollmentManager =
        "Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Security_Cryptography_Certificates_UserCertificateStore =
        "Windows.Security.Cryptography.Certificates.UserCertificateStore";
}
