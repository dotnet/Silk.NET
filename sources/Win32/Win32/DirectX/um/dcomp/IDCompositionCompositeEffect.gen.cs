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

[Guid("576616C0-A231-494D-A38D-00FD5EC4DB46")]
[NativeTypeName("struct IDCompositionCompositeEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionCompositeEffect
    : IDCompositionCompositeEffect.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionCompositeEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionCompositeEffect, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown input, uint flags)
    {
        return (
            (delegate* unmanaged<IDCompositionCompositeEffect, uint, IUnknown, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, index, input, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMode(D2D1_COMPOSITE_MODE mode)
    {
        return (
            (delegate* unmanaged<IDCompositionCompositeEffect, D2D1_COMPOSITE_MODE, int>)(
                (*lpVtbl)[4]
            )
        )(this, mode);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetMode(D2D1_COMPOSITE_MODE mode);
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
            "HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IUnknown, uint, int> SetInput;

        [NativeTypeName(
            "HRESULT (D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COMPOSITE_MODE, int> SetMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionCompositeEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionCompositeEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> to <see cref = "IDCompositionCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionCompositeEffect(
        Silk.NET.DirectX.IDCompositionFilterEffect value
    )
    {
        return new IDCompositionCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionCompositeEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionFilterEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionFilterEffect(
        IDCompositionCompositeEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionFilterEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionCompositeEffect(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionCompositeEffect"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionCompositeEffect value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionCompositeEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionCompositeEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionCompositeEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionCompositeEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionCompositeEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionCompositeEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
