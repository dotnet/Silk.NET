// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINTRUST_FILE_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszFilePath;
    public HANDLE hFile;
    public Guid* pgKnownSubject;
}
