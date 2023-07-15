// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect"]/*'/>
[Guid("4AD18AC0-CFD2-4C2F-BB62-96E54FDB6879")]
[NativeTypeName("struct IDCompositionShadowEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionShadowEffect : IDCompositionShadowEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionShadowEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, uint> )(lpVtbl[1]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, uint> )(lpVtbl[2]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionFilterEffect.SetInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetStandardDeviation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStandardDeviation(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int> )(lpVtbl[4]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetStandardDeviation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStandardDeviation(float amount)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int> )(lpVtbl[5]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, D2D_VECTOR_4F*, int> )(lpVtbl[6]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetRed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRed(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int> )(lpVtbl[7]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetRed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRed(float amount)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int> )(lpVtbl[8]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetGreen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGreen(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int> )(lpVtbl[9]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetGreen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGreen(float amount)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int> )(lpVtbl[10]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetBlue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBlue(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int> )(lpVtbl[11]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetBlue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBlue(float amount)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int> )(lpVtbl[12]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetAlpha"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetAlpha(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int> )(lpVtbl[13]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionShadowEffect.xml' path='doc/member[@name="IDCompositionShadowEffect.SetAlpha"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAlpha(float amount)
    {
        return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int> )(lpVtbl[14]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetStandardDeviation(IDCompositionAnimation* animation);
        [VtblIndex(5)]
        HRESULT SetStandardDeviation(float amount);
        [VtblIndex(6)]
        HRESULT SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color);
        [VtblIndex(7)]
        HRESULT SetRed(IDCompositionAnimation* animation);
        [VtblIndex(8)]
        HRESULT SetRed(float amount);
        [VtblIndex(9)]
        HRESULT SetGreen(IDCompositionAnimation* animation);
        [VtblIndex(10)]
        HRESULT SetGreen(float amount);
        [VtblIndex(11)]
        HRESULT SetBlue(IDCompositionAnimation* animation);
        [VtblIndex(12)]
        HRESULT SetBlue(float amount);
        [VtblIndex(13)]
        HRESULT SetAlpha(IDCompositionAnimation* animation);
        [VtblIndex(14)]
        HRESULT SetAlpha(float amount);
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
        [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, uint, int> SetInput;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetStandardDeviation;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetStandardDeviation1;
        [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_4F*, int> SetColor;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetRed;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRed1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetGreen;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetGreen1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetBlue;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlue1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetAlpha;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAlpha1;
    }
}