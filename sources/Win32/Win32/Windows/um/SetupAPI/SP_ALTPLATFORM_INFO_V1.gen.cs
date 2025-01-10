// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_ALTPLATFORM_INFO_V1
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Platform;

    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    [NativeTypeName("WORD")]
    public ushort ProcessorArchitecture;

    [NativeTypeName("WORD")]
    public ushort Reserved;
}
