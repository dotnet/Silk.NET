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
    Quit = 0x100,

    [NativeName("SDL_EVENT_TERMINATING")]
    Terminating,

    [NativeName("SDL_EVENT_LOW_MEMORY")]
    LowMemory,

    [NativeName("SDL_EVENT_WILL_ENTER_BACKGROUND")]
    WillEnterBackground,

    [NativeName("SDL_EVENT_DID_ENTER_BACKGROUND")]
    DidEnterBackground,

    [NativeName("SDL_EVENT_WILL_ENTER_FOREGROUND")]
    WillEnterForeground,

    [NativeName("SDL_EVENT_DID_ENTER_FOREGROUND")]
    DidEnterForeground,

    [NativeName("SDL_EVENT_LOCALE_CHANGED")]
    LocaleChanged,

    [NativeName("SDL_EVENT_SYSTEM_THEME_CHANGED")]
    SystemThemeChanged,

    [NativeName("SDL_EVENT_DISPLAY_ORIENTATION")]
    DisplayOrientation = 0x151,

    [NativeName("SDL_EVENT_DISPLAY_ADDED")]
    DisplayAdded,

    [NativeName("SDL_EVENT_DISPLAY_REMOVED")]
    DisplayRemoved,

    [NativeName("SDL_EVENT_DISPLAY_MOVED")]
    DisplayMoved,

    [NativeName("SDL_EVENT_DISPLAY_DESKTOP_MODE_CHANGED")]
    DisplayDesktopModeChanged,

    [NativeName("SDL_EVENT_DISPLAY_CURRENT_MODE_CHANGED")]
    DisplayCurrentModeChanged,

    [NativeName("SDL_EVENT_DISPLAY_CONTENT_SCALE_CHANGED")]
    DisplayContentScaleChanged,

    [NativeName("SDL_EVENT_DISPLAY_FIRST")]
    DisplayFirst = DisplayOrientation,

    [NativeName("SDL_EVENT_DISPLAY_LAST")]
    DisplayLast = DisplayContentScaleChanged,

    [NativeName("SDL_EVENT_WINDOW_SHOWN")]
    WindowShown = 0x202,

    [NativeName("SDL_EVENT_WINDOW_HIDDEN")]
    WindowHidden,

    [NativeName("SDL_EVENT_WINDOW_EXPOSED")]
    WindowExposed,

    [NativeName("SDL_EVENT_WINDOW_MOVED")]
    WindowMoved,

    [NativeName("SDL_EVENT_WINDOW_RESIZED")]
    WindowResized,

    [NativeName("SDL_EVENT_WINDOW_PIXEL_SIZE_CHANGED")]
    WindowPixelSizeChanged,

    [NativeName("SDL_EVENT_WINDOW_METAL_VIEW_RESIZED")]
    WindowMetalViewResized,

    [NativeName("SDL_EVENT_WINDOW_MINIMIZED")]
    WindowMinimized,

    [NativeName("SDL_EVENT_WINDOW_MAXIMIZED")]
    WindowMaximized,

    [NativeName("SDL_EVENT_WINDOW_RESTORED")]
    WindowRestored,

    [NativeName("SDL_EVENT_WINDOW_MOUSE_ENTER")]
    WindowMouseEnter,

    [NativeName("SDL_EVENT_WINDOW_MOUSE_LEAVE")]
    WindowMouseLeave,

    [NativeName("SDL_EVENT_WINDOW_FOCUS_GAINED")]
    WindowFocusGained,

    [NativeName("SDL_EVENT_WINDOW_FOCUS_LOST")]
    WindowFocusLost,

    [NativeName("SDL_EVENT_WINDOW_CLOSE_REQUESTED")]
    WindowCloseRequested,

    [NativeName("SDL_EVENT_WINDOW_HIT_TEST")]
    WindowHitTest,

    [NativeName("SDL_EVENT_WINDOW_ICCPROF_CHANGED")]
    WindowIccprofChanged,

    [NativeName("SDL_EVENT_WINDOW_DISPLAY_CHANGED")]
    WindowDisplayChanged,

    [NativeName("SDL_EVENT_WINDOW_DISPLAY_SCALE_CHANGED")]
    WindowDisplayScaleChanged,

    [NativeName("SDL_EVENT_WINDOW_SAFE_AREA_CHANGED")]
    WindowSafeAreaChanged,

    [NativeName("SDL_EVENT_WINDOW_OCCLUDED")]
    WindowOccluded,

    [NativeName("SDL_EVENT_WINDOW_ENTER_FULLSCREEN")]
    WindowEnterFullscreen,

    [NativeName("SDL_EVENT_WINDOW_LEAVE_FULLSCREEN")]
    WindowLeaveFullscreen,

    [NativeName("SDL_EVENT_WINDOW_DESTROYED")]
    WindowDestroyed,

    [NativeName("SDL_EVENT_WINDOW_HDR_STATE_CHANGED")]
    WindowHdrStateChanged,

    [NativeName("SDL_EVENT_WINDOW_FIRST")]
    WindowFirst = WindowShown,

    [NativeName("SDL_EVENT_WINDOW_LAST")]
    WindowLast = WindowHdrStateChanged,

    [NativeName("SDL_EVENT_KEY_DOWN")]
    KeyDown = 0x300,

    [NativeName("SDL_EVENT_KEY_UP")]
    KeyUp,

    [NativeName("SDL_EVENT_TEXT_EDITING")]
    TextEditing,

    [NativeName("SDL_EVENT_TEXT_INPUT")]
    TextInput,

    [NativeName("SDL_EVENT_KEYMAP_CHANGED")]
    KeymapChanged,

    [NativeName("SDL_EVENT_KEYBOARD_ADDED")]
    KeyboardAdded,

    [NativeName("SDL_EVENT_KEYBOARD_REMOVED")]
    KeyboardRemoved,

    [NativeName("SDL_EVENT_TEXT_EDITING_CANDIDATES")]
    TextEditingCandidates,

    [NativeName("SDL_EVENT_MOUSE_MOTION")]
    MouseMotion = 0x400,

    [NativeName("SDL_EVENT_MOUSE_BUTTON_DOWN")]
    MouseButtonDown,

    [NativeName("SDL_EVENT_MOUSE_BUTTON_UP")]
    MouseButtonUp,

    [NativeName("SDL_EVENT_MOUSE_WHEEL")]
    MouseWheel,

    [NativeName("SDL_EVENT_MOUSE_ADDED")]
    MouseAdded,

    [NativeName("SDL_EVENT_MOUSE_REMOVED")]
    MouseRemoved,

    [NativeName("SDL_EVENT_JOYSTICK_AXIS_MOTION")]
    JoystickAxisMotion = 0x600,

    [NativeName("SDL_EVENT_JOYSTICK_BALL_MOTION")]
    JoystickBallMotion,

    [NativeName("SDL_EVENT_JOYSTICK_HAT_MOTION")]
    JoystickHatMotion,

    [NativeName("SDL_EVENT_JOYSTICK_BUTTON_DOWN")]
    JoystickButtonDown,

    [NativeName("SDL_EVENT_JOYSTICK_BUTTON_UP")]
    JoystickButtonUp,

    [NativeName("SDL_EVENT_JOYSTICK_ADDED")]
    JoystickAdded,

    [NativeName("SDL_EVENT_JOYSTICK_REMOVED")]
    JoystickRemoved,

    [NativeName("SDL_EVENT_JOYSTICK_BATTERY_UPDATED")]
    JoystickBatteryUpdated,

    [NativeName("SDL_EVENT_JOYSTICK_UPDATE_COMPLETE")]
    JoystickUpdateComplete,

    [NativeName("SDL_EVENT_GAMEPAD_AXIS_MOTION")]
    GamepadAxisMotion = 0x650,

    [NativeName("SDL_EVENT_GAMEPAD_BUTTON_DOWN")]
    GamepadButtonDown,

    [NativeName("SDL_EVENT_GAMEPAD_BUTTON_UP")]
    GamepadButtonUp,

    [NativeName("SDL_EVENT_GAMEPAD_ADDED")]
    GamepadAdded,

    [NativeName("SDL_EVENT_GAMEPAD_REMOVED")]
    GamepadRemoved,

    [NativeName("SDL_EVENT_GAMEPAD_REMAPPED")]
    GamepadRemapped,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN")]
    GamepadTouchpadDown,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION")]
    GamepadTouchpadMotion,

    [NativeName("SDL_EVENT_GAMEPAD_TOUCHPAD_UP")]
    GamepadTouchpadUp,

    [NativeName("SDL_EVENT_GAMEPAD_SENSOR_UPDATE")]
    GamepadSensorUpdate,

    [NativeName("SDL_EVENT_GAMEPAD_UPDATE_COMPLETE")]
    GamepadUpdateComplete,

    [NativeName("SDL_EVENT_GAMEPAD_STEAM_HANDLE_UPDATED")]
    GamepadSteamHandleUpdated,

    [NativeName("SDL_EVENT_FINGER_DOWN")]
    FingerDown = 0x700,

    [NativeName("SDL_EVENT_FINGER_UP")]
    FingerUp,

    [NativeName("SDL_EVENT_FINGER_MOTION")]
    FingerMotion,

    [NativeName("SDL_EVENT_FINGER_CANCELED")]
    FingerCanceled,

    [NativeName("SDL_EVENT_CLIPBOARD_UPDATE")]
    ClipboardUpdate = 0x900,

    [NativeName("SDL_EVENT_DROP_FILE")]
    DropFile = 0x1000,

    [NativeName("SDL_EVENT_DROP_TEXT")]
    DropText,

    [NativeName("SDL_EVENT_DROP_BEGIN")]
    DropBegin,

    [NativeName("SDL_EVENT_DROP_COMPLETE")]
    DropComplete,

    [NativeName("SDL_EVENT_DROP_POSITION")]
    DropPosition,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_ADDED")]
    AudioDeviceAdded = 0x1100,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_REMOVED")]
    AudioDeviceRemoved,

    [NativeName("SDL_EVENT_AUDIO_DEVICE_FORMAT_CHANGED")]
    AudioDeviceFormatChanged,

    [NativeName("SDL_EVENT_SENSOR_UPDATE")]
    SensorUpdate = 0x1200,

    [NativeName("SDL_EVENT_PEN_PROXIMITY_IN")]
    PenProximityIn = 0x1300,

    [NativeName("SDL_EVENT_PEN_PROXIMITY_OUT")]
    PenProximityOut,

    [NativeName("SDL_EVENT_PEN_DOWN")]
    PenDown,

    [NativeName("SDL_EVENT_PEN_UP")]
    PenUp,

    [NativeName("SDL_EVENT_PEN_BUTTON_DOWN")]
    PenButtonDown,

    [NativeName("SDL_EVENT_PEN_BUTTON_UP")]
    PenButtonUp,

    [NativeName("SDL_EVENT_PEN_MOTION")]
    PenMotion,

    [NativeName("SDL_EVENT_PEN_AXIS")]
    PenAxis,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_ADDED")]
    CameraDeviceAdded = 0x1400,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_REMOVED")]
    CameraDeviceRemoved,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_APPROVED")]
    CameraDeviceApproved,

    [NativeName("SDL_EVENT_CAMERA_DEVICE_DENIED")]
    CameraDeviceDenied,

    [NativeName("SDL_EVENT_RENDER_TARGETS_RESET")]
    RenderTargetsReset = 0x2000,

    [NativeName("SDL_EVENT_RENDER_DEVICE_RESET")]
    RenderDeviceReset,

    [NativeName("SDL_EVENT_RENDER_DEVICE_LOST")]
    RenderDeviceLost,

    [NativeName("SDL_EVENT_PRIVATE0")]
    Private0 = 0x4000,

    [NativeName("SDL_EVENT_PRIVATE1")]
    Private1,

    [NativeName("SDL_EVENT_PRIVATE2")]
    Private2,

    [NativeName("SDL_EVENT_PRIVATE3")]
    Private3,

    [NativeName("SDL_EVENT_POLL_SENTINEL")]
    PollSentinel = 0x7F00,

    [NativeName("SDL_EVENT_USER")]
    User = 0x8000,

    [NativeName("SDL_EVENT_LAST")]
    Last = 0xFFFF,

    [NativeName("SDL_EVENT_ENUM_PADDING")]
    EnumPadding = 0x7FFFFFFF,
}
