// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define _WIN32_MSI 500")]
    public const int _WIN32_MSI = 500;
    [NativeTypeName("#define IACTIONNAME_INSTALL TEXT(\"INSTALL\")")]
    public const string IACTIONNAME_INSTALL = "INSTALL";
    [NativeTypeName("#define IACTIONNAME_ADVERTISE TEXT(\"ADVERTISE\")")]
    public const string IACTIONNAME_ADVERTISE = "ADVERTISE";
    [NativeTypeName("#define IACTIONNAME_ADMIN TEXT(\"ADMIN\")")]
    public const string IACTIONNAME_ADMIN = "ADMIN";
    [NativeTypeName("#define IACTIONNAME_SEQUENCE TEXT(\"SEQUENCE\")")]
    public const string IACTIONNAME_SEQUENCE = "SEQUENCE";
    [NativeTypeName("#define IACTIONNAME_COLLECTUSERINFO TEXT(\"CollectUserInfo\")")]
    public const string IACTIONNAME_COLLECTUSERINFO = "CollectUserInfo";
    [NativeTypeName("#define IACTIONNAME_FIRSTRUN TEXT(\"FirstRun\")")]
    public const string IACTIONNAME_FIRSTRUN = "FirstRun";
}