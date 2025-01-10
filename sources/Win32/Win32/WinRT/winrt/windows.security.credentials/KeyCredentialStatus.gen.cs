// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum KeyCredentialStatus
{
    KeyCredentialStatus_Success = 0,
    KeyCredentialStatus_UnknownError = 1,
    KeyCredentialStatus_NotFound = 2,
    KeyCredentialStatus_UserCanceled = 3,
    KeyCredentialStatus_UserPrefersPassword = 4,
    KeyCredentialStatus_CredentialAlreadyExists = 5,
    KeyCredentialStatus_SecurityDeviceLocked = 6,
}
