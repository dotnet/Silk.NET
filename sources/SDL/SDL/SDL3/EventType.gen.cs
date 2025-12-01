// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_EventType")]
public enum EventType : uint
{
    [NativeName("SDL_EVENT_FIRST")]
    First = 0,

    [NativeName("SDL_EVENT_QUIT")]
    Quit = 256,

    [NativeName("SDL_EVENT_TERMINATING")]
    Terminating = 257,

    [NativeName("SDL_EVENT_LOW_MEMORY")]
    LowMemory = 258,

    [NativeName("SDL_EVENT_WILL_ENTER_BACKGROUND")]
    WillEnterBackground = 259,

    [NativeName("SDL_EVENT_DID_ENTER_BACKGROUND")]
    DidEnterBackground = 260,

    [NativeName("SDL_EVENT_WILL_ENTER_FOREGROUND")]
    WillEnterForeground = 261,

    [NativeName("SDL_EVENT_DID_ENTER_FOREGROUND")]
    DidEnterForeground = 262,

    [NativeName("SDL_EVENT_LOCALE_CHANGED")]
    LocaleChanged = 263,

    [NativeName("SDL_EVENT_SYSTEM_THEME_CHANGED")]
    SystemThemeChanged = 264,

    [NativeName("SDL_EVENT_DISPLAY_ORIENTATION")]
    DisplayOrientation = 337,

    [NativeName("SDL_EVENT_DISPLAY_ADDED")]
    DisplayAdded = 338,

    [NativeName("SDL_EVENT_DISPLAY_REMOVED")]
    DisplayRemoved = 339,

    [NativeName("SDL_EVENT_DISPLAY_MOVED")]
    DisplayMoved = 340,

    [NativeName("SDL_EVENT_DISPLAY_DESKTOP_MODE_CHANGED")]
    DisplayDesktopModeChanged = 341,

    [NativeName("SDL_EVENT_DISPLAY_CURRENT_MODE_CHANGED")]
    DisplayCurrentModeChanged = 342,

    [NativeName("SDL_EVENT_DISPLAY_CONTENT_SCALE_CHANGED")]
    DisplayContentScaleChanged = 343,

    [NativeName("SDL_EVENT_DISPLAY_FIRST")]
    DisplayFirst = DisplayOrientation,

    [NativeName("SDL_EVENT_DISPLAY_LAST")]
    DisplayLast = DisplayContentScaleChanged,

    [NativeName("SDL_EVENT_WINDOW_SHOWN")]
    WindowShown = 514,

    [NativeName("SDL_EVENT_WINDOW_HIDDEN")]
    WindowHidden = 515,

    [NativeName("SDL_EVENT_WINDOW_EXPOSED")]
    WindowExposed = 516,

    [NativeName("SDL_EVENT_WINDOW_MOVED")]
    WindowMoved = 517,

    [NativeName("SDL_EVENT_WINDOW_RESIZED")]
    WindowResized = 518,

    [NativeName("SDL_EVENT_WINDOW_PIXEL_SIZE_CHANGED")]
    WindowPixelSizeChanged = 519,

    [NativeName("SDL_EVENT_WINDOW_METAL_VIEW_RESIZED")]
    WindowMetalViewResized = 520,

    [NativeName("SDL_EVENT_WINDOW_MINIMIZED")]
    WindowMinimized = 521,

    [NativeName("SDL_EVENT_WINDOW_MAXIMIZED")]
    WindowMaximized = 522,

    [NativeName("SDL_EVENT_WINDOW_RESTORED")]
    WindowRestored = 523,

    [NativeName("SDL_EVENT_WINDOW_MOUSE_ENTER")]
    WindowMouseEnter = 524,

    [NativeName("SDL_EVENT_WINDOW_MOUSE_LEAVE")]
    WindowMouseLeave = 525,

    [NativeName("SDL_EVENT_WINDOW_FOCUS_GAINED")]
    WindowFocusGained = 526,

    [NativeName("SDL_EVENT_WINDOW_FOCUS_LOST")]
    WindowFocusLost = 527,

    [NativeName("SDL_EVENT_WINDOW_CLOSE_REQUESTED")]
    WindowCloseRequested = 528,

    [NativeName("SDL_EVENT_WINDOW_HIT_TEST")]
    WindowHitTest = 529,

    [NativeName("SDL_EVENT_WINDOW_ICCPROF_CHANGED")]
    WindowIccprofChanged = 530,

