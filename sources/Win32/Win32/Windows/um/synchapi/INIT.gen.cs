// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class INIT
{
    [NativeTypeName("#define INIT_ONCE_CHECK_ONLY RTL_RUN_ONCE_CHECK_ONLY")]
    public const uint INIT_ONCE_CHECK_ONLY = 0x00000001U;

    [NativeTypeName("#define INIT_ONCE_ASYNC RTL_RUN_ONCE_ASYNC")]
    public const uint INIT_ONCE_ASYNC = 0x00000002U;

    [NativeTypeName("#define INIT_ONCE_INIT_FAILED RTL_RUN_ONCE_INIT_FAILED")]
    public const uint INIT_ONCE_INIT_FAILED = 0x00000004U;

    [NativeTypeName("#define INIT_ONCE_CTX_RESERVED_BITS RTL_RUN_ONCE_CTX_RESERVED_BITS")]
    public const int INIT_ONCE_CTX_RESERVED_BITS = 2;
}
