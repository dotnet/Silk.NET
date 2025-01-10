// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ToastTemplateType
{
    ToastTemplateType_ToastImageAndText01 = 0,
    ToastTemplateType_ToastImageAndText02 = 1,
    ToastTemplateType_ToastImageAndText03 = 2,
    ToastTemplateType_ToastImageAndText04 = 3,
    ToastTemplateType_ToastText01 = 4,
    ToastTemplateType_ToastText02 = 5,
    ToastTemplateType_ToastText03 = 6,
    ToastTemplateType_ToastText04 = 7,
}
