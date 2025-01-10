// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum RevocationAndRenewalReasons : uint
{
    RevocationAndRenewalReasons_UserModeComponentLoad = 0x1,
    RevocationAndRenewalReasons_KernelModeComponentLoad = 0x2,
    RevocationAndRenewalReasons_AppComponent = 0x4,
    RevocationAndRenewalReasons_GlobalRevocationListLoadFailed = 0x10,
    RevocationAndRenewalReasons_InvalidGlobalRevocationListSignature = 0x20,
    RevocationAndRenewalReasons_GlobalRevocationListAbsent = 0x1000,
    RevocationAndRenewalReasons_ComponentRevoked = 0x2000,
    RevocationAndRenewalReasons_InvalidComponentCertificateExtendedKeyUse = 0x4000,
    RevocationAndRenewalReasons_ComponentCertificateRevoked = 0x8000,
    RevocationAndRenewalReasons_InvalidComponentCertificateRoot = 0x10000,
    RevocationAndRenewalReasons_ComponentHighSecurityCertificateRevoked = 0x20000,
    RevocationAndRenewalReasons_ComponentLowSecurityCertificateRevoked = 0x40000,
    RevocationAndRenewalReasons_BootDriverVerificationFailed = 0x100000,
    RevocationAndRenewalReasons_ComponentSignedWithTestCertificate = 0x1000000,
    RevocationAndRenewalReasons_EncryptionFailure = 0x10000000,
}
