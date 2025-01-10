// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EmailSpecialFolderKind
{
    EmailSpecialFolderKind_None = 0,
    EmailSpecialFolderKind_Root = 1,
    EmailSpecialFolderKind_Inbox = 2,
    EmailSpecialFolderKind_Outbox = 3,
    EmailSpecialFolderKind_Drafts = 4,
    EmailSpecialFolderKind_DeletedItems = 5,
    EmailSpecialFolderKind_Sent = 6,
}
