// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NETINFOSTRUCT
{
    [NativeTypeName("DWORD")]
    public uint cbStructure;

    [NativeTypeName("DWORD")]
    public uint dwProviderVersion;

    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [NativeTypeName("DWORD")]
    public uint dwCharacteristics;

    [NativeTypeName("ULONG_PTR")]
    public nuint dwHandle;

    [NativeTypeName("WORD")]
    public ushort wNetType;

    [NativeTypeName("DWORD")]
    public uint dwPrinters;

    [NativeTypeName("DWORD")]
    public uint dwDrives;
}
