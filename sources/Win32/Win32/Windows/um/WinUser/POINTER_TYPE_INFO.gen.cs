// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct POINTER_TYPE_INFO
{
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint type;

    [NativeTypeName("__AnonymousRecord_winuser_L6496_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref POINTER_TOUCH_INFO touchInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.touchInfo; }
    }

    [UnscopedRef]
    public ref POINTER_PEN_INFO penInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.penInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public POINTER_TOUCH_INFO touchInfo;

        [FieldOffset(0)]
        public POINTER_PEN_INFO penInfo;
    }
}
