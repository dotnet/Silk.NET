// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1SolidColorBrush.xml' path='doc/member[@name="ID2D1SolidColorBrush"]/*' />
[Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1SolidColorBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1SolidColorBrush : ID2D1SolidColorBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SolidColorBrush));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SolidColorBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SolidColorBrush*, uint>)(lpVtbl[1]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SolidColorBrush*, uint>)(lpVtbl[2]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SolidColorBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref="ID2D1Brush.SetOpacity" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged<ID2D1SolidColorBrush*, float, void>)(lpVtbl[4]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), opacity);
    }

    /// <inheritdoc cref="ID2D1Brush.SetTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1SolidColorBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref="ID2D1Brush.GetOpacity" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public float GetOpacity()
    {
        return ((delegate* unmanaged<ID2D1SolidColorBrush*, float>)(lpVtbl[6]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Brush.GetTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1SolidColorBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='ID2D1SolidColorBrush.xml' path='doc/member[@name="ID2D1SolidColorBrush.SetColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        ((delegate* unmanaged<ID2D1SolidColorBrush*, DXGI_RGBA*, void>)(lpVtbl[8]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), color);
    }

    /// <include file='ID2D1SolidColorBrush.xml' path='doc/member[@name="ID2D1SolidColorBrush.GetColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("D2D1_COLOR_F")]
    public DXGI_RGBA GetColor()
    {
        DXGI_RGBA result;
        return *((delegate* unmanaged<ID2D1SolidColorBrush*, DXGI_RGBA*, DXGI_RGBA*>)(lpVtbl[9]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), &result);
    }

    public interface Interface : ID2D1Brush.Interface
    {
        [VtblIndex(8)]
        void SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [VtblIndex(9)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        DXGI_RGBA GetColor();
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, void> SetOpacity;

        [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> SetTransform;

        [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetOpacity;

        [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;

        [NativeTypeName("void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, void> SetColor;

        [NativeTypeName("D2D1_COLOR_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, DXGI_RGBA*> GetColor;
    }
}
