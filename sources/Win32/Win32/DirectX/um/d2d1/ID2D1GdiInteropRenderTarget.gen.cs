// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("E0DB51C3-6F77-4BAE-B3D5-E47509B35838")]
[NativeTypeName("struct ID2D1GdiInteropRenderTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1GdiInteropRenderTarget
    : ID2D1GdiInteropRenderTarget.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiInteropRenderTarget));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID2D1GdiInteropRenderTarget, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, HDC* hdc)
    {
        return (
            (delegate* unmanaged<ID2D1GdiInteropRenderTarget, D2D1_DC_INITIALIZE_MODE, HDC*, int>)(
                (*lpVtbl)[3]
            )
        )(this, mode, hdc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseDC([NativeTypeName("const RECT *")] RECT* update)
    {
        return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget, RECT*, int>)((*lpVtbl)[4]))(
            this,
            update
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, HDC* hdc);

        [VtblIndex(4)]
        HRESULT ReleaseDC([NativeTypeName("const RECT *")] RECT* update);
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
            "HRESULT (D2D1_DC_INITIALIZE_MODE, HDC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_DC_INITIALIZE_MODE, HDC*, int> GetDC;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> ReleaseDC;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1GdiInteropRenderTarget"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1GdiInteropRenderTarget(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1GdiInteropRenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1GdiInteropRenderTarget(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1GdiInteropRenderTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiInteropRenderTarget"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiInteropRenderTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1GdiInteropRenderTarget value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
