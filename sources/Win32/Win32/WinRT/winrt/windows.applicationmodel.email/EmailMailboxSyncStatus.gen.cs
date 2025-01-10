// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailMailboxSyncStatus
{
    EmailMailboxSyncStatus_Idle = 0,
    EmailMailboxSyncStatus_Syncing = 1,
    EmailMailboxSyncStatus_UpToDate = 2,
    EmailMailboxSyncStatus_AuthenticationError = 3,
    EmailMailboxSyncStatus_PolicyError = 4,
    EmailMailboxSyncStatus_UnknownError = 5,
    EmailMailboxSyncStatus_ManualAccountRemovalRequired = 6,
}
