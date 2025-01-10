// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("4D93059D-097B-4651-9A60-F0F25116E2F3")]
[NativeTypeName("struct IDCompositionVisual : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionVisual : IDCompositionVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionVisual, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionVisual, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionVisual, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOffsetX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, IDCompositionAnimation, int>)((*lpVtbl)[3])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffsetX(float offsetX)
    {
        return ((delegate* unmanaged<IDCompositionVisual, float, int>)((*lpVtbl)[4]))(
            this,
            offsetX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOffsetY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, IDCompositionAnimation, int>)((*lpVtbl)[5])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetOffsetY(float offsetY)
    {
        return ((delegate* unmanaged<IDCompositionVisual, float, int>)((*lpVtbl)[6]))(
            this,
            offsetY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTransform(IDCompositionTransform transform)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, IDCompositionTransform, int>)((*lpVtbl)[7])
        )(this, transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform(
        [NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix
    )
    {
        return ((delegate* unmanaged<IDCompositionVisual, D2D_MATRIX_3X2_F*, int>)((*lpVtbl)[8]))(
            this,
            matrix
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransformParent(IDCompositionVisual visual)
    {
        return ((delegate* unmanaged<IDCompositionVisual, IDCompositionVisual, int>)((*lpVtbl)[9]))(
            this,
            visual
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEffect(IDCompositionEffect effect)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, IDCompositionEffect, int>)((*lpVtbl)[10])
        )(this, effect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBitmapInterpolationMode(
        DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode
    )
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(
                (*lpVtbl)[11]
            )
        )(this, interpolationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, DCOMPOSITION_BORDER_MODE, int>)((*lpVtbl)[12])
        )(this, borderMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetClip(IDCompositionClip clip)
    {
        return ((delegate* unmanaged<IDCompositionVisual, IDCompositionClip, int>)((*lpVtbl)[13]))(
            this,
            clip
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
    {
        return ((delegate* unmanaged<IDCompositionVisual, D2D_RECT_F*, int>)((*lpVtbl)[14]))(
            this,
            rect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetContent(IUnknown content)
    {
        return ((delegate* unmanaged<IDCompositionVisual, IUnknown, int>)((*lpVtbl)[15]))(
            this,
            content
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddVisual(
        IDCompositionVisual visual,
        BOOL insertAbove,
        IDCompositionVisual referenceVisual
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionVisual,
                IDCompositionVisual,
                BOOL,
                IDCompositionVisual,
                int>)((*lpVtbl)[16])
        )(this, visual, insertAbove, referenceVisual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RemoveVisual(IDCompositionVisual visual)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, IDCompositionVisual, int>)((*lpVtbl)[17])
        )(this, visual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveAllVisuals()
    {
        return ((delegate* unmanaged<IDCompositionVisual, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
    {
        return (
            (delegate* unmanaged<IDCompositionVisual, DCOMPOSITION_COMPOSITE_MODE, int>)(
                (*lpVtbl)[19]
            )
        )(this, compositeMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOffsetX(IDCompositionAnimation animation);

        [VtblIndex(4)]
        HRESULT SetOffsetX(float offsetX);

        [VtblIndex(5)]
        HRESULT SetOffsetY(IDCompositionAnimation animation);

        [VtblIndex(6)]
        HRESULT SetOffsetY(float offsetY);

        [VtblIndex(7)]
        HRESULT SetTransform(IDCompositionTransform transform);

        [VtblIndex(8)]
        HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix);

        [VtblIndex(9)]
        HRESULT SetTransformParent(IDCompositionVisual visual);

        [VtblIndex(10)]
        HRESULT SetEffect(IDCompositionEffect effect);

        [VtblIndex(11)]
        HRESULT SetBitmapInterpolationMode(
            DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode
        );

        [VtblIndex(12)]
        HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode);

        [VtblIndex(13)]
        HRESULT SetClip(IDCompositionClip clip);

        [VtblIndex(14)]
        HRESULT SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect);

        [VtblIndex(15)]
        HRESULT SetContent(IUnknown content);

        [VtblIndex(16)]
        HRESULT AddVisual(
            IDCompositionVisual visual,
            BOOL insertAbove,
            IDCompositionVisual referenceVisual
        );

        [VtblIndex(17)]
        HRESULT RemoveVisual(IDCompositionVisual visual);

        [VtblIndex(18)]
        HRESULT RemoveAllVisuals();

        [VtblIndex(19)]
        HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode);
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

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetOffsetX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetOffsetY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetY1;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionTransform, int> SetTransform;

        [NativeTypeName(
            "HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransform1;

        [NativeTypeName(
            "HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionVisual, int> SetTransformParent;

        [NativeTypeName(
            "HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionEffect, int> SetEffect;

        [NativeTypeName(
            "HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DCOMPOSITION_BITMAP_INTERPOLATION_MODE,
            int> SetBitmapInterpolationMode;

        [NativeTypeName(
            "HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_BORDER_MODE, int> SetBorderMode;

        [NativeTypeName(
            "HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionClip, int> SetClip;

        [NativeTypeName(
            "HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, int> SetClip1;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetContent;

        [NativeTypeName(
            "HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionVisual,
            BOOL,
            IDCompositionVisual,
            int> AddVisual;

        [NativeTypeName(
            "HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionVisual, int> RemoveVisual;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllVisuals;

        [NativeTypeName(
            "HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_COMPOSITE_MODE, int> SetCompositeMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionVisual"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionVisual(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionVisual"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionVisual(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionVisual(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionVisual"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionVisual"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionVisual value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
