// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect"]/*'/>
[Guid("0B74B9E8-CDD6-492F-BBBC-5ED32157026D")]
[NativeTypeName("struct IDCompositionAffineTransform2DEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionAffineTransform2DEffect : IDCompositionAffineTransform2DEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAffineTransform2DEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, uint> )(lpVtbl[1]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, uint> )(lpVtbl[2]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionFilterEffect.SetInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetInterpolationMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE, int> )(lpVtbl[4]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), interpolationMode);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetBorderMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBorderMode(D2D1_BORDER_MODE borderMode)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, D2D1_BORDER_MODE, int> )(lpVtbl[5]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), borderMode);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetTransformMatrix"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTransformMatrix([NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, D2D_MATRIX_3X2_F*, int> )(lpVtbl[6]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), transformMatrix);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetTransformMatrixElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTransformMatrixElement(int row, int column, IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, int, int, IDCompositionAnimation*, int> )(lpVtbl[7]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, animation);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetTransformMatrixElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransformMatrixElement(int row, int column, float value)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, int, int, float, int> )(lpVtbl[8]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, value);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetSharpness"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSharpness(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, IDCompositionAnimation*, int> )(lpVtbl[9]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionAffineTransform2DEffect.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect.SetSharpness"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSharpness(float sharpness)
    {
        return ((delegate* unmanaged<IDCompositionAffineTransform2DEffect*, float, int> )(lpVtbl[10]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), sharpness);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode);
        [VtblIndex(5)]
        HRESULT SetBorderMode(D2D1_BORDER_MODE borderMode);
        [VtblIndex(6)]
        HRESULT SetTransformMatrix([NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix);
        [VtblIndex(7)]
        HRESULT SetTransformMatrixElement(int row, int column, IDCompositionAnimation* animation);
        [VtblIndex(8)]
        HRESULT SetTransformMatrixElement(int row, int column, float value);
        [VtblIndex(9)]
        HRESULT SetSharpness(IDCompositionAnimation* animation);
        [VtblIndex(10)]
        HRESULT SetSharpness(float sharpness);
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
        [NativeTypeName("HRESULT (D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE, int> SetInterpolationMode;
        [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BORDER_MODE, int> SetBorderMode;
        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransformMatrix;
        [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation*, int> SetTransformMatrixElement;
        [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetTransformMatrixElement1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetSharpness;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetSharpness1;
    }
}