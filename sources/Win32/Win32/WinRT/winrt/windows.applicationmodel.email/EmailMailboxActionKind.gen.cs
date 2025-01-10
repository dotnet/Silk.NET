// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailMailboxActionKind
{
    EmailMailboxActionKind_MarkMessageAsSeen = 0,
    EmailMailboxActionKind_MarkMessageRead = 1,
    EmailMailboxActionKind_ChangeMessageFlagState = 2,
    EmailMailboxActionKind_MoveMessage = 3,
    EmailMailboxActionKind_SaveDraft = 4,
    EmailMailboxActionKind_SendMessage = 5,
    EmailMailboxActionKind_CreateResponseReplyMessage = 6,
    EmailMailboxActionKind_CreateResponseReplyAllMessage = 7,
    EmailMailboxActionKind_CreateResponseForwardMessage = 8,
    EmailMailboxActionKind_MoveFolder = 9,
    EmailMailboxActionKind_MarkFolderForSyncEnabled = 10,
}