    [NativeName("SDL_EVENT_WINDOW_DISPLAY_CHANGED")]
    WindowDisplayChanged = 531,

    [NativeName("SDL_EVENT_WINDOW_DISPLAY_SCALE_CHANGED")]
    WindowDisplayScaleChanged = 532,

    [NativeName("SDL_EVENT_WINDOW_SAFE_AREA_CHANGED")]
    WindowSafeAreaChanged = 533,

    [NativeName("SDL_EVENT_WINDOW_OCCLUDED")]
    WindowOccluded = 534,

    [NativeName("SDL_EVENT_WINDOW_ENTER_FULLSCREEN")]
    WindowEnterFullscreen = 535,

    [NativeName("SDL_EVENT_WINDOW_LEAVE_FULLSCREEN")]
    WindowLeaveFullscreen = 536,

    [NativeName("SDL_EVENT_WINDOW_DESTROYED")]
    WindowDestroyed = 537,

    [NativeName("SDL_EVENT_WINDOW_HDR_STATE_CHANGED")]
    WindowHdrStateChanged = 538,

    [NativeName("SDL_EVENT_WINDOW_FIRST")]
    WindowFirst = WindowShown,

    [NativeName("SDL_EVENT_WINDOW_LAST")]
    WindowLast = WindowHdrStateChanged,

    [NativeName("SDL_EVENT_KEY_DOWN")]
    KeyDown = 768,

    [NativeName("SDL_EVENT_KEY_UP")]
    KeyUp = 769,

    [NativeName("SDL_EVENT_TEXT_EDITING")]
    TextEditing = 770,

    [NativeName("SDL_EVENT_TEXT_INPUT")]
    TextInput = 771,

    [NativeName("SDL_EVENT_KEYMAP_CHANGED")]
    KeymapChanged = 772,

    [NativeName("SDL_EVENT_KEYBOARD_ADDED")]
    KeyboardAdded = 773,

    [NativeName("SDL_EVENT_KEYBOARD_REMOVED")]
    KeyboardRemoved = 774,

    [NativeName("SDL_EVENT_TEXT_EDITING_CANDIDATES")]
    TextEditingCandidates = 775,

    [NativeName("SDL_EVENT_MOUSE_MOTION")]
    MouseMotion = 1024,

    [NativeName("SDL_EVENT_MOUSE_BUTTON_DOWN")]
    MouseButtonDown = 1025,

    [NativeName("SDL_EVENT_MOUSE_BUTTON_UP")]
    MouseButtonUp = 1026,

    [NativeName("SDL_EVENT_MOUSE_WHEEL")]
    MouseWheel = 1027,

    [NativeName("SDL_EVENT_MOUSE_ADDED")]
    MouseAdded = 1028,

    [NativeName("SDL_EVENT_MOUSE_REMOVED")]
    MouseRemoved = 1029,

    [NativeName("SDL_EVENT_JOYSTICK_AXIS_MOTION")]
    JoystickAxisMotion = 1536,

    [NativeName("SDL_EVENT_JOYSTICK_BALL_MOTION")]
    JoystickBallMotion = 1537,

    [NativeName("SDL_EVENT_JOYSTICK_HAT_MOTION")]
    JoystickHatMotion = 1538,

    [NativeName("SDL_EVENT_JOYSTICK_BUTTON_DOWN")]
    JoystickButtonDown = 1539,

    [NativeName("SDL_EVENT_JOYSTICK_BUTTON_UP")]
    JoystickButtonUp = 1540,

    [NativeName("SDL_EVENT_JOYSTICK_ADDED")]
    JoystickAdded = 1541,

    [NativeName("SDL_EVENT_JOYSTICK_REMOVED")]
    JoystickRemoved = 1542,

    [NativeName("SDL_EVENT_JOYSTICK_BATTERY_UPDATED")]
    JoystickBatteryUpdated = 1543,

    [NativeName("SDL_EVENT_JOYSTICK_UPDATE_COMPLETE")]
    JoystickUpdateComplete = 1544,

    [NativeName("SDL_EVENT_GAMEPAD_AXIS_MOTION")]
    GamepadAxisMotion = 1616,

    [NativeName("SDL_EVENT_GAMEPAD_BUTTON_DOWN")]
    GamepadButtonDown = 1617,

    [NativeName("SDL_EVENT_GAMEPAD_BUTTON_UP")]
    GamepadButtonUp = 1618,

    [NativeName("SDL_EVENT_GAMEPAD_ADDED")]
    GamepadAdded = 1619,

