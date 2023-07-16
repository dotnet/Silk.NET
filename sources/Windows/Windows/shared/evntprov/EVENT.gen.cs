// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EVENT
{
    [NativeTypeName("#define EVENT_MIN_LEVEL (0)")]
    public const int EVENT_MIN_LEVEL = (0);
    [NativeTypeName("#define EVENT_MAX_LEVEL (0xff)")]
    public const int EVENT_MAX_LEVEL = (0xff);
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_GET_ID (1)")]
    public const int EVENT_ACTIVITY_CTRL_GET_ID = (1);
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_SET_ID (2)")]
    public const int EVENT_ACTIVITY_CTRL_SET_ID = (2);
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_CREATE_ID (3)")]
    public const int EVENT_ACTIVITY_CTRL_CREATE_ID = (3);
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_GET_SET_ID (4)")]
    public const int EVENT_ACTIVITY_CTRL_GET_SET_ID = (4);
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_CREATE_SET_ID (5)")]
    public const int EVENT_ACTIVITY_CTRL_CREATE_SET_ID = (5);
    [NativeTypeName("#define EVENT_FILTER_TYPE_NONE (0x00000000)")]
    public const int EVENT_FILTER_TYPE_NONE = (0x00000000);
    [NativeTypeName("#define EVENT_FILTER_TYPE_SCHEMATIZED (0x80000000)")]
    public const uint EVENT_FILTER_TYPE_SCHEMATIZED = (0x80000000);
    [NativeTypeName("#define EVENT_FILTER_TYPE_SYSTEM_FLAGS (0x80000001)")]
    public const uint EVENT_FILTER_TYPE_SYSTEM_FLAGS = (0x80000001);
    [NativeTypeName("#define EVENT_FILTER_TYPE_TRACEHANDLE (0x80000002)")]
    public const uint EVENT_FILTER_TYPE_TRACEHANDLE = (0x80000002);
    [NativeTypeName("#define EVENT_FILTER_TYPE_PID (0x80000004)")]
    public const uint EVENT_FILTER_TYPE_PID = (0x80000004);
    [NativeTypeName("#define EVENT_FILTER_TYPE_EXECUTABLE_NAME (0x80000008)")]
    public const uint EVENT_FILTER_TYPE_EXECUTABLE_NAME = (0x80000008);
    [NativeTypeName("#define EVENT_FILTER_TYPE_PACKAGE_ID (0x80000010)")]
    public const uint EVENT_FILTER_TYPE_PACKAGE_ID = (0x80000010);
    [NativeTypeName("#define EVENT_FILTER_TYPE_PACKAGE_APP_ID (0x80000020)")]
    public const uint EVENT_FILTER_TYPE_PACKAGE_APP_ID = (0x80000020);
    [NativeTypeName("#define EVENT_FILTER_TYPE_PAYLOAD (0x80000100)")]
    public const uint EVENT_FILTER_TYPE_PAYLOAD = (0x80000100);
    [NativeTypeName("#define EVENT_FILTER_TYPE_EVENT_ID (0x80000200)")]
    public const uint EVENT_FILTER_TYPE_EVENT_ID = (0x80000200);
    [NativeTypeName("#define EVENT_FILTER_TYPE_EVENT_NAME (0x80000400)")]
    public const uint EVENT_FILTER_TYPE_EVENT_NAME = (0x80000400);
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK (0x80001000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK = (0x80001000);
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK_NAME (0x80002000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK_NAME = (0x80002000);
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK_LEVEL_KW (0x80004000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK_LEVEL_KW = (0x80004000);
    [NativeTypeName("#define EVENT_FILTER_TYPE_CONTAINER (0x80008000)")]
    public const uint EVENT_FILTER_TYPE_CONTAINER = (0x80008000);
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_NONE (0)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_NONE = (0);
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_EVENT_METADATA (1)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_EVENT_METADATA = (1);
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_PROVIDER_METADATA (2)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_PROVIDER_METADATA = (2);
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_TIMESTAMP_OVERRIDE (3)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_TIMESTAMP_OVERRIDE = (3);
    [NativeTypeName("#define EVENT_WRITE_FLAG_NO_FAULTING 0x00000001")]
    public const int EVENT_WRITE_FLAG_NO_FAULTING = 0x00000001;
    [NativeTypeName("#define EVENT_WRITE_FLAG_INPRIVATE 0x00000002")]
    public const int EVENT_WRITE_FLAG_INPRIVATE = 0x00000002;
}