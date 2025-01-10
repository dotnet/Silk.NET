// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct RAWMOUSE
{
    public ushort usFlags;

    [NativeTypeName("__AnonymousRecord_winuser_L14999_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("ULONG")]
    public uint ulRawButtons;

    [NativeTypeName("LONG")]
    public int lLastX;

    [NativeTypeName("LONG")]
    public int lLastY;

    [NativeTypeName("ULONG")]
    public uint ulExtraInformation;

    [UnscopedRef]
    public ref uint ulButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ulButtons; }
    }

    [UnscopedRef]
    public ref ushort usButtonFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.usButtonFlags; }
    }

    [UnscopedRef]
    public ref ushort usButtonData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.usButtonData; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ulButtons;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winuser_L15001_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public ushort usButtonFlags;
            public ushort usButtonData;
        }
    }
}
