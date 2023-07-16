// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class UI
{
    [NativeTypeName("#define UI_E_CREATE_FAILED _HRESULT_TYPEDEF_(0x802A0001L)")]
    public const int UI_E_CREATE_FAILED = unchecked((int)(0x802A0001));
    [NativeTypeName("#define UI_E_SHUTDOWN_CALLED _HRESULT_TYPEDEF_(0x802A0002L)")]
    public const int UI_E_SHUTDOWN_CALLED = unchecked((int)(0x802A0002));
    [NativeTypeName("#define UI_E_ILLEGAL_REENTRANCY _HRESULT_TYPEDEF_(0x802A0003L)")]
    public const int UI_E_ILLEGAL_REENTRANCY = unchecked((int)(0x802A0003));
    [NativeTypeName("#define UI_E_OBJECT_SEALED _HRESULT_TYPEDEF_(0x802A0004L)")]
    public const int UI_E_OBJECT_SEALED = unchecked((int)(0x802A0004));
    [NativeTypeName("#define UI_E_VALUE_NOT_SET _HRESULT_TYPEDEF_(0x802A0005L)")]
    public const int UI_E_VALUE_NOT_SET = unchecked((int)(0x802A0005));
    [NativeTypeName("#define UI_E_VALUE_NOT_DETERMINED _HRESULT_TYPEDEF_(0x802A0006L)")]
    public const int UI_E_VALUE_NOT_DETERMINED = unchecked((int)(0x802A0006));
    [NativeTypeName("#define UI_E_INVALID_OUTPUT _HRESULT_TYPEDEF_(0x802A0007L)")]
    public const int UI_E_INVALID_OUTPUT = unchecked((int)(0x802A0007));
    [NativeTypeName("#define UI_E_BOOLEAN_EXPECTED _HRESULT_TYPEDEF_(0x802A0008L)")]
    public const int UI_E_BOOLEAN_EXPECTED = unchecked((int)(0x802A0008));
    [NativeTypeName("#define UI_E_DIFFERENT_OWNER _HRESULT_TYPEDEF_(0x802A0009L)")]
    public const int UI_E_DIFFERENT_OWNER = unchecked((int)(0x802A0009));
    [NativeTypeName("#define UI_E_AMBIGUOUS_MATCH _HRESULT_TYPEDEF_(0x802A000AL)")]
    public const int UI_E_AMBIGUOUS_MATCH = unchecked((int)(0x802A000A));
    [NativeTypeName("#define UI_E_FP_OVERFLOW _HRESULT_TYPEDEF_(0x802A000BL)")]
    public const int UI_E_FP_OVERFLOW = unchecked((int)(0x802A000B));
    [NativeTypeName("#define UI_E_WRONG_THREAD _HRESULT_TYPEDEF_(0x802A000CL)")]
    public const int UI_E_WRONG_THREAD = unchecked((int)(0x802A000C));
    [NativeTypeName("#define UI_E_STORYBOARD_ACTIVE _HRESULT_TYPEDEF_(0x802A0101L)")]
    public const int UI_E_STORYBOARD_ACTIVE = unchecked((int)(0x802A0101));
    [NativeTypeName("#define UI_E_STORYBOARD_NOT_PLAYING _HRESULT_TYPEDEF_(0x802A0102L)")]
    public const int UI_E_STORYBOARD_NOT_PLAYING = unchecked((int)(0x802A0102));
    [NativeTypeName("#define UI_E_START_KEYFRAME_AFTER_END _HRESULT_TYPEDEF_(0x802A0103L)")]
    public const int UI_E_START_KEYFRAME_AFTER_END = unchecked((int)(0x802A0103));
    [NativeTypeName("#define UI_E_END_KEYFRAME_NOT_DETERMINED _HRESULT_TYPEDEF_(0x802A0104L)")]
    public const int UI_E_END_KEYFRAME_NOT_DETERMINED = unchecked((int)(0x802A0104));
    [NativeTypeName("#define UI_E_LOOPS_OVERLAP _HRESULT_TYPEDEF_(0x802A0105L)")]
    public const int UI_E_LOOPS_OVERLAP = unchecked((int)(0x802A0105));
    [NativeTypeName("#define UI_E_TRANSITION_ALREADY_USED _HRESULT_TYPEDEF_(0x802A0106L)")]
    public const int UI_E_TRANSITION_ALREADY_USED = unchecked((int)(0x802A0106));
    [NativeTypeName("#define UI_E_TRANSITION_NOT_IN_STORYBOARD _HRESULT_TYPEDEF_(0x802A0107L)")]
    public const int UI_E_TRANSITION_NOT_IN_STORYBOARD = unchecked((int)(0x802A0107));
    [NativeTypeName("#define UI_E_TRANSITION_ECLIPSED _HRESULT_TYPEDEF_(0x802A0108L)")]
    public const int UI_E_TRANSITION_ECLIPSED = unchecked((int)(0x802A0108));
    [NativeTypeName("#define UI_E_TIME_BEFORE_LAST_UPDATE _HRESULT_TYPEDEF_(0x802A0109L)")]
    public const int UI_E_TIME_BEFORE_LAST_UPDATE = unchecked((int)(0x802A0109));
    [NativeTypeName("#define UI_E_TIMER_CLIENT_ALREADY_CONNECTED _HRESULT_TYPEDEF_(0x802A010AL)")]
    public const int UI_E_TIMER_CLIENT_ALREADY_CONNECTED = unchecked((int)(0x802A010A));
    [NativeTypeName("#define UI_E_INVALID_DIMENSION _HRESULT_TYPEDEF_(0x802A010BL)")]
    public const int UI_E_INVALID_DIMENSION = unchecked((int)(0x802A010B));
    [NativeTypeName("#define UI_E_PRIMITIVE_OUT_OF_BOUNDS _HRESULT_TYPEDEF_(0x802A010CL)")]
    public const int UI_E_PRIMITIVE_OUT_OF_BOUNDS = unchecked((int)(0x802A010C));
    [NativeTypeName("#define UI_E_WINDOW_CLOSED _HRESULT_TYPEDEF_(0x802A0201L)")]
    public const int UI_E_WINDOW_CLOSED = unchecked((int)(0x802A0201));
}