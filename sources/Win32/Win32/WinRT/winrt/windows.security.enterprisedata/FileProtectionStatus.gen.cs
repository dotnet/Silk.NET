// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum FileProtectionStatus
{
    [Obsolete("Undetermined might be unavailable after Windows 10. Instead, use Unknown.")]
    FileProtectionStatus_Undetermined = 0,
    FileProtectionStatus_Unknown = 0,
    FileProtectionStatus_Unprotected = 1,
    FileProtectionStatus_Revoked = 2,
    FileProtectionStatus_Protected = 3,

    [Obsolete(
        "ProtectedByOtherUser might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity."
    )]
    FileProtectionStatus_ProtectedByOtherUser = 4,

    [Obsolete(
        "ProtectedToOtherEnterprise might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity."
    )]
    FileProtectionStatus_ProtectedToOtherEnterprise = 5,
    FileProtectionStatus_NotProtectable = 6,
    FileProtectionStatus_ProtectedToOtherIdentity = 7,
    FileProtectionStatus_LicenseExpired = 8,
    FileProtectionStatus_AccessSuspended = 9,
    FileProtectionStatus_FileInUse = 10,
}
