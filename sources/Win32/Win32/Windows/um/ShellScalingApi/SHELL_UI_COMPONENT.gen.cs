// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public enum SHELL_UI_COMPONENT
{
    SHELL_UI_COMPONENT_TASKBARS = 0,
    SHELL_UI_COMPONENT_NOTIFICATIONAREA = 1,
    SHELL_UI_COMPONENT_DESKBAND = 2,
}
