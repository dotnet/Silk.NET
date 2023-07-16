// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2"]/*'/>
public unsafe partial struct DDSURFACEDESC2
{
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHeight;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWidth;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2268_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2273_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2278_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwAlphaBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBitDepth;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.lpSurface"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpSurface;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.Anonymous4"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2288_C5")]
    public _Anonymous4_e__Union Anonymous4;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.ddckCKDestBlt"]/*'/>
    public DDCOLORKEY ddckCKDestBlt;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.ddckCKSrcOverlay"]/*'/>
    public DDCOLORKEY ddckCKSrcOverlay;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.ddckCKSrcBlt"]/*'/>
    public DDCOLORKEY ddckCKSrcBlt;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.Anonymous5"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2296_C5")]
    public _Anonymous5_e__Union Anonymous5;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.ddsCaps"]/*'/>
    public DDSCAPS2 ddsCaps;
    /// <include file='DDSURFACEDESC2.xml' path='doc/member[@name="DDSURFACEDESC2.dwTextureStage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTextureStage;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lPitch"]/*'/>
    [UnscopedRef]
    public ref int lPitch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.lPitch;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLinearSize"]/*'/>
    [UnscopedRef]
    public ref uint dwLinearSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwLinearSize;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBackBufferCount"]/*'/>
    [UnscopedRef]
    public ref uint dwBackBufferCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwBackBufferCount;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwDepth;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwMipMapCount"]/*'/>
    [UnscopedRef]
    public ref uint dwMipMapCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwMipMapCount;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwRefreshRate"]/*'/>
    [UnscopedRef]
    public ref uint dwRefreshRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwRefreshRate;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwSrcVBHandle"]/*'/>
    [UnscopedRef]
    public ref uint dwSrcVBHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwSrcVBHandle;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.ddckCKDestOverlay"]/*'/>
    [UnscopedRef]
    public ref DDCOLORKEY ddckCKDestOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.ddckCKDestOverlay;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwEmptyFaceColor"]/*'/>
    [UnscopedRef]
    public ref uint dwEmptyFaceColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwEmptyFaceColor;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.ddpfPixelFormat"]/*'/>
    [UnscopedRef]
    public ref DDPIXELFORMAT ddpfPixelFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.ddpfPixelFormat;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFVF"]/*'/>
    [UnscopedRef]
    public ref uint dwFVF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwFVF;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lPitch"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int lPitch;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwLinearSize"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLinearSize;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwBackBufferCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBackBufferCount;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwDepth;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwMipMapCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwMipMapCount;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwRefreshRate"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRefreshRate;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwSrcVBHandle"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwSrcVBHandle;
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.ddckCKDestOverlay"]/*'/>
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKDestOverlay;
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwEmptyFaceColor"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwEmptyFaceColor;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.ddpfPixelFormat"]/*'/>
        [FieldOffset(0)]
        public DDPIXELFORMAT ddpfPixelFormat;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFVF"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFVF;
    }
}