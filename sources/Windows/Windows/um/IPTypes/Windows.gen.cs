// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define BROADCAST_NODETYPE 1")]
    public const int BROADCAST_NODETYPE = 1;

    [NativeTypeName("#define MIXED_NODETYPE 4")]
    public const int MIXED_NODETYPE = 4;

    [NativeTypeName("#define HYBRID_NODETYPE 8")]
    public const int HYBRID_NODETYPE = 8;
}
