// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX"]/*'/>
public unsafe partial struct DDOVERLAYFX
{
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwAlphaEdgeBlendBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlendBitDepth;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwAlphaEdgeBlend"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaEdgeBlend;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwAlphaDestConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaDestConstBitDepth;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L775_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwAlphaSrcConstBitDepth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlphaSrcConstBitDepth;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L781_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dckDestColorkey"]/*'/>
    public DDCOLORKEY dckDestColorkey;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dckSrcColorkey"]/*'/>
    public DDCOLORKEY dckSrcColorkey;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwDDFX"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDDFX;
    /// <include file='DDOVERLAYFX.xml' path='doc/member[@name="DDOVERLAYFX.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaDestConst"]/*'/>
    [UnscopedRef]
    public ref uint dwAlphaDestConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwAlphaDestConst;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lpDDSAlphaDest"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSAlphaDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.lpDDSAlphaDest;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwAlphaSrcConst"]/*'/>
    [UnscopedRef]
    public ref uint dwAlphaSrcConst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwAlphaSrcConst;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.lpDDSAlphaSrc"]/*'/>
    [UnscopedRef]
    public ref IDirectDrawSurface* lpDDSAlphaSrc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.lpDDSAlphaSrc;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwAlphaDestConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConst;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.lpDDSAlphaDest"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSAlphaDest;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwAlphaSrcConst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConst;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.lpDDSAlphaSrc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPDIRECTDRAWSURFACE")]
        public IDirectDrawSurface* lpDDSAlphaSrc;
    }
}