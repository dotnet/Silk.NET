// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SHARD
{
    SHARD_PIDL = 0x00000001,
    SHARD_PATHA = 0x00000002,
    SHARD_PATHW = 0x00000003,
    SHARD_APPIDINFO = 0x00000004,
    SHARD_APPIDINFOIDLIST = 0x00000005,
    SHARD_LINK = 0x00000006,
    SHARD_APPIDINFOLINK = 0x00000007,
    SHARD_SHELLITEM = 0x00000008,
}
