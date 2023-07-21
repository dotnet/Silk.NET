// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class EVENT
{
    [NativeTypeName("#define EVENT_SRCSPEW_START 100")]
    public const int EVENT_SRCSPEW_START = 100;

    [NativeTypeName("#define EVENT_SRCSPEW 100")]
    public const int EVENT_SRCSPEW = 100;

    [NativeTypeName("#define EVENT_SRCSPEW_END 199")]
    public const int EVENT_SRCSPEW_END = 199;
}
