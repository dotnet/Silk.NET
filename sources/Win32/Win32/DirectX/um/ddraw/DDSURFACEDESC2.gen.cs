// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DDSURFACEDESC2
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwHeight;

    [NativeTypeName("DWORD")]
    public uint dwWidth;

    [NativeTypeName("__AnonymousRecord_ddraw_L2268_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_ddraw_L2273_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("__AnonymousRecord_ddraw_L2278_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("DWORD")]
    public uint dwAlphaBitDepth;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("LPVOID")]
    public void* lpSurface;

    [NativeTypeName("__AnonymousRecord_ddraw_L2288_C5")]
    public _Anonymous4_e__Union Anonymous4;
    public DDCOLORKEY ddckCKDestBlt;
    public DDCOLORKEY ddckCKSrcOverlay;
    public DDCOLORKEY ddckCKSrcBlt;

    [NativeTypeName("__AnonymousRecord_ddraw_L2296_C5")]
    public _Anonymous5_e__Union Anonymous5;
    public DDSCAPS2 ddsCaps;

    [NativeTypeName("DWORD")]
    public uint dwTextureStage;

    [UnscopedRef]
    public ref int lPitch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.lPitch; }
    }

    [UnscopedRef]
    public ref uint dwLinearSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwLinearSize; }
    }

    [UnscopedRef]
    public ref uint dwBackBufferCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwBackBufferCount; }
    }

    [UnscopedRef]
    public ref uint dwDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwDepth; }
    }

    [UnscopedRef]
    public ref uint dwMipMapCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwMipMapCount; }
    }

    [UnscopedRef]
    public ref uint dwRefreshRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwRefreshRate; }
    }

    [UnscopedRef]
    public ref uint dwSrcVBHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwSrcVBHandle; }
    }

    [UnscopedRef]
    public ref DDCOLORKEY ddckCKDestOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.ddckCKDestOverlay; }
    }

    [UnscopedRef]
    public ref uint dwEmptyFaceColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwEmptyFaceColor; }
    }

    [UnscopedRef]
    public ref DDPIXELFORMAT ddpfPixelFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.ddpfPixelFormat; }
    }

    [UnscopedRef]
    public ref uint dwFVF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwFVF; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int lPitch;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLinearSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwBackBufferCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwDepth;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwMipMapCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRefreshRate;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwSrcVBHandle;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKDestOverlay;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwEmptyFaceColor;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public DDPIXELFORMAT ddpfPixelFormat;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFVF;
    }
}
