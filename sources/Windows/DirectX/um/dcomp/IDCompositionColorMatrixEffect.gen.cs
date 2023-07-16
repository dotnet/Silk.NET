// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect"]/*'/>
[Guid("C1170A22-3CE2-4966-90D4-55408BFC84C4")]
[NativeTypeName("struct IDCompositionColorMatrixEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionColorMatrixEffect : IDCompositionColorMatrixEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionColorMatrixEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint> )(lpVtbl[1]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint> )(lpVtbl[2]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionFilterEffect.SetInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect.SetMatrix"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, D2D_MATRIX_5X4_F*, int> )(lpVtbl[4]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), matrix);
    }

    /// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect.SetMatrixElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, int, int, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, animation);
    }

    /// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect.SetMatrixElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMatrixElement(int row, int column, float value)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, int, int, float, int> )(lpVtbl[6]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, value);
    }

    /// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect.SetAlphaMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, D2D1_COLORMATRIX_ALPHA_MODE, int> )(lpVtbl[7]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IDCompositionColorMatrixEffect.xml' path='doc/member[@name="IDCompositionColorMatrixEffect.SetClampOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetClampOutput(BOOL clamp)
    {
        return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, BOOL, int> )(lpVtbl[8]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), clamp);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix);
        [VtblIndex(5)]
        HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation);
        [VtblIndex(6)]
        HRESULT SetMatrixElement(int row, int column, float value);
        [VtblIndex(7)]
        HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode);
        [VtblIndex(8)]
        HRESULT SetClampOutput(BOOL clamp);
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
        [NativeTypeName("HRESULT (const D2D1_MATRIX_5X4_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_5X4_F*, int> SetMatrix;
        [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation*, int> SetMatrixElement;
        [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetMatrixElement1;
        [NativeTypeName("HRESULT (D2D1_COLORMATRIX_ALPHA_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_COLORMATRIX_ALPHA_MODE, int> SetAlphaMode;
        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetClampOutput;
    }
}