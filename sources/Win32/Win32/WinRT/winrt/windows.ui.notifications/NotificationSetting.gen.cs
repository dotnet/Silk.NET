// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum NotificationSetting
{
    NotificationSetting_Enabled = 0,
    NotificationSetting_DisabledForApplication = 1,
    NotificationSetting_DisabledForUser = 2,
    NotificationSetting_DisabledByGroupPolicy = 3,
    NotificationSetting_DisabledByManifest = 4,
}
