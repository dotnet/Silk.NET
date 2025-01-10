// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum KnownFoldersAccessStatus
{
    KnownFoldersAccessStatus_DeniedBySystem = 0,
    KnownFoldersAccessStatus_NotDeclaredByApp = 1,
    KnownFoldersAccessStatus_DeniedByUser = 2,
    KnownFoldersAccessStatus_UserPromptRequired = 3,
    KnownFoldersAccessStatus_Allowed = 4,
    KnownFoldersAccessStatus_AllowedPerAppFolder = 5,
}
