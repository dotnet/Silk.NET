// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class POINTER
{
    [NativeTypeName("#define POINTER_FLAG_NONE 0x00000000")]
    public const int POINTER_FLAG_NONE = 0x00000000;
    [NativeTypeName("#define POINTER_FLAG_NEW 0x00000001")]
    public const int POINTER_FLAG_NEW = 0x00000001;
    [NativeTypeName("#define POINTER_FLAG_INRANGE 0x00000002")]
    public const int POINTER_FLAG_INRANGE = 0x00000002;
    [NativeTypeName("#define POINTER_FLAG_INCONTACT 0x00000004")]
    public const int POINTER_FLAG_INCONTACT = 0x00000004;
    [NativeTypeName("#define POINTER_FLAG_FIRSTBUTTON 0x00000010")]
    public const int POINTER_FLAG_FIRSTBUTTON = 0x00000010;
    [NativeTypeName("#define POINTER_FLAG_SECONDBUTTON 0x00000020")]
    public const int POINTER_FLAG_SECONDBUTTON = 0x00000020;
    [NativeTypeName("#define POINTER_FLAG_THIRDBUTTON 0x00000040")]
    public const int POINTER_FLAG_THIRDBUTTON = 0x00000040;
    [NativeTypeName("#define POINTER_FLAG_FOURTHBUTTON 0x00000080")]
    public const int POINTER_FLAG_FOURTHBUTTON = 0x00000080;
    [NativeTypeName("#define POINTER_FLAG_FIFTHBUTTON 0x00000100")]
    public const int POINTER_FLAG_FIFTHBUTTON = 0x00000100;
    [NativeTypeName("#define POINTER_FLAG_PRIMARY 0x00002000")]
    public const int POINTER_FLAG_PRIMARY = 0x00002000;
    [NativeTypeName("#define POINTER_FLAG_CONFIDENCE 0x00004000")]
    public const int POINTER_FLAG_CONFIDENCE = 0x00004000;
    [NativeTypeName("#define POINTER_FLAG_CANCELED 0x00008000")]
    public const int POINTER_FLAG_CANCELED = 0x00008000;
    [NativeTypeName("#define POINTER_FLAG_DOWN 0x00010000")]
    public const int POINTER_FLAG_DOWN = 0x00010000;
    [NativeTypeName("#define POINTER_FLAG_UPDATE 0x00020000")]
    public const int POINTER_FLAG_UPDATE = 0x00020000;
    [NativeTypeName("#define POINTER_FLAG_UP 0x00040000")]
    public const int POINTER_FLAG_UP = 0x00040000;
    [NativeTypeName("#define POINTER_FLAG_WHEEL 0x00080000")]
    public const int POINTER_FLAG_WHEEL = 0x00080000;
    [NativeTypeName("#define POINTER_FLAG_HWHEEL 0x00100000")]
    public const int POINTER_FLAG_HWHEEL = 0x00100000;
    [NativeTypeName("#define POINTER_FLAG_CAPTURECHANGED 0x00200000")]
    public const int POINTER_FLAG_CAPTURECHANGED = 0x00200000;
    [NativeTypeName("#define POINTER_FLAG_HASTRANSFORM 0x00400000")]
    public const int POINTER_FLAG_HASTRANSFORM = 0x00400000;
    [NativeTypeName("#define POINTER_MOD_SHIFT (0x0004)")]
    public const int POINTER_MOD_SHIFT = (0x0004);
    [NativeTypeName("#define POINTER_MOD_CTRL (0x0008)")]
    public const int POINTER_MOD_CTRL = (0x0008);
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_NEW 0x00000001")]
    public const int POINTER_MESSAGE_FLAG_NEW = 0x00000001;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_INRANGE 0x00000002")]
    public const int POINTER_MESSAGE_FLAG_INRANGE = 0x00000002;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_INCONTACT 0x00000004")]
    public const int POINTER_MESSAGE_FLAG_INCONTACT = 0x00000004;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_FIRSTBUTTON 0x00000010")]
    public const int POINTER_MESSAGE_FLAG_FIRSTBUTTON = 0x00000010;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_SECONDBUTTON 0x00000020")]
    public const int POINTER_MESSAGE_FLAG_SECONDBUTTON = 0x00000020;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_THIRDBUTTON 0x00000040")]
    public const int POINTER_MESSAGE_FLAG_THIRDBUTTON = 0x00000040;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_FOURTHBUTTON 0x00000080")]
    public const int POINTER_MESSAGE_FLAG_FOURTHBUTTON = 0x00000080;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_FIFTHBUTTON 0x00000100")]
    public const int POINTER_MESSAGE_FLAG_FIFTHBUTTON = 0x00000100;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_PRIMARY 0x00002000")]
    public const int POINTER_MESSAGE_FLAG_PRIMARY = 0x00002000;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_CONFIDENCE 0x00004000")]
    public const int POINTER_MESSAGE_FLAG_CONFIDENCE = 0x00004000;
    [NativeTypeName("#define POINTER_MESSAGE_FLAG_CANCELED 0x00008000")]
    public const int POINTER_MESSAGE_FLAG_CANCELED = 0x00008000;
    [NativeTypeName("#define POINTER_DEVICE_PRODUCT_STRING_MAX 520")]
    public const int POINTER_DEVICE_PRODUCT_STRING_MAX = 520;
}