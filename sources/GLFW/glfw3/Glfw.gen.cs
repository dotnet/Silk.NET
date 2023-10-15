// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;
public static unsafe partial class Glfw
{
    [NativeTypeName("#define GLFW_VERSION_MAJOR 3")]
    public const int GLFW_VERSION_MAJOR = 3;
    [NativeTypeName("#define GLFW_VERSION_MINOR 4")]
    public const int GLFW_VERSION_MINOR = 4;
    [NativeTypeName("#define GLFW_VERSION_REVISION 0")]
    public const int GLFW_VERSION_REVISION = 0;
    [NativeTypeName("#define GLFW_TRUE 1")]
    public const int GLFW_TRUE = 1;
    [NativeTypeName("#define GLFW_FALSE 0")]
    public const int GLFW_FALSE = 0;
    [NativeTypeName("#define GLFW_RELEASE 0")]
    public const int GLFW_RELEASE = 0;
    [NativeTypeName("#define GLFW_PRESS 1")]
    public const int GLFW_PRESS = 1;
    [NativeTypeName("#define GLFW_REPEAT 2")]
    public const int GLFW_REPEAT = 2;
    [NativeTypeName("#define GLFW_HAT_CENTERED 0")]
    public const int GLFW_HAT_CENTERED = 0;
    [NativeTypeName("#define GLFW_HAT_UP 1")]
    public const int GLFW_HAT_UP = 1;
    [NativeTypeName("#define GLFW_HAT_RIGHT 2")]
    public const int GLFW_HAT_RIGHT = 2;
    [NativeTypeName("#define GLFW_HAT_DOWN 4")]
    public const int GLFW_HAT_DOWN = 4;
    [NativeTypeName("#define GLFW_HAT_LEFT 8")]
    public const int GLFW_HAT_LEFT = 8;
    [NativeTypeName("#define GLFW_HAT_RIGHT_UP (GLFW_HAT_RIGHT | GLFW_HAT_UP)")]
    public const int GLFW_HAT_RIGHT_UP = (2 | 1);
    [NativeTypeName("#define GLFW_HAT_RIGHT_DOWN (GLFW_HAT_RIGHT | GLFW_HAT_DOWN)")]
    public const int GLFW_HAT_RIGHT_DOWN = (2 | 4);
    [NativeTypeName("#define GLFW_HAT_LEFT_UP (GLFW_HAT_LEFT  | GLFW_HAT_UP)")]
    public const int GLFW_HAT_LEFT_UP = (8 | 1);
    [NativeTypeName("#define GLFW_HAT_LEFT_DOWN (GLFW_HAT_LEFT  | GLFW_HAT_DOWN)")]
    public const int GLFW_HAT_LEFT_DOWN = (8 | 4);
    [NativeTypeName("#define GLFW_KEY_UNKNOWN -1")]
    public const int GLFW_KEY_UNKNOWN = -1;
    [NativeTypeName("#define GLFW_KEY_SPACE 32")]
    public const int GLFW_KEY_SPACE = 32;
    [NativeTypeName("#define GLFW_KEY_APOSTROPHE 39")]
    public const int GLFW_KEY_APOSTROPHE = 39;
    [NativeTypeName("#define GLFW_KEY_COMMA 44")]
    public const int GLFW_KEY_COMMA = 44;
    [NativeTypeName("#define GLFW_KEY_MINUS 45")]
    public const int GLFW_KEY_MINUS = 45;
    [NativeTypeName("#define GLFW_KEY_PERIOD 46")]
    public const int GLFW_KEY_PERIOD = 46;
    [NativeTypeName("#define GLFW_KEY_SLASH 47")]
    public const int GLFW_KEY_SLASH = 47;
    [NativeTypeName("#define GLFW_KEY_0 48")]
    public const int GLFW_KEY_0 = 48;
    [NativeTypeName("#define GLFW_KEY_1 49")]
    public const int GLFW_KEY_1 = 49;
    [NativeTypeName("#define GLFW_KEY_2 50")]
    public const int GLFW_KEY_2 = 50;
    [NativeTypeName("#define GLFW_KEY_3 51")]
    public const int GLFW_KEY_3 = 51;
    [NativeTypeName("#define GLFW_KEY_4 52")]
    public const int GLFW_KEY_4 = 52;
    [NativeTypeName("#define GLFW_KEY_5 53")]
    public const int GLFW_KEY_5 = 53;
    [NativeTypeName("#define GLFW_KEY_6 54")]
    public const int GLFW_KEY_6 = 54;
    [NativeTypeName("#define GLFW_KEY_7 55")]
    public const int GLFW_KEY_7 = 55;
    [NativeTypeName("#define GLFW_KEY_8 56")]
    public const int GLFW_KEY_8 = 56;
    [NativeTypeName("#define GLFW_KEY_9 57")]
    public const int GLFW_KEY_9 = 57;
    [NativeTypeName("#define GLFW_KEY_SEMICOLON 59")]
    public const int GLFW_KEY_SEMICOLON = 59;
    [NativeTypeName("#define GLFW_KEY_EQUAL 61")]
    public const int GLFW_KEY_EQUAL = 61;
    [NativeTypeName("#define GLFW_KEY_A 65")]
    public const int GLFW_KEY_A = 65;
    [NativeTypeName("#define GLFW_KEY_B 66")]
    public const int GLFW_KEY_B = 66;
    [NativeTypeName("#define GLFW_KEY_C 67")]
    public const int GLFW_KEY_C = 67;
    [NativeTypeName("#define GLFW_KEY_D 68")]
    public const int GLFW_KEY_D = 68;
    [NativeTypeName("#define GLFW_KEY_E 69")]
    public const int GLFW_KEY_E = 69;
    [NativeTypeName("#define GLFW_KEY_F 70")]
    public const int GLFW_KEY_F = 70;
    [NativeTypeName("#define GLFW_KEY_G 71")]
    public const int GLFW_KEY_G = 71;
    [NativeTypeName("#define GLFW_KEY_H 72")]
    public const int GLFW_KEY_H = 72;
    [NativeTypeName("#define GLFW_KEY_I 73")]
    public const int GLFW_KEY_I = 73;
    [NativeTypeName("#define GLFW_KEY_J 74")]
    public const int GLFW_KEY_J = 74;
    [NativeTypeName("#define GLFW_KEY_K 75")]
    public const int GLFW_KEY_K = 75;
    [NativeTypeName("#define GLFW_KEY_L 76")]
    public const int GLFW_KEY_L = 76;
    [NativeTypeName("#define GLFW_KEY_M 77")]
    public const int GLFW_KEY_M = 77;
    [NativeTypeName("#define GLFW_KEY_N 78")]
    public const int GLFW_KEY_N = 78;
    [NativeTypeName("#define GLFW_KEY_O 79")]
    public const int GLFW_KEY_O = 79;
    [NativeTypeName("#define GLFW_KEY_P 80")]
    public const int GLFW_KEY_P = 80;
    [NativeTypeName("#define GLFW_KEY_Q 81")]
    public const int GLFW_KEY_Q = 81;
    [NativeTypeName("#define GLFW_KEY_R 82")]
    public const int GLFW_KEY_R = 82;
    [NativeTypeName("#define GLFW_KEY_S 83")]
    public const int GLFW_KEY_S = 83;
    [NativeTypeName("#define GLFW_KEY_T 84")]
    public const int GLFW_KEY_T = 84;
    [NativeTypeName("#define GLFW_KEY_U 85")]
    public const int GLFW_KEY_U = 85;
    [NativeTypeName("#define GLFW_KEY_V 86")]
    public const int GLFW_KEY_V = 86;
    [NativeTypeName("#define GLFW_KEY_W 87")]
    public const int GLFW_KEY_W = 87;
    [NativeTypeName("#define GLFW_KEY_X 88")]
    public const int GLFW_KEY_X = 88;
    [NativeTypeName("#define GLFW_KEY_Y 89")]
    public const int GLFW_KEY_Y = 89;
    [NativeTypeName("#define GLFW_KEY_Z 90")]
    public const int GLFW_KEY_Z = 90;
    [NativeTypeName("#define GLFW_KEY_LEFT_BRACKET 91")]
    public const int GLFW_KEY_LEFT_BRACKET = 91;
    [NativeTypeName("#define GLFW_KEY_BACKSLASH 92")]
    public const int GLFW_KEY_BACKSLASH = 92;
    [NativeTypeName("#define GLFW_KEY_RIGHT_BRACKET 93")]
    public const int GLFW_KEY_RIGHT_BRACKET = 93;
    [NativeTypeName("#define GLFW_KEY_GRAVE_ACCENT 96")]
    public const int GLFW_KEY_GRAVE_ACCENT = 96;
    [NativeTypeName("#define GLFW_KEY_WORLD_1 161")]
    public const int GLFW_KEY_WORLD_1 = 161;
    [NativeTypeName("#define GLFW_KEY_WORLD_2 162")]
    public const int GLFW_KEY_WORLD_2 = 162;
    [NativeTypeName("#define GLFW_KEY_ESCAPE 256")]
    public const int GLFW_KEY_ESCAPE = 256;
    [NativeTypeName("#define GLFW_KEY_ENTER 257")]
    public const int GLFW_KEY_ENTER = 257;
    [NativeTypeName("#define GLFW_KEY_TAB 258")]
    public const int GLFW_KEY_TAB = 258;
    [NativeTypeName("#define GLFW_KEY_BACKSPACE 259")]
    public const int GLFW_KEY_BACKSPACE = 259;
    [NativeTypeName("#define GLFW_KEY_INSERT 260")]
    public const int GLFW_KEY_INSERT = 260;
    [NativeTypeName("#define GLFW_KEY_DELETE 261")]
    public const int GLFW_KEY_DELETE = 261;
    [NativeTypeName("#define GLFW_KEY_RIGHT 262")]
    public const int GLFW_KEY_RIGHT = 262;
    [NativeTypeName("#define GLFW_KEY_LEFT 263")]
    public const int GLFW_KEY_LEFT = 263;
    [NativeTypeName("#define GLFW_KEY_DOWN 264")]
    public const int GLFW_KEY_DOWN = 264;
    [NativeTypeName("#define GLFW_KEY_UP 265")]
    public const int GLFW_KEY_UP = 265;
    [NativeTypeName("#define GLFW_KEY_PAGE_UP 266")]
    public const int GLFW_KEY_PAGE_UP = 266;
    [NativeTypeName("#define GLFW_KEY_PAGE_DOWN 267")]
    public const int GLFW_KEY_PAGE_DOWN = 267;
    [NativeTypeName("#define GLFW_KEY_HOME 268")]
    public const int GLFW_KEY_HOME = 268;
    [NativeTypeName("#define GLFW_KEY_END 269")]
    public const int GLFW_KEY_END = 269;
    [NativeTypeName("#define GLFW_KEY_CAPS_LOCK 280")]
    public const int GLFW_KEY_CAPS_LOCK = 280;
    [NativeTypeName("#define GLFW_KEY_SCROLL_LOCK 281")]
    public const int GLFW_KEY_SCROLL_LOCK = 281;
    [NativeTypeName("#define GLFW_KEY_NUM_LOCK 282")]
    public const int GLFW_KEY_NUM_LOCK = 282;
    [NativeTypeName("#define GLFW_KEY_PRINT_SCREEN 283")]
    public const int GLFW_KEY_PRINT_SCREEN = 283;
    [NativeTypeName("#define GLFW_KEY_PAUSE 284")]
    public const int GLFW_KEY_PAUSE = 284;
    [NativeTypeName("#define GLFW_KEY_F1 290")]
    public const int GLFW_KEY_F1 = 290;
    [NativeTypeName("#define GLFW_KEY_F2 291")]
    public const int GLFW_KEY_F2 = 291;
    [NativeTypeName("#define GLFW_KEY_F3 292")]
    public const int GLFW_KEY_F3 = 292;
    [NativeTypeName("#define GLFW_KEY_F4 293")]
    public const int GLFW_KEY_F4 = 293;
    [NativeTypeName("#define GLFW_KEY_F5 294")]
    public const int GLFW_KEY_F5 = 294;
    [NativeTypeName("#define GLFW_KEY_F6 295")]
    public const int GLFW_KEY_F6 = 295;
    [NativeTypeName("#define GLFW_KEY_F7 296")]
    public const int GLFW_KEY_F7 = 296;
    [NativeTypeName("#define GLFW_KEY_F8 297")]
    public const int GLFW_KEY_F8 = 297;
    [NativeTypeName("#define GLFW_KEY_F9 298")]
    public const int GLFW_KEY_F9 = 298;
    [NativeTypeName("#define GLFW_KEY_F10 299")]
    public const int GLFW_KEY_F10 = 299;
    [NativeTypeName("#define GLFW_KEY_F11 300")]
    public const int GLFW_KEY_F11 = 300;
    [NativeTypeName("#define GLFW_KEY_F12 301")]
    public const int GLFW_KEY_F12 = 301;
    [NativeTypeName("#define GLFW_KEY_F13 302")]
    public const int GLFW_KEY_F13 = 302;
    [NativeTypeName("#define GLFW_KEY_F14 303")]
    public const int GLFW_KEY_F14 = 303;
    [NativeTypeName("#define GLFW_KEY_F15 304")]
    public const int GLFW_KEY_F15 = 304;
    [NativeTypeName("#define GLFW_KEY_F16 305")]
    public const int GLFW_KEY_F16 = 305;
    [NativeTypeName("#define GLFW_KEY_F17 306")]
    public const int GLFW_KEY_F17 = 306;
    [NativeTypeName("#define GLFW_KEY_F18 307")]
    public const int GLFW_KEY_F18 = 307;
    [NativeTypeName("#define GLFW_KEY_F19 308")]
    public const int GLFW_KEY_F19 = 308;
    [NativeTypeName("#define GLFW_KEY_F20 309")]
    public const int GLFW_KEY_F20 = 309;
    [NativeTypeName("#define GLFW_KEY_F21 310")]
    public const int GLFW_KEY_F21 = 310;
    [NativeTypeName("#define GLFW_KEY_F22 311")]
    public const int GLFW_KEY_F22 = 311;
    [NativeTypeName("#define GLFW_KEY_F23 312")]
    public const int GLFW_KEY_F23 = 312;
    [NativeTypeName("#define GLFW_KEY_F24 313")]
    public const int GLFW_KEY_F24 = 313;
    [NativeTypeName("#define GLFW_KEY_F25 314")]
    public const int GLFW_KEY_F25 = 314;
    [NativeTypeName("#define GLFW_KEY_KP_0 320")]
    public const int GLFW_KEY_KP_0 = 320;
    [NativeTypeName("#define GLFW_KEY_KP_1 321")]
    public const int GLFW_KEY_KP_1 = 321;
    [NativeTypeName("#define GLFW_KEY_KP_2 322")]
    public const int GLFW_KEY_KP_2 = 322;
    [NativeTypeName("#define GLFW_KEY_KP_3 323")]
    public const int GLFW_KEY_KP_3 = 323;
    [NativeTypeName("#define GLFW_KEY_KP_4 324")]
    public const int GLFW_KEY_KP_4 = 324;
    [NativeTypeName("#define GLFW_KEY_KP_5 325")]
    public const int GLFW_KEY_KP_5 = 325;
    [NativeTypeName("#define GLFW_KEY_KP_6 326")]
    public const int GLFW_KEY_KP_6 = 326;
    [NativeTypeName("#define GLFW_KEY_KP_7 327")]
    public const int GLFW_KEY_KP_7 = 327;
    [NativeTypeName("#define GLFW_KEY_KP_8 328")]
    public const int GLFW_KEY_KP_8 = 328;
    [NativeTypeName("#define GLFW_KEY_KP_9 329")]
    public const int GLFW_KEY_KP_9 = 329;
    [NativeTypeName("#define GLFW_KEY_KP_DECIMAL 330")]
    public const int GLFW_KEY_KP_DECIMAL = 330;
    [NativeTypeName("#define GLFW_KEY_KP_DIVIDE 331")]
    public const int GLFW_KEY_KP_DIVIDE = 331;
    [NativeTypeName("#define GLFW_KEY_KP_MULTIPLY 332")]
    public const int GLFW_KEY_KP_MULTIPLY = 332;
    [NativeTypeName("#define GLFW_KEY_KP_SUBTRACT 333")]
    public const int GLFW_KEY_KP_SUBTRACT = 333;
    [NativeTypeName("#define GLFW_KEY_KP_ADD 334")]
    public const int GLFW_KEY_KP_ADD = 334;
    [NativeTypeName("#define GLFW_KEY_KP_ENTER 335")]
    public const int GLFW_KEY_KP_ENTER = 335;
    [NativeTypeName("#define GLFW_KEY_KP_EQUAL 336")]
    public const int GLFW_KEY_KP_EQUAL = 336;
    [NativeTypeName("#define GLFW_KEY_LEFT_SHIFT 340")]
    public const int GLFW_KEY_LEFT_SHIFT = 340;
    [NativeTypeName("#define GLFW_KEY_LEFT_CONTROL 341")]
    public const int GLFW_KEY_LEFT_CONTROL = 341;
    [NativeTypeName("#define GLFW_KEY_LEFT_ALT 342")]
    public const int GLFW_KEY_LEFT_ALT = 342;
    [NativeTypeName("#define GLFW_KEY_LEFT_SUPER 343")]
    public const int GLFW_KEY_LEFT_SUPER = 343;
    [NativeTypeName("#define GLFW_KEY_RIGHT_SHIFT 344")]
    public const int GLFW_KEY_RIGHT_SHIFT = 344;
    [NativeTypeName("#define GLFW_KEY_RIGHT_CONTROL 345")]
    public const int GLFW_KEY_RIGHT_CONTROL = 345;
    [NativeTypeName("#define GLFW_KEY_RIGHT_ALT 346")]
    public const int GLFW_KEY_RIGHT_ALT = 346;
    [NativeTypeName("#define GLFW_KEY_RIGHT_SUPER 347")]
    public const int GLFW_KEY_RIGHT_SUPER = 347;
    [NativeTypeName("#define GLFW_KEY_MENU 348")]
    public const int GLFW_KEY_MENU = 348;
    [NativeTypeName("#define GLFW_KEY_LAST GLFW_KEY_MENU")]
    public const int GLFW_KEY_LAST = 348;
    [NativeTypeName("#define GLFW_MOD_SHIFT 0x0001")]
    public const int GLFW_MOD_SHIFT = 0x0001;
    [NativeTypeName("#define GLFW_MOD_CONTROL 0x0002")]
    public const int GLFW_MOD_CONTROL = 0x0002;
    [NativeTypeName("#define GLFW_MOD_ALT 0x0004")]
    public const int GLFW_MOD_ALT = 0x0004;
    [NativeTypeName("#define GLFW_MOD_SUPER 0x0008")]
    public const int GLFW_MOD_SUPER = 0x0008;
    [NativeTypeName("#define GLFW_MOD_CAPS_LOCK 0x0010")]
    public const int GLFW_MOD_CAPS_LOCK = 0x0010;
    [NativeTypeName("#define GLFW_MOD_NUM_LOCK 0x0020")]
    public const int GLFW_MOD_NUM_LOCK = 0x0020;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_1 0")]
    public const int GLFW_MOUSE_BUTTON_1 = 0;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_2 1")]
    public const int GLFW_MOUSE_BUTTON_2 = 1;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_3 2")]
    public const int GLFW_MOUSE_BUTTON_3 = 2;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_4 3")]
    public const int GLFW_MOUSE_BUTTON_4 = 3;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_5 4")]
    public const int GLFW_MOUSE_BUTTON_5 = 4;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_6 5")]
    public const int GLFW_MOUSE_BUTTON_6 = 5;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_7 6")]
    public const int GLFW_MOUSE_BUTTON_7 = 6;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_8 7")]
    public const int GLFW_MOUSE_BUTTON_8 = 7;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LAST GLFW_MOUSE_BUTTON_8")]
    public const int GLFW_MOUSE_BUTTON_LAST = 7;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LEFT GLFW_MOUSE_BUTTON_1")]
    public const int GLFW_MOUSE_BUTTON_LEFT = 0;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_RIGHT GLFW_MOUSE_BUTTON_2")]
    public const int GLFW_MOUSE_BUTTON_RIGHT = 1;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_MIDDLE GLFW_MOUSE_BUTTON_3")]
    public const int GLFW_MOUSE_BUTTON_MIDDLE = 2;
    [NativeTypeName("#define GLFW_JOYSTICK_1 0")]
    public const int GLFW_JOYSTICK_1 = 0;
    [NativeTypeName("#define GLFW_JOYSTICK_2 1")]
    public const int GLFW_JOYSTICK_2 = 1;
    [NativeTypeName("#define GLFW_JOYSTICK_3 2")]
    public const int GLFW_JOYSTICK_3 = 2;
    [NativeTypeName("#define GLFW_JOYSTICK_4 3")]
    public const int GLFW_JOYSTICK_4 = 3;
    [NativeTypeName("#define GLFW_JOYSTICK_5 4")]
    public const int GLFW_JOYSTICK_5 = 4;
    [NativeTypeName("#define GLFW_JOYSTICK_6 5")]
    public const int GLFW_JOYSTICK_6 = 5;
    [NativeTypeName("#define GLFW_JOYSTICK_7 6")]
    public const int GLFW_JOYSTICK_7 = 6;
    [NativeTypeName("#define GLFW_JOYSTICK_8 7")]
    public const int GLFW_JOYSTICK_8 = 7;
    [NativeTypeName("#define GLFW_JOYSTICK_9 8")]
    public const int GLFW_JOYSTICK_9 = 8;
    [NativeTypeName("#define GLFW_JOYSTICK_10 9")]
    public const int GLFW_JOYSTICK_10 = 9;
    [NativeTypeName("#define GLFW_JOYSTICK_11 10")]
    public const int GLFW_JOYSTICK_11 = 10;
    [NativeTypeName("#define GLFW_JOYSTICK_12 11")]
    public const int GLFW_JOYSTICK_12 = 11;
    [NativeTypeName("#define GLFW_JOYSTICK_13 12")]
    public const int GLFW_JOYSTICK_13 = 12;
    [NativeTypeName("#define GLFW_JOYSTICK_14 13")]
    public const int GLFW_JOYSTICK_14 = 13;
    [NativeTypeName("#define GLFW_JOYSTICK_15 14")]
    public const int GLFW_JOYSTICK_15 = 14;
    [NativeTypeName("#define GLFW_JOYSTICK_16 15")]
    public const int GLFW_JOYSTICK_16 = 15;
    [NativeTypeName("#define GLFW_JOYSTICK_LAST GLFW_JOYSTICK_16")]
    public const int GLFW_JOYSTICK_LAST = 15;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_A 0")]
    public const int GLFW_GAMEPAD_BUTTON_A = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_B 1")]
    public const int GLFW_GAMEPAD_BUTTON_B = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_X 2")]
    public const int GLFW_GAMEPAD_BUTTON_X = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_Y 3")]
    public const int GLFW_GAMEPAD_BUTTON_Y = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_BUMPER 4")]
    public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER 5")]
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_BACK 6")]
    public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_START 7")]
    public const int GLFW_GAMEPAD_BUTTON_START = 7;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_GUIDE 8")]
    public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_THUMB 9")]
    public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_THUMB 10")]
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_UP 11")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_RIGHT 12")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_DOWN 13")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_LEFT 14")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LAST GLFW_GAMEPAD_BUTTON_DPAD_LEFT")]
    public const int GLFW_GAMEPAD_BUTTON_LAST = 14;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CROSS GLFW_GAMEPAD_BUTTON_A")]
    public const int GLFW_GAMEPAD_BUTTON_CROSS = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CIRCLE GLFW_GAMEPAD_BUTTON_B")]
    public const int GLFW_GAMEPAD_BUTTON_CIRCLE = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_SQUARE GLFW_GAMEPAD_BUTTON_X")]
    public const int GLFW_GAMEPAD_BUTTON_SQUARE = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_TRIANGLE GLFW_GAMEPAD_BUTTON_Y")]
    public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_X 0")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_Y 1")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_X 2")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_Y 3")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_TRIGGER 4")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER 5")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LAST GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER")]
    public const int GLFW_GAMEPAD_AXIS_LAST = 5;
    [NativeTypeName("#define GLFW_NO_ERROR 0")]
    public const int GLFW_NO_ERROR = 0;
    [NativeTypeName("#define GLFW_NOT_INITIALIZED 0x00010001")]
    public const int GLFW_NOT_INITIALIZED = 0x00010001;
    [NativeTypeName("#define GLFW_NO_CURRENT_CONTEXT 0x00010002")]
    public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
    [NativeTypeName("#define GLFW_INVALID_ENUM 0x00010003")]
    public const int GLFW_INVALID_ENUM = 0x00010003;
    [NativeTypeName("#define GLFW_INVALID_VALUE 0x00010004")]
    public const int GLFW_INVALID_VALUE = 0x00010004;
    [NativeTypeName("#define GLFW_OUT_OF_MEMORY 0x00010005")]
    public const int GLFW_OUT_OF_MEMORY = 0x00010005;
    [NativeTypeName("#define GLFW_API_UNAVAILABLE 0x00010006")]
    public const int GLFW_API_UNAVAILABLE = 0x00010006;
    [NativeTypeName("#define GLFW_VERSION_UNAVAILABLE 0x00010007")]
    public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
    [NativeTypeName("#define GLFW_PLATFORM_ERROR 0x00010008")]
    public const int GLFW_PLATFORM_ERROR = 0x00010008;
    [NativeTypeName("#define GLFW_FORMAT_UNAVAILABLE 0x00010009")]
    public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
    [NativeTypeName("#define GLFW_NO_WINDOW_CONTEXT 0x0001000A")]
    public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
    [NativeTypeName("#define GLFW_CURSOR_UNAVAILABLE 0x0001000B")]
    public const int GLFW_CURSOR_UNAVAILABLE = 0x0001000B;
    [NativeTypeName("#define GLFW_FEATURE_UNAVAILABLE 0x0001000C")]
    public const int GLFW_FEATURE_UNAVAILABLE = 0x0001000C;
    [NativeTypeName("#define GLFW_FEATURE_UNIMPLEMENTED 0x0001000D")]
    public const int GLFW_FEATURE_UNIMPLEMENTED = 0x0001000D;
    [NativeTypeName("#define GLFW_PLATFORM_UNAVAILABLE 0x0001000E")]
    public const int GLFW_PLATFORM_UNAVAILABLE = 0x0001000E;
    [NativeTypeName("#define GLFW_FOCUSED 0x00020001")]
    public const int GLFW_FOCUSED = 0x00020001;
    [NativeTypeName("#define GLFW_ICONIFIED 0x00020002")]
    public const int GLFW_ICONIFIED = 0x00020002;
    [NativeTypeName("#define GLFW_RESIZABLE 0x00020003")]
    public const int GLFW_RESIZABLE = 0x00020003;
    [NativeTypeName("#define GLFW_VISIBLE 0x00020004")]
    public const int GLFW_VISIBLE = 0x00020004;
    [NativeTypeName("#define GLFW_DECORATED 0x00020005")]
    public const int GLFW_DECORATED = 0x00020005;
    [NativeTypeName("#define GLFW_AUTO_ICONIFY 0x00020006")]
    public const int GLFW_AUTO_ICONIFY = 0x00020006;
    [NativeTypeName("#define GLFW_FLOATING 0x00020007")]
    public const int GLFW_FLOATING = 0x00020007;
    [NativeTypeName("#define GLFW_MAXIMIZED 0x00020008")]
    public const int GLFW_MAXIMIZED = 0x00020008;
    [NativeTypeName("#define GLFW_CENTER_CURSOR 0x00020009")]
    public const int GLFW_CENTER_CURSOR = 0x00020009;
    [NativeTypeName("#define GLFW_TRANSPARENT_FRAMEBUFFER 0x0002000A")]
    public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
    [NativeTypeName("#define GLFW_HOVERED 0x0002000B")]
    public const int GLFW_HOVERED = 0x0002000B;
    [NativeTypeName("#define GLFW_FOCUS_ON_SHOW 0x0002000C")]
    public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;
    [NativeTypeName("#define GLFW_MOUSE_PASSTHROUGH 0x0002000D")]
    public const int GLFW_MOUSE_PASSTHROUGH = 0x0002000D;
    [NativeTypeName("#define GLFW_POSITION_X 0x0002000E")]
    public const int GLFW_POSITION_X = 0x0002000E;
    [NativeTypeName("#define GLFW_POSITION_Y 0x0002000F")]
    public const int GLFW_POSITION_Y = 0x0002000F;
    [NativeTypeName("#define GLFW_RED_BITS 0x00021001")]
    public const int GLFW_RED_BITS = 0x00021001;
    [NativeTypeName("#define GLFW_GREEN_BITS 0x00021002")]
    public const int GLFW_GREEN_BITS = 0x00021002;
    [NativeTypeName("#define GLFW_BLUE_BITS 0x00021003")]
    public const int GLFW_BLUE_BITS = 0x00021003;
    [NativeTypeName("#define GLFW_ALPHA_BITS 0x00021004")]
    public const int GLFW_ALPHA_BITS = 0x00021004;
    [NativeTypeName("#define GLFW_DEPTH_BITS 0x00021005")]
    public const int GLFW_DEPTH_BITS = 0x00021005;
    [NativeTypeName("#define GLFW_STENCIL_BITS 0x00021006")]
    public const int GLFW_STENCIL_BITS = 0x00021006;
    [NativeTypeName("#define GLFW_ACCUM_RED_BITS 0x00021007")]
    public const int GLFW_ACCUM_RED_BITS = 0x00021007;
    [NativeTypeName("#define GLFW_ACCUM_GREEN_BITS 0x00021008")]
    public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
    [NativeTypeName("#define GLFW_ACCUM_BLUE_BITS 0x00021009")]
    public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
    [NativeTypeName("#define GLFW_ACCUM_ALPHA_BITS 0x0002100A")]
    public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
    [NativeTypeName("#define GLFW_AUX_BUFFERS 0x0002100B")]
    public const int GLFW_AUX_BUFFERS = 0x0002100B;
    [NativeTypeName("#define GLFW_STEREO 0x0002100C")]
    public const int GLFW_STEREO = 0x0002100C;
    [NativeTypeName("#define GLFW_SAMPLES 0x0002100D")]
    public const int GLFW_SAMPLES = 0x0002100D;
    [NativeTypeName("#define GLFW_SRGB_CAPABLE 0x0002100E")]
    public const int GLFW_SRGB_CAPABLE = 0x0002100E;
    [NativeTypeName("#define GLFW_REFRESH_RATE 0x0002100F")]
    public const int GLFW_REFRESH_RATE = 0x0002100F;
    [NativeTypeName("#define GLFW_DOUBLEBUFFER 0x00021010")]
    public const int GLFW_DOUBLEBUFFER = 0x00021010;
    [NativeTypeName("#define GLFW_CLIENT_API 0x00022001")]
    public const int GLFW_CLIENT_API = 0x00022001;
    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MAJOR 0x00022002")]
    public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MINOR 0x00022003")]
    public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
    [NativeTypeName("#define GLFW_CONTEXT_REVISION 0x00022004")]
    public const int GLFW_CONTEXT_REVISION = 0x00022004;
    [NativeTypeName("#define GLFW_CONTEXT_ROBUSTNESS 0x00022005")]
    public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
    [NativeTypeName("#define GLFW_OPENGL_FORWARD_COMPAT 0x00022006")]
    public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
    [NativeTypeName("#define GLFW_CONTEXT_DEBUG 0x00022007")]
    public const int GLFW_CONTEXT_DEBUG = 0x00022007;
    [NativeTypeName("#define GLFW_OPENGL_DEBUG_CONTEXT GLFW_CONTEXT_DEBUG")]
    public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
    [NativeTypeName("#define GLFW_OPENGL_PROFILE 0x00022008")]
    public const int GLFW_OPENGL_PROFILE = 0x00022008;
    [NativeTypeName("#define GLFW_CONTEXT_RELEASE_BEHAVIOR 0x00022009")]
    public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
    [NativeTypeName("#define GLFW_CONTEXT_NO_ERROR 0x0002200A")]
    public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
    [NativeTypeName("#define GLFW_CONTEXT_CREATION_API 0x0002200B")]
    public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
    [NativeTypeName("#define GLFW_SCALE_TO_MONITOR 0x0002200C")]
    public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
    [NativeTypeName("#define GLFW_COCOA_RETINA_FRAMEBUFFER 0x00023001")]
    public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
    [NativeTypeName("#define GLFW_COCOA_FRAME_NAME 0x00023002")]
    public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
    [NativeTypeName("#define GLFW_COCOA_GRAPHICS_SWITCHING 0x00023003")]
    public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
    [NativeTypeName("#define GLFW_X11_CLASS_NAME 0x00024001")]
    public const int GLFW_X11_CLASS_NAME = 0x00024001;
    [NativeTypeName("#define GLFW_X11_INSTANCE_NAME 0x00024002")]
    public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
    [NativeTypeName("#define GLFW_WIN32_KEYBOARD_MENU 0x00025001")]
    public const int GLFW_WIN32_KEYBOARD_MENU = 0x00025001;
    [NativeTypeName("#define GLFW_WAYLAND_APP_ID 0x00026001")]
    public const int GLFW_WAYLAND_APP_ID = 0x00026001;
    [NativeTypeName("#define GLFW_NO_API 0")]
    public const int GLFW_NO_API = 0;
    [NativeTypeName("#define GLFW_OPENGL_API 0x00030001")]
    public const int GLFW_OPENGL_API = 0x00030001;
    [NativeTypeName("#define GLFW_OPENGL_ES_API 0x00030002")]
    public const int GLFW_OPENGL_ES_API = 0x00030002;
    [NativeTypeName("#define GLFW_NO_ROBUSTNESS 0")]
    public const int GLFW_NO_ROBUSTNESS = 0;
    [NativeTypeName("#define GLFW_NO_RESET_NOTIFICATION 0x00031001")]
    public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
    [NativeTypeName("#define GLFW_LOSE_CONTEXT_ON_RESET 0x00031002")]
    public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;
    [NativeTypeName("#define GLFW_OPENGL_ANY_PROFILE 0")]
    public const int GLFW_OPENGL_ANY_PROFILE = 0;
    [NativeTypeName("#define GLFW_OPENGL_CORE_PROFILE 0x00032001")]
    public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
    [NativeTypeName("#define GLFW_OPENGL_COMPAT_PROFILE 0x00032002")]
    public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
    [NativeTypeName("#define GLFW_CURSOR 0x00033001")]
    public const int GLFW_CURSOR = 0x00033001;
    [NativeTypeName("#define GLFW_STICKY_KEYS 0x00033002")]
    public const int GLFW_STICKY_KEYS = 0x00033002;
    [NativeTypeName("#define GLFW_STICKY_MOUSE_BUTTONS 0x00033003")]
    public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
    [NativeTypeName("#define GLFW_LOCK_KEY_MODS 0x00033004")]
    public const int GLFW_LOCK_KEY_MODS = 0x00033004;
    [NativeTypeName("#define GLFW_RAW_MOUSE_MOTION 0x00033005")]
    public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;
    [NativeTypeName("#define GLFW_CURSOR_NORMAL 0x00034001")]
    public const int GLFW_CURSOR_NORMAL = 0x00034001;
    [NativeTypeName("#define GLFW_CURSOR_HIDDEN 0x00034002")]
    public const int GLFW_CURSOR_HIDDEN = 0x00034002;
    [NativeTypeName("#define GLFW_CURSOR_DISABLED 0x00034003")]
    public const int GLFW_CURSOR_DISABLED = 0x00034003;
    [NativeTypeName("#define GLFW_CURSOR_CAPTURED 0x00034004")]
    public const int GLFW_CURSOR_CAPTURED = 0x00034004;
    [NativeTypeName("#define GLFW_ANY_RELEASE_BEHAVIOR 0")]
    public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_FLUSH 0x00035001")]
    public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_NONE 0x00035002")]
    public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
    [NativeTypeName("#define GLFW_NATIVE_CONTEXT_API 0x00036001")]
    public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
    [NativeTypeName("#define GLFW_EGL_CONTEXT_API 0x00036002")]
    public const int GLFW_EGL_CONTEXT_API = 0x00036002;
    [NativeTypeName("#define GLFW_OSMESA_CONTEXT_API 0x00036003")]
    public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_NONE 0x00037001")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_NONE = 0x00037001;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGL 0x00037002")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x00037002;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGLES 0x00037003")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x00037003;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D9 0x00037004")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 = 0x00037004;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 = 0x00037005;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_VULKAN 0x00037007")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x00037007;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_METAL 0x00037008")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_METAL = 0x00037008;
    [NativeTypeName("#define GLFW_WAYLAND_PREFER_LIBDECOR 0x00038001")]
    public const int GLFW_WAYLAND_PREFER_LIBDECOR = 0x00038001;
    [NativeTypeName("#define GLFW_WAYLAND_DISABLE_LIBDECOR 0x00038002")]
    public const int GLFW_WAYLAND_DISABLE_LIBDECOR = 0x00038002;
    [NativeTypeName("#define GLFW_ANY_POSITION 0x80000000")]
    public const uint GLFW_ANY_POSITION = 0x80000000;
    [NativeTypeName("#define GLFW_ARROW_CURSOR 0x00036001")]
    public const int GLFW_ARROW_CURSOR = 0x00036001;
    [NativeTypeName("#define GLFW_IBEAM_CURSOR 0x00036002")]
    public const int GLFW_IBEAM_CURSOR = 0x00036002;
    [NativeTypeName("#define GLFW_CROSSHAIR_CURSOR 0x00036003")]
    public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
    [NativeTypeName("#define GLFW_POINTING_HAND_CURSOR 0x00036004")]
    public const int GLFW_POINTING_HAND_CURSOR = 0x00036004;
    [NativeTypeName("#define GLFW_RESIZE_EW_CURSOR 0x00036005")]
    public const int GLFW_RESIZE_EW_CURSOR = 0x00036005;
    [NativeTypeName("#define GLFW_RESIZE_NS_CURSOR 0x00036006")]
    public const int GLFW_RESIZE_NS_CURSOR = 0x00036006;
    [NativeTypeName("#define GLFW_RESIZE_NWSE_CURSOR 0x00036007")]
    public const int GLFW_RESIZE_NWSE_CURSOR = 0x00036007;
    [NativeTypeName("#define GLFW_RESIZE_NESW_CURSOR 0x00036008")]
    public const int GLFW_RESIZE_NESW_CURSOR = 0x00036008;
    [NativeTypeName("#define GLFW_RESIZE_ALL_CURSOR 0x00036009")]
    public const int GLFW_RESIZE_ALL_CURSOR = 0x00036009;
    [NativeTypeName("#define GLFW_NOT_ALLOWED_CURSOR 0x0003600A")]
    public const int GLFW_NOT_ALLOWED_CURSOR = 0x0003600A;
    [NativeTypeName("#define GLFW_HRESIZE_CURSOR GLFW_RESIZE_EW_CURSOR")]
    public const int GLFW_HRESIZE_CURSOR = 0x00036005;
    [NativeTypeName("#define GLFW_VRESIZE_CURSOR GLFW_RESIZE_NS_CURSOR")]
    public const int GLFW_VRESIZE_CURSOR = 0x00036006;
    [NativeTypeName("#define GLFW_HAND_CURSOR GLFW_POINTING_HAND_CURSOR")]
    public const int GLFW_HAND_CURSOR = 0x00036004;
    [NativeTypeName("#define GLFW_CONNECTED 0x00040001")]
    public const int GLFW_CONNECTED = 0x00040001;
    [NativeTypeName("#define GLFW_DISCONNECTED 0x00040002")]
    public const int GLFW_DISCONNECTED = 0x00040002;
    [NativeTypeName("#define GLFW_JOYSTICK_HAT_BUTTONS 0x00050001")]
    public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE 0x00050002")]
    public const int GLFW_ANGLE_PLATFORM_TYPE = 0x00050002;
    [NativeTypeName("#define GLFW_PLATFORM 0x00050003")]
    public const int GLFW_PLATFORM = 0x00050003;
    [NativeTypeName("#define GLFW_COCOA_CHDIR_RESOURCES 0x00051001")]
    public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;
    [NativeTypeName("#define GLFW_COCOA_MENUBAR 0x00051002")]
    public const int GLFW_COCOA_MENUBAR = 0x00051002;
    [NativeTypeName("#define GLFW_X11_XCB_VULKAN_SURFACE 0x00052001")]
    public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x00052001;
    [NativeTypeName("#define GLFW_WAYLAND_LIBDECOR 0x00053001")]
    public const int GLFW_WAYLAND_LIBDECOR = 0x00053001;
    [NativeTypeName("#define GLFW_ANY_PLATFORM 0x00060000")]
    public const int GLFW_ANY_PLATFORM = 0x00060000;
    [NativeTypeName("#define GLFW_PLATFORM_WIN32 0x00060001")]
    public const int GLFW_PLATFORM_WIN32 = 0x00060001;
    [NativeTypeName("#define GLFW_PLATFORM_COCOA 0x00060002")]
    public const int GLFW_PLATFORM_COCOA = 0x00060002;
    [NativeTypeName("#define GLFW_PLATFORM_WAYLAND 0x00060003")]
    public const int GLFW_PLATFORM_WAYLAND = 0x00060003;
    [NativeTypeName("#define GLFW_PLATFORM_X11 0x00060004")]
    public const int GLFW_PLATFORM_X11 = 0x00060004;
    [NativeTypeName("#define GLFW_PLATFORM_NULL 0x00060005")]
    public const int GLFW_PLATFORM_NULL = 0x00060005;
    [NativeTypeName("#define GLFW_DONT_CARE -1")]
    public const int GLFW_DONT_CARE = -1;
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWcursor> glfwCreateCursor([NativeTypeName("const GLFWimage *")] ConstPtr<GLFWimage> image, int xhot, int yhot)
    {
        fixed (GLFWimage* __dsl_image = image)
        {
            [DllImport("glfw", EntryPoint = "glfwCreateCursor")]
            static extern GLFWcursor* __DSL_glfwCreateCursor([NativeTypeName("const GLFWimage *")] GLFWimage* image, int xhot, int yhot);
            return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWcursor> glfwCreateStandardCursor(int shape)
    {
        [DllImport("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static extern GLFWcursor* __DSL_glfwCreateStandardCursor(int shape);
        return __DSL_glfwCreateStandardCursor(shape);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWwindow> glfwCreateWindow(int width, int height, [NativeTypeName("const char *")] ConstPtr<sbyte> title, Ptr<GLFWmonitor> monitor, Ptr<GLFWwindow> share)
    {
        fixed (GLFWwindow* __dsl_share = share)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        fixed (sbyte* __dsl_title = title)
        {
            [DllImport("glfw", EntryPoint = "glfwCreateWindow")]
            static extern GLFWwindow* __DSL_glfwCreateWindow(int width, int height, [NativeTypeName("const char *")] sbyte* title, GLFWmonitor* monitor, GLFWwindow* share);
            return __DSL_glfwCreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwDefaultWindowHints();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwDestroyCursor(Ptr<GLFWcursor> cursor)
    {
        fixed (GLFWcursor* __dsl_cursor = cursor)
        {
            [DllImport("glfw", EntryPoint = "glfwDestroyCursor")]
            static extern void __DSL_glfwDestroyCursor(GLFWcursor* cursor);
            __DSL_glfwDestroyCursor(__dsl_cursor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwDestroyWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwDestroyWindow")]
            static extern void __DSL_glfwDestroyWindow(GLFWwindow* window);
            __DSL_glfwDestroyWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwExtensionSupported([NativeTypeName("const char *")] ConstPtr<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            [DllImport("glfw", EntryPoint = "glfwExtensionSupported")]
            static extern int __DSL_glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension);
            return __DSL_glfwExtensionSupported(__dsl_extension);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwFocusWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwFocusWindow")]
            static extern void __DSL_glfwFocusWindow(GLFWwindow* window);
            __DSL_glfwFocusWindow(__dsl_window);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetClipboardString(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetClipboardString")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetClipboardString(GLFWwindow* window);
            return __DSL_glfwGetClipboardString(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWwindow> glfwGetCurrentContext()
    {
        [DllImport("glfw", EntryPoint = "glfwGetCurrentContext")]
        static extern GLFWwindow* __DSL_glfwGetCurrentContext();
        return __DSL_glfwGetCurrentContext();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetCursorPos(Ptr<GLFWwindow> window, Ptr<double> xpos, Ptr<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetCursorPos")]
            static extern void __DSL_glfwGetCursorPos(GLFWwindow* window, double* xpos, double* ypos);
            __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetError([NativeTypeName("const char **")] ConstPtr2D<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            [DllImport("glfw", EntryPoint = "glfwGetError")]
            static extern int __DSL_glfwGetError([NativeTypeName("const char **")] sbyte** description);
            return __DSL_glfwGetError(__dsl_description);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetFramebufferSize(Ptr<GLFWwindow> window, Ptr<int> width, Ptr<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetFramebufferSize")]
            static extern void __DSL_glfwGetFramebufferSize(GLFWwindow* window, int* width, int* height);
            __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetGamepadName(int jid)
    {
        [DllImport("glfw", EntryPoint = "glfwGetGamepadName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetGamepadName(int jid);
        return __DSL_glfwGetGamepadName(jid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetGamepadState(int jid, Ptr<GLFWgamepadstate> state)
    {
        fixed (GLFWgamepadstate* __dsl_state = state)
        {
            [DllImport("glfw", EntryPoint = "glfwGetGamepadState")]
            static extern int __DSL_glfwGetGamepadState(int jid, GLFWgamepadstate* state);
            return __DSL_glfwGetGamepadState(jid, __dsl_state);
        }
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<GLFWgammaramp> glfwGetGammaRamp(Ptr<GLFWmonitor> monitor)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetGammaRamp")]
            [return: NativeTypeName("const GLFWgammaramp *")]
            static extern GLFWgammaramp* __DSL_glfwGetGammaRamp(GLFWmonitor* monitor);
            return __DSL_glfwGetGammaRamp(__dsl_monitor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetInputMode(Ptr<GLFWwindow> window, int mode)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetInputMode")]
            static extern int __DSL_glfwGetInputMode(GLFWwindow* window, int mode);
            return __DSL_glfwGetInputMode(__dsl_window, mode);
        }
    }

    [return: NativeTypeName("const float *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<float> glfwGetJoystickAxes(int jid, Ptr<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", EntryPoint = "glfwGetJoystickAxes")]
            [return: NativeTypeName("const float *")]
            static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
            return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<byte> glfwGetJoystickButtons(int jid, Ptr<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", EntryPoint = "glfwGetJoystickButtons")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
            return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetJoystickGUID(int jid)
    {
        [DllImport("glfw", EntryPoint = "glfwGetJoystickGUID")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
        return __DSL_glfwGetJoystickGUID(jid);
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<byte> glfwGetJoystickHats(int jid, Ptr<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", EntryPoint = "glfwGetJoystickHats")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
            return __DSL_glfwGetJoystickHats(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetJoystickName(int jid)
    {
        [DllImport("glfw", EntryPoint = "glfwGetJoystickName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickName(int jid);
        return __DSL_glfwGetJoystickName(jid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Any glfwGetJoystickUserPointer(int jid)
    {
        [DllImport("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
        return __DSL_glfwGetJoystickUserPointer(jid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetKey(Ptr<GLFWwindow> window, int key)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetKey")]
            static extern int __DSL_glfwGetKey(GLFWwindow* window, int key);
            return __DSL_glfwGetKey(__dsl_window, key);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetKeyName(int key, int scancode)
    {
        [DllImport("glfw", EntryPoint = "glfwGetKeyName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
        return __DSL_glfwGetKeyName(key, scancode);
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetKeyScancode(int key);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetMonitorContentScale(Ptr<GLFWmonitor> monitor, Ptr<float> xscale, Ptr<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorContentScale")]
            static extern void __DSL_glfwGetMonitorContentScale(GLFWmonitor* monitor, float* xscale, float* yscale);
            __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetMonitorName(Ptr<GLFWmonitor> monitor)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetMonitorName(GLFWmonitor* monitor);
            return __DSL_glfwGetMonitorName(__dsl_monitor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetMonitorPhysicalSize(Ptr<GLFWmonitor> monitor, Ptr<int> widthMM, Ptr<int> heightMM)
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
            static extern void __DSL_glfwGetMonitorPhysicalSize(GLFWmonitor* monitor, int* widthMM, int* heightMM);
            __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetMonitorPos(Ptr<GLFWmonitor> monitor, Ptr<int> xpos, Ptr<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorPos")]
            static extern void __DSL_glfwGetMonitorPos(GLFWmonitor* monitor, int* xpos, int* ypos);
            __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr2D<GLFWmonitor> glfwGetMonitors(Ptr<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitors")]
            static extern GLFWmonitor** __DSL_glfwGetMonitors(int* count);
            return __DSL_glfwGetMonitors(__dsl_count);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Any glfwGetMonitorUserPointer(Ptr<GLFWmonitor> monitor)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
            static extern void* __DSL_glfwGetMonitorUserPointer(GLFWmonitor* monitor);
            return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetMonitorWorkarea(Ptr<GLFWmonitor> monitor, Ptr<int> xpos, Ptr<int> ypos, Ptr<int> width, Ptr<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
            static extern void __DSL_glfwGetMonitorWorkarea(GLFWmonitor* monitor, int* xpos, int* ypos, int* width, int* height);
            __DSL_glfwGetMonitorWorkarea(__dsl_monitor, __dsl_xpos, __dsl_ypos, __dsl_width, __dsl_height);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetMouseButton(Ptr<GLFWwindow> window, int button)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetMouseButton")]
            static extern int __DSL_glfwGetMouseButton(GLFWwindow* window, int button);
            return __DSL_glfwGetMouseButton(__dsl_window, button);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetPlatform();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWmonitor> glfwGetPrimaryMonitor()
    {
        [DllImport("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static extern GLFWmonitor* __DSL_glfwGetPrimaryMonitor();
        return __DSL_glfwGetPrimaryMonitor();
    }

    [return: NativeTypeName("GLFWglproc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<void> glfwGetProcAddress([NativeTypeName("const char *")] ConstPtr<sbyte> procname)
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            [DllImport("glfw", EntryPoint = "glfwGetProcAddress")]
            [return: NativeTypeName("GLFWglproc")]
            static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress([NativeTypeName("const char *")] sbyte* procname);
            return __DSL_glfwGetProcAddress(__dsl_procname);
        }
    }

    [return: NativeTypeName("const char **")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr2D<sbyte> glfwGetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Ptr<uint> count)
    {
        fixed (uint* __dsl_count = count)
        {
            [DllImport("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
            [return: NativeTypeName("const char **")]
            static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count);
            return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern double glfwGetTime();
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong glfwGetTimerFrequency();
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong glfwGetTimerValue();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetVersion(Ptr<int> major, Ptr<int> minor, Ptr<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            [DllImport("glfw", EntryPoint = "glfwGetVersion")]
            static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
            __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<sbyte> glfwGetVersionString()
    {
        [DllImport("glfw", EntryPoint = "glfwGetVersionString")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetVersionString();
        return __DSL_glfwGetVersionString();
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<GLFWvidmode> glfwGetVideoMode(Ptr<GLFWmonitor> monitor)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetVideoMode")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern GLFWvidmode* __DSL_glfwGetVideoMode(GLFWmonitor* monitor);
            return __DSL_glfwGetVideoMode(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ConstPtr<GLFWvidmode> glfwGetVideoModes(Ptr<GLFWmonitor> monitor, Ptr<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwGetVideoModes")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern GLFWvidmode* __DSL_glfwGetVideoModes(GLFWmonitor* monitor, int* count);
            return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwGetWindowAttrib(Ptr<GLFWwindow> window, int attrib)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowAttrib")]
            static extern int __DSL_glfwGetWindowAttrib(GLFWwindow* window, int attrib);
            return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetWindowContentScale(Ptr<GLFWwindow> window, Ptr<float> xscale, Ptr<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowContentScale")]
            static extern void __DSL_glfwGetWindowContentScale(GLFWwindow* window, float* xscale, float* yscale);
            __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetWindowFrameSize(Ptr<GLFWwindow> window, Ptr<int> left, Ptr<int> top, Ptr<int> right, Ptr<int> bottom)
    {
        fixed (int* __dsl_bottom = bottom)
        fixed (int* __dsl_right = right)
        fixed (int* __dsl_top = top)
        fixed (int* __dsl_left = left)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowFrameSize")]
            static extern void __DSL_glfwGetWindowFrameSize(GLFWwindow* window, int* left, int* top, int* right, int* bottom);
            __DSL_glfwGetWindowFrameSize(__dsl_window, __dsl_left, __dsl_top, __dsl_right, __dsl_bottom);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<GLFWmonitor> glfwGetWindowMonitor(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowMonitor")]
            static extern GLFWmonitor* __DSL_glfwGetWindowMonitor(GLFWwindow* window);
            return __DSL_glfwGetWindowMonitor(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float glfwGetWindowOpacity(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowOpacity")]
            static extern float __DSL_glfwGetWindowOpacity(GLFWwindow* window);
            return __DSL_glfwGetWindowOpacity(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetWindowPos(Ptr<GLFWwindow> window, Ptr<int> xpos, Ptr<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowPos")]
            static extern void __DSL_glfwGetWindowPos(GLFWwindow* window, int* xpos, int* ypos);
            __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwGetWindowSize(Ptr<GLFWwindow> window, Ptr<int> width, Ptr<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowSize")]
            static extern void __DSL_glfwGetWindowSize(GLFWwindow* window, int* width, int* height);
            __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Any glfwGetWindowUserPointer(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwGetWindowUserPointer")]
            static extern void* __DSL_glfwGetWindowUserPointer(GLFWwindow* window);
            return __DSL_glfwGetWindowUserPointer(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwHideWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwHideWindow")]
            static extern void __DSL_glfwHideWindow(GLFWwindow* window);
            __DSL_glfwHideWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwIconifyWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwIconifyWindow")]
            static extern void __DSL_glfwIconifyWindow(GLFWwindow* window);
            __DSL_glfwIconifyWindow(__dsl_window);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwInit();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwInitAllocator([NativeTypeName("const GLFWallocator *")] ConstPtr<GLFWallocator> allocator)
    {
        fixed (GLFWallocator* __dsl_allocator = allocator)
        {
            [DllImport("glfw", EntryPoint = "glfwInitAllocator")]
            static extern void __DSL_glfwInitAllocator([NativeTypeName("const GLFWallocator *")] GLFWallocator* allocator);
            __DSL_glfwInitAllocator(__dsl_allocator);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwInitHint(int hint, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwJoystickIsGamepad(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwJoystickPresent(int jid);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwMakeContextCurrent(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwMakeContextCurrent")]
            static extern void __DSL_glfwMakeContextCurrent(GLFWwindow* window);
            __DSL_glfwMakeContextCurrent(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwMaximizeWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwMaximizeWindow")]
            static extern void __DSL_glfwMaximizeWindow(GLFWwindow* window);
            __DSL_glfwMaximizeWindow(__dsl_window);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwPlatformSupported(int platform);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwPollEvents();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwPostEmptyEvent();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwRawMouseMotionSupported();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwRequestWindowAttention(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwRequestWindowAttention")]
            static extern void __DSL_glfwRequestWindowAttention(GLFWwindow* window);
            __DSL_glfwRequestWindowAttention(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwRestoreWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwRestoreWindow")]
            static extern void __DSL_glfwRestoreWindow(GLFWwindow* window);
            __DSL_glfwRestoreWindow(__dsl_window);
        }
    }

    [return: NativeTypeName("GLFWcharfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, uint, void> glfwSetCharCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWcharfun")] delegate* unmanaged<GLFWwindow*, uint, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCharCallback")]
            [return: NativeTypeName("GLFWcharfun")]
            static extern delegate* unmanaged<GLFWwindow*, uint, void> __DSL_glfwSetCharCallback(GLFWwindow* window, [NativeTypeName("GLFWcharfun")] delegate* unmanaged<GLFWwindow*, uint, void> callback);
            return __DSL_glfwSetCharCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, uint, int, void> glfwSetCharModsCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<GLFWwindow*, uint, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCharModsCallback")]
            [return: NativeTypeName("GLFWcharmodsfun")]
            static extern delegate* unmanaged<GLFWwindow*, uint, int, void> __DSL_glfwSetCharModsCallback(GLFWwindow* window, [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<GLFWwindow*, uint, int, void> callback);
            return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetClipboardString(Ptr<GLFWwindow> window, [NativeTypeName("const char *")] ConstPtr<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetClipboardString")]
            static extern void __DSL_glfwSetClipboardString(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* @string);
            __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetCursor(Ptr<GLFWwindow> window, Ptr<GLFWcursor> cursor)
    {
        fixed (GLFWcursor* __dsl_cursor = cursor)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCursor")]
            static extern void __DSL_glfwSetCursor(GLFWwindow* window, GLFWcursor* cursor);
            __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, void> glfwSetCursorEnterCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<GLFWwindow*, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
            [return: NativeTypeName("GLFWcursorenterfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, void> __DSL_glfwSetCursorEnterCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
            return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetCursorPos(Ptr<GLFWwindow> window, double xpos, double ypos)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCursorPos")]
            static extern void __DSL_glfwSetCursorPos(GLFWwindow* window, double xpos, double ypos);
            __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, double, double, void> glfwSetCursorPosCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWcursorposfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetCursorPosCallback")]
            [return: NativeTypeName("GLFWcursorposfun")]
            static extern delegate* unmanaged<GLFWwindow*, double, double, void> __DSL_glfwSetCursorPosCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorposfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback);
            return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWdropfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, sbyte**, void> glfwSetDropCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWdropfun")] delegate* unmanaged<GLFWwindow*, int, sbyte**, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetDropCallback")]
            [return: NativeTypeName("GLFWdropfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, sbyte**, void> __DSL_glfwSetDropCallback(GLFWwindow* window, [NativeTypeName("GLFWdropfun")] delegate* unmanaged<GLFWwindow*, int, sbyte**, void> callback);
            return __DSL_glfwSetDropCallback(__dsl_window, callback);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWerrorfun")]
    public static extern delegate* unmanaged<int, sbyte*, void> glfwSetErrorCallback([NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback);
    [return: NativeTypeName("GLFWframebuffersizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetFramebufferSizeCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWframebuffersizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
            [return: NativeTypeName("GLFWframebuffersizefun")]
            static extern delegate* unmanaged<GLFWwindow*, int, int, void> __DSL_glfwSetFramebufferSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWframebuffersizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
            return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetGamma(Ptr<GLFWmonitor> monitor, float gamma)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwSetGamma")]
            static extern void __DSL_glfwSetGamma(GLFWmonitor* monitor, float gamma);
            __DSL_glfwSetGamma(__dsl_monitor, gamma);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetGammaRamp(Ptr<GLFWmonitor> monitor, [NativeTypeName("const GLFWgammaramp *")] ConstPtr<GLFWgammaramp> ramp)
    {
        fixed (GLFWgammaramp* __dsl_ramp = ramp)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwSetGammaRamp")]
            static extern void __DSL_glfwSetGammaRamp(GLFWmonitor* monitor, [NativeTypeName("const GLFWgammaramp *")] GLFWgammaramp* ramp);
            __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetInputMode(Ptr<GLFWwindow> window, int mode, int value)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetInputMode")]
            static extern void __DSL_glfwSetInputMode(GLFWwindow* window, int mode, int value);
            __DSL_glfwSetInputMode(__dsl_window, mode, value);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWjoystickfun")]
    public static extern delegate* unmanaged<int, int, void> glfwSetJoystickCallback([NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetJoystickUserPointer(int jid, Any pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            [DllImport("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
            static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
            __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, int, int, int, void> glfwSetKeyCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWkeyfun")] delegate* unmanaged<GLFWwindow*, int, int, int, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetKeyCallback")]
            [return: NativeTypeName("GLFWkeyfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, int, int, int, void> __DSL_glfwSetKeyCallback(GLFWwindow* window, [NativeTypeName("GLFWkeyfun")] delegate* unmanaged<GLFWwindow*, int, int, int, int, void> callback);
            return __DSL_glfwSetKeyCallback(__dsl_window, callback);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWmonitorfun")]
    public static extern delegate* unmanaged<GLFWmonitor*, int, void> glfwSetMonitorCallback([NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<GLFWmonitor*, int, void> callback);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetMonitorUserPointer(Ptr<GLFWmonitor> monitor, Any pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
            static extern void __DSL_glfwSetMonitorUserPointer(GLFWmonitor* monitor, void* pointer);
            __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, int, int, void> glfwSetMouseButtonCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWmousebuttonfun")] delegate* unmanaged<GLFWwindow*, int, int, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
            [return: NativeTypeName("GLFWmousebuttonfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, int, int, void> __DSL_glfwSetMouseButtonCallback(GLFWwindow* window, [NativeTypeName("GLFWmousebuttonfun")] delegate* unmanaged<GLFWwindow*, int, int, int, void> callback);
            return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, double, double, void> glfwSetScrollCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWscrollfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetScrollCallback")]
            [return: NativeTypeName("GLFWscrollfun")]
            static extern delegate* unmanaged<GLFWwindow*, double, double, void> __DSL_glfwSetScrollCallback(GLFWwindow* window, [NativeTypeName("GLFWscrollfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback);
            return __DSL_glfwSetScrollCallback(__dsl_window, callback);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetTime(double time);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowAspectRatio(Ptr<GLFWwindow> window, int numer, int denom)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
            static extern void __DSL_glfwSetWindowAspectRatio(GLFWwindow* window, int numer, int denom);
            __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowAttrib(Ptr<GLFWwindow> window, int attrib, int value)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowAttrib")]
            static extern void __DSL_glfwSetWindowAttrib(GLFWwindow* window, int attrib, int value);
            __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, void> glfwSetWindowCloseCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<GLFWwindow*, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
            [return: NativeTypeName("GLFWwindowclosefun")]
            static extern delegate* unmanaged<GLFWwindow*, void> __DSL_glfwSetWindowCloseCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<GLFWwindow*, void> callback);
            return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, float, float, void> glfwSetWindowContentScaleCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowcontentscalefun")] delegate* unmanaged<GLFWwindow*, float, float, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
            [return: NativeTypeName("GLFWwindowcontentscalefun")]
            static extern delegate* unmanaged<GLFWwindow*, float, float, void> __DSL_glfwSetWindowContentScaleCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowcontentscalefun")] delegate* unmanaged<GLFWwindow*, float, float, void> callback);
            return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowFocusCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<GLFWwindow*, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
            [return: NativeTypeName("GLFWwindowfocusfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, void> __DSL_glfwSetWindowFocusCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
            return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowIcon(Ptr<GLFWwindow> window, int count, [NativeTypeName("const GLFWimage *")] ConstPtr<GLFWimage> images)
    {
        fixed (GLFWimage* __dsl_images = images)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowIcon")]
            static extern void __DSL_glfwSetWindowIcon(GLFWwindow* window, int count, [NativeTypeName("const GLFWimage *")] GLFWimage* images);
            __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowIconifyCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<GLFWwindow*, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
            [return: NativeTypeName("GLFWwindowiconifyfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, void> __DSL_glfwSetWindowIconifyCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
            return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowMaximizeCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<GLFWwindow*, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
            [return: NativeTypeName("GLFWwindowmaximizefun")]
            static extern delegate* unmanaged<GLFWwindow*, int, void> __DSL_glfwSetWindowMaximizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
            return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowMonitor(Ptr<GLFWwindow> window, Ptr<GLFWmonitor> monitor, int xpos, int ypos, int width, int height, int refreshRate)
    {
        fixed (GLFWmonitor* __dsl_monitor = monitor)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowMonitor")]
            static extern void __DSL_glfwSetWindowMonitor(GLFWwindow* window, GLFWmonitor* monitor, int xpos, int ypos, int width, int height, int refreshRate);
            __DSL_glfwSetWindowMonitor(__dsl_window, __dsl_monitor, xpos, ypos, width, height, refreshRate);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowOpacity(Ptr<GLFWwindow> window, float opacity)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowOpacity")]
            static extern void __DSL_glfwSetWindowOpacity(GLFWwindow* window, float opacity);
            __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowPos(Ptr<GLFWwindow> window, int xpos, int ypos)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowPos")]
            static extern void __DSL_glfwSetWindowPos(GLFWwindow* window, int xpos, int ypos);
            __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetWindowPosCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowPosCallback")]
            [return: NativeTypeName("GLFWwindowposfun")]
            static extern delegate* unmanaged<GLFWwindow*, int, int, void> __DSL_glfwSetWindowPosCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
            return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, void> glfwSetWindowRefreshCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<GLFWwindow*, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
            [return: NativeTypeName("GLFWwindowrefreshfun")]
            static extern delegate* unmanaged<GLFWwindow*, void> __DSL_glfwSetWindowRefreshCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<GLFWwindow*, void> callback);
            return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowShouldClose(Ptr<GLFWwindow> window, int value)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowShouldClose")]
            static extern void __DSL_glfwSetWindowShouldClose(GLFWwindow* window, int value);
            __DSL_glfwSetWindowShouldClose(__dsl_window, value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowSize(Ptr<GLFWwindow> window, int width, int height)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowSize")]
            static extern void __DSL_glfwSetWindowSize(GLFWwindow* window, int width, int height);
            __DSL_glfwSetWindowSize(__dsl_window, width, height);
        }
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetWindowSizeCallback(Ptr<GLFWwindow> window, [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
            [return: NativeTypeName("GLFWwindowsizefun")]
            static extern delegate* unmanaged<GLFWwindow*, int, int, void> __DSL_glfwSetWindowSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
            return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowSizeLimits(Ptr<GLFWwindow> window, int minwidth, int minheight, int maxwidth, int maxheight)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
            static extern void __DSL_glfwSetWindowSizeLimits(GLFWwindow* window, int minwidth, int minheight, int maxwidth, int maxheight);
            __DSL_glfwSetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowTitle(Ptr<GLFWwindow> window, [NativeTypeName("const char *")] ConstPtr<sbyte> title)
    {
        fixed (sbyte* __dsl_title = title)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowTitle")]
            static extern void __DSL_glfwSetWindowTitle(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* title);
            __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSetWindowUserPointer(Ptr<GLFWwindow> window, Any pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSetWindowUserPointer")]
            static extern void __DSL_glfwSetWindowUserPointer(GLFWwindow* window, void* pointer);
            __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwShowWindow(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwShowWindow")]
            static extern void __DSL_glfwShowWindow(GLFWwindow* window);
            __DSL_glfwShowWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwSwapBuffers(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwSwapBuffers")]
            static extern void __DSL_glfwSwapBuffers(GLFWwindow* window);
            __DSL_glfwSwapBuffers(__dsl_window);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSwapInterval(int interval);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwTerminate();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwUpdateGamepadMappings([NativeTypeName("const char *")] ConstPtr<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            [DllImport("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
            static extern int __DSL_glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string);
            return __DSL_glfwUpdateGamepadMappings(__dsl_string);
        }
    }

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwVulkanSupported();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWaitEvents();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWaitEventsTimeout(double timeout);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWindowHint(int hint, int value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void glfwWindowHintString(int hint, [NativeTypeName("const char *")] ConstPtr<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            [DllImport("glfw", EntryPoint = "glfwWindowHintString")]
            static extern void __DSL_glfwWindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value);
            __DSL_glfwWindowHintString(hint, __dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int glfwWindowShouldClose(Ptr<GLFWwindow> window)
    {
        fixed (GLFWwindow* __dsl_window = window)
        {
            [DllImport("glfw", EntryPoint = "glfwWindowShouldClose")]
            static extern int __DSL_glfwWindowShouldClose(GLFWwindow* window);
            return __DSL_glfwWindowShouldClose(__dsl_window);
        }
    }
}