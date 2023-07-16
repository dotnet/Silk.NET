// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MIB
{
    [NativeTypeName("#define MIB_TCP_MAXCONN_DYNAMIC ((ULONG)-1)")]
    public const uint MIB_TCP_MAXCONN_DYNAMIC = unchecked((uint)(-1));
}