    [NativeName("SDL_EVENT_GAMEPAD_REMOVED")]
    GamepadRemoved = 1620,

    [NativeName("SDL_EVENT_GAMEPAD_REMAPPED")]
    GamepadRemapped = 1621,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN")]
    GamepadTouchpadDown = 1622,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION")]
    GamepadTouchpadMotion = 1623,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_UP")]
    GamepadTouchpadUp = 1624,

    [NativeName("SDL_EVENT_GAMEPAD_SENSOR_UPDATE")]
    GamepadSensorUpdate = 1625,

    [NativeName("SDL_EVENT_GAMEPAD_UPDATE_COMPLETE")]
    GamepadUpdateComplete = 1626,

    [NativeName("SDL_EVENT_GAMEPAD_STEAM_HANDLE_UPDATED")]
    GamepadSteamHandleUpdated = 1627,

    [NativeName("SDL_EVENT_FINGER_DOWN")]
    FingerDown = 1792,

    [NativeName("SDL_EVENT_FINGER_UP")]
    FingerUp = 1793,

    [NativeName("SDL_EVENT_FINGER_MOTION")]
    FingerMotion = 1794,

    [NativeName("SDL_EVENT_FINGER_CANCELED")]
    FingerCanceled = 1795,

    [NativeName("SDL_EVENT_CLIPBOARD_UPDATE")]
    ClipboardUpdate = 2304,

    [NativeName("SDL_EVENT_DROP_FILE")]
    DropFile = 4096,

    [NativeName("SDL_EVENT_DROP_TEXT")]
    DropText = 4097,

    [NativeName("SDL_EVENT_DROP_BEGIN")]
    DropBegin = 4098,

    [NativeName("SDL_EVENT_DROP_COMPLETE")]
    DropComplete = 4099,

    [NativeName("SDL_EVENT_DROP_POSITION")]
    DropPosition = 4100,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_ADDED")]
    AudioDeviceAdded = 4352,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_REMOVED")]
    AudioDeviceRemoved = 4353,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_FORMAT_CHANGED")]
    AudioDeviceFormatChanged = 4354,

    [NativeName("SDL_EVENT_SENSOR_UPDATE")]
    SensorUpdate = 4608,

    [NativeName("SDL_EVENT_PEN_PROXIMITY_IN")]
    PenProximityIn = 4864,

    [NativeName("SDL_EVENT_PEN_PROXIMITY_OUT")]
    PenProximityOut = 4865,

    [NativeName("SDL_EVENT_PEN_DOWN")]
    PenDown = 4866,

    [NativeName("SDL_EVENT_PEN_UP")]
    PenUp = 4867,

    [NativeName("SDL_EVENT_PEN_BUTTON_DOWN")]
    PenButtonDown = 4868,

    [NativeName("SDL_EVENT_PEN_BUTTON_UP")]
    PenButtonUp = 4869,

    [NativeName("SDL_EVENT_PEN_MOTION")]
    PenMotion = 4870,

    [NativeName("SDL_EVENT_PEN_AXIS")]
    PenAxis = 4871,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_ADDED")]
    CameraDeviceAdded = 5120,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_REMOVED")]
    CameraDeviceRemoved = 5121,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_APPROVED")]
    CameraDeviceApproved = 5122,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_DENIED")]
    CameraDeviceDenied = 5123,

    [NativeName("SDL_EVENT_RENDER_TARGETS_RESET")]
    RenderTargetsReset = 8192,

    [NativeName("SDL_EVENT_RENDER_DEVICE_RESET")]
    RenderDeviceReset = 8193,

    [NativeName("SDL_EVENT_RENDER_DEVICE_LOST")]
    RenderDeviceLost = 8194,

    [NativeName("SDL_EVENT_PRIVATE0")]
    Private0 = 16384,

    [NativeName("SDL_EVENT_PRIVATE1")]
    Private1 = 16385,

    [NativeName("SDL_EVENT_PRIVATE2")]
    Private2 = 16386,

    [NativeName("SDL_EVENT_PRIVATE3")]
    Private3 = 16387,

    [NativeName("SDL_EVENT_POLL_SENTINEL")]
    PollSentinel = 32512,

    [NativeName("SDL_EVENT_USER")]
    User = 32768,

    [NativeName("SDL_EVENT_LAST")]
    Last = 65535,

    [NativeName("SDL_EVENT_ENUM_PADDING")]
    EnumPadding = 2147483647,
}
