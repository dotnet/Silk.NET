// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TOUCH
{
    [NativeTypeName("#define TOUCH_FLAG_NONE 0x00000000")]
    public const int TOUCH_FLAG_NONE = 0x00000000;

    [NativeTypeName("#define TOUCH_MASK_NONE 0x00000000")]
    public const int TOUCH_MASK_NONE = 0x00000000;

    [NativeTypeName("#define TOUCH_MASK_CONTACTAREA 0x00000001")]
    public const int TOUCH_MASK_CONTACTAREA = 0x00000001;

    [NativeTypeName("#define TOUCH_MASK_ORIENTATION 0x00000002")]
    public const int TOUCH_MASK_ORIENTATION = 0x00000002;

    [NativeTypeName("#define TOUCH_MASK_PRESSURE 0x00000004")]
    public const int TOUCH_MASK_PRESSURE = 0x00000004;

    [NativeTypeName("#define TOUCH_FEEDBACK_DEFAULT 0x1")]
    public const int TOUCH_FEEDBACK_DEFAULT = 0x1;

    [NativeTypeName("#define TOUCH_FEEDBACK_INDIRECT 0x2")]
    public const int TOUCH_FEEDBACK_INDIRECT = 0x2;

    [NativeTypeName("#define TOUCH_FEEDBACK_NONE 0x3")]
    public const int TOUCH_FEEDBACK_NONE = 0x3;

    [NativeTypeName("#define TOUCH_HIT_TESTING_DEFAULT 0x0")]
    public const int TOUCH_HIT_TESTING_DEFAULT = 0x0;

    [NativeTypeName("#define TOUCH_HIT_TESTING_CLIENT 0x1")]
    public const int TOUCH_HIT_TESTING_CLIENT = 0x1;

    [NativeTypeName("#define TOUCH_HIT_TESTING_NONE 0x2")]
    public const int TOUCH_HIT_TESTING_NONE = 0x2;

    [NativeTypeName("#define TOUCH_HIT_TESTING_PROXIMITY_CLOSEST 0x0")]
    public const int TOUCH_HIT_TESTING_PROXIMITY_CLOSEST = 0x0;

    [NativeTypeName("#define TOUCH_HIT_TESTING_PROXIMITY_FARTHEST 0xFFF")]
    public const int TOUCH_HIT_TESTING_PROXIMITY_FARTHEST = 0xFFF;
}
