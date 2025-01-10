// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DataProtectionStatus
{
    DataProtectionStatus_ProtectedToOtherIdentity = 0,
    DataProtectionStatus_Protected = 1,
    DataProtectionStatus_Revoked = 2,
    DataProtectionStatus_Unprotected = 3,
    DataProtectionStatus_LicenseExpired = 4,
    DataProtectionStatus_AccessSuspended = 5,
}
