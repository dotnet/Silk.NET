// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidusage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HID
{
    [NativeTypeName("#define HID_USAGE_PAGE_UNDEFINED ((USAGE) 0x0000)")]
    public const ushort HID_USAGE_PAGE_UNDEFINED = ((ushort)(0x0000));

    [NativeTypeName("#define HID_USAGE_PAGE_ARCADE ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_PAGE_ARCADE = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_PAGE_ALPHANUMERIC ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_PAGE_ALPHANUMERIC = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_PAGE_BARCODE_SCANNER ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_PAGE_BARCODE_SCANNER = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_PAGE_BATTERY_SYSTEM ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_PAGE_BATTERY_SYSTEM = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_PAGE_BRAILLE_DISPLAY ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_PAGE_BRAILLE_DISPLAY = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_PAGE_BUTTON ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_PAGE_BUTTON = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_PAGE_CAMERA_CONTROL ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_PAGE_CAMERA_CONTROL = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_PAGE_CONSUMER ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_PAGE_CONSUMER = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_PAGE_DIGITIZER ((USAGE) 0x000D)")]
    public const ushort HID_USAGE_PAGE_DIGITIZER = ((ushort)(0x000D));

    [NativeTypeName("#define HID_USAGE_PAGE_EYE_AND_HEAD_TRACKERS ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_PAGE_EYE_AND_HEAD_TRACKERS = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_PAGE_FIDO_ALLIANCE ((USAGE) 0xF1D0)")]
    public const ushort HID_USAGE_PAGE_FIDO_ALLIANCE = ((ushort)(0xF1D0));

    [NativeTypeName("#define HID_USAGE_PAGE_GAME ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_PAGE_GAME = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_PAGE_GAMING_DEVICE ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_PAGE_GAMING_DEVICE = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_PAGE_GENERIC ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_PAGE_GENERIC = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_PAGE_GENERIC_DEVICE ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_PAGE_GENERIC_DEVICE = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_PAGE_HAPTICS ((USAGE) 0x000E)")]
    public const ushort HID_USAGE_PAGE_HAPTICS = ((ushort)(0x000E));

    [NativeTypeName("#define HID_USAGE_PAGE_KEYBOARD ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_PAGE_KEYBOARD = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_PAGE_LED ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_PAGE_LED = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_PAGE_LIGHTING_ILLUMINATION ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_PAGE_LIGHTING_ILLUMINATION = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_PAGE_MAGNETIC_STRIPE_READER ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_PAGE_MAGNETIC_STRIPE_READER = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_PAGE_MEDICAL_INSTRUMENT ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_PAGE_MEDICAL_INSTRUMENT = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE ((USAGE) 0xFFF3)")]
    public const ushort HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE = ((ushort)(0xFFF3));

    [NativeTypeName("#define HID_USAGE_PAGE_MONITOR ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_PAGE_MONITOR = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_PAGE_MONITOR_ENUMERATED ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_PAGE_MONITOR_ENUMERATED = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_PAGE_ORDINAL ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_PAGE_ORDINAL = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_PAGE_PID ((USAGE) 0x000F)")]
    public const ushort HID_USAGE_PAGE_PID = ((ushort)(0x000F));

    [NativeTypeName("#define HID_USAGE_PAGE_POWER ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_PAGE_POWER = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_PAGE_WEIGHING_DEVICE ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_PAGE_WEIGHING_DEVICE = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_PAGE_SENSOR ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_PAGE_SENSOR = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_PAGE_SIMULATION ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_PAGE_SIMULATION = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_PAGE_SOC ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_PAGE_SOC = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_PAGE_SPORT ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_PAGE_SPORT = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_PAGE_TELEPHONY ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_PAGE_TELEPHONY = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_PAGE_UNICODE ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_PAGE_UNICODE = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_PAGE_VESA_VIRTUAL_CONTROLS ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_PAGE_VESA_VIRTUAL_CONTROLS = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_PAGE_VR ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_PAGE_VR = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN ((USAGE) 0xFF00)")]
    public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN = ((ushort)(0xFF00));

    [NativeTypeName("#define HID_USAGE_PAGE_VENDOR_DEFINED_END ((USAGE) 0xFFFF)")]
    public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_END = ((ushort)(0xFFFF));

    [NativeTypeName("#define HID_USAGE_UNDEFINED ((USAGE) 0x0000)")]
    public const ushort HID_USAGE_UNDEFINED = ((ushort)(0x0000));

    [NativeTypeName("#define HID_USAGE_ARCADE_GENERAL_PURPOSE_IO_CARD ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_ARCADE_GENERAL_PURPOSE_IO_CARD = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DOOR ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_ARCADE_COIN_DOOR = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_ARCADE_WATCHDOG_TIMER ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_ARCADE_WATCHDOG_TIMER = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_ARCADE_GENERAL_PURPOSE_ANALOG_INPUT_STATE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_ARCADE_GENERAL_PURPOSE_ANALOG_INPUT_STATE = ((ushort)(0x0030));

    [NativeTypeName(
        "#define HID_USAGE_ARCADE_GENERAL_PURPOSE_DIGITAL_INPUT_STATE ((USAGE) 0x0031)"
    )]
    public const ushort HID_USAGE_ARCADE_GENERAL_PURPOSE_DIGITAL_INPUT_STATE = ((ushort)(0x0031));

    [NativeTypeName(
        "#define HID_USAGE_ARCADE_GENERAL_PURPOSE_OPTICAL_INPUT_STATE ((USAGE) 0x0032)"
    )]
    public const ushort HID_USAGE_ARCADE_GENERAL_PURPOSE_OPTICAL_INPUT_STATE = ((ushort)(0x0032));

    [NativeTypeName(
        "#define HID_USAGE_ARCADE_GENERAL_PURPOSE_DIGITAL_OUTPUT_STATE ((USAGE) 0x0033)"
    )]
    public const ushort HID_USAGE_ARCADE_GENERAL_PURPOSE_DIGITAL_OUTPUT_STATE = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_ARCADE_NUMBER_OF_COIN_DOORS ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_ARCADE_NUMBER_OF_COIN_DOORS = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DRAWER_DROP_COUNT ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_ARCADE_COIN_DRAWER_DROP_COUNT = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DRAWER_START ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_ARCADE_COIN_DRAWER_START = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DRAWER_SERVICE ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_ARCADE_COIN_DRAWER_SERVICE = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DRAWER_TILT ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_ARCADE_COIN_DRAWER_TILT = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DOOR_TEST ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_ARCADE_COIN_DOOR_TEST = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DOOR_LOCKOUT ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_ARCADE_COIN_DOOR_LOCKOUT = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_ARCADE_WATCHDOG_TIMEOUT ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_ARCADE_WATCHDOG_TIMEOUT = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_ARCADE_WATCHDOG_ACTION ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_ARCADE_WATCHDOG_ACTION = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_ARCADE_WATCHDOG_REBOOT ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_ARCADE_WATCHDOG_REBOOT = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_ARCADE_WATCHDOG_RESTART ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_ARCADE_WATCHDOG_RESTART = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_ARCADE_ALARM_INPUT ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_ARCADE_ALARM_INPUT = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_ARCADE_COIN_DOOR_COUNTER ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_ARCADE_COIN_DOOR_COUNTER = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_ARCADE_IO_DIRECTION_MAPPING ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_ARCADE_IO_DIRECTION_MAPPING = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_ARCADE_SET_IO_DIRECTION_MAPPING ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_ARCADE_SET_IO_DIRECTION_MAPPING = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_ARCADE_EXTENDED_OPTICAL_INPUT_STATE ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_ARCADE_EXTENDED_OPTICAL_INPUT_STATE = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_ARCADE_PIN_PAD_INPUT_STATE ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_ARCADE_PIN_PAD_INPUT_STATE = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_ARCADE_PIN_PAD_STATUS ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_ARCADE_PIN_PAD_STATUS = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_ARCADE_PIN_PAD_OUTPUT ((USAGE) 0x004C)")]
    public const ushort HID_USAGE_ARCADE_PIN_PAD_OUTPUT = ((ushort)(0x004C));

    [NativeTypeName("#define HID_USAGE_ARCADE_PIN_PAD_COMMAND ((USAGE) 0x004D)")]
    public const ushort HID_USAGE_ARCADE_PIN_PAD_COMMAND = ((ushort)(0x004D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DATA_READ_BACK ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DATA_READ_BACK = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_READ_BACK ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_READ_BACK = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_DATA ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_DATA = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_STATUS_READY ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_STATUS_READY = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ROW ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ROW = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_COLUMN ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_ALPHANUMERIC_COLUMN = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ROWS ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ROWS = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_COLUMNS ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_ALPHANUMERIC_COLUMNS = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_MODE ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_MODE = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CURSOR_BLINK ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_BLINK = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_REPORT ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_REPORT = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_DATA ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_DATA = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_WIDTH ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_WIDTH = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL ((USAGE) 0x003F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL = ((ushort)(0x003F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE ((USAGE) 0x004C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE = ((ushort)(0x004C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK ((USAGE) 0x004D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK = ((ushort)(0x004D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_MAX_BLIT_SIZE ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_ALPHANUMERIC_MAX_BLIT_SIZE = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_REPORT ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_REPORT = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_PALETTE_DATA ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_REPORT ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_REPORT = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1 ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1 = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1 ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1 = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2 ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2 = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2 ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2 = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_BLIT_DATA ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_ALPHANUMERIC_BLIT_DATA = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1 ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1 = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2 ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2 = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_SOFT_KEYS ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_ALPHANUMERIC_SOFT_KEYS = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_DISPLAY_DATA_EXTENSIONS ((USAGE) 0x00CC)")]
    public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_DATA_EXTENSIONS = ((ushort)(0x00CC));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_MAPPING ((USAGE) 0x00CF)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_MAPPING = ((ushort)(0x00CF));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_UNICODE_EQUIVALENT ((USAGE) 0x00DD)")]
    public const ushort HID_USAGE_ALPHANUMERIC_UNICODE_EQUIVALENT = ((ushort)(0x00DD));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_CHARACTER_PAGE_MAPPING ((USAGE) 0x00DF)")]
    public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_PAGE_MAPPING = ((ushort)(0x00DF));

    [NativeTypeName("#define HID_USAGE_ALPHANUMERIC_REQUEST_REPORT ((USAGE) 0x00FF)")]
    public const ushort HID_USAGE_ALPHANUMERIC_REQUEST_REPORT = ((ushort)(0x00FF));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BARCODE_BADGE_READER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BARCODE_BADGE_READER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BARCODE_SCANNER ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BARCODE_SCANNER = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DUMB_BAR_CODE_SCANNER ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DUMB_BAR_CODE_SCANNER = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CORDLESS_SCANNER_BASE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CORDLESS_SCANNER_BASE = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BAR_CODE_SCANNER_CRADLE ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BAR_CODE_SCANNER_CRADLE = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ATTRIBUTE_REPORT ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ATTRIBUTE_REPORT = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SETTINGS_REPORT ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SETTINGS_REPORT = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SCANNED_DATA_REPORT ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SCANNED_DATA_REPORT = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_RAW_SCANNED_DATA_REPORT ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_RAW_SCANNED_DATA_REPORT = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRIGGER_REPORT ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_REPORT = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_STATUS_REPORT ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_STATUS_REPORT = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCEAN_CONTROL_REPORT ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCEAN_CONTROL_REPORT = ((ushort)(0x0016));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_EAN_23_LABEL_CONTROL_REPORT ((USAGE) 0x0017)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_23_LABEL_CONTROL_REPORT = ((ushort)(0x0017));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_39_CONTROL_REPORT ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_39_CONTROL_REPORT = ((ushort)(0x0018));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_INTERLEAVED_2_OF_5_CONTROL_REPORT ((USAGE) 0x0019)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_INTERLEAVED_2_OF_5_CONTROL_REPORT = (
        (ushort)(0x0019)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5_CONTROL_REPORT ((USAGE) 0x001A)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5_CONTROL_REPORT = (
        (ushort)(0x001A)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_MSI_PLESSEY_CONTROL_REPORT ((USAGE) 0x001B)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_MSI_PLESSEY_CONTROL_REPORT = ((ushort)(0x001B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODABAR_CONTROL_REPORT ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODABAR_CONTROL_REPORT = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_128_CONTROL_REPORT ((USAGE) 0x001D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_128_CONTROL_REPORT = ((ushort)(0x001D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MISC_1D_CONTROL_REPORT ((USAGE) 0x001E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MISC_1D_CONTROL_REPORT = ((ushort)(0x001E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_2D_CONTROL_REPORT ((USAGE) 0x001F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_2D_CONTROL_REPORT = ((ushort)(0x001F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_AIMINGPOINTER_MODE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_AIMINGPOINTER_MODE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BAR_CODE_PRESENT_SENSOR ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BAR_CODE_PRESENT_SENSOR = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CLASS_1A_LASER ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CLASS_1A_LASER = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CLASS_2_LASER ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CLASS_2_LASER = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_HEATER_PRESENT ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_HEATER_PRESENT = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CONTACT_SCANNER ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CONTACT_SCANNER = ((ushort)(0x0035));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_ELECTRONIC_ARTICLE_SURVEILLANCE_NOTIFICATION ((USAGE) 0x0036)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_ELECTRONIC_ARTICLE_SURVEILLANCE_NOTIFICATION = (
        (ushort)(0x0036)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CONSTANT_ELECTRONIC_ARTICLE_SURVEILLANCE ((USAGE) 0x0037)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CONSTANT_ELECTRONIC_ARTICLE_SURVEILLANCE = (
        (ushort)(0x0037)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ERROR_INDICATION ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ERROR_INDICATION = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_FIXED_BEEPER ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_FIXED_BEEPER = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_DECODE_INDICATION ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_DECODE_INDICATION = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_HANDS_FREE_SCANNING ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_HANDS_FREE_SCANNING = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_INTRINSICALLY_SAFE ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_INTRINSICALLY_SAFE = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_KLASSE_EINS_LASER ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_KLASSE_EINS_LASER = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_LONG_RANGE_SCANNER ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_LONG_RANGE_SCANNER = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MIRROR_SPEED_CONTROL ((USAGE) 0x003F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MIRROR_SPEED_CONTROL = ((ushort)(0x003F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_NOT_ON_FILE_INDICATION ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_NOT_ON_FILE_INDICATION = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PROGRAMMABLE_BEEPER ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PROGRAMMABLE_BEEPER = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRIGGERLESS ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGERLESS = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_WAND ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_WAND = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_WATER_RESISTANT ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_WATER_RESISTANT = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MULTIRANGE_SCANNER ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MULTIRANGE_SCANNER = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PROXIMITY_SENSOR ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PROXIMITY_SENSOR = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_FRAGMENT_DECODING ((USAGE) 0x004D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_FRAGMENT_DECODING = ((ushort)(0x004D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SCANNER_READ_CONFIDENCE ((USAGE) 0x004E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SCANNER_READ_CONFIDENCE = ((ushort)(0x004E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DATA_PREFIX ((USAGE) 0x004F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DATA_PREFIX = ((ushort)(0x004F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PREFIX_AIMI ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PREFIX_AIMI = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PREFIX_NONE ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PREFIX_NONE = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PREFIX_PROPRIETARY ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PREFIX_PROPRIETARY = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ACTIVE_TIME ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ACTIVE_TIME = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_AIMING_LASER_PATTERN ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_AIMING_LASER_PATTERN = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BAR_CODE_PRESENT ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BAR_CODE_PRESENT = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BEEPER_STATE ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BEEPER_STATE = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_LASER_ON_TIME ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_LASER_ON_TIME = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_LASER_STATE ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_LASER_STATE = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_LOCKOUT_TIME ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_LOCKOUT_TIME = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MOTOR_STATE ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MOTOR_STATE = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MOTOR_TIMEOUT ((USAGE) 0x005D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MOTOR_TIMEOUT = ((ushort)(0x005D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_POWER_ON_RESET_SCANNER ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_POWER_ON_RESET_SCANNER = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PREVENT_READ_OF_BARCODES ((USAGE) 0x005F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PREVENT_READ_OF_BARCODES = ((ushort)(0x005F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_INITIATE_BARCODE_READ ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_INITIATE_BARCODE_READ = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRIGGER_STATE ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_STATE = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE = ((ushort)(0x0062));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_BLINKING_LASER_ON ((USAGE) 0x0063)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_BLINKING_LASER_ON = (
        (ushort)(0x0063)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_CONTINUOUS_LASER_ON ((USAGE) 0x0064)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_CONTINUOUS_LASER_ON = (
        (ushort)(0x0064)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_LASER_ON_WHILE_PULLED ((USAGE) 0x0065)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_LASER_ON_WHILE_PULLED = (
        (ushort)(0x0065)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_LASER_STAYS_ON_AFTER_RELEASE ((USAGE) 0x0066)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIGGER_MODE_LASER_STAYS_ON_AFTER_RELEASE = (
        (ushort)(0x0066)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_COMMIT_PARAMETERS_TO_NVM ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_COMMIT_PARAMETERS_TO_NVM = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PARAMETER_SCANNING ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PARAMETER_SCANNING = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PARAMETERS_CHANGED ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PARAMETERS_CHANGED = ((ushort)(0x006F));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_SET_PARAMETER_DEFAULT_VALUES ((USAGE) 0x0070)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_SET_PARAMETER_DEFAULT_VALUES = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SCANNER_IN_CRADLE ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SCANNER_IN_CRADLE = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SCANNER_IN_RANGE ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SCANNER_IN_RANGE = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_AIM_DURATION ((USAGE) 0x007A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_AIM_DURATION = ((ushort)(0x007A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_LAMP_DURATION ((USAGE) 0x007B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_LAMP_DURATION = ((ushort)(0x007B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_LAMP_INTENSITY ((USAGE) 0x007C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_LAMP_INTENSITY = ((ushort)(0x007C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_LED ((USAGE) 0x007D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_LED = ((ushort)(0x007D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_FREQUENCY ((USAGE) 0x007E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_FREQUENCY = ((ushort)(0x007E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_LENGTH ((USAGE) 0x007F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_LENGTH = ((ushort)(0x007F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_VOLUME ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_TONE_VOLUME = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_NO_READ_MESSAGE ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_NO_READ_MESSAGE = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_NOT_ON_FILE_VOLUME ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_NOT_ON_FILE_VOLUME = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_POWERUP_BEEP ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_POWERUP_BEEP = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SOUND_ERROR_BEEP ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SOUND_ERROR_BEEP = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SOUND_GOOD_READ_BEEP ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SOUND_GOOD_READ_BEEP = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SOUND_NOT_ON_FILE_BEEP ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SOUND_NOT_ON_FILE_BEEP = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GOOD_READ_WHEN_TO_WRITE ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GOOD_READ_WHEN_TO_WRITE = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_GRWTI_AFTER_DECODE ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_GRWTI_AFTER_DECODE = ((ushort)(0x0089));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_GRWTI_BEEPLAMP_AFTER_TRANSMIT ((USAGE) 0x008A)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_GRWTI_BEEPLAMP_AFTER_TRANSMIT = (
        (ushort)(0x008A)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_GRWTI_NO_BEEPLAMP_USE_AT_ALL ((USAGE) 0x008B)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_GRWTI_NO_BEEPLAMP_USE_AT_ALL = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BOOKLAND_EAN ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BOOKLAND_EAN = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CONVERT_EAN_8_TO_13_TYPE ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CONVERT_EAN_8_TO_13_TYPE = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CONVERT_UPC_A_TO_EAN13 ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CONVERT_UPC_A_TO_EAN13 = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CONVERT_UPCE_TO_A ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CONVERT_UPCE_TO_A = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN13 ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN13 = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN8 ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN8 = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN99_128_MANDATORY ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN99_128_MANDATORY = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN99_P5128_OPTIONAL ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN99_P5128_OPTIONAL = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ENABLE_EAN_TWO_LABEL ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ENABLE_EAN_TWO_LABEL = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCEAN ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCEAN = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCEAN_COUPON_CODE ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCEAN_COUPON_CODE = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCEAN_PERIODICALS ((USAGE) 0x009C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCEAN_PERIODICALS = ((ushort)(0x009C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCA ((USAGE) 0x009D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCA = ((ushort)(0x009D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCA_WITH_128_MANDATORY ((USAGE) 0x009E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCA_WITH_128_MANDATORY = ((ushort)(0x009E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCA_WITH_128_OPTIONAL ((USAGE) 0x009F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCA_WITH_128_OPTIONAL = ((ushort)(0x009F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCA_WITH_P5_OPTIONAL ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCA_WITH_P5_OPTIONAL = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCE ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCE = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UPCE1 ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UPCE1 = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PERIODICAL ((USAGE) 0x00A9)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL = ((ushort)(0x00A9));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_AUTODISCRIMINATE_2 ((USAGE) 0x00AA)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_AUTODISCRIMINATE_2 = (
        (ushort)(0x00AA)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_ONLY_DECODE_WITH_2 ((USAGE) 0x00AB)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_ONLY_DECODE_WITH_2 = (
        (ushort)(0x00AB)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_IGNORE_2 ((USAGE) 0x00AC)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_IGNORE_2 = ((ushort)(0x00AC));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_AUTODISCRIMINATE_5 ((USAGE) 0x00AD)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_AUTODISCRIMINATE_5 = (
        (ushort)(0x00AD)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_ONLY_DECODE_WITH_5 ((USAGE) 0x00AE)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_ONLY_DECODE_WITH_5 = (
        (ushort)(0x00AE)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PERIODICAL_IGNORE_5 ((USAGE) 0x00AF)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PERIODICAL_IGNORE_5 = ((ushort)(0x00AF));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CHECK ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CHECK_DISABLE_PRICE ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DISABLE_PRICE = ((ushort)(0x00B1));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_4_DIGIT_PRICE ((USAGE) 0x00B2)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_4_DIGIT_PRICE = ((ushort)(0x00B2));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_5_DIGIT_PRICE ((USAGE) 0x00B3)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_5_DIGIT_PRICE = ((ushort)(0x00B3));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_EUROPEAN_4_DIGIT_PRICE ((USAGE) 0x00B4)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_EUROPEAN_4_DIGIT_PRICE = (
        (ushort)(0x00B4)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_EUROPEAN_5_DIGIT_PRICE ((USAGE) 0x00B5)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_ENABLE_EUROPEAN_5_DIGIT_PRICE = (
        (ushort)(0x00B5)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_TWO_LABEL ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_TWO_LABEL = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_THREE_LABEL ((USAGE) 0x00B8)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_THREE_LABEL = ((ushort)(0x00B8));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_1 ((USAGE) 0x00B9)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_1 = ((ushort)(0x00B9));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_2 ((USAGE) 0x00BA)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_2 = ((ushort)(0x00BA));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_3 ((USAGE) 0x00BB)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_8_FLAG_DIGIT_3 = ((ushort)(0x00BB));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_1 ((USAGE) 0x00BC)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_1 = ((ushort)(0x00BC));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_2 ((USAGE) 0x00BD)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_2 = ((ushort)(0x00BD));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_3 ((USAGE) 0x00BE)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_EAN_13_FLAG_DIGIT_3 = ((ushort)(0x00BE));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_ADD_EAN_23_LABEL_DEFINITION ((USAGE) 0x00BF)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_ADD_EAN_23_LABEL_DEFINITION = ((ushort)(0x00BF));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CLEAR_ALL_EAN_23_LABEL_DEFINITIONS ((USAGE) 0x00C0)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CLEAR_ALL_EAN_23_LABEL_DEFINITIONS = (
        (ushort)(0x00C0)
    );

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODABAR ((USAGE) 0x00C3)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODABAR = ((ushort)(0x00C3));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_128 ((USAGE) 0x00C4)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_128 = ((ushort)(0x00C4));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_39 ((USAGE) 0x00C7)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_39 = ((ushort)(0x00C7));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_93 ((USAGE) 0x00C8)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_93 = ((ushort)(0x00C8));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_FULL_ASCII_CONVERSION ((USAGE) 0x00C9)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_FULL_ASCII_CONVERSION = ((ushort)(0x00C9));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_INTERLEAVED_2_OF_5 ((USAGE) 0x00CA)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_INTERLEAVED_2_OF_5 = ((ushort)(0x00CA));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ITALIAN_PHARMACY_CODE ((USAGE) 0x00CB)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ITALIAN_PHARMACY_CODE = ((ushort)(0x00CB));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MSIPLESSEY ((USAGE) 0x00CC)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MSIPLESSEY = ((ushort)(0x00CC));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5_IATA ((USAGE) 0x00CD)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5_IATA = ((ushort)(0x00CD));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5 ((USAGE) 0x00CE)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_STANDARD_2_OF_5 = ((ushort)(0x00CE));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRANSMIT_STARTSTOP ((USAGE) 0x00D3)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRANSMIT_STARTSTOP = ((ushort)(0x00D3));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRIOPTIC ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRIOPTIC = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_UCCEAN128 ((USAGE) 0x00D5)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_UCCEAN128 = ((ushort)(0x00D5));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT ((USAGE) 0x00D6)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT = ((ushort)(0x00D6));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_DISABLE ((USAGE) 0x00D7)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_DISABLE = ((ushort)(0x00D7));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_INTERLEAVED_2_OF_5_OPCC ((USAGE) 0x00D8)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_INTERLEAVED_2_OF_5_OPCC = (
        (ushort)(0x00D8)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_INTERLEAVED_2_OF_5_USS ((USAGE) 0x00D9)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_INTERLEAVED_2_OF_5_USS = (
        (ushort)(0x00D9)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_STANDARD_2_OF_5_OPCC ((USAGE) 0x00DA)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_STANDARD_2_OF_5_OPCC = (
        (ushort)(0x00DA)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_STANDARD_2_OF_5_USS ((USAGE) 0x00DB)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_STANDARD_2_OF_5_USS = (
        (ushort)(0x00DB)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_ONE_MSI_PLESSEY ((USAGE) 0x00DC)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_ONE_MSI_PLESSEY = (
        (ushort)(0x00DC)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_TWO_MSI_PLESSEY ((USAGE) 0x00DD)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_ENABLE_TWO_MSI_PLESSEY = (
        (ushort)(0x00DD)
    );

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_CODABAR_ENABLE ((USAGE) 0x00DE)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_CODABAR_ENABLE = ((ushort)(0x00DE));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_CODE_39_ENABLE ((USAGE) 0x00DF)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHECK_DIGIT_CODE_39_ENABLE = ((ushort)(0x00DF));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_TRANSMIT_CHECK_DIGIT ((USAGE) 0x00F0)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_TRANSMIT_CHECK_DIGIT = ((ushort)(0x00F0));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_DISABLE_CHECK_DIGIT_TRANSMIT ((USAGE) 0x00F1)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_DISABLE_CHECK_DIGIT_TRANSMIT = ((ushort)(0x00F1));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_ENABLE_CHECK_DIGIT_TRANSMIT ((USAGE) 0x00F2)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_ENABLE_CHECK_DIGIT_TRANSMIT = ((ushort)(0x00F2));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_1 ((USAGE) 0x00FB)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_1 = ((ushort)(0x00FB));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_2 ((USAGE) 0x00FC)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_2 = ((ushort)(0x00FC));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_3 ((USAGE) 0x00FD)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SYMBOLOGY_IDENTIFIER_3 = ((ushort)(0x00FD));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DECODED_DATA ((USAGE) 0x00FE)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DECODED_DATA = ((ushort)(0x00FE));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DECODE_DATA_CONTINUED ((USAGE) 0x00FF)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DECODE_DATA_CONTINUED = ((ushort)(0x00FF));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BAR_SPACE_DATA ((USAGE) 0x0100)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BAR_SPACE_DATA = ((ushort)(0x0100));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SCANNER_DATA_ACCURACY ((USAGE) 0x0101)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SCANNER_DATA_ACCURACY = ((ushort)(0x0101));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_RAW_DATA_POLARITY ((USAGE) 0x0102)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_RAW_DATA_POLARITY = ((ushort)(0x0102));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_POLARITY_INVERTED_BAR_CODE ((USAGE) 0x0103)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_POLARITY_INVERTED_BAR_CODE = ((ushort)(0x0103));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_POLARITY_NORMAL_BAR_CODE ((USAGE) 0x0104)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_POLARITY_NORMAL_BAR_CODE = ((ushort)(0x0104));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MINIMUM_LENGTH_TO_DECODE ((USAGE) 0x0106)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MINIMUM_LENGTH_TO_DECODE = ((ushort)(0x0106));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MAXIMUM_LENGTH_TO_DECODE ((USAGE) 0x0107)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MAXIMUM_LENGTH_TO_DECODE = ((ushort)(0x0107));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_DISCRETE_LENGTH_TO_DECODE_1 ((USAGE) 0x0108)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_DISCRETE_LENGTH_TO_DECODE_1 = ((ushort)(0x0108));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_DISCRETE_LENGTH_TO_DECODE_2 ((USAGE) 0x0109)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_DISCRETE_LENGTH_TO_DECODE_2 = ((ushort)(0x0109));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DATA_LENGTH_METHOD ((USAGE) 0x010A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DATA_LENGTH_METHOD = ((ushort)(0x010A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DL_METHOD_READ_ANY ((USAGE) 0x010B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DL_METHOD_READ_ANY = ((ushort)(0x010B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DL_METHOD_CHECK_IN_RANGE ((USAGE) 0x010C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DL_METHOD_CHECK_IN_RANGE = ((ushort)(0x010C));

    [NativeTypeName(
        "#define HID_USAGE_BARCODE_SCANNER_DL_METHOD_CHECK_FOR_DISCRETE ((USAGE) 0x010D)"
    )]
    public const ushort HID_USAGE_BARCODE_SCANNER_DL_METHOD_CHECK_FOR_DISCRETE = ((ushort)(0x010D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_AZTEC_CODE ((USAGE) 0x0110)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_AZTEC_CODE = ((ushort)(0x0110));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_BC412 ((USAGE) 0x0111)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_BC412 = ((ushort)(0x0111));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CHANNEL_CODE ((USAGE) 0x0112)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CHANNEL_CODE = ((ushort)(0x0112));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_16 ((USAGE) 0x0113)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_16 = ((ushort)(0x0113));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_32 ((USAGE) 0x0114)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_32 = ((ushort)(0x0114));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_49 ((USAGE) 0x0115)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_49 = ((ushort)(0x0115));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_CODE_ONE ((USAGE) 0x0116)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_CODE_ONE = ((ushort)(0x0116));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_COLORCODE ((USAGE) 0x0117)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_COLORCODE = ((ushort)(0x0117));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_DATA_MATRIX ((USAGE) 0x0118)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_DATA_MATRIX = ((ushort)(0x0118));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MAXICODE ((USAGE) 0x0119)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MAXICODE = ((ushort)(0x0119));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_MICROPDF ((USAGE) 0x011A)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_MICROPDF = ((ushort)(0x011A));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_PDF417 ((USAGE) 0x011B)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_PDF417 = ((ushort)(0x011B));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_POSICODE ((USAGE) 0x011C)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_POSICODE = ((ushort)(0x011C));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_QR_CODE ((USAGE) 0x011D)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_QR_CODE = ((ushort)(0x011D));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_SUPERCODE ((USAGE) 0x011E)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_SUPERCODE = ((ushort)(0x011E));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_ULTRACODE ((USAGE) 0x011F)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_ULTRACODE = ((ushort)(0x011F));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_USD5_SLUG_CODE ((USAGE) 0x0120)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_USD5_SLUG_CODE = ((ushort)(0x0120));

    [NativeTypeName("#define HID_USAGE_BARCODE_SCANNER_VERICODE ((USAGE) 0x0121)")]
    public const ushort HID_USAGE_BARCODE_SCANNER_VERICODE = ((ushort)(0x0121));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_BATTERY_MODE ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_BATTERY_MODE = ((ushort)(0x0001));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_BATTERY_STATUS ((USAGE) 0x0002)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_BATTERY_STATUS = ((ushort)(0x0002));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_ALARM_WARNING ((USAGE) 0x0003)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_ALARM_WARNING = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_MODE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_MODE = ((ushort)(0x0004));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_STATUS ((USAGE) 0x0005)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_STATUS = ((ushort)(0x0005));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_SPEC_INFO ((USAGE) 0x0006)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_CHARGER_SPEC_INFO = (
        (ushort)(0x0006)
    );

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_STATE ((USAGE) 0x0007)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_STATE = ((ushort)(0x0007));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_PRESETS ((USAGE) 0x0008)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_PRESETS = (
        (ushort)(0x0008)
    );

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_INFO ((USAGE) 0x0009)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_SELECTOR_INFO = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_1 ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_1 = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_2 ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_2 = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_3 ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_3 = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_4 ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_4 = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_5 ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OPTIONAL_MFG_FUNCTION_5 = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CONNECTION_TO_SM_BUS ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CONNECTION_TO_SM_BUS = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OUTPUT_CONNECTION ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OUTPUT_CONNECTION = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGER_CONNECTION ((USAGE) 0x0017)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGER_CONNECTION = ((ushort)(0x0017));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_BATTERY_INSERTION ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BATTERY_INSERTION = ((ushort)(0x0018));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_USE_NEXT ((USAGE) 0x0019)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_USE_NEXT = ((ushort)(0x0019));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_OK_TO_USE ((USAGE) 0x001A)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_OK_TO_USE = ((ushort)(0x001A));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_BATTERY_SUPPORTED ((USAGE) 0x001B)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BATTERY_SUPPORTED = ((ushort)(0x001B));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SELECTOR_REVISION ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SELECTOR_REVISION = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGING_INDICATOR ((USAGE) 0x001D)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGING_INDICATOR = ((ushort)(0x001D));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_MANUFACTURER_ACCESS ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_MANUFACTURER_ACCESS = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_REMAINING_CAPACITY_LIMIT ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_REMAINING_CAPACITY_LIMIT = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_REMAINING_TIME_LIMIT ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_REMAINING_TIME_LIMIT = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AT_RATE ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AT_RATE = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CAPACITY_MODE ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CAPACITY_MODE = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_BROADCAST_TO_CHARGER ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BROADCAST_TO_CHARGER = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_PRIMARY_BATTERY ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_PRIMARY_BATTERY = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGE_CONTROLLER ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGE_CONTROLLER = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_TERMINATE_CHARGE ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_TERMINATE_CHARGE = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_TERMINATE_DISCHARGE ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_TERMINATE_DISCHARGE = ((ushort)(0x0041));

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_BELOW_REMAINING_CAPACITY_LIMIT ((USAGE) 0x0042)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BELOW_REMAINING_CAPACITY_LIMIT = (
        (ushort)(0x0042)
    );

    [NativeTypeName(
        "#define HID_USAGE_BATTERY_SYSTEM_REMAINING_TIME_LIMIT_EXPIRED ((USAGE) 0x0043)"
    )]
    public const ushort HID_USAGE_BATTERY_SYSTEM_REMAINING_TIME_LIMIT_EXPIRED = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGING ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGING = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_DISCHARGING ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_DISCHARGING = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_FULLY_CHARGED ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_FULLY_CHARGED = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_FULLY_DISCHARGED ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_FULLY_DISCHARGED = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CONDITIONING_FLAG ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CONDITIONING_FLAG = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AT_RATE_OK ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AT_RATE_OK = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_ERROR_CODE ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SMART_BATTERY_ERROR_CODE = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_NEED_REPLACEMENT ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_NEED_REPLACEMENT = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AT_RATE_TIME_TO_FULL ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AT_RATE_TIME_TO_FULL = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AT_RATE_TIME_TO_EMPTY ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AT_RATE_TIME_TO_EMPTY = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AVERAGE_CURRENT ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AVERAGE_CURRENT = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_MAX_ERROR ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_MAX_ERROR = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_RELATIVE_STATE_OF_CHARGE ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_RELATIVE_STATE_OF_CHARGE = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_ABSOLUTE_STATE_OF_CHARGE ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_ABSOLUTE_STATE_OF_CHARGE = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_REMAINING_CAPACITY ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_REMAINING_CAPACITY = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_FULL_CHARGE_CAPACITY ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_FULL_CHARGE_CAPACITY = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_RUN_TIME_TO_EMPTY ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_RUN_TIME_TO_EMPTY = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AVERAGE_TIME_TO_EMPTY ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AVERAGE_TIME_TO_EMPTY = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AVERAGE_TIME_TO_FULL ((USAGE) 0x006A)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AVERAGE_TIME_TO_FULL = ((ushort)(0x006A));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CYCLE_COUNT ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CYCLE_COUNT = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_BATTERY_PACK_MODEL_LEVEL ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BATTERY_PACK_MODEL_LEVEL = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_INTERNAL_CHARGE_CONTROLLER ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_INTERNAL_CHARGE_CONTROLLER = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_PRIMARY_BATTERY_SUPPORT ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_PRIMARY_BATTERY_SUPPORT = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_DESIGN_CAPACITY ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_DESIGN_CAPACITY = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SPECIFICATION_INFO ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SPECIFICATION_INFO = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_MANUFACTURE_DATE ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_MANUFACTURE_DATE = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_SERIAL_NUMBER ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_SERIAL_NUMBER = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_IMANUFACTURER_NAME ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_IMANUFACTURER_NAME = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_IDEVICE_NAME ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_IDEVICE_NAME = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_IDEVICE_CHEMISTRY ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_IDEVICE_CHEMISTRY = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_MANUFACTURER_DATA ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_MANUFACTURER_DATA = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_RECHARGABLE ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_RECHARGABLE = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_WARNING_CAPACITY_LIMIT ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_WARNING_CAPACITY_LIMIT = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CAPACITY_GRANULARITY_1 ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CAPACITY_GRANULARITY_1 = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CAPACITY_GRANULARITY_2 ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CAPACITY_GRANULARITY_2 = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_IOEM_INFORMATION ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_IOEM_INFORMATION = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_INHIBIT_CHARGE ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_INHIBIT_CHARGE = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_ENABLE_POLLING ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_ENABLE_POLLING = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_RESET_TO_ZERO ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_RESET_TO_ZERO = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_AC_PRESENT ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_AC_PRESENT = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_BATTERY_PRESENT ((USAGE) 0x00D1)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_BATTERY_PRESENT = ((ushort)(0x00D1));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_POWER_FAIL ((USAGE) 0x00D2)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_POWER_FAIL = ((ushort)(0x00D2));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_ALARM_INHIBITED ((USAGE) 0x00D3)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_ALARM_INHIBITED = ((ushort)(0x00D3));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_THERMISTOR_UNDER_RANGE ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_THERMISTOR_UNDER_RANGE = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_THERMISTOR_HOT ((USAGE) 0x00D5)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_THERMISTOR_HOT = ((ushort)(0x00D5));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_THERMISTOR_COLD ((USAGE) 0x00D6)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_THERMISTOR_COLD = ((ushort)(0x00D6));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_THERMISTOR_OVER_RANGE ((USAGE) 0x00D7)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_THERMISTOR_OVER_RANGE = ((ushort)(0x00D7));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_VOLTAGE_OUT_OF_RANGE ((USAGE) 0x00D8)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_VOLTAGE_OUT_OF_RANGE = ((ushort)(0x00D8));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CURRENT_OUT_OF_RANGE ((USAGE) 0x00D9)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CURRENT_OUT_OF_RANGE = ((ushort)(0x00D9));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CURRENT_NOT_REGULATED ((USAGE) 0x00DA)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CURRENT_NOT_REGULATED = ((ushort)(0x00DA));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_VOLTAGE_NOT_REGULATED ((USAGE) 0x00DB)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_VOLTAGE_NOT_REGULATED = ((ushort)(0x00DB));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_MASTER_MODE ((USAGE) 0x00DC)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_MASTER_MODE = ((ushort)(0x00DC));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGER_SELECTOR_SUPPORT ((USAGE) 0x00F0)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGER_SELECTOR_SUPPORT = ((ushort)(0x00F0));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_CHARGER_SPEC ((USAGE) 0x00F1)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_CHARGER_SPEC = ((ushort)(0x00F1));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_LEVEL_2 ((USAGE) 0x00F2)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_LEVEL_2 = ((ushort)(0x00F2));

    [NativeTypeName("#define HID_USAGE_BATTERY_SYSTEM_LEVEL_3 ((USAGE) 0x00F3)")]
    public const ushort HID_USAGE_BATTERY_SYSTEM_LEVEL_3 = ((ushort)(0x00F3));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DISPLAY ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DISPLAY = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROW ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROW = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_8_DOT_BRAILLE_CELL ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_8_DOT_BRAILLE_CELL = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_6_DOT_BRAILLE_CELL ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_6_DOT_BRAILLE_CELL = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_NUMBER_OF_BRAILLE_CELLS ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_NUMBER_OF_BRAILLE_CELLS = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_SCREEN_READER_CONTROL ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_SCREEN_READER_CONTROL = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_SCREEN_READER_IDENTIFIER ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_SCREEN_READER_IDENTIFIER = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_1 ((USAGE) 0x00FA)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_1 = ((ushort)(0x00FA));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_2 ((USAGE) 0x00FB)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_2 = ((ushort)(0x00FB));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_3 ((USAGE) 0x00FC)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_ROUTER_SET_3 = ((ushort)(0x00FC));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_ROUTER_KEY ((USAGE) 0x0100)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_ROUTER_KEY = ((ushort)(0x0100));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_ROW_ROUTER_KEY ((USAGE) 0x0101)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_ROW_ROUTER_KEY = ((ushort)(0x0101));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_BUTTONS ((USAGE) 0x0200)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_BUTTONS = ((ushort)(0x0200));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_1 ((USAGE) 0x0201)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_1 = ((ushort)(0x0201));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_2 ((USAGE) 0x0202)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_2 = ((ushort)(0x0202));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_3 ((USAGE) 0x0203)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_3 = ((ushort)(0x0203));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_4 ((USAGE) 0x0204)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_4 = ((ushort)(0x0204));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_5 ((USAGE) 0x0205)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_5 = ((ushort)(0x0205));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_6 ((USAGE) 0x0206)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_6 = ((ushort)(0x0206));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_7 ((USAGE) 0x0207)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_7 = ((ushort)(0x0207));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_8 ((USAGE) 0x0208)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_DOT_8 = ((ushort)(0x0208));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_SPACE ((USAGE) 0x0209)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_SPACE = ((ushort)(0x0209));

    [NativeTypeName(
        "#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_LEFT_SPACE ((USAGE) 0x020A)"
    )]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_LEFT_SPACE = ((ushort)(0x020A));

    [NativeTypeName(
        "#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_RIGHT_SPACE ((USAGE) 0x020B)"
    )]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_KEYBOARD_RIGHT_SPACE = ((ushort)(0x020B));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_FACE_CONTROLS ((USAGE) 0x020C)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_FACE_CONTROLS = ((ushort)(0x020C));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_LEFT_CONTROLS ((USAGE) 0x020D)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_LEFT_CONTROLS = ((ushort)(0x020D));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_RIGHT_CONTROLS ((USAGE) 0x020E)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_RIGHT_CONTROLS = ((ushort)(0x020E));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_TOP_CONTROLS ((USAGE) 0x020F)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_TOP_CONTROLS = ((ushort)(0x020F));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_CENTER ((USAGE) 0x0210)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_CENTER = ((ushort)(0x0210));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_UP ((USAGE) 0x0211)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_UP = ((ushort)(0x0211));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_DOWN ((USAGE) 0x0212)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_DOWN = ((ushort)(0x0212));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_LEFT ((USAGE) 0x0213)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_LEFT = ((ushort)(0x0213));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_RIGHT ((USAGE) 0x0214)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_JOYSTICK_RIGHT = ((ushort)(0x0214));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_CENTER ((USAGE) 0x0215)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_CENTER = ((ushort)(0x0215));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_UP ((USAGE) 0x0216)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_UP = ((ushort)(0x0216));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_DOWN ((USAGE) 0x0217)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_DOWN = ((ushort)(0x0217));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_LEFT ((USAGE) 0x0218)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_LEFT = ((ushort)(0x0218));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_RIGHT ((USAGE) 0x0219)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_DPAD_RIGHT = ((ushort)(0x0219));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_PAN_LEFT ((USAGE) 0x021A)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_PAN_LEFT = ((ushort)(0x021A));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_PAN_RIGHT ((USAGE) 0x021B)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_PAN_RIGHT = ((ushort)(0x021B));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_UP ((USAGE) 0x021C)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_UP = ((ushort)(0x021C));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_DOWN ((USAGE) 0x021D)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_DOWN = ((ushort)(0x021D));

    [NativeTypeName("#define HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_PRESS ((USAGE) 0x021E)")]
    public const ushort HID_USAGE_BRAILLE_DISPLAY_BRAILLE_ROCKER_PRESS = ((ushort)(0x021E));

    [NativeTypeName("#define HID_USAGE_CAMERA_AUTO_FOCUS ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_CAMERA_AUTO_FOCUS = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_CAMERA_SHUTTER ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_CAMERA_SHUTTER = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_CONSUMERCTRL ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_CONSUMERCTRL = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_CONSUMER_NUMERIC_KEY_PAD ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_CONSUMER_NUMERIC_KEY_PAD = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PROGRAMMABLE_BUTTONS ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_CONSUMER_PROGRAMMABLE_BUTTONS = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MICROPHONE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_CONSUMER_MICROPHONE = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_CONSUMER_HEADPHONE ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_CONSUMER_HEADPHONE = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GRAPHIC_EQUALIZER ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_CONSUMER_GRAPHIC_EQUALIZER = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_CONSUMER_10 ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_CONSUMER_10 = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_CONSUMER_100 ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_CONSUMER_100 = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AMPM ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_CONSUMER_AMPM = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_CONSUMER_POWER ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_CONSUMER_POWER = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RESET ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_CONSUMER_RESET = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SLEEP ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_CONSUMER_SLEEP = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SLEEP_AFTER ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_CONSUMER_SLEEP_AFTER = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SLEEP_MODE ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_CONSUMER_SLEEP_MODE = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ILLUMINATION ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_CONSUMER_ILLUMINATION = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FUNCTION_BUTTONS ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_CONSUMER_FUNCTION_BUTTONS = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_CONSUMER_MENU = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_PICK ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_CONSUMER_MENU_PICK = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_UP ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_CONSUMER_MENU_UP = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_DOWN ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_CONSUMER_MENU_DOWN = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_LEFT ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_CONSUMER_MENU_LEFT = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_RIGHT ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_CONSUMER_MENU_RIGHT = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_ESCAPE ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_CONSUMER_MENU_ESCAPE = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_VALUE_INCREASE ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_CONSUMER_MENU_VALUE_INCREASE = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MENU_VALUE_DECREASE ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_CONSUMER_MENU_VALUE_DECREASE = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DATA_ON_SCREEN ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_CONSUMER_DATA_ON_SCREEN = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CLOSED_CAPTION ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_CONSUMER_CLOSED_CAPTION = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CLOSED_CAPTION_SELECT ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_CONSUMER_CLOSED_CAPTION_SELECT = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VCRTV ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_CONSUMER_VCRTV = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BROADCAST_MODE ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_CONSUMER_BROADCAST_MODE = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SNAPSHOT ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_CONSUMER_SNAPSHOT = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_CONSUMER_STILL ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_CONSUMER_STILL = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PICTUREINPICTURE_TOGGLE ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_CONSUMER_PICTUREINPICTURE_TOGGLE = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PICTUREINPICTURE_SWAP ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_CONSUMER_PICTUREINPICTURE_SWAP = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RED_MENU_BUTTON ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_CONSUMER_RED_MENU_BUTTON = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GREEN_MENU_BUTTON ((USAGE) 0x006A)")]
    public const ushort HID_USAGE_CONSUMER_GREEN_MENU_BUTTON = ((ushort)(0x006A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BLUE_MENU_BUTTON ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_CONSUMER_BLUE_MENU_BUTTON = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_YELLOW_MENU_BUTTON ((USAGE) 0x006C)")]
    public const ushort HID_USAGE_CONSUMER_YELLOW_MENU_BUTTON = ((ushort)(0x006C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ASPECT ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_CONSUMER_ASPECT = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_3D_MODE_SELECT ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_CONSUMER_3D_MODE_SELECT = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS_INCREMENT ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS_INCREMENT = ((ushort)(0x006F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS_DECREMENT ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS_DECREMENT = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_BRIGHTNESS = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DISPLAY_BACKLIGHT_TOGGLE ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_BACKLIGHT_TOGGLE = ((ushort)(0x0072));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_DISPLAY_SET_BRIGHTNESS_TO_MINIMUM ((USAGE) 0x0073)"
    )]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_SET_BRIGHTNESS_TO_MINIMUM = ((ushort)(0x0073));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_DISPLAY_SET_BRIGHTNESS_TO_MAXIMUM ((USAGE) 0x0074)"
    )]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_SET_BRIGHTNESS_TO_MAXIMUM = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DISPLAY_SET_AUTO_BRIGHTNESS ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_CONSUMER_DISPLAY_SET_AUTO_BRIGHTNESS = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CAMERA_ACCESS_ENABLED ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_CONSUMER_CAMERA_ACCESS_ENABLED = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CAMERA_ACCESS_DISABLED ((USAGE) 0x0077)")]
    public const ushort HID_USAGE_CONSUMER_CAMERA_ACCESS_DISABLED = ((ushort)(0x0077));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CAMERA_ACCESS_TOGGLE ((USAGE) 0x0078)")]
    public const ushort HID_USAGE_CONSUMER_CAMERA_ACCESS_TOGGLE = ((ushort)(0x0078));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BRIGHTNESS_INCREMENT ((USAGE) 0x0079)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BRIGHTNESS_INCREMENT = ((ushort)(0x0079));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BRIGHTNESS_DECREMENT ((USAGE) 0x007A)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BRIGHTNESS_DECREMENT = ((ushort)(0x007A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_LEVEL ((USAGE) 0x007B)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_LEVEL = ((ushort)(0x007B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_OOC ((USAGE) 0x007C)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_OOC = ((ushort)(0x007C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_MINIMUM ((USAGE) 0x007D)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_MINIMUM = ((ushort)(0x007D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_MAXIMUM ((USAGE) 0x007E)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_SET_MAXIMUM = ((ushort)(0x007E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_AUTO ((USAGE) 0x007F)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_BACKLIGHT_AUTO = ((ushort)(0x007F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SELECTION ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_CONSUMER_SELECTION = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ASSIGN_SELECTION ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_CONSUMER_ASSIGN_SELECTION = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MODE_STEP ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_CONSUMER_MODE_STEP = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RECALL_LAST ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_CONSUMER_RECALL_LAST = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ENTER_CHANNEL ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_CONSUMER_ENTER_CHANNEL = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ORDER_MOVIE ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_CONSUMER_ORDER_MOVIE = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECTION ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECTION = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_COMPUTER ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_COMPUTER = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_TV ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_TV = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_WWW ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_WWW = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_DVD ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_DVD = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_TELEPHONE ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_TELEPHONE = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_PROGRAM_GUIDE ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_PROGRAM_GUIDE = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_VIDEO_PHONE ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_VIDEO_PHONE = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_GAMES ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_GAMES = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_MESSAGES ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_MESSAGES = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_CD ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_CD = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_VCR ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_VCR = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_TUNER ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_TUNER = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_CONSUMER_QUIT ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_CONSUMER_QUIT = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_CONSUMER_HELP ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_CONSUMER_HELP = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_TAPE ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_TAPE = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_CABLE ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_CABLE = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_SATELLITE ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_SATELLITE = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_SECURITY ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_SECURITY = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_HOME ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_HOME = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_CALL ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_CALL = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_INCREMENT ((USAGE) 0x009C)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_INCREMENT = ((ushort)(0x009C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_DECREMENT ((USAGE) 0x009D)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_DECREMENT = ((ushort)(0x009D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDIA_SELECT_SAP ((USAGE) 0x009E)")]
    public const ushort HID_USAGE_CONSUMER_MEDIA_SELECT_SAP = ((ushort)(0x009E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VCR_PLUS ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_CONSUMER_VCR_PLUS = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ONCE ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_CONSUMER_ONCE = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DAILY ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_CONSUMER_DAILY = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_WEEKLY ((USAGE) 0x00A3)")]
    public const ushort HID_USAGE_CONSUMER_WEEKLY = ((ushort)(0x00A3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MONTHLY ((USAGE) 0x00A4)")]
    public const ushort HID_USAGE_CONSUMER_MONTHLY = ((ushort)(0x00A4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAY ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_CONSUMER_PLAY = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PAUSE ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_CONSUMER_PAUSE = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RECORD ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_CONSUMER_RECORD = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FAST_FORWARD ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_CONSUMER_FAST_FORWARD = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_REWIND ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_CONSUMER_REWIND = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SCAN_NEXT_TRACK ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_CONSUMER_SCAN_NEXT_TRACK = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SCAN_PREV_TRACK ((USAGE) 0x00B6)")]
    public const ushort HID_USAGE_CONSUMER_SCAN_PREV_TRACK = ((ushort)(0x00B6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_STOP ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_CONSUMER_STOP = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_EJECT ((USAGE) 0x00B8)")]
    public const ushort HID_USAGE_CONSUMER_EJECT = ((ushort)(0x00B8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RANDOM_PLAY ((USAGE) 0x00B9)")]
    public const ushort HID_USAGE_CONSUMER_RANDOM_PLAY = ((ushort)(0x00B9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SELECT_DISC ((USAGE) 0x00BA)")]
    public const ushort HID_USAGE_CONSUMER_SELECT_DISC = ((ushort)(0x00BA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ENTER_DISC ((USAGE) 0x00BB)")]
    public const ushort HID_USAGE_CONSUMER_ENTER_DISC = ((ushort)(0x00BB));

    [NativeTypeName("#define HID_USAGE_CONSUMER_REPEAT ((USAGE) 0x00BC)")]
    public const ushort HID_USAGE_CONSUMER_REPEAT = ((ushort)(0x00BC));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TRACKING ((USAGE) 0x00BD)")]
    public const ushort HID_USAGE_CONSUMER_TRACKING = ((ushort)(0x00BD));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TRACK_NORMAL ((USAGE) 0x00BE)")]
    public const ushort HID_USAGE_CONSUMER_TRACK_NORMAL = ((ushort)(0x00BE));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SLOW_TRACKING ((USAGE) 0x00BF)")]
    public const ushort HID_USAGE_CONSUMER_SLOW_TRACKING = ((ushort)(0x00BF));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FRAME_FORWARD ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_CONSUMER_FRAME_FORWARD = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FRAME_BACK ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_CONSUMER_FRAME_BACK = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MARK ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_CONSUMER_MARK = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CLEAR_MARK ((USAGE) 0x00C3)")]
    public const ushort HID_USAGE_CONSUMER_CLEAR_MARK = ((ushort)(0x00C3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_REPEAT_FROM_MARK ((USAGE) 0x00C4)")]
    public const ushort HID_USAGE_CONSUMER_REPEAT_FROM_MARK = ((ushort)(0x00C4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_RETURN_TO_MARK ((USAGE) 0x00C5)")]
    public const ushort HID_USAGE_CONSUMER_RETURN_TO_MARK = ((ushort)(0x00C5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SEARCH_MARK_FORWARD ((USAGE) 0x00C6)")]
    public const ushort HID_USAGE_CONSUMER_SEARCH_MARK_FORWARD = ((ushort)(0x00C6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SEARCH_MARK_BACKWARDS ((USAGE) 0x00C7)")]
    public const ushort HID_USAGE_CONSUMER_SEARCH_MARK_BACKWARDS = ((ushort)(0x00C7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_COUNTER_RESET ((USAGE) 0x00C8)")]
    public const ushort HID_USAGE_CONSUMER_COUNTER_RESET = ((ushort)(0x00C8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SHOW_COUNTER ((USAGE) 0x00C9)")]
    public const ushort HID_USAGE_CONSUMER_SHOW_COUNTER = ((ushort)(0x00C9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TRACKING_INCREMENT ((USAGE) 0x00CA)")]
    public const ushort HID_USAGE_CONSUMER_TRACKING_INCREMENT = ((ushort)(0x00CA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TRACKING_DECREMENT ((USAGE) 0x00CB)")]
    public const ushort HID_USAGE_CONSUMER_TRACKING_DECREMENT = ((ushort)(0x00CB));

    [NativeTypeName("#define HID_USAGE_CONSUMER_STOPEJECT ((USAGE) 0x00CC)")]
    public const ushort HID_USAGE_CONSUMER_STOPEJECT = ((ushort)(0x00CC));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAY_PAUSE ((USAGE) 0x00CD)")]
    public const ushort HID_USAGE_CONSUMER_PLAY_PAUSE = ((ushort)(0x00CD));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAYSKIP ((USAGE) 0x00CE)")]
    public const ushort HID_USAGE_CONSUMER_PLAYSKIP = ((ushort)(0x00CE));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOICE_COMMAND ((USAGE) 0x00CF)")]
    public const ushort HID_USAGE_CONSUMER_VOICE_COMMAND = ((ushort)(0x00CF));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD ((USAGE) 0x00D1)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD = ((ushort)(0x00D1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP ((USAGE) 0x00D2)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP = ((ushort)(0x00D2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT ((USAGE) 0x00D3)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT = ((ushort)(0x00D3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE ((USAGE) 0x00D5)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE = ((ushort)(0x00D5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA ((USAGE) 0x00D6)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA = ((ushort)(0x00D6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST ((USAGE) 0x00D7)")]
    public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST = ((ushort)(0x00D7));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_START_OR_STOP_VOICE_DICTATION_SESSION ((USAGE) 0x00D8)"
    )]
    public const ushort HID_USAGE_CONSUMER_START_OR_STOP_VOICE_DICTATION_SESSION = (
        (ushort)(0x00D8)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_INVOKEDISMISS_EMOJI_PICKER ((USAGE) 0x00D9)")]
    public const ushort HID_USAGE_CONSUMER_INVOKEDISMISS_EMOJI_PICKER = ((ushort)(0x00D9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME ((USAGE) 0x00E0)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME = ((ushort)(0x00E0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BALANCE ((USAGE) 0x00E1)")]
    public const ushort HID_USAGE_CONSUMER_BALANCE = ((ushort)(0x00E1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MUTE ((USAGE) 0x00E2)")]
    public const ushort HID_USAGE_CONSUMER_MUTE = ((ushort)(0x00E2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS ((USAGE) 0x00E3)")]
    public const ushort HID_USAGE_CONSUMER_BASS = ((ushort)(0x00E3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE ((USAGE) 0x00E4)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE = ((ushort)(0x00E4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_BOOST ((USAGE) 0x00E5)")]
    public const ushort HID_USAGE_CONSUMER_BASS_BOOST = ((ushort)(0x00E5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SURROUND_MODE ((USAGE) 0x00E6)")]
    public const ushort HID_USAGE_CONSUMER_SURROUND_MODE = ((ushort)(0x00E6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_LOUDNESS ((USAGE) 0x00E7)")]
    public const ushort HID_USAGE_CONSUMER_LOUDNESS = ((ushort)(0x00E7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MPX ((USAGE) 0x00E8)")]
    public const ushort HID_USAGE_CONSUMER_MPX = ((ushort)(0x00E8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME_INCREMENT ((USAGE) 0x00E9)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME_INCREMENT = ((ushort)(0x00E9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_VOLUME_DECREMENT ((USAGE) 0x00EA)")]
    public const ushort HID_USAGE_CONSUMER_VOLUME_DECREMENT = ((ushort)(0x00EA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SPEED_SELECT ((USAGE) 0x00F0)")]
    public const ushort HID_USAGE_CONSUMER_SPEED_SELECT = ((ushort)(0x00F0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PLAYBACK_SPEED ((USAGE) 0x00F1)")]
    public const ushort HID_USAGE_CONSUMER_PLAYBACK_SPEED = ((ushort)(0x00F1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_STANDARD_PLAY ((USAGE) 0x00F2)")]
    public const ushort HID_USAGE_CONSUMER_STANDARD_PLAY = ((ushort)(0x00F2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_LONG_PLAY ((USAGE) 0x00F3)")]
    public const ushort HID_USAGE_CONSUMER_LONG_PLAY = ((ushort)(0x00F3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_EXTENDED_PLAY ((USAGE) 0x00F4)")]
    public const ushort HID_USAGE_CONSUMER_EXTENDED_PLAY = ((ushort)(0x00F4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SLOW ((USAGE) 0x00F5)")]
    public const ushort HID_USAGE_CONSUMER_SLOW = ((ushort)(0x00F5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FAN_ENABLE ((USAGE) 0x0100)")]
    public const ushort HID_USAGE_CONSUMER_FAN_ENABLE = ((ushort)(0x0100));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FAN_SPEED ((USAGE) 0x0101)")]
    public const ushort HID_USAGE_CONSUMER_FAN_SPEED = ((ushort)(0x0101));

    [NativeTypeName("#define HID_USAGE_CONSUMER_LIGHT_ENABLE ((USAGE) 0x0102)")]
    public const ushort HID_USAGE_CONSUMER_LIGHT_ENABLE = ((ushort)(0x0102));

    [NativeTypeName("#define HID_USAGE_CONSUMER_LIGHT_ILLUMINATION_LEVEL ((USAGE) 0x0103)")]
    public const ushort HID_USAGE_CONSUMER_LIGHT_ILLUMINATION_LEVEL = ((ushort)(0x0103));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CLIMATE_CONTROL_ENABLE ((USAGE) 0x0104)")]
    public const ushort HID_USAGE_CONSUMER_CLIMATE_CONTROL_ENABLE = ((ushort)(0x0104));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ROOM_TEMPERATURE ((USAGE) 0x0105)")]
    public const ushort HID_USAGE_CONSUMER_ROOM_TEMPERATURE = ((ushort)(0x0105));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SECURITY_ENABLE ((USAGE) 0x0106)")]
    public const ushort HID_USAGE_CONSUMER_SECURITY_ENABLE = ((ushort)(0x0106));

    [NativeTypeName("#define HID_USAGE_CONSUMER_FIRE_ALARM ((USAGE) 0x0107)")]
    public const ushort HID_USAGE_CONSUMER_FIRE_ALARM = ((ushort)(0x0107));

    [NativeTypeName("#define HID_USAGE_CONSUMER_POLICE_ALARM ((USAGE) 0x0108)")]
    public const ushort HID_USAGE_CONSUMER_POLICE_ALARM = ((ushort)(0x0108));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PROXIMITY ((USAGE) 0x0109)")]
    public const ushort HID_USAGE_CONSUMER_PROXIMITY = ((ushort)(0x0109));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MOTION ((USAGE) 0x010A)")]
    public const ushort HID_USAGE_CONSUMER_MOTION = ((ushort)(0x010A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_DURESS_ALARM ((USAGE) 0x010B)")]
    public const ushort HID_USAGE_CONSUMER_DURESS_ALARM = ((ushort)(0x010B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_HOLDUP_ALARM ((USAGE) 0x010C)")]
    public const ushort HID_USAGE_CONSUMER_HOLDUP_ALARM = ((ushort)(0x010C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_MEDICAL_ALARM ((USAGE) 0x010D)")]
    public const ushort HID_USAGE_CONSUMER_MEDICAL_ALARM = ((ushort)(0x010D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BALANCE_RIGHT ((USAGE) 0x0150)")]
    public const ushort HID_USAGE_CONSUMER_BALANCE_RIGHT = ((ushort)(0x0150));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BALANCE_LEFT ((USAGE) 0x0151)")]
    public const ushort HID_USAGE_CONSUMER_BALANCE_LEFT = ((ushort)(0x0151));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_INCREMENT ((USAGE) 0x0152)")]
    public const ushort HID_USAGE_CONSUMER_BASS_INCREMENT = ((ushort)(0x0152));

    [NativeTypeName("#define HID_USAGE_CONSUMER_BASS_DECREMENT ((USAGE) 0x0153)")]
    public const ushort HID_USAGE_CONSUMER_BASS_DECREMENT = ((ushort)(0x0153));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE_INCREMENT ((USAGE) 0x0154)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE_INCREMENT = ((ushort)(0x0154));

    [NativeTypeName("#define HID_USAGE_CONSUMER_TREBLE_DECREMENT ((USAGE) 0x0155)")]
    public const ushort HID_USAGE_CONSUMER_TREBLE_DECREMENT = ((ushort)(0x0155));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SPEAKER_SYSTEM ((USAGE) 0x0160)")]
    public const ushort HID_USAGE_CONSUMER_SPEAKER_SYSTEM = ((ushort)(0x0160));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_LEFT ((USAGE) 0x0161)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_LEFT = ((ushort)(0x0161));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_RIGHT ((USAGE) 0x0162)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_RIGHT = ((ushort)(0x0162));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_CENTER ((USAGE) 0x0163)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_CENTER = ((ushort)(0x0163));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_FRONT ((USAGE) 0x0164)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_FRONT = ((ushort)(0x0164));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_CENTER_FRONT ((USAGE) 0x0165)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_CENTER_FRONT = ((ushort)(0x0165));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_SIDE ((USAGE) 0x0166)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_SIDE = ((ushort)(0x0166));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_SURROUND ((USAGE) 0x0167)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_SURROUND = ((ushort)(0x0167));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_CHANNEL_LOW_FREQUENCY_ENHANCEMENT ((USAGE) 0x0168)"
    )]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_LOW_FREQUENCY_ENHANCEMENT = ((ushort)(0x0168));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_TOP ((USAGE) 0x0169)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_TOP = ((ushort)(0x0169));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CHANNEL_UNKNOWN ((USAGE) 0x016A)")]
    public const ushort HID_USAGE_CONSUMER_CHANNEL_UNKNOWN = ((ushort)(0x016A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SUBCHANNEL ((USAGE) 0x0170)")]
    public const ushort HID_USAGE_CONSUMER_SUBCHANNEL = ((ushort)(0x0170));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SUBCHANNEL_INCREMENT ((USAGE) 0x0171)")]
    public const ushort HID_USAGE_CONSUMER_SUBCHANNEL_INCREMENT = ((ushort)(0x0171));

    [NativeTypeName("#define HID_USAGE_CONSUMER_SUBCHANNEL_DECREMENT ((USAGE) 0x0172)")]
    public const ushort HID_USAGE_CONSUMER_SUBCHANNEL_DECREMENT = ((ushort)(0x0172));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ALTERNATE_AUDIO_INCREMENT ((USAGE) 0x0173)")]
    public const ushort HID_USAGE_CONSUMER_ALTERNATE_AUDIO_INCREMENT = ((ushort)(0x0173));

    [NativeTypeName("#define HID_USAGE_CONSUMER_ALTERNATE_AUDIO_DECREMENT ((USAGE) 0x0174)")]
    public const ushort HID_USAGE_CONSUMER_ALTERNATE_AUDIO_DECREMENT = ((ushort)(0x0174));

    [NativeTypeName("#define HID_USAGE_CONSUMER_APPLICATION_LAUNCH_BUTTONS ((USAGE) 0x0180)")]
    public const ushort HID_USAGE_CONSUMER_APPLICATION_LAUNCH_BUTTONS = ((ushort)(0x0180));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_LAUNCH_BUTTON_CONFIGURATION_TOOL ((USAGE) 0x0181)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_LAUNCH_BUTTON_CONFIGURATION_TOOL = ((ushort)(0x0181));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_PROGRAMMABLE_BUTTON_CONFIGURATION ((USAGE) 0x0182)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_PROGRAMMABLE_BUTTON_CONFIGURATION = (
        (ushort)(0x0182)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CONFIGURATION ((USAGE) 0x0183)")]
    public const ushort HID_USAGE_CONSUMER_AL_CONFIGURATION = ((ushort)(0x0183));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_WORD_PROCESSOR ((USAGE) 0x0184)")]
    public const ushort HID_USAGE_CONSUMER_AL_WORD_PROCESSOR = ((ushort)(0x0184));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_TEXT_EDITOR ((USAGE) 0x0185)")]
    public const ushort HID_USAGE_CONSUMER_AL_TEXT_EDITOR = ((ushort)(0x0185));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SPREADSHEET ((USAGE) 0x0186)")]
    public const ushort HID_USAGE_CONSUMER_AL_SPREADSHEET = ((ushort)(0x0186));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_GRAPHICS_EDITOR ((USAGE) 0x0187)")]
    public const ushort HID_USAGE_CONSUMER_AL_GRAPHICS_EDITOR = ((ushort)(0x0187));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_PRESENTATION_APP ((USAGE) 0x0188)")]
    public const ushort HID_USAGE_CONSUMER_AL_PRESENTATION_APP = ((ushort)(0x0188));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DATABASE_APP ((USAGE) 0x0189)")]
    public const ushort HID_USAGE_CONSUMER_AL_DATABASE_APP = ((ushort)(0x0189));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_EMAIL ((USAGE) 0x018A)")]
    public const ushort HID_USAGE_CONSUMER_AL_EMAIL = ((ushort)(0x018A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_NEWSREADER ((USAGE) 0x018B)")]
    public const ushort HID_USAGE_CONSUMER_AL_NEWSREADER = ((ushort)(0x018B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_VOICEMAIL ((USAGE) 0x018C)")]
    public const ushort HID_USAGE_CONSUMER_AL_VOICEMAIL = ((ushort)(0x018C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CONTACTSADDRESS_BOOK ((USAGE) 0x018D)")]
    public const ushort HID_USAGE_CONSUMER_AL_CONTACTSADDRESS_BOOK = ((ushort)(0x018D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CALENDARSCHEDULE ((USAGE) 0x018E)")]
    public const ushort HID_USAGE_CONSUMER_AL_CALENDARSCHEDULE = ((ushort)(0x018E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_TASKPROJECT_MANAGER ((USAGE) 0x018F)")]
    public const ushort HID_USAGE_CONSUMER_AL_TASKPROJECT_MANAGER = ((ushort)(0x018F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_LOGJOURNALTIMECARD ((USAGE) 0x0190)")]
    public const ushort HID_USAGE_CONSUMER_AL_LOGJOURNALTIMECARD = ((ushort)(0x0190));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CHECKBOOKFINANCE ((USAGE) 0x0191)")]
    public const ushort HID_USAGE_CONSUMER_AL_CHECKBOOKFINANCE = ((ushort)(0x0191));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CALCULATOR ((USAGE) 0x0192)")]
    public const ushort HID_USAGE_CONSUMER_AL_CALCULATOR = ((ushort)(0x0192));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_AV_CAPTUREPLAYBACK ((USAGE) 0x0193)")]
    public const ushort HID_USAGE_CONSUMER_AL_AV_CAPTUREPLAYBACK = ((ushort)(0x0193));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_BROWSER ((USAGE) 0x0194)")]
    public const ushort HID_USAGE_CONSUMER_AL_BROWSER = ((ushort)(0x0194));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_LANWAN_BROWSER ((USAGE) 0x0195)")]
    public const ushort HID_USAGE_CONSUMER_AL_LANWAN_BROWSER = ((ushort)(0x0195));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_INTERNET_BROWSER ((USAGE) 0x0196)")]
    public const ushort HID_USAGE_CONSUMER_AL_INTERNET_BROWSER = ((ushort)(0x0196));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_REMOTE_NETWORKINGISP_CONNECT ((USAGE) 0x0197)")]
    public const ushort HID_USAGE_CONSUMER_AL_REMOTE_NETWORKINGISP_CONNECT = ((ushort)(0x0197));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_NETWORK_CONFERENCE ((USAGE) 0x0198)")]
    public const ushort HID_USAGE_CONSUMER_AL_NETWORK_CONFERENCE = ((ushort)(0x0198));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_NETWORK_CHAT ((USAGE) 0x0199)")]
    public const ushort HID_USAGE_CONSUMER_AL_NETWORK_CHAT = ((ushort)(0x0199));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_TELEPHONYDIALER ((USAGE) 0x019A)")]
    public const ushort HID_USAGE_CONSUMER_AL_TELEPHONYDIALER = ((ushort)(0x019A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_LOGON ((USAGE) 0x019B)")]
    public const ushort HID_USAGE_CONSUMER_AL_LOGON = ((ushort)(0x019B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_LOGOFF ((USAGE) 0x019C)")]
    public const ushort HID_USAGE_CONSUMER_AL_LOGOFF = ((ushort)(0x019C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_LOGONLOGOFF ((USAGE) 0x019D)")]
    public const ushort HID_USAGE_CONSUMER_AL_LOGONLOGOFF = ((ushort)(0x019D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_TERMINAL_LOCKSCREENSAVER ((USAGE) 0x019E)")]
    public const ushort HID_USAGE_CONSUMER_AL_TERMINAL_LOCKSCREENSAVER = ((ushort)(0x019E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CONTROL_PANEL ((USAGE) 0x019F)")]
    public const ushort HID_USAGE_CONSUMER_AL_CONTROL_PANEL = ((ushort)(0x019F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_COMMAND_LINE_PROCESSORRUN ((USAGE) 0x01A0)")]
    public const ushort HID_USAGE_CONSUMER_AL_COMMAND_LINE_PROCESSORRUN = ((ushort)(0x01A0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_PROCESSTASK_MANAGER ((USAGE) 0x01A1)")]
    public const ushort HID_USAGE_CONSUMER_AL_PROCESSTASK_MANAGER = ((ushort)(0x01A1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SELECT_TASKAPPLICATION ((USAGE) 0x01A2)")]
    public const ushort HID_USAGE_CONSUMER_AL_SELECT_TASKAPPLICATION = ((ushort)(0x01A2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_NEXT_TASKAPPLICATION ((USAGE) 0x01A3)")]
    public const ushort HID_USAGE_CONSUMER_AL_NEXT_TASKAPPLICATION = ((ushort)(0x01A3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_PREVIOUS_TASKAPPLICATION ((USAGE) 0x01A4)")]
    public const ushort HID_USAGE_CONSUMER_AL_PREVIOUS_TASKAPPLICATION = ((ushort)(0x01A4));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_PREEMPTIVE_HALT_TASKAPPLICATION ((USAGE) 0x01A5)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_PREEMPTIVE_HALT_TASKAPPLICATION = ((ushort)(0x01A5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_INTEGRATED_HELP_CENTER ((USAGE) 0x01A6)")]
    public const ushort HID_USAGE_CONSUMER_AL_INTEGRATED_HELP_CENTER = ((ushort)(0x01A6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DOCUMENTS ((USAGE) 0x01A7)")]
    public const ushort HID_USAGE_CONSUMER_AL_DOCUMENTS = ((ushort)(0x01A7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_THESAURUS ((USAGE) 0x01A8)")]
    public const ushort HID_USAGE_CONSUMER_AL_THESAURUS = ((ushort)(0x01A8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DICTIONARY ((USAGE) 0x01A9)")]
    public const ushort HID_USAGE_CONSUMER_AL_DICTIONARY = ((ushort)(0x01A9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DESKTOP ((USAGE) 0x01AA)")]
    public const ushort HID_USAGE_CONSUMER_AL_DESKTOP = ((ushort)(0x01AA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SPELL_CHECK ((USAGE) 0x01AB)")]
    public const ushort HID_USAGE_CONSUMER_AL_SPELL_CHECK = ((ushort)(0x01AB));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_GRAMMAR_CHECK ((USAGE) 0x01AC)")]
    public const ushort HID_USAGE_CONSUMER_AL_GRAMMAR_CHECK = ((ushort)(0x01AC));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_WIRELESS_STATUS ((USAGE) 0x01AD)")]
    public const ushort HID_USAGE_CONSUMER_AL_WIRELESS_STATUS = ((ushort)(0x01AD));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_KEYBOARD_LAYOUT ((USAGE) 0x01AE)")]
    public const ushort HID_USAGE_CONSUMER_AL_KEYBOARD_LAYOUT = ((ushort)(0x01AE));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_VIRUS_PROTECTION ((USAGE) 0x01AF)")]
    public const ushort HID_USAGE_CONSUMER_AL_VIRUS_PROTECTION = ((ushort)(0x01AF));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ENCRYPTION ((USAGE) 0x01B0)")]
    public const ushort HID_USAGE_CONSUMER_AL_ENCRYPTION = ((ushort)(0x01B0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SCREEN_SAVER ((USAGE) 0x01B1)")]
    public const ushort HID_USAGE_CONSUMER_AL_SCREEN_SAVER = ((ushort)(0x01B1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ALARMS ((USAGE) 0x01B2)")]
    public const ushort HID_USAGE_CONSUMER_AL_ALARMS = ((ushort)(0x01B2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CLOCK ((USAGE) 0x01B3)")]
    public const ushort HID_USAGE_CONSUMER_AL_CLOCK = ((ushort)(0x01B3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_FILE_BROWSER ((USAGE) 0x01B4)")]
    public const ushort HID_USAGE_CONSUMER_AL_FILE_BROWSER = ((ushort)(0x01B4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_POWER_STATUS ((USAGE) 0x01B5)")]
    public const ushort HID_USAGE_CONSUMER_AL_POWER_STATUS = ((ushort)(0x01B5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_IMAGE_BROWSER ((USAGE) 0x01B6)")]
    public const ushort HID_USAGE_CONSUMER_AL_IMAGE_BROWSER = ((ushort)(0x01B6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_AUDIO_BROWSER ((USAGE) 0x01B7)")]
    public const ushort HID_USAGE_CONSUMER_AL_AUDIO_BROWSER = ((ushort)(0x01B7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_MOVIE_BROWSER ((USAGE) 0x01B8)")]
    public const ushort HID_USAGE_CONSUMER_AL_MOVIE_BROWSER = ((ushort)(0x01B8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DIGITAL_RIGHTS_MANAGER ((USAGE) 0x01B9)")]
    public const ushort HID_USAGE_CONSUMER_AL_DIGITAL_RIGHTS_MANAGER = ((ushort)(0x01B9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_DIGITAL_WALLET ((USAGE) 0x01BA)")]
    public const ushort HID_USAGE_CONSUMER_AL_DIGITAL_WALLET = ((ushort)(0x01BA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_INSTANT_MESSAGING ((USAGE) 0x01BC)")]
    public const ushort HID_USAGE_CONSUMER_AL_INSTANT_MESSAGING = ((ushort)(0x01BC));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_OEM_FEATURES_TIPSTUTORIAL_BROWSER ((USAGE) 0x01BD)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_OEM_FEATURES_TIPSTUTORIAL_BROWSER = (
        (ushort)(0x01BD)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_OEM_HELP ((USAGE) 0x01BE)")]
    public const ushort HID_USAGE_CONSUMER_AL_OEM_HELP = ((ushort)(0x01BE));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ONLINE_COMMUNITY ((USAGE) 0x01BF)")]
    public const ushort HID_USAGE_CONSUMER_AL_ONLINE_COMMUNITY = ((ushort)(0x01BF));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ENTERTAINMENT_CONTENT_BROWSER ((USAGE) 0x01C0)")]
    public const ushort HID_USAGE_CONSUMER_AL_ENTERTAINMENT_CONTENT_BROWSER = ((ushort)(0x01C0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ONLINE_SHOPPING_BROWSER ((USAGE) 0x01C1)")]
    public const ushort HID_USAGE_CONSUMER_AL_ONLINE_SHOPPING_BROWSER = ((ushort)(0x01C1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SMARTCARD_INFORMATIONHELP ((USAGE) 0x01C2)")]
    public const ushort HID_USAGE_CONSUMER_AL_SMARTCARD_INFORMATIONHELP = ((ushort)(0x01C2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_MARKET_MONITORFINANCE_BROWSER ((USAGE) 0x01C3)")]
    public const ushort HID_USAGE_CONSUMER_AL_MARKET_MONITORFINANCE_BROWSER = ((ushort)(0x01C3));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_CUSTOMIZED_CORPORATE_NEWS_BROWSER ((USAGE) 0x01C4)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_CUSTOMIZED_CORPORATE_NEWS_BROWSER = (
        (ushort)(0x01C4)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_ONLINE_ACTIVITY_BROWSER ((USAGE) 0x01C5)")]
    public const ushort HID_USAGE_CONSUMER_AL_ONLINE_ACTIVITY_BROWSER = ((ushort)(0x01C5));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_SEARCH ((USAGE) 0x01C6)")]
    public const ushort HID_USAGE_CONSUMER_AL_SEARCH = ((ushort)(0x01C6));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_AUDIO_PLAYER ((USAGE) 0x01C7)")]
    public const ushort HID_USAGE_CONSUMER_AL_AUDIO_PLAYER = ((ushort)(0x01C7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_MESSAGE_STATUS ((USAGE) 0x01C8)")]
    public const ushort HID_USAGE_CONSUMER_AL_MESSAGE_STATUS = ((ushort)(0x01C8));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_CONTACT_SYNC ((USAGE) 0x01C9)")]
    public const ushort HID_USAGE_CONSUMER_AL_CONTACT_SYNC = ((ushort)(0x01C9));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AL_NAVIGATION ((USAGE) 0x01CA)")]
    public const ushort HID_USAGE_CONSUMER_AL_NAVIGATION = ((ushort)(0x01CA));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_AL_CONTEXTAWARE_DESKTOP_ASSISTANT ((USAGE) 0x01CB)"
    )]
    public const ushort HID_USAGE_CONSUMER_AL_CONTEXTAWARE_DESKTOP_ASSISTANT = ((ushort)(0x01CB));

    [NativeTypeName("#define HID_USAGE_CONSUMER_GENERIC_GUI_APPLICATION_CONTROLS ((USAGE) 0x0200)")]
    public const ushort HID_USAGE_CONSUMER_GENERIC_GUI_APPLICATION_CONTROLS = ((ushort)(0x0200));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NEW ((USAGE) 0x0201)")]
    public const ushort HID_USAGE_CONSUMER_AC_NEW = ((ushort)(0x0201));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_OPEN ((USAGE) 0x0202)")]
    public const ushort HID_USAGE_CONSUMER_AC_OPEN = ((ushort)(0x0202));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_CLOSE ((USAGE) 0x0203)")]
    public const ushort HID_USAGE_CONSUMER_AC_CLOSE = ((ushort)(0x0203));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_EXIT ((USAGE) 0x0204)")]
    public const ushort HID_USAGE_CONSUMER_AC_EXIT = ((ushort)(0x0204));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_MAXIMIZE ((USAGE) 0x0205)")]
    public const ushort HID_USAGE_CONSUMER_AC_MAXIMIZE = ((ushort)(0x0205));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_MINIMIZE ((USAGE) 0x0206)")]
    public const ushort HID_USAGE_CONSUMER_AC_MINIMIZE = ((ushort)(0x0206));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SAVE ((USAGE) 0x0207)")]
    public const ushort HID_USAGE_CONSUMER_AC_SAVE = ((ushort)(0x0207));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PRINT ((USAGE) 0x0208)")]
    public const ushort HID_USAGE_CONSUMER_AC_PRINT = ((ushort)(0x0208));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PROPERTIES ((USAGE) 0x0209)")]
    public const ushort HID_USAGE_CONSUMER_AC_PROPERTIES = ((ushort)(0x0209));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_UNDO ((USAGE) 0x021A)")]
    public const ushort HID_USAGE_CONSUMER_AC_UNDO = ((ushort)(0x021A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_COPY ((USAGE) 0x021B)")]
    public const ushort HID_USAGE_CONSUMER_AC_COPY = ((ushort)(0x021B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_CUT ((USAGE) 0x021C)")]
    public const ushort HID_USAGE_CONSUMER_AC_CUT = ((ushort)(0x021C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PASTE ((USAGE) 0x021D)")]
    public const ushort HID_USAGE_CONSUMER_AC_PASTE = ((ushort)(0x021D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_ALL ((USAGE) 0x021E)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_ALL = ((ushort)(0x021E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FIND ((USAGE) 0x021F)")]
    public const ushort HID_USAGE_CONSUMER_AC_FIND = ((ushort)(0x021F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FIND_AND_REPLACE ((USAGE) 0x0220)")]
    public const ushort HID_USAGE_CONSUMER_AC_FIND_AND_REPLACE = ((ushort)(0x0220));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SEARCH ((USAGE) 0x0221)")]
    public const ushort HID_USAGE_CONSUMER_AC_SEARCH = ((ushort)(0x0221));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_GOTO ((USAGE) 0x0222)")]
    public const ushort HID_USAGE_CONSUMER_AC_GOTO = ((ushort)(0x0222));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_HOME ((USAGE) 0x0223)")]
    public const ushort HID_USAGE_CONSUMER_AC_HOME = ((ushort)(0x0223));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BACK ((USAGE) 0x0224)")]
    public const ushort HID_USAGE_CONSUMER_AC_BACK = ((ushort)(0x0224));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FORWARD ((USAGE) 0x0225)")]
    public const ushort HID_USAGE_CONSUMER_AC_FORWARD = ((ushort)(0x0225));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_STOP ((USAGE) 0x0226)")]
    public const ushort HID_USAGE_CONSUMER_AC_STOP = ((ushort)(0x0226));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_REFRESH ((USAGE) 0x0227)")]
    public const ushort HID_USAGE_CONSUMER_AC_REFRESH = ((ushort)(0x0227));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PREVIOUS ((USAGE) 0x0228)")]
    public const ushort HID_USAGE_CONSUMER_AC_PREVIOUS = ((ushort)(0x0228));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NEXT ((USAGE) 0x0229)")]
    public const ushort HID_USAGE_CONSUMER_AC_NEXT = ((ushort)(0x0229));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BOOKMARKS ((USAGE) 0x022A)")]
    public const ushort HID_USAGE_CONSUMER_AC_BOOKMARKS = ((ushort)(0x022A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_HISTORY ((USAGE) 0x022B)")]
    public const ushort HID_USAGE_CONSUMER_AC_HISTORY = ((ushort)(0x022B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SUBSCRIPTIONS ((USAGE) 0x022C)")]
    public const ushort HID_USAGE_CONSUMER_AC_SUBSCRIPTIONS = ((ushort)(0x022C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ZOOM_IN ((USAGE) 0x022D)")]
    public const ushort HID_USAGE_CONSUMER_AC_ZOOM_IN = ((ushort)(0x022D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ZOOM_OUT ((USAGE) 0x022E)")]
    public const ushort HID_USAGE_CONSUMER_AC_ZOOM_OUT = ((ushort)(0x022E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ZOOM ((USAGE) 0x022F)")]
    public const ushort HID_USAGE_CONSUMER_AC_ZOOM = ((ushort)(0x022F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FULL_SCREEN_VIEW ((USAGE) 0x0230)")]
    public const ushort HID_USAGE_CONSUMER_AC_FULL_SCREEN_VIEW = ((ushort)(0x0230));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NORMAL_VIEW ((USAGE) 0x0231)")]
    public const ushort HID_USAGE_CONSUMER_AC_NORMAL_VIEW = ((ushort)(0x0231));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_VIEW_TOGGLE ((USAGE) 0x0232)")]
    public const ushort HID_USAGE_CONSUMER_AC_VIEW_TOGGLE = ((ushort)(0x0232));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SCROLL_UP ((USAGE) 0x0233)")]
    public const ushort HID_USAGE_CONSUMER_AC_SCROLL_UP = ((ushort)(0x0233));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SCROLL_DOWN ((USAGE) 0x0234)")]
    public const ushort HID_USAGE_CONSUMER_AC_SCROLL_DOWN = ((ushort)(0x0234));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SCROLL ((USAGE) 0x0235)")]
    public const ushort HID_USAGE_CONSUMER_AC_SCROLL = ((ushort)(0x0235));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PAN_LEFT ((USAGE) 0x0236)")]
    public const ushort HID_USAGE_CONSUMER_AC_PAN_LEFT = ((ushort)(0x0236));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PAN_RIGHT ((USAGE) 0x0237)")]
    public const ushort HID_USAGE_CONSUMER_AC_PAN_RIGHT = ((ushort)(0x0237));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PAN ((USAGE) 0x0238)")]
    public const ushort HID_USAGE_CONSUMER_AC_PAN = ((ushort)(0x0238));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NEW_WINDOW ((USAGE) 0x0239)")]
    public const ushort HID_USAGE_CONSUMER_AC_NEW_WINDOW = ((ushort)(0x0239));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_TILE_HORIZONTALLY ((USAGE) 0x023A)")]
    public const ushort HID_USAGE_CONSUMER_AC_TILE_HORIZONTALLY = ((ushort)(0x023A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_TILE_VERTICALLY ((USAGE) 0x023B)")]
    public const ushort HID_USAGE_CONSUMER_AC_TILE_VERTICALLY = ((ushort)(0x023B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FORMAT ((USAGE) 0x023C)")]
    public const ushort HID_USAGE_CONSUMER_AC_FORMAT = ((ushort)(0x023C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_EDIT ((USAGE) 0x023D)")]
    public const ushort HID_USAGE_CONSUMER_AC_EDIT = ((ushort)(0x023D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BOLD ((USAGE) 0x023E)")]
    public const ushort HID_USAGE_CONSUMER_AC_BOLD = ((ushort)(0x023E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ITALICS ((USAGE) 0x023F)")]
    public const ushort HID_USAGE_CONSUMER_AC_ITALICS = ((ushort)(0x023F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_UNDERLINE ((USAGE) 0x0240)")]
    public const ushort HID_USAGE_CONSUMER_AC_UNDERLINE = ((ushort)(0x0240));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_STRIKETHROUGH ((USAGE) 0x0241)")]
    public const ushort HID_USAGE_CONSUMER_AC_STRIKETHROUGH = ((ushort)(0x0241));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SUBSCRIPT ((USAGE) 0x0242)")]
    public const ushort HID_USAGE_CONSUMER_AC_SUBSCRIPT = ((ushort)(0x0242));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SUPERSCRIPT ((USAGE) 0x0243)")]
    public const ushort HID_USAGE_CONSUMER_AC_SUPERSCRIPT = ((ushort)(0x0243));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ALL_CAPS ((USAGE) 0x0244)")]
    public const ushort HID_USAGE_CONSUMER_AC_ALL_CAPS = ((ushort)(0x0244));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ROTATE ((USAGE) 0x0245)")]
    public const ushort HID_USAGE_CONSUMER_AC_ROTATE = ((ushort)(0x0245));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_RESIZE ((USAGE) 0x0246)")]
    public const ushort HID_USAGE_CONSUMER_AC_RESIZE = ((ushort)(0x0246));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FLIP_HORIZONTAL ((USAGE) 0x0247)")]
    public const ushort HID_USAGE_CONSUMER_AC_FLIP_HORIZONTAL = ((ushort)(0x0247));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FLIP_VERTICAL ((USAGE) 0x0248)")]
    public const ushort HID_USAGE_CONSUMER_AC_FLIP_VERTICAL = ((ushort)(0x0248));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_MIRROR_HORIZONTAL ((USAGE) 0x0249)")]
    public const ushort HID_USAGE_CONSUMER_AC_MIRROR_HORIZONTAL = ((ushort)(0x0249));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_MIRROR_VERTICAL ((USAGE) 0x024A)")]
    public const ushort HID_USAGE_CONSUMER_AC_MIRROR_VERTICAL = ((ushort)(0x024A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FONT_SELECT ((USAGE) 0x024B)")]
    public const ushort HID_USAGE_CONSUMER_AC_FONT_SELECT = ((ushort)(0x024B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FONT_COLOR ((USAGE) 0x024C)")]
    public const ushort HID_USAGE_CONSUMER_AC_FONT_COLOR = ((ushort)(0x024C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FONT_SIZE ((USAGE) 0x024D)")]
    public const ushort HID_USAGE_CONSUMER_AC_FONT_SIZE = ((ushort)(0x024D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_LEFT ((USAGE) 0x024E)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_LEFT = ((ushort)(0x024E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_CENTER_H ((USAGE) 0x024F)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_CENTER_H = ((ushort)(0x024F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_RIGHT ((USAGE) 0x0250)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_RIGHT = ((ushort)(0x0250));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_BLOCK_H ((USAGE) 0x0251)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_BLOCK_H = ((ushort)(0x0251));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_TOP ((USAGE) 0x0252)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_TOP = ((ushort)(0x0252));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_CENTER_V ((USAGE) 0x0253)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_CENTER_V = ((ushort)(0x0253));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_BOTTOM ((USAGE) 0x0254)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_BOTTOM = ((ushort)(0x0254));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_JUSTIFY_BLOCK_V ((USAGE) 0x0255)")]
    public const ushort HID_USAGE_CONSUMER_AC_JUSTIFY_BLOCK_V = ((ushort)(0x0255));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INDENT_DECREASE ((USAGE) 0x0256)")]
    public const ushort HID_USAGE_CONSUMER_AC_INDENT_DECREASE = ((ushort)(0x0256));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INDENT_INCREASE ((USAGE) 0x0257)")]
    public const ushort HID_USAGE_CONSUMER_AC_INDENT_INCREASE = ((ushort)(0x0257));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NUMBERED_LIST ((USAGE) 0x0258)")]
    public const ushort HID_USAGE_CONSUMER_AC_NUMBERED_LIST = ((ushort)(0x0258));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_RESTART_NUMBERING ((USAGE) 0x0259)")]
    public const ushort HID_USAGE_CONSUMER_AC_RESTART_NUMBERING = ((ushort)(0x0259));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BULLETED_LIST ((USAGE) 0x025A)")]
    public const ushort HID_USAGE_CONSUMER_AC_BULLETED_LIST = ((ushort)(0x025A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PROMOTE ((USAGE) 0x025B)")]
    public const ushort HID_USAGE_CONSUMER_AC_PROMOTE = ((ushort)(0x025B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DEMOTE ((USAGE) 0x025C)")]
    public const ushort HID_USAGE_CONSUMER_AC_DEMOTE = ((ushort)(0x025C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_YES ((USAGE) 0x025D)")]
    public const ushort HID_USAGE_CONSUMER_AC_YES = ((ushort)(0x025D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NO ((USAGE) 0x025E)")]
    public const ushort HID_USAGE_CONSUMER_AC_NO = ((ushort)(0x025E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_CANCEL ((USAGE) 0x025F)")]
    public const ushort HID_USAGE_CONSUMER_AC_CANCEL = ((ushort)(0x025F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_CATALOG ((USAGE) 0x0260)")]
    public const ushort HID_USAGE_CONSUMER_AC_CATALOG = ((ushort)(0x0260));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_BUYCHECKOUT ((USAGE) 0x0261)")]
    public const ushort HID_USAGE_CONSUMER_AC_BUYCHECKOUT = ((ushort)(0x0261));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ADD_TO_CART ((USAGE) 0x0262)")]
    public const ushort HID_USAGE_CONSUMER_AC_ADD_TO_CART = ((ushort)(0x0262));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_EXPAND ((USAGE) 0x0263)")]
    public const ushort HID_USAGE_CONSUMER_AC_EXPAND = ((ushort)(0x0263));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_EXPAND_ALL ((USAGE) 0x0264)")]
    public const ushort HID_USAGE_CONSUMER_AC_EXPAND_ALL = ((ushort)(0x0264));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_COLLAPSE ((USAGE) 0x0265)")]
    public const ushort HID_USAGE_CONSUMER_AC_COLLAPSE = ((ushort)(0x0265));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_COLLAPSE_ALL ((USAGE) 0x0266)")]
    public const ushort HID_USAGE_CONSUMER_AC_COLLAPSE_ALL = ((ushort)(0x0266));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PRINT_PREVIEW ((USAGE) 0x0267)")]
    public const ushort HID_USAGE_CONSUMER_AC_PRINT_PREVIEW = ((ushort)(0x0267));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PASTE_SPECIAL ((USAGE) 0x0268)")]
    public const ushort HID_USAGE_CONSUMER_AC_PASTE_SPECIAL = ((ushort)(0x0268));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_MODE ((USAGE) 0x0269)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_MODE = ((ushort)(0x0269));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DELETE ((USAGE) 0x026A)")]
    public const ushort HID_USAGE_CONSUMER_AC_DELETE = ((ushort)(0x026A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_LOCK ((USAGE) 0x026B)")]
    public const ushort HID_USAGE_CONSUMER_AC_LOCK = ((ushort)(0x026B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_UNLOCK ((USAGE) 0x026C)")]
    public const ushort HID_USAGE_CONSUMER_AC_UNLOCK = ((ushort)(0x026C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_PROTECT ((USAGE) 0x026D)")]
    public const ushort HID_USAGE_CONSUMER_AC_PROTECT = ((ushort)(0x026D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_UNPROTECT ((USAGE) 0x026E)")]
    public const ushort HID_USAGE_CONSUMER_AC_UNPROTECT = ((ushort)(0x026E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ATTACH_COMMENT ((USAGE) 0x026F)")]
    public const ushort HID_USAGE_CONSUMER_AC_ATTACH_COMMENT = ((ushort)(0x026F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DELETE_COMMENT ((USAGE) 0x0270)")]
    public const ushort HID_USAGE_CONSUMER_AC_DELETE_COMMENT = ((ushort)(0x0270));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_VIEW_COMMENT ((USAGE) 0x0271)")]
    public const ushort HID_USAGE_CONSUMER_AC_VIEW_COMMENT = ((ushort)(0x0271));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_WORD ((USAGE) 0x0272)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_WORD = ((ushort)(0x0272));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_SENTENCE ((USAGE) 0x0273)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_SENTENCE = ((ushort)(0x0273));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_PARAGRAPH ((USAGE) 0x0274)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_PARAGRAPH = ((ushort)(0x0274));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_COLUMN ((USAGE) 0x0275)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_COLUMN = ((ushort)(0x0275));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_ROW ((USAGE) 0x0276)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_ROW = ((ushort)(0x0276));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_TABLE ((USAGE) 0x0277)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_TABLE = ((ushort)(0x0277));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_OBJECT ((USAGE) 0x0278)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_OBJECT = ((ushort)(0x0278));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_REDOREPEAT ((USAGE) 0x0279)")]
    public const ushort HID_USAGE_CONSUMER_AC_REDOREPEAT = ((ushort)(0x0279));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SORT ((USAGE) 0x027A)")]
    public const ushort HID_USAGE_CONSUMER_AC_SORT = ((ushort)(0x027A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SORT_ASCENDING ((USAGE) 0x027B)")]
    public const ushort HID_USAGE_CONSUMER_AC_SORT_ASCENDING = ((ushort)(0x027B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SORT_DESCENDING ((USAGE) 0x027C)")]
    public const ushort HID_USAGE_CONSUMER_AC_SORT_DESCENDING = ((ushort)(0x027C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FILTER ((USAGE) 0x027D)")]
    public const ushort HID_USAGE_CONSUMER_AC_FILTER = ((ushort)(0x027D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SET_CLOCK ((USAGE) 0x027E)")]
    public const ushort HID_USAGE_CONSUMER_AC_SET_CLOCK = ((ushort)(0x027E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_VIEW_CLOCK ((USAGE) 0x027F)")]
    public const ushort HID_USAGE_CONSUMER_AC_VIEW_CLOCK = ((ushort)(0x027F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SELECT_TIME_ZONE ((USAGE) 0x0280)")]
    public const ushort HID_USAGE_CONSUMER_AC_SELECT_TIME_ZONE = ((ushort)(0x0280));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_EDIT_TIME_ZONES ((USAGE) 0x0281)")]
    public const ushort HID_USAGE_CONSUMER_AC_EDIT_TIME_ZONES = ((ushort)(0x0281));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SET_ALARM ((USAGE) 0x0282)")]
    public const ushort HID_USAGE_CONSUMER_AC_SET_ALARM = ((ushort)(0x0282));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_CLEAR_ALARM ((USAGE) 0x0283)")]
    public const ushort HID_USAGE_CONSUMER_AC_CLEAR_ALARM = ((ushort)(0x0283));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SNOOZE_ALARM ((USAGE) 0x0284)")]
    public const ushort HID_USAGE_CONSUMER_AC_SNOOZE_ALARM = ((ushort)(0x0284));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_RESET_ALARM ((USAGE) 0x0285)")]
    public const ushort HID_USAGE_CONSUMER_AC_RESET_ALARM = ((ushort)(0x0285));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SYNCHRONIZE ((USAGE) 0x0286)")]
    public const ushort HID_USAGE_CONSUMER_AC_SYNCHRONIZE = ((ushort)(0x0286));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SENDRECEIVE ((USAGE) 0x0287)")]
    public const ushort HID_USAGE_CONSUMER_AC_SENDRECEIVE = ((ushort)(0x0287));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SEND_TO ((USAGE) 0x0288)")]
    public const ushort HID_USAGE_CONSUMER_AC_SEND_TO = ((ushort)(0x0288));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_REPLY ((USAGE) 0x0289)")]
    public const ushort HID_USAGE_CONSUMER_AC_REPLY = ((ushort)(0x0289));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_REPLY_ALL ((USAGE) 0x028A)")]
    public const ushort HID_USAGE_CONSUMER_AC_REPLY_ALL = ((ushort)(0x028A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_FORWARD_MSG ((USAGE) 0x028B)")]
    public const ushort HID_USAGE_CONSUMER_AC_FORWARD_MSG = ((ushort)(0x028B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SEND ((USAGE) 0x028C)")]
    public const ushort HID_USAGE_CONSUMER_AC_SEND = ((ushort)(0x028C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_ATTACH_FILE ((USAGE) 0x028D)")]
    public const ushort HID_USAGE_CONSUMER_AC_ATTACH_FILE = ((ushort)(0x028D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_UPLOAD ((USAGE) 0x028E)")]
    public const ushort HID_USAGE_CONSUMER_AC_UPLOAD = ((ushort)(0x028E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DOWNLOAD_SAVE_TARGET_AS ((USAGE) 0x028F)")]
    public const ushort HID_USAGE_CONSUMER_AC_DOWNLOAD_SAVE_TARGET_AS = ((ushort)(0x028F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SET_BORDERS ((USAGE) 0x0290)")]
    public const ushort HID_USAGE_CONSUMER_AC_SET_BORDERS = ((ushort)(0x0290));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_ROW ((USAGE) 0x0291)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_ROW = ((ushort)(0x0291));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_COLUMN ((USAGE) 0x0292)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_COLUMN = ((ushort)(0x0292));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_FILE ((USAGE) 0x0293)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_FILE = ((ushort)(0x0293));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_PICTURE ((USAGE) 0x0294)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_PICTURE = ((ushort)(0x0294));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_OBJECT ((USAGE) 0x0295)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_OBJECT = ((ushort)(0x0295));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_INSERT_SYMBOL ((USAGE) 0x0296)")]
    public const ushort HID_USAGE_CONSUMER_AC_INSERT_SYMBOL = ((ushort)(0x0296));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SAVE_AND_CLOSE ((USAGE) 0x0297)")]
    public const ushort HID_USAGE_CONSUMER_AC_SAVE_AND_CLOSE = ((ushort)(0x0297));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_RENAME ((USAGE) 0x0298)")]
    public const ushort HID_USAGE_CONSUMER_AC_RENAME = ((ushort)(0x0298));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_MERGE ((USAGE) 0x0299)")]
    public const ushort HID_USAGE_CONSUMER_AC_MERGE = ((ushort)(0x0299));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SPLIT ((USAGE) 0x029A)")]
    public const ushort HID_USAGE_CONSUMER_AC_SPLIT = ((ushort)(0x029A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DISRIBUTE_HORIZONTALLY ((USAGE) 0x029B)")]
    public const ushort HID_USAGE_CONSUMER_AC_DISRIBUTE_HORIZONTALLY = ((ushort)(0x029B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DISTRIBUTE_VERTICALLY ((USAGE) 0x029C)")]
    public const ushort HID_USAGE_CONSUMER_AC_DISTRIBUTE_VERTICALLY = ((ushort)(0x029C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NEXT_KEYBOARD_LAYOUT_SELECT ((USAGE) 0x029D)")]
    public const ushort HID_USAGE_CONSUMER_AC_NEXT_KEYBOARD_LAYOUT_SELECT = ((ushort)(0x029D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_NAVIGATION_GUIDANCE ((USAGE) 0x029E)")]
    public const ushort HID_USAGE_CONSUMER_AC_NAVIGATION_GUIDANCE = ((ushort)(0x029E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DESKTOP_SHOW_ALL_WINDOWS ((USAGE) 0x029F)")]
    public const ushort HID_USAGE_CONSUMER_AC_DESKTOP_SHOW_ALL_WINDOWS = ((ushort)(0x029F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SOFT_KEY_LEFT ((USAGE) 0x02A0)")]
    public const ushort HID_USAGE_CONSUMER_AC_SOFT_KEY_LEFT = ((ushort)(0x02A0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_SOFT_KEY_RIGHT ((USAGE) 0x02A1)")]
    public const ushort HID_USAGE_CONSUMER_AC_SOFT_KEY_RIGHT = ((ushort)(0x02A1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_DESKTOP_SHOW_ALL_APPLICATIONS ((USAGE) 0x02A2)")]
    public const ushort HID_USAGE_CONSUMER_AC_DESKTOP_SHOW_ALL_APPLICATIONS = ((ushort)(0x02A2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_AC_IDLE_KEEP_ALIVE ((USAGE) 0x02B0)")]
    public const ushort HID_USAGE_CONSUMER_AC_IDLE_KEEP_ALIVE = ((ushort)(0x02B0));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION ((USAGE) 0x02C0)"
    )]
    public const ushort HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION = (
        (ushort)(0x02C0)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR ((USAGE) 0x02C1)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR = ((ushort)(0x02C1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE ((USAGE) 0x02C2)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE = ((ushort)(0x02C2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT ((USAGE) 0x02C3)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT = ((ushort)(0x02C3));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT ((USAGE) 0x02C4)"
    )]
    public const ushort HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT = (
        (ushort)(0x02C4)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX ((USAGE) 0x02C5)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX = ((ushort)(0x02C5));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS ((USAGE) 0x02C6)"
    )]
    public const ushort HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS = (
        (ushort)(0x02C6)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_PREVIOUS ((USAGE) 0x02C7)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_PREVIOUS = ((ushort)(0x02C7));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_NEXT ((USAGE) 0x02C8)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_NEXT = ((ushort)(0x02C8));

    [NativeTypeName(
        "#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_PREVIOUS_GROUP ((USAGE) 0x02C9)"
    )]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_PREVIOUS_GROUP = (
        (ushort)(0x02C9)
    );

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_NEXT_GROUP ((USAGE) 0x02CA)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_NEXT_GROUP = ((ushort)(0x02CA));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_ACCEPT ((USAGE) 0x02CB)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_ACCEPT = ((ushort)(0x02CB));

    [NativeTypeName("#define HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_CANCEL ((USAGE) 0x02CC)")]
    public const ushort HID_USAGE_CONSUMER_KEYBOARD_INPUT_ASSIST_CANCEL = ((ushort)(0x02CC));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PRIVACY_SCREEN_TOGGLE ((USAGE) 0x02D0)")]
    public const ushort HID_USAGE_CONSUMER_PRIVACY_SCREEN_TOGGLE = ((ushort)(0x02D0));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_DECREMENT ((USAGE) 0x02D1)")]
    public const ushort HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_DECREMENT = ((ushort)(0x02D1));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_INCREMENT ((USAGE) 0x02D2)")]
    public const ushort HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_INCREMENT = ((ushort)(0x02D2));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_MINIMUM ((USAGE) 0x02D3)")]
    public const ushort HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_MINIMUM = ((ushort)(0x02D3));

    [NativeTypeName("#define HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_MAXIMUM ((USAGE) 0x02D4)")]
    public const ushort HID_USAGE_CONSUMER_PRIVACY_SCREEN_LEVEL_MAXIMUM = ((ushort)(0x02D4));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_EDITED ((USAGE) 0x0500)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_EDITED = ((ushort)(0x0500));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_ADDED ((USAGE) 0x0501)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_ADDED = ((ushort)(0x0501));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_RECORD_ACTIVE ((USAGE) 0x0502)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_RECORD_ACTIVE = ((ushort)(0x0502));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_INDEX ((USAGE) 0x0503)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_INDEX = ((ushort)(0x0503));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_NICKNAME ((USAGE) 0x0504)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_NICKNAME = ((ushort)(0x0504));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_FIRST_NAME ((USAGE) 0x0505)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_FIRST_NAME = ((ushort)(0x0505));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_LAST_NAME ((USAGE) 0x0506)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_LAST_NAME = ((ushort)(0x0506));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_FULL_NAME ((USAGE) 0x0507)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_FULL_NAME = ((ushort)(0x0507));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_PERSONAL ((USAGE) 0x0508)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_PERSONAL = ((ushort)(0x0508));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_BUSINESS ((USAGE) 0x0509)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_BUSINESS = ((ushort)(0x0509));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_MOBILE ((USAGE) 0x050A)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_MOBILE = ((ushort)(0x050A));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_PAGER ((USAGE) 0x050B)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_PAGER = ((ushort)(0x050B));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_FAX ((USAGE) 0x050C)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_FAX = ((ushort)(0x050C));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_OTHER ((USAGE) 0x050D)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_PHONE_NUMBER_OTHER = ((ushort)(0x050D));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_EMAIL_PERSONAL ((USAGE) 0x050E)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_EMAIL_PERSONAL = ((ushort)(0x050E));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_EMAIL_BUSINESS ((USAGE) 0x050F)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_EMAIL_BUSINESS = ((ushort)(0x050F));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_EMAIL_OTHER ((USAGE) 0x0510)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_EMAIL_OTHER = ((ushort)(0x0510));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_EMAIL_MAIN ((USAGE) 0x0511)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_EMAIL_MAIN = ((ushort)(0x0511));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_SPEED_DIAL_NUMBER ((USAGE) 0x0512)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_SPEED_DIAL_NUMBER = ((ushort)(0x0512));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_STATUS_FLAG ((USAGE) 0x0513)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_STATUS_FLAG = ((ushort)(0x0513));

    [NativeTypeName("#define HID_USAGE_CONSUMER_CONTACT_MISC ((USAGE) 0x0514)")]
    public const ushort HID_USAGE_CONSUMER_CONTACT_MISC = ((ushort)(0x0514));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_UNKNOWN ((USAGE_VALUE) 0x0000)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_UNKNOWN = ((int)(0x0000));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_FULL_SIZE ((USAGE_VALUE) 0x0001)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_FULL_SIZE = ((int)(0x0001));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_COMPACT ((USAGE_VALUE) 0x0002)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_FORM_FACTOR_COMPACT = ((int)(0x0002));

    [NativeTypeName("#define HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_UNKNOWN ((USAGE_VALUE) 0x0000)")]
    public const int HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_UNKNOWN = ((int)(0x0000));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_FULL_TRAVEL ((USAGE_VALUE) 0x0001)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_FULL_TRAVEL = ((int)(0x0001));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_LOW_TRAVEL ((USAGE_VALUE) 0x0002)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_LOW_TRAVEL = ((int)(0x0002));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_ZERO_TRAVEL ((USAGE_VALUE) 0x0003)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_KEY_TYPE_ZERO_TRAVEL = ((int)(0x0003));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_UNKNOWN ((USAGE_VALUE) 0x0000)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_UNKNOWN = ((int)(0x0000));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_US_101 ((USAGE_VALUE) 0x0001)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_US_101 = ((int)(0x0001));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_KOREA_103 ((USAGE_VALUE) 0x0002)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_KOREA_103 = ((int)(0x0002));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_EUROPE_102 ((USAGE_VALUE) 0x0003)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_EUROPE_102 = ((int)(0x0003));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_BRAZIL_104 ((USAGE_VALUE) 0x0004)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_BRAZIL_104 = ((int)(0x0004));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_JAPAN_106 ((USAGE_VALUE) 0x0005)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_JAPAN_106 = ((int)(0x0005));

    [NativeTypeName(
        "#define HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_VENDOR ((USAGE_VALUE) 0x0006)"
    )]
    public const int HID_VALUE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT_VENDOR = ((int)(0x0006));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DIGITIZER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_DIGITIZER_DIGITIZER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PEN ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_DIGITIZER_PEN = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_LIGHT_PEN ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_DIGITIZER_LIGHT_PEN = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH_SCREEN ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH_SCREEN = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH_PAD ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH_PAD = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_WHITE_BOARD ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_DIGITIZER_WHITE_BOARD = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_COORD_MEASURING ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_DIGITIZER_COORD_MEASURING = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_3D_DIGITIZER ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_DIGITIZER_3D_DIGITIZER = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_STEREO_PLOTTER ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_DIGITIZER_STEREO_PLOTTER = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ARTICULATED_ARM ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_DIGITIZER_ARTICULATED_ARM = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ARMATURE ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_DIGITIZER_ARMATURE = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_MULTI_POINT ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_DIGITIZER_MULTI_POINT = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_FREE_SPACE_WAND ((USAGE) 0x000D)")]
    public const ushort HID_USAGE_DIGITIZER_FREE_SPACE_WAND = ((ushort)(0x000D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DEVICE_CONFIGURATION ((USAGE) 0x000E)")]
    public const ushort HID_USAGE_DIGITIZER_DEVICE_CONFIGURATION = ((ushort)(0x000E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP ((USAGE) 0x000F)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP = ((ushort)(0x000F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_STYLUS ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_DIGITIZER_STYLUS = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PUCK ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_DIGITIZER_PUCK = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_FINGER ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_DIGITIZER_FINGER = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DEVICE_SETTINGS ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_DIGITIZER_DEVICE_SETTINGS = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CHARACTER_GESTURE ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_DIGITIZER_CHARACTER_GESTURE = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TIP_PRESSURE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_DIGITIZER_TIP_PRESSURE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BARREL_PRESSURE ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_DIGITIZER_BARREL_PRESSURE = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_IN_RANGE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_DIGITIZER_IN_RANGE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_UNTOUCH ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_DIGITIZER_UNTOUCH = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TAP ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_DIGITIZER_TAP = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_QUALITY ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_DIGITIZER_QUALITY = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DATA_VALID ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_DIGITIZER_DATA_VALID = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_INDEX ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_INDEX = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BATTERY_STRENGTH ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_DIGITIZER_BATTERY_STRENGTH = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_INVERT ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_DIGITIZER_INVERT = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_X_TILT ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_DIGITIZER_X_TILT = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_Y_TILT ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_DIGITIZER_Y_TILT = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_AZIMUTH ((USAGE) 0x003F)")]
    public const ushort HID_USAGE_DIGITIZER_AZIMUTH = ((ushort)(0x003F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ALTITUDE ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_DIGITIZER_ALTITUDE = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TWIST ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_DIGITIZER_TWIST = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TIP_SWITCH ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_DIGITIZER_TIP_SWITCH = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BARREL_SWITCH ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_DIGITIZER_BARREL_SWITCH = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ERASER ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_DIGITIZER_ERASER = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TABLET_PICK ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_DIGITIZER_TABLET_PICK = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TOUCH_VALID ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_DIGITIZER_TOUCH_VALID = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_WIDTH ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_DIGITIZER_WIDTH = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEIGHT ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_DIGITIZER_HEIGHT = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CONTACT_IDENTIFIER ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_DIGITIZER_CONTACT_IDENTIFIER = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DEVICE_MODE ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_DIGITIZER_DEVICE_MODE = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DEVICE_IDENTIFIER ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_DIGITIZER_DEVICE_IDENTIFIER = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CONTACT_COUNT ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_DIGITIZER_CONTACT_COUNT = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CONTACT_COUNT_MAXIMUM ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_DIGITIZER_CONTACT_COUNT_MAXIMUM = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SCAN_TIME ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_DIGITIZER_SCAN_TIME = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SURFACE_SWITCH ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_DIGITIZER_SURFACE_SWITCH = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BUTTON_SWITCH ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_DIGITIZER_BUTTON_SWITCH = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PAD_TYPE ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_DIGITIZER_PAD_TYPE = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SECONDARY_BARREL_SWITCH ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_DIGITIZER_SECONDARY_BARREL_SWITCH = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_COLOR ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_COLOR = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_COLOR_IS_LOCKED ((USAGE) 0x005D)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_COLOR_IS_LOCKED = ((ushort)(0x005D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_LINE_WIDTH ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_LINE_WIDTH = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_LINE_WIDTH_IS_LOCKED ((USAGE) 0x005F)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_LINE_WIDTH_IS_LOCKED = ((ushort)(0x005F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_LATENCY_MODE ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_DIGITIZER_LATENCY_MODE = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_GESTURE_CHARACTER_QUALITY ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_DIGITIZER_GESTURE_CHARACTER_QUALITY = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CHARACTER_GESTURE_DATA_LENGTH ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_DIGITIZER_CHARACTER_GESTURE_DATA_LENGTH = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CHARACTER_GESTURE_DATA ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_DIGITIZER_CHARACTER_GESTURE_DATA = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_GESTURE_CHARACTER_ENCODING ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_DIGITIZER_GESTURE_CHARACTER_ENCODING = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_UTF8_CHARACTER_GESTURE_ENCODING ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_DIGITIZER_UTF8_CHARACTER_GESTURE_ENCODING = ((ushort)(0x0065));

    [NativeTypeName(
        "#define HID_USAGE_DIGITIZER_UTF16_LITTLE_ENDIAN_CHARACTER_GESTURE_ENCODING ((USAGE) 0x0066)"
    )]
    public const ushort HID_USAGE_DIGITIZER_UTF16_LITTLE_ENDIAN_CHARACTER_GESTURE_ENCODING = (
        (ushort)(0x0066)
    );

    [NativeTypeName(
        "#define HID_USAGE_DIGITIZER_UTF16_BIG_ENDIAN_CHARACTER_GESTURE_ENCODING ((USAGE) 0x0067)"
    )]
    public const ushort HID_USAGE_DIGITIZER_UTF16_BIG_ENDIAN_CHARACTER_GESTURE_ENCODING = (
        (ushort)(0x0067)
    );

    [NativeTypeName(
        "#define HID_USAGE_DIGITIZER_UTF32_LITTLE_ENDIAN_CHARACTER_GESTURE_ENCODING ((USAGE) 0x0068)"
    )]
    public const ushort HID_USAGE_DIGITIZER_UTF32_LITTLE_ENDIAN_CHARACTER_GESTURE_ENCODING = (
        (ushort)(0x0068)
    );

    [NativeTypeName(
        "#define HID_USAGE_DIGITIZER_UTF32_BIG_ENDIAN_CHARACTER_GESTURE_ENCODING ((USAGE) 0x0069)"
    )]
    public const ushort HID_USAGE_DIGITIZER_UTF32_BIG_ENDIAN_CHARACTER_GESTURE_ENCODING = (
        (ushort)(0x0069)
    );

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VENDOR_ID ((USAGE) 0x006A)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VENDOR_ID = ((ushort)(0x006A));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VERSION ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_PROTOCOL_VERSION = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HEAT_MAP_FRAME_DATA ((USAGE) 0x006C)")]
    public const ushort HID_USAGE_DIGITIZER_HEAT_MAP_FRAME_DATA = ((ushort)(0x006C));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_GESTURE_CHARACTER_ENABLE ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_DIGITIZER_GESTURE_CHARACTER_ENABLE = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL_PART2 ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL_PART2 = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_NO_PREFERRED_COLOR ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_DIGITIZER_NO_PREFERRED_COLOR = ((ushort)(0x006F));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_LINE_STYLE ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_LINE_STYLE = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PREFERRED_LINE_STYLE_IS_LOCKED ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_DIGITIZER_PREFERRED_LINE_STYLE_IS_LOCKED = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_INK ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_DIGITIZER_INK = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_PENCIL ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_DIGITIZER_PENCIL = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_HIGHLIGHTER ((USAGE) 0x0074)")]
    public const ushort HID_USAGE_DIGITIZER_HIGHLIGHTER = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_CHISEL_MARKER ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_DIGITIZER_CHISEL_MARKER = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BRUSH ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_DIGITIZER_BRUSH = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_NO_PREFERENCE ((USAGE) 0x0077)")]
    public const ushort HID_USAGE_DIGITIZER_NO_PREFERENCE = ((ushort)(0x0077));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DIGITIZER_DIAGNOSTIC ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_DIGITIZER_DIGITIZER_DIAGNOSTIC = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DIGITIZER_ERROR ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_DIGITIZER_DIGITIZER_ERROR = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ERR_NORMAL_STATUS ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_DIGITIZER_ERR_NORMAL_STATUS = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ERR_TRANSDUCERS_EXCEEDED ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_DIGITIZER_ERR_TRANSDUCERS_EXCEEDED = ((ushort)(0x0083));

    [NativeTypeName(
        "#define HID_USAGE_DIGITIZER_ERR_FULL_TRANS_FEATURES_UNAVAILABLE ((USAGE) 0x0084)"
    )]
    public const ushort HID_USAGE_DIGITIZER_ERR_FULL_TRANS_FEATURES_UNAVAILABLE = (
        (ushort)(0x0084)
    );

    [NativeTypeName("#define HID_USAGE_DIGITIZER_ERR_CHARGE_LOW ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_DIGITIZER_ERR_CHARGE_LOW = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SOFTWARE_INFO ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SOFTWARE_INFO = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_VENDOR ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_VENDOR = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_PRODUCT ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_PRODUCT = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_DEVICE_SUPPORTED_PROTOCOLS ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_DIGITIZER_DEVICE_SUPPORTED_PROTOCOLS = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SUPPORTED_PROTOCOLS ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SUPPORTED_PROTOCOLS = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_NO_PROTOCOL ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_DIGITIZER_NO_PROTOCOL = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_WACOM_AES_PROTOCOL ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_DIGITIZER_WACOM_AES_PROTOCOL = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_USI_PROTOCOL ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_DIGITIZER_USI_PROTOCOL = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_MICROSOFT_PEN_PROTOCOL ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_DIGITIZER_MICROSOFT_PEN_PROTOCOL = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SUPPORTED_REPORT_RATES ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_DIGITIZER_SUPPORTED_REPORT_RATES = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_REPORT_RATE ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_DIGITIZER_REPORT_RATE = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_CONNECTED ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_CONNECTED = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SWITCH_DISABLED ((USAGE) 0x00A3)")]
    public const ushort HID_USAGE_DIGITIZER_SWITCH_DISABLED = ((ushort)(0x00A3));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_SWITCH_UNIMPLEMENTED ((USAGE) 0x00A4)")]
    public const ushort HID_USAGE_DIGITIZER_SWITCH_UNIMPLEMENTED = ((ushort)(0x00A4));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_SWITCHES ((USAGE) 0x00A5)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SWITCHES = ((ushort)(0x00A5));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_TRANSDUCER_INDEX_SELECTOR ((USAGE) 0x00A6)")]
    public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_INDEX_SELECTOR = ((ushort)(0x00A6));

    [NativeTypeName("#define HID_USAGE_DIGITIZER_BUTTON_PRESS_THRESHOLD ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_DIGITIZER_BUTTON_PRESS_THRESHOLD = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_EYE_TRACKER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_EYE_TRACKER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_TRACKER ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_TRACKER = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_TRACKING_DATA ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_TRACKING_DATA = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CAPABILITIES ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CAPABILITIES = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CONFIGURATION ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CONFIGURATION = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_STATUS ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_STATUS = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CONTROL ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CONTROL = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_SENSOR_TIMESTAMP ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_SENSOR_TIMESTAMP = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_X ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_X = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_Y ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_Y = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_Z ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_POSITION_Z = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_GAZE_POINT ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_GAZE_POINT = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_LEFT_EYE_POSITION ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_LEFT_EYE_POSITION = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_RIGHT_EYE_POSITION ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_RIGHT_EYE_POSITION = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_POSITION ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_POSITION = ((ushort)(0x0027));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_DIRECTION_POINT ((USAGE) 0x0028)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_HEAD_DIRECTION_POINT = ((ushort)(0x0028));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_X_AXIS ((USAGE) 0x0029)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_X_AXIS = ((ushort)(0x0029));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_Y_AXIS ((USAGE) 0x002A)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_Y_AXIS = ((ushort)(0x002A));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_Z_AXIS ((USAGE) 0x002B)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_ROTATION_ABOUT_Z_AXIS = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_TRACKER_QUALITY ((USAGE) 0x0100)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_TRACKER_QUALITY = ((ushort)(0x0100));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_MINIMUM_TRACKING_DISTANCE ((USAGE) 0x0101)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_MINIMUM_TRACKING_DISTANCE = (
        (ushort)(0x0101)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_OPTIMUM_TRACKING_DISTANCE ((USAGE) 0x0102)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_OPTIMUM_TRACKING_DISTANCE = (
        (ushort)(0x0102)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_TRACKING_DISTANCE ((USAGE) 0x0103)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_TRACKING_DISTANCE = (
        (ushort)(0x0103)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_SCREEN_PLANE_WIDTH ((USAGE) 0x0104)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_SCREEN_PLANE_WIDTH = (
        (ushort)(0x0104)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_SCREEN_PLANE_HEIGHT ((USAGE) 0x0105)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_MAXIMUM_SCREEN_PLANE_HEIGHT = (
        (ushort)(0x0105)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_MANUFACTURER_ID ((USAGE) 0x0200)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_MANUFACTURER_ID = (
        (ushort)(0x0200)
    );

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_PRODUCT_ID ((USAGE) 0x0201)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_PRODUCT_ID = ((ushort)(0x0201));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_SERIAL_NUMBER ((USAGE) 0x0202)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_SERIAL_NUMBER = ((ushort)(0x0202));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_MANUFACTURER_DATE ((USAGE) 0x0203)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_DISPLAY_MANUFACTURER_DATE = (
        (ushort)(0x0203)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CALIBRATED_SCREEN_WIDTH ((USAGE) 0x0204)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CALIBRATED_SCREEN_WIDTH = (
        (ushort)(0x0204)
    );

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CALIBRATED_SCREEN_HEIGHT ((USAGE) 0x0205)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CALIBRATED_SCREEN_HEIGHT = (
        (ushort)(0x0205)
    );

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_SAMPLING_FREQUENCY ((USAGE) 0x0300)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_SAMPLING_FREQUENCY = ((ushort)(0x0300));

    [NativeTypeName(
        "#define HID_USAGE_EYE_AND_HEAD_TRACKERS_CONFIGURATION_STATUS ((USAGE) 0x0301)"
    )]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_CONFIGURATION_STATUS = ((ushort)(0x0301));

    [NativeTypeName("#define HID_USAGE_EYE_AND_HEAD_TRACKERS_DEVICE_MODE_REQUEST ((USAGE) 0x0400)")]
    public const ushort HID_USAGE_EYE_AND_HEAD_TRACKERS_DEVICE_MODE_REQUEST = ((ushort)(0x0400));

    [NativeTypeName("#define HID_USAGE_FIDO_ALLIANCE_U2F_AUTHENTICATOR_DEVICE ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_FIDO_ALLIANCE_U2F_AUTHENTICATOR_DEVICE = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_FIDO_ALLIANCE_INPUT_REPORT_DATA ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_FIDO_ALLIANCE_INPUT_REPORT_DATA = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_FIDO_ALLIANCE_OUTPUT_REPORT_DATA ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_FIDO_ALLIANCE_OUTPUT_REPORT_DATA = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_GAME_3D_GAME_CONTROLLER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_GAME_3D_GAME_CONTROLLER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_GAME_PINBALL_DEVICE ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_GAME_PINBALL_DEVICE = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_DEVICE ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_GAME_GUN_DEVICE = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_GAME_POV ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_GAME_POV = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_GAME_TURN_RIGHT_LEFT ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_GAME_TURN_RIGHT_LEFT = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_GAME_PITCH_FORWARD_BACK ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_GAME_PITCH_FORWARD_BACK = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_GAME_ROLL_RIGHT_LEFT ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_GAME_ROLL_RIGHT_LEFT = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_RIGHT_LEFT ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_GAME_MOVE_RIGHT_LEFT = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_FORWARD_BACK ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_GAME_MOVE_FORWARD_BACK = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_GAME_MOVE_UP_DOWN ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_GAME_MOVE_UP_DOWN = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_GAME_LEAN_RIGHT_LEFT ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_GAME_LEAN_RIGHT_LEFT = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_GAME_LEAN_FORWARD_BACK ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_GAME_LEAN_FORWARD_BACK = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_GAME_POV_HEIGHT ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_GAME_POV_HEIGHT = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_GAME_FLIPPER ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_GAME_FLIPPER = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_GAME_SECONDARY_FLIPPER ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_GAME_SECONDARY_FLIPPER = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_GAME_BUMP ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_GAME_BUMP = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_GAME_NEW_GAME ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_GAME_NEW_GAME = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_GAME_SHOOT_BALL ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_GAME_SHOOT_BALL = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_GAME_PLAYER ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_GAME_PLAYER = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_BOLT ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_GAME_GUN_BOLT = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_CLIP ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_GAME_GUN_CLIP = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SELECTOR ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_GAME_GUN_SELECTOR = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SINGLE_SHOT ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_GAME_GUN_SINGLE_SHOT = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_BURST ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_GAME_GUN_BURST = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_AUTOMATIC ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_GAME_GUN_AUTOMATIC = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_GAME_GUN_SAFETY ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_GAME_GUN_SAFETY = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_GAME_GAMEPAD_FIRE_JUMP ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_GAME_GAMEPAD_FIRE_JUMP = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_GAME_GAMEPAD_TRIGGER ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_GAME_GAMEPAD_TRIGGER = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_GAME_FORMFITTING_GAMEPAD ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_GAME_FORMFITTING_GAMEPAD = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_GENERIC_POINTER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_GENERIC_POINTER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_GENERIC_MOUSE ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_GENERIC_MOUSE = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_GENERIC_JOYSTICK ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_GENERIC_JOYSTICK = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_GENERIC_GAMEPAD ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_GENERIC_GAMEPAD = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_GENERIC_KEYBOARD ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_GENERIC_KEYBOARD = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_GENERIC_KEYPAD ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_GENERIC_KEYPAD = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_GENERIC_WATER_COOLING_DEVICE ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_GENERIC_WATER_COOLING_DEVICE = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_GENERIC_COMPUTER_CHASSIS_DEVICE ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_GENERIC_COMPUTER_CHASSIS_DEVICE = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_GENERIC_WIRELESS_RADIO_CONTROLS ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_GENERIC_WIRELESS_RADIO_CONTROLS = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL ((USAGE) 0x000D)")]
    public const ushort HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL = ((ushort)(0x000D));

    [NativeTypeName("#define HID_USAGE_GENERIC_INTERACTIVE_CONTROL ((USAGE) 0x000E)")]
    public const ushort HID_USAGE_GENERIC_INTERACTIVE_CONTROL = ((ushort)(0x000E));

    [NativeTypeName("#define HID_USAGE_GENERIC_SPATIAL_CONTROLLER ((USAGE) 0x000F)")]
    public const ushort HID_USAGE_GENERIC_SPATIAL_CONTROLLER = ((ushort)(0x000F));

    [NativeTypeName("#define HID_USAGE_GENERIC_ASSISTIVE_CONTROL ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_GENERIC_ASSISTIVE_CONTROL = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_DOCK ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_DOCK = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_GENERIC_CALL_STATE_MANAGEMENT_CONTROL ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_GENERIC_CALL_STATE_MANAGEMENT_CONTROL = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_GENERIC_X ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_GENERIC_X = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_GENERIC_Y ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_GENERIC_Y = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_GENERIC_Z ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_GENERIC_Z = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_GENERIC_RX ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_GENERIC_RX = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_GENERIC_RY ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_GENERIC_RY = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_GENERIC_RZ ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_GENERIC_RZ = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_GENERIC_SLIDER ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_GENERIC_SLIDER = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_GENERIC_DIAL ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_GENERIC_DIAL = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_GENERIC_WHEEL ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_GENERIC_WHEEL = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_GENERIC_HATSWITCH ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_GENERIC_HATSWITCH = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_GENERIC_COUNTED_BUFFER ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_GENERIC_COUNTED_BUFFER = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_GENERIC_BYTE_COUNT ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_GENERIC_BYTE_COUNT = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_GENERIC_MOTION_WAKEUP ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_GENERIC_MOTION_WAKEUP = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_GENERIC_START ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_GENERIC_START = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_GENERIC_SELECT ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_GENERIC_SELECT = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_GENERIC_VX ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_GENERIC_VX = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_GENERIC_VY ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_GENERIC_VY = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_GENERIC_VZ ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_GENERIC_VZ = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRX ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_GENERIC_VBRX = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRY ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_GENERIC_VBRY = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_GENERIC_VBRZ ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_GENERIC_VBRZ = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_GENERIC_VNO ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_GENERIC_VNO = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_GENERIC_FEATURE_NOTIFICATION ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_GENERIC_FEATURE_NOTIFICATION = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_GENERIC_QX ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_GENERIC_QX = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_GENERIC_QY ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_GENERIC_QY = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_GENERIC_QZ ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_GENERIC_QZ = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_GENERIC_QW ((USAGE) 0x004C)")]
    public const ushort HID_USAGE_GENERIC_QW = ((ushort)(0x004C));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSTEM_CTL ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_GENERIC_SYSTEM_CTL = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_POWER ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_POWER = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SLEEP ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SLEEP = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_WAKE ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_WAKE = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MAIN_MENU ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MAIN_MENU = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_MENU ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_MENU = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_HELP_MENU ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_HELP_MENU = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_EXIT ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_EXIT = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_SELECT ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_SELECT = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_LEFT ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_LEFT = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_UP ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_UP = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MENU_DOWN ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_DOWN = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_COLD_RESTART ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_COLD_RESTART = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_WARM_RESTART ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_WARM_RESTART = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_UP ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_GENERIC_DPAD_UP = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_DOWN ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_GENERIC_DPAD_DOWN = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_RIGHT ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_GENERIC_DPAD_RIGHT = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_GENERIC_DPAD_LEFT ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_GENERIC_DPAD_LEFT = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_GENERIC_INDEX_TRIGGER ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_GENERIC_INDEX_TRIGGER = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_GENERIC_PALM_TRIGGER ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_GENERIC_PALM_TRIGGER = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_GENERIC_THUMBSTICK ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_GENERIC_THUMBSTICK = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN_LOCK ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN_LOCK = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_FN_LOCK_INDICATOR ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_FN_LOCK_INDICATOR = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSTEM_DO_NOT_DISTURB ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_GENERIC_SYSTEM_DO_NOT_DISTURB = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DOCK ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DOCK = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_UNDOCK ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_UNDOCK = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SETUP ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SETUP = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SYS_BREAK ((USAGE) 0x00A3)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_BREAK = ((ushort)(0x00A3));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK ((USAGE) 0x00A4)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK = ((ushort)(0x00A4));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_BREAK ((USAGE) 0x00A5)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_BREAK = ((ushort)(0x00A5));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK ((USAGE) 0x00A6)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK = ((ushort)(0x00A6));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MUTE ((USAGE) 0x00A7)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MUTE = ((ushort)(0x00A7));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_HIBERNATE ((USAGE) 0x00A8)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_HIBERNATE = ((ushort)(0x00A8));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_MICROPHONE_MUTE ((USAGE) 0x00A9)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_MICROPHONE_MUTE = ((ushort)(0x00A9));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_ACCESSIBILITY_BINDING ((USAGE) 0x00AA)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_ACCESSIBILITY_BINDING = ((ushort)(0x00AA));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_INVERT ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INVERT = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_BOTH ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_BOTH = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_DUAL ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_DUAL = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_SWAP ((USAGE) 0x00B6)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_SWAP = ((ushort)(0x00B6));

    [NativeTypeName("#define HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_GENERIC_SENSOR_ZONE ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_GENERIC_SENSOR_ZONE = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_GENERIC_RPM ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_GENERIC_RPM = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_GENERIC_COOLANT_LEVEL ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_GENERIC_COOLANT_LEVEL = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_GENERIC_COOLANT_CRITICAL_LEVEL ((USAGE) 0x00C3)")]
    public const ushort HID_USAGE_GENERIC_COOLANT_CRITICAL_LEVEL = ((ushort)(0x00C3));

    [NativeTypeName("#define HID_USAGE_GENERIC_COOLANT_PUMP ((USAGE) 0x00C4)")]
    public const ushort HID_USAGE_GENERIC_COOLANT_PUMP = ((ushort)(0x00C4));

    [NativeTypeName("#define HID_USAGE_GENERIC_CHASSIS_ENCLOSURE ((USAGE) 0x00C5)")]
    public const ushort HID_USAGE_GENERIC_CHASSIS_ENCLOSURE = ((ushort)(0x00C5));

    [NativeTypeName("#define HID_USAGE_GENERIC_WIRELESS_RADIO_BUTTON ((USAGE) 0x00C6)")]
    public const ushort HID_USAGE_GENERIC_WIRELESS_RADIO_BUTTON = ((ushort)(0x00C6));

    [NativeTypeName("#define HID_USAGE_GENERIC_WIRELESS_RADIO_LED ((USAGE) 0x00C7)")]
    public const ushort HID_USAGE_GENERIC_WIRELESS_RADIO_LED = ((ushort)(0x00C7));

    [NativeTypeName("#define HID_USAGE_GENERIC_WIRELESS_RADIO_SLIDER_SWITCH ((USAGE) 0x00C8)")]
    public const ushort HID_USAGE_GENERIC_WIRELESS_RADIO_SLIDER_SWITCH = ((ushort)(0x00C8));

    [NativeTypeName(
        "#define HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON ((USAGE) 0x00C9)"
    )]
    public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON = ((ushort)(0x00C9));

    [NativeTypeName(
        "#define HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH ((USAGE) 0x00CA)"
    )]
    public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH = (
        (ushort)(0x00CA)
    );

    [NativeTypeName("#define HID_USAGE_GENERIC_CONTROL_ENABLE ((USAGE) 0x00CB)")]
    public const ushort HID_USAGE_GENERIC_CONTROL_ENABLE = ((ushort)(0x00CB));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_UNIQUE_ID ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_UNIQUE_ID = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_VENDOR_ID ((USAGE) 0x00D1)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_VENDOR_ID = ((ushort)(0x00D1));

    [NativeTypeName(
        "#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_PRIMARY_USAGE_PAGE ((USAGE) 0x00D2)"
    )]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_PRIMARY_USAGE_PAGE = ((ushort)(0x00D2));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_PRIMARY_USAGE_ID ((USAGE) 0x00D3)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_PRIMARY_USAGE_ID = ((ushort)(0x00D3));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_DOCKING_STATE ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_DOCKING_STATE = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_DISPLAY_OCCLUSION ((USAGE) 0x00D5)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_DISPLAY_OCCLUSION = ((ushort)(0x00D5));

    [NativeTypeName("#define HID_USAGE_GENERIC_DOCKABLE_DEVICE_OBJECT_TYPE ((USAGE) 0x00D6)")]
    public const ushort HID_USAGE_GENERIC_DOCKABLE_DEVICE_OBJECT_TYPE = ((ushort)(0x00D6));

    [NativeTypeName("#define HID_USAGE_GENERIC_CALL_ACTIVE_LED ((USAGE) 0x00E0)")]
    public const ushort HID_USAGE_GENERIC_CALL_ACTIVE_LED = ((ushort)(0x00E0));

    [NativeTypeName("#define HID_USAGE_GENERIC_CALL_MUTE_TOGGLE ((USAGE) 0x00E1)")]
    public const ushort HID_USAGE_GENERIC_CALL_MUTE_TOGGLE = ((ushort)(0x00E1));

    [NativeTypeName("#define HID_USAGE_GENERIC_CALL_MUTE_LED ((USAGE) 0x00E2)")]
    public const ushort HID_USAGE_GENERIC_CALL_MUTE_LED = ((ushort)(0x00E2));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_BACKGROUNDNONUSER_CONTROLS ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_BACKGROUNDNONUSER_CONTROLS = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_WIRELESS_ID ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_ID = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SEQUENCE_ID ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SEQUENCE_ID = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SEQUENCE_ID_RESET ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SEQUENCE_ID_RESET = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_RF_SIGNAL_STRENGTH ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_RF_SIGNAL_STRENGTH = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_SOFTWARE_VERSION ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_SOFTWARE_VERSION = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_PROTOCOL_VERSION ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_PROTOCOL_VERSION = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_HARDWARE_VERSION ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_HARDWARE_VERSION = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_MAJOR ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_MAJOR = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_MINOR ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_MINOR = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_REVISION ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_REVISION = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_HANDEDNESS ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_HANDEDNESS = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_EITHER_HAND ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_EITHER_HAND = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_LEFT_HAND ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_LEFT_HAND = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_RIGHT_HAND ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_RIGHT_HAND = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_BOTH_HANDS ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_BOTH_HANDS = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_GRIP_POSE_OFFSET ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_GRIP_POSE_OFFSET = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_GENERIC_DEVICE_POINTER_POSE_OFFSET ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_GENERIC_DEVICE_POINTER_POSE_OFFSET = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_HAPTICS_SIMPLE_CONTROLLER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_HAPTICS_SIMPLE_CONTROLLER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_LIST ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_LIST = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_HAPTICS_DURATION_LIST ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_HAPTICS_DURATION_LIST = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_HAPTICS_AUTO_TRIGGER ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_HAPTICS_AUTO_TRIGGER = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_HAPTICS_MANUAL_TRIGGER ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_HAPTICS_MANUAL_TRIGGER = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_HAPTICS_INTENSITY ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_HAPTICS_INTENSITY = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_HAPTICS_REPEAT_COUNT ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_HAPTICS_REPEAT_COUNT = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_HAPTICS_RETRIGGER_PERIOD ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_HAPTICS_RETRIGGER_PERIOD = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_NONE ((USAGE) 0x1001)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_NONE = ((ushort)(0x1001));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_STOP ((USAGE) 0x1002)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_STOP = ((ushort)(0x1002));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_CLICK ((USAGE) 0x1003)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_CLICK = ((ushort)(0x1003));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_BUZZ ((USAGE) 0x1004)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_BUZZ = ((ushort)(0x1004));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_RUMBLE ((USAGE) 0x1005)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_RUMBLE = ((ushort)(0x1005));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_PRESS ((USAGE) 0x1006)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_PRESS = ((ushort)(0x1006));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_RELEASE ((USAGE) 0x1007)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_RELEASE = ((ushort)(0x1007));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_HOVER ((USAGE) 0x1008)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_HOVER = ((ushort)(0x1008));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_SUCCESS ((USAGE) 0x1009)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_SUCCESS = ((ushort)(0x1009));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_ERROR ((USAGE) 0x100A)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_ERROR = ((ushort)(0x100A));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_INK_CONTINUOUS ((USAGE) 0x100B)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_INK_CONTINUOUS = ((ushort)(0x100B));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_PENCIL_CONTINUOUS ((USAGE) 0x100C)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_PENCIL_CONTINUOUS = ((ushort)(0x100C));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_MARKER_CONTINUOUS ((USAGE) 0x100D)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_MARKER_CONTINUOUS = ((ushort)(0x100D));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_CHISEL_MARKER_CONTINUOUS ((USAGE) 0x100E)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_CHISEL_MARKER_CONTINUOUS = ((ushort)(0x100E));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_BRUSH_CONTINUOUS ((USAGE) 0x100F)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_BRUSH_CONTINUOUS = ((ushort)(0x100F));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_ERASER_CONTINUOUS ((USAGE) 0x1010)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_ERASER_CONTINUOUS = ((ushort)(0x1010));

    [NativeTypeName("#define HID_USAGE_HAPTICS_WAVEFORM_SPARKLE_CONTINUOUS ((USAGE) 0x1011)")]
    public const ushort HID_USAGE_HAPTICS_WAVEFORM_SPARKLE_CONTINUOUS = ((ushort)(0x1011));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NOEVENT ((USAGE) 0x0000)")]
    public const ushort HID_USAGE_KEYBOARD_NOEVENT = ((ushort)(0x0000));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ROLLOVER ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_KEYBOARD_ROLLOVER = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_POSTFAIL ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_KEYBOARD_POSTFAIL = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_UNDEFINED ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_KEYBOARD_UNDEFINED = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_aA ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_KEYBOARD_aA = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_bB ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_KEYBOARD_bB = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_cC ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_KEYBOARD_cC = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_dD ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_KEYBOARD_dD = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_eE ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_KEYBOARD_eE = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_fF ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_KEYBOARD_fF = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_gG ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_KEYBOARD_gG = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_hH ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_KEYBOARD_hH = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_iI ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_KEYBOARD_iI = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_jJ ((USAGE) 0x000D)")]
    public const ushort HID_USAGE_KEYBOARD_jJ = ((ushort)(0x000D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_kK ((USAGE) 0x000E)")]
    public const ushort HID_USAGE_KEYBOARD_kK = ((ushort)(0x000E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_lL ((USAGE) 0x000F)")]
    public const ushort HID_USAGE_KEYBOARD_lL = ((ushort)(0x000F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_mM ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_KEYBOARD_mM = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_nN ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_KEYBOARD_nN = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_oO ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_KEYBOARD_oO = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_pP ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_KEYBOARD_pP = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_qQ ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_KEYBOARD_qQ = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_rR ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_KEYBOARD_rR = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_sS ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_KEYBOARD_sS = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_tT ((USAGE) 0x0017)")]
    public const ushort HID_USAGE_KEYBOARD_tT = ((ushort)(0x0017));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_uU ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_KEYBOARD_uU = ((ushort)(0x0018));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_vV ((USAGE) 0x0019)")]
    public const ushort HID_USAGE_KEYBOARD_vV = ((ushort)(0x0019));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_wW ((USAGE) 0x001A)")]
    public const ushort HID_USAGE_KEYBOARD_wW = ((ushort)(0x001A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_xX ((USAGE) 0x001B)")]
    public const ushort HID_USAGE_KEYBOARD_xX = ((ushort)(0x001B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_yY ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_KEYBOARD_yY = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_zZ ((USAGE) 0x001D)")]
    public const ushort HID_USAGE_KEYBOARD_zZ = ((ushort)(0x001D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ONE ((USAGE) 0x001E)")]
    public const ushort HID_USAGE_KEYBOARD_ONE = ((ushort)(0x001E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_TWO_AND_AT ((USAGE) 0x001F)")]
    public const ushort HID_USAGE_KEYBOARD_TWO_AND_AT = ((ushort)(0x001F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_THREE_AND_HASH ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_KEYBOARD_THREE_AND_HASH = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_FOUR_AND_DOLLAR ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_KEYBOARD_FOUR_AND_DOLLAR = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_FIVE_AND_PERCENT ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_KEYBOARD_FIVE_AND_PERCENT = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SIX_AND_CARET ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_KEYBOARD_SIX_AND_CARET = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SEVEN_AND_AMPERSAND ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_KEYBOARD_SEVEN_AND_AMPERSAND = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_EIGHT_AND_STAR ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_KEYBOARD_EIGHT_AND_STAR = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NINE_AND_LEFT_BRACKET ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_KEYBOARD_NINE_AND_LEFT_BRACKET = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ZERO ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_KEYBOARD_ZERO = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RETURN ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_KEYBOARD_RETURN = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ESCAPE ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_KEYBOARD_ESCAPE = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DELETE ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_KEYBOARD_DELETE = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_TAB ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_KEYBOARD_TAB = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SPACEBAR ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_KEYBOARD_SPACEBAR = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DASH_AND_UNDERSCORE ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_KEYBOARD_DASH_AND_UNDERSCORE = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_EQUALS_AND_PLUS ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_KEYBOARD_EQUALS_AND_PLUS = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LEFT_BRACE ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_KEYBOARD_LEFT_BRACE = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RIGHT_BRACE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_KEYBOARD_RIGHT_BRACE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_BACKSLASH_AND_PIPE ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_KEYBOARD_BACKSLASH_AND_PIPE = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NONUS_HASH_AND_TILDE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_KEYBOARD_NONUS_HASH_AND_TILDE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SEMICOLON_AND_COLON ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_KEYBOARD_SEMICOLON_AND_COLON = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LEFT_APOS_AND_DOUBLE ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_KEYBOARD_LEFT_APOS_AND_DOUBLE = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_GRAVE_ACCENT_AND_TILDE ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_KEYBOARD_GRAVE_ACCENT_AND_TILDE = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_COMMA_AND_LESSTHAN ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_KEYBOARD_COMMA_AND_LESSTHAN = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PERIOD_AND_GREATERTHAN ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_KEYBOARD_PERIOD_AND_GREATERTHAN = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_FORWARDSLASH_AND_QUESTIONMARK ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_KEYBOARD_FORWARDSLASH_AND_QUESTIONMARK = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CAPS_LOCK ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_KEYBOARD_CAPS_LOCK = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F1 ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_KEYBOARD_F1 = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F2 ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_KEYBOARD_F2 = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F3 ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_KEYBOARD_F3 = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F4 ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_KEYBOARD_F4 = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F5 ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_KEYBOARD_F5 = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F6 ((USAGE) 0x003F)")]
    public const ushort HID_USAGE_KEYBOARD_F6 = ((ushort)(0x003F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F7 ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_KEYBOARD_F7 = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F8 ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_KEYBOARD_F8 = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F9 ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_KEYBOARD_F9 = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F10 ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_KEYBOARD_F10 = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F11 ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_KEYBOARD_F11 = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F12 ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_KEYBOARD_F12 = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PRINT_SCREEN ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_KEYBOARD_PRINT_SCREEN = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SCROLL_LOCK ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_KEYBOARD_SCROLL_LOCK = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PAUSE ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_KEYBOARD_PAUSE = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INSERT ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_KEYBOARD_INSERT = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_HOME ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_KEYBOARD_HOME = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PAGEUP ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_KEYBOARD_PAGEUP = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DELETE_FORWARD ((USAGE) 0x004C)")]
    public const ushort HID_USAGE_KEYBOARD_DELETE_FORWARD = ((ushort)(0x004C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_END ((USAGE) 0x004D)")]
    public const ushort HID_USAGE_KEYBOARD_END = ((ushort)(0x004D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PAGEDOWN ((USAGE) 0x004E)")]
    public const ushort HID_USAGE_KEYBOARD_PAGEDOWN = ((ushort)(0x004E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RIGHTARROW ((USAGE) 0x004F)")]
    public const ushort HID_USAGE_KEYBOARD_RIGHTARROW = ((ushort)(0x004F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LEFTARROW ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_KEYBOARD_LEFTARROW = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DOWNARROW ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_KEYBOARD_DOWNARROW = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_UPARROW ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_KEYBOARD_UPARROW = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NUM_LOCK ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_KEYBOARD_NUM_LOCK = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_FORWARDSLASH ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_FORWARDSLASH = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_STAR ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_STAR = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DASH ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_KEYBOARD_DASH = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_PLUS ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_PLUS = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_ENTER ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_ENTER = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_ONE_AND_END ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_ONE_AND_END = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_TWO_AND_DOWN_ARROW ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_TWO_AND_DOWN_ARROW = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_THREE_AND_PAGEDN ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_THREE_AND_PAGEDN = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_FOUR_AND_LEFT_ARROW ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_FOUR_AND_LEFT_ARROW = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_FIVE ((USAGE) 0x005D)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_FIVE = ((ushort)(0x005D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_SIX_AND_RIGHT_ARROW ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_SIX_AND_RIGHT_ARROW = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_SEVEN_AND_HOME ((USAGE) 0x005F)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_SEVEN_AND_HOME = ((ushort)(0x005F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_EIGHT_AND_UP_ARROW ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_EIGHT_AND_UP_ARROW = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_NINE_AND_PAGEUP ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_NINE_AND_PAGEUP = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_ZERO_AND_INSERT ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_ZERO_AND_INSERT = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_PERIOD_AND_DELETE ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_PERIOD_AND_DELETE = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_NONUS_BACKSLASH_AND_PIPE ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_KEYBOARD_NONUS_BACKSLASH_AND_PIPE = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_APPLICATION ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_KEYBOARD_APPLICATION = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_POWER ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_KEYBOARD_POWER = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_EQUALS ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_EQUALS = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F13 ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_KEYBOARD_F13 = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F14 ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_KEYBOARD_F14 = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F15 ((USAGE) 0x006A)")]
    public const ushort HID_USAGE_KEYBOARD_F15 = ((ushort)(0x006A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F16 ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_KEYBOARD_F16 = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F17 ((USAGE) 0x006C)")]
    public const ushort HID_USAGE_KEYBOARD_F17 = ((ushort)(0x006C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F18 ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_KEYBOARD_F18 = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F19 ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_KEYBOARD_F19 = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F20 ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_KEYBOARD_F20 = ((ushort)(0x006F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F21 ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_KEYBOARD_F21 = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F22 ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_KEYBOARD_F22 = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F23 ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_KEYBOARD_F23 = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_F24 ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_KEYBOARD_F24 = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_EXECUTE ((USAGE) 0x0074)")]
    public const ushort HID_USAGE_KEYBOARD_EXECUTE = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_HELP ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_KEYBOARD_HELP = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_MENU ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_KEYBOARD_MENU = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SELECT ((USAGE) 0x0077)")]
    public const ushort HID_USAGE_KEYBOARD_SELECT = ((ushort)(0x0077));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_STOP ((USAGE) 0x0078)")]
    public const ushort HID_USAGE_KEYBOARD_STOP = ((ushort)(0x0078));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_AGAIN ((USAGE) 0x0079)")]
    public const ushort HID_USAGE_KEYBOARD_AGAIN = ((ushort)(0x0079));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_UNDO ((USAGE) 0x007A)")]
    public const ushort HID_USAGE_KEYBOARD_UNDO = ((ushort)(0x007A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CUT ((USAGE) 0x007B)")]
    public const ushort HID_USAGE_KEYBOARD_CUT = ((ushort)(0x007B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_COPY ((USAGE) 0x007C)")]
    public const ushort HID_USAGE_KEYBOARD_COPY = ((ushort)(0x007C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PASTE ((USAGE) 0x007D)")]
    public const ushort HID_USAGE_KEYBOARD_PASTE = ((ushort)(0x007D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_FIND ((USAGE) 0x007E)")]
    public const ushort HID_USAGE_KEYBOARD_FIND = ((ushort)(0x007E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_MUTE ((USAGE) 0x007F)")]
    public const ushort HID_USAGE_KEYBOARD_MUTE = ((ushort)(0x007F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_VOLUME_UP ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_KEYBOARD_VOLUME_UP = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_VOLUME_DOWN ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_KEYBOARD_VOLUME_DOWN = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LOCKING_CAPS_LOCK ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_KEYBOARD_LOCKING_CAPS_LOCK = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LOCKING_NUM_LOCK ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_KEYBOARD_LOCKING_NUM_LOCK = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LOCKING_SCROLL_LOCK ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_KEYBOARD_LOCKING_SCROLL_LOCK = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_COMMA ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_COMMA = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_EQUAL_SIGN ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_EQUAL_SIGN = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL1 ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL1 = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL2 ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL2 = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL3 ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL3 = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL4 ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL4 = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL5 ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL5 = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL6 ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL6 = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL7 ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL7 = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL8 ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL8 = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_INTERNATIONAL9 ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_KEYBOARD_INTERNATIONAL9 = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG1 ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_KEYBOARD_LANG1 = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG2 ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_KEYBOARD_LANG2 = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG3 ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_KEYBOARD_LANG3 = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG4 ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_KEYBOARD_LANG4 = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG5 ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_KEYBOARD_LANG5 = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG6 ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_KEYBOARD_LANG6 = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG7 ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_KEYBOARD_LANG7 = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG8 ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_KEYBOARD_LANG8 = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LANG9 ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_KEYBOARD_LANG9 = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_ALTERNATE_ERASE ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_KEYBOARD_ALTERNATE_ERASE = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SYSREQ_ATTENTION ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_KEYBOARD_SYSREQ_ATTENTION = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CANCEL ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_KEYBOARD_CANCEL = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CLEAR ((USAGE) 0x009C)")]
    public const ushort HID_USAGE_KEYBOARD_CLEAR = ((ushort)(0x009C));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_PRIOR ((USAGE) 0x009D)")]
    public const ushort HID_USAGE_KEYBOARD_PRIOR = ((ushort)(0x009D));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RETURN_NO_ENTER ((USAGE) 0x009E)")]
    public const ushort HID_USAGE_KEYBOARD_RETURN_NO_ENTER = ((ushort)(0x009E));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_SEPARATOR ((USAGE) 0x009F)")]
    public const ushort HID_USAGE_KEYBOARD_SEPARATOR = ((ushort)(0x009F));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_OUT ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_KEYBOARD_OUT = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_OPER ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_KEYBOARD_OPER = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CLEAR_AGAIN ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_KEYBOARD_CLEAR_AGAIN = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CRSEL_PROPS ((USAGE) 0x00A3)")]
    public const ushort HID_USAGE_KEYBOARD_CRSEL_PROPS = ((ushort)(0x00A3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_EXSEL ((USAGE) 0x00A4)")]
    public const ushort HID_USAGE_KEYBOARD_EXSEL = ((ushort)(0x00A4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_0 ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_0 = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_TRIPLE_0 ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_TRIPLE_0 = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_THOUSANDS_SEPARATOR ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_KEYBOARD_THOUSANDS_SEPARATOR = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_DECIMAL_SEPARATOR ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_KEYBOARD_DECIMAL_SEPARATOR = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CURRENCY_UNIT ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_KEYBOARD_CURRENCY_UNIT = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_CURRENCY_SUBUNIT ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_KEYBOARD_CURRENCY_SUBUNIT = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_LEFT_BRACKET ((USAGE) 0x00B6)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_LEFT_BRACKET = ((ushort)(0x00B6));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_RIGHT_BRACKET ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_RIGHT_BRACKET = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_LEFT_BRACE ((USAGE) 0x00B8)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_LEFT_BRACE = ((ushort)(0x00B8));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_RIGHT_BRACE ((USAGE) 0x00B9)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_RIGHT_BRACE = ((ushort)(0x00B9));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_TAB ((USAGE) 0x00BA)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_TAB = ((ushort)(0x00BA));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_BACKSPACE ((USAGE) 0x00BB)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_BACKSPACE = ((ushort)(0x00BB));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_A ((USAGE) 0x00BC)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_A = ((ushort)(0x00BC));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_B ((USAGE) 0x00BD)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_B = ((ushort)(0x00BD));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_C ((USAGE) 0x00BE)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_C = ((ushort)(0x00BE));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_D ((USAGE) 0x00BF)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_D = ((ushort)(0x00BF));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_E ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_E = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_F ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_F = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_XOR ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_XOR = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_CARET ((USAGE) 0x00C3)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_CARET = ((ushort)(0x00C3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_PERCENTAGE ((USAGE) 0x00C4)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_PERCENTAGE = ((ushort)(0x00C4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_LESS ((USAGE) 0x00C5)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_LESS = ((ushort)(0x00C5));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_GREATER ((USAGE) 0x00C6)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_GREATER = ((ushort)(0x00C6));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_AMPERSAND ((USAGE) 0x00C7)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_AMPERSAND = ((ushort)(0x00C7));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_AMPERSAND ((USAGE) 0x00C8)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_AMPERSAND = ((ushort)(0x00C8));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_BAR ((USAGE) 0x00C9)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_BAR = ((ushort)(0x00C9));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_BAR ((USAGE) 0x00CA)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_DOUBLE_BAR = ((ushort)(0x00CA));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_COLON ((USAGE) 0x00CB)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_COLON = ((ushort)(0x00CB));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_HASH ((USAGE) 0x00CC)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_HASH = ((ushort)(0x00CC));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_SPACE ((USAGE) 0x00CD)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_SPACE = ((ushort)(0x00CD));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_AT ((USAGE) 0x00CE)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_AT = ((ushort)(0x00CE));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_BANG ((USAGE) 0x00CF)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_BANG = ((ushort)(0x00CF));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_STORE ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_STORE = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_RECALL ((USAGE) 0x00D1)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_RECALL = ((ushort)(0x00D1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_CLEAR ((USAGE) 0x00D2)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_CLEAR = ((ushort)(0x00D2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_ADD ((USAGE) 0x00D3)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_ADD = ((ushort)(0x00D3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_SUBTRACT ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_SUBTRACT = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_MULTIPLY ((USAGE) 0x00D5)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_MULTIPLY = ((ushort)(0x00D5));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_MEMORY_DIVIDE ((USAGE) 0x00D6)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_MEMORY_DIVIDE = ((ushort)(0x00D6));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_PLUS_MINUS ((USAGE) 0x00D7)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_PLUS_MINUS = ((ushort)(0x00D7));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_CLEAR ((USAGE) 0x00D8)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_CLEAR = ((ushort)(0x00D8));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_CLEAR_ENTRY ((USAGE) 0x00D9)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_CLEAR_ENTRY = ((ushort)(0x00D9));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_BINARY ((USAGE) 0x00DA)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_BINARY = ((ushort)(0x00DA));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_OCTAL ((USAGE) 0x00DB)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_OCTAL = ((ushort)(0x00DB));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_DECIMAL ((USAGE) 0x00DC)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_DECIMAL = ((ushort)(0x00DC));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_KEYPAD_HEXADECIMAL ((USAGE) 0x00DD)")]
    public const ushort HID_USAGE_KEYBOARD_KEYPAD_HEXADECIMAL = ((ushort)(0x00DD));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LCTRL ((USAGE) 0x00E0)")]
    public const ushort HID_USAGE_KEYBOARD_LCTRL = ((ushort)(0x00E0));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LSHFT ((USAGE) 0x00E1)")]
    public const ushort HID_USAGE_KEYBOARD_LSHFT = ((ushort)(0x00E1));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LALT ((USAGE) 0x00E2)")]
    public const ushort HID_USAGE_KEYBOARD_LALT = ((ushort)(0x00E2));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_LGUI ((USAGE) 0x00E3)")]
    public const ushort HID_USAGE_KEYBOARD_LGUI = ((ushort)(0x00E3));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RCTRL ((USAGE) 0x00E4)")]
    public const ushort HID_USAGE_KEYBOARD_RCTRL = ((ushort)(0x00E4));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RSHFT ((USAGE) 0x00E5)")]
    public const ushort HID_USAGE_KEYBOARD_RSHFT = ((ushort)(0x00E5));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RALT ((USAGE) 0x00E6)")]
    public const ushort HID_USAGE_KEYBOARD_RALT = ((ushort)(0x00E6));

    [NativeTypeName("#define HID_USAGE_KEYBOARD_RGUI ((USAGE) 0x00E7)")]
    public const ushort HID_USAGE_KEYBOARD_RGUI = ((ushort)(0x00E7));

    [NativeTypeName("#define HID_USAGE_LED_NUM_LOCK ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_LED_NUM_LOCK = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_LED_CAPS_LOCK ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_LED_CAPS_LOCK = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_LED_SCROLL_LOCK ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_LED_SCROLL_LOCK = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_LED_COMPOSE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_LED_COMPOSE = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_LED_KANA ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_LED_KANA = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_LED_POWER ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_LED_POWER = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_LED_SHIFT ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_LED_SHIFT = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_LED_DO_NOT_DISTURB ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_LED_DO_NOT_DISTURB = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_LED_MUTE ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_LED_MUTE = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_LED_TONE_ENABLE ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_LED_TONE_ENABLE = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_LED_HIGH_CUT_FILTER ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_LED_HIGH_CUT_FILTER = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_LED_LOW_CUT_FILTER ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_LED_LOW_CUT_FILTER = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_LED_EQUALIZER_ENABLE ((USAGE) 0x000D)")]
    public const ushort HID_USAGE_LED_EQUALIZER_ENABLE = ((ushort)(0x000D));

    [NativeTypeName("#define HID_USAGE_LED_SOUND_FIELD_ON ((USAGE) 0x000E)")]
    public const ushort HID_USAGE_LED_SOUND_FIELD_ON = ((ushort)(0x000E));

    [NativeTypeName("#define HID_USAGE_LED_SURROUND_FIELD_ON ((USAGE) 0x000F)")]
    public const ushort HID_USAGE_LED_SURROUND_FIELD_ON = ((ushort)(0x000F));

    [NativeTypeName("#define HID_USAGE_LED_REPEAT ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_LED_REPEAT = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_LED_STEREO ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_LED_STEREO = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_LED_SAMPLING_RATE_DETECT ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_LED_SAMPLING_RATE_DETECT = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_LED_SPINNING ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_LED_SPINNING = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_LED_CAV ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_LED_CAV = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_LED_CLV ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_LED_CLV = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_LED_RECORDING_FORMAT_DET ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_LED_RECORDING_FORMAT_DET = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_LED_OFF_HOOK ((USAGE) 0x0017)")]
    public const ushort HID_USAGE_LED_OFF_HOOK = ((ushort)(0x0017));

    [NativeTypeName("#define HID_USAGE_LED_RING ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_LED_RING = ((ushort)(0x0018));

    [NativeTypeName("#define HID_USAGE_LED_MESSAGE_WAITING ((USAGE) 0x0019)")]
    public const ushort HID_USAGE_LED_MESSAGE_WAITING = ((ushort)(0x0019));

    [NativeTypeName("#define HID_USAGE_LED_DATA_MODE ((USAGE) 0x001A)")]
    public const ushort HID_USAGE_LED_DATA_MODE = ((ushort)(0x001A));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_OPERATION ((USAGE) 0x001B)")]
    public const ushort HID_USAGE_LED_BATTERY_OPERATION = ((ushort)(0x001B));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_OK ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_LED_BATTERY_OK = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_LED_BATTERY_LOW ((USAGE) 0x001D)")]
    public const ushort HID_USAGE_LED_BATTERY_LOW = ((ushort)(0x001D));

    [NativeTypeName("#define HID_USAGE_LED_SPEAKER ((USAGE) 0x001E)")]
    public const ushort HID_USAGE_LED_SPEAKER = ((ushort)(0x001E));

    [NativeTypeName("#define HID_USAGE_LED_HEAD_SET ((USAGE) 0x001F)")]
    public const ushort HID_USAGE_LED_HEAD_SET = ((ushort)(0x001F));

    [NativeTypeName("#define HID_USAGE_LED_HOLD ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_LED_HOLD = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_LED_MICROPHONE ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_LED_MICROPHONE = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_LED_COVERAGE ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_LED_COVERAGE = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_LED_NIGHT_MODE ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_LED_NIGHT_MODE = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_LED_SEND_CALLS ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_LED_SEND_CALLS = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_LED_CALL_PICKUP ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_LED_CALL_PICKUP = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_LED_CONFERENCE ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_LED_CONFERENCE = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_LED_STAND_BY ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_LED_STAND_BY = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_LED_CAMERA_ON ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_LED_CAMERA_ON = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_LED_CAMERA_OFF ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_LED_CAMERA_OFF = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_LED_ON_LINE ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_LED_ON_LINE = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_LED_OFF_LINE ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_LED_OFF_LINE = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_LED_BUSY ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_LED_BUSY = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_LED_READY ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_LED_READY = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_LED_PAPER_OUT ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_LED_PAPER_OUT = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_LED_PAPER_JAM ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_LED_PAPER_JAM = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_LED_REMOTE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_LED_REMOTE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_LED_FORWARD ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_LED_FORWARD = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_LED_REVERSE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_LED_REVERSE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_LED_STOP ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_LED_STOP = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_LED_REWIND ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_LED_REWIND = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_LED_FAST_FORWARD ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_LED_FAST_FORWARD = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_LED_PLAY ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_LED_PLAY = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_LED_PAUSE ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_LED_PAUSE = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_LED_RECORD ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_LED_RECORD = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_LED_ERROR ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_LED_ERROR = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_LED_SELECTED_INDICATOR ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_LED_SELECTED_INDICATOR = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_LED_IN_USE_INDICATOR ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_LED_IN_USE_INDICATOR = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_LED_MULTI_MODE_INDICATOR ((USAGE) 0x003C)")]
    public const ushort HID_USAGE_LED_MULTI_MODE_INDICATOR = ((ushort)(0x003C));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_ON ((USAGE) 0x003D)")]
    public const ushort HID_USAGE_LED_INDICATOR_ON = ((ushort)(0x003D));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_FLASH ((USAGE) 0x003E)")]
    public const ushort HID_USAGE_LED_INDICATOR_FLASH = ((ushort)(0x003E));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_SLOW_BLINK ((USAGE) 0x003F)")]
    public const ushort HID_USAGE_LED_INDICATOR_SLOW_BLINK = ((ushort)(0x003F));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_FAST_BLINK ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_LED_INDICATOR_FAST_BLINK = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_OFF ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_LED_INDICATOR_OFF = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_LED_FLASH_ON_TIME ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_LED_FLASH_ON_TIME = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_LED_SLOW_BLINK_ON_TIME ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_LED_SLOW_BLINK_ON_TIME = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_LED_SLOW_BLINK_OFF_TIME ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_LED_SLOW_BLINK_OFF_TIME = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_LED_FAST_BLINK_ON_TIME ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_LED_FAST_BLINK_ON_TIME = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_LED_FAST_BLINK_OFF_TIME ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_LED_FAST_BLINK_OFF_TIME = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_COLOR ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_LED_INDICATOR_COLOR = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_LED_RED ((USAGE) 0x0048)")]
    public const ushort HID_USAGE_LED_RED = ((ushort)(0x0048));

    [NativeTypeName("#define HID_USAGE_LED_GREEN ((USAGE) 0x0049)")]
    public const ushort HID_USAGE_LED_GREEN = ((ushort)(0x0049));

    [NativeTypeName("#define HID_USAGE_LED_AMBER ((USAGE) 0x004A)")]
    public const ushort HID_USAGE_LED_AMBER = ((ushort)(0x004A));

    [NativeTypeName("#define HID_USAGE_LED_GENERIC_INDICATOR ((USAGE) 0x004B)")]
    public const ushort HID_USAGE_LED_GENERIC_INDICATOR = ((ushort)(0x004B));

    [NativeTypeName("#define HID_USAGE_LED_SYSTEM_SUSPEND ((USAGE) 0x004C)")]
    public const ushort HID_USAGE_LED_SYSTEM_SUSPEND = ((ushort)(0x004C));

    [NativeTypeName("#define HID_USAGE_LED_EXTERNAL_POWER ((USAGE) 0x004D)")]
    public const ushort HID_USAGE_LED_EXTERNAL_POWER = ((ushort)(0x004D));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_BLUE ((USAGE) 0x004E)")]
    public const ushort HID_USAGE_LED_INDICATOR_BLUE = ((ushort)(0x004E));

    [NativeTypeName("#define HID_USAGE_LED_INDICATOR_ORANGE ((USAGE) 0x004F)")]
    public const ushort HID_USAGE_LED_INDICATOR_ORANGE = ((ushort)(0x004F));

    [NativeTypeName("#define HID_USAGE_LED_GOOD_STATUS ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_LED_GOOD_STATUS = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_LED_WARNING_STATUS ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_LED_WARNING_STATUS = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_LED_RGB_LED ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_LED_RGB_LED = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_LED_RED_LED_CHANNEL ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_LED_RED_LED_CHANNEL = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_LED_BLUE_LED_CHANNEL ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_LED_BLUE_LED_CHANNEL = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_LED_GREEN_LED_CHANNEL ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_LED_GREEN_LED_CHANNEL = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_LED_LED_INTENSITY ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_LED_LED_INTENSITY = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_LED_SYSTEM_MICROPHONE_MUTE ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_LED_SYSTEM_MICROPHONE_MUTE = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_INDICATOR ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_LED_PLAYER_INDICATOR = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_1 ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_LED_PLAYER_1 = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_2 ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_LED_PLAYER_2 = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_3 ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_LED_PLAYER_3 = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_4 ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_LED_PLAYER_4 = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_5 ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_LED_PLAYER_5 = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_6 ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_LED_PLAYER_6 = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_7 ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_LED_PLAYER_7 = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_LED_PLAYER_8 ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_LED_PLAYER_8 = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_LAMPARRAY = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_COUNT ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_COUNT = ((ushort)(0x0003));

    [NativeTypeName(
        "#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS ((USAGE) 0x0004)"
    )]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS = ((ushort)(0x0004));

    [NativeTypeName(
        "#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS ((USAGE) 0x0005)"
    )]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS = ((ushort)(0x0005));

    [NativeTypeName(
        "#define HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS ((USAGE) 0x0006)"
    )]
    public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_KIND ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_LAMPARRAY_KIND = ((ushort)(0x0007));

    [NativeTypeName(
        "#define HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS ((USAGE) 0x0008)"
    )]
    public const ushort HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS = (
        (ushort)(0x0008)
    );

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_PURPOSES ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_PURPOSES = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_INPUT_BINDING ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_LAMPARRAY_INPUT_BINDING = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID_START ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_START = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_LAMP_ID_END ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_END = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_CONTROL_REPORT ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_LAMPARRAY_CONTROL_REPORT = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE = ((ushort)(0x0071));

    [NativeTypeName(
        "#define HID_USAGE_MAGNETIC_STRIPE_READER_MSR_DEVICE_READONLY ((USAGE) 0x0001)"
    )]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_MSR_DEVICE_READONLY = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_1_LENGTH ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_1_LENGTH = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_2_LENGTH ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_2_LENGTH = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_3_LENGTH ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_3_LENGTH = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_JIS_LENGTH ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_JIS_LENGTH = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_DATA ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_DATA = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_1_DATA ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_1_DATA = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_2_DATA ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_2_DATA = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_3_DATA ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_3_DATA = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_JIS_DATA ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_MAGNETIC_STRIPE_READER_TRACK_JIS_DATA = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_MEDICAL_ULTRASOUND ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_MEDICAL_ULTRASOUND = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_VCRACQUISITION ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_VCRACQUISITION = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_FREEZETHAW ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_FREEZETHAW = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_CLIP_STORE ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_CLIP_STORE = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_UPDATE ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_UPDATE = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_NEXT ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_NEXT = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_SAVE ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SAVE = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_PRINT ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_PRINT = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_MICROPHONE_ENABLE ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_MICROPHONE_ENABLE = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_CINE ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_CINE = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_TRANSMIT_POWER ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_TRANSMIT_POWER = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_VOLUME ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_VOLUME = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_FOCUS ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_FOCUS = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_DEPTH ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_DEPTH = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_SOFT_STEP__PRIMARY ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SOFT_STEP__PRIMARY = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_SOFT_STEP__SECONDARY ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SOFT_STEP__SECONDARY = ((ushort)(0x0061));

    [NativeTypeName(
        "#define HID_USAGE_MEDICAL_INSTRUMENT_DEPTH_GAIN_COMPENSATION ((USAGE) 0x0070)"
    )]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_DEPTH_GAIN_COMPENSATION = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_ZOOM_SELECT ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_ZOOM_SELECT = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_ZOOM_ADJUST ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_ZOOM_ADJUST = ((ushort)(0x0081));

    [NativeTypeName(
        "#define HID_USAGE_MEDICAL_INSTRUMENT_SPECTRAL_DOPPLER_MODE_SELECT ((USAGE) 0x0082)"
    )]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SPECTRAL_DOPPLER_MODE_SELECT = (
        (ushort)(0x0082)
    );

    [NativeTypeName(
        "#define HID_USAGE_MEDICAL_INSTRUMENT_SPECTRAL_DOPPLER_ADJUST ((USAGE) 0x0083)"
    )]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SPECTRAL_DOPPLER_ADJUST = ((ushort)(0x0083));

    [NativeTypeName(
        "#define HID_USAGE_MEDICAL_INSTRUMENT_COLOR_DOPPLER_MODE_SELECT ((USAGE) 0x0084)"
    )]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_COLOR_DOPPLER_MODE_SELECT = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_COLOR_DOPPLER_ADJUST ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_COLOR_DOPPLER_ADJUST = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_MOTION_MODE_SELECT ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_MOTION_MODE_SELECT = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_MOTION_MODE_ADJUST ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_MOTION_MODE_ADJUST = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_2D_MODE_SELECT ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_2D_MODE_SELECT = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_2D_MODE_ADJUST ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_2D_MODE_ADJUST = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_SOFT_CONTROL_SELECT ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SOFT_CONTROL_SELECT = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_MEDICAL_INSTRUMENT_SOFT_CONTROL_ADJUST ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_MEDICAL_INSTRUMENT_SOFT_CONTROL_ADJUST = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_GENERAL ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_GENERAL = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_DIAL_NUMBER ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_DIAL_NUMBER = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_DIAL_MEMORY ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_DIAL_MEMORY = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_CALL_SETUP ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_MICROSOFT_BLUETOOTH_HANDSFREE_CALL_SETUP = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_MONITOR_MONITOR_CONTROL ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_MONITOR_MONITOR_CONTROL = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_MONITOR_EDID_INFORMATION ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_MONITOR_EDID_INFORMATION = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_MONITOR_VDIF_INFORMATION ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_MONITOR_VDIF_INFORMATION = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_MONITOR_VESA_VERSION ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_MONITOR_VESA_VERSION = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_PID_PHYSICAL_INPUT_DEVICE ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_PID_PHYSICAL_INPUT_DEVICE = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_PID_NORMAL ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_PID_NORMAL = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_PID_SET_EFFECT_REPORT ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_PID_SET_EFFECT_REPORT = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_PID_EFFECT_BLOCK_INDEX ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_PID_EFFECT_BLOCK_INDEX = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_PID_PARAMETER_BLOCK_OFFSET ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_PID_PARAMETER_BLOCK_OFFSET = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_PID_ROM_FLAG ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_PID_ROM_FLAG = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_PID_EFFECT_TYPE ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_PID_EFFECT_TYPE = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_PID_ET_CONSTANT ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_PID_ET_CONSTANT = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_PID_ET_RAMP ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_PID_ET_RAMP = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_PID_ET_CUSTOM ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_PID_ET_CUSTOM = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_PID_ET_SQUARE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_PID_ET_SQUARE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_PID_ET_SINE ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_PID_ET_SINE = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_PID_ET_TRIANGLE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_PID_ET_TRIANGLE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_PID_ET_SAWTOOTH_UP ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_PID_ET_SAWTOOTH_UP = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_PID_ET_SAWTOOTH_DOWN ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_PID_ET_SAWTOOTH_DOWN = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_PID_ET_SPRING ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_PID_ET_SPRING = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_PID_ET_DAMPER ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_PID_ET_DAMPER = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_PID_ET_INERTIA ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_PID_ET_INERTIA = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_PID_ET_FRICTION ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_PID_ET_FRICTION = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_PID_DURATION ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_PID_DURATION = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_PID_SAMPLE_PERIOD ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_PID_SAMPLE_PERIOD = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_PID_GAIN ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_PID_GAIN = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_PID_TRIGGER_BUTTON ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_PID_TRIGGER_BUTTON = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_PID_TRIGGER_REPEAT_INTERVAL ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_PID_TRIGGER_REPEAT_INTERVAL = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_PID_AXES_ENABLE ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_PID_AXES_ENABLE = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_PID_DIRECTION_ENABLE ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_PID_DIRECTION_ENABLE = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_PID_DIRECTION ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_PID_DIRECTION = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_PID_TYPE_SPECIFIC_BLOCK_OFFSET ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_PID_TYPE_SPECIFIC_BLOCK_OFFSET = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_TYPE ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_PID_BLOCK_TYPE = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_PID_SET_ENVELOPE_REPORT ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_PID_SET_ENVELOPE_REPORT = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_PID_ATTACK_LEVEL ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_PID_ATTACK_LEVEL = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_PID_ATTACK_TIME ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_PID_ATTACK_TIME = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_PID_FADE_LEVEL ((USAGE) 0x005D)")]
    public const ushort HID_USAGE_PID_FADE_LEVEL = ((ushort)(0x005D));

    [NativeTypeName("#define HID_USAGE_PID_FADE_TIME ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_PID_FADE_TIME = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_PID_SET_CONDITION_REPORT ((USAGE) 0x005F)")]
    public const ushort HID_USAGE_PID_SET_CONDITION_REPORT = ((ushort)(0x005F));

    [NativeTypeName("#define HID_USAGE_PID_CP_OFFSET ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_PID_CP_OFFSET = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_PID_POSITIVE_COEFFICIENT ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_PID_POSITIVE_COEFFICIENT = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_PID_NEGATIVE_COEFFICIENT ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_PID_NEGATIVE_COEFFICIENT = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_PID_POSITIVE_SATURATION ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_PID_POSITIVE_SATURATION = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_PID_NEGATIVE_SATURATION ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_PID_NEGATIVE_SATURATION = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_PID_DEAD_BAND ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_PID_DEAD_BAND = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_PID_DOWNLOAD_FORCE_SAMPLE ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_PID_DOWNLOAD_FORCE_SAMPLE = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_PID_ISOCH_CUSTOMFORCE_ENABLE ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_PID_ISOCH_CUSTOMFORCE_ENABLE = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_PID_CUSTOM_FORCE_DATA_REPORT ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_PID_CUSTOM_FORCE_DATA_REPORT = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_PID_CUSTOM_FORCE_DATA ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_PID_CUSTOM_FORCE_DATA = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_PID_CUSTOM_FORCE_VENDOR_DEFINED_DATA ((USAGE) 0x006A)")]
    public const ushort HID_USAGE_PID_CUSTOM_FORCE_VENDOR_DEFINED_DATA = ((ushort)(0x006A));

    [NativeTypeName("#define HID_USAGE_PID_SET_CUSTOM_FORCE_REPORT ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_PID_SET_CUSTOM_FORCE_REPORT = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_PID_CUSTOM_FORCE_DATA_OFFSET ((USAGE) 0x006C)")]
    public const ushort HID_USAGE_PID_CUSTOM_FORCE_DATA_OFFSET = ((ushort)(0x006C));

    [NativeTypeName("#define HID_USAGE_PID_SAMPLE_COUNT ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_PID_SAMPLE_COUNT = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_PID_SET_PERIODIC_REPORT ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_PID_SET_PERIODIC_REPORT = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_PID_OFFSET ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_PID_OFFSET = ((ushort)(0x006F));

    [NativeTypeName("#define HID_USAGE_PID_MAGNITUDE ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_PID_MAGNITUDE = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_PID_PHASE ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_PID_PHASE = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_PID_PERIOD ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_PID_PERIOD = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_PID_SET_CONSTANT_FORCE_REPORT ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_PID_SET_CONSTANT_FORCE_REPORT = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_PID_SET_RAMP_FORCE_REPORT ((USAGE) 0x0074)")]
    public const ushort HID_USAGE_PID_SET_RAMP_FORCE_REPORT = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_PID_RAMP_START ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_PID_RAMP_START = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_PID_RAMP_END ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_PID_RAMP_END = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_PID_EFFECT_OPERATION_REPORT ((USAGE) 0x0077)")]
    public const ushort HID_USAGE_PID_EFFECT_OPERATION_REPORT = ((ushort)(0x0077));

    [NativeTypeName("#define HID_USAGE_PID_EFFECT_OPERATION ((USAGE) 0x0078)")]
    public const ushort HID_USAGE_PID_EFFECT_OPERATION = ((ushort)(0x0078));

    [NativeTypeName("#define HID_USAGE_PID_OP_EFFECT_START ((USAGE) 0x0079)")]
    public const ushort HID_USAGE_PID_OP_EFFECT_START = ((ushort)(0x0079));

    [NativeTypeName("#define HID_USAGE_PID_OP_EFFECT_START_SOLO ((USAGE) 0x007A)")]
    public const ushort HID_USAGE_PID_OP_EFFECT_START_SOLO = ((ushort)(0x007A));

    [NativeTypeName("#define HID_USAGE_PID_OP_EFFECT_STOP ((USAGE) 0x007B)")]
    public const ushort HID_USAGE_PID_OP_EFFECT_STOP = ((ushort)(0x007B));

    [NativeTypeName("#define HID_USAGE_PID_LOOP_COUNT ((USAGE) 0x007C)")]
    public const ushort HID_USAGE_PID_LOOP_COUNT = ((ushort)(0x007C));

    [NativeTypeName("#define HID_USAGE_PID_DEVICE_GAIN_REPORT ((USAGE) 0x007D)")]
    public const ushort HID_USAGE_PID_DEVICE_GAIN_REPORT = ((ushort)(0x007D));

    [NativeTypeName("#define HID_USAGE_PID_DEVICE_GAIN ((USAGE) 0x007E)")]
    public const ushort HID_USAGE_PID_DEVICE_GAIN = ((ushort)(0x007E));

    [NativeTypeName("#define HID_USAGE_PID_POOL_REPORT ((USAGE) 0x007F)")]
    public const ushort HID_USAGE_PID_POOL_REPORT = ((ushort)(0x007F));

    [NativeTypeName("#define HID_USAGE_PID_RAM_POOL_SIZE ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_PID_RAM_POOL_SIZE = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_PID_ROM_POOL_SIZE ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_PID_ROM_POOL_SIZE = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_PID_ROM_EFFECT_BLOCK_COUNT ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_PID_ROM_EFFECT_BLOCK_COUNT = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_PID_SIMULTANEOUS_EFFECTS_MAX ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_PID_SIMULTANEOUS_EFFECTS_MAX = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_PID_POOL_ALIGNMENT ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_PID_POOL_ALIGNMENT = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_PID_PARAMETER_BLOCK_MOVE_REPORT ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_PID_PARAMETER_BLOCK_MOVE_REPORT = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_PID_MOVE_SOURCE ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_PID_MOVE_SOURCE = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_PID_MOVE_DESTINATION ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_PID_MOVE_DESTINATION = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_PID_MOVE_LENGTH ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_PID_MOVE_LENGTH = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_LOAD_REPORT ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_PID_BLOCK_LOAD_REPORT = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_LOAD_STATUS ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_PID_BLOCK_LOAD_STATUS = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_LOAD_SUCCESS ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_PID_BLOCK_LOAD_SUCCESS = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_LOAD_FULL ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_PID_BLOCK_LOAD_FULL = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_LOAD_ERROR ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_PID_BLOCK_LOAD_ERROR = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_HANDLE ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_PID_BLOCK_HANDLE = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_PID_BLOCK_FREE_REPORT ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_PID_BLOCK_FREE_REPORT = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_PID_TYPE_SPECIFIC_BLOCK_HANDLE ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_PID_TYPE_SPECIFIC_BLOCK_HANDLE = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_PID_STATE_REPORT ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_PID_STATE_REPORT = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_PID_EFFECT_PLAYING ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_PID_EFFECT_PLAYING = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_PID_PID_DEVICE_CONTROL_REPORT ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_PID_PID_DEVICE_CONTROL_REPORT = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_PID_DEVICE_CONTROL ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_PID_DEVICE_CONTROL = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_PID_DC_ENABLE_ACTUATORS ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_PID_DC_ENABLE_ACTUATORS = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_PID_DC_DISABLE_ACTUATORS ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_PID_DC_DISABLE_ACTUATORS = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_PID_DC_STOP_ALL_EFFECTS ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_PID_DC_STOP_ALL_EFFECTS = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_PID_DC_DEVICE_RESET ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_PID_DC_DEVICE_RESET = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_PID_DC_DEVICE_PAUSE ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_PID_DC_DEVICE_PAUSE = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_PID_DC_DEVICE_CONTINUE ((USAGE) 0x009C)")]
    public const ushort HID_USAGE_PID_DC_DEVICE_CONTINUE = ((ushort)(0x009C));

    [NativeTypeName("#define HID_USAGE_PID_DEVICE_PAUSED ((USAGE) 0x009F)")]
    public const ushort HID_USAGE_PID_DEVICE_PAUSED = ((ushort)(0x009F));

    [NativeTypeName("#define HID_USAGE_PID_ACTUATORS_ENABLED ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_PID_ACTUATORS_ENABLED = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_PID_SAFETY_SWITCH ((USAGE) 0x00A4)")]
    public const ushort HID_USAGE_PID_SAFETY_SWITCH = ((ushort)(0x00A4));

    [NativeTypeName("#define HID_USAGE_PID_ACTUATOR_OVERRIDE_SWITCH ((USAGE) 0x00A5)")]
    public const ushort HID_USAGE_PID_ACTUATOR_OVERRIDE_SWITCH = ((ushort)(0x00A5));

    [NativeTypeName("#define HID_USAGE_PID_ACTUATOR_POWER ((USAGE) 0x00A6)")]
    public const ushort HID_USAGE_PID_ACTUATOR_POWER = ((ushort)(0x00A6));

    [NativeTypeName("#define HID_USAGE_PID_START_DELAY ((USAGE) 0x00A7)")]
    public const ushort HID_USAGE_PID_START_DELAY = ((ushort)(0x00A7));

    [NativeTypeName("#define HID_USAGE_PID_PARAMETER_BLOCK_SIZE ((USAGE) 0x00A8)")]
    public const ushort HID_USAGE_PID_PARAMETER_BLOCK_SIZE = ((ushort)(0x00A8));

    [NativeTypeName("#define HID_USAGE_PID_DEVICE_MANAGED_POOL ((USAGE) 0x00A9)")]
    public const ushort HID_USAGE_PID_DEVICE_MANAGED_POOL = ((ushort)(0x00A9));

    [NativeTypeName("#define HID_USAGE_PID_SHARED_PARAMETER_BLOCKS ((USAGE) 0x00AA)")]
    public const ushort HID_USAGE_PID_SHARED_PARAMETER_BLOCKS = ((ushort)(0x00AA));

    [NativeTypeName("#define HID_USAGE_PID_CREATE_NEW_EFFECT ((USAGE) 0x00AB)")]
    public const ushort HID_USAGE_PID_CREATE_NEW_EFFECT = ((ushort)(0x00AB));

    [NativeTypeName("#define HID_USAGE_PID_RAMPOOL_AVAILABLE ((USAGE) 0x00AC)")]
    public const ushort HID_USAGE_PID_RAMPOOL_AVAILABLE = ((ushort)(0x00AC));

    [NativeTypeName("#define HID_USAGE_POWER_INAME ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_POWER_INAME = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_POWER_PRESENT_STATUS ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_POWER_PRESENT_STATUS = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_POWER_CHANGED_STATUS ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_POWER_CHANGED_STATUS = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_POWER_UPS ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_POWER_UPS = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_POWER_POWER_SUPPLY ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_POWER_POWER_SUPPLY = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_POWER_BATTERY_SYSTEM ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_POWER_BATTERY_SYSTEM = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_POWER_BATTERY_SYSTEM_ID ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_POWER_BATTERY_SYSTEM_ID = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_POWER_BATTERY ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_POWER_BATTERY = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_POWER_BATTERY_ID ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_POWER_BATTERY_ID = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_POWER_CHARGER ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_POWER_CHARGER = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_POWER_CHARGER_ID ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_POWER_CHARGER_ID = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_POWER_POWER_CONVERTER ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_POWER_POWER_CONVERTER = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_POWER_POWER_CONVERTER_ID ((USAGE) 0x0017)")]
    public const ushort HID_USAGE_POWER_POWER_CONVERTER_ID = ((ushort)(0x0017));

    [NativeTypeName("#define HID_USAGE_POWER_OUTLET_SYSTEM ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_POWER_OUTLET_SYSTEM = ((ushort)(0x0018));

    [NativeTypeName("#define HID_USAGE_POWER_OUTLET_SYSTEM_ID ((USAGE) 0x0019)")]
    public const ushort HID_USAGE_POWER_OUTLET_SYSTEM_ID = ((ushort)(0x0019));

    [NativeTypeName("#define HID_USAGE_POWER_INPUT ((USAGE) 0x001A)")]
    public const ushort HID_USAGE_POWER_INPUT = ((ushort)(0x001A));

    [NativeTypeName("#define HID_USAGE_POWER_INPUT_ID ((USAGE) 0x001B)")]
    public const ushort HID_USAGE_POWER_INPUT_ID = ((ushort)(0x001B));

    [NativeTypeName("#define HID_USAGE_POWER_OUTPUT ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_POWER_OUTPUT = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_POWER_OUTPUT_ID ((USAGE) 0x001D)")]
    public const ushort HID_USAGE_POWER_OUTPUT_ID = ((ushort)(0x001D));

    [NativeTypeName("#define HID_USAGE_POWER_FLOW ((USAGE) 0x001E)")]
    public const ushort HID_USAGE_POWER_FLOW = ((ushort)(0x001E));

    [NativeTypeName("#define HID_USAGE_POWER_FLOW_ID ((USAGE) 0x001F)")]
    public const ushort HID_USAGE_POWER_FLOW_ID = ((ushort)(0x001F));

    [NativeTypeName("#define HID_USAGE_POWER_OUTLET ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_POWER_OUTLET = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_POWER_OUTLET_ID ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_POWER_OUTLET_ID = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_POWER_GANG ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_POWER_GANG = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_POWER_GANG_ID ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_POWER_GANG_ID = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_POWER_POWER_SUMMARY ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_POWER_POWER_SUMMARY = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_POWER_POWER_SUMMARY_ID ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_POWER_POWER_SUMMARY_ID = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_POWER_VOLTAGE ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_POWER_VOLTAGE = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_POWER_CURRENT ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_POWER_CURRENT = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_POWER_FREQUENCY ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_POWER_FREQUENCY = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_POWER_APPARENT_POWER ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_POWER_APPARENT_POWER = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_POWER_ACTIVE_POWER ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_POWER_ACTIVE_POWER = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_POWER_PERCENT_LOAD ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_POWER_PERCENT_LOAD = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_POWER_TEMPERATURE ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_POWER_TEMPERATURE = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_POWER_HUMIDITY ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_POWER_HUMIDITY = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_POWER_BAD_COUNT ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_POWER_BAD_COUNT = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_VOLTAGE ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_POWER_CONFIG_VOLTAGE = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_CURRENT ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_POWER_CONFIG_CURRENT = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_FREQUENCY ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_POWER_CONFIG_FREQUENCY = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_APPARENT_POWER ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_POWER_CONFIG_APPARENT_POWER = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_ACTIVE_POWER ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_POWER_CONFIG_ACTIVE_POWER = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_PERCENT_LOAD ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_POWER_CONFIG_PERCENT_LOAD = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_TEMPERATURE ((USAGE) 0x0046)")]
    public const ushort HID_USAGE_POWER_CONFIG_TEMPERATURE = ((ushort)(0x0046));

    [NativeTypeName("#define HID_USAGE_POWER_CONFIG_HUMIDITY ((USAGE) 0x0047)")]
    public const ushort HID_USAGE_POWER_CONFIG_HUMIDITY = ((ushort)(0x0047));

    [NativeTypeName("#define HID_USAGE_POWER_SWITCH_ON_CONTROL ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_POWER_SWITCH_ON_CONTROL = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_POWER_SWITCH_OFF_CONTROL ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_POWER_SWITCH_OFF_CONTROL = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_POWER_TOGGLE_CONTROL ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_POWER_TOGGLE_CONTROL = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_POWER_LOW_VOLTAGE_TRANSFER ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_POWER_LOW_VOLTAGE_TRANSFER = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_POWER_HIGH_VOLTAGE_TRANSFER ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_POWER_HIGH_VOLTAGE_TRANSFER = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_POWER_DELAY_BEFORE_REBOOT ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_POWER_DELAY_BEFORE_REBOOT = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_POWER_DELAY_BEFORE_STARTUP ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_POWER_DELAY_BEFORE_STARTUP = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_POWER_DELAY_BEFORE_SHUTDOWN ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_POWER_DELAY_BEFORE_SHUTDOWN = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_POWER_TEST ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_POWER_TEST = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_POWER_MODULE_RESET ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_POWER_MODULE_RESET = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_POWER_AUDIBLE_ALARM_CONTROL ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_POWER_AUDIBLE_ALARM_CONTROL = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_POWER_PRESENT ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_POWER_PRESENT = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_POWER_GOOD ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_POWER_GOOD = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_POWER_INTERNAL_FAILURE ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_POWER_INTERNAL_FAILURE = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_POWER_VOLTAG_OUT_OF_RANGE ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_POWER_VOLTAG_OUT_OF_RANGE = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_POWER_FREQUENCY_OUT_OF_RANGE ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_POWER_FREQUENCY_OUT_OF_RANGE = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_POWER_OVERLOAD ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_POWER_OVERLOAD = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_POWER_OVER_CHARGED ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_POWER_OVER_CHARGED = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_POWER_OVER_TEMPERATURE ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_POWER_OVER_TEMPERATURE = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_POWER_SHUTDOWN_REQUESTED ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_POWER_SHUTDOWN_REQUESTED = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_POWER_SHUTDOWN_IMMINENT ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_POWER_SHUTDOWN_IMMINENT = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_POWER_SWITCH_ONOFF ((USAGE) 0x006B)")]
    public const ushort HID_USAGE_POWER_SWITCH_ONOFF = ((ushort)(0x006B));

    [NativeTypeName("#define HID_USAGE_POWER_SWITCHABLE ((USAGE) 0x006C)")]
    public const ushort HID_USAGE_POWER_SWITCHABLE = ((ushort)(0x006C));

    [NativeTypeName("#define HID_USAGE_POWER_USED ((USAGE) 0x006D)")]
    public const ushort HID_USAGE_POWER_USED = ((ushort)(0x006D));

    [NativeTypeName("#define HID_USAGE_POWER_BOOST ((USAGE) 0x006E)")]
    public const ushort HID_USAGE_POWER_BOOST = ((ushort)(0x006E));

    [NativeTypeName("#define HID_USAGE_POWER_BUCK ((USAGE) 0x006F)")]
    public const ushort HID_USAGE_POWER_BUCK = ((ushort)(0x006F));

    [NativeTypeName("#define HID_USAGE_POWER_INITIALIZED ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_POWER_INITIALIZED = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_POWER_TESTED ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_POWER_TESTED = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_POWER_AWAITING_POWER ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_POWER_AWAITING_POWER = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_POWER_COMMUNICATION_LOST ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_POWER_COMMUNICATION_LOST = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_POWER_IMANUFACTURER ((USAGE) 0x00FD)")]
    public const ushort HID_USAGE_POWER_IMANUFACTURER = ((ushort)(0x00FD));

    [NativeTypeName("#define HID_USAGE_POWER_IPRODUCT ((USAGE) 0x00FE)")]
    public const ushort HID_USAGE_POWER_IPRODUCT = ((ushort)(0x00FE));

    [NativeTypeName("#define HID_USAGE_POWER_ISERIALNUMBER ((USAGE) 0x00FF)")]
    public const ushort HID_USAGE_POWER_ISERIALNUMBER = ((ushort)(0x00FF));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALES ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALES = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_DEVICE ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_DEVICE = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_I_METRIC ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_I_METRIC = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_II_METRIC ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_II_METRIC = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_III_METRIC ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_III_METRIC = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IIIL_METRIC ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IIIL_METRIC = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IV_METRIC ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IV_METRIC = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_III_ENGLISH ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_III_ENGLISH = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IIIL_ENGLISH ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IIIL_ENGLISH = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IV_ENGLISH ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_IV_ENGLISH = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_GENERIC ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CLASS_GENERIC = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_ATTRIBUTE_REPORT ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_ATTRIBUTE_REPORT = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_CONTROL_REPORT ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_CONTROL_REPORT = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_DATA_REPORT ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_DATA_REPORT = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REPORT ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REPORT = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_WEIGHT_LIMIT_REPORT ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_WEIGHT_LIMIT_REPORT = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATISTICS_REPORT ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATISTICS_REPORT = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_DATA_WEIGHT ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_DATA_WEIGHT = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_DATA_SCALING ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_DATA_SCALING = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_MILLIGRAM ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_MILLIGRAM = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_GRAM ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_GRAM = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_KILOGRAM ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_KILOGRAM = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_CARATS ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_CARATS = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_TAELS ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_TAELS = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_GRAINS ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_GRAINS = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_PENNYWEIGHTS ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_PENNYWEIGHTS = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_METRIC_TON ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_METRIC_TON = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_AVOIR_TON ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_AVOIR_TON = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_TROY_OUNCE ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_TROY_OUNCE = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_OUNCE ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_OUNCE = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_POUND ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_WEIGHT_UNIT_POUND = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_CALIBRATION_COUNT ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_CALIBRATION_COUNT = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_REZERO_COUNT ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_REZERO_COUNT = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_FAULT ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_FAULT = ((ushort)(0x0071));

    [NativeTypeName(
        "#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_STABLE_AT_CENTER_OF_ZERO ((USAGE) 0x0072)"
    )]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_STABLE_AT_CENTER_OF_ZERO = (
        (ushort)(0x0072)
    );

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_IN_MOTION ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_IN_MOTION = ((ushort)(0x0073));

    [NativeTypeName(
        "#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_WEIGHT_STABLE ((USAGE) 0x0074)"
    )]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_WEIGHT_STABLE = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_UNDER_ZERO ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_UNDER_ZERO = ((ushort)(0x0075));

    [NativeTypeName(
        "#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_OVER_WEIGHT_LIMIT ((USAGE) 0x0076)"
    )]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_OVER_WEIGHT_LIMIT = (
        (ushort)(0x0076)
    );

    [NativeTypeName(
        "#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REQUIRES_CALIBRATION ((USAGE) 0x0077)"
    )]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REQUIRES_CALIBRATION = (
        (ushort)(0x0077)
    );

    [NativeTypeName(
        "#define HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REQUIRES_REZEROING ((USAGE) 0x0078)"
    )]
    public const ushort HID_USAGE_WEIGHING_DEVICE_SCALE_STATUS_REQUIRES_REZEROING = (
        (ushort)(0x0078)
    );

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_ZERO_SCALE ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_ZERO_SCALE = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_WEIGHING_DEVICE_ENFORCED_ZERO_RETURN ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_WEIGHING_DEVICE_ENFORCED_ZERO_RETURN = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_SENSORS_SENSOR = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_HUMAN_PRESENCE ((USAGE) 0x0011)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_HUMAN_PRESENCE = ((ushort)(0x0011));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_HUMAN_PROXIMITY ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_HUMAN_PROXIMITY = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_HUMAN_TOUCH ((USAGE) 0x0013)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_HUMAN_TOUCH = ((ushort)(0x0013));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_BLOOD_PRESSURE ((USAGE) 0x0014)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_BLOOD_PRESSURE = ((ushort)(0x0014));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_BODY_TEMPERATURE ((USAGE) 0x0015)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_BODY_TEMPERATURE = ((ushort)(0x0015));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_HEART_RATE ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_HEART_RATE = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_HEART_RATE_VARIABILITY ((USAGE) 0x0017)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_HEART_RATE_VARIABILITY = ((ushort)(0x0017));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_BIOMETRIC_PERIPHERAL_OXYGEN_SATURATION ((USAGE) 0x0018)"
    )]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_PERIPHERAL_OXYGEN_SATURATION = (
        (ushort)(0x0018)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_BIOMETRIC_RESPIRATORY_RATE ((USAGE) 0x0019)")]
    public const ushort HID_USAGE_SENSORS_BIOMETRIC_RESPIRATORY_RATE = ((ushort)(0x0019));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_CAPACITANCE ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_CAPACITANCE = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_CURRENT ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_CURRENT = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_POWER ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_POWER = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_INDUCTANCE ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_INDUCTANCE = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_RESISTANCE ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_RESISTANCE = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_VOLTAGE ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_VOLTAGE = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_POTENTIOMETER ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_POTENTIOMETER = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_FREQUENCY ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_FREQUENCY = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_SENSORS_ELECTRICAL_PERIOD ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_SENSORS_ELECTRICAL_PERIOD = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL = ((ushort)(0x0030));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_ENVIRONMENTAL_ATMOSPHERIC_PRESSURE ((USAGE) 0x0031)"
    )]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_ATMOSPHERIC_PRESSURE = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_HUMIDITY ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_HUMIDITY = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_TEMPERATURE ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_TEMPERATURE = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_WIND_DIRECTION ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_WIND_DIRECTION = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_WIND_SPEED ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_WIND_SPEED = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_AIR_QUALITY ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_AIR_QUALITY = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_HEAT_INDEX ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_HEAT_INDEX = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_SURFACE_TEMPERATURE ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_SURFACE_TEMPERATURE = ((ushort)(0x0038));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_ENVIRONMENTAL_VOLATILE_ORGANIC_COMPOUNDS ((USAGE) 0x0039)"
    )]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_VOLATILE_ORGANIC_COMPOUNDS = (
        (ushort)(0x0039)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_OBJECT_PRESENCE ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_OBJECT_PRESENCE = ((ushort)(0x003A));

    [NativeTypeName("#define HID_USAGE_SENSORS_ENVIRONMENTAL_OBJECT_PROXIMITY ((USAGE) 0x003B)")]
    public const ushort HID_USAGE_SENSORS_ENVIRONMENTAL_OBJECT_PROXIMITY = ((ushort)(0x003B));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT ((USAGE) 0x0040)")]
    public const ushort HID_USAGE_SENSORS_LIGHT = ((ushort)(0x0040));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT_AMBIENT_LIGHT ((USAGE) 0x0041)")]
    public const ushort HID_USAGE_SENSORS_LIGHT_AMBIENT_LIGHT = ((ushort)(0x0041));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT_CONSUMER_INFRARED ((USAGE) 0x0042)")]
    public const ushort HID_USAGE_SENSORS_LIGHT_CONSUMER_INFRARED = ((ushort)(0x0042));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT_INFRARED_LIGHT ((USAGE) 0x0043)")]
    public const ushort HID_USAGE_SENSORS_LIGHT_INFRARED_LIGHT = ((ushort)(0x0043));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT_VISIBLE_LIGHT ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_SENSORS_LIGHT_VISIBLE_LIGHT = ((ushort)(0x0044));

    [NativeTypeName("#define HID_USAGE_SENSORS_LIGHT_ULTRAVIOLET_LIGHT ((USAGE) 0x0045)")]
    public const ushort HID_USAGE_SENSORS_LIGHT_ULTRAVIOLET_LIGHT = ((ushort)(0x0045));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_SENSORS_LOCATION = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_BROADCAST ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_BROADCAST = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_DEAD_RECKONING ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_DEAD_RECKONING = ((ushort)(0x0052));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_LOCATION_GPS_GLOBAL_POSITIONING_SYSTEM ((USAGE) 0x0053)"
    )]
    public const ushort HID_USAGE_SENSORS_LOCATION_GPS_GLOBAL_POSITIONING_SYSTEM = (
        (ushort)(0x0053)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_LOOKUP ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_LOOKUP = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_OTHER ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_OTHER = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_STATIC ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_STATIC = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_SENSORS_LOCATION_TRIANGULATION ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_SENSORS_LOCATION_TRIANGULATION = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_BOOLEAN_SWITCH ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_BOOLEAN_SWITCH = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_BOOLEAN_SWITCH_ARRAY ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_BOOLEAN_SWITCH_ARRAY = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_MULTIVALUE_SWITCH ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_MULTIVALUE_SWITCH = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_FORCE ((USAGE) 0x0064)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_FORCE = ((ushort)(0x0064));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_PRESSURE ((USAGE) 0x0065)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_PRESSURE = ((ushort)(0x0065));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_STRAIN ((USAGE) 0x0066)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_STRAIN = ((ushort)(0x0066));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_WEIGHT ((USAGE) 0x0067)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_WEIGHT = ((ushort)(0x0067));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_HAPTIC_VIBRATOR ((USAGE) 0x0068)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_HAPTIC_VIBRATOR = ((ushort)(0x0068));

    [NativeTypeName("#define HID_USAGE_SENSORS_MECHANICAL_HALL_EFFECT_SWITCH ((USAGE) 0x0069)")]
    public const ushort HID_USAGE_SENSORS_MECHANICAL_HALL_EFFECT_SWITCH = ((ushort)(0x0069));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_SENSORS_MOTION = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_ACCELEROMETER_1D ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_SENSORS_MOTION_ACCELEROMETER_1D = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_ACCELEROMETER_2D ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_SENSORS_MOTION_ACCELEROMETER_2D = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_ACCELEROMETER_3D ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_SENSORS_MOTION_ACCELEROMETER_3D = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_GYROMETER_1D ((USAGE) 0x0074)")]
    public const ushort HID_USAGE_SENSORS_MOTION_GYROMETER_1D = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_GYROMETER_2D ((USAGE) 0x0075)")]
    public const ushort HID_USAGE_SENSORS_MOTION_GYROMETER_2D = ((ushort)(0x0075));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_GYROMETER_3D ((USAGE) 0x0076)")]
    public const ushort HID_USAGE_SENSORS_MOTION_GYROMETER_3D = ((ushort)(0x0076));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_MOTION_DETECTOR ((USAGE) 0x0077)")]
    public const ushort HID_USAGE_SENSORS_MOTION_MOTION_DETECTOR = ((ushort)(0x0077));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_SPEEDOMETER ((USAGE) 0x0078)")]
    public const ushort HID_USAGE_SENSORS_MOTION_SPEEDOMETER = ((ushort)(0x0078));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_ACCELEROMETER ((USAGE) 0x0079)")]
    public const ushort HID_USAGE_SENSORS_MOTION_ACCELEROMETER = ((ushort)(0x0079));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_GYROMETER ((USAGE) 0x007A)")]
    public const ushort HID_USAGE_SENSORS_MOTION_GYROMETER = ((ushort)(0x007A));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_GRAVITY_VECTOR ((USAGE) 0x007B)")]
    public const ushort HID_USAGE_SENSORS_MOTION_GRAVITY_VECTOR = ((ushort)(0x007B));

    [NativeTypeName("#define HID_USAGE_SENSORS_MOTION_LINEAR_ACCELEROMETER ((USAGE) 0x007C)")]
    public const ushort HID_USAGE_SENSORS_MOTION_LINEAR_ACCELEROMETER = ((ushort)(0x007C));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION ((USAGE) 0x0080)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION = ((ushort)(0x0080));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_COMPASS_1D ((USAGE) 0x0081)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_COMPASS_1D = ((ushort)(0x0081));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_COMPASS_2D ((USAGE) 0x0082)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_COMPASS_2D = ((ushort)(0x0082));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_COMPASS_3D ((USAGE) 0x0083)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_COMPASS_3D = ((ushort)(0x0083));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_1D ((USAGE) 0x0084)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_1D = ((ushort)(0x0084));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_2D ((USAGE) 0x0085)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_2D = ((ushort)(0x0085));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_3D ((USAGE) 0x0086)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER_3D = ((ushort)(0x0086));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_DISTANCE_1D ((USAGE) 0x0087)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_DISTANCE_1D = ((ushort)(0x0087));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_DISTANCE_2D ((USAGE) 0x0088)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_DISTANCE_2D = ((ushort)(0x0088));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_DISTANCE_3D ((USAGE) 0x0089)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_DISTANCE_3D = ((ushort)(0x0089));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_DEVICE_ORIENTATION ((USAGE) 0x008A)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_DEVICE_ORIENTATION = ((ushort)(0x008A));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_COMPASS ((USAGE) 0x008B)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_COMPASS = ((ushort)(0x008B));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER ((USAGE) 0x008C)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_INCLINOMETER = ((ushort)(0x008C));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_DISTANCE ((USAGE) 0x008D)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_DISTANCE = ((ushort)(0x008D));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_RELATIVE_ORIENTATION ((USAGE) 0x008E)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_RELATIVE_ORIENTATION = ((ushort)(0x008E));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_SIMPLE_ORIENTATION ((USAGE) 0x008F)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_SIMPLE_ORIENTATION = ((ushort)(0x008F));

    [NativeTypeName("#define HID_USAGE_SENSORS_SCANNER ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_SENSORS_SCANNER = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_SENSORS_SCANNER_BARCODE ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_SENSORS_SCANNER_BARCODE = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_SENSORS_SCANNER_RFID ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_SENSORS_SCANNER_RFID = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_SENSORS_SCANNER_NFC ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_SENSORS_SCANNER_NFC = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_SENSORS_TIME ((USAGE) 0x00A0)")]
    public const ushort HID_USAGE_SENSORS_TIME = ((ushort)(0x00A0));

    [NativeTypeName("#define HID_USAGE_SENSORS_TIME_ALARM_TIMER ((USAGE) 0x00A1)")]
    public const ushort HID_USAGE_SENSORS_TIME_ALARM_TIMER = ((ushort)(0x00A1));

    [NativeTypeName("#define HID_USAGE_SENSORS_TIME_REAL_TIME_CLOCK ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_SENSORS_TIME_REAL_TIME_CLOCK = ((ushort)(0x00A2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY = ((ushort)(0x00B0));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY_ACTIVITY_DETECTION ((USAGE) 0x00B1)"
    )]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY_ACTIVITY_DETECTION = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY_DEVICE_POSITION ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY_DEVICE_POSITION = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY_FLOOR_TRACKER ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY_FLOOR_TRACKER = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY_PEDOMETER ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY_PEDOMETER = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_SENSORS_PERSONAL_ACTIVITY_STEP_DETECTION ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_SENSORS_PERSONAL_ACTIVITY_STEP_DETECTION = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_EXTENDED ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_EXTENDED = ((ushort)(0x00C0));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_ORIENTATION_EXTENDED_GEOMAGNETIC_ORIENTATION ((USAGE) 0x00C1)"
    )]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_EXTENDED_GEOMAGNETIC_ORIENTATION = (
        (ushort)(0x00C1)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_ORIENTATION_EXTENDED_MAGNETOMETER ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_SENSORS_ORIENTATION_EXTENDED_MAGNETOMETER = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_SENSORS_GESTURE = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_CHASSIS_FLIP_GESTURE ((USAGE) 0x00D1)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_CHASSIS_FLIP_GESTURE = ((ushort)(0x00D1));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_HINGE_FOLD_GESTURE ((USAGE) 0x00D2)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_HINGE_FOLD_GESTURE = ((ushort)(0x00D2));

    [NativeTypeName("#define HID_USAGE_SENSORS_OTHER ((USAGE) 0x00E0)")]
    public const ushort HID_USAGE_SENSORS_OTHER = ((ushort)(0x00E0));

    [NativeTypeName("#define HID_USAGE_SENSORS_OTHER_CUSTOM ((USAGE) 0x00E1)")]
    public const ushort HID_USAGE_SENSORS_OTHER_CUSTOM = ((ushort)(0x00E1));

    [NativeTypeName("#define HID_USAGE_SENSORS_OTHER_GENERIC ((USAGE) 0x00E2)")]
    public const ushort HID_USAGE_SENSORS_OTHER_GENERIC = ((ushort)(0x00E2));

    [NativeTypeName("#define HID_USAGE_SENSORS_OTHER_GENERIC_ENUMERATOR ((USAGE) 0x00E3)")]
    public const ushort HID_USAGE_SENSORS_OTHER_GENERIC_ENUMERATOR = ((ushort)(0x00E3));

    [NativeTypeName("#define HID_USAGE_SENSORS_OTHER_HINGE_ANGLE ((USAGE) 0x00E4)")]
    public const ushort HID_USAGE_SENSORS_OTHER_HINGE_ANGLE = ((ushort)(0x00E4));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_1 ((USAGE) 0x00F0)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_1 = ((ushort)(0x00F0));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_2 ((USAGE) 0x00F1)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_2 = ((ushort)(0x00F1));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_3 ((USAGE) 0x00F2)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_3 = ((ushort)(0x00F2));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_4 ((USAGE) 0x00F3)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_4 = ((ushort)(0x00F3));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_5 ((USAGE) 0x00F4)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_5 = ((ushort)(0x00F4));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_6 ((USAGE) 0x00F5)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_6 = ((ushort)(0x00F5));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_7 ((USAGE) 0x00F6)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_7 = ((ushort)(0x00F6));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_8 ((USAGE) 0x00F7)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_8 = ((ushort)(0x00F7));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_9 ((USAGE) 0x00F8)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_9 = ((ushort)(0x00F8));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_10 ((USAGE) 0x00F9)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_10 = ((ushort)(0x00F9));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_11 ((USAGE) 0x00FA)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_11 = ((ushort)(0x00FA));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_12 ((USAGE) 0x00FB)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_12 = ((ushort)(0x00FB));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_13 ((USAGE) 0x00FC)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_13 = ((ushort)(0x00FC));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_14 ((USAGE) 0x00FD)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_14 = ((ushort)(0x00FD));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_15 ((USAGE) 0x00FE)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_15 = ((ushort)(0x00FE));

    [NativeTypeName("#define HID_USAGE_SENSORS_VENDOR_RESERVED_16 ((USAGE) 0x00FF)")]
    public const ushort HID_USAGE_SENSORS_VENDOR_RESERVED_16 = ((ushort)(0x00FF));

    [NativeTypeName("#define HID_USAGE_SENSORS_EVENT ((USAGE) 0x0200)")]
    public const ushort HID_USAGE_SENSORS_EVENT = ((ushort)(0x0200));

    [NativeTypeName("#define HID_USAGE_SENSORS_EVENT_SENSOR_STATE ((USAGE) 0x0201)")]
    public const ushort HID_USAGE_SENSORS_EVENT_SENSOR_STATE = ((ushort)(0x0201));

    [NativeTypeName("#define HID_USAGE_SENSORS_EVENT_SENSOR_EVENT ((USAGE) 0x0202)")]
    public const ushort HID_USAGE_SENSORS_EVENT_SENSOR_EVENT = ((ushort)(0x0202));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY ((USAGE) 0x0300)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY = ((ushort)(0x0300));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_FRIENDLY_NAME ((USAGE) 0x0301)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_FRIENDLY_NAME = ((ushort)(0x0301));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_PERSISTENT_UNIQUE_ID ((USAGE) 0x0302)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_PERSISTENT_UNIQUE_ID = ((ushort)(0x0302));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_STATUS ((USAGE) 0x0303)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_STATUS = ((ushort)(0x0303));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_MINIMUM_REPORT_INTERVAL ((USAGE) 0x0304)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MINIMUM_REPORT_INTERVAL = ((ushort)(0x0304));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_MANUFACTURER ((USAGE) 0x0305)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_MANUFACTURER = ((ushort)(0x0305));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_MODEL ((USAGE) 0x0306)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_MODEL = ((ushort)(0x0306));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_SERIAL_NUMBER ((USAGE) 0x0307)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_SERIAL_NUMBER = ((ushort)(0x0307));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_DESCRIPTION ((USAGE) 0x0308)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_DESCRIPTION = ((ushort)(0x0308));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_CONNECTION_TYPE ((USAGE) 0x0309)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_CONNECTION_TYPE = ((ushort)(0x0309));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SENSOR_DEVICE_PATH ((USAGE) 0x030A)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SENSOR_DEVICE_PATH = ((ushort)(0x030A));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_HARDWARE_REVISION ((USAGE) 0x030B)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_HARDWARE_REVISION = ((ushort)(0x030B));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_FIRMWARE_VERSION ((USAGE) 0x030C)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_FIRMWARE_VERSION = ((ushort)(0x030C));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_RELEASE_DATE ((USAGE) 0x030D)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_RELEASE_DATE = ((ushort)(0x030D));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_REPORT_INTERVAL ((USAGE) 0x030E)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_REPORT_INTERVAL = ((ushort)(0x030E));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_ABSOLUTE ((USAGE) 0x030F)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_ABSOLUTE = ((ushort)(0x030F));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_PERCENT_OF_RANGE ((USAGE) 0x0310)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_PERCENT_OF_RANGE = (
        (ushort)(0x0310)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_PERCENT_RELATIVE ((USAGE) 0x0311)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CHANGE_SENSITIVITY_PERCENT_RELATIVE = (
        (ushort)(0x0311)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_ACCURACY ((USAGE) 0x0312)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_ACCURACY = ((ushort)(0x0312));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_RESOLUTION ((USAGE) 0x0313)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_RESOLUTION = ((ushort)(0x0313));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_MAXIMUM ((USAGE) 0x0314)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MAXIMUM = ((ushort)(0x0314));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_MINIMUM ((USAGE) 0x0315)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MINIMUM = ((ushort)(0x0315));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_REPORTING_STATE ((USAGE) 0x0316)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_REPORTING_STATE = ((ushort)(0x0316));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SAMPLING_RATE ((USAGE) 0x0317)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SAMPLING_RATE = ((ushort)(0x0317));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_RESPONSE_CURVE ((USAGE) 0x0318)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_RESPONSE_CURVE = ((ushort)(0x0318));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_POWER_STATE ((USAGE) 0x0319)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_POWER_STATE = ((ushort)(0x0319));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_MAXIMUM_FIFO_EVENTS ((USAGE) 0x031A)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MAXIMUM_FIFO_EVENTS = ((ushort)(0x031A));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_REPORT_LATENCY ((USAGE) 0x031B)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_REPORT_LATENCY = ((ushort)(0x031B));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_FLUSH_FIFO_EVENTS ((USAGE) 0x031C)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_FLUSH_FIFO_EVENTS = ((ushort)(0x031C));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_MAXIMUM_POWER_CONSUMPTION ((USAGE) 0x031D)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MAXIMUM_POWER_CONSUMPTION = ((ushort)(0x031D));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_IS_PRIMARY ((USAGE) 0x031E)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_IS_PRIMARY = ((ushort)(0x031E));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_HUMAN_PRESENCE_DETECTION_TYPE ((USAGE) 0x031F)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_HUMAN_PRESENCE_DETECTION_TYPE = (
        (ushort)(0x031F)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_LOCATION ((USAGE) 0x0400)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_LOCATION = ((ushort)(0x0400));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ANTENNA_SEA_LEVEL ((USAGE) 0x0402)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ANTENNA_SEA_LEVEL = (
        (ushort)(0x0402)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_DIFFERENTIAL_REFERENCE_STATION_ID ((USAGE) 0x0403)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DIFFERENTIAL_REFERENCE_STATION_ID = (
        (ushort)(0x0403)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ELLIPSOID_ERROR ((USAGE) 0x0404)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ELLIPSOID_ERROR = ((ushort)(0x0404));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ELLIPSOID ((USAGE) 0x0405)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_ELLIPSOID = ((ushort)(0x0405));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_SEA_LEVEL_ERROR ((USAGE) 0x0406)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_SEA_LEVEL_ERROR = ((ushort)(0x0406));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_SEA_LEVEL ((USAGE) 0x0407)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ALTITUDE_SEA_LEVEL = ((ushort)(0x0407));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_DIFFERENTIAL_GPS_DATA_AGE ((USAGE) 0x0408)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DIFFERENTIAL_GPS_DATA_AGE = ((ushort)(0x0408));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ERROR_RADIUS ((USAGE) 0x0409)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ERROR_RADIUS = ((ushort)(0x0409));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_FIX_QUALITY ((USAGE) 0x040A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_FIX_QUALITY = ((ushort)(0x040A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_FIX_TYPE ((USAGE) 0x040B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_FIX_TYPE = ((ushort)(0x040B));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GEOIDAL_SEPARATION ((USAGE) 0x040C)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GEOIDAL_SEPARATION = ((ushort)(0x040C));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GPS_OPERATION_MODE ((USAGE) 0x040D)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GPS_OPERATION_MODE = ((ushort)(0x040D));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GPS_SELECTION_MODE ((USAGE) 0x040E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GPS_SELECTION_MODE = ((ushort)(0x040E));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GPS_STATUS ((USAGE) 0x040F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GPS_STATUS = ((ushort)(0x040F));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_POSITION_DILUTION_OF_PRECISION ((USAGE) 0x0410)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_POSITION_DILUTION_OF_PRECISION = (
        (ushort)(0x0410)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HORIZONTAL_DILUTION_OF_PRECISION ((USAGE) 0x0411)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HORIZONTAL_DILUTION_OF_PRECISION = (
        (ushort)(0x0411)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_VERTICAL_DILUTION_OF_PRECISION ((USAGE) 0x0412)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_VERTICAL_DILUTION_OF_PRECISION = (
        (ushort)(0x0412)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_LATITUDE ((USAGE) 0x0413)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_LATITUDE = ((ushort)(0x0413));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_LONGITUDE ((USAGE) 0x0414)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_LONGITUDE = ((ushort)(0x0414));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TRUE_HEADING ((USAGE) 0x0415)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TRUE_HEADING = ((ushort)(0x0415));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_HEADING ((USAGE) 0x0416)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_HEADING = ((ushort)(0x0416));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_VARIATION ((USAGE) 0x0417)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_VARIATION = ((ushort)(0x0417));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SPEED ((USAGE) 0x0418)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SPEED = ((ushort)(0x0418));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW ((USAGE) 0x0419)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW = ((ushort)(0x0419));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_AZIMUTH ((USAGE) 0x041A)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_AZIMUTH = (
        (ushort)(0x041A)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_ELEVATION ((USAGE) 0x041B)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_ELEVATION = (
        (ushort)(0x041B)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_IDS ((USAGE) 0x041C)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_IDS = ((ushort)(0x041C));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_PRNS ((USAGE) 0x041D)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_PRNS = ((ushort)(0x041D));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_SN_RATIOS ((USAGE) 0x041E)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_IN_VIEW_SN_RATIOS = (
        (ushort)(0x041E)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_USED_COUNT ((USAGE) 0x041F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_USED_COUNT = ((ushort)(0x041F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_USED_PRNS ((USAGE) 0x0420)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SATELLITES_USED_PRNS = ((ushort)(0x0420));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_NMEA_SENTENCE ((USAGE) 0x0421)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_NMEA_SENTENCE = ((ushort)(0x0421));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ADDRESS_LINE_1 ((USAGE) 0x0422)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ADDRESS_LINE_1 = ((ushort)(0x0422));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ADDRESS_LINE_2 ((USAGE) 0x0423)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ADDRESS_LINE_2 = ((ushort)(0x0423));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CITY ((USAGE) 0x0424)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CITY = ((ushort)(0x0424));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STATE_OR_PROVINCE ((USAGE) 0x0425)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STATE_OR_PROVINCE = ((ushort)(0x0425));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_COUNTRY_OR_REGION ((USAGE) 0x0426)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_COUNTRY_OR_REGION = ((ushort)(0x0426));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_POSTAL_CODE ((USAGE) 0x0427)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_POSTAL_CODE = ((ushort)(0x0427));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_LOCATION ((USAGE) 0x042A)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_LOCATION = ((ushort)(0x042A));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_LOCATION_DESIRED_ACCURACY ((USAGE) 0x042B)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_LOCATION_DESIRED_ACCURACY = ((ushort)(0x042B));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ENVIRONMENTAL ((USAGE) 0x0430)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ENVIRONMENTAL = ((ushort)(0x0430));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ATMOSPHERIC_PRESSURE ((USAGE) 0x0431)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ATMOSPHERIC_PRESSURE = ((ushort)(0x0431));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RELATIVE_HUMIDITY ((USAGE) 0x0433)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RELATIVE_HUMIDITY = ((ushort)(0x0433));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TEMPERATURE ((USAGE) 0x0434)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TEMPERATURE = ((ushort)(0x0434));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_WIND_DIRECTION ((USAGE) 0x0435)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_WIND_DIRECTION = ((ushort)(0x0435));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_WIND_SPEED ((USAGE) 0x0436)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_WIND_SPEED = ((ushort)(0x0436));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_AIR_QUALITY_INDEX ((USAGE) 0x0437)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_AIR_QUALITY_INDEX = ((ushort)(0x0437));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_EQUIVALENT_CO2 ((USAGE) 0x0438)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_EQUIVALENT_CO2 = ((ushort)(0x0438));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_VOLATILE_ORGANIC_COMPOUND_CONCENTRATION ((USAGE) 0x0439)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_VOLATILE_ORGANIC_COMPOUND_CONCENTRATION = (
        (ushort)(0x0439)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PRESENCE ((USAGE) 0x043A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PRESENCE = ((ushort)(0x043A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PROXIMITY_RANGE ((USAGE) 0x043B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PROXIMITY_RANGE = ((ushort)(0x043B));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PROXIMITY_OUT_OF_RANGE ((USAGE) 0x043C)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_OBJECT_PROXIMITY_OUT_OF_RANGE = (
        (ushort)(0x043C)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_ENVIRONMENTAL ((USAGE) 0x0440)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_ENVIRONMENTAL = ((ushort)(0x0440));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_REFERENCE_PRESSURE ((USAGE) 0x0441)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_REFERENCE_PRESSURE = ((ushort)(0x0441));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MOTION ((USAGE) 0x0450)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MOTION = ((ushort)(0x0450));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MOTION_STATE ((USAGE) 0x0451)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MOTION_STATE = ((ushort)(0x0451));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION ((USAGE) 0x0452)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION = ((ushort)(0x0452));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_X ((USAGE) 0x0453)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_X = ((ushort)(0x0453));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_Y ((USAGE) 0x0454)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_Y = ((ushort)(0x0454));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_Z ((USAGE) 0x0455)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACCELERATION_AXIS_Z = ((ushort)(0x0455));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY ((USAGE) 0x0456)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY = ((ushort)(0x0456));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_X_AXIS ((USAGE) 0x0457)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_X_AXIS = (
        (ushort)(0x0457)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_Y_AXIS ((USAGE) 0x0458)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_Y_AXIS = (
        (ushort)(0x0458)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_Z_AXIS ((USAGE) 0x0459)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_VELOCITY_ABOUT_Z_AXIS = (
        (ushort)(0x0459)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION ((USAGE) 0x045A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION = ((ushort)(0x045A));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_X_AXIS ((USAGE) 0x045B)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_X_AXIS = (
        (ushort)(0x045B)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_Y_AXIS ((USAGE) 0x045C)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_Y_AXIS = (
        (ushort)(0x045C)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_Z_AXIS ((USAGE) 0x045D)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ANGULAR_POSITION_ABOUT_Z_AXIS = (
        (ushort)(0x045D)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MOTION_SPEED ((USAGE) 0x045E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MOTION_SPEED = ((ushort)(0x045E));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MOTION_INTENSITY ((USAGE) 0x045F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MOTION_INTENSITY = ((ushort)(0x045F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ORIENTATION ((USAGE) 0x0470)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ORIENTATION = ((ushort)(0x0470));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING ((USAGE) 0x0471)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING = ((ushort)(0x0471));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_X_AXIS ((USAGE) 0x0472)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_X_AXIS = ((ushort)(0x0472));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_Y_AXIS ((USAGE) 0x0473)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_Y_AXIS = ((ushort)(0x0473));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_Z_AXIS ((USAGE) 0x0474)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_Z_AXIS = ((ushort)(0x0474));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_COMPENSATED_MAGNETIC_NORTH ((USAGE) 0x0475)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_COMPENSATED_MAGNETIC_NORTH = (
        (ushort)(0x0475)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_COMPENSATED_TRUE_NORTH ((USAGE) 0x0476)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_COMPENSATED_TRUE_NORTH = (
        (ushort)(0x0476)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_MAGNETIC_NORTH ((USAGE) 0x0477)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_MAGNETIC_NORTH = ((ushort)(0x0477));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEADING_TRUE_NORTH ((USAGE) 0x0478)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEADING_TRUE_NORTH = ((ushort)(0x0478));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DISTANCE ((USAGE) 0x0479)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DISTANCE = ((ushort)(0x0479));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_X_AXIS ((USAGE) 0x047A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_X_AXIS = ((ushort)(0x047A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_Y_AXIS ((USAGE) 0x047B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_Y_AXIS = ((ushort)(0x047B));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_Z_AXIS ((USAGE) 0x047C)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_Z_AXIS = ((ushort)(0x047C));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_OUTOFRANGE ((USAGE) 0x047D)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DISTANCE_OUTOFRANGE = ((ushort)(0x047D));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TILT ((USAGE) 0x047E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TILT = ((ushort)(0x047E));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TILT_X_AXIS ((USAGE) 0x047F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TILT_X_AXIS = ((ushort)(0x047F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TILT_Y_AXIS ((USAGE) 0x0480)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TILT_Y_AXIS = ((ushort)(0x0480));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TILT_Z_AXIS ((USAGE) 0x0481)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TILT_Z_AXIS = ((ushort)(0x0481));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ROTATION_MATRIX ((USAGE) 0x0482)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ROTATION_MATRIX = ((ushort)(0x0482));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_QUATERNION ((USAGE) 0x0483)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_QUATERNION = ((ushort)(0x0483));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX ((USAGE) 0x0484)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX = ((ushort)(0x0484));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_X_AXIS ((USAGE) 0x0485)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_X_AXIS = ((ushort)(0x0485));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_Y_AXIS ((USAGE) 0x0486)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_Y_AXIS = ((ushort)(0x0486));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_Z_AXIS ((USAGE) 0x0487)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETIC_FLUX_Z_AXIS = ((ushort)(0x0487));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MAGNETOMETER_ACCURACY ((USAGE) 0x0488)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MAGNETOMETER_ACCURACY = ((ushort)(0x0488));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_SIMPLE_ORIENTATION_DIRECTION ((USAGE) 0x0489)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SIMPLE_ORIENTATION_DIRECTION = (
        (ushort)(0x0489)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MECHANICAL ((USAGE) 0x0490)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MECHANICAL = ((ushort)(0x0490));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_BOOLEAN_SWITCH_STATE ((USAGE) 0x0491)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BOOLEAN_SWITCH_STATE = ((ushort)(0x0491));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_BOOLEAN_SWITCH_ARRAY_STATES ((USAGE) 0x0492)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BOOLEAN_SWITCH_ARRAY_STATES = (
        (ushort)(0x0492)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_MULTIVALUE_SWITCH_VALUE ((USAGE) 0x0493)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MULTIVALUE_SWITCH_VALUE = ((ushort)(0x0493));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_FORCE ((USAGE) 0x0494)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_FORCE = ((ushort)(0x0494));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ABSOLUTE_PRESSURE ((USAGE) 0x0495)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ABSOLUTE_PRESSURE = ((ushort)(0x0495));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GAUGE_PRESSURE ((USAGE) 0x0496)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GAUGE_PRESSURE = ((ushort)(0x0496));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STRAIN ((USAGE) 0x0497)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STRAIN = ((ushort)(0x0497));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_WEIGHT ((USAGE) 0x0498)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_WEIGHT = ((ushort)(0x0498));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_MECHANICAL ((USAGE) 0x04A0)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MECHANICAL = ((ushort)(0x04A0));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_VIBRATION_STATE ((USAGE) 0x04A1)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_VIBRATION_STATE = ((ushort)(0x04A1));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_FORWARD_VIBRATION_SPEED ((USAGE) 0x04A2)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_FORWARD_VIBRATION_SPEED = ((ushort)(0x04A2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_BACKWARD_VIBRATION_SPEED ((USAGE) 0x04A3)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_BACKWARD_VIBRATION_SPEED = ((ushort)(0x04A3));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_BIOMETRIC ((USAGE) 0x04B0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BIOMETRIC = ((ushort)(0x04B0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PRESENCE ((USAGE) 0x04B1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PRESENCE = ((ushort)(0x04B1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PROXIMITY_RANGE ((USAGE) 0x04B2)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PROXIMITY_RANGE = ((ushort)(0x04B2));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PROXIMITY_OUT_OF_RANGE ((USAGE) 0x04B3)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_PROXIMITY_OUT_OF_RANGE = (
        (ushort)(0x04B3)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_TOUCH_STATE ((USAGE) 0x04B4)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_TOUCH_STATE = ((ushort)(0x04B4));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE ((USAGE) 0x04B5)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE = ((ushort)(0x04B5));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE_DIASTOLIC ((USAGE) 0x04B6)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE_DIASTOLIC = ((ushort)(0x04B6));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE_SYSTOLIC ((USAGE) 0x04B7)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BLOOD_PRESSURE_SYSTOLIC = ((ushort)(0x04B7));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEART_RATE ((USAGE) 0x04B8)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEART_RATE = ((ushort)(0x04B8));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RESTING_HEART_RATE ((USAGE) 0x04B9)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RESTING_HEART_RATE = ((ushort)(0x04B9));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HEARTBEAT_INTERVAL ((USAGE) 0x04BA)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HEARTBEAT_INTERVAL = ((ushort)(0x04BA));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RESPIRATORY_RATE ((USAGE) 0x04BB)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RESPIRATORY_RATE = ((ushort)(0x04BB));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SPO2 ((USAGE) 0x04BC)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SPO2 = ((ushort)(0x04BC));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_ATTENTION_DETECTED ((USAGE) 0x04BD)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_ATTENTION_DETECTED = ((ushort)(0x04BD));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_AZIMUTH ((USAGE) 0x04BE)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_AZIMUTH = ((ushort)(0x04BE));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_ALTITUDE ((USAGE) 0x04BF)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_ALTITUDE = ((ushort)(0x04BF));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_ROLL ((USAGE) 0x04C0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_ROLL = ((ushort)(0x04C0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_PITCH ((USAGE) 0x04C1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_PITCH = ((ushort)(0x04C1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_YAW ((USAGE) 0x04C2)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_HEAD_YAW = ((ushort)(0x04C2));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HUMAN_CORRELATION_ID ((USAGE) 0x04C3)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HUMAN_CORRELATION_ID = ((ushort)(0x04C3));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_LIGHT ((USAGE) 0x04D0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_LIGHT = ((ushort)(0x04D0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ILLUMINANCE ((USAGE) 0x04D1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ILLUMINANCE = ((ushort)(0x04D1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_COLOR_TEMPERATURE ((USAGE) 0x04D2)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_COLOR_TEMPERATURE = ((ushort)(0x04D2));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY ((USAGE) 0x04D3)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY = ((ushort)(0x04D3));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY_X ((USAGE) 0x04D4)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY_X = ((ushort)(0x04D4));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY_Y ((USAGE) 0x04D5)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CHROMATICITY_Y = ((ushort)(0x04D5));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_CONSUMER_IR_SENTENCE_RECEIVE ((USAGE) 0x04D6)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CONSUMER_IR_SENTENCE_RECEIVE = (
        (ushort)(0x04D6)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_INFRARED_LIGHT ((USAGE) 0x04D7)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_INFRARED_LIGHT = ((ushort)(0x04D7));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RED_LIGHT ((USAGE) 0x04D8)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RED_LIGHT = ((ushort)(0x04D8));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GREEN_LIGHT ((USAGE) 0x04D9)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GREEN_LIGHT = ((ushort)(0x04D9));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_BLUE_LIGHT ((USAGE) 0x04DA)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_BLUE_LIGHT = ((ushort)(0x04DA));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_A_LIGHT ((USAGE) 0x04DB)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_A_LIGHT = ((ushort)(0x04DB));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_B_LIGHT ((USAGE) 0x04DC)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_B_LIGHT = ((ushort)(0x04DC));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_INDEX ((USAGE) 0x04DD)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ULTRAVIOLET_INDEX = ((ushort)(0x04DD));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_NEAR_INFRARED_LIGHT ((USAGE) 0x04DE)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_NEAR_INFRARED_LIGHT = ((ushort)(0x04DE));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_LIGHT ((USAGE) 0x04DF)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_LIGHT = ((ushort)(0x04DF));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_CONSUMER_IR_SENTENCE_SEND ((USAGE) 0x04E0)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CONSUMER_IR_SENTENCE_SEND = ((ushort)(0x04E0));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_AUTO_BRIGHTNESS_PREFERRED ((USAGE) 0x04E2)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_AUTO_BRIGHTNESS_PREFERRED = ((ushort)(0x04E2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_AUTO_COLOR_PREFERRED ((USAGE) 0x04E3)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_AUTO_COLOR_PREFERRED = ((ushort)(0x04E3));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SCANNER ((USAGE) 0x04F0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SCANNER = ((ushort)(0x04F0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RFID_TAG_40_BIT ((USAGE) 0x04F1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RFID_TAG_40_BIT = ((ushort)(0x04F1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_NFC_SENTENCE_RECEIVE ((USAGE) 0x04F2)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_NFC_SENTENCE_RECEIVE = ((ushort)(0x04F2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SCANNER ((USAGE) 0x04F8)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SCANNER = ((ushort)(0x04F8));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_NFC_SENTENCE_SEND ((USAGE) 0x04F9)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_NFC_SENTENCE_SEND = ((ushort)(0x04F9));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ELECTRICAL ((USAGE) 0x0500)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ELECTRICAL = ((ushort)(0x0500));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CAPACITANCE ((USAGE) 0x0501)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CAPACITANCE = ((ushort)(0x0501));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CURRENT ((USAGE) 0x0502)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CURRENT = ((ushort)(0x0502));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ELECTRICAL_POWER ((USAGE) 0x0503)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ELECTRICAL_POWER = ((ushort)(0x0503));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_INDUCTANCE ((USAGE) 0x0504)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_INDUCTANCE = ((ushort)(0x0504));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_RESISTANCE ((USAGE) 0x0505)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_RESISTANCE = ((ushort)(0x0505));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_VOLTAGE ((USAGE) 0x0506)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_VOLTAGE = ((ushort)(0x0506));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_FREQUENCY ((USAGE) 0x0507)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_FREQUENCY = ((ushort)(0x0507));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_PERIOD ((USAGE) 0x0508)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_PERIOD = ((ushort)(0x0508));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_PERCENT_OF_RANGE ((USAGE) 0x0509)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_PERCENT_OF_RANGE = ((ushort)(0x0509));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TIME ((USAGE) 0x0520)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TIME = ((ushort)(0x0520));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_YEAR ((USAGE) 0x0521)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_YEAR = ((ushort)(0x0521));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MONTH ((USAGE) 0x0522)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MONTH = ((ushort)(0x0522));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DAY ((USAGE) 0x0523)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DAY = ((ushort)(0x0523));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DAY_OF_WEEK ((USAGE) 0x0524)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DAY_OF_WEEK = ((ushort)(0x0524));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HOUR ((USAGE) 0x0525)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HOUR = ((ushort)(0x0525));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MINUTE ((USAGE) 0x0526)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MINUTE = ((ushort)(0x0526));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_SECOND ((USAGE) 0x0527)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_SECOND = ((ushort)(0x0527));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_MILLISECOND ((USAGE) 0x0528)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_MILLISECOND = ((ushort)(0x0528));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TIMESTAMP ((USAGE) 0x0529)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TIMESTAMP = ((ushort)(0x0529));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_JULIAN_DAY_OF_YEAR ((USAGE) 0x052A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_JULIAN_DAY_OF_YEAR = ((ushort)(0x052A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_TIME_SINCE_SYSTEM_BOOT ((USAGE) 0x052B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_TIME_SINCE_SYSTEM_BOOT = ((ushort)(0x052B));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_TIME ((USAGE) 0x0530)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_TIME = ((ushort)(0x0530));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_TIME_ZONE_OFFSET_FROM_UTC ((USAGE) 0x0531)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_TIME_ZONE_OFFSET_FROM_UTC = ((ushort)(0x0531));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_TIME_ZONE_NAME ((USAGE) 0x0532)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_TIME_ZONE_NAME = ((ushort)(0x0532));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_DAYLIGHT_SAVINGS_TIME_OBSERVED ((USAGE) 0x0533)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_DAYLIGHT_SAVINGS_TIME_OBSERVED = (
        (ushort)(0x0533)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_TIME_TRIM_ADJUSTMENT ((USAGE) 0x0534)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_TIME_TRIM_ADJUSTMENT = ((ushort)(0x0534));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_ARM_ALARM ((USAGE) 0x0535)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_ARM_ALARM = ((ushort)(0x0535));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM ((USAGE) 0x0540)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM = ((ushort)(0x0540));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_USAGE ((USAGE) 0x0541)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_USAGE = ((ushort)(0x0541));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_BOOLEAN_ARRAY ((USAGE) 0x0542)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_BOOLEAN_ARRAY = ((ushort)(0x0542));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE ((USAGE) 0x0543)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE = ((ushort)(0x0543));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_1 ((USAGE) 0x0544)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_1 = ((ushort)(0x0544));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_2 ((USAGE) 0x0545)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_2 = ((ushort)(0x0545));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_3 ((USAGE) 0x0546)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_3 = ((ushort)(0x0546));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_4 ((USAGE) 0x0547)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_4 = ((ushort)(0x0547));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_5 ((USAGE) 0x0548)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_5 = ((ushort)(0x0548));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_6 ((USAGE) 0x0549)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_6 = ((ushort)(0x0549));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_7 ((USAGE) 0x054A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_7 = ((ushort)(0x054A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_8 ((USAGE) 0x054B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_8 = ((ushort)(0x054B));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_9 ((USAGE) 0x054C)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_9 = ((ushort)(0x054C));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_10 ((USAGE) 0x054D)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_10 = ((ushort)(0x054D));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_11 ((USAGE) 0x054E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_11 = ((ushort)(0x054E));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_12 ((USAGE) 0x054F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_12 = ((ushort)(0x054F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_13 ((USAGE) 0x0550)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_13 = ((ushort)(0x0550));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_14 ((USAGE) 0x0551)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_14 = ((ushort)(0x0551));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_15 ((USAGE) 0x0552)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_15 = ((ushort)(0x0552));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_16 ((USAGE) 0x0553)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_16 = ((ushort)(0x0553));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_17 ((USAGE) 0x0554)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_17 = ((ushort)(0x0554));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_18 ((USAGE) 0x0555)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_18 = ((ushort)(0x0555));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_19 ((USAGE) 0x0556)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_19 = ((ushort)(0x0556));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_20 ((USAGE) 0x0557)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_20 = ((ushort)(0x0557));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_21 ((USAGE) 0x0558)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_21 = ((ushort)(0x0558));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_22 ((USAGE) 0x0559)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_22 = ((ushort)(0x0559));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_23 ((USAGE) 0x055A)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_23 = ((ushort)(0x055A));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_24 ((USAGE) 0x055B)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_24 = ((ushort)(0x055B));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_25 ((USAGE) 0x055C)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_25 = ((ushort)(0x055C));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_26 ((USAGE) 0x055D)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_26 = ((ushort)(0x055D));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_27 ((USAGE) 0x055E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_27 = ((ushort)(0x055E));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_28 ((USAGE) 0x055F)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_VALUE_28 = ((ushort)(0x055F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC ((USAGE) 0x0560)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC = ((ushort)(0x0560));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID_OR_PROPERTYKEY ((USAGE) 0x0561)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID_OR_PROPERTYKEY = (
        (ushort)(0x0561)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_CATEGORY_GUID ((USAGE) 0x0562)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_CATEGORY_GUID = ((ushort)(0x0562));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_TYPE_GUID ((USAGE) 0x0563)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_TYPE_GUID = ((ushort)(0x0563));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_EVENT_PROPERTYKEY ((USAGE) 0x0564)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_EVENT_PROPERTYKEY = ((ushort)(0x0564));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTY_PROPERTYKEY ((USAGE) 0x0565)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTY_PROPERTYKEY = (
        (ushort)(0x0565)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_DATA_FIELD_PROPERTYKEY ((USAGE) 0x0566)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_DATA_FIELD_PROPERTYKEY = (
        (ushort)(0x0566)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_EVENT ((USAGE) 0x0567)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_EVENT = ((ushort)(0x0567));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTY ((USAGE) 0x0568)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTY = ((ushort)(0x0568));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_DATA_FIELD ((USAGE) 0x0569)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_DATA_FIELD = ((ushort)(0x0569));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ENUMERATOR_TABLE_ROW_INDEX ((USAGE) 0x056A)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ENUMERATOR_TABLE_ROW_INDEX = (
        (ushort)(0x056A)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_ENUMERATOR_TABLE_ROW_COUNT ((USAGE) 0x056B)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ENUMERATOR_TABLE_ROW_COUNT = (
        (ushort)(0x056B)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID_OR_PROPERTYKEY_KIND ((USAGE) 0x056C)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID_OR_PROPERTYKEY_KIND = (
        (ushort)(0x056C)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID ((USAGE) 0x056D)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_GUID = ((ushort)(0x056D));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTYKEY ((USAGE) 0x056E)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_PROPERTYKEY = ((ushort)(0x056E));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_TOP_LEVEL_COLLECTION_ID ((USAGE) 0x056F)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_TOP_LEVEL_COLLECTION_ID = (
        (ushort)(0x056F)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_ID ((USAGE) 0x0570)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_ID = ((ushort)(0x0570));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_ITEM_POSITION_INDEX ((USAGE) 0x0571)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_ITEM_POSITION_INDEX = (
        (ushort)(0x0571)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_FIRMWARE_VARTYPE ((USAGE) 0x0572)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_FIRMWARE_VARTYPE = ((ushort)(0x0572));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_UNIT_OF_MEASURE ((USAGE) 0x0573)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_UNIT_OF_MEASURE = ((ushort)(0x0573));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_UNIT_EXPONENT ((USAGE) 0x0574)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_UNIT_EXPONENT = ((ushort)(0x0574));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_SIZE ((USAGE) 0x0575)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_SIZE = ((ushort)(0x0575));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_COUNT ((USAGE) 0x0576)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GENERIC_REPORT_COUNT = ((ushort)(0x0576));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_GENERIC ((USAGE) 0x0580)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_GENERIC = ((ushort)(0x0580));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_ENUMERATOR_TABLE_ROW_INDEX ((USAGE) 0x0581)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_ENUMERATOR_TABLE_ROW_INDEX = ((ushort)(0x0581));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_ENUMERATOR_TABLE_ROW_COUNT ((USAGE) 0x0582)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_ENUMERATOR_TABLE_ROW_COUNT = ((ushort)(0x0582));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_PERSONAL_ACTIVITY ((USAGE) 0x0590)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_PERSONAL_ACTIVITY = ((ushort)(0x0590));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACTIVITY_TYPE ((USAGE) 0x0591)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACTIVITY_TYPE = ((ushort)(0x0591));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_ACTIVITY_STATE ((USAGE) 0x0592)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_ACTIVITY_STATE = ((ushort)(0x0592));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_DEVICE_POSITION ((USAGE) 0x0593)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_DEVICE_POSITION = ((ushort)(0x0593));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STEP_COUNT ((USAGE) 0x0594)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STEP_COUNT = ((ushort)(0x0594));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STEP_COUNT_RESET ((USAGE) 0x0595)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STEP_COUNT_RESET = ((ushort)(0x0595));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STEP_DURATION ((USAGE) 0x0596)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STEP_DURATION = ((ushort)(0x0596));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_STEP_TYPE ((USAGE) 0x0597)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_STEP_TYPE = ((ushort)(0x0597));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_MINIMUM_ACTIVITY_DETECTION_INTERVAL ((USAGE) 0x05A0)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_MINIMUM_ACTIVITY_DETECTION_INTERVAL = (
        (ushort)(0x05A0)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SUPPORTED_ACTIVITY_TYPES ((USAGE) 0x05A1)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SUPPORTED_ACTIVITY_TYPES = ((ushort)(0x05A1));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_PROPERTY_SUBSCRIBED_ACTIVITY_TYPES ((USAGE) 0x05A2)"
    )]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SUBSCRIBED_ACTIVITY_TYPES = ((ushort)(0x05A2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SUPPORTED_STEP_TYPES ((USAGE) 0x05A3)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SUPPORTED_STEP_TYPES = ((ushort)(0x05A3));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_SUBSCRIBED_STEP_TYPES ((USAGE) 0x05A4)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_SUBSCRIBED_STEP_TYPES = ((ushort)(0x05A4));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_FLOOR_HEIGHT ((USAGE) 0x05A5)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_FLOOR_HEIGHT = ((ushort)(0x05A5));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_TYPE_ID ((USAGE) 0x05B0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_CUSTOM_TYPE_ID = ((ushort)(0x05B0));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM ((USAGE) 0x05C0)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM = ((ushort)(0x05C0));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_1 ((USAGE) 0x05C1)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_1 = ((ushort)(0x05C1));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_2 ((USAGE) 0x05C2)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_2 = ((ushort)(0x05C2));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_3 ((USAGE) 0x05C3)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_3 = ((ushort)(0x05C3));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_4 ((USAGE) 0x05C4)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_4 = ((ushort)(0x05C4));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_5 ((USAGE) 0x05C5)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_5 = ((ushort)(0x05C5));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_6 ((USAGE) 0x05C6)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_6 = ((ushort)(0x05C6));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_7 ((USAGE) 0x05C7)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_7 = ((ushort)(0x05C7));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_8 ((USAGE) 0x05C8)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_8 = ((ushort)(0x05C8));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_9 ((USAGE) 0x05C9)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_9 = ((ushort)(0x05C9));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_10 ((USAGE) 0x05CA)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_10 = ((ushort)(0x05CA));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_11 ((USAGE) 0x05CB)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_11 = ((ushort)(0x05CB));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_12 ((USAGE) 0x05CC)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_12 = ((ushort)(0x05CC));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_13 ((USAGE) 0x05CD)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_13 = ((ushort)(0x05CD));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_14 ((USAGE) 0x05CE)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_14 = ((ushort)(0x05CE));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_15 ((USAGE) 0x05CF)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_15 = ((ushort)(0x05CF));

    [NativeTypeName("#define HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_16 ((USAGE) 0x05D0)")]
    public const ushort HID_USAGE_SENSORS_PROPERTY_CUSTOM_VALUE_16 = ((ushort)(0x05D0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HINGE ((USAGE) 0x05E0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE = ((ushort)(0x05E0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HINGE_ANGLE ((USAGE) 0x05E1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE_ANGLE = ((ushort)(0x05E1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GESTURE_SENSOR ((USAGE) 0x05F0)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GESTURE_SENSOR = ((ushort)(0x05F0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_GESTURE_STATE ((USAGE) 0x05F1)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_GESTURE_STATE = ((ushort)(0x05F1));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_INITIAL_ANGLE ((USAGE) 0x05F2)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_INITIAL_ANGLE = ((ushort)(0x05F2));

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_FINAL_ANGLE ((USAGE) 0x05F3)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_FINAL_ANGLE = ((ushort)(0x05F3));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_CONTRIBUTING_PANEL ((USAGE) 0x05F4)"
    )]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_CONTRIBUTING_PANEL = (
        (ushort)(0x05F4)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_TYPE ((USAGE) 0x05F5)")]
    public const ushort HID_USAGE_SENSORS_DATA_FIELD_HINGE_FOLD_TYPE = ((ushort)(0x05F5));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_UNDEFINED ((USAGE) 0x0800)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_UNDEFINED = ((ushort)(0x0800));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_READY ((USAGE) 0x0801)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_READY = ((ushort)(0x0801));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_NOT_AVAILABLE ((USAGE) 0x0802)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_NOT_AVAILABLE = ((ushort)(0x0802));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_NO_DATA ((USAGE) 0x0803)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_NO_DATA = ((ushort)(0x0803));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_INITIALIZING ((USAGE) 0x0804)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_INITIALIZING = ((ushort)(0x0804));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_ACCESS_DENIED ((USAGE) 0x0805)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_ACCESS_DENIED = ((ushort)(0x0805));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_STATE_ERROR ((USAGE) 0x0806)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_STATE_ERROR = ((ushort)(0x0806));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_UNKNOWN ((USAGE) 0x0810)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_UNKNOWN = ((ushort)(0x0810));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_STATE_CHANGED ((USAGE) 0x0811)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_STATE_CHANGED = ((ushort)(0x0811));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_PROPERTY_CHANGED ((USAGE) 0x0812)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_PROPERTY_CHANGED = ((ushort)(0x0812));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_DATA_UPDATED ((USAGE) 0x0813)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_DATA_UPDATED = ((ushort)(0x0813));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_POLL_RESPONSE ((USAGE) 0x0814)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_POLL_RESPONSE = ((ushort)(0x0814));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_CHANGE_SENSITIVITY ((USAGE) 0x0815)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_CHANGE_SENSITIVITY = ((ushort)(0x0815));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_RANGE_MAXIMUM_REACHED ((USAGE) 0x0816)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_RANGE_MAXIMUM_REACHED = ((ushort)(0x0816));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_RANGE_MINIMUM_REACHED ((USAGE) 0x0817)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_RANGE_MINIMUM_REACHED = ((ushort)(0x0817));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_HIGH_THRESHOLD_CROSS_UPWARD ((USAGE) 0x0818)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_HIGH_THRESHOLD_CROSS_UPWARD = (
        (ushort)(0x0818)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_HIGH_THRESHOLD_CROSS_DOWNWARD ((USAGE) 0x0819)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_HIGH_THRESHOLD_CROSS_DOWNWARD = (
        (ushort)(0x0819)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_LOW_THRESHOLD_CROSS_UPWARD ((USAGE) 0x081A)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_LOW_THRESHOLD_CROSS_UPWARD = (
        (ushort)(0x081A)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_LOW_THRESHOLD_CROSS_DOWNWARD ((USAGE) 0x081B)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_LOW_THRESHOLD_CROSS_DOWNWARD = (
        (ushort)(0x081B)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_ZERO_THRESHOLD_CROSS_UPWARD ((USAGE) 0x081C)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_ZERO_THRESHOLD_CROSS_UPWARD = (
        (ushort)(0x081C)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SENSOR_EVENT_ZERO_THRESHOLD_CROSS_DOWNWARD ((USAGE) 0x081D)"
    )]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_ZERO_THRESHOLD_CROSS_DOWNWARD = (
        (ushort)(0x081D)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_PERIOD_EXCEEDED ((USAGE) 0x081E)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_PERIOD_EXCEEDED = ((ushort)(0x081E));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_FREQUENCY_EXCEEDED ((USAGE) 0x081F)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_FREQUENCY_EXCEEDED = ((ushort)(0x081F));

    [NativeTypeName("#define HID_USAGE_SENSORS_SENSOR_EVENT_COMPLEX_TRIGGER ((USAGE) 0x0820)")]
    public const ushort HID_USAGE_SENSORS_SENSOR_EVENT_COMPLEX_TRIGGER = ((ushort)(0x0820));

    [NativeTypeName("#define HID_USAGE_SENSORS_CONNECTION_TYPE_PC_INTEGRATED ((USAGE) 0x0830)")]
    public const ushort HID_USAGE_SENSORS_CONNECTION_TYPE_PC_INTEGRATED = ((ushort)(0x0830));

    [NativeTypeName("#define HID_USAGE_SENSORS_CONNECTION_TYPE_PC_ATTACHED ((USAGE) 0x0831)")]
    public const ushort HID_USAGE_SENSORS_CONNECTION_TYPE_PC_ATTACHED = ((ushort)(0x0831));

    [NativeTypeName("#define HID_USAGE_SENSORS_CONNECTION_TYPE_PC_EXTERNAL ((USAGE) 0x0832)")]
    public const ushort HID_USAGE_SENSORS_CONNECTION_TYPE_PC_EXTERNAL = ((ushort)(0x0832));

    [NativeTypeName("#define HID_USAGE_SENSORS_REPORTING_STATE_REPORT_NO_EVENTS ((USAGE) 0x0840)")]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_REPORT_NO_EVENTS = ((ushort)(0x0840));

    [NativeTypeName("#define HID_USAGE_SENSORS_REPORTING_STATE_REPORT_ALL_EVENTS ((USAGE) 0x0841)")]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_REPORT_ALL_EVENTS = ((ushort)(0x0841));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_REPORTING_STATE_REPORT_THRESHOLD_EVENTS ((USAGE) 0x0842)"
    )]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_REPORT_THRESHOLD_EVENTS = (
        (ushort)(0x0842)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_NO_EVENTS ((USAGE) 0x0843)")]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_NO_EVENTS = ((ushort)(0x0843));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_ALL_EVENTS ((USAGE) 0x0844)"
    )]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_ALL_EVENTS = ((ushort)(0x0844));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_THRESHOLD_EVENTS ((USAGE) 0x0845)"
    )]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_WAKE_ON_THRESHOLD_EVENTS = (
        (ushort)(0x0845)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_REPORTING_STATE_ANYTIME_SEL ((USAGE) 0x0846)")]
    public const ushort HID_USAGE_SENSORS_REPORTING_STATE_ANYTIME_SEL = ((ushort)(0x0846));

    [NativeTypeName("#define HID_USAGE_SENSORS_POWER_STATE_UNDEFINED ((USAGE) 0x0850)")]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_UNDEFINED = ((ushort)(0x0850));

    [NativeTypeName("#define HID_USAGE_SENSORS_POWER_STATE_D0_FULL_POWER ((USAGE) 0x0851)")]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_D0_FULL_POWER = ((ushort)(0x0851));

    [NativeTypeName("#define HID_USAGE_SENSORS_POWER_STATE_D1_LOW_POWER ((USAGE) 0x0852)")]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_D1_LOW_POWER = ((ushort)(0x0852));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_POWER_STATE_D2_STANDBY_POWER_WITH_WAKEUP ((USAGE) 0x0853)"
    )]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_D2_STANDBY_POWER_WITH_WAKEUP = (
        (ushort)(0x0853)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_POWER_STATE_D3_SLEEP_WITH_WAKEUP ((USAGE) 0x0854)")]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_D3_SLEEP_WITH_WAKEUP = ((ushort)(0x0854));

    [NativeTypeName("#define HID_USAGE_SENSORS_POWER_STATE_D4_POWER_OFF ((USAGE) 0x0855)")]
    public const ushort HID_USAGE_SENSORS_POWER_STATE_D4_POWER_OFF = ((ushort)(0x0855));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACCURACY_DEFAULT ((USAGE) 0x0860)")]
    public const ushort HID_USAGE_SENSORS_ACCURACY_DEFAULT = ((ushort)(0x0860));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACCURACY_HIGH ((USAGE) 0x0861)")]
    public const ushort HID_USAGE_SENSORS_ACCURACY_HIGH = ((ushort)(0x0861));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACCURACY_MEDIUM ((USAGE) 0x0862)")]
    public const ushort HID_USAGE_SENSORS_ACCURACY_MEDIUM = ((ushort)(0x0862));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACCURACY_LOW ((USAGE) 0x0863)")]
    public const ushort HID_USAGE_SENSORS_ACCURACY_LOW = ((ushort)(0x0863));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_QUALITY_NO_FIX ((USAGE) 0x0870)")]
    public const ushort HID_USAGE_SENSORS_FIX_QUALITY_NO_FIX = ((ushort)(0x0870));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_QUALITY_GPS ((USAGE) 0x0871)")]
    public const ushort HID_USAGE_SENSORS_FIX_QUALITY_GPS = ((ushort)(0x0871));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_QUALITY_DGPS ((USAGE) 0x0872)")]
    public const ushort HID_USAGE_SENSORS_FIX_QUALITY_DGPS = ((ushort)(0x0872));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_NO_FIX ((USAGE) 0x0880)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_NO_FIX = ((ushort)(0x0880));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_GPS_SPS_MODE_FIX_VALID ((USAGE) 0x0881)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_GPS_SPS_MODE_FIX_VALID = ((ushort)(0x0881));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_DGPS_SPS_MODE_FIX_VALID ((USAGE) 0x0882)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_DGPS_SPS_MODE_FIX_VALID = ((ushort)(0x0882));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_GPS_PPS_MODE_FIX_VALID ((USAGE) 0x0883)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_GPS_PPS_MODE_FIX_VALID = ((ushort)(0x0883));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_REAL_TIME_KINEMATIC ((USAGE) 0x0884)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_REAL_TIME_KINEMATIC = ((ushort)(0x0884));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_FLOAT_RTK ((USAGE) 0x0885)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_FLOAT_RTK = ((ushort)(0x0885));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_ESTIMATED_DEAD_RECKONED ((USAGE) 0x0886)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_ESTIMATED_DEAD_RECKONED = ((ushort)(0x0886));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_MANUAL_INPUT_MODE ((USAGE) 0x0887)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_MANUAL_INPUT_MODE = ((ushort)(0x0887));

    [NativeTypeName("#define HID_USAGE_SENSORS_FIX_TYPE_SIMULATOR_MODE ((USAGE) 0x0888)")]
    public const ushort HID_USAGE_SENSORS_FIX_TYPE_SIMULATOR_MODE = ((ushort)(0x0888));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_OPERATION_MODE_MANUAL ((USAGE) 0x0890)")]
    public const ushort HID_USAGE_SENSORS_GPS_OPERATION_MODE_MANUAL = ((ushort)(0x0890));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_OPERATION_MODE_AUTOMATIC ((USAGE) 0x0891)")]
    public const ushort HID_USAGE_SENSORS_GPS_OPERATION_MODE_AUTOMATIC = ((ushort)(0x0891));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_AUTONOMOUS ((USAGE) 0x08A0)")]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_AUTONOMOUS = ((ushort)(0x08A0));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_DGPS ((USAGE) 0x08A1)")]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_DGPS = ((ushort)(0x08A1));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_ESTIMATED_DEAD_RECKONED ((USAGE) 0x08A2)"
    )]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_ESTIMATED_DEAD_RECKONED = (
        (ushort)(0x08A2)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_MANUAL_INPUT ((USAGE) 0x08A3)")]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_MANUAL_INPUT = ((ushort)(0x08A3));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_SIMULATOR ((USAGE) 0x08A4)")]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_SIMULATOR = ((ushort)(0x08A4));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_SELECTION_MODE_DATA_NOT_VALID ((USAGE) 0x08A5)")]
    public const ushort HID_USAGE_SENSORS_GPS_SELECTION_MODE_DATA_NOT_VALID = ((ushort)(0x08A5));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_STATUS_DATA_VALID ((USAGE) 0x08B0)")]
    public const ushort HID_USAGE_SENSORS_GPS_STATUS_DATA_VALID = ((ushort)(0x08B0));

    [NativeTypeName("#define HID_USAGE_SENSORS_GPS_STATUS_DATA_NOT_VALID ((USAGE) 0x08B1)")]
    public const ushort HID_USAGE_SENSORS_GPS_STATUS_DATA_NOT_VALID = ((ushort)(0x08B1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_SUNDAY ((USAGE) 0x08C0)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_SUNDAY = ((ushort)(0x08C0));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_MONDAY ((USAGE) 0x08C1)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_MONDAY = ((ushort)(0x08C1));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_TUESDAY ((USAGE) 0x08C2)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_TUESDAY = ((ushort)(0x08C2));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_WEDNESDAY ((USAGE) 0x08C3)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_WEDNESDAY = ((ushort)(0x08C3));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_THURSDAY ((USAGE) 0x08C4)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_THURSDAY = ((ushort)(0x08C4));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_FRIDAY ((USAGE) 0x08C5)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_FRIDAY = ((ushort)(0x08C5));

    [NativeTypeName("#define HID_USAGE_SENSORS_DAY_OF_WEEK_SATURDAY ((USAGE) 0x08C6)")]
    public const ushort HID_USAGE_SENSORS_DAY_OF_WEEK_SATURDAY = ((ushort)(0x08C6));

    [NativeTypeName("#define HID_USAGE_SENSORS_KIND_CATEGORY ((USAGE) 0x08D0)")]
    public const ushort HID_USAGE_SENSORS_KIND_CATEGORY = ((ushort)(0x08D0));

    [NativeTypeName("#define HID_USAGE_SENSORS_KIND_TYPE ((USAGE) 0x08D1)")]
    public const ushort HID_USAGE_SENSORS_KIND_TYPE = ((ushort)(0x08D1));

    [NativeTypeName("#define HID_USAGE_SENSORS_KIND_EVENT ((USAGE) 0x08D2)")]
    public const ushort HID_USAGE_SENSORS_KIND_EVENT = ((ushort)(0x08D2));

    [NativeTypeName("#define HID_USAGE_SENSORS_KIND_PROPERTY ((USAGE) 0x08D3)")]
    public const ushort HID_USAGE_SENSORS_KIND_PROPERTY = ((ushort)(0x08D3));

    [NativeTypeName("#define HID_USAGE_SENSORS_KIND_DATA_FIELD ((USAGE) 0x08D4)")]
    public const ushort HID_USAGE_SENSORS_KIND_DATA_FIELD = ((ushort)(0x08D4));

    [NativeTypeName("#define HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_LOW ((USAGE) 0x08E0)")]
    public const ushort HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_LOW = ((ushort)(0x08E0));

    [NativeTypeName("#define HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_MEDIUM ((USAGE) 0x08E1)")]
    public const ushort HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_MEDIUM = ((ushort)(0x08E1));

    [NativeTypeName("#define HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_HIGH ((USAGE) 0x08E2)")]
    public const ushort HID_USAGE_SENSORS_MAGNETOMETER_ACCURACY_HIGH = ((ushort)(0x08E2));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_NOT_ROTATED ((USAGE) 0x08F0)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_NOT_ROTATED = (
        (ushort)(0x08F0)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_90_DEGREES_CCW ((USAGE) 0x08F1)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_90_DEGREES_CCW = (
        (ushort)(0x08F1)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_180_DEGREES_CCW ((USAGE) 0x08F2)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_180_DEGREES_CCW = (
        (ushort)(0x08F2)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_270_DEGREES_CCW ((USAGE) 0x08F3)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_ROTATED_270_DEGREES_CCW = (
        (ushort)(0x08F3)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_FACE_UP ((USAGE) 0x08F4)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_FACE_UP = ((ushort)(0x08F4));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_FACE_DOWN ((USAGE) 0x08F5)"
    )]
    public const ushort HID_USAGE_SENSORS_SIMPLE_ORIENTATION_DIRECTION_FACE_DOWN = (
        (ushort)(0x08F5)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_NULL ((USAGE) 0x0900)")]
    public const ushort HID_USAGE_SENSORS_VT_NULL = ((ushort)(0x0900));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_BOOL ((USAGE) 0x0901)")]
    public const ushort HID_USAGE_SENSORS_VT_BOOL = ((ushort)(0x0901));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_UI1 ((USAGE) 0x0902)")]
    public const ushort HID_USAGE_SENSORS_VT_UI1 = ((ushort)(0x0902));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_I1 ((USAGE) 0x0903)")]
    public const ushort HID_USAGE_SENSORS_VT_I1 = ((ushort)(0x0903));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_UI2 ((USAGE) 0x0904)")]
    public const ushort HID_USAGE_SENSORS_VT_UI2 = ((ushort)(0x0904));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_I2 ((USAGE) 0x0905)")]
    public const ushort HID_USAGE_SENSORS_VT_I2 = ((ushort)(0x0905));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_UI4 ((USAGE) 0x0906)")]
    public const ushort HID_USAGE_SENSORS_VT_UI4 = ((ushort)(0x0906));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_I4 ((USAGE) 0x0907)")]
    public const ushort HID_USAGE_SENSORS_VT_I4 = ((ushort)(0x0907));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_UI8 ((USAGE) 0x0908)")]
    public const ushort HID_USAGE_SENSORS_VT_UI8 = ((ushort)(0x0908));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_I8 ((USAGE) 0x0909)")]
    public const ushort HID_USAGE_SENSORS_VT_I8 = ((ushort)(0x0909));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_R4 ((USAGE) 0x090A)")]
    public const ushort HID_USAGE_SENSORS_VT_R4 = ((ushort)(0x090A));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_R8 ((USAGE) 0x090B)")]
    public const ushort HID_USAGE_SENSORS_VT_R8 = ((ushort)(0x090B));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_WSTR ((USAGE) 0x090C)")]
    public const ushort HID_USAGE_SENSORS_VT_WSTR = ((ushort)(0x090C));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_STR ((USAGE) 0x090D)")]
    public const ushort HID_USAGE_SENSORS_VT_STR = ((ushort)(0x090D));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_CLSID ((USAGE) 0x090E)")]
    public const ushort HID_USAGE_SENSORS_VT_CLSID = ((ushort)(0x090E));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_VECTOR_VT_UI1 ((USAGE) 0x090F)")]
    public const ushort HID_USAGE_SENSORS_VT_VECTOR_VT_UI1 = ((ushort)(0x090F));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E0 ((USAGE) 0x0910)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E0 = ((ushort)(0x0910));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E1 ((USAGE) 0x0911)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E1 = ((ushort)(0x0911));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E2 ((USAGE) 0x0912)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E2 = ((ushort)(0x0912));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E3 ((USAGE) 0x0913)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E3 = ((ushort)(0x0913));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E4 ((USAGE) 0x0914)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E4 = ((ushort)(0x0914));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E5 ((USAGE) 0x0915)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E5 = ((ushort)(0x0915));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E6 ((USAGE) 0x0916)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E6 = ((ushort)(0x0916));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E7 ((USAGE) 0x0917)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E7 = ((ushort)(0x0917));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E8 ((USAGE) 0x0918)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E8 = ((ushort)(0x0918));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16E9 ((USAGE) 0x0919)")]
    public const ushort HID_USAGE_SENSORS_VT_F16E9 = ((ushort)(0x0919));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16EA ((USAGE) 0x091A)")]
    public const ushort HID_USAGE_SENSORS_VT_F16EA = ((ushort)(0x091A));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16EB ((USAGE) 0x091B)")]
    public const ushort HID_USAGE_SENSORS_VT_F16EB = ((ushort)(0x091B));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16EC ((USAGE) 0x091C)")]
    public const ushort HID_USAGE_SENSORS_VT_F16EC = ((ushort)(0x091C));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16ED ((USAGE) 0x091D)")]
    public const ushort HID_USAGE_SENSORS_VT_F16ED = ((ushort)(0x091D));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16EE ((USAGE) 0x091E)")]
    public const ushort HID_USAGE_SENSORS_VT_F16EE = ((ushort)(0x091E));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F16EF ((USAGE) 0x091F)")]
    public const ushort HID_USAGE_SENSORS_VT_F16EF = ((ushort)(0x091F));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E0 ((USAGE) 0x0920)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E0 = ((ushort)(0x0920));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E1 ((USAGE) 0x0921)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E1 = ((ushort)(0x0921));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E2 ((USAGE) 0x0922)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E2 = ((ushort)(0x0922));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E3 ((USAGE) 0x0923)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E3 = ((ushort)(0x0923));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E4 ((USAGE) 0x0924)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E4 = ((ushort)(0x0924));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E5 ((USAGE) 0x0925)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E5 = ((ushort)(0x0925));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E6 ((USAGE) 0x0926)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E6 = ((ushort)(0x0926));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E7 ((USAGE) 0x0927)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E7 = ((ushort)(0x0927));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E8 ((USAGE) 0x0928)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E8 = ((ushort)(0x0928));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32E9 ((USAGE) 0x0929)")]
    public const ushort HID_USAGE_SENSORS_VT_F32E9 = ((ushort)(0x0929));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32EA ((USAGE) 0x092A)")]
    public const ushort HID_USAGE_SENSORS_VT_F32EA = ((ushort)(0x092A));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32EB ((USAGE) 0x092B)")]
    public const ushort HID_USAGE_SENSORS_VT_F32EB = ((ushort)(0x092B));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32EC ((USAGE) 0x092C)")]
    public const ushort HID_USAGE_SENSORS_VT_F32EC = ((ushort)(0x092C));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32ED ((USAGE) 0x092D)")]
    public const ushort HID_USAGE_SENSORS_VT_F32ED = ((ushort)(0x092D));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32EE ((USAGE) 0x092E)")]
    public const ushort HID_USAGE_SENSORS_VT_F32EE = ((ushort)(0x092E));

    [NativeTypeName("#define HID_USAGE_SENSORS_VT_F32EF ((USAGE) 0x092F)")]
    public const ushort HID_USAGE_SENSORS_VT_F32EF = ((ushort)(0x092F));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_UNKNOWN ((USAGE) 0x0930)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_UNKNOWN = ((ushort)(0x0930));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_STATIONARY ((USAGE) 0x0931)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_STATIONARY = ((ushort)(0x0931));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_FIDGETING ((USAGE) 0x0932)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_FIDGETING = ((ushort)(0x0932));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_WALKING ((USAGE) 0x0933)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_WALKING = ((ushort)(0x0933));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_RUNNING ((USAGE) 0x0934)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_RUNNING = ((ushort)(0x0934));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_IN_VEHICLE ((USAGE) 0x0935)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_IN_VEHICLE = ((ushort)(0x0935));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_BIKING ((USAGE) 0x0936)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_BIKING = ((ushort)(0x0936));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_TYPE_IDLE ((USAGE) 0x0937)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_TYPE_IDLE = ((ushort)(0x0937));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_NOT_SPECIFIED ((USAGE) 0x0940)")]
    public const ushort HID_USAGE_SENSORS_UNIT_NOT_SPECIFIED = ((ushort)(0x0940));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_LUX ((USAGE) 0x0941)")]
    public const ushort HID_USAGE_SENSORS_UNIT_LUX = ((ushort)(0x0941));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREES_KELVIN ((USAGE) 0x0942)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREES_KELVIN = ((ushort)(0x0942));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREES_CELSIUS ((USAGE) 0x0943)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREES_CELSIUS = ((ushort)(0x0943));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_PASCAL ((USAGE) 0x0944)")]
    public const ushort HID_USAGE_SENSORS_UNIT_PASCAL = ((ushort)(0x0944));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_NEWTON ((USAGE) 0x0945)")]
    public const ushort HID_USAGE_SENSORS_UNIT_NEWTON = ((ushort)(0x0945));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_METERSSECOND ((USAGE) 0x0946)")]
    public const ushort HID_USAGE_SENSORS_UNIT_METERSSECOND = ((ushort)(0x0946));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_KILOGRAM ((USAGE) 0x0947)")]
    public const ushort HID_USAGE_SENSORS_UNIT_KILOGRAM = ((ushort)(0x0947));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_METER ((USAGE) 0x0948)")]
    public const ushort HID_USAGE_SENSORS_UNIT_METER = ((ushort)(0x0948));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_METERSSECONDSECOND ((USAGE) 0x0949)")]
    public const ushort HID_USAGE_SENSORS_UNIT_METERSSECONDSECOND = ((ushort)(0x0949));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_FARAD ((USAGE) 0x094A)")]
    public const ushort HID_USAGE_SENSORS_UNIT_FARAD = ((ushort)(0x094A));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_AMPERE ((USAGE) 0x094B)")]
    public const ushort HID_USAGE_SENSORS_UNIT_AMPERE = ((ushort)(0x094B));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_WATT ((USAGE) 0x094C)")]
    public const ushort HID_USAGE_SENSORS_UNIT_WATT = ((ushort)(0x094C));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_HENRY ((USAGE) 0x094D)")]
    public const ushort HID_USAGE_SENSORS_UNIT_HENRY = ((ushort)(0x094D));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_OHM ((USAGE) 0x094E)")]
    public const ushort HID_USAGE_SENSORS_UNIT_OHM = ((ushort)(0x094E));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_VOLT ((USAGE) 0x094F)")]
    public const ushort HID_USAGE_SENSORS_UNIT_VOLT = ((ushort)(0x094F));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_HERTZ ((USAGE) 0x0950)")]
    public const ushort HID_USAGE_SENSORS_UNIT_HERTZ = ((ushort)(0x0950));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_BAR ((USAGE) 0x0951)")]
    public const ushort HID_USAGE_SENSORS_UNIT_BAR = ((ushort)(0x0951));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREES_ANTICLOCKWISE ((USAGE) 0x0952)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREES_ANTICLOCKWISE = ((ushort)(0x0952));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREES_CLOCKWISE ((USAGE) 0x0953)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREES_CLOCKWISE = ((ushort)(0x0953));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREES ((USAGE) 0x0954)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREES = ((ushort)(0x0954));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREESSECOND ((USAGE) 0x0955)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREESSECOND = ((ushort)(0x0955));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_DEGREESSECONDSECOND ((USAGE) 0x0956)")]
    public const ushort HID_USAGE_SENSORS_UNIT_DEGREESSECONDSECOND = ((ushort)(0x0956));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_KNOT ((USAGE) 0x0957)")]
    public const ushort HID_USAGE_SENSORS_UNIT_KNOT = ((ushort)(0x0957));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_PERCENT ((USAGE) 0x0958)")]
    public const ushort HID_USAGE_SENSORS_UNIT_PERCENT = ((ushort)(0x0958));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_SECOND ((USAGE) 0x0959)")]
    public const ushort HID_USAGE_SENSORS_UNIT_SECOND = ((ushort)(0x0959));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_MILLISECOND ((USAGE) 0x095A)")]
    public const ushort HID_USAGE_SENSORS_UNIT_MILLISECOND = ((ushort)(0x095A));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_G ((USAGE) 0x095B)")]
    public const ushort HID_USAGE_SENSORS_UNIT_G = ((ushort)(0x095B));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_BYTES ((USAGE) 0x095C)")]
    public const ushort HID_USAGE_SENSORS_UNIT_BYTES = ((ushort)(0x095C));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_MILLIGAUSS ((USAGE) 0x095D)")]
    public const ushort HID_USAGE_SENSORS_UNIT_MILLIGAUSS = ((ushort)(0x095D));

    [NativeTypeName("#define HID_USAGE_SENSORS_UNIT_BITS ((USAGE) 0x095E)")]
    public const ushort HID_USAGE_SENSORS_UNIT_BITS = ((ushort)(0x095E));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_STATE_NO_STATE_CHANGE ((USAGE) 0x0960)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_STATE_NO_STATE_CHANGE = ((ushort)(0x0960));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_STATE_START_ACTIVITY ((USAGE) 0x0961)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_STATE_START_ACTIVITY = ((ushort)(0x0961));

    [NativeTypeName("#define HID_USAGE_SENSORS_ACTIVITY_STATE_END_ACTIVITY ((USAGE) 0x0962)")]
    public const ushort HID_USAGE_SENSORS_ACTIVITY_STATE_END_ACTIVITY = ((ushort)(0x0962));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_0 ((USAGE) 0x0970)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_0 = ((ushort)(0x0970));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_1 ((USAGE) 0x0971)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_1 = ((ushort)(0x0971));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_2 ((USAGE) 0x0972)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_2 = ((ushort)(0x0972));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_3 ((USAGE) 0x0973)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_3 = ((ushort)(0x0973));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_4 ((USAGE) 0x0974)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_4 = ((ushort)(0x0974));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_5 ((USAGE) 0x0975)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_5 = ((ushort)(0x0975));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_6 ((USAGE) 0x0976)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_6 = ((ushort)(0x0976));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_7 ((USAGE) 0x0977)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_7 = ((ushort)(0x0977));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_8 ((USAGE) 0x0978)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_8 = ((ushort)(0x0978));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_9 ((USAGE) 0x0979)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_9 = ((ushort)(0x0979));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_A ((USAGE) 0x097A)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_A = ((ushort)(0x097A));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_B ((USAGE) 0x097B)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_B = ((ushort)(0x097B));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_C ((USAGE) 0x097C)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_C = ((ushort)(0x097C));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_D ((USAGE) 0x097D)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_D = ((ushort)(0x097D));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_E ((USAGE) 0x097E)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_E = ((ushort)(0x097E));

    [NativeTypeName("#define HID_USAGE_SENSORS_EXPONENT_F ((USAGE) 0x097F)")]
    public const ushort HID_USAGE_SENSORS_EXPONENT_F = ((ushort)(0x097F));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_UNKNOWN ((USAGE) 0x0980)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_UNKNOWN = ((ushort)(0x0980));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_UNCHANGED ((USAGE) 0x0981)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_UNCHANGED = ((ushort)(0x0981));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_ON_DESK ((USAGE) 0x0982)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_ON_DESK = ((ushort)(0x0982));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_IN_HAND ((USAGE) 0x0983)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_IN_HAND = ((ushort)(0x0983));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_MOVING_IN_BAG ((USAGE) 0x0984)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_MOVING_IN_BAG = ((ushort)(0x0984));

    [NativeTypeName("#define HID_USAGE_SENSORS_DEVICE_POSITION_STATIONARY_IN_BAG ((USAGE) 0x0985)")]
    public const ushort HID_USAGE_SENSORS_DEVICE_POSITION_STATIONARY_IN_BAG = ((ushort)(0x0985));

    [NativeTypeName("#define HID_USAGE_SENSORS_STEP_TYPE_UNKNOWN ((USAGE) 0x0990)")]
    public const ushort HID_USAGE_SENSORS_STEP_TYPE_UNKNOWN = ((ushort)(0x0990));

    [NativeTypeName("#define HID_USAGE_SENSORS_STEP_TYPE_WALKING ((USAGE) 0x0991)")]
    public const ushort HID_USAGE_SENSORS_STEP_TYPE_WALKING = ((ushort)(0x0991));

    [NativeTypeName("#define HID_USAGE_SENSORS_STEP_TYPE_RUNNING ((USAGE) 0x0992)")]
    public const ushort HID_USAGE_SENSORS_STEP_TYPE_RUNNING = ((ushort)(0x0992));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_STATE_UNKNOWN ((USAGE) 0x09A0)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_STATE_UNKNOWN = ((ushort)(0x09A0));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_STATE_STARTED ((USAGE) 0x09A1)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_STATE_STARTED = ((ushort)(0x09A1));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_STATE_COMPLETED ((USAGE) 0x09A2)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_STATE_COMPLETED = ((ushort)(0x09A2));

    [NativeTypeName("#define HID_USAGE_SENSORS_GESTURE_STATE_CANCELLED ((USAGE) 0x09A3)")]
    public const ushort HID_USAGE_SENSORS_GESTURE_STATE_CANCELLED = ((ushort)(0x09A3));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_UNKNOWN ((USAGE) 0x09B0)"
    )]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_UNKNOWN = (
        (ushort)(0x09B0)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_PANEL_1 ((USAGE) 0x09B1)"
    )]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_PANEL_1 = (
        (ushort)(0x09B1)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_PANEL_2 ((USAGE) 0x09B2)"
    )]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_PANEL_2 = (
        (ushort)(0x09B2)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_BOTH ((USAGE) 0x09B3)"
    )]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_CONTRIBUTING_PANEL_BOTH = ((ushort)(0x09B3));

    [NativeTypeName("#define HID_USAGE_SENSORS_HINGE_FOLD_TYPE_UNKNOWN ((USAGE) 0x09B4)")]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_TYPE_UNKNOWN = ((ushort)(0x09B4));

    [NativeTypeName("#define HID_USAGE_SENSORS_HINGE_FOLD_TYPE_INCREASING ((USAGE) 0x09B5)")]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_TYPE_INCREASING = ((ushort)(0x09B5));

    [NativeTypeName("#define HID_USAGE_SENSORS_HINGE_FOLD_TYPE_DECREASING ((USAGE) 0x09B6)")]
    public const ushort HID_USAGE_SENSORS_HINGE_FOLD_TYPE_DECREASING = ((ushort)(0x09B6));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_VENDORDEFINED_NONBIOMETRIC ((USAGE) 0x09C0)"
    )]
    public const ushort HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_VENDORDEFINED_NONBIOMETRIC =
        ((ushort)(0x09C0));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_VENDORDEFINED_BIOMETRIC ((USAGE) 0x09C1)"
    )]
    public const ushort HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_VENDORDEFINED_BIOMETRIC = (
        (ushort)(0x09C1)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_FACIAL_BIOMETRIC ((USAGE) 0x09C2)"
    )]
    public const ushort HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_FACIAL_BIOMETRIC = (
        (ushort)(0x09C2)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_AUDIO_BIOMETRIC ((USAGE) 0x09C3)"
    )]
    public const ushort HID_USAGE_SENSORS_HUMAN_PRESENCE_DETECTION_TYPE_AUDIO_BIOMETRIC = (
        (ushort)(0x09C3)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_ABSOLUTE ((USAGE) 0x1000)"
    )]
    public const ushort HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_ABSOLUTE = ((ushort)(0x1000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_MAXIMUM ((USAGE) 0x2000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_MAXIMUM = ((ushort)(0x2000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_MINIMUM ((USAGE) 0x3000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_MINIMUM = ((ushort)(0x3000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_ACCURACY ((USAGE) 0x4000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_ACCURACY = ((ushort)(0x4000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_RESOLUTION ((USAGE) 0x5000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_RESOLUTION = ((ushort)(0x5000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_THRESHOLD_HIGH ((USAGE) 0x6000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_THRESHOLD_HIGH = ((ushort)(0x6000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_THRESHOLD_LOW ((USAGE) 0x7000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_THRESHOLD_LOW = ((ushort)(0x7000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_CALIBRATION_OFFSET ((USAGE) 0x8000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_CALIBRATION_OFFSET = ((ushort)(0x8000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_CALIBRATION_MULTIPLIER ((USAGE) 0x9000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_CALIBRATION_MULTIPLIER = ((ushort)(0x9000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_REPORT_INTERVAL ((USAGE) 0xA000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_REPORT_INTERVAL = ((ushort)(0xA000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_FREQUENCY_MAX ((USAGE) 0xB000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_FREQUENCY_MAX = ((ushort)(0xB000));

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_PERIOD_MAX ((USAGE) 0xC000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_PERIOD_MAX = ((ushort)(0xC000));

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_PERCENT_OF_RANGE ((USAGE) 0xD000)"
    )]
    public const ushort HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_PERCENT_OF_RANGE = (
        (ushort)(0xD000)
    );

    [NativeTypeName(
        "#define HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_PERCENT_RELATIVE ((USAGE) 0xE000)"
    )]
    public const ushort HID_USAGE_SENSORS_MODIFIER_CHANGE_SENSITIVITY_PERCENT_RELATIVE = (
        (ushort)(0xE000)
    );

    [NativeTypeName("#define HID_USAGE_SENSORS_MODIFIER_VENDOR_RESERVED ((USAGE) 0xF000)")]
    public const ushort HID_USAGE_SENSORS_MODIFIER_VENDOR_RESERVED = ((ushort)(0xF000));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE ((USAGE) 0x000B)")]
    public const ushort HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE = ((ushort)(0x000B));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE ((USAGE) 0x000C)")]
    public const ushort HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE = ((ushort)(0x000C));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_STICK ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_STICK = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CYCLIC_CONTROL ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_SIMULATION_CYCLIC_CONTROL = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CYCLIC_TRIM ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_SIMULATION_CYCLIC_TRIM = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_YOKE ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_YOKE = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TRACK_CONTROL ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_SIMULATION_TRACK_CONTROL = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AILERON ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_SIMULATION_AILERON = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AILERON_TRIM ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_SIMULATION_AILERON_TRIM = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CHAFF_RELEASE ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_SIMULATION_CHAFF_RELEASE = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_SIMULATION_COLLECTIVE_CONTROL ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_SIMULATION_COLLECTIVE_CONTROL = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_SIMULATION_DIVE_BRAKE ((USAGE) 0x00B6)")]
    public const ushort HID_USAGE_SIMULATION_DIVE_BRAKE = ((ushort)(0x00B6));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELEVATOR ((USAGE) 0x00B8)")]
    public const ushort HID_USAGE_SIMULATION_ELEVATOR = ((ushort)(0x00B8));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ELEVATOR_TRIM ((USAGE) 0x00B9)")]
    public const ushort HID_USAGE_SIMULATION_ELEVATOR_TRIM = ((ushort)(0x00B9));

    [NativeTypeName("#define HID_USAGE_SIMULATION_RUDDER ((USAGE) 0x00BA)")]
    public const ushort HID_USAGE_SIMULATION_RUDDER = ((ushort)(0x00BA));

    [NativeTypeName("#define HID_USAGE_SIMULATION_THROTTLE ((USAGE) 0x00BB)")]
    public const ushort HID_USAGE_SIMULATION_THROTTLE = ((ushort)(0x00BB));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS ((USAGE) 0x00BC)")]
    public const ushort HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS = ((ushort)(0x00BC));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FLARE_RELEASE ((USAGE) 0x00BD)")]
    public const ushort HID_USAGE_SIMULATION_FLARE_RELEASE = ((ushort)(0x00BD));

    [NativeTypeName("#define HID_USAGE_SIMULATION_LANDING_GEAR ((USAGE) 0x00BE)")]
    public const ushort HID_USAGE_SIMULATION_LANDING_GEAR = ((ushort)(0x00BE));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TOE_BRAKE ((USAGE) 0x00BF)")]
    public const ushort HID_USAGE_SIMULATION_TOE_BRAKE = ((ushort)(0x00BF));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TRIGGER ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_SIMULATION_TRIGGER = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WEAPONS_ARM ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_SIMULATION_WEAPONS_ARM = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WEAPONS_SELECT ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_SIMULATION_WEAPONS_SELECT = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_SIMULATION_WING_FLAPS ((USAGE) 0x00C3)")]
    public const ushort HID_USAGE_SIMULATION_WING_FLAPS = ((ushort)(0x00C3));

    [NativeTypeName("#define HID_USAGE_SIMULATION_ACCELERATOR ((USAGE) 0x00C4)")]
    public const ushort HID_USAGE_SIMULATION_ACCELERATOR = ((ushort)(0x00C4));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BRAKE ((USAGE) 0x00C5)")]
    public const ushort HID_USAGE_SIMULATION_BRAKE = ((ushort)(0x00C5));

    [NativeTypeName("#define HID_USAGE_SIMULATION_CLUTCH ((USAGE) 0x00C6)")]
    public const ushort HID_USAGE_SIMULATION_CLUTCH = ((ushort)(0x00C6));

    [NativeTypeName("#define HID_USAGE_SIMULATION_SHIFTER ((USAGE) 0x00C7)")]
    public const ushort HID_USAGE_SIMULATION_SHIFTER = ((ushort)(0x00C7));

    [NativeTypeName("#define HID_USAGE_SIMULATION_STEERING ((USAGE) 0x00C8)")]
    public const ushort HID_USAGE_SIMULATION_STEERING = ((ushort)(0x00C8));

    [NativeTypeName("#define HID_USAGE_SIMULATION_TURRET_DIRECTION ((USAGE) 0x00C9)")]
    public const ushort HID_USAGE_SIMULATION_TURRET_DIRECTION = ((ushort)(0x00C9));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BARREL_ELEVATION ((USAGE) 0x00CA)")]
    public const ushort HID_USAGE_SIMULATION_BARREL_ELEVATION = ((ushort)(0x00CA));

    [NativeTypeName("#define HID_USAGE_SIMULATION_DIVE_PLANE ((USAGE) 0x00CB)")]
    public const ushort HID_USAGE_SIMULATION_DIVE_PLANE = ((ushort)(0x00CB));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BALLAST ((USAGE) 0x00CC)")]
    public const ushort HID_USAGE_SIMULATION_BALLAST = ((ushort)(0x00CC));

    [NativeTypeName("#define HID_USAGE_SIMULATION_BICYCLE_CRANK ((USAGE) 0x00CD)")]
    public const ushort HID_USAGE_SIMULATION_BICYCLE_CRANK = ((ushort)(0x00CD));

    [NativeTypeName("#define HID_USAGE_SIMULATION_HANDLE_BARS ((USAGE) 0x00CE)")]
    public const ushort HID_USAGE_SIMULATION_HANDLE_BARS = ((ushort)(0x00CE));

    [NativeTypeName("#define HID_USAGE_SIMULATION_FRONT_BRAKE ((USAGE) 0x00CF)")]
    public const ushort HID_USAGE_SIMULATION_FRONT_BRAKE = ((ushort)(0x00CF));

    [NativeTypeName("#define HID_USAGE_SIMULATION_REAR_BRAKE ((USAGE) 0x00D0)")]
    public const ushort HID_USAGE_SIMULATION_REAR_BRAKE = ((ushort)(0x00D0));

    [NativeTypeName("#define HID_USAGE_SOC_SOC_CONTROL ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_SOC_SOC_CONTROL = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_SOC_FIRMWARE_TRANSFER ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_SOC_FIRMWARE_TRANSFER = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_SOC_FIRMWARE_FILE_ID ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_SOC_FIRMWARE_FILE_ID = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_OFFSET_IN_BYTES ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_SOC_FILE_OFFSET_IN_BYTES = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_TRANSFER_SIZE_MAX_IN_BYTES ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_SOC_FILE_TRANSFER_SIZE_MAX_IN_BYTES = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_PAYLOAD ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_SOC_FILE_PAYLOAD = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_PAYLOAD_SIZE_IN_BYTES ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_SOC_FILE_PAYLOAD_SIZE_IN_BYTES = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_PAYLOAD_CONTAINS_LAST_BYTES ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_SOC_FILE_PAYLOAD_CONTAINS_LAST_BYTES = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_TRANSFER_STOP ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_SOC_FILE_TRANSFER_STOP = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_SOC_FILE_TRANSFER_TILL_END ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_SOC_FILE_TRANSFER_TILL_END = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_SPORT_BASEBALL_BAT ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_SPORT_BASEBALL_BAT = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_SPORT_GOLF_CLUB ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_SPORT_GOLF_CLUB = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_SPORT_ROWING_MACHINE ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_SPORT_ROWING_MACHINE = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_SPORT_TREADMILL ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_SPORT_TREADMILL = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_SPORT_OAR ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_SPORT_OAR = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_SPORT_SLOPE ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_SPORT_SLOPE = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_SPORT_RATE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_SPORT_RATE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_SPEED ((USAGE) 0x0033)")]
    public const ushort HID_USAGE_SPORT_STICK_SPEED = ((ushort)(0x0033));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_FACE_ANGLE ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_SPORT_STICK_FACE_ANGLE = ((ushort)(0x0034));

    [NativeTypeName("#define HID_USAGE_SPORT_HEEL_TOE ((USAGE) 0x0035)")]
    public const ushort HID_USAGE_SPORT_HEEL_TOE = ((ushort)(0x0035));

    [NativeTypeName("#define HID_USAGE_SPORT_FOLLOW_THROUGH ((USAGE) 0x0036)")]
    public const ushort HID_USAGE_SPORT_FOLLOW_THROUGH = ((ushort)(0x0036));

    [NativeTypeName("#define HID_USAGE_SPORT_TEMPO ((USAGE) 0x0037)")]
    public const ushort HID_USAGE_SPORT_TEMPO = ((ushort)(0x0037));

    [NativeTypeName("#define HID_USAGE_SPORT_STICK_TYPE ((USAGE) 0x0038)")]
    public const ushort HID_USAGE_SPORT_STICK_TYPE = ((ushort)(0x0038));

    [NativeTypeName("#define HID_USAGE_SPORT_HEIGHT ((USAGE) 0x0039)")]
    public const ushort HID_USAGE_SPORT_HEIGHT = ((ushort)(0x0039));

    [NativeTypeName("#define HID_USAGE_SPORT_PUTTER ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_SPORT_PUTTER = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_SPORT_1_IRON ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_SPORT_1_IRON = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_SPORT_2_IRON ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_SPORT_2_IRON = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_SPORT_3_IRON ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_SPORT_3_IRON = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_SPORT_4_IRON ((USAGE) 0x0054)")]
    public const ushort HID_USAGE_SPORT_4_IRON = ((ushort)(0x0054));

    [NativeTypeName("#define HID_USAGE_SPORT_5_IRON ((USAGE) 0x0055)")]
    public const ushort HID_USAGE_SPORT_5_IRON = ((ushort)(0x0055));

    [NativeTypeName("#define HID_USAGE_SPORT_6_IRON ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_SPORT_6_IRON = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_SPORT_7_IRON ((USAGE) 0x0057)")]
    public const ushort HID_USAGE_SPORT_7_IRON = ((ushort)(0x0057));

    [NativeTypeName("#define HID_USAGE_SPORT_8_IRON ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_SPORT_8_IRON = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_SPORT_9_IRON ((USAGE) 0x0059)")]
    public const ushort HID_USAGE_SPORT_9_IRON = ((ushort)(0x0059));

    [NativeTypeName("#define HID_USAGE_SPORT_10_IRON ((USAGE) 0x005A)")]
    public const ushort HID_USAGE_SPORT_10_IRON = ((ushort)(0x005A));

    [NativeTypeName("#define HID_USAGE_SPORT_11_IRON ((USAGE) 0x005B)")]
    public const ushort HID_USAGE_SPORT_11_IRON = ((ushort)(0x005B));

    [NativeTypeName("#define HID_USAGE_SPORT_SAND_WEDGE ((USAGE) 0x005C)")]
    public const ushort HID_USAGE_SPORT_SAND_WEDGE = ((ushort)(0x005C));

    [NativeTypeName("#define HID_USAGE_SPORT_LOFT_WEDGE ((USAGE) 0x005D)")]
    public const ushort HID_USAGE_SPORT_LOFT_WEDGE = ((ushort)(0x005D));

    [NativeTypeName("#define HID_USAGE_SPORT_POWER_WEDGE ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_SPORT_POWER_WEDGE = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_SPORT_1_WOOD ((USAGE) 0x005F)")]
    public const ushort HID_USAGE_SPORT_1_WOOD = ((ushort)(0x005F));

    [NativeTypeName("#define HID_USAGE_SPORT_3_WOOD ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_SPORT_3_WOOD = ((ushort)(0x0060));

    [NativeTypeName("#define HID_USAGE_SPORT_5_WOOD ((USAGE) 0x0061)")]
    public const ushort HID_USAGE_SPORT_5_WOOD = ((ushort)(0x0061));

    [NativeTypeName("#define HID_USAGE_SPORT_7_WOOD ((USAGE) 0x0062)")]
    public const ushort HID_USAGE_SPORT_7_WOOD = ((ushort)(0x0062));

    [NativeTypeName("#define HID_USAGE_SPORT_9_WOOD ((USAGE) 0x0063)")]
    public const ushort HID_USAGE_SPORT_9_WOOD = ((ushort)(0x0063));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ANSWERING_MACHINE ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_TELEPHONY_ANSWERING_MACHINE = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_MESSAGE_CONTROLS ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_TELEPHONY_MESSAGE_CONTROLS = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HANDSET ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_TELEPHONY_HANDSET = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HEADSET ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_TELEPHONY_HEADSET = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_KEYPAD ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_TELEPHONY_KEYPAD = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOOK_SWITCH ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_TELEPHONY_HOOK_SWITCH = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_FLASH ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_TELEPHONY_FLASH = ((ushort)(0x0021));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_FEATURE ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_TELEPHONY_FEATURE = ((ushort)(0x0022));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOLD ((USAGE) 0x0023)")]
    public const ushort HID_USAGE_TELEPHONY_HOLD = ((ushort)(0x0023));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_REDIAL ((USAGE) 0x0024)")]
    public const ushort HID_USAGE_TELEPHONY_REDIAL = ((ushort)(0x0024));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_TRANSFER ((USAGE) 0x0025)")]
    public const ushort HID_USAGE_TELEPHONY_TRANSFER = ((ushort)(0x0025));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_DROP ((USAGE) 0x0026)")]
    public const ushort HID_USAGE_TELEPHONY_DROP = ((ushort)(0x0026));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PARK ((USAGE) 0x0027)")]
    public const ushort HID_USAGE_TELEPHONY_PARK = ((ushort)(0x0027));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_FORWARD_CALLS ((USAGE) 0x0028)")]
    public const ushort HID_USAGE_TELEPHONY_FORWARD_CALLS = ((ushort)(0x0028));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ALTERNATE_FUNCTION ((USAGE) 0x0029)")]
    public const ushort HID_USAGE_TELEPHONY_ALTERNATE_FUNCTION = ((ushort)(0x0029));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_LINE ((USAGE) 0x002A)")]
    public const ushort HID_USAGE_TELEPHONY_LINE = ((ushort)(0x002A));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SPEAKER_PHONE ((USAGE) 0x002B)")]
    public const ushort HID_USAGE_TELEPHONY_SPEAKER_PHONE = ((ushort)(0x002B));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CONFERENCE ((USAGE) 0x002C)")]
    public const ushort HID_USAGE_TELEPHONY_CONFERENCE = ((ushort)(0x002C));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RING_ENABLE ((USAGE) 0x002D)")]
    public const ushort HID_USAGE_TELEPHONY_RING_ENABLE = ((ushort)(0x002D));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RING_SELECT ((USAGE) 0x002E)")]
    public const ushort HID_USAGE_TELEPHONY_RING_SELECT = ((ushort)(0x002E));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_MUTE ((USAGE) 0x002F)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_MUTE = ((ushort)(0x002F));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CALLER_ID ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_TELEPHONY_CALLER_ID = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SEND ((USAGE) 0x0031)")]
    public const ushort HID_USAGE_TELEPHONY_SEND = ((ushort)(0x0031));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SPEED_DIAL ((USAGE) 0x0050)")]
    public const ushort HID_USAGE_TELEPHONY_SPEED_DIAL = ((ushort)(0x0050));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_STORE_NUMBER ((USAGE) 0x0051)")]
    public const ushort HID_USAGE_TELEPHONY_STORE_NUMBER = ((ushort)(0x0051));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RECALL_NUMBER ((USAGE) 0x0052)")]
    public const ushort HID_USAGE_TELEPHONY_RECALL_NUMBER = ((ushort)(0x0052));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_DIRECTORY ((USAGE) 0x0053)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_DIRECTORY = ((ushort)(0x0053));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_VOICE_MAIL ((USAGE) 0x0070)")]
    public const ushort HID_USAGE_TELEPHONY_VOICE_MAIL = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SCREEN_CALLS ((USAGE) 0x0071)")]
    public const ushort HID_USAGE_TELEPHONY_SCREEN_CALLS = ((ushort)(0x0071));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_DO_NOT_DISTURB ((USAGE) 0x0072)")]
    public const ushort HID_USAGE_TELEPHONY_DO_NOT_DISTURB = ((ushort)(0x0072));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_MESSAGE ((USAGE) 0x0073)")]
    public const ushort HID_USAGE_TELEPHONY_MESSAGE = ((ushort)(0x0073));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ANSWER_ONOFF ((USAGE) 0x0074)")]
    public const ushort HID_USAGE_TELEPHONY_ANSWER_ONOFF = ((ushort)(0x0074));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_INSIDE_DIAL_TONE ((USAGE) 0x0090)")]
    public const ushort HID_USAGE_TELEPHONY_INSIDE_DIAL_TONE = ((ushort)(0x0090));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_OUTSIDE_DIAL_TONE ((USAGE) 0x0091)")]
    public const ushort HID_USAGE_TELEPHONY_OUTSIDE_DIAL_TONE = ((ushort)(0x0091));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_INSIDE_RING_TONE ((USAGE) 0x0092)")]
    public const ushort HID_USAGE_TELEPHONY_INSIDE_RING_TONE = ((ushort)(0x0092));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_OUTSIDE_RING_TONE ((USAGE) 0x0093)")]
    public const ushort HID_USAGE_TELEPHONY_OUTSIDE_RING_TONE = ((ushort)(0x0093));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PRIORITY_RING_TONE ((USAGE) 0x0094)")]
    public const ushort HID_USAGE_TELEPHONY_PRIORITY_RING_TONE = ((ushort)(0x0094));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_INSIDE_RINGBACK ((USAGE) 0x0095)")]
    public const ushort HID_USAGE_TELEPHONY_INSIDE_RINGBACK = ((ushort)(0x0095));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PRIORITY_RINGBACK ((USAGE) 0x0096)")]
    public const ushort HID_USAGE_TELEPHONY_PRIORITY_RINGBACK = ((ushort)(0x0096));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_LINE_BUSY_TONE ((USAGE) 0x0097)")]
    public const ushort HID_USAGE_TELEPHONY_LINE_BUSY_TONE = ((ushort)(0x0097));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_REORDER_TONE ((USAGE) 0x0098)")]
    public const ushort HID_USAGE_TELEPHONY_REORDER_TONE = ((ushort)(0x0098));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CALL_WAITING_TONE ((USAGE) 0x0099)")]
    public const ushort HID_USAGE_TELEPHONY_CALL_WAITING_TONE = ((ushort)(0x0099));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CONFIRMATION_TONE_1 ((USAGE) 0x009A)")]
    public const ushort HID_USAGE_TELEPHONY_CONFIRMATION_TONE_1 = ((ushort)(0x009A));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CONFIRMATION_TONE_2 ((USAGE) 0x009B)")]
    public const ushort HID_USAGE_TELEPHONY_CONFIRMATION_TONE_2 = ((ushort)(0x009B));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_TONES_OFF ((USAGE) 0x009C)")]
    public const ushort HID_USAGE_TELEPHONY_TONES_OFF = ((ushort)(0x009C));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_OUTSIDE_RINGBACK ((USAGE) 0x009D)")]
    public const ushort HID_USAGE_TELEPHONY_OUTSIDE_RINGBACK = ((ushort)(0x009D));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RINGER ((USAGE) 0x009E)")]
    public const ushort HID_USAGE_TELEPHONY_RINGER = ((ushort)(0x009E));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_0 ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_0 = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_1 ((USAGE) 0x00B1)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_1 = ((ushort)(0x00B1));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_2 ((USAGE) 0x00B2)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_2 = ((ushort)(0x00B2));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_3 ((USAGE) 0x00B3)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_3 = ((ushort)(0x00B3));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_4 ((USAGE) 0x00B4)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_4 = ((ushort)(0x00B4));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_5 ((USAGE) 0x00B5)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_5 = ((ushort)(0x00B5));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_6 ((USAGE) 0x00B6)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_6 = ((ushort)(0x00B6));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_7 ((USAGE) 0x00B7)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_7 = ((ushort)(0x00B7));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_8 ((USAGE) 0x00B8)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_8 = ((ushort)(0x00B8));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_9 ((USAGE) 0x00B9)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_9 = ((ushort)(0x00B9));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_STAR ((USAGE) 0x00BA)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_STAR = ((ushort)(0x00BA));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_POUND ((USAGE) 0x00BB)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_POUND = ((ushort)(0x00BB));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_A ((USAGE) 0x00BC)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_A = ((ushort)(0x00BC));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_B ((USAGE) 0x00BD)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_B = ((ushort)(0x00BD));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_C ((USAGE) 0x00BE)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_C = ((ushort)(0x00BE));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_KEY_D ((USAGE) 0x00BF)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_KEY_D = ((ushort)(0x00BF));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_CALL_HISTORY_KEY ((USAGE) 0x00C0)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_CALL_HISTORY_KEY = ((ushort)(0x00C0));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_CALLER_ID_KEY ((USAGE) 0x00C1)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_CALLER_ID_KEY = ((ushort)(0x00C1));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_SETTINGS_KEY ((USAGE) 0x00C2)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_SETTINGS_KEY = ((ushort)(0x00C2));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_CONTROL ((USAGE) 0x00F0)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_CONTROL = ((ushort)(0x00F0));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_AVAILABLE ((USAGE) 0x00F1)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_AVAILABLE = ((ushort)(0x00F1));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_CALL_ACTIVE ((USAGE) 0x00F2)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_CALL_ACTIVE = ((ushort)(0x00F2));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ACTIVATE_HANDSET_AUDIO ((USAGE) 0x00F3)")]
    public const ushort HID_USAGE_TELEPHONY_ACTIVATE_HANDSET_AUDIO = ((ushort)(0x00F3));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_RING_TYPE ((USAGE) 0x00F4)")]
    public const ushort HID_USAGE_TELEPHONY_RING_TYPE = ((ushort)(0x00F4));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_REDIALABLE_PHONE_NUMBER ((USAGE) 0x00F5)")]
    public const ushort HID_USAGE_TELEPHONY_REDIALABLE_PHONE_NUMBER = ((ushort)(0x00F5));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_STOP_RING_TONE ((USAGE) 0x00F8)")]
    public const ushort HID_USAGE_TELEPHONY_STOP_RING_TONE = ((ushort)(0x00F8));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PSTN_RING_TONE ((USAGE) 0x00F9)")]
    public const ushort HID_USAGE_TELEPHONY_PSTN_RING_TONE = ((ushort)(0x00F9));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_RING_TONE ((USAGE) 0x00FA)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_RING_TONE = ((ushort)(0x00FA));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ALERT_SOUND_ERROR ((USAGE) 0x00FB)")]
    public const ushort HID_USAGE_TELEPHONY_ALERT_SOUND_ERROR = ((ushort)(0x00FB));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ALERT_SOUND_CONFIRM ((USAGE) 0x00FC)")]
    public const ushort HID_USAGE_TELEPHONY_ALERT_SOUND_CONFIRM = ((ushort)(0x00FC));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ALERT_SOUND_NOTIFICATION ((USAGE) 0x00FD)")]
    public const ushort HID_USAGE_TELEPHONY_ALERT_SOUND_NOTIFICATION = ((ushort)(0x00FD));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_SILENT_RING ((USAGE) 0x00FE)")]
    public const ushort HID_USAGE_TELEPHONY_SILENT_RING = ((ushort)(0x00FE));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_EMAIL_MESSAGE_WAITING ((USAGE) 0x0108)")]
    public const ushort HID_USAGE_TELEPHONY_EMAIL_MESSAGE_WAITING = ((ushort)(0x0108));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_VOICEMAIL_MESSAGE_WAITING ((USAGE) 0x0109)")]
    public const ushort HID_USAGE_TELEPHONY_VOICEMAIL_MESSAGE_WAITING = ((ushort)(0x0109));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HOST_HOLD ((USAGE) 0x010A)")]
    public const ushort HID_USAGE_TELEPHONY_HOST_HOLD = ((ushort)(0x010A));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_INCOMING_CALL_HISTORY_COUNT ((USAGE) 0x0110)")]
    public const ushort HID_USAGE_TELEPHONY_INCOMING_CALL_HISTORY_COUNT = ((ushort)(0x0110));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_OUTGOING_CALL_HISTORY_COUNT ((USAGE) 0x0111)")]
    public const ushort HID_USAGE_TELEPHONY_OUTGOING_CALL_HISTORY_COUNT = ((ushort)(0x0111));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_INCOMING_CALL_HISTORY ((USAGE) 0x0112)")]
    public const ushort HID_USAGE_TELEPHONY_INCOMING_CALL_HISTORY = ((ushort)(0x0112));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_OUTGOING_CALL_HISTORY ((USAGE) 0x0113)")]
    public const ushort HID_USAGE_TELEPHONY_OUTGOING_CALL_HISTORY = ((ushort)(0x0113));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_LOCALE ((USAGE) 0x0114)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_LOCALE = ((ushort)(0x0114));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_TIME_SECOND ((USAGE) 0x0140)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_TIME_SECOND = ((ushort)(0x0140));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_TIME_MINUTE ((USAGE) 0x0141)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_TIME_MINUTE = ((ushort)(0x0141));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_TIME_HOUR ((USAGE) 0x0142)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_TIME_HOUR = ((ushort)(0x0142));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_DATE_DAY ((USAGE) 0x0143)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_DATE_DAY = ((ushort)(0x0143));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_DATE_MONTH ((USAGE) 0x0144)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_DATE_MONTH = ((ushort)(0x0144));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_PHONE_DATE_YEAR ((USAGE) 0x0145)")]
    public const ushort HID_USAGE_TELEPHONY_PHONE_DATE_YEAR = ((ushort)(0x0145));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_HANDSET_NICKNAME ((USAGE) 0x0146)")]
    public const ushort HID_USAGE_TELEPHONY_HANDSET_NICKNAME = ((ushort)(0x0146));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_ADDRESS_BOOK_ID ((USAGE) 0x0147)")]
    public const ushort HID_USAGE_TELEPHONY_ADDRESS_BOOK_ID = ((ushort)(0x0147));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_CALL_DURATION ((USAGE) 0x014A)")]
    public const ushort HID_USAGE_TELEPHONY_CALL_DURATION = ((ushort)(0x014A));

    [NativeTypeName("#define HID_USAGE_TELEPHONY_DUAL_MODE_PHONE ((USAGE) 0x014B)")]
    public const ushort HID_USAGE_TELEPHONY_DUAL_MODE_PHONE = ((ushort)(0x014B));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_DEGAUSS ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_DEGAUSS = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_BRIGHTNESS ((USAGE) 0x0010)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_BRIGHTNESS = ((ushort)(0x0010));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_CONTRAST ((USAGE) 0x0012)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_CONTRAST = ((ushort)(0x0012));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_RED_VIDEO_GAIN ((USAGE) 0x0016)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_RED_VIDEO_GAIN = ((ushort)(0x0016));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_GREEN_VIDEO_GAIN ((USAGE) 0x0018)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_GREEN_VIDEO_GAIN = ((ushort)(0x0018));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_BLUE_VIDEO_GAIN ((USAGE) 0x001A)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_BLUE_VIDEO_GAIN = ((ushort)(0x001A));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_FOCUS ((USAGE) 0x001C)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_FOCUS = ((ushort)(0x001C));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_POSITION ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_POSITION = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_SIZE ((USAGE) 0x0022)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_SIZE = ((ushort)(0x0022));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_PINCUSHION ((USAGE) 0x0024)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_PINCUSHION = ((ushort)(0x0024));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_PINCUSHION_BALANCE ((USAGE) 0x0026)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_PINCUSHION_BALANCE = (
        (ushort)(0x0026)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_MISCONVERGENCE ((USAGE) 0x0028)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_MISCONVERGENCE = (
        (ushort)(0x0028)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_LINEARITY ((USAGE) 0x002A)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_LINEARITY = ((ushort)(0x002A));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_LINEARITY_BALANCE ((USAGE) 0x002C)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_LINEARITY_BALANCE = (
        (ushort)(0x002C)
    );

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_POSITION ((USAGE) 0x0030)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_POSITION = ((ushort)(0x0030));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_SIZE ((USAGE) 0x0032)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_SIZE = ((ushort)(0x0032));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_PINCUSHION ((USAGE) 0x0034)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_PINCUSHION = ((ushort)(0x0034));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_PINCUSHION_BALANCE ((USAGE) 0x0036)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_PINCUSHION_BALANCE = (
        (ushort)(0x0036)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_MISCONVERGENCE ((USAGE) 0x0038)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_MISCONVERGENCE = (
        (ushort)(0x0038)
    );

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_LINEARITY ((USAGE) 0x003A)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_LINEARITY = ((ushort)(0x003A));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_LINEARITY_BALANCE ((USAGE) 0x003C)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_LINEARITY_BALANCE = (
        (ushort)(0x003C)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_PARALLELOGRAM_DISTORTION_KEY_BALANCE ((USAGE) 0x0040)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_PARALLELOGRAM_DISTORTION_KEY_BALANCE = (
        (ushort)(0x0040)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_TRAPEZOIDAL_DISTORTION_KEY ((USAGE) 0x0042)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_TRAPEZOIDAL_DISTORTION_KEY = (
        (ushort)(0x0042)
    );

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_TILT_ROTATION ((USAGE) 0x0044)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_TILT_ROTATION = ((ushort)(0x0044));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_TOP_CORNER_DISTORTION_CONTROL ((USAGE) 0x0046)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_TOP_CORNER_DISTORTION_CONTROL = (
        (ushort)(0x0046)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_TOP_CORNER_DISTORTION_BALANCE ((USAGE) 0x0048)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_TOP_CORNER_DISTORTION_BALANCE = (
        (ushort)(0x0048)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_BOTTOM_CORNER_DISTORTION_CONTROL ((USAGE) 0x004A)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_BOTTOM_CORNER_DISTORTION_CONTROL = (
        (ushort)(0x004A)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_BOTTOM_CORNER_DISTORTION_BALANCE ((USAGE) 0x004C)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_BOTTOM_CORNER_DISTORTION_BALANCE = (
        (ushort)(0x004C)
    );

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_MOIRE ((USAGE) 0x0056)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_MOIRE = ((ushort)(0x0056));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_MOIRE ((USAGE) 0x0058)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_MOIRE = ((ushort)(0x0058));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_INPUT_LEVEL_SELECT ((USAGE) 0x005E)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_INPUT_LEVEL_SELECT = ((ushort)(0x005E));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_INPUT_SOURCE_SELECT ((USAGE) 0x0060)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_INPUT_SOURCE_SELECT = ((ushort)(0x0060));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_RED_VIDEO_BLACK_LEVEL ((USAGE) 0x006C)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_RED_VIDEO_BLACK_LEVEL = ((ushort)(0x006C));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_GREEN_VIDEO_BLACK_LEVEL ((USAGE) 0x006E)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_GREEN_VIDEO_BLACK_LEVEL = (
        (ushort)(0x006E)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_BLUE_VIDEO_BLACK_LEVEL ((USAGE) 0x0070)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_BLUE_VIDEO_BLACK_LEVEL = ((ushort)(0x0070));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_AUTO_SIZE_CENTER ((USAGE) 0x00A2)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_AUTO_SIZE_CENTER = ((ushort)(0x00A2));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_POLARITY_HORIZONTAL_SYNCHRONIZATION ((USAGE) 0x00A4)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_POLARITY_HORIZONTAL_SYNCHRONIZATION = (
        (ushort)(0x00A4)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_POLARITY_VERTICAL_SYNCHRONIZATION ((USAGE) 0x00A6)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_POLARITY_VERTICAL_SYNCHRONIZATION = (
        (ushort)(0x00A6)
    );

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_SYNCHRONIZATION_TYPE ((USAGE) 0x00A8)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_SYNCHRONIZATION_TYPE = ((ushort)(0x00A8));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_SCREEN_ORIENTATION ((USAGE) 0x00AA)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_SCREEN_ORIENTATION = ((ushort)(0x00AA));

    [NativeTypeName(
        "#define HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_FREQUENCY ((USAGE) 0x00AC)"
    )]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_HORIZONTAL_FREQUENCY = ((ushort)(0x00AC));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_FREQUENCY ((USAGE) 0x00AE)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_VERTICAL_FREQUENCY = ((ushort)(0x00AE));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_SETTINGS ((USAGE) 0x00B0)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_SETTINGS = ((ushort)(0x00B0));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_ON_SCREEN_DISPLAY ((USAGE) 0x00CA)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_ON_SCREEN_DISPLAY = ((ushort)(0x00CA));

    [NativeTypeName("#define HID_USAGE_VESA_VIRTUAL_CONTROLS_STEREO_MODE ((USAGE) 0x00D4)")]
    public const ushort HID_USAGE_VESA_VIRTUAL_CONTROLS_STEREO_MODE = ((ushort)(0x00D4));

    [NativeTypeName("#define HID_USAGE_VR_BELT ((USAGE) 0x0001)")]
    public const ushort HID_USAGE_VR_BELT = ((ushort)(0x0001));

    [NativeTypeName("#define HID_USAGE_VR_BODY_SUIT ((USAGE) 0x0002)")]
    public const ushort HID_USAGE_VR_BODY_SUIT = ((ushort)(0x0002));

    [NativeTypeName("#define HID_USAGE_VR_FLEXOR ((USAGE) 0x0003)")]
    public const ushort HID_USAGE_VR_FLEXOR = ((ushort)(0x0003));

    [NativeTypeName("#define HID_USAGE_VR_GLOVE ((USAGE) 0x0004)")]
    public const ushort HID_USAGE_VR_GLOVE = ((ushort)(0x0004));

    [NativeTypeName("#define HID_USAGE_VR_HEAD_TRACKER ((USAGE) 0x0005)")]
    public const ushort HID_USAGE_VR_HEAD_TRACKER = ((ushort)(0x0005));

    [NativeTypeName("#define HID_USAGE_VR_HEAD_MOUNTED_DISPLAY ((USAGE) 0x0006)")]
    public const ushort HID_USAGE_VR_HEAD_MOUNTED_DISPLAY = ((ushort)(0x0006));

    [NativeTypeName("#define HID_USAGE_VR_HAND_TRACKER ((USAGE) 0x0007)")]
    public const ushort HID_USAGE_VR_HAND_TRACKER = ((ushort)(0x0007));

    [NativeTypeName("#define HID_USAGE_VR_OCULOMETER ((USAGE) 0x0008)")]
    public const ushort HID_USAGE_VR_OCULOMETER = ((ushort)(0x0008));

    [NativeTypeName("#define HID_USAGE_VR_VEST ((USAGE) 0x0009)")]
    public const ushort HID_USAGE_VR_VEST = ((ushort)(0x0009));

    [NativeTypeName("#define HID_USAGE_VR_ANIMATRONIC_DEVICE ((USAGE) 0x000A)")]
    public const ushort HID_USAGE_VR_ANIMATRONIC_DEVICE = ((ushort)(0x000A));

    [NativeTypeName("#define HID_USAGE_VR_STEREO_ENABLE ((USAGE) 0x0020)")]
    public const ushort HID_USAGE_VR_STEREO_ENABLE = ((ushort)(0x0020));

    [NativeTypeName("#define HID_USAGE_VR_DISPLAY_ENABLE ((USAGE) 0x0021)")]
    public const ushort HID_USAGE_VR_DISPLAY_ENABLE = ((ushort)(0x0021));
}
