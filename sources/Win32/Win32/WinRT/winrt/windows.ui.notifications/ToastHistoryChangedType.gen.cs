// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ToastHistoryChangedType
{
    ToastHistoryChangedType_Cleared = 0,
    ToastHistoryChangedType_Removed = 1,
    ToastHistoryChangedType_Expired = 2,
    ToastHistoryChangedType_Added = 3,
}
