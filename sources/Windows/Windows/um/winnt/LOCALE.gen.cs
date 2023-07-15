// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class LOCALE
{
    [NativeTypeName("#define LOCALE_NAME_MAX_LENGTH 85")]
    public const int LOCALE_NAME_MAX_LENGTH = 85;
    [NativeTypeName("#define LOCALE_SYSTEM_DEFAULT (MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT))")]
    public const uint LOCALE_SYSTEM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked(((((ushort)(0x02)) << 10) | (ushort)(0x00)))))))));
    [NativeTypeName("#define LOCALE_USER_DEFAULT (MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT))")]
    public const uint LOCALE_USER_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked(((((ushort)(0x01)) << 10) | (ushort)(0x00)))))))));
    [NativeTypeName("#define LOCALE_CUSTOM_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_DEFAULT), SORT_DEFAULT))")]
    public const uint LOCALE_CUSTOM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x03)) << 10) | (ushort)(0x00))))))));
    [NativeTypeName("#define LOCALE_CUSTOM_UNSPECIFIED (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_UNSPECIFIED), SORT_DEFAULT))")]
    public const uint LOCALE_CUSTOM_UNSPECIFIED = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));
    [NativeTypeName("#define LOCALE_CUSTOM_UI_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_UI_CUSTOM_DEFAULT), SORT_DEFAULT))")]
    public const uint LOCALE_CUSTOM_UI_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x05)) << 10) | (ushort)(0x00))))))));
    [NativeTypeName("#define LOCALE_NEUTRAL (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
    public const uint LOCALE_NEUTRAL = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x00)) << 10) | (ushort)(0x00))))))));
    [NativeTypeName("#define LOCALE_INVARIANT (MAKELCID(MAKELANGID(LANG_INVARIANT, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
    public const uint LOCALE_INVARIANT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x00)) << 10) | (ushort)(0x7f))))))));
    [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD1 0x2000")]
    public const int LOCALE_TRANSIENT_KEYBOARD1 = 0x2000;
    [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD2 0x2400")]
    public const int LOCALE_TRANSIENT_KEYBOARD2 = 0x2400;
    [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD3 0x2800")]
    public const int LOCALE_TRANSIENT_KEYBOARD3 = 0x2800;
    [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD4 0x2c00")]
    public const int LOCALE_TRANSIENT_KEYBOARD4 = 0x2c00;
    [NativeTypeName("#define LOCALE_UNASSIGNED_LCID LOCALE_CUSTOM_UNSPECIFIED")]
    public const uint LOCALE_UNASSIGNED_LCID = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));
}