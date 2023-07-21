// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch"]/*' />
[Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
[NativeTypeName("struct ID2D1SpriteBatch : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SpriteBatch : ID2D1SpriteBatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SpriteBatch));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[1]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[2]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SpriteBatch*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch.AddSprites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int>)(lpVtbl[4]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch.SetSprites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int>)(lpVtbl[5]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch.GetSprites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null)
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[6]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
    }

    /// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch.GetSpriteCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT32")]
    public uint GetSpriteCount()
    {
        return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[7]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SpriteBatch.xml' path='doc/member[@name="ID2D1SpriteBatch.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Clear()
    {
        ((delegate* unmanaged<ID2D1SpriteBatch*, void>)(lpVtbl[8]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        HRESULT AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        [VtblIndex(5)]
        HRESULT SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        [VtblIndex(6)]
        HRESULT GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null);

        [VtblIndex(7)]
        [return: NativeTypeName("UINT32")]
        uint GetSpriteCount();

        [VtblIndex(8)]
        void Clear();
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

        [NativeTypeName("HRESULT (UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int> AddSprites;

        [NativeTypeName("HRESULT (UINT32, UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int> SetSprites;

        [NativeTypeName("HRESULT (UINT32, UINT32, D2D1_RECT_F *, D2D1_RECT_U *, D2D1_COLOR_F *, D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, int> GetSprites;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSpriteCount;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Clear;
    }
}
