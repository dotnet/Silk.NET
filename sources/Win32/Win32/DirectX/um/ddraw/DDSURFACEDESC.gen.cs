// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DDSURFACEDESC
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwHeight;

    [NativeTypeName("DWORD")]
    public uint dwWidth;

    [NativeTypeName("__AnonymousRecord_ddraw_L2236_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("DWORD")]
    public uint dwBackBufferCount;

    [NativeTypeName("__AnonymousRecord_ddraw_L2242_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("DWORD")]
    public uint dwAlphaBitDepth;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("LPVOID")]
    public void* lpSurface;
    public DDCOLORKEY ddckCKDestOverlay;
    public DDCOLORKEY ddckCKDestBlt;
    public DDCOLORKEY ddckCKSrcOverlay;
    public DDCOLORKEY ddckCKSrcBlt;
    public DDPIXELFORMAT ddpfPixelFormat;
    public DDSCAPS ddsCaps;

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
    public ref uint dwMipMapCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwMipMapCount; }
    }

    [UnscopedRef]
    public ref uint dwZBufferBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwZBufferBitDepth; }
    }

    [UnscopedRef]
    public ref uint dwRefreshRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwRefreshRate; }
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
        public uint dwMipMapCount;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBufferBitDepth;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRefreshRate;
    }
}
