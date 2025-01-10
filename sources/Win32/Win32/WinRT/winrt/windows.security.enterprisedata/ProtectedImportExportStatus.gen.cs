// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ProtectedImportExportStatus
{
    ProtectedImportExportStatus_Ok = 0,
    ProtectedImportExportStatus_Undetermined = 1,
    ProtectedImportExportStatus_Unprotected = 2,
    ProtectedImportExportStatus_Revoked = 3,
    ProtectedImportExportStatus_NotRoamable = 4,
    ProtectedImportExportStatus_ProtectedToOtherIdentity = 5,
    ProtectedImportExportStatus_LicenseExpired = 6,
    ProtectedImportExportStatus_AccessSuspended = 7,
}
