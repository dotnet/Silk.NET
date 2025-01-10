// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailMailboxChangeType
{
    EmailMailboxChangeType_MessageCreated = 0,
    EmailMailboxChangeType_MessageModified = 1,
    EmailMailboxChangeType_MessageDeleted = 2,
    EmailMailboxChangeType_FolderCreated = 3,
    EmailMailboxChangeType_FolderModified = 4,
    EmailMailboxChangeType_FolderDeleted = 5,
    EmailMailboxChangeType_ChangeTrackingLost = 6,
}
