// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CONTEXT
{
    [NativeTypeName("#define CONTEXT_EXCEPTION_ACTIVE 0x08000000L")]
    public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

    [NativeTypeName("#define CONTEXT_SERVICE_ACTIVE 0x10000000L")]
    public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;

    [NativeTypeName("#define CONTEXT_EXCEPTION_REQUEST 0x40000000L")]
    public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;

    [NativeTypeName("#define CONTEXT_EXCEPTION_REPORTING 0x80000000L")]
    public const uint CONTEXT_EXCEPTION_REPORTING = 0x80000000;
}
