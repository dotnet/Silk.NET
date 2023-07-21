// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidusage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HID
{
    [NativeTypeName("#define HID_USAGE_PAGE_UNDEFINED ((USAGE) 0x00)")]
    public const ushort HID_USAGE_PAGE_UNDEFINED = ((ushort)(0x00));

    [NativeTypeName("#define HID_USAGE_PAGE_GENERIC ((USAGE) 0x01)")]
    public const ushort HID_USAGE_PAGE_GENERIC = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_PAGE_SIMULATION ((USAGE) 0x02)")]
    public const ushort HID_USAGE_PAGE_SIMULATION = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_PAGE_VR ((USAGE) 0x03)")]
    public const ushort HID_USAGE_PAGE_VR = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_PAGE_SPORT ((USAGE) 0x04)")]
    public const ushort HID_USAGE_PAGE_SPORT = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_PAGE_GAME ((USAGE) 0x05)")]
    public const ushort HID_USAGE_PAGE_GAME = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_PAGE_GENERIC_DEVICE ((USAGE) 0x06)")]
    public const ushort HID_USAGE_PAGE_GENERIC_DEVICE = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_PAGE_KEYBOARD ((USAGE) 0x07)")]
    public const ushort HID_USAGE_PAGE_KEYBOARD = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_PAGE_LED ((USAGE) 0x08)")]
    public const ushort HID_USAGE_PAGE_LED = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_PAGE_BUTTON ((USAGE) 0x09)")]
    public const ushort HID_USAGE_PAGE_BUTTON = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_PAGE_ORDINAL ((USAGE) 0x0A)")]
    public const ushort HID_USAGE_PAGE_ORDINAL = ((ushort)(0x0A));

    [NativeTypeName("#define HID_USAGE_PAGE_TELEPHONY ((USAGE) 0x0B)")]
    public const ushort HID_USAGE_PAGE_TELEPHONY = ((ushort)(0x0B));

    [NativeTypeName("#define HID_USAGE_PAGE_CONSUMER ((USAGE) 0x0C)")]
    public const ushort HID_USAGE_PAGE_CONSUMER = ((ushort)(0x0C));

    [NativeTypeName("#define HID_USAGE_PAGE_DIGITIZER ((USAGE) 0x0D)")]
    public const ushort HID_USAGE_PAGE_DIGITIZER = ((ushort)(0x0D));

    [NativeTypeName("#define HID_USAGE_PAGE_HAPTICS ((USAGE) 0x0E)")]
    public const ushort HID_USAGE_PAGE_HAPTICS = ((ushort)(0x0E));

    [NativeTypeName("#define HID_USAGE_PAGE_PID ((USAGE) 0x0F)")]
    public const ushort HID_USAGE_PAGE_PID = ((ushort)(0x0F));

    [NativeTypeName("#define HID_USAGE_PAGE_UNICODE ((USAGE) 0x10)")]
    public const ushort HID_USAGE_PAGE_UNICODE = ((ushort)(0x10));

    [NativeTypeName("#define HID_USAGE_PAGE_ALPHANUMERIC ((USAGE) 0x14)")]
    public const ushort HID_USAGE_PAGE_ALPHANUMERIC = ((ushort)(0x14));

    [NativeTypeName("#define HID_USAGE_PAGE_SENSOR ((USAGE) 0x20)")]
    public const ushort HID_USAGE_PAGE_SENSOR = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_PAGE_LIGHTING_ILLUMINATION ((USAGE) 0x59)")]
    public const ushort HID_USAGE_PAGE_LIGHTING_ILLUMINATION = ((ushort)(0x59));

    [NativeTypeName("#define HID_USAGE_PAGE_BARCODE_SCANNER ((USAGE) 0x8C)")]
    public const ushort HID_USAGE_PAGE_BARCODE_SCANNER = ((ushort)(0x8C));

    [NativeTypeName("#define HID_USAGE_PAGE_WEIGHING_DEVICE ((USAGE) 0x8D)")]
    public const ushort HID_USAGE_PAGE_WEIGHING_DEVICE = ((ushort)(0x8D));

    [NativeTypeName("#define HID_USAGE_PAGE_MAGNETIC_STRIPE_READER ((USAGE) 0x8E)")]
    public const ushort HID_USAGE_PAGE_MAGNETIC_STRIPE_READER = ((ushort)(0x8E));

    [NativeTypeName("#define HID_USAGE_PAGE_CAMERA_CONTROL ((USAGE) 0x90)")]
    public const ushort HID_USAGE_PAGE_CAMERA_CONTROL = ((ushort)(0x90));

    [NativeTypeName("#define HID_USAGE_PAGE_ARCADE ((USAGE) 0x91)")]
    public const ushort HID_USAGE_PAGE_ARCADE = ((ushort)(0x91));

    [NativeTypeName("#define HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE ((USAGE) 0xFFF3)")]
    public const ushort HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE = ((ushort)(0xFFF3));

    [NativeTypeName("#define HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN ((USAGE) 0xFF00)")]
    public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN = ((ushort)(0xFF00));

    [NativeTypeName("#define HID_USAGE_PAGE_VENDOR_DEFINED_END ((USAGE) 0xFFFF)")]
    public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_END = ((ushort)(0xFFFF));

    [NativeTypeName("#define HID_USAGE_GENERIC_POINTER ((USAGE) 0x01)")]
    public const ushort HID_USAGE_GENERIC_POINTER = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_GENERIC_MOUSE ((USAGE) 0x02)")]
    public const ushort HID_USAGE_GENERIC_MOUSE = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_GENERIC_JOYSTICK ((USAGE) 0x04)")]
    public const ushort HID_USAGE_GENERIC_JOYSTICK = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_GENERIC_GAMEPAD ((USAGE) 0x05)")]
    public const ushort HID_USAGE_GENERIC_GAMEPAD = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_GENERIC_KEYBOARD ((USAGE) 0x06)")]
    public const ushort HID_USAGE_GENERIC_KEYBOARD = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_GENERIC_KEYPAD ((USAGE) 0x07)")]
    public const ushort HID_USAGE_GENERIC_KEYPAD = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER ((USAGE) 0x08)")]
    public const ushort HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL ((USAGE) 0x09)")]
    public const ushort HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL ((USAGE) 0x0D)")]
    public const ushort HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL = ((ushort)(0x0D));

    [NativeTypeName("#define HID_USAGE_GENERIC_INTERACTIVE_CONTROL ((USAGE) 0x0E)")]
    public const ushort HID_USAGE_GENERIC_INTERACTIVE_CONTROL = ((ushort)(0x0E));

    [NativeTypeName("#define HID_USAGE_GENERIC_COUNTED_BUFFER ((USAGE) 0x3A)")]
    public const ushort HID_USAGE_GENERIC_COUNTED_BUFFER = ((ushort)(0x3A));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSTEM_CTL ((USAGE) 0x80)")]
    public const ushort HID_USAGE_GENERIC_SYSTEM_CTL = ((ushort)(0x80));

    [NativeTypeName("#define HID_USAGE_GENERIC_X ((USAGE) 0x30)")]
    public const ushort HID_USAGE_GENERIC_X = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_GENERIC_Y ((USAGE) 0x31)")]
    public const ushort HID_USAGE_GENERIC_Y = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_GENERIC_Z ((USAGE) 0x32)")]
    public const ushort HID_USAGE_GENERIC_Z = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_GENERIC_RX ((USAGE) 0x33)")]
    public const ushort HID_USAGE_GENERIC_RX = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_GENERIC_RY ((USAGE) 0x34)")]
    public const ushort HID_USAGE_GENERIC_RY = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_GENERIC_RZ ((USAGE) 0x35)")]
    public const ushort HID_USAGE_GENERIC_RZ = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_GENERIC_SLIDER ((USAGE) 0x36)")]
    public const ushort HID_USAGE_GENERIC_SLIDER = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_GENERIC_DIAL ((USAGE) 0x37)")]
    public const ushort HID_USAGE_GENERIC_DIAL = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_GENERIC_WHEEL ((USAGE) 0x38)")]
    public const ushort HID_USAGE_GENERIC_WHEEL = ((ushort)(0x38));

    [NativeTypeName("#define HID_USAGE_GENERIC_HATSWITCH ((USAGE) 0x39)")]
    public const ushort HID_USAGE_GENERIC_HATSWITCH = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_GENERIC_BYTE_COUNT ((USAGE) 0x3B)")]
    public const ushort HID_USAGE_GENERIC_BYTE_COUNT = ((ushort)(0x3B));

    [NativeTypeName("#define HID_USAGE_GENERIC_MOTION_WAKEUP ((USAGE) 0x3C)")]
    public const ushort HID_USAGE_GENERIC_MOTION_WAKEUP = ((ushort)(0x3C));

    [NativeTypeName("#define HID_USAGE_GENERIC_START ((USAGE) 0x3D)")]
    public const ushort HID_USAGE_GENERIC_START = ((ushort)(0x3D));

    [NativeTypeName("#define HID_USAGE_GENERIC_SELECT ((USAGE) 0x3E)")]
    public const ushort HID_USAGE_GENERIC_SELECT = ((ushort)(0x3E));

    [NativeTypeName("#define HID_USAGE_GENERIC_VX ((USAGE) 0x40)")]
    public const ushort HID_USAGE_GENERIC_VX = ((ushort)(0x40));

    [NativeTypeName("#define HID_USAGE_GENERIC_VY ((USAGE) 0x41)")]
    public const ushort HID_USAGE_GENERIC_VY = ((ushort)(0x41));

    [NativeTypeName("#define HID_USAGE_GENERIC_VZ ((USAGE) 0x42)")]
    public const ushort HID_USAGE_GENERIC_VZ = ((ushort)(0x42));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRX ((USAGE) 0x43)")]
    public const ushort HID_USAGE_GENERIC_VBRX = ((ushort)(0x43));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRY ((USAGE) 0x44)")]
    public const ushort HID_USAGE_GENERIC_VBRY = ((ushort)(0x44));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRZ ((USAGE) 0x45)")]
    public const ushort HID_USAGE_GENERIC_VBRZ = ((ushort)(0x45));

    [NativeTypeName("#define HID_USAGE_GENERIC_VNO ((USAGE) 0x46)")]
    public const ushort HID_USAGE_GENERIC_VNO = ((ushort)(0x46));

    [NativeTypeName("#define HID_USAGE_GENERIC_FEATURE_NOTIFICATION ((USAGE) 0x47)")]
    public const ushort HID_USAGE_GENERIC_FEATURE_NOTIFICATION = ((ushort)(0x47));

    [NativeTypeName("#define HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER ((USAGE) 0x48)")]
    public const ushort HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER = ((ushort)(0x48));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_POWER ((USAGE) 0x81)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_POWER = ((ushort)(0x81));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SLEEP ((USAGE) 0x82)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SLEEP = ((ushort)(0x82));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_WAKE ((USAGE) 0x83)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_WAKE = ((ushort)(0x83));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU ((USAGE) 0x84)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU = ((ushort)(0x84));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MAIN_MENU ((USAGE) 0x85)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MAIN_MENU = ((ushort)(0x85));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_MENU ((USAGE) 0x86)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_MENU = ((ushort)(0x86));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_HELP_MENU ((USAGE) 0x87)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_HELP_MENU = ((ushort)(0x87));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_EXIT ((USAGE) 0x88)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_EXIT = ((ushort)(0x88));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_SELECT ((USAGE) 0x89)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_SELECT = ((ushort)(0x89));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT ((USAGE) 0x8A)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT = ((ushort)(0x8A));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_LEFT ((USAGE) 0x8B)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_LEFT = ((ushort)(0x8B));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_UP ((USAGE) 0x8C)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_UP = ((ushort)(0x8C));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_DOWN ((USAGE) 0x8D)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_DOWN = ((ushort)(0x8D));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_COLD_RESTART ((USAGE) 0x8E)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_COLD_RESTART = ((ushort)(0x8E));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_WARM_RESTART ((USAGE) 0x8F)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_WARM_RESTART = ((ushort)(0x8F));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_UP ((USAGE) 0x90)")]
    public const ushort HID_USAGE_GENERIC_DPAD_UP = ((ushort)(0x90));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_DOWN ((USAGE) 0x91)")]
    public const ushort HID_USAGE_GENERIC_DPAD_DOWN = ((ushort)(0x91));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_RIGHT ((USAGE) 0x92)")]
    public const ushort HID_USAGE_GENERIC_DPAD_RIGHT = ((ushort)(0x92));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_LEFT ((USAGE) 0x93)")]
    public const ushort HID_USAGE_GENERIC_DPAD_LEFT = ((ushort)(0x93));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN ((USAGE) 0x97)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN = ((ushort)(0x97));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN_LOCK ((USAGE) 0x98)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN_LOCK = ((ushort)(0x98));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN_LOCK_INDICATOR ((USAGE) 0x99)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN_LOCK_INDICATOR = ((ushort)(0x99));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION ((USAGE) 0x9A)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION = ((ushort)(0x9A));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DOCK ((USAGE) 0xA0)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DOCK = ((ushort)(0xA0));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_UNDOCK ((USAGE) 0xA1)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_UNDOCK = ((ushort)(0xA1));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SETUP ((USAGE) 0xA2)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SETUP = ((ushort)(0xA2));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SYS_BREAK ((USAGE) 0xA3)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_BREAK = ((ushort)(0xA3));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK ((USAGE) 0xA4)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK = ((ushort)(0xA4));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_BREAK ((USAGE) 0xA5)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_BREAK = ((ushort)(0xA5));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK ((USAGE) 0xA6)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK = ((ushort)(0xA6));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MUTE ((USAGE) 0xA7)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MUTE = ((ushort)(0xA7));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_HIBERNATE ((USAGE) 0xA8)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_HIBERNATE = ((ushort)(0xA8));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_INVERT ((USAGE) 0xB0)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INVERT = ((ushort)(0xB0));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL ((USAGE) 0xB1)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL = ((ushort)(0xB1));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL ((USAGE) 0xB2)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL = ((ushort)(0xB2));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_BOTH ((USAGE) 0xB3)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_BOTH = ((ushort)(0xB3));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_DUAL ((USAGE) 0xB4)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_DUAL = ((ushort)(0xB4));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE ((USAGE) 0xB5)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE = ((ushort)(0xB5));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_SWAP ((USAGE) 0xB6)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_SWAP = ((ushort)(0xB6));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE ((USAGE) 0xB7)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE = ((ushort)(0xB7));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON ((USAGE) 0xC9)")]
    public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON = ((ushort)(0xC9));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH ((USAGE) 0xCA)")]
    public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH = ((ushort)(0xCA));

    [NativeTypeName("#define HID_USAGE_GENERIC_CONTROL_ENABLE ((USAGE) 0xCB)")]
    public const ushort HID_USAGE_GENERIC_CONTROL_ENABLE = ((ushort)(0xCB));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE ((USAGE) 0x01)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE ((USAGE) 0x02)")]
    public const ushort HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE ((USAGE) 0x03)")]
    public const ushort HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE ((USAGE) 0x04)")]
    public const ushort HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE ((USAGE) 0x05)")]
    public const ushort HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE ((USAGE) 0x06)")]
    public const ushort HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE ((USAGE) 0x07)")]
    public const ushort HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE ((USAGE) 0x08)")]
    public const ushort HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE ((USAGE) 0x09)")]
    public const ushort HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE ((USAGE) 0x0A)")]
    public const ushort HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE = ((ushort)(0x0A));

    [NativeTypeName("#define HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE ((USAGE) 0x0B)")]
    public const ushort HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE = ((ushort)(0x0B));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE ((USAGE) 0x0C)")]
    public const ushort HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE = ((ushort)(0x0C));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK ((USAGE) 0x20)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_STICK ((USAGE) 0x21)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_STICK = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CYCLIC_CONTROL ((USAGE) 0x22)")]
    public const ushort HID_USAGE_SIMULATION_CYCLIC_CONTROL = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CYCLIC_TRIM ((USAGE) 0x23)")]
    public const ushort HID_USAGE_SIMULATION_CYCLIC_TRIM = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_YOKE ((USAGE) 0x24)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_YOKE = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TRACK_CONTROL ((USAGE) 0x25)")]
    public const ushort HID_USAGE_SIMULATION_TRACK_CONTROL = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AILERON ((USAGE) 0xB0)")]
    public const ushort HID_USAGE_SIMULATION_AILERON = ((ushort)(0xB0));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AILERON_TRIM ((USAGE) 0xB1)")]
    public const ushort HID_USAGE_SIMULATION_AILERON_TRIM = ((ushort)(0xB1));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL ((USAGE) 0xB2)")]
    public const ushort HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL = ((ushort)(0xB2));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE ((USAGE) 0xB3)")]
    public const ushort HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE = ((ushort)(0xB3));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CHAFF_RELEASE ((USAGE) 0xB4)")]
    public const ushort HID_USAGE_SIMULATION_CHAFF_RELEASE = ((ushort)(0xB4));

    [NativeTypeName("#define HID_USAGE_SIMULATION_COLLECTIVE_CONTROL ((USAGE) 0xB5)")]
    public const ushort HID_USAGE_SIMULATION_COLLECTIVE_CONTROL = ((ushort)(0xB5));

    [NativeTypeName("#define HID_USAGE_SIMULATION_DIVE_BRAKE ((USAGE) 0xB6)")]
    public const ushort HID_USAGE_SIMULATION_DIVE_BRAKE = ((ushort)(0xB6));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES ((USAGE) 0xB7)")]
    public const ushort HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES = ((ushort)(0xB7));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELEVATOR ((USAGE) 0xB8)")]
    public const ushort HID_USAGE_SIMULATION_ELEVATOR = ((ushort)(0xB8));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELEVATOR_TRIM ((USAGE) 0xB9)")]
    public const ushort HID_USAGE_SIMULATION_ELEVATOR_TRIM = ((ushort)(0xB9));

    [NativeTypeName("#define HID_USAGE_SIMULATION_RUDDER ((USAGE) 0xBA)")]
    public const ushort HID_USAGE_SIMULATION_RUDDER = ((ushort)(0xBA));

    [NativeTypeName("#define HID_USAGE_SIMULATION_THROTTLE ((USAGE) 0xBB)")]
    public const ushort HID_USAGE_SIMULATION_THROTTLE = ((ushort)(0xBB));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS ((USAGE) 0xBC)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS = ((ushort)(0xBC));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLARE_RELEASE ((USAGE) 0xBD)")]
    public const ushort HID_USAGE_SIMULATION_FLARE_RELEASE = ((ushort)(0xBD));

    [NativeTypeName("#define HID_USAGE_SIMULATION_LANDING_GEAR ((USAGE) 0xBE)")]
    public const ushort HID_USAGE_SIMULATION_LANDING_GEAR = ((ushort)(0xBE));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TOE_BRAKE ((USAGE) 0xBF)")]
    public const ushort HID_USAGE_SIMULATION_TOE_BRAKE = ((ushort)(0xBF));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TRIGGER ((USAGE) 0xC0)")]
    public const ushort HID_USAGE_SIMULATION_TRIGGER = ((ushort)(0xC0));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WEAPONS_ARM ((USAGE) 0xC1)")]
    public const ushort HID_USAGE_SIMULATION_WEAPONS_ARM = ((ushort)(0xC1));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WEAPONS_SELECT ((USAGE) 0xC2)")]
    public const ushort HID_USAGE_SIMULATION_WEAPONS_SELECT = ((ushort)(0xC2));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WING_FLAPS ((USAGE) 0xC3)")]
    public const ushort HID_USAGE_SIMULATION_WING_FLAPS = ((ushort)(0xC3));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ACCELLERATOR ((USAGE) 0xC4)")]
    public const ushort HID_USAGE_SIMULATION_ACCELLERATOR = ((ushort)(0xC4));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BRAKE ((USAGE) 0xC5)")]
    public const ushort HID_USAGE_SIMULATION_BRAKE = ((ushort)(0xC5));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CLUTCH ((USAGE) 0xC6)")]
    public const ushort HID_USAGE_SIMULATION_CLUTCH = ((ushort)(0xC6));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SHIFTER ((USAGE) 0xC7)")]
    public const ushort HID_USAGE_SIMULATION_SHIFTER = ((ushort)(0xC7));

    [NativeTypeName("#define HID_USAGE_SIMULATION_STEERING ((USAGE) 0xC8)")]
    public const ushort HID_USAGE_SIMULATION_STEERING = ((ushort)(0xC8));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TURRET_DIRECTION ((USAGE) 0xC9)")]
    public const ushort HID_USAGE_SIMULATION_TURRET_DIRECTION = ((ushort)(0xC9));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BARREL_ELEVATION ((USAGE) 0xCA)")]
    public const ushort HID_USAGE_SIMULATION_BARREL_ELEVATION = ((ushort)(0xCA));

    [NativeTypeName("#define HID_USAGE_SIMULATION_DIVE_PLANE ((USAGE) 0xCB)")]
    public const ushort HID_USAGE_SIMULATION_DIVE_PLANE = ((ushort)(0xCB));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BALLAST ((USAGE) 0xCC)")]
    public const ushort HID_USAGE_SIMULATION_BALLAST = ((ushort)(0xCC));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BICYCLE_CRANK ((USAGE) 0xCD)")]
    public const ushort HID_USAGE_SIMULATION_BICYCLE_CRANK = ((ushort)(0xCD));

    [NativeTypeName("#define HID_USAGE_SIMULATION_HANDLE_BARS ((USAGE) 0xCE)")]
    public const ushort HID_USAGE_SIMULATION_HANDLE_BARS = ((ushort)(0xCE));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FRONT_BRAKE ((USAGE) 0xCF)")]
    public const ushort HID_USAGE_SIMULATION_FRONT_BRAKE = ((ushort)(0xCF));

    [NativeTypeName("#define HID_USAGE_SIMULATION_REAR_BRAKE ((USAGE) 0xD0)")]
    public const ushort HID_USAGE_SIMULATION_REAR_BRAKE = ((ushort)(0xD0));

    [NativeTypeName("#define HID_USAGE_VR_BELT ((USAGE) 0x01)")]
    public const ushort HID_USAGE_VR_BELT = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_VR_BODY_SUIT ((USAGE) 0x02)")]
    public const ushort HID_USAGE_VR_BODY_SUIT = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_VR_FLEXOR ((USAGE) 0x03)")]
    public const ushort HID_USAGE_VR_FLEXOR = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_VR_GLOVE ((USAGE) 0x04)")]
    public const ushort HID_USAGE_VR_GLOVE = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_VR_HEAD_TRACKER ((USAGE) 0x05)")]
    public const ushort HID_USAGE_VR_HEAD_TRACKER = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_VR_HEAD_MOUNTED_DISPLAY ((USAGE) 0x06)")]
    public const ushort HID_USAGE_VR_HEAD_MOUNTED_DISPLAY = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_VR_HAND_TRACKER ((USAGE) 0x07)")]
    public const ushort HID_USAGE_VR_HAND_TRACKER = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_VR_OCULOMETER ((USAGE) 0x08)")]
    public const ushort HID_USAGE_VR_OCULOMETER = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_VR_VEST ((USAGE) 0x09)")]
    public const ushort HID_USAGE_VR_VEST = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_VR_ANIMATRONIC_DEVICE ((USAGE) 0x0A)")]
    public const ushort HID_USAGE_VR_ANIMATRONIC_DEVICE = ((ushort)(0x0A));

    [NativeTypeName("#define HID_USAGE_VR_STEREO_ENABLE ((USAGE) 0x20)")]
    public const ushort HID_USAGE_VR_STEREO_ENABLE = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_VR_DISPLAY_ENABLE ((USAGE) 0x21)")]
    public const ushort HID_USAGE_VR_DISPLAY_ENABLE = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_SPORT_BASEBALL_BAT ((USAGE) 0x01)")]
    public const ushort HID_USAGE_SPORT_BASEBALL_BAT = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_SPORT_GOLF_CLUB ((USAGE) 0x02)")]
    public const ushort HID_USAGE_SPORT_GOLF_CLUB = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_SPORT_ROWING_MACHINE ((USAGE) 0x03)")]
    public const ushort HID_USAGE_SPORT_ROWING_MACHINE = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_SPORT_TREADMILL ((USAGE) 0x04)")]
    public const ushort HID_USAGE_SPORT_TREADMILL = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_TYPE ((USAGE) 0x38)")]
    public const ushort HID_USAGE_SPORT_STICK_TYPE = ((ushort)(0x38));

    [NativeTypeName("#define HID_USAGE_SPORT_OAR ((USAGE) 0x30)")]
    public const ushort HID_USAGE_SPORT_OAR = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_SPORT_SLOPE ((USAGE) 0x31)")]
    public const ushort HID_USAGE_SPORT_SLOPE = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_SPORT_RATE ((USAGE) 0x32)")]
    public const ushort HID_USAGE_SPORT_RATE = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_SPEED ((USAGE) 0x33)")]
    public const ushort HID_USAGE_SPORT_STICK_SPEED = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_FACE_ANGLE ((USAGE) 0x34)")]
    public const ushort HID_USAGE_SPORT_STICK_FACE_ANGLE = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_SPORT_HEEL_TOE ((USAGE) 0x35)")]
    public const ushort HID_USAGE_SPORT_HEEL_TOE = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_SPORT_FOLLOW_THROUGH ((USAGE) 0x36)")]
    public const ushort HID_USAGE_SPORT_FOLLOW_THROUGH = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_SPORT_TEMPO ((USAGE) 0x37)")]
    public const ushort HID_USAGE_SPORT_TEMPO = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_SPORT_HEIGHT ((USAGE) 0x39)")]
    public const ushort HID_USAGE_SPORT_HEIGHT = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_SPORT_PUTTER ((USAGE) 0x50)")]
    public const ushort HID_USAGE_SPORT_PUTTER = ((ushort)(0x50));

    [NativeTypeName("#define HID_USAGE_SPORT_1_IRON ((USAGE) 0x51)")]
    public const ushort HID_USAGE_SPORT_1_IRON = ((ushort)(0x51));

    [NativeTypeName("#define HID_USAGE_SPORT_2_IRON ((USAGE) 0x52)")]
    public const ushort HID_USAGE_SPORT_2_IRON = ((ushort)(0x52));

    [NativeTypeName("#define HID_USAGE_SPORT_3_IRON ((USAGE) 0x53)")]
    public const ushort HID_USAGE_SPORT_3_IRON = ((ushort)(0x53));

    [NativeTypeName("#define HID_USAGE_SPORT_4_IRON ((USAGE) 0x54)")]
    public const ushort HID_USAGE_SPORT_4_IRON = ((ushort)(0x54));

    [NativeTypeName("#define HID_USAGE_SPORT_5_IRON ((USAGE) 0x55)")]
    public const ushort HID_USAGE_SPORT_5_IRON = ((ushort)(0x55));

    [NativeTypeName("#define HID_USAGE_SPORT_6_IRON ((USAGE) 0x56)")]
    public const ushort HID_USAGE_SPORT_6_IRON = ((ushort)(0x56));

    [NativeTypeName("#define HID_USAGE_SPORT_7_IRON ((USAGE) 0x57)")]
    public const ushort HID_USAGE_SPORT_7_IRON = ((ushort)(0x57));

    [NativeTypeName("#define HID_USAGE_SPORT_8_IRON ((USAGE) 0x58)")]
    public const ushort HID_USAGE_SPORT_8_IRON = ((ushort)(0x58));

    [NativeTypeName("#define HID_USAGE_SPORT_9_IRON ((USAGE) 0x59)")]
    public const ushort HID_USAGE_SPORT_9_IRON = ((ushort)(0x59));

    [NativeTypeName("#define HID_USAGE_SPORT_10_IRON ((USAGE) 0x5A)")]
    public const ushort HID_USAGE_SPORT_10_IRON = ((ushort)(0x5A));

    [NativeTypeName("#define HID_USAGE_SPORT_11_IRON ((USAGE) 0x5B)")]
    public const ushort HID_USAGE_SPORT_11_IRON = ((ushort)(0x5B));

    [NativeTypeName("#define HID_USAGE_SPORT_SAND_WEDGE ((USAGE) 0x5C)")]
    public const ushort HID_USAGE_SPORT_SAND_WEDGE = ((ushort)(0x5C));

    [NativeTypeName("#define HID_USAGE_SPORT_LOFT_WEDGE ((USAGE) 0x5D)")]
    public const ushort HID_USAGE_SPORT_LOFT_WEDGE = ((ushort)(0x5D));

    [NativeTypeName("#define HID_USAGE_SPORT_POWER_WEDGE ((USAGE) 0x5E)")]
    public const ushort HID_USAGE_SPORT_POWER_WEDGE = ((ushort)(0x5E));

    [NativeTypeName("#define HID_USAGE_SPORT_1_WOOD ((USAGE) 0x5F)")]
    public const ushort HID_USAGE_SPORT_1_WOOD = ((ushort)(0x5F));

    [NativeTypeName("#define HID_USAGE_SPORT_3_WOOD ((USAGE) 0x60)")]
    public const ushort HID_USAGE_SPORT_3_WOOD = ((ushort)(0x60));

    [NativeTypeName("#define HID_USAGE_SPORT_5_WOOD ((USAGE) 0x61)")]
    public const ushort HID_USAGE_SPORT_5_WOOD = ((ushort)(0x61));

    [NativeTypeName("#define HID_USAGE_SPORT_7_WOOD ((USAGE) 0x62)")]
    public const ushort HID_USAGE_SPORT_7_WOOD = ((ushort)(0x62));

    [NativeTypeName("#define HID_USAGE_SPORT_9_WOOD ((USAGE) 0x63)")]
    public const ushort HID_USAGE_SPORT_9_WOOD = ((ushort)(0x63));

    [NativeTypeName("#define HID_USAGE_GAME_3D_GAME_CONTROLLER ((USAGE) 0x01)")]
    public const ushort HID_USAGE_GAME_3D_GAME_CONTROLLER = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_GAME_PINBALL_DEVICE ((USAGE) 0x02)")]
    public const ushort HID_USAGE_GAME_PINBALL_DEVICE = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_DEVICE ((USAGE) 0x03)")]
    public const ushort HID_USAGE_GAME_GUN_DEVICE = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_GAME_POINT_OF_VIEW ((USAGE) 0x20)")]
    public const ushort HID_USAGE_GAME_POINT_OF_VIEW = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SELECTOR ((USAGE) 0x32)")]
    public const ushort HID_USAGE_GAME_GUN_SELECTOR = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_GAME_GAMEPAD_FIRE_JUMP ((USAGE) 0x37)")]
    public const ushort HID_USAGE_GAME_GAMEPAD_FIRE_JUMP = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_GAME_GAMEPAD_TRIGGER ((USAGE) 0x39)")]
    public const ushort HID_USAGE_GAME_GAMEPAD_TRIGGER = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_GAME_TURN_RIGHT_LEFT ((USAGE) 0x21)")]
    public const ushort HID_USAGE_GAME_TURN_RIGHT_LEFT = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_GAME_PITCH_FORWARD_BACK ((USAGE) 0x22)")]
    public const ushort HID_USAGE_GAME_PITCH_FORWARD_BACK = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_GAME_ROLL_RIGHT_LEFT ((USAGE) 0x23)")]
    public const ushort HID_USAGE_GAME_ROLL_RIGHT_LEFT = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_RIGHT_LEFT ((USAGE) 0x24)")]
    public const ushort HID_USAGE_GAME_MOVE_RIGHT_LEFT = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_FORWARD_BACK ((USAGE) 0x25)")]
    public const ushort HID_USAGE_GAME_MOVE_FORWARD_BACK = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_UP_DOWN ((USAGE) 0x26)")]
    public const ushort HID_USAGE_GAME_MOVE_UP_DOWN = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_GAME_LEAN_RIGHT_LEFT ((USAGE) 0x27)")]
    public const ushort HID_USAGE_GAME_LEAN_RIGHT_LEFT = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_GAME_LEAN_FORWARD_BACK ((USAGE) 0x28)")]
    public const ushort HID_USAGE_GAME_LEAN_FORWARD_BACK = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_GAME_POV_HEIGHT ((USAGE) 0x29)")]
    public const ushort HID_USAGE_GAME_POV_HEIGHT = ((ushort)(0x29));

    [NativeTypeName("#define HID_USAGE_GAME_FLIPPER ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_GAME_FLIPPER = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_GAME_SECONDARY_FLIPPER ((USAGE) 0x2B)")]
    public const ushort HID_USAGE_GAME_SECONDARY_FLIPPER = ((ushort)(0x2B));

    [NativeTypeName("#define HID_USAGE_GAME_BUMP ((USAGE) 0x2C)")]
    public const ushort HID_USAGE_GAME_BUMP = ((ushort)(0x2C));

    [NativeTypeName("#define HID_USAGE_GAME_NEW_GAME ((USAGE) 0x2D)")]
    public const ushort HID_USAGE_GAME_NEW_GAME = ((ushort)(0x2D));

    [NativeTypeName("#define HID_USAGE_GAME_SHOOT_BALL ((USAGE) 0x2E)")]
    public const ushort HID_USAGE_GAME_SHOOT_BALL = ((ushort)(0x2E));

    [NativeTypeName("#define HID_USAGE_GAME_PLAYER ((USAGE) 0x2F)")]
    public const ushort HID_USAGE_GAME_PLAYER = ((ushort)(0x2F));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_BOLT ((USAGE) 0x30)")]
    public const ushort HID_USAGE_GAME_GUN_BOLT = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_CLIP ((USAGE) 0x31)")]
    public const ushort HID_USAGE_GAME_GUN_CLIP = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SINGLE_SHOT ((USAGE) 0x33)")]
    public const ushort HID_USAGE_GAME_GUN_SINGLE_SHOT = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_BURST ((USAGE) 0x34)")]
    public const ushort HID_USAGE_GAME_GUN_BURST = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_AUTOMATIC ((USAGE) 0x35)")]
    public const ushort HID_USAGE_GAME_GUN_AUTOMATIC = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SAFETY ((USAGE) 0x36)")]
    public const ushort HID_USAGE_GAME_GUN_SAFETY = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH ((USAGE) 0x20)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL ((USAGE) 0x21)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_WIRELESS_ID ((USAGE) 0x22)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_ID = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL ((USAGE) 0x23)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED ((USAGE) 0x24)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED ((USAGE) 0x25)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED ((USAGE) 0x26)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NOEVENT ((USAGE) 0x00)")]
    public const ushort HID_USAGE_KEYBOARD_NOEVENT = ((ushort)(0x00));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ROLLOVER ((USAGE) 0x01)")]
    public const ushort HID_USAGE_KEYBOARD_ROLLOVER = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_POSTFAIL ((USAGE) 0x02)")]
    public const ushort HID_USAGE_KEYBOARD_POSTFAIL = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_UNDEFINED ((USAGE) 0x03)")]
    public const ushort HID_USAGE_KEYBOARD_UNDEFINED = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_aA ((USAGE) 0x04)")]
    public const ushort HID_USAGE_KEYBOARD_aA = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_zZ ((USAGE) 0x1D)")]
    public const ushort HID_USAGE_KEYBOARD_zZ = ((ushort)(0x1D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ONE ((USAGE) 0x1E)")]
    public const ushort HID_USAGE_KEYBOARD_ONE = ((ushort)(0x1E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ZERO ((USAGE) 0x27)")]
    public const ushort HID_USAGE_KEYBOARD_ZERO = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LCTRL ((USAGE) 0xE0)")]
    public const ushort HID_USAGE_KEYBOARD_LCTRL = ((ushort)(0xE0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LSHFT ((USAGE) 0xE1)")]
    public const ushort HID_USAGE_KEYBOARD_LSHFT = ((ushort)(0xE1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LALT ((USAGE) 0xE2)")]
    public const ushort HID_USAGE_KEYBOARD_LALT = ((ushort)(0xE2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LGUI ((USAGE) 0xE3)")]
    public const ushort HID_USAGE_KEYBOARD_LGUI = ((ushort)(0xE3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RCTRL ((USAGE) 0xE4)")]
    public const ushort HID_USAGE_KEYBOARD_RCTRL = ((ushort)(0xE4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RSHFT ((USAGE) 0xE5)")]
    public const ushort HID_USAGE_KEYBOARD_RSHFT = ((ushort)(0xE5));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RALT ((USAGE) 0xE6)")]
    public const ushort HID_USAGE_KEYBOARD_RALT = ((ushort)(0xE6));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RGUI ((USAGE) 0xE7)")]
    public const ushort HID_USAGE_KEYBOARD_RGUI = ((ushort)(0xE7));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SCROLL_LOCK ((USAGE) 0x47)")]
    public const ushort HID_USAGE_KEYBOARD_SCROLL_LOCK = ((ushort)(0x47));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NUM_LOCK ((USAGE) 0x53)")]
    public const ushort HID_USAGE_KEYBOARD_NUM_LOCK = ((ushort)(0x53));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CAPS_LOCK ((USAGE) 0x39)")]
    public const ushort HID_USAGE_KEYBOARD_CAPS_LOCK = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F1 ((USAGE) 0x3A)")]
    public const ushort HID_USAGE_KEYBOARD_F1 = ((ushort)(0x3A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F2 ((USAGE) 0x3B)")]
    public const ushort HID_USAGE_KEYBOARD_F2 = ((ushort)(0x3B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F3 ((USAGE) 0x3C)")]
    public const ushort HID_USAGE_KEYBOARD_F3 = ((ushort)(0x3C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F4 ((USAGE) 0x3D)")]
    public const ushort HID_USAGE_KEYBOARD_F4 = ((ushort)(0x3D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F5 ((USAGE) 0x3E)")]
    public const ushort HID_USAGE_KEYBOARD_F5 = ((ushort)(0x3E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F6 ((USAGE) 0x3F)")]
    public const ushort HID_USAGE_KEYBOARD_F6 = ((ushort)(0x3F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F7 ((USAGE) 0x40)")]
    public const ushort HID_USAGE_KEYBOARD_F7 = ((ushort)(0x40));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F8 ((USAGE) 0x41)")]
    public const ushort HID_USAGE_KEYBOARD_F8 = ((ushort)(0x41));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F9 ((USAGE) 0x42)")]
    public const ushort HID_USAGE_KEYBOARD_F9 = ((ushort)(0x42));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F10 ((USAGE) 0x43)")]
    public const ushort HID_USAGE_KEYBOARD_F10 = ((ushort)(0x43));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F11 ((USAGE) 0x44)")]
    public const ushort HID_USAGE_KEYBOARD_F11 = ((ushort)(0x44));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F12 ((USAGE) 0x45)")]
    public const ushort HID_USAGE_KEYBOARD_F12 = ((ushort)(0x45));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F13 ((USAGE) 0x68)")]
    public const ushort HID_USAGE_KEYBOARD_F13 = ((ushort)(0x68));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F14 ((USAGE) 0x69)")]
    public const ushort HID_USAGE_KEYBOARD_F14 = ((ushort)(0x69));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F15 ((USAGE) 0x6A)")]
    public const ushort HID_USAGE_KEYBOARD_F15 = ((ushort)(0x6A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F16 ((USAGE) 0x6B)")]
    public const ushort HID_USAGE_KEYBOARD_F16 = ((ushort)(0x6B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F17 ((USAGE) 0x6C)")]
    public const ushort HID_USAGE_KEYBOARD_F17 = ((ushort)(0x6C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F18 ((USAGE) 0x6D)")]
    public const ushort HID_USAGE_KEYBOARD_F18 = ((ushort)(0x6D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F19 ((USAGE) 0x6E)")]
    public const ushort HID_USAGE_KEYBOARD_F19 = ((ushort)(0x6E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F20 ((USAGE) 0x6F)")]
    public const ushort HID_USAGE_KEYBOARD_F20 = ((ushort)(0x6F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F21 ((USAGE) 0x70)")]
    public const ushort HID_USAGE_KEYBOARD_F21 = ((ushort)(0x70));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F22 ((USAGE) 0x71)")]
    public const ushort HID_USAGE_KEYBOARD_F22 = ((ushort)(0x71));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F23 ((USAGE) 0x72)")]
    public const ushort HID_USAGE_KEYBOARD_F23 = ((ushort)(0x72));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F24 ((USAGE) 0x73)")]
    public const ushort HID_USAGE_KEYBOARD_F24 = ((ushort)(0x73));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RETURN ((USAGE) 0x28)")]
    public const ushort HID_USAGE_KEYBOARD_RETURN = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ESCAPE ((USAGE) 0x29)")]
    public const ushort HID_USAGE_KEYBOARD_ESCAPE = ((ushort)(0x29));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DELETE ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_KEYBOARD_DELETE = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PRINT_SCREEN ((USAGE) 0x46)")]
    public const ushort HID_USAGE_KEYBOARD_PRINT_SCREEN = ((ushort)(0x46));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DELETE_FORWARD ((USAGE) 0x4C)")]
    public const ushort HID_USAGE_KEYBOARD_DELETE_FORWARD = ((ushort)(0x4C));

    [NativeTypeName("#define HID_USAGE_LED_NUM_LOCK ((USAGE) 0x01)")]
    public const ushort HID_USAGE_LED_NUM_LOCK = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_LED_CAPS_LOCK ((USAGE) 0x02)")]
    public const ushort HID_USAGE_LED_CAPS_LOCK = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_LED_SCROLL_LOCK ((USAGE) 0x03)")]
    public const ushort HID_USAGE_LED_SCROLL_LOCK = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_LED_COMPOSE ((USAGE) 0x04)")]
    public const ushort HID_USAGE_LED_COMPOSE = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_LED_KANA ((USAGE) 0x05)")]
    public const ushort HID_USAGE_LED_KANA = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_LED_POWER ((USAGE) 0x06)")]
    public const ushort HID_USAGE_LED_POWER = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_LED_SHIFT ((USAGE) 0x07)")]
    public const ushort HID_USAGE_LED_SHIFT = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_LED_DO_NOT_DISTURB ((USAGE) 0x08)")]
    public const ushort HID_USAGE_LED_DO_NOT_DISTURB = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_LED_MUTE ((USAGE) 0x09)")]
    public const ushort HID_USAGE_LED_MUTE = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_LED_TONE_ENABLE ((USAGE) 0x0A)")]
    public const ushort HID_USAGE_LED_TONE_ENABLE = ((ushort)(0x0A));

    [NativeTypeName("#define HID_USAGE_LED_HIGH_CUT_FILTER ((USAGE) 0x0B)")]
    public const ushort HID_USAGE_LED_HIGH_CUT_FILTER = ((ushort)(0x0B));

    [NativeTypeName("#define HID_USAGE_LED_LOW_CUT_FILTER ((USAGE) 0x0C)")]
    public const ushort HID_USAGE_LED_LOW_CUT_FILTER = ((ushort)(0x0C));

    [NativeTypeName("#define HID_USAGE_LED_EQUALIZER_ENABLE ((USAGE) 0x0D)")]
    public const ushort HID_USAGE_LED_EQUALIZER_ENABLE = ((ushort)(0x0D));

    [NativeTypeName("#define HID_USAGE_LED_SOUND_FIELD_ON ((USAGE) 0x0E)")]
    public const ushort HID_USAGE_LED_SOUND_FIELD_ON = ((ushort)(0x0E));

    [NativeTypeName("#define HID_USAGE_LED_SURROUND_FIELD_ON ((USAGE) 0x0F)")]
    public const ushort HID_USAGE_LED_SURROUND_FIELD_ON = ((ushort)(0x0F));

    [NativeTypeName("#define HID_USAGE_LED_REPEAT ((USAGE) 0x10)")]
    public const ushort HID_USAGE_LED_REPEAT = ((ushort)(0x10));

    [NativeTypeName("#define HID_USAGE_LED_STEREO ((USAGE) 0x11)")]
    public const ushort HID_USAGE_LED_STEREO = ((ushort)(0x11));

    [NativeTypeName("#define HID_USAGE_LED_SAMPLING_RATE_DETECT ((USAGE) 0x12)")]
    public const ushort HID_USAGE_LED_SAMPLING_RATE_DETECT = ((ushort)(0x12));

    [NativeTypeName("#define HID_USAGE_LED_SPINNING ((USAGE) 0x13)")]
    public const ushort HID_USAGE_LED_SPINNING = ((ushort)(0x13));

    [NativeTypeName("#define HID_USAGE_LED_CAV ((USAGE) 0x14)")]
    public const ushort HID_USAGE_LED_CAV = ((ushort)(0x14));

    [NativeTypeName("#define HID_USAGE_LED_CLV ((USAGE) 0x15)")]
    public const ushort HID_USAGE_LED_CLV = ((ushort)(0x15));

    [NativeTypeName("#define HID_USAGE_LED_RECORDING_FORMAT_DET ((USAGE) 0x16)")]
    public const ushort HID_USAGE_LED_RECORDING_FORMAT_DET = ((ushort)(0x16));

    [NativeTypeName("#define HID_USAGE_LED_OFF_HOOK ((USAGE) 0x17)")]
    public const ushort HID_USAGE_LED_OFF_HOOK = ((ushort)(0x17));

    [NativeTypeName("#define HID_USAGE_LED_RING ((USAGE) 0x18)")]
    public const ushort HID_USAGE_LED_RING = ((ushort)(0x18));

    [NativeTypeName("#define HID_USAGE_LED_MESSAGE_WAITING ((USAGE) 0x19)")]
    public const ushort HID_USAGE_LED_MESSAGE_WAITING = ((ushort)(0x19));

    [NativeTypeName("#define HID_USAGE_LED_DATA_MODE ((USAGE) 0x1A)")]
    public const ushort HID_USAGE_LED_DATA_MODE = ((ushort)(0x1A));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_OPERATION ((USAGE) 0x1B)")]
    public const ushort HID_USAGE_LED_BATTERY_OPERATION = ((ushort)(0x1B));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_OK ((USAGE) 0x1C)")]
    public const ushort HID_USAGE_LED_BATTERY_OK = ((ushort)(0x1C));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_LOW ((USAGE) 0x1D)")]
    public const ushort HID_USAGE_LED_BATTERY_LOW = ((ushort)(0x1D));

    [NativeTypeName("#define HID_USAGE_LED_SPEAKER ((USAGE) 0x1E)")]
    public const ushort HID_USAGE_LED_SPEAKER = ((ushort)(0x1E));

    [NativeTypeName("#define HID_USAGE_LED_HEAD_SET ((USAGE) 0x1F)")]
    public const ushort HID_USAGE_LED_HEAD_SET = ((ushort)(0x1F));

    [NativeTypeName("#define HID_USAGE_LED_HOLD ((USAGE) 0x20)")]
    public const ushort HID_USAGE_LED_HOLD = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_LED_MICROPHONE ((USAGE) 0x21)")]
    public const ushort HID_USAGE_LED_MICROPHONE = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_LED_COVERAGE ((USAGE) 0x22)")]
    public const ushort HID_USAGE_LED_COVERAGE = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_LED_NIGHT_MODE ((USAGE) 0x23)")]
    public const ushort HID_USAGE_LED_NIGHT_MODE = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_LED_SEND_CALLS ((USAGE) 0x24)")]
    public const ushort HID_USAGE_LED_SEND_CALLS = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_LED_CALL_PICKUP ((USAGE) 0x25)")]
    public const ushort HID_USAGE_LED_CALL_PICKUP = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_LED_CONFERENCE ((USAGE) 0x26)")]
    public const ushort HID_USAGE_LED_CONFERENCE = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_LED_STAND_BY ((USAGE) 0x27)")]
    public const ushort HID_USAGE_LED_STAND_BY = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_LED_CAMERA_ON ((USAGE) 0x28)")]
    public const ushort HID_USAGE_LED_CAMERA_ON = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_LED_CAMERA_OFF ((USAGE) 0x29)")]
    public const ushort HID_USAGE_LED_CAMERA_OFF = ((ushort)(0x29));

    [NativeTypeName("#define HID_USAGE_LED_ON_LINE ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_LED_ON_LINE = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_LED_OFF_LINE ((USAGE) 0x2B)")]
    public const ushort HID_USAGE_LED_OFF_LINE = ((ushort)(0x2B));

    [NativeTypeName("#define HID_USAGE_LED_BUSY ((USAGE) 0x2C)")]
    public const ushort HID_USAGE_LED_BUSY = ((ushort)(0x2C));

    [NativeTypeName("#define HID_USAGE_LED_READY ((USAGE) 0x2D)")]
    public const ushort HID_USAGE_LED_READY = ((ushort)(0x2D));

    [NativeTypeName("#define HID_USAGE_LED_PAPER_OUT ((USAGE) 0x2E)")]
    public const ushort HID_USAGE_LED_PAPER_OUT = ((ushort)(0x2E));

    [NativeTypeName("#define HID_USAGE_LED_PAPER_JAM ((USAGE) 0x2F)")]
    public const ushort HID_USAGE_LED_PAPER_JAM = ((ushort)(0x2F));

    [NativeTypeName("#define HID_USAGE_LED_REMOTE ((USAGE) 0x30)")]
    public const ushort HID_USAGE_LED_REMOTE = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_LED_FORWARD ((USAGE) 0x31)")]
    public const ushort HID_USAGE_LED_FORWARD = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_LED_REVERSE ((USAGE) 0x32)")]
    public const ushort HID_USAGE_LED_REVERSE = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_LED_STOP ((USAGE) 0x33)")]
    public const ushort HID_USAGE_LED_STOP = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_LED_REWIND ((USAGE) 0x34)")]
    public const ushort HID_USAGE_LED_REWIND = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_LED_FAST_FORWARD ((USAGE) 0x35)")]
    public const ushort HID_USAGE_LED_FAST_FORWARD = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_LED_PLAY ((USAGE) 0x36)")]
    public const ushort HID_USAGE_LED_PLAY = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_LED_PAUSE ((USAGE) 0x37)")]
    public const ushort HID_USAGE_LED_PAUSE = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_LED_RECORD ((USAGE) 0x38)")]
    public const ushort HID_USAGE_LED_RECORD = ((ushort)(0x38));

    [NativeTypeName("#define HID_USAGE_LED_ERROR ((USAGE) 0x39)")]
    public const ushort HID_USAGE_LED_ERROR = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_LED_SELECTED_INDICATOR ((USAGE) 0x3A)")]
    public const ushort HID_USAGE_LED_SELECTED_INDICATOR = ((ushort)(0x3A));

    [NativeTypeName("#define HID_USAGE_LED_IN_USE_INDICATOR ((USAGE) 0x3B)")]
    public const ushort HID_USAGE_LED_IN_USE_INDICATOR = ((ushort)(0x3B));

    [NativeTypeName("#define HID_USAGE_LED_MULTI_MODE_INDICATOR ((USAGE) 0x3C)")]
    public const ushort HID_USAGE_LED_MULTI_MODE_INDICATOR = ((ushort)(0x3C));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_ON ((USAGE) 0x3D)")]
    public const ushort HID_USAGE_LED_INDICATOR_ON = ((ushort)(0x3D));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_FLASH ((USAGE) 0x3E)")]
    public const ushort HID_USAGE_LED_INDICATOR_FLASH = ((ushort)(0x3E));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_SLOW_BLINK ((USAGE) 0x3F)")]
    public const ushort HID_USAGE_LED_INDICATOR_SLOW_BLINK = ((ushort)(0x3F));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_FAST_BLINK ((USAGE) 0x40)")]
    public const ushort HID_USAGE_LED_INDICATOR_FAST_BLINK = ((ushort)(0x40));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_OFF ((USAGE) 0x41)")]
    public const ushort HID_USAGE_LED_INDICATOR_OFF = ((ushort)(0x41));

    [NativeTypeName("#define HID_USAGE_LED_FLASH_ON_TIME ((USAGE) 0x42)")]
    public const ushort HID_USAGE_LED_FLASH_ON_TIME = ((ushort)(0x42));

    [NativeTypeName("#define HID_USAGE_LED_SLOW_BLINK_ON_TIME ((USAGE) 0x43)")]
    public const ushort HID_USAGE_LED_SLOW_BLINK_ON_TIME = ((ushort)(0x43));

    [NativeTypeName("#define HID_USAGE_LED_SLOW_BLINK_OFF_TIME ((USAGE) 0x44)")]
    public const ushort HID_USAGE_LED_SLOW_BLINK_OFF_TIME = ((ushort)(0x44));

    [NativeTypeName("#define HID_USAGE_LED_FAST_BLINK_ON_TIME ((USAGE) 0x45)")]
    public const ushort HID_USAGE_LED_FAST_BLINK_ON_TIME = ((ushort)(0x45));

    [NativeTypeName("#define HID_USAGE_LED_FAST_BLINK_OFF_TIME ((USAGE) 0x46)")]
    public const ushort HID_USAGE_LED_FAST_BLINK_OFF_TIME = ((ushort)(0x46));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_COLOR ((USAGE) 0x47)")]
    public const ushort HID_USAGE_LED_INDICATOR_COLOR = ((ushort)(0x47));

    [NativeTypeName("#define HID_USAGE_LED_RED ((USAGE) 0x48)")]
    public const ushort HID_USAGE_LED_RED = ((ushort)(0x48));

    [NativeTypeName("#define HID_USAGE_LED_GREEN ((USAGE) 0x49)")]
    public const ushort HID_USAGE_LED_GREEN = ((ushort)(0x49));

    [NativeTypeName("#define HID_USAGE_LED_AMBER ((USAGE) 0x4A)")]
    public const ushort HID_USAGE_LED_AMBER = ((ushort)(0x4A));

    [NativeTypeName("#define HID_USAGE_LED_GENERIC_INDICATOR ((USAGE) 0x4B)")]
    public const ushort HID_USAGE_LED_GENERIC_INDICATOR = ((ushort)(0x4B));

    [NativeTypeName("#define HID_USAGE_LED_SYSTEM_SUSPEND ((USAGE) 0x4C)")]
    public const ushort HID_USAGE_LED_SYSTEM_SUSPEND = ((ushort)(0x4C));

    [NativeTypeName("#define HID_USAGE_LED_EXTERNAL_POWER ((USAGE) 0x4D)")]
    public const ushort HID_USAGE_LED_EXTERNAL_POWER = ((ushort)(0x4D));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE ((USAGE) 0x01)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ANSWERING_MACHINE ((USAGE) 0x02)")]
    public const ushort HID_USAGE_TELEPHONY_ANSWERING_MACHINE = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_MESSAGE_CONTROLS ((USAGE) 0x03)")]
    public const ushort HID_USAGE_TELEPHONY_MESSAGE_CONTROLS = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HANDSET ((USAGE) 0x04)")]
    public const ushort HID_USAGE_TELEPHONY_HANDSET = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HEADSET ((USAGE) 0x05)")]
    public const ushort HID_USAGE_TELEPHONY_HEADSET = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_KEYPAD ((USAGE) 0x06)")]
    public const ushort HID_USAGE_TELEPHONY_KEYPAD = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON ((USAGE) 0x07)")]
    public const ushort HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_REDIAL ((USAGE) 0x24)")]
    public const ushort HID_USAGE_TELEPHONY_REDIAL = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_TRANSFER ((USAGE) 0x25)")]
    public const ushort HID_USAGE_TELEPHONY_TRANSFER = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_DROP ((USAGE) 0x26)")]
    public const ushort HID_USAGE_TELEPHONY_DROP = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_LINE ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_TELEPHONY_LINE = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RING_ENABLE ((USAGE) 0x2D)")]
    public const ushort HID_USAGE_TELEPHONY_RING_ENABLE = ((ushort)(0x2D));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SEND ((USAGE) 0x31)")]
    public const ushort HID_USAGE_TELEPHONY_SEND = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_KEYPAD_0 ((USAGE) 0xB0)")]
    public const ushort HID_USAGE_TELEPHONY_KEYPAD_0 = ((ushort)(0xB0));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_KEYPAD_D ((USAGE) 0xBF)")]
    public const ushort HID_USAGE_TELEPHONY_KEYPAD_D = ((ushort)(0xBF));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_AVAILABLE ((USAGE) 0xF1)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_AVAILABLE = ((ushort)(0xF1));

    [NativeTypeName("#define HID_USAGE_CONSUMERCTRL ((USAGE) 0x01)")]
    public const ushort HID_USAGE_CONSUMERCTRL = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_INCREMENT ((USAGE) 0x9C)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_INCREMENT = ((ushort)(0x9C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_DECREMENT ((USAGE) 0x9D)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_DECREMENT = ((ushort)(0x9D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAY ((USAGE) 0xB0)")]
    public const ushort HID_USAGE_CONSUMER_PLAY = ((ushort)(0xB0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PAUSE ((USAGE) 0xB1)")]
    public const ushort HID_USAGE_CONSUMER_PAUSE = ((ushort)(0xB1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RECORD ((USAGE) 0xB2)")]
    public const ushort HID_USAGE_CONSUMER_RECORD = ((ushort)(0xB2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FAST_FORWARD ((USAGE) 0xB3)")]
    public const ushort HID_USAGE_CONSUMER_FAST_FORWARD = ((ushort)(0xB3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_REWIND ((USAGE) 0xB4)")]
    public const ushort HID_USAGE_CONSUMER_REWIND = ((ushort)(0xB4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SCAN_NEXT_TRACK ((USAGE) 0xB5)")]
    public const ushort HID_USAGE_CONSUMER_SCAN_NEXT_TRACK = ((ushort)(0xB5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SCAN_PREV_TRACK ((USAGE) 0xB6)")]
    public const ushort HID_USAGE_CONSUMER_SCAN_PREV_TRACK = ((ushort)(0xB6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_STOP ((USAGE) 0xB7)")]
    public const ushort HID_USAGE_CONSUMER_STOP = ((ushort)(0xB7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAY_PAUSE ((USAGE) 0xCD)")]
    public const ushort HID_USAGE_CONSUMER_PLAY_PAUSE = ((ushort)(0xCD));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR ((USAGE) 0xD0)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR = ((ushort)(0xD0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD ((USAGE) 0xD1)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD = ((ushort)(0xD1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP ((USAGE) 0xD2)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP = ((ushort)(0xD2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT ((USAGE) 0xD3)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT = ((ushort)(0xD3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR ((USAGE) 0xD4)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR = ((ushort)(0xD4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE ((USAGE) 0xD5)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE = ((ushort)(0xD5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA ((USAGE) 0xD6)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA = ((ushort)(0xD6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST ((USAGE) 0xD7)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST = ((ushort)(0xD7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME ((USAGE) 0xE0)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME = ((ushort)(0xE0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BALANCE ((USAGE) 0xE1)")]
    public const ushort HID_USAGE_CONSUMER_BALANCE = ((ushort)(0xE1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MUTE ((USAGE) 0xE2)")]
    public const ushort HID_USAGE_CONSUMER_MUTE = ((ushort)(0xE2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS ((USAGE) 0xE3)")]
    public const ushort HID_USAGE_CONSUMER_BASS = ((ushort)(0xE3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE ((USAGE) 0xE4)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE = ((ushort)(0xE4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_BOOST ((USAGE) 0xE5)")]
    public const ushort HID_USAGE_CONSUMER_BASS_BOOST = ((ushort)(0xE5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SURROUND_MODE ((USAGE) 0xE6)")]
    public const ushort HID_USAGE_CONSUMER_SURROUND_MODE = ((ushort)(0xE6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_LOUDNESS ((USAGE) 0xE7)")]
    public const ushort HID_USAGE_CONSUMER_LOUDNESS = ((ushort)(0xE7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MPX ((USAGE) 0xE8)")]
    public const ushort HID_USAGE_CONSUMER_MPX = ((ushort)(0xE8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME_INCREMENT ((USAGE) 0xE9)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME_INCREMENT = ((ushort)(0xE9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME_DECREMENT ((USAGE) 0xEA)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME_DECREMENT = ((ushort)(0xEA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_INCREMENT ((USAGE) 0x152)")]
    public const ushort HID_USAGE_CONSUMER_BASS_INCREMENT = ((ushort)(0x152));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_DECREMENT ((USAGE) 0x153)")]
    public const ushort HID_USAGE_CONSUMER_BASS_DECREMENT = ((ushort)(0x153));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE_INCREMENT ((USAGE) 0x154)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE_INCREMENT = ((ushort)(0x154));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE_DECREMENT ((USAGE) 0x155)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE_DECREMENT = ((ushort)(0x155));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CONFIGURATION ((USAGE) 0x183)")]
    public const ushort HID_USAGE_CONSUMER_AL_CONFIGURATION = ((ushort)(0x183));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_EMAIL ((USAGE) 0x18A)")]
    public const ushort HID_USAGE_CONSUMER_AL_EMAIL = ((ushort)(0x18A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CALCULATOR ((USAGE) 0x192)")]
    public const ushort HID_USAGE_CONSUMER_AL_CALCULATOR = ((ushort)(0x192));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_BROWSER ((USAGE) 0x194)")]
    public const ushort HID_USAGE_CONSUMER_AL_BROWSER = ((ushort)(0x194));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SEARCH ((USAGE) 0x1C6)")]
    public const ushort HID_USAGE_CONSUMER_AL_SEARCH = ((ushort)(0x1C6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SEARCH ((USAGE) 0x221)")]
    public const ushort HID_USAGE_CONSUMER_AC_SEARCH = ((ushort)(0x221));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_GOTO ((USAGE) 0x222)")]
    public const ushort HID_USAGE_CONSUMER_AC_GOTO = ((ushort)(0x222));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_HOME ((USAGE) 0x223)")]
    public const ushort HID_USAGE_CONSUMER_AC_HOME = ((ushort)(0x223));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BACK ((USAGE) 0x224)")]
    public const ushort HID_USAGE_CONSUMER_AC_BACK = ((ushort)(0x224));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FORWARD ((USAGE) 0x225)")]
    public const ushort HID_USAGE_CONSUMER_AC_FORWARD = ((ushort)(0x225));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_STOP ((USAGE) 0x226)")]
    public const ushort HID_USAGE_CONSUMER_AC_STOP = ((ushort)(0x226));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_REFRESH ((USAGE) 0x227)")]
    public const ushort HID_USAGE_CONSUMER_AC_REFRESH = ((ushort)(0x227));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PREVIOUS ((USAGE) 0x228)")]
    public const ushort HID_USAGE_CONSUMER_AC_PREVIOUS = ((ushort)(0x228));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NEXT ((USAGE) 0x229)")]
    public const ushort HID_USAGE_CONSUMER_AC_NEXT = ((ushort)(0x229));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BOOKMARKS ((USAGE) 0x22A)")]
    public const ushort HID_USAGE_CONSUMER_AC_BOOKMARKS = ((ushort)(0x22A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PAN ((USAGE) 0x238)")]
    public const ushort HID_USAGE_CONSUMER_AC_PAN = ((ushort)(0x238));

    [NativeTypeName("#define HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION ((USAGE) 0x2C0)")]
    public const ushort HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION = ((ushort)(0x2C0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR ((USAGE) 0x2C1)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR = ((ushort)(0x2C1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE ((USAGE) 0x2C2)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE = ((ushort)(0x2C2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT ((USAGE) 0x2C3)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT = ((ushort)(0x2C3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT ((USAGE) 0x2C4)")]
    public const ushort HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT = ((ushort)(0x2C4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX ((USAGE) 0x2C5)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX = ((ushort)(0x2C5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS ((USAGE) 0x2C6)")]
    public const ushort HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS = ((ushort)(0x2C6));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DIGITIZER ((USAGE) 0x01)")]
    public const ushort HID_USAGE_DIGITIZER_DIGITIZER = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PEN ((USAGE) 0x02)")]
    public const ushort HID_USAGE_DIGITIZER_PEN = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_LIGHT_PEN ((USAGE) 0x03)")]
    public const ushort HID_USAGE_DIGITIZER_LIGHT_PEN = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH_SCREEN ((USAGE) 0x04)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH_SCREEN = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH_PAD ((USAGE) 0x05)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH_PAD = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_WHITE_BOARD ((USAGE) 0x06)")]
    public const ushort HID_USAGE_DIGITIZER_WHITE_BOARD = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_COORD_MEASURING ((USAGE) 0x07)")]
    public const ushort HID_USAGE_DIGITIZER_COORD_MEASURING = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_3D_DIGITIZER ((USAGE) 0x08)")]
    public const ushort HID_USAGE_DIGITIZER_3D_DIGITIZER = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_STEREO_PLOTTER ((USAGE) 0x09)")]
    public const ushort HID_USAGE_DIGITIZER_STEREO_PLOTTER = ((ushort)(0x09));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ARTICULATED_ARM ((USAGE) 0x0A)")]
    public const ushort HID_USAGE_DIGITIZER_ARTICULATED_ARM = ((ushort)(0x0A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ARMATURE ((USAGE) 0x0B)")]
    public const ushort HID_USAGE_DIGITIZER_ARMATURE = ((ushort)(0x0B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_MULTI_POINT ((USAGE) 0x0C)")]
    public const ushort HID_USAGE_DIGITIZER_MULTI_POINT = ((ushort)(0x0C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_FREE_SPACE_WAND ((USAGE) 0x0D)")]
    public const ushort HID_USAGE_DIGITIZER_FREE_SPACE_WAND = ((ushort)(0x0D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP ((USAGE) 0x0F)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP = ((ushort)(0x0F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_STYLUS ((USAGE) 0x20)")]
    public const ushort HID_USAGE_DIGITIZER_STYLUS = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PUCK ((USAGE) 0x21)")]
    public const ushort HID_USAGE_DIGITIZER_PUCK = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_FINGER ((USAGE) 0x22)")]
    public const ushort HID_USAGE_DIGITIZER_FINGER = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS ((USAGE) 0x39)")]
    public const ushort HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS ((USAGE) 0x3A)")]
    public const ushort HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS = ((ushort)(0x3A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TIP_PRESSURE ((USAGE) 0x30)")]
    public const ushort HID_USAGE_DIGITIZER_TIP_PRESSURE = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BARREL_PRESSURE ((USAGE) 0x31)")]
    public const ushort HID_USAGE_DIGITIZER_BARREL_PRESSURE = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_IN_RANGE ((USAGE) 0x32)")]
    public const ushort HID_USAGE_DIGITIZER_IN_RANGE = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH ((USAGE) 0x33)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_UNTOUCH ((USAGE) 0x34)")]
    public const ushort HID_USAGE_DIGITIZER_UNTOUCH = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TAP ((USAGE) 0x35)")]
    public const ushort HID_USAGE_DIGITIZER_TAP = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_QUALITY ((USAGE) 0x36)")]
    public const ushort HID_USAGE_DIGITIZER_QUALITY = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DATA_VALID ((USAGE) 0x37)")]
    public const ushort HID_USAGE_DIGITIZER_DATA_VALID = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_INDEX ((USAGE) 0x38)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_INDEX = ((ushort)(0x38));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BATTERY_STRENGTH ((USAGE) 0x3B)")]
    public const ushort HID_USAGE_DIGITIZER_BATTERY_STRENGTH = ((ushort)(0x3B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_INVERT ((USAGE) 0x3C)")]
    public const ushort HID_USAGE_DIGITIZER_INVERT = ((ushort)(0x3C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_X_TILT ((USAGE) 0x3D)")]
    public const ushort HID_USAGE_DIGITIZER_X_TILT = ((ushort)(0x3D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_Y_TILT ((USAGE) 0x3E)")]
    public const ushort HID_USAGE_DIGITIZER_Y_TILT = ((ushort)(0x3E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_AZIMUTH ((USAGE) 0x3F)")]
    public const ushort HID_USAGE_DIGITIZER_AZIMUTH = ((ushort)(0x3F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ALTITUDE ((USAGE) 0x40)")]
    public const ushort HID_USAGE_DIGITIZER_ALTITUDE = ((ushort)(0x40));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TWIST ((USAGE) 0x41)")]
    public const ushort HID_USAGE_DIGITIZER_TWIST = ((ushort)(0x41));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TIP_SWITCH ((USAGE) 0x42)")]
    public const ushort HID_USAGE_DIGITIZER_TIP_SWITCH = ((ushort)(0x42));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH ((USAGE) 0x43)")]
    public const ushort HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH = ((ushort)(0x43));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BARREL_SWITCH ((USAGE) 0x44)")]
    public const ushort HID_USAGE_DIGITIZER_BARREL_SWITCH = ((ushort)(0x44));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ERASER ((USAGE) 0x45)")]
    public const ushort HID_USAGE_DIGITIZER_ERASER = ((ushort)(0x45));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TABLET_PICK ((USAGE) 0x46)")]
    public const ushort HID_USAGE_DIGITIZER_TABLET_PICK = ((ushort)(0x46));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL ((USAGE) 0x5B)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL = ((ushort)(0x5B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VENDOR_ID ((USAGE) 0x6A)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VENDOR_ID = ((ushort)(0x6A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VERSION ((USAGE) 0x6B)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VERSION = ((ushort)(0x6B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_FRAME_DATA ((USAGE) 0x6C)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_FRAME_DATA = ((ushort)(0x6C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL_PART2 ((USAGE) 0x6E)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL_PART2 = ((ushort)(0x6E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_VENDOR ((USAGE) 0x91)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_VENDOR = ((ushort)(0x91));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_PRODUCT ((USAGE) 0x92)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_PRODUCT = ((ushort)(0x92));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_CONNECTED ((USAGE) 0xA2)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_CONNECTED = ((ushort)(0xA2));

    [NativeTypeName("#define HID_USAGE_HAPTICS_SIMPLE_CONTROLLER ((USAGE)0x01)")]
    public const ushort HID_USAGE_HAPTICS_SIMPLE_CONTROLLER = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_LIST ((USAGE)0x10)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_LIST = ((ushort)(0x10));

    [NativeTypeName("#define HID_USAGE_HAPTICS_DURATION_LIST ((USAGE)0x11)")]
    public const ushort HID_USAGE_HAPTICS_DURATION_LIST = ((ushort)(0x11));

    [NativeTypeName("#define HID_USAGE_HAPTICS_AUTO_TRIGGER ((USAGE)0x20)")]
    public const ushort HID_USAGE_HAPTICS_AUTO_TRIGGER = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_HAPTICS_MANUAL_TRIGGER ((USAGE)0x21)")]
    public const ushort HID_USAGE_HAPTICS_MANUAL_TRIGGER = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL ((USAGE)0x22)")]
    public const ushort HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_HAPTICS_INTENSITY ((USAGE)0x23)")]
    public const ushort HID_USAGE_HAPTICS_INTENSITY = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_HAPTICS_REPEAT_COUNT ((USAGE)0x24)")]
    public const ushort HID_USAGE_HAPTICS_REPEAT_COUNT = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_HAPTICS_RETRIGGER_PERIOD ((USAGE)0x25)")]
    public const ushort HID_USAGE_HAPTICS_RETRIGGER_PERIOD = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE ((USAGE)0x26)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID ((USAGE)0x27)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME ((USAGE)0x28)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_BEGIN ((USAGE)0x1000)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_BEGIN = ((ushort)(0x1000));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_STOP ((USAGE)0x1001)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_STOP = ((ushort)(0x1001));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_NULL ((USAGE)0x1002)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_NULL = ((ushort)(0x1002));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_CLICK ((USAGE)0x1003)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_CLICK = ((ushort)(0x1003));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_BUZZ ((USAGE)0x1004)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_BUZZ = ((ushort)(0x1004));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_RUMBLE ((USAGE)0x1005)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_RUMBLE = ((ushort)(0x1005));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_PRESS ((USAGE)0x1006)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_PRESS = ((ushort)(0x1006));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_RELEASE ((USAGE)0x1007)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_RELEASE = ((ushort)(0x1007));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_END ((USAGE)0x1FFF)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_END = ((ushort)(0x1FFF));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_BEGIN ((USAGE)0x2000)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_BEGIN = ((ushort)(0x2000));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_END ((USAGE)0x2FFF)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_END = ((ushort)(0x2FFF));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY ((USAGE) 0x01)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY ((USAGE) 0x02)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT ((USAGE) 0x20)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT ((USAGE) 0x24)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT ((USAGE) 0x2B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT = ((ushort)(0x2B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS ((USAGE) 0x2D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS = ((ushort)(0x2D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT ((USAGE) 0x32)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT = ((ushort)(0x32));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_REPORT ((USAGE) 0x3B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_REPORT = ((ushort)(0x3B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_DATA ((USAGE) 0x3C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_DATA = ((ushort)(0x3C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE ((USAGE) 0x48)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE = ((ushort)(0x48));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_REPORT ((USAGE) 0x85)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_REPORT = ((ushort)(0x85));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA ((USAGE) 0x88)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA = ((ushort)(0x88));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_REPORT ((USAGE) 0x8A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_REPORT = ((ushort)(0x8A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_DATA ((USAGE) 0x8F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_DATA = ((ushort)(0x8F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON ((USAGE) 0x90)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON = ((ushort)(0x90));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET ((USAGE) 0x21)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DATA_READ_BACK ((USAGE) 0x22)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DATA_READ_BACK = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_READ_BACK ((USAGE) 0x23)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_READ_BACK = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY ((USAGE) 0x25)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE ((USAGE) 0x26)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY ((USAGE) 0x27)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE ((USAGE) 0x28)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL ((USAGE) 0x29)")]
    public const ushort HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL = ((ushort)(0x29));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_DATA ((USAGE) 0x2C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_DATA = ((ushort)(0x2C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY ((USAGE) 0x2E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY = ((ushort)(0x2E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_STATUS_READY ((USAGE) 0x2F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_STATUS_READY = ((ushort)(0x2F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER ((USAGE) 0x30)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER = ((ushort)(0x30));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ ((USAGE) 0x31)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ = ((ushort)(0x31));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ROW ((USAGE) 0x33)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ROW = ((ushort)(0x33));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_COLUMN ((USAGE) 0x34)")]
    public const ushort HID_USAGE_ALPHANUMERIC_COLUMN = ((ushort)(0x34));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ROWS ((USAGE) 0x35)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ROWS = ((ushort)(0x35));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_COLUMNS ((USAGE) 0x36)")]
    public const ushort HID_USAGE_ALPHANUMERIC_COLUMNS = ((ushort)(0x36));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING ((USAGE) 0x37)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING = ((ushort)(0x37));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_MODE ((USAGE) 0x38)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_MODE = ((ushort)(0x38));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE ((USAGE) 0x39)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE = ((ushort)(0x39));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_BLINK ((USAGE) 0x3A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_BLINK = ((ushort)(0x3A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_WIDTH ((USAGE) 0x3D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_WIDTH = ((ushort)(0x3D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT ((USAGE) 0x3E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT = ((ushort)(0x3E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL ((USAGE) 0x3F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL = ((ushort)(0x3F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL ((USAGE) 0x40)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL = ((ushort)(0x40));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET ((USAGE) 0x41)")]
    public const ushort HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET = ((ushort)(0x41));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT ((USAGE) 0x42)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT = ((ushort)(0x42));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP ((USAGE) 0x43)")]
    public const ushort HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP = ((ushort)(0x43));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT ((USAGE) 0x44)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT = ((ushort)(0x44));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP ((USAGE) 0x45)")]
    public const ushort HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP = ((ushort)(0x45));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS ((USAGE) 0x46)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS = ((ushort)(0x46));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST ((USAGE) 0x47)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST = ((ushort)(0x47));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK ((USAGE) 0x49)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK = ((ushort)(0x49));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA ((USAGE) 0x4A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA = ((ushort)(0x4A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE ((USAGE) 0x4B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE = ((ushort)(0x4B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE ((USAGE) 0x4C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE = ((ushort)(0x4C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK ((USAGE) 0x4D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK = ((ushort)(0x4D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X ((USAGE) 0x80)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X = ((ushort)(0x80));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y ((USAGE) 0x81)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y = ((ushort)(0x81));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT ((USAGE) 0x83)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT = ((ushort)(0x83));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION ((USAGE) 0x84)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION = ((ushort)(0x84));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE ((USAGE) 0x86)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE = ((ushort)(0x86));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET ((USAGE) 0x87)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET = ((ushort)(0x87));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1 ((USAGE) 0x8B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1 = ((ushort)(0x8B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1 ((USAGE) 0x8C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1 = ((ushort)(0x8C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2 ((USAGE) 0x8D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2 = ((ushort)(0x8D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2 ((USAGE) 0x8E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2 = ((ushort)(0x8E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID ((USAGE) 0x91)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID = ((ushort)(0x91));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE ((USAGE) 0x92)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE = ((ushort)(0x92));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1 ((USAGE) 0x93)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1 = ((ushort)(0x93));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2 ((USAGE) 0x94)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2 = ((ushort)(0x94));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT ((USAGE) 0x95)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT = ((ushort)(0x95));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY ((USAGE) 0x01)")]
    public const ushort HID_USAGE_LAMPARRAY = ((ushort)(0x01));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT ((USAGE) 0x02)")]
    public const ushort HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT = ((ushort)(0x02));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_COUNT ((USAGE) 0x03)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_COUNT = ((ushort)(0x03));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS ((USAGE) 0x04)")]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS = ((ushort)(0x04));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS ((USAGE) 0x05)")]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS = ((ushort)(0x05));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS ((USAGE) 0x06)")]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS = ((ushort)(0x06));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_KIND ((USAGE) 0x07)")]
    public const ushort HID_USAGE_LAMPARRAY_KIND = ((ushort)(0x07));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS ((USAGE) 0x08)")]
    public const ushort HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS = ((ushort)(0x08));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT ((USAGE) 0x20)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID ((USAGE) 0x21)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT ((USAGE) 0x22)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT = ((ushort)(0x22));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS ((USAGE) 0x23)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS = ((ushort)(0x23));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS ((USAGE) 0x24)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS = ((ushort)(0x24));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS ((USAGE) 0x25)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS = ((ushort)(0x25));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_PURPOSES ((USAGE) 0x26)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_PURPOSES = ((ushort)(0x26));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS ((USAGE) 0x27)")]
    public const ushort HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS = ((ushort)(0x27));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT ((USAGE) 0x28)")]
    public const ushort HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT = ((ushort)(0x28));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT ((USAGE) 0x29)")]
    public const ushort HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT = ((ushort)(0x29));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT ((USAGE) 0x2A)")]
    public const ushort HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT = ((ushort)(0x2A));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT ((USAGE) 0x2B)")]
    public const ushort HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT = ((ushort)(0x2B));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE ((USAGE) 0x2C)")]
    public const ushort HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE = ((ushort)(0x2C));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_INPUT_BINDING ((USAGE) 0x2D)")]
    public const ushort HID_USAGE_LAMPARRAY_INPUT_BINDING = ((ushort)(0x2D));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT ((USAGE) 0x50)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT = ((ushort)(0x50));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL ((USAGE) 0x51)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL = ((ushort)(0x51));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL ((USAGE) 0x52)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL = ((ushort)(0x52));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL ((USAGE) 0x53)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL = ((ushort)(0x53));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL ((USAGE) 0x54)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL = ((ushort)(0x54));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS ((USAGE) 0x55)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS = ((ushort)(0x55));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT ((USAGE) 0x60)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT = ((ushort)(0x60));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID_START ((USAGE) 0x61)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_START = ((ushort)(0x61));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID_END ((USAGE) 0x62)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_END = ((ushort)(0x62));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_CONTROL_REPORT ((USAGE) 0x70)")]
    public const ushort HID_USAGE_LAMPARRAY_CONTROL_REPORT = ((ushort)(0x70));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE ((USAGE) 0x71)")]
    public const ushort HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE = ((ushort)(0x71));

    [NativeTypeName("#define HID_USAGE_CAMERA_AUTO_FOCUS ((USAGE) 0x20)")]
    public const ushort HID_USAGE_CAMERA_AUTO_FOCUS = ((ushort)(0x20));

    [NativeTypeName("#define HID_USAGE_CAMERA_SHUTTER ((USAGE) 0x21)")]
    public const ushort HID_USAGE_CAMERA_SHUTTER = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_MS_BTH_HF_DIALNUMBER ((USAGE) 0x21)")]
    public const ushort HID_USAGE_MS_BTH_HF_DIALNUMBER = ((ushort)(0x21));

    [NativeTypeName("#define HID_USAGE_MS_BTH_HF_DIALMEMORY ((USAGE) 0x22)")]
    public const ushort HID_USAGE_MS_BTH_HF_DIALMEMORY = ((ushort)(0x22));
}
