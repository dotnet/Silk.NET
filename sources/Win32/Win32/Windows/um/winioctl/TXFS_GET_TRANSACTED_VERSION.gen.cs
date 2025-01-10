// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TXFS_GET_TRANSACTED_VERSION
{
    [NativeTypeName("DWORD")]
    public uint ThisBaseVersion;

    [NativeTypeName("DWORD")]
    public uint LatestVersion;

    [NativeTypeName("WORD")]
    public ushort ThisMiniVersion;

    [NativeTypeName("WORD")]
    public ushort FirstMiniVersion;

    [NativeTypeName("WORD")]
    public ushort LatestMiniVersion;
}
