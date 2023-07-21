// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SHELL_UI_COMPONENT.xml' path='doc/member[@name="SHELL_UI_COMPONENT"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum SHELL_UI_COMPONENT
{
    /// <include file='SHELL_UI_COMPONENT.xml' path='doc/member[@name="SHELL_UI_COMPONENT.SHELL_UI_COMPONENT_TASKBARS"]/*' />
    SHELL_UI_COMPONENT_TASKBARS = 0,

    /// <include file='SHELL_UI_COMPONENT.xml' path='doc/member[@name="SHELL_UI_COMPONENT.SHELL_UI_COMPONENT_NOTIFICATIONAREA"]/*' />
    SHELL_UI_COMPONENT_NOTIFICATIONAREA = 1,

    /// <include file='SHELL_UI_COMPONENT.xml' path='doc/member[@name="SHELL_UI_COMPONENT.SHELL_UI_COMPONENT_DESKBAND"]/*' />
    SHELL_UI_COMPONENT_DESKBAND = 2,
}
