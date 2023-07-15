// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define RIGHT_ALT_PRESSED 0x0001")]
    public const int RIGHT_ALT_PRESSED = 0x0001;
    [NativeTypeName("#define LEFT_ALT_PRESSED 0x0002")]
    public const int LEFT_ALT_PRESSED = 0x0002;
    [NativeTypeName("#define RIGHT_CTRL_PRESSED 0x0004")]
    public const int RIGHT_CTRL_PRESSED = 0x0004;
    [NativeTypeName("#define LEFT_CTRL_PRESSED 0x0008")]
    public const int LEFT_CTRL_PRESSED = 0x0008;
    [NativeTypeName("#define SHIFT_PRESSED 0x0010")]
    public const int SHIFT_PRESSED = 0x0010;
    [NativeTypeName("#define NUMLOCK_ON 0x0020")]
    public const int NUMLOCK_ON = 0x0020;
    [NativeTypeName("#define SCROLLLOCK_ON 0x0040")]
    public const int SCROLLLOCK_ON = 0x0040;
    [NativeTypeName("#define CAPSLOCK_ON 0x0080")]
    public const int CAPSLOCK_ON = 0x0080;
    [NativeTypeName("#define ENHANCED_KEY 0x0100")]
    public const int ENHANCED_KEY = 0x0100;
    [NativeTypeName("#define NLS_DBCSCHAR 0x00010000")]
    public const int NLS_DBCSCHAR = 0x00010000;
    [NativeTypeName("#define NLS_ALPHANUMERIC 0x00000000")]
    public const int NLS_ALPHANUMERIC = 0x00000000;
    [NativeTypeName("#define NLS_KATAKANA 0x00020000")]
    public const int NLS_KATAKANA = 0x00020000;
    [NativeTypeName("#define NLS_HIRAGANA 0x00040000")]
    public const int NLS_HIRAGANA = 0x00040000;
    [NativeTypeName("#define NLS_ROMAN 0x00400000")]
    public const int NLS_ROMAN = 0x00400000;
    [NativeTypeName("#define NLS_IME_CONVERSION 0x00800000")]
    public const int NLS_IME_CONVERSION = 0x00800000;
    [NativeTypeName("#define ALTNUMPAD_BIT 0x04000000")]
    public const int ALTNUMPAD_BIT = 0x04000000;
    [NativeTypeName("#define NLS_IME_DISABLE 0x20000000")]
    public const int NLS_IME_DISABLE = 0x20000000;
    [NativeTypeName("#define FROM_LEFT_1ST_BUTTON_PRESSED 0x0001")]
    public const int FROM_LEFT_1ST_BUTTON_PRESSED = 0x0001;
    [NativeTypeName("#define RIGHTMOST_BUTTON_PRESSED 0x0002")]
    public const int RIGHTMOST_BUTTON_PRESSED = 0x0002;
    [NativeTypeName("#define FROM_LEFT_2ND_BUTTON_PRESSED 0x0004")]
    public const int FROM_LEFT_2ND_BUTTON_PRESSED = 0x0004;
    [NativeTypeName("#define FROM_LEFT_3RD_BUTTON_PRESSED 0x0008")]
    public const int FROM_LEFT_3RD_BUTTON_PRESSED = 0x0008;
    [NativeTypeName("#define FROM_LEFT_4TH_BUTTON_PRESSED 0x0010")]
    public const int FROM_LEFT_4TH_BUTTON_PRESSED = 0x0010;
    [NativeTypeName("#define MOUSE_MOVED 0x0001")]
    public const int MOUSE_MOVED = 0x0001;
    [NativeTypeName("#define DOUBLE_CLICK 0x0002")]
    public const int DOUBLE_CLICK = 0x0002;
    [NativeTypeName("#define MOUSE_WHEELED 0x0004")]
    public const int MOUSE_WHEELED = 0x0004;
    [NativeTypeName("#define MOUSE_HWHEELED 0x0008")]
    public const int MOUSE_HWHEELED = 0x0008;
    [NativeTypeName("#define MOUSE_EVENT 0x0002")]
    public const int MOUSE_EVENT = 0x0002;
    [NativeTypeName("#define WINDOW_BUFFER_SIZE_EVENT 0x0004")]
    public const int WINDOW_BUFFER_SIZE_EVENT = 0x0004;
    [NativeTypeName("#define MENU_EVENT 0x0008")]
    public const int MENU_EVENT = 0x0008;
    [NativeTypeName("#define FOCUS_EVENT 0x0010")]
    public const int FOCUS_EVENT = 0x0010;
}