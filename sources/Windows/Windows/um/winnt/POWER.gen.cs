// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.POWER_PLATFORM_ROLE;

namespace TerraFX.Interop.Windows;
public static partial class POWER
{
    [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_PERFORMANCE 0")]
    public const int POWER_DEVICE_IDLE_POLICY_PERFORMANCE = 0;
    [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_CONSERVATIVE 1")]
    public const int POWER_DEVICE_IDLE_POLICY_CONSERVATIVE = 1;
    [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_DISABLED 0")]
    public const int POWER_CONNECTIVITY_IN_STANDBY_DISABLED = 0;
    [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_ENABLED 1")]
    public const int POWER_CONNECTIVITY_IN_STANDBY_ENABLED = 1;
    [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED 2")]
    public const int POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED = 2;
    [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_NORMAL 0")]
    public const int POWER_DISCONNECTED_STANDBY_MODE_NORMAL = 0;
    [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE 1")]
    public const int POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE = 1;
    [NativeTypeName("#define POWER_SYSTEM_MAXIMUM 7")]
    public const int POWER_SYSTEM_MAXIMUM = 7;
    [NativeTypeName("#define POWER_REQUEST_CONTEXT_VERSION DIAGNOSTIC_REASON_VERSION")]
    public const int POWER_REQUEST_CONTEXT_VERSION = 0;
    [NativeTypeName("#define POWER_REQUEST_CONTEXT_SIMPLE_STRING DIAGNOSTIC_REASON_SIMPLE_STRING")]
    public const int POWER_REQUEST_CONTEXT_SIMPLE_STRING = 0x00000001;
    [NativeTypeName("#define POWER_REQUEST_CONTEXT_DETAILED_STRING DIAGNOSTIC_REASON_DETAILED_STRING")]
    public const int POWER_REQUEST_CONTEXT_DETAILED_STRING = 0x00000002;
    [NativeTypeName("#define POWER_SETTING_VALUE_VERSION (0x1)")]
    public const int POWER_SETTING_VALUE_VERSION = (0x1);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_V1 (0x00000001)")]
    public const int POWER_PLATFORM_ROLE_V1 = (0x00000001);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_V1_MAX (PlatformRolePerformanceServer + 1)")]
    public const int POWER_PLATFORM_ROLE_V1_MAX = ((int)(PlatformRolePerformanceServer) + 1);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_V2 (0x00000002)")]
    public const int POWER_PLATFORM_ROLE_V2 = (0x00000002);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_V2_MAX (PlatformRoleSlate + 1)")]
    public const int POWER_PLATFORM_ROLE_V2_MAX = ((int)(PlatformRoleSlate) + 1);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION POWER_PLATFORM_ROLE_V2")]
    public const int POWER_PLATFORM_ROLE_VERSION = (0x00000002);
    [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION_MAX POWER_PLATFORM_ROLE_V2_MAX")]
    public const int POWER_PLATFORM_ROLE_VERSION_MAX = ((int)(PlatformRoleSlate) + 1);
    [NativeTypeName("#define POWER_ACTION_QUERY_ALLOWED 0x00000001")]
    public const int POWER_ACTION_QUERY_ALLOWED = 0x00000001;
    [NativeTypeName("#define POWER_ACTION_UI_ALLOWED 0x00000002")]
    public const int POWER_ACTION_UI_ALLOWED = 0x00000002;
    [NativeTypeName("#define POWER_ACTION_OVERRIDE_APPS 0x00000004")]
    public const int POWER_ACTION_OVERRIDE_APPS = 0x00000004;
    [NativeTypeName("#define POWER_ACTION_HIBERBOOT 0x00000008")]
    public const int POWER_ACTION_HIBERBOOT = 0x00000008;
    [NativeTypeName("#define POWER_ACTION_USER_NOTIFY 0x00000010")]
    public const int POWER_ACTION_USER_NOTIFY = 0x00000010;
    [NativeTypeName("#define POWER_ACTION_DOZE_TO_HIBERNATE 0x00000020")]
    public const int POWER_ACTION_DOZE_TO_HIBERNATE = 0x00000020;
    [NativeTypeName("#define POWER_ACTION_ACPI_CRITICAL 0x01000000")]
    public const int POWER_ACTION_ACPI_CRITICAL = 0x01000000;
    [NativeTypeName("#define POWER_ACTION_ACPI_USER_NOTIFY 0x02000000")]
    public const int POWER_ACTION_ACPI_USER_NOTIFY = 0x02000000;
    [NativeTypeName("#define POWER_ACTION_DIRECTED_DRIPS 0x04000000")]
    public const int POWER_ACTION_DIRECTED_DRIPS = 0x04000000;
    [NativeTypeName("#define POWER_ACTION_PSEUDO_TRANSITION 0x08000000")]
    public const int POWER_ACTION_PSEUDO_TRANSITION = 0x08000000;
    [NativeTypeName("#define POWER_ACTION_LIGHTEST_FIRST 0x10000000")]
    public const int POWER_ACTION_LIGHTEST_FIRST = 0x10000000;
    [NativeTypeName("#define POWER_ACTION_LOCK_CONSOLE 0x20000000")]
    public const int POWER_ACTION_LOCK_CONSOLE = 0x20000000;
    [NativeTypeName("#define POWER_ACTION_DISABLE_WAKES 0x40000000")]
    public const int POWER_ACTION_DISABLE_WAKES = 0x40000000;
    [NativeTypeName("#define POWER_ACTION_CRITICAL 0x80000000")]
    public const uint POWER_ACTION_CRITICAL = 0x80000000;
    [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_TEXT 0x00000001")]
    public const int POWER_LEVEL_USER_NOTIFY_TEXT = 0x00000001;
    [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_SOUND 0x00000002")]
    public const int POWER_LEVEL_USER_NOTIFY_SOUND = 0x00000002;
    [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_EXEC 0x00000004")]
    public const int POWER_LEVEL_USER_NOTIFY_EXEC = 0x00000004;
    [NativeTypeName("#define POWER_USER_NOTIFY_BUTTON 0x00000008")]
    public const int POWER_USER_NOTIFY_BUTTON = 0x00000008;
    [NativeTypeName("#define POWER_USER_NOTIFY_SHUTDOWN 0x00000010")]
    public const int POWER_USER_NOTIFY_SHUTDOWN = 0x00000010;
    [NativeTypeName("#define POWER_USER_NOTIFY_FORCED_SHUTDOWN 0x00000020")]
    public const int POWER_USER_NOTIFY_FORCED_SHUTDOWN = 0x00000020;
    [NativeTypeName("#define POWER_FORCE_TRIGGER_RESET 0x80000000")]
    public const uint POWER_FORCE_TRIGGER_RESET = 0x80000000;
}