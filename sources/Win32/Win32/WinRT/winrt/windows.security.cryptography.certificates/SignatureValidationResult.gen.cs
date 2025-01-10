// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SignatureValidationResult
{
    SignatureValidationResult_Success = 0,
    SignatureValidationResult_InvalidParameter = 1,
    SignatureValidationResult_BadMessage = 2,
    SignatureValidationResult_InvalidSignature = 3,
    SignatureValidationResult_OtherErrors = 4,
}
