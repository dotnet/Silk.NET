// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush"]/*'/>
[Guid("2CD906AB-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1LinearGradientBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1LinearGradientBrush : ID2D1LinearGradientBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1LinearGradientBrush));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1LinearGradientBrush*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1LinearGradientBrush*, uint> )(lpVtbl[1]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1LinearGradientBrush*, uint> )(lpVtbl[2]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref = "ID2D1Brush.SetOpacity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, float, void> )(lpVtbl[4]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), opacity);
    }

    /// <inheritdoc cref = "ID2D1Brush.SetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void> )(lpVtbl[5]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref = "ID2D1Brush.GetOpacity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public float GetOpacity()
    {
        return ((delegate* unmanaged<ID2D1LinearGradientBrush*, float> )(lpVtbl[6]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Brush.GetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void> )(lpVtbl[7]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush.SetStartPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_POINT_2F, void> )(lpVtbl[8]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), startPoint);
    }

    /// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush.SetEndPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_POINT_2F, void> )(lpVtbl[9]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), endPoint);
    }

    /// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush.GetStartPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F GetStartPoint()
    {
        D2D_POINT_2F result;
        return *((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*> )(lpVtbl[10]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush.GetEndPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F GetEndPoint()
    {
        D2D_POINT_2F result;
        return *((delegate* unmanaged<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*> )(lpVtbl[11]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1LinearGradientBrush.xml' path='doc/member[@name="ID2D1LinearGradientBrush.GetGradientStopCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection)
    {
        ((delegate* unmanaged<ID2D1LinearGradientBrush*, ID2D1GradientStopCollection**, void> )(lpVtbl[12]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), gradientStopCollection);
    }

    public interface Interface : ID2D1Brush.Interface
    {
        [VtblIndex(8)]
        void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint);
        [VtblIndex(9)]
        void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint);
        [VtblIndex(10)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        D2D_POINT_2F GetStartPoint();
        [VtblIndex(11)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        D2D_POINT_2F GetEndPoint();
        [VtblIndex(12)]
        void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection);
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
        [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, void> SetStartPoint;
        [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, void> SetEndPoint;
        [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, D2D_POINT_2F*> GetStartPoint;
        [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, D2D_POINT_2F*> GetEndPoint;
        [NativeTypeName("void (ID2D1GradientStopCollection **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1GradientStopCollection**, void> GetGradientStopCollection;
    }
}