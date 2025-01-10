// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailCertificateValidationStatus
{
    EmailCertificateValidationStatus_Success = 0,
    EmailCertificateValidationStatus_NoMatch = 1,
    EmailCertificateValidationStatus_InvalidUsage = 2,
    EmailCertificateValidationStatus_InvalidCertificate = 3,
    EmailCertificateValidationStatus_Revoked = 4,
    EmailCertificateValidationStatus_ChainRevoked = 5,
    EmailCertificateValidationStatus_RevocationServerFailure = 6,
    EmailCertificateValidationStatus_Expired = 7,
    EmailCertificateValidationStatus_Untrusted = 8,
    EmailCertificateValidationStatus_ServerError = 9,
    EmailCertificateValidationStatus_UnknownFailure = 10,
}
