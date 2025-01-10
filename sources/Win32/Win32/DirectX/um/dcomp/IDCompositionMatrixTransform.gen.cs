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

[Guid("16CDFF07-C503-419C-83F2-0965C7AF1FA6")]
[NativeTypeName("struct IDCompositionMatrixTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionMatrixTransform
    : IDCompositionMatrixTransform.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionMatrixTransform, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
    {
        return (
            (delegate* unmanaged<IDCompositionMatrixTransform, D2D_MATRIX_3X2_F*, int>)(
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
                IDCompositionMatrixTransform,
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
            (delegate* unmanaged<IDCompositionMatrixTransform, int, int, float, int>)((*lpVtbl)[5])
        )(this, row, column, value);
    }

    public interface Interface : IDCompositionTransform.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix);

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
            "HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetMatrix;

        [NativeTypeName(
            "HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation, int> SetMatrixElement;

        [NativeTypeName(
            "HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetMatrixElement1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionMatrixTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionMatrixTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionTransform"/> to <see cref = "IDCompositionMatrixTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionTransform"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform(
        Silk.NET.DirectX.IDCompositionTransform value
    )
    {
        return new IDCompositionMatrixTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionTransform"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionTransform(
        IDCompositionMatrixTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionTransform(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> to <see cref = "IDCompositionMatrixTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform(
        Silk.NET.DirectX.IDCompositionTransform3D value
    )
    {
        return new IDCompositionMatrixTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionTransform3D(
        IDCompositionMatrixTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionTransform3D(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionMatrixTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionMatrixTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionMatrixTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionMatrixTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionMatrixTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionMatrixTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionMatrixTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionMatrixTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionMatrixTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
