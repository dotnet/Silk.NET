// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect"]/*' />
[Guid("3B67DFA8-E3DD-4E61-B640-46C2F3D739DC")]
[NativeTypeName("struct IDCompositionArithmeticCompositeEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionArithmeticCompositeEffect : IDCompositionArithmeticCompositeEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionArithmeticCompositeEffect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[1]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[2]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficients"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, D2D_VECTOR_4F*, int>)(lpVtbl[4]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), coefficients);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetClampOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetClampOutput(BOOL clampoutput)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, BOOL, int>)(lpVtbl[5]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), clampoutput);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCoefficient1(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCoefficient1(float Coeffcient1)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[7]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coeffcient1);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCoefficient2(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetCoefficient2(float Coefficient2)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[9]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient2);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCoefficient3(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetCoefficient3(float Coefficient3)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[11]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient3);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCoefficient4(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionArithmeticCompositeEffect.xml' path='doc/member[@name="IDCompositionArithmeticCompositeEffect.SetCoefficient4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCoefficient4(float Coefficient4)
    {
        return ((delegate* unmanaged<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[13]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient4);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients);

        [VtblIndex(5)]
        HRESULT SetClampOutput(BOOL clampoutput);

        [VtblIndex(6)]
        HRESULT SetCoefficient1(IDCompositionAnimation* animation);

        [VtblIndex(7)]
        HRESULT SetCoefficient1(float Coeffcient1);

        [VtblIndex(8)]
        HRESULT SetCoefficient2(IDCompositionAnimation* animation);

        [VtblIndex(9)]
        HRESULT SetCoefficient2(float Coefficient2);

        [VtblIndex(10)]
        HRESULT SetCoefficient3(IDCompositionAnimation* animation);

        [VtblIndex(11)]
        HRESULT SetCoefficient3(float Coefficient3);

        [VtblIndex(12)]
        HRESULT SetCoefficient4(IDCompositionAnimation* animation);

        [VtblIndex(13)]
        HRESULT SetCoefficient4(float Coefficient4);
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

        [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_VECTOR_4F*, int> SetCoefficients;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCoefficient1;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient11;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCoefficient2;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient21;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCoefficient3;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient31;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCoefficient4;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCoefficient41;
    }
}
