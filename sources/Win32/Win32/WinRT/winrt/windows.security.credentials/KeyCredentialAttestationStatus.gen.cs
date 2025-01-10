// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum KeyCredentialAttestationStatus
{
    KeyCredentialAttestationStatus_Success = 0,
    KeyCredentialAttestationStatus_UnknownError = 1,
    KeyCredentialAttestationStatus_NotSupported = 2,
    KeyCredentialAttestationStatus_TemporaryFailure = 3,
}
