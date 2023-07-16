// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class STG
{
    [NativeTypeName("#define STG_TOEND 0xFFFFFFFFL")]
    public const uint STG_TOEND = 0xFFFFFFFF;
    [NativeTypeName("#define STG_LAYOUT_SEQUENTIAL 0x00000000L")]
    public const int STG_LAYOUT_SEQUENTIAL = 0x00000000;
    [NativeTypeName("#define STG_LAYOUT_INTERLEAVED 0x00000001L")]
    public const int STG_LAYOUT_INTERLEAVED = 0x00000001;
}