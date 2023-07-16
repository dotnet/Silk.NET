// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT"]/*'/>
public partial struct DDPIXELFORMAT
{
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.dwFourCC"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFourCC;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L712_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L723_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L732_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous4"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L745_C5")]
    public _Anonymous4_e__Union Anonymous4;
    /// <include file='DDPIXELFORMAT.xml' path='doc/member[@name="DDPIXELFORMAT.Anonymous5"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L752_C5")]
    public _Anonymous5_e__Union Anonymous5;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwRGBBitCount"]/*'/>
    [UnscopedRef]
    public ref uint dwRGBBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwRGBBitCount;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwYUVBitCount"]/*'/>
    [UnscopedRef]
    public ref uint dwYUVBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwYUVBitCount;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZBufferBitDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwZBufferBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwZBufferBitDepth;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaBitDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwAlphaBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwAlphaBitDepth;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLuminanceBitCount"]/*'/>
    [UnscopedRef]
    public ref uint dwLuminanceBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwLuminanceBitCount;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwBumpBitCount"]/*'/>
    [UnscopedRef]
    public ref uint dwBumpBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwBumpBitCount;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwPrivateFormatBitCount"]/*'/>
    [UnscopedRef]
    public ref uint dwPrivateFormatBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwPrivateFormatBitCount;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwRBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwRBitMask;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwYBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwYBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwYBitMask;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwStencilBitDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwStencilBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwStencilBitDepth;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwLuminanceBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwLuminanceBitMask;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBumpDuBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwBumpDuBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwBumpDuBitMask;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwOperations"]/*'/>
    [UnscopedRef]
    public ref uint dwOperations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwOperations;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwGBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwGBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwGBitMask;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwUBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwUBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwUBitMask;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwZBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwZBitMask;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwBumpDvBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwBumpDvBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwBumpDvBitMask;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.MultiSampleCaps"]/*'/>
    [UnscopedRef]
    public ref _Anonymous3_e__Union._MultiSampleCaps_e__Struct MultiSampleCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.MultiSampleCaps;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwBBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwBBitMask;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwVBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwVBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwVBitMask;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwStencilBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwStencilBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwStencilBitMask;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBumpLuminanceBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwBumpLuminanceBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwBumpLuminanceBitMask;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBAlphaBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwRGBAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwRGBAlphaBitMask;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVAlphaBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwYUVAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwYUVAlphaBitMask;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwLuminanceAlphaBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwLuminanceAlphaBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwLuminanceAlphaBitMask;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBZBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwRGBZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwRGBZBitMask;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVZBitMask"]/*'/>
    [UnscopedRef]
    public ref uint dwYUVZBitMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwYUVZBitMask;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwRGBBitCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBBitCount;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwYUVBitCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVBitCount;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZBufferBitDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBufferBitDepth;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaBitDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaBitDepth;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLuminanceBitCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitCount;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwBumpBitCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpBitCount;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwPrivateFormatBitCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwPrivateFormatBitCount;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRBitMask;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwYBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYBitMask;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwStencilBitDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitDepth;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwLuminanceBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceBitMask;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBumpDuBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDuBitMask;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwOperations"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwOperations;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwGBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwGBitMask;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwUBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwUBitMask;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwZBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBitMask;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwBumpDvBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpDvBitMask;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.MultiSampleCaps"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ddraw_L738_C9")]
        public _MultiSampleCaps_e__Struct MultiSampleCaps;
        /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct"]/*'/>
        public partial struct _MultiSampleCaps_e__Struct
        {
            /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct.wFlipMSTypes"]/*'/>
            [NativeTypeName("WORD")]
            public ushort wFlipMSTypes;
            /// <include file='_MultiSampleCaps_e__Struct.xml' path='doc/member[@name="_MultiSampleCaps_e__Struct.wBltMSTypes"]/*'/>
            [NativeTypeName("WORD")]
            public ushort wBltMSTypes;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBBitMask;
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwVBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVBitMask;
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwStencilBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwStencilBitMask;
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwBumpLuminanceBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBumpLuminanceBitMask;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBAlphaBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBAlphaBitMask;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVAlphaBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVAlphaBitMask;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwLuminanceAlphaBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLuminanceAlphaBitMask;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwRGBZBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRGBZBitMask;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwYUVZBitMask"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwYUVZBitMask;
    }
}