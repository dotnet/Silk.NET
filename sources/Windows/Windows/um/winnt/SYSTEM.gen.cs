// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SYSTEM
{
    [NativeTypeName("#define SYSTEM_AUDIT_ACE_TYPE (0x2)")]
    public const int SYSTEM_AUDIT_ACE_TYPE = (0x2);
    [NativeTypeName("#define SYSTEM_ALARM_ACE_TYPE (0x3)")]
    public const int SYSTEM_ALARM_ACE_TYPE = (0x3);
    [NativeTypeName("#define SYSTEM_AUDIT_OBJECT_ACE_TYPE (0x7)")]
    public const int SYSTEM_AUDIT_OBJECT_ACE_TYPE = (0x7);
    [NativeTypeName("#define SYSTEM_ALARM_OBJECT_ACE_TYPE (0x8)")]
    public const int SYSTEM_ALARM_OBJECT_ACE_TYPE = (0x8);
    [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_ACE_TYPE (0xD)")]
    public const int SYSTEM_AUDIT_CALLBACK_ACE_TYPE = (0xD);
    [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_ACE_TYPE (0xE)")]
    public const int SYSTEM_ALARM_CALLBACK_ACE_TYPE = (0xE);
    [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE (0xF)")]
    public const int SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = (0xF);
    [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE (0x10)")]
    public const int SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = (0x10);
    [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_ACE_TYPE (0x11)")]
    public const int SYSTEM_MANDATORY_LABEL_ACE_TYPE = (0x11);
    [NativeTypeName("#define SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE (0x12)")]
    public const int SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE = (0x12);
    [NativeTypeName("#define SYSTEM_SCOPED_POLICY_ID_ACE_TYPE (0x13)")]
    public const int SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = (0x13);
    [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE (0x14)")]
    public const int SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE = (0x14);
    [NativeTypeName("#define SYSTEM_ACCESS_FILTER_ACE_TYPE (0x15)")]
    public const int SYSTEM_ACCESS_FILTER_ACE_TYPE = (0x15);
    [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_WRITE_UP 0x1")]
    public const int SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = 0x1;
    [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_READ_UP 0x2")]
    public const int SYSTEM_MANDATORY_LABEL_NO_READ_UP = 0x2;
    [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP 0x4")]
    public const int SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = 0x4;
    [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_VALID_MASK (SYSTEM_MANDATORY_LABEL_NO_WRITE_UP   | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_READ_UP    | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP)")]
    public const int SYSTEM_MANDATORY_LABEL_VALID_MASK = (0x1 | 0x2 | 0x4);
    [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK 0x00ffffff")]
    public const int SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = 0x00ffffff;
    [NativeTypeName("#define SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK 0xffffffff")]
    public const uint SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = 0xffffffff;
    [NativeTypeName("#define SYSTEM_ACCESS_FILTER_VALID_MASK 0x00ffffff")]
    public const int SYSTEM_ACCESS_FILTER_VALID_MASK = 0x00ffffff;
    [NativeTypeName("#define SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK 0xffffffff")]
    public const uint SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = 0xffffffff;
    [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_PARKED 0x1")]
    public const int SYSTEM_CPU_SET_INFORMATION_PARKED = 0x1;
    [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED 0x2")]
    public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED = 0x2;
    [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS 0x4")]
    public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS = 0x4;
    [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_REALTIME 0x8")]
    public const int SYSTEM_CPU_SET_INFORMATION_REALTIME = 0x8;
}