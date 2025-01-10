// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DDOVERLAYFX
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlendBitDepth;

    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlend;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("DWORD")]
    public uint dwAlphaDestConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L775_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("DWORD")]
    public uint dwAlphaSrcConstBitDepth;

    [NativeTypeName("__AnonymousRecord_ddraw_L781_C5")]
    public _Anonymous2_e__Union Anonymous2;
    public DDCOLORKEY dckDestColorkey;
    public DDCOLORKEY dckSrcColorkey;

    [NativeTypeName("DWORD")]
    public uint dwDDFX;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [UnscopedRef]
    public ref uint dwAlphaDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwAlphaDestConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSAlphaDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.lpDDSAlphaDest; }
    }

    [UnscopedRef]
    public ref uint dwAlphaSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwAlphaSrcConst; }
    }

    [UnscopedRef]
    public ref IDirectDrawSurface lpDDSAlphaSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.lpDDSAlphaSrc; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSAlphaDest;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConst;

        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface lpDDSAlphaSrc;
    }
}
