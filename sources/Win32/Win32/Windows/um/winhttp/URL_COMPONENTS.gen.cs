// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct URL_COMPONENTS
{
    [NativeTypeName("DWORD")]
    public uint dwStructSize;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszScheme;

    [NativeTypeName("DWORD")]
    public uint dwSchemeLength;

    [NativeTypeName("INTERNET_SCHEME")]
    public int nScheme;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszHostName;

    [NativeTypeName("DWORD")]
    public uint dwHostNameLength;

    [NativeTypeName("INTERNET_PORT")]
    public ushort nPort;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszUserName;

    [NativeTypeName("DWORD")]
    public uint dwUserNameLength;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszPassword;

    [NativeTypeName("DWORD")]
    public uint dwPasswordLength;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrlPath;

    [NativeTypeName("DWORD")]
    public uint dwUrlPathLength;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszExtraInfo;

    [NativeTypeName("DWORD")]
    public uint dwExtraInfoLength;
}
