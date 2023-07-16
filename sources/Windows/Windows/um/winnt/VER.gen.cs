// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class VER
{
    [NativeTypeName("#define VER_SERVER_NT 0x80000000")]
    public const uint VER_SERVER_NT = 0x80000000;
    [NativeTypeName("#define VER_WORKSTATION_NT 0x40000000")]
    public const int VER_WORKSTATION_NT = 0x40000000;
    [NativeTypeName("#define VER_SUITE_SMALLBUSINESS 0x00000001")]
    public const int VER_SUITE_SMALLBUSINESS = 0x00000001;
    [NativeTypeName("#define VER_SUITE_ENTERPRISE 0x00000002")]
    public const int VER_SUITE_ENTERPRISE = 0x00000002;
    [NativeTypeName("#define VER_SUITE_BACKOFFICE 0x00000004")]
    public const int VER_SUITE_BACKOFFICE = 0x00000004;
    [NativeTypeName("#define VER_SUITE_COMMUNICATIONS 0x00000008")]
    public const int VER_SUITE_COMMUNICATIONS = 0x00000008;
    [NativeTypeName("#define VER_SUITE_TERMINAL 0x00000010")]
    public const int VER_SUITE_TERMINAL = 0x00000010;
    [NativeTypeName("#define VER_SUITE_SMALLBUSINESS_RESTRICTED 0x00000020")]
    public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
    [NativeTypeName("#define VER_SUITE_EMBEDDEDNT 0x00000040")]
    public const int VER_SUITE_EMBEDDEDNT = 0x00000040;
    [NativeTypeName("#define VER_SUITE_DATACENTER 0x00000080")]
    public const int VER_SUITE_DATACENTER = 0x00000080;
    [NativeTypeName("#define VER_SUITE_SINGLEUSERTS 0x00000100")]
    public const int VER_SUITE_SINGLEUSERTS = 0x00000100;
    [NativeTypeName("#define VER_SUITE_PERSONAL 0x00000200")]
    public const int VER_SUITE_PERSONAL = 0x00000200;
    [NativeTypeName("#define VER_SUITE_BLADE 0x00000400")]
    public const int VER_SUITE_BLADE = 0x00000400;
    [NativeTypeName("#define VER_SUITE_EMBEDDED_RESTRICTED 0x00000800")]
    public const int VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;
    [NativeTypeName("#define VER_SUITE_SECURITY_APPLIANCE 0x00001000")]
    public const int VER_SUITE_SECURITY_APPLIANCE = 0x00001000;
    [NativeTypeName("#define VER_SUITE_STORAGE_SERVER 0x00002000")]
    public const int VER_SUITE_STORAGE_SERVER = 0x00002000;
    [NativeTypeName("#define VER_SUITE_COMPUTE_SERVER 0x00004000")]
    public const int VER_SUITE_COMPUTE_SERVER = 0x00004000;
    [NativeTypeName("#define VER_SUITE_WH_SERVER 0x00008000")]
    public const int VER_SUITE_WH_SERVER = 0x00008000;
    [NativeTypeName("#define VER_SUITE_MULTIUSERTS 0x00020000")]
    public const int VER_SUITE_MULTIUSERTS = 0x00020000;
    [NativeTypeName("#define VER_EQUAL 1")]
    public const int VER_EQUAL = 1;
    [NativeTypeName("#define VER_GREATER 2")]
    public const int VER_GREATER = 2;
    [NativeTypeName("#define VER_GREATER_EQUAL 3")]
    public const int VER_GREATER_EQUAL = 3;
    [NativeTypeName("#define VER_LESS 4")]
    public const int VER_LESS = 4;
    [NativeTypeName("#define VER_LESS_EQUAL 5")]
    public const int VER_LESS_EQUAL = 5;
    [NativeTypeName("#define VER_AND 6")]
    public const int VER_AND = 6;
    [NativeTypeName("#define VER_OR 7")]
    public const int VER_OR = 7;
    [NativeTypeName("#define VER_CONDITION_MASK 7")]
    public const int VER_CONDITION_MASK = 7;
    [NativeTypeName("#define VER_NUM_BITS_PER_CONDITION_MASK 3")]
    public const int VER_NUM_BITS_PER_CONDITION_MASK = 3;
    [NativeTypeName("#define VER_MINORVERSION 0x0000001")]
    public const int VER_MINORVERSION = 0x0000001;
    [NativeTypeName("#define VER_MAJORVERSION 0x0000002")]
    public const int VER_MAJORVERSION = 0x0000002;
    [NativeTypeName("#define VER_BUILDNUMBER 0x0000004")]
    public const int VER_BUILDNUMBER = 0x0000004;
    [NativeTypeName("#define VER_PLATFORMID 0x0000008")]
    public const int VER_PLATFORMID = 0x0000008;
    [NativeTypeName("#define VER_SERVICEPACKMINOR 0x0000010")]
    public const int VER_SERVICEPACKMINOR = 0x0000010;
    [NativeTypeName("#define VER_SERVICEPACKMAJOR 0x0000020")]
    public const int VER_SERVICEPACKMAJOR = 0x0000020;
    [NativeTypeName("#define VER_SUITENAME 0x0000040")]
    public const int VER_SUITENAME = 0x0000040;
    [NativeTypeName("#define VER_PRODUCT_TYPE 0x0000080")]
    public const int VER_PRODUCT_TYPE = 0x0000080;
    [NativeTypeName("#define VER_NT_WORKSTATION 0x0000001")]
    public const int VER_NT_WORKSTATION = 0x0000001;
    [NativeTypeName("#define VER_NT_DOMAIN_CONTROLLER 0x0000002")]
    public const int VER_NT_DOMAIN_CONTROLLER = 0x0000002;
    [NativeTypeName("#define VER_NT_SERVER 0x0000003")]
    public const int VER_NT_SERVER = 0x0000003;
    [NativeTypeName("#define VER_PLATFORM_WIN32s 0")]
    public const int VER_PLATFORM_WIN32s = 0;
    [NativeTypeName("#define VER_PLATFORM_WIN32_WINDOWS 1")]
    public const int VER_PLATFORM_WIN32_WINDOWS = 1;
    [NativeTypeName("#define VER_PLATFORM_WIN32_NT 2")]
    public const int VER_PLATFORM_WIN32_NT = 2;
}