// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static partial class GET
{
    [NativeTypeName("#define GET_TAPE_MEDIA_INFORMATION 0")]
    public const int GET_TAPE_MEDIA_INFORMATION = 0;
    [NativeTypeName("#define GET_TAPE_DRIVE_INFORMATION 1")]
    public const int GET_TAPE_DRIVE_INFORMATION = 1;
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A \"GetSystemWow64DirectoryA\"")]
    public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A => "GetSystemWow64DirectoryA"u8;

    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W L\"GetSystemWow64DirectoryA\"")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W = "GetSystemWow64DirectoryA";
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T TEXT(\"GetSystemWow64DirectoryA\")")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T = "GetSystemWow64DirectoryA";
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A \"GetSystemWow64DirectoryW\"")]
    public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A => "GetSystemWow64DirectoryW"u8;

    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W L\"GetSystemWow64DirectoryW\"")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W = "GetSystemWow64DirectoryW";
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T TEXT(\"GetSystemWow64DirectoryW\")")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T = "GetSystemWow64DirectoryW";
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A")]
    public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A => "GetSystemWow64DirectoryW"u8;

    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W = "GetSystemWow64DirectoryW";
    [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T")]
    public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T = "GetSystemWow64DirectoryW";
}