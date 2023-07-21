// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush"]/*' />
[Guid("FE9E984D-3F95-407C-B5DB-CB94D4E8F87C")]
[NativeTypeName("struct ID2D1ImageBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1ImageBrush : ID2D1ImageBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageBrush));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, uint>)(lpVtbl[1]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, uint>)(lpVtbl[2]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref="ID2D1Brush.SetOpacity" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOpacity(float opacity)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, float, void>)(lpVtbl[4]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), opacity);
    }

    /// <inheritdoc cref="ID2D1Brush.SetTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref="ID2D1Brush.GetOpacity" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public float GetOpacity()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, float>)(lpVtbl[6]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Brush.GetTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.SetImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetImage(ID2D1Image* image)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, ID2D1Image*, void>)(lpVtbl[8]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.SetExtendModeX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[9]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeX);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.SetExtendModeY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[10]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeY);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.SetInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_INTERPOLATION_MODE, void>)(lpVtbl[11]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), interpolationMode);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.SetSourceRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetSourceRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D_RECT_F*, void>)(lpVtbl[12]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.GetImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void GetImage(ID2D1Image** image)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, ID2D1Image**, void>)(lpVtbl[13]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.GetExtendModeX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public D2D1_EXTEND_MODE GetExtendModeX()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_EXTEND_MODE>)(lpVtbl[14]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.GetExtendModeY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public D2D1_EXTEND_MODE GetExtendModeY()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_EXTEND_MODE>)(lpVtbl[15]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.GetInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public D2D1_INTERPOLATION_MODE GetInterpolationMode()
    {
        return ((delegate* unmanaged<ID2D1ImageBrush*, D2D1_INTERPOLATION_MODE>)(lpVtbl[16]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ImageBrush.xml' path='doc/member[@name="ID2D1ImageBrush.GetSourceRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void GetSourceRectangle([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
    {
        ((delegate* unmanaged<ID2D1ImageBrush*, D2D_RECT_F*, void>)(lpVtbl[17]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
    }

    public interface Interface : ID2D1Brush.Interface
    {
        [VtblIndex(8)]
        void SetImage(ID2D1Image* image);

        [VtblIndex(9)]
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);

        [VtblIndex(10)]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);

        [VtblIndex(11)]
        void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode);

        [VtblIndex(12)]
        void SetSourceRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle);

        [VtblIndex(13)]
        void GetImage(ID2D1Image** image);

        [VtblIndex(14)]
        D2D1_EXTEND_MODE GetExtendModeX();

        [VtblIndex(15)]
        D2D1_EXTEND_MODE GetExtendModeY();

        [VtblIndex(16)]
        D2D1_INTERPOLATION_MODE GetInterpolationMode();

        [VtblIndex(17)]
        void GetSourceRectangle([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle);
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

        [NativeTypeName("void (ID2D1Image *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Image*, void> SetImage;

        [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeX;

        [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE, void> SetExtendModeY;

        [NativeTypeName("void (D2D1_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INTERPOLATION_MODE, void> SetInterpolationMode;

        [NativeTypeName("void (const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, void> SetSourceRectangle;

        [NativeTypeName("void (ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Image**, void> GetImage;

        [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeX;

        [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_EXTEND_MODE> GetExtendModeY;

        [NativeTypeName("D2D1_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INTERPOLATION_MODE> GetInterpolationMode;

        [NativeTypeName("void (D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, void> GetSourceRectangle;
    }
}
