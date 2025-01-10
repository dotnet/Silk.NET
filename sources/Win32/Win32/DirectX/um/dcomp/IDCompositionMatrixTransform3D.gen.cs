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

[Guid("4B3363F0-643B-41B7-B6E0-CCF22D34467C")]
[NativeTypeName("struct IDCompositionMatrixTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionMatrixTransform3D
    : IDCompositionMatrixTransform3D.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform3D));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionMatrixTransform3D, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix)
    {
        return (
            (delegate* unmanaged<IDCompositionMatrixTransform3D, D2D_MATRIX_4X4_F*, int>)(
                (*lpVtbl)[3]
            )
        )(this, matrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<
                IDCompositionMatrixTransform3D,
                int,
                int,
                IDCompositionAnimation,
                int>)((*lpVtbl)[4])
        )(this, row, column, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMatrixElement(int row, int column, float value)
    {
        return (
            (delegate* unmanaged<IDCompositionMatrixTransform3D, int, int, float, int>)(
                (*lpVtbl)[5]
            )
        )(this, row, column, value);
    }

    public interface Interface : IDCompositionTransform3D.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix);

        [VtblIndex(4)]
        HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation);

        [VtblIndex(5)]
        HRESULT SetMatrixElement(int row, int column, float value);
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
            "HRESULT (const D3DMATRIX &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_4X4_F*, int> SetMatrix;

        [NativeTypeName(
            "HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation, int> SetMatrixElement;

        [NativeTypeName(
            "HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetMatrixElement1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionMatrixTransform3D"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionMatrixTransform3D(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> to <see cref = "IDCompositionMatrixTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform3D(
        Silk.NET.DirectX.IDCompositionTransform3D value
    )
    {
        return new IDCompositionMatrixTransform3D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform3D"/> to <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform3D"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionTransform3D(
        IDCompositionMatrixTransform3D value
    )
    {
        return new Silk.NET.DirectX.IDCompositionTransform3D(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionMatrixTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform3D(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionMatrixTransform3D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform3D"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform3D"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionMatrixTransform3D value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionMatrixTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform3D(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionMatrixTransform3D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform3D"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform3D"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionMatrixTransform3D value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
