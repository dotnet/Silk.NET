// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionVisual2.xml' path='doc/member[@name="IDCompositionVisual2"]/*'/>
[Guid("E8DE1639-4331-4B26-BC5F-6A321D347A85")]
[NativeTypeName("struct IDCompositionVisual2 : IDCompositionVisual")]
[NativeInheritance("IDCompositionVisual")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDCompositionVisual2 : IDCompositionVisual2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, uint> )(lpVtbl[1]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, uint> )(lpVtbl[2]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetOffsetX"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOffsetX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetOffsetX"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffsetX(float offsetX)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, float, int> )(lpVtbl[4]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetX);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetOffsetY"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOffsetY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetOffsetY"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetOffsetY(float offsetY)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, float, int> )(lpVtbl[6]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetY);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTransform(IDCompositionTransform* transform)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionTransform*, int> )(lpVtbl[7]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, D2D_MATRIX_3X2_F*, int> )(lpVtbl[8]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), matrix);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetTransformParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransformParent(IDCompositionVisual* visual)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionVisual*, int> )(lpVtbl[9]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetEffect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEffect(IDCompositionEffect* effect)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionEffect*, int> )(lpVtbl[10]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), effect);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetBitmapInterpolationMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int> )(lpVtbl[11]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), interpolationMode);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetBorderMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, DCOMPOSITION_BORDER_MODE, int> )(lpVtbl[12]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), borderMode);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetClip"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetClip(IDCompositionClip* clip)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionClip*, int> )(lpVtbl[13]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), clip);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetClip"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, D2D_RECT_F*, int> )(lpVtbl[14]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), rect);
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetContent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetContent(IUnknown* content)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IUnknown*, int> )(lpVtbl[15]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), content);
    }

    /// <inheritdoc cref = "IDCompositionVisual.AddVisual"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddVisual(IDCompositionVisual* visual, BOOL insertAbove, IDCompositionVisual* referenceVisual)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int> )(lpVtbl[16]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
    }

    /// <inheritdoc cref = "IDCompositionVisual.RemoveVisual"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RemoveVisual(IDCompositionVisual* visual)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, IDCompositionVisual*, int> )(lpVtbl[17]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
    }

    /// <inheritdoc cref = "IDCompositionVisual.RemoveAllVisuals"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveAllVisuals()
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, int> )(lpVtbl[18]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionVisual.SetCompositeMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, DCOMPOSITION_COMPOSITE_MODE, int> )(lpVtbl[19]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), compositeMode);
    }

    /// <include file='IDCompositionVisual2.xml' path='doc/member[@name="IDCompositionVisual2.SetOpacityMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, DCOMPOSITION_OPACITY_MODE, int> )(lpVtbl[20]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IDCompositionVisual2.xml' path='doc/member[@name="IDCompositionVisual2.SetBackFaceVisibility"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
    {
        return ((delegate* unmanaged<IDCompositionVisual2*, DCOMPOSITION_BACKFACE_VISIBILITY, int> )(lpVtbl[21]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visibility);
    }

    public interface Interface : IDCompositionVisual.Interface
    {
        [VtblIndex(20)]
        HRESULT SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode);
        [VtblIndex(21)]
        HRESULT SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility);
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
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetOffsetX;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetX1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetOffsetY;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetY1;
        [NativeTypeName("HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTransform*, int> SetTransform;
        [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransform1;
        [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionVisual*, int> SetTransformParent;
        [NativeTypeName("HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionEffect*, int> SetEffect;
        [NativeTypeName("HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int> SetBitmapInterpolationMode;
        [NativeTypeName("HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_BORDER_MODE, int> SetBorderMode;
        [NativeTypeName("HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionClip*, int> SetClip;
        [NativeTypeName("HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, int> SetClip1;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetContent;
        [NativeTypeName("HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int> AddVisual;
        [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionVisual*, int> RemoveVisual;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllVisuals;
        [NativeTypeName("HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_COMPOSITE_MODE, int> SetCompositeMode;
        [NativeTypeName("HRESULT (DCOMPOSITION_OPACITY_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_OPACITY_MODE, int> SetOpacityMode;
        [NativeTypeName("HRESULT (DCOMPOSITION_BACKFACE_VISIBILITY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_BACKFACE_VISIBILITY, int> SetBackFaceVisibility;
    }
}