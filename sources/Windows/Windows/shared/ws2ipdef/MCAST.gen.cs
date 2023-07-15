// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MCAST
{
    [NativeTypeName("#define MCAST_JOIN_GROUP 41")]
    public const int MCAST_JOIN_GROUP = 41;
    [NativeTypeName("#define MCAST_LEAVE_GROUP 42")]
    public const int MCAST_LEAVE_GROUP = 42;
    [NativeTypeName("#define MCAST_BLOCK_SOURCE 43")]
    public const int MCAST_BLOCK_SOURCE = 43;
    [NativeTypeName("#define MCAST_UNBLOCK_SOURCE 44")]
    public const int MCAST_UNBLOCK_SOURCE = 44;
    [NativeTypeName("#define MCAST_JOIN_SOURCE_GROUP 45")]
    public const int MCAST_JOIN_SOURCE_GROUP = 45;
    [NativeTypeName("#define MCAST_LEAVE_SOURCE_GROUP 46")]
    public const int MCAST_LEAVE_SOURCE_GROUP = 46;
}