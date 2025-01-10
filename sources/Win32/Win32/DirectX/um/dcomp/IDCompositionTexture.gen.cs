// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("929BB1AA-725F-433B-ABD7-273075A835F2")]
[NativeTypeName("struct IDCompositionTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionTexture : IDCompositionTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTexture));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionTexture, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDCompositionTexture, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTexture, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSourceRect([NativeTypeName("const D2D_RECT_U &")] D2D_RECT_U* sourceRect)
    {
        return ((delegate* unmanaged<IDCompositionTexture, D2D_RECT_U*, int>)((*lpVtbl)[3]))(
            this,
            sourceRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        return (
            (delegate* unmanaged<IDCompositionTexture, DXGI_COLOR_SPACE_TYPE, int>)((*lpVtbl)[4])
        )(this, colorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode)
    {
        return ((delegate* unmanaged<IDCompositionTexture, DXGI_ALPHA_MODE, int>)((*lpVtbl)[5]))(
            this,
            alphaMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableFence(
        [NativeTypeName("UINT64 *")] ulong* fenceValue,
        [NativeTypeName("const IID &")] Guid* iid,
        void** availableFence
    )
    {
        return (
            (delegate* unmanaged<IDCompositionTexture, ulong*, Guid*, void**, int>)((*lpVtbl)[6])
        )(this, fenceValue, iid, availableFence);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSourceRect([NativeTypeName("const D2D_RECT_U &")] D2D_RECT_U* sourceRect);

        [VtblIndex(4)]
        HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace);

        [VtblIndex(5)]
        HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode);

        [VtblIndex(6)]
        HRESULT GetAvailableFence(
            [NativeTypeName("UINT64 *")] ulong* fenceValue,
            [NativeTypeName("const IID &")] Guid* iid,
            void** availableFence
        );
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
            "HRESULT (const D2D_RECT_U &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, int> SetSourceRect;

        [NativeTypeName(
            "HRESULT (DXGI_COLOR_SPACE_TYPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_COLOR_SPACE_TYPE, int> SetColorSpace;

        [NativeTypeName(
            "HRESULT (DXGI_ALPHA_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_ALPHA_MODE, int> SetAlphaMode;

        [NativeTypeName(
            "HRESULT (UINT64 *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong*, Guid*, void**, int> GetAvailableFence;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionTexture"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionTexture(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionTexture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionTexture(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionTexture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionTexture"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionTexture"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionTexture value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
