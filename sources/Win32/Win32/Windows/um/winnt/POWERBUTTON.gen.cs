// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class POWERBUTTON
{
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_NOTHING 0")]
    public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;

    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SLEEP 1")]
    public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;

    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_HIBERNATE 2")]
    public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;

    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SHUTDOWN 3")]
    public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;

    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY 4")]
    public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_NOTHING 0")]
    public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;

    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SLEEP 2")]
    public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;

    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_HIBERNATE 3")]
    public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;

    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SHUTDOWN 6")]
    public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;

    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY 8")]
    public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;
}
