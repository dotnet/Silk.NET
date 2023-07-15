// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
public unsafe partial struct DDBLTFX
{
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwDDFX"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDDFX;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwROP"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwROP;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwDDROP"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDDROP;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwRotationAngle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRotationAngle;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZBufferOpCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferOpCode;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZBufferLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferLow;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZBufferHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferHigh;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZBufferBaseDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZBufferBaseDest;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZDestConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZDestConstBitDepth;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L287_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwZSrcConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwZSrcConstBitDepth;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L293_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwAlphaEdgeBlendBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlendBitDepth;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwAlphaEdgeBlend"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlend;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwAlphaDestConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaDestConstBitDepth;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L302_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.dwAlphaSrcConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaSrcConstBitDepth;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.Anonymous4"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L308_C5")]
    public _Anonymous4_e__Union Anonymous4;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.Anonymous5"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L313_C5")]
    public _Anonymous5_e__Union Anonymous5;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.ddckDestColorkey"]/*'/>
    public DDCOLORKEY ddckDestColorkey;
    /// <include file='DDBLTFX.xml' path='doc/member[@name="DDBLTFX.ddckSrcColorkey"]/*'/>
    public DDCOLORKEY ddckSrcColorkey;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZDestConst"]/*'/>
    [UnscopedRef]
    public ref uint dwZDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwZDestConst;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lpDDSZBufferDest"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSZBufferDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.lpDDSZBufferDest;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwZSrcConst"]/*'/>
    [UnscopedRef]
    public ref uint dwZSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwZSrcConst;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.lpDDSZBufferSrc"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSZBufferSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.lpDDSZBufferSrc;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwAlphaDestConst"]/*'/>
    [UnscopedRef]
    public ref uint dwAlphaDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.dwAlphaDestConst;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.lpDDSAlphaDest"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSAlphaDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.lpDDSAlphaDest;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwAlphaSrcConst"]/*'/>
    [UnscopedRef]
    public ref uint dwAlphaSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.dwAlphaSrcConst;
        }
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.lpDDSAlphaSrc"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSAlphaSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous4.lpDDSAlphaSrc;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillColor"]/*'/>
    [UnscopedRef]
    public ref uint dwFillColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwFillColor;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwFillDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwFillDepth;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillPixel"]/*'/>
    [UnscopedRef]
    public ref uint dwFillPixel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.dwFillPixel;
        }
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.lpDDSPattern"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSPattern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous5.lpDDSPattern;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwZDestConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZDestConst;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lpDDSZBufferDest"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSZBufferDest;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwZSrcConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwZSrcConst;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.lpDDSZBufferSrc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSZBufferSrc;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.dwAlphaDestConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConst;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.lpDDSAlphaDest"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSAlphaDest;
    }

    /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous4_e__Union
    {
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.dwAlphaSrcConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConst;
        /// <include file='_Anonymous4_e__Union.xml' path='doc/member[@name="_Anonymous4_e__Union.lpDDSAlphaSrc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSAlphaSrc;
    }

    /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous5_e__Union
    {
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillColor"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillColor;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillDepth;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.dwFillPixel"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFillPixel;
        /// <include file='_Anonymous5_e__Union.xml' path='doc/member[@name="_Anonymous5_e__Union.lpDDSPattern"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSPattern;
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