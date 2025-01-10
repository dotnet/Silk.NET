// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ContactListSyncStatus
{
    ContactListSyncStatus_Idle = 0,
    ContactListSyncStatus_Syncing = 1,
    ContactListSyncStatus_UpToDate = 2,
    ContactListSyncStatus_AuthenticationError = 3,
    ContactListSyncStatus_PolicyError = 4,
    ContactListSyncStatus_UnknownError = 5,
    ContactListSyncStatus_ManualAccountRemovalRequired = 6,
}
