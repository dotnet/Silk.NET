// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDPIXELFORMAT
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwFourCC;

    [NativeTypeName("__AnonymousRecord_ddraw_L712_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_ddraw_L723_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("__AnonymousRecord_ddraw_L732_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("__AnonymousRecord_ddraw_L745_C5")]
    public _Anonymous4_e__Union Anonymous4;

    [NativeTypeName("__AnonymousRecord_ddraw_L752_C5")]
    public _Anonymous5_e__Union Anonymous5;

    [UnscopedRef]
    public ref uint dwRGBBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwRGBBitCount; }
    }

    [UnscopedRef]
    public ref uint dwYUVBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwYUVBitCount; }
    }

    [UnscopedRef]
    public ref uint dwZBufferBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwZBufferBitDepth; }
    }

    [UnscopedRef]
    public ref uint dwAlphaBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwAlphaBitDepth; }
    }

    [UnscopedRef]
    public ref uint dwLuminanceBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwLuminanceBitCount; }
    }

    [UnscopedRef]
    public ref uint dwBumpBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwBumpBitCount; }
    }

    [UnscopedRef]
    public ref uint dwPrivateFormatBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwPrivateFormatBitCount; }
    }

    [UnscopedRef]
    public ref uint dwRBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwRBitMask; }
    }

    [UnscopedRef]
    public ref uint dwYBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwYBitMask; }
    }

    [UnscopedRef]
    public ref uint dwStencilBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwStencilBitDepth; }
    }

    [UnscopedRef]
    public ref uint dwLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwLuminanceBitMask; }
    }

    [UnscopedRef]
    public ref uint dwBumpDuBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwBumpDuBitMask; }
    }

    [UnscopedRef]
    public ref uint dwOperations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwOperations; }
    }

    [UnscopedRef]
    public ref uint dwGBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwGBitMask; }
    }

    [UnscopedRef]
    public ref uint dwUBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwUBitMask; }
    }

    [UnscopedRef]
    public ref uint dwZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwZBitMask; }
    }

    [UnscopedRef]
    public ref uint dwBumpDvBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwBumpDvBitMask; }
    }

    [UnscopedRef]
    public ref _Anonymous3_e__Union._MultiSampleCaps_e__Struct MultiSampleCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.MultiSampleCaps; }
    }

    [UnscopedRef]
    public ref uint dwBBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwBBitMask; }
    }

    [UnscopedRef]
    public ref uint dwVBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwVBitMask; }
    }

    [UnscopedRef]
    public ref uint dwStencilBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwStencilBitMask; }
    }

    [UnscopedRef]
    public ref uint dwBumpLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwBumpLuminanceBitMask; }
    }

    [UnscopedRef]
    public ref uint dwRGBAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwRGBAlphaBitMask; }
    }

    [UnscopedRef]
    public ref uint dwYUVAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwYUVAlphaBitMask; }
    }

    [UnscopedRef]
    public ref uint dwLuminanceAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwLuminanceAlphaBitMask; }
    }

    [UnscopedRef]
    public ref uint dwRGBZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwRGBZBitMask; }
    }

    [UnscopedRef]
    public ref uint dwYUVZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwYUVZBitMask; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBBitCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVBitCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBufferBitDepth;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaBitDepth;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpBitCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwPrivateFormatBitCount;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitDepth;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDuBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwOperations;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwGBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwUBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDvBitMask;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ddraw_L738_C9")]
        public _MultiSampleCaps_e__Struct MultiSampleCaps;

        public partial struct _MultiSampleCaps_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort wFlipMSTypes;

            [NativeTypeName("WORD")]
            public ushort wBltMSTypes;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpLuminanceBitMask;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBAlphaBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVAlphaBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceAlphaBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBZBitMask;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVZBitMask;
    }
}
