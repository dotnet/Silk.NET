// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DDBLTFX
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwDDFX;

    [NativeTypeName("DWORD")]
    public uint dwROP;

    [NativeTypeName("DWORD")]
    public uint dwDDROP;

    [NativeTypeName("DWORD")]
    public uint dwRotationAngle;

    [NativeTypeName("DWORD")]
    public uint dwZBufferOpCode;

    [NativeTypeName("DWORD")]
    public uint dwZBufferLow;

    [NativeTypeName("DWORD")]
    public uint dwZBufferHigh;

    [NativeTypeName("DWORD")]
    public uint dwZBufferBaseDest;

    [NativeTypeName("DWORD")]
    public uint dwZDestConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L287_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("DWORD")]
    public uint dwZSrcConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L293_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlendBitDepth;

    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlend;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("DWORD")]
    public uint dwAlphaDestConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L302_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("DWORD")]
    public uint dwAlphaSrcConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L308_C5")]
    public _Anonymous4_e__Union Anonymous4;

    [NativeTypeName("__AnonymousRecord_ddraw_L313_C5")]
    public _Anonymous5_e__Union Anonymous5;
    public DDCOLORKEY ddckDestColorkey;
    public DDCOLORKEY ddckSrcColorkey;

    [UnscopedRef]
    public ref uint dwZDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwZDestConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSZBufferDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.lpDDSZBufferDest; }
    }

    [UnscopedRef]
    public ref uint dwZSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwZSrcConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSZBufferSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.lpDDSZBufferSrc; }
    }

    [UnscopedRef]
    public ref uint dwAlphaDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.dwAlphaDestConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSAlphaDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.lpDDSAlphaDest; }
    }

    [UnscopedRef]
    public ref uint dwAlphaSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.dwAlphaSrcConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSAlphaSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous4.lpDDSAlphaSrc; }
    }

    [UnscopedRef]
    public ref uint dwFillColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwFillColor; }
    }

    [UnscopedRef]
    public ref uint dwFillDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwFillDepth; }
    }

    [UnscopedRef]
    public ref uint dwFillPixel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.dwFillPixel; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSPattern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous5.lpDDSPattern; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZDestConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSZBufferDest;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZSrcConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSZBufferSrc;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSAlphaDest;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSAlphaSrc;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillColor;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillDepth;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillPixel;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSPattern;
    }

    [NativeTypeName("#define DDBLTFX_ARITHSTRETCHY 0x00000001l")]
    public const int DDBLTFX_ARITHSTRETCHY = 0x00000001;

    [NativeTypeName("#define DDBLTFX_MIRRORLEFTRIGHT 0x00000002l")]
    public const int DDBLTFX_MIRRORLEFTRIGHT = 0x00000002;

    [NativeTypeName("#define DDBLTFX_MIRRORUPDOWN 0x00000004l")]
    public const int DDBLTFX_MIRRORUPDOWN = 0x00000004;

    [NativeTypeName("#define DDBLTFX_NOTEARING 0x00000008l")]
    public const int DDBLTFX_NOTEARING = 0x00000008;

    [NativeTypeName("#define DDBLTFX_ROTATE180 0x00000010l")]
    public const int DDBLTFX_ROTATE180 = 0x00000010;

    [NativeTypeName("#define DDBLTFX_ROTATE270 0x00000020l")]
    public const int DDBLTFX_ROTATE270 = 0x00000020;

    [NativeTypeName("#define DDBLTFX_ROTATE90 0x00000040l")]
    public const int DDBLTFX_ROTATE90 = 0x00000040;

    [NativeTypeName("#define DDBLTFX_ZBUFFERRANGE 0x00000080l")]
    public const int DDBLTFX_ZBUFFERRANGE = 0x00000080;

    [NativeTypeName("#define DDBLTFX_ZBUFFERBASEDEST 0x00000100l")]
    public const int DDBLTFX_ZBUFFERBASEDEST = 0x00000100;
}
