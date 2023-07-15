// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPPHRASERNG;

namespace TerraFX.Interop.Windows;
public static unsafe partial class SP
{
    [NativeTypeName("#define SP_LOW_CONFIDENCE ( -1 )")]
    public const int SP_LOW_CONFIDENCE = (-1);
    [NativeTypeName("#define SP_NORMAL_CONFIDENCE ( 0 )")]
    public const int SP_NORMAL_CONFIDENCE = (0);
    [NativeTypeName("#define SP_HIGH_CONFIDENCE ( +1 )")]
    public const int SP_HIGH_CONFIDENCE = (+1);
    [NativeTypeName("#define SP_MAX_WORD_LENGTH ( 128 )")]
    public const int SP_MAX_WORD_LENGTH = (128);
    [NativeTypeName("#define SP_MAX_PRON_LENGTH ( 384 )")]
    public const int SP_MAX_PRON_LENGTH = (384);
    [NativeTypeName("#define SP_EMULATE_RESULT ( 0x40000000 )")]
    public const int SP_EMULATE_RESULT = (0x40000000);
    [NativeTypeName("#define SP_SPPHRASESIZE_500 sizeof(SPPHRASE_50)")]
    public static uint SP_SPPHRASESIZE_500 => unchecked((uint)((uint)(sizeof(SPPHRASE_50))));

    [NativeTypeName("#define SP_SPPHRASESIZE_530 sizeof(SPPHRASE_53)")]
    public static uint SP_SPPHRASESIZE_530 => unchecked((uint)((uint)(sizeof(SPPHRASE_53))));

    [NativeTypeName("#define SP_GETWHOLEPHRASE SPPR_ALL_ELEMENTS")]
    public const SPPHRASERNG SP_GETWHOLEPHRASE = SPPR_ALL_ELEMENTS;
    [NativeTypeName("#define SP_STREAMPOS_ASAP ( 0 )")]
    public const int SP_STREAMPOS_ASAP = (0);
    [NativeTypeName("#define SP_STREAMPOS_REALTIME ( -1 )")]
    public const int SP_STREAMPOS_REALTIME = (-1);
    [NativeTypeName("#define SP_MAX_LANGIDS ( 20 )")]
    public const int SP_MAX_LANGIDS = (20);
}