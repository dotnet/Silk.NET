// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDrawVideoImage.xml' path='doc/member[@name="IDrawVideoImage"]/*'/>
[Guid("48EFB120-AB49-11D2-AED2-00A0C995E8D5")]
[NativeTypeName("struct IDrawVideoImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDrawVideoImage : IDrawVideoImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDrawVideoImage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDrawVideoImage*, Guid*, void**, int> )(lpVtbl[0]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDrawVideoImage*, uint> )(lpVtbl[1]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDrawVideoImage*, uint> )(lpVtbl[2]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDrawVideoImage.xml' path='doc/member[@name="IDrawVideoImage.DrawVideoImageBegin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DrawVideoImageBegin()
    {
        return ((delegate* unmanaged<IDrawVideoImage*, int> )(lpVtbl[3]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDrawVideoImage.xml' path='doc/member[@name="IDrawVideoImage.DrawVideoImageEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DrawVideoImageEnd()
    {
        return ((delegate* unmanaged<IDrawVideoImage*, int> )(lpVtbl[4]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDrawVideoImage.xml' path='doc/member[@name="IDrawVideoImage.DrawVideoImageDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DrawVideoImageDraw(HDC hdc, [NativeTypeName("LPRECT")] RECT* lprcSrc, [NativeTypeName("LPRECT")] RECT* lprcDst)
    {
        return ((delegate* unmanaged<IDrawVideoImage*, HDC, RECT*, RECT*, int> )(lpVtbl[5]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), hdc, lprcSrc, lprcDst);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DrawVideoImageBegin();
        [VtblIndex(4)]
        HRESULT DrawVideoImageEnd();
        [VtblIndex(5)]
        HRESULT DrawVideoImageDraw(HDC hdc, [NativeTypeName("LPRECT")] RECT* lprcSrc, [NativeTypeName("LPRECT")] RECT* lprcDst);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DrawVideoImageBegin;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DrawVideoImageEnd;
        [NativeTypeName("HRESULT (HDC, LPRECT, LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, RECT*, int> DrawVideoImageDraw;
    }
}