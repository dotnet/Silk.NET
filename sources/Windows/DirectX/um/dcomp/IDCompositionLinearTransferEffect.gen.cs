// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect"]/*' />
[Guid("4305EE5B-C4A0-4C88-9385-67124E017683")]
[NativeTypeName("struct IDCompositionLinearTransferEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionLinearTransferEffect : IDCompositionLinearTransferEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionLinearTransferEffect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, uint>)(lpVtbl[1]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, uint>)(lpVtbl[2]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetRedYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRedYIntercept(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetRedYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetRedYIntercept(float redYIntercept)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[5]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redYIntercept);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetRedSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRedSlope(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetRedSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRedSlope(float redSlope)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[7]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redSlope);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetRedDisable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRedDisable(BOOL redDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, BOOL, int>)(lpVtbl[8]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetGreenYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGreenYIntercept(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetGreenYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGreenYIntercept(float greenYIntercept)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[10]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenYIntercept);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetGreenSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetGreenSlope(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetGreenSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetGreenSlope(float greenSlope)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[12]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenSlope);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetGreenDisable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetGreenDisable(BOOL greenDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, BOOL, int>)(lpVtbl[13]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetBlueYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetBlueYIntercept(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetBlueYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetBlueYIntercept(float blueYIntercept)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[15]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueYIntercept);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetBlueSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetBlueSlope(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[16]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetBlueSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetBlueSlope(float blueSlope)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[17]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueSlope);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetBlueDisable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetBlueDisable(BOOL blueDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, BOOL, int>)(lpVtbl[18]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetAlphaYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetAlphaYIntercept(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetAlphaYIntercept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetAlphaYIntercept(float alphaYIntercept)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[20]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaYIntercept);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetAlphaSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetAlphaSlope(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetAlphaSlope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetAlphaSlope(float alphaSlope)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[22]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaSlope);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetAlphaDisable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetAlphaDisable(BOOL alphaDisable)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, BOOL, int>)(lpVtbl[23]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
    }

    /// <include file='IDCompositionLinearTransferEffect.xml' path='doc/member[@name="IDCompositionLinearTransferEffect.SetClampOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClampOutput(BOOL clampOutput)
    {
        return ((delegate* unmanaged<IDCompositionLinearTransferEffect*, BOOL, int>)(lpVtbl[24]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetRedYIntercept(IDCompositionAnimation* animation);

        [VtblIndex(5)]
        HRESULT SetRedYIntercept(float redYIntercept);

        [VtblIndex(6)]
        HRESULT SetRedSlope(IDCompositionAnimation* animation);

        [VtblIndex(7)]
        HRESULT SetRedSlope(float redSlope);

        [VtblIndex(8)]
        HRESULT SetRedDisable(BOOL redDisable);

        [VtblIndex(9)]
        HRESULT SetGreenYIntercept(IDCompositionAnimation* animation);

        [VtblIndex(10)]
        HRESULT SetGreenYIntercept(float greenYIntercept);

        [VtblIndex(11)]
        HRESULT SetGreenSlope(IDCompositionAnimation* animation);

        [VtblIndex(12)]
        HRESULT SetGreenSlope(float greenSlope);

        [VtblIndex(13)]
        HRESULT SetGreenDisable(BOOL greenDisable);

        [VtblIndex(14)]
        HRESULT SetBlueYIntercept(IDCompositionAnimation* animation);

        [VtblIndex(15)]
        HRESULT SetBlueYIntercept(float blueYIntercept);

        [VtblIndex(16)]
        HRESULT SetBlueSlope(IDCompositionAnimation* animation);

        [VtblIndex(17)]
        HRESULT SetBlueSlope(float blueSlope);

        [VtblIndex(18)]
        HRESULT SetBlueDisable(BOOL blueDisable);

        [VtblIndex(19)]
        HRESULT SetAlphaYIntercept(IDCompositionAnimation* animation);

        [VtblIndex(20)]
        HRESULT SetAlphaYIntercept(float alphaYIntercept);

        [VtblIndex(21)]
        HRESULT SetAlphaSlope(IDCompositionAnimation* animation);

        [VtblIndex(22)]
        HRESULT SetAlphaSlope(float alphaSlope);

        [VtblIndex(23)]
        HRESULT SetAlphaDisable(BOOL alphaDisable);

        [VtblIndex(24)]
        HRESULT SetClampOutput(BOOL clampOutput);
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
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetRedYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRedYIntercept1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetRedSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRedSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetRedDisable;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetGreenYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetGreenYIntercept1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetGreenSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetGreenSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetGreenDisable;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetBlueYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlueYIntercept1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetBlueSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBlueSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetBlueDisable;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetAlphaYIntercept;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAlphaYIntercept1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetAlphaSlope;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAlphaSlope1;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAlphaDisable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;
    }
}
