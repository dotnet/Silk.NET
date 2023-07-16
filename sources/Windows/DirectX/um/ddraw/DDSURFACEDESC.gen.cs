// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC"]/*'/>
public unsafe partial struct DDSURFACEDESC
{
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHeight;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWidth;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2236_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwBackBufferCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBackBufferCount;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L2242_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwAlphaBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaBitDepth;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.lpSurface"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpSurface;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddckCKDestOverlay"]/*'/>
    public DDCOLORKEY ddckCKDestOverlay;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddckCKDestBlt"]/*'/>
    public DDCOLORKEY ddckCKDestBlt;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddckCKSrcOverlay"]/*'/>
    public DDCOLORKEY ddckCKSrcOverlay;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddckCKSrcBlt"]/*'/>
    public DDCOLORKEY ddckCKSrcBlt;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddpfPixelFormat"]/*'/>
    public DDPIXELFORMAT ddpfPixelFormat;
    /// <include file='DDSURFACEDESC.xml' path='doc/member[@name="DDSURFACEDESC.ddsCaps"]/*'/>
    public DDSCAPS ddsCaps;
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

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwMipMapCount"]/*'/>
    [UnscopedRef]
    public ref uint dwMipMapCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwMipMapCount;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwZBufferBitDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwZBufferBitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwZBufferBitDepth;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRefreshRate"]/*'/>
    [UnscopedRef]
    public ref uint dwRefreshRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwRefreshRate;
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
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwMipMapCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwMipMapCount;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwZBufferBitDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZBufferBitDepth;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwRefreshRate"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRefreshRate;
    }
}