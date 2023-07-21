// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class UI
{
    [NativeTypeName("#define UI_ANIMATION_SECONDS_EVENTUALLY ( -1 )")]
    public const int UI_ANIMATION_SECONDS_EVENTUALLY = (-1);

    [NativeTypeName("#define UI_ANIMATION_KEYFRAME_STORYBOARD_START ( ( UI_ANIMATION_KEYFRAME  )-1 )")]
    public static UI_ANIMATION_KEYFRAME UI_ANIMATION_KEYFRAME_STORYBOARD_START => unchecked((UI_ANIMATION_KEYFRAME)(-1));

    [NativeTypeName("#define UI_ANIMATION_REPEAT_INDEFINITELY ( -1 )")]
    public const int UI_ANIMATION_REPEAT_INDEFINITELY = (-1);

    [NativeTypeName("#define UI_ANIMATION_REPEAT_INDEFINITELY_CONCLUDE_AT_END ( UI_ANIMATION_REPEAT_INDEFINITELY )")]
    public const int UI_ANIMATION_REPEAT_INDEFINITELY_CONCLUDE_AT_END = ((-1));

    [NativeTypeName("#define UI_ANIMATION_REPEAT_INDEFINITELY_CONCLUDE_AT_START ( -2 )")]
    public const int UI_ANIMATION_REPEAT_INDEFINITELY_CONCLUDE_AT_START = (-2);

    [NativeTypeName("#define UI_ANIMATION_SECONDS_INFINITE ( -1 )")]
    public const int UI_ANIMATION_SECONDS_INFINITE = (-1);

    [NativeTypeName("#define UI_ANIMATION_DIMENSION_UNKNOWN ( ( UINT  )-1 )")]
    public const uint UI_ANIMATION_DIMENSION_UNKNOWN = unchecked((uint)(-1));

    [NativeTypeName("#define UI_ANIMATION_ITERATION_NONE ( ( UINT32  )-1 )")]
    public const uint UI_ANIMATION_ITERATION_NONE = unchecked((uint)(-1));
}
