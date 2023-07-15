// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DISPID
{
    [NativeTypeName("#define DISPID_UNKNOWN ( -1 )")]
    public const int DISPID_UNKNOWN = (-1);
    [NativeTypeName("#define DISPID_VALUE ( 0 )")]
    public const int DISPID_VALUE = (0);
    [NativeTypeName("#define DISPID_PROPERTYPUT ( -3 )")]
    public const int DISPID_PROPERTYPUT = (-3);
    [NativeTypeName("#define DISPID_NEWENUM ( -4 )")]
    public const int DISPID_NEWENUM = (-4);
    [NativeTypeName("#define DISPID_EVALUATE ( -5 )")]
    public const int DISPID_EVALUATE = (-5);
    [NativeTypeName("#define DISPID_CONSTRUCTOR ( -6 )")]
    public const int DISPID_CONSTRUCTOR = (-6);
    [NativeTypeName("#define DISPID_DESTRUCTOR ( -7 )")]
    public const int DISPID_DESTRUCTOR = (-7);
    [NativeTypeName("#define DISPID_COLLECT ( -8 )")]
    public const int DISPID_COLLECT = (-8);
}