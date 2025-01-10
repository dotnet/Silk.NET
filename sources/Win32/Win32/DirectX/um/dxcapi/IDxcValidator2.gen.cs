// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("458E1FD1-B1B2-4750-A6E1-9C10F03BED92")]
[NativeTypeName("struct IDxcValidator2 : IDxcValidator")]
[NativeInheritance("IDxcValidator")]
public unsafe partial struct IDxcValidator2 : IDxcValidator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcValidator2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcValidator2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcValidator2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcValidator2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Validate(
        IDxcBlob pShader,
        [NativeTypeName("UINT32")] uint Flags,
        IDxcOperationResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDxcValidator2, IDxcBlob, uint, IDxcOperationResult*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pShader, Flags, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ValidateWithDebug(
        IDxcBlob pShader,
        [NativeTypeName("UINT32")] uint Flags,
        DxcBuffer* pOptDebugBitcode,
        IDxcOperationResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDxcValidator2,
                IDxcBlob,
                uint,
                DxcBuffer*,
                IDxcOperationResult*,
                int>)((*lpVtbl)[4])
        )(this, pShader, Flags, pOptDebugBitcode, ppResult);
    }

    public interface Interface : IDxcValidator.Interface
    {
        [VtblIndex(4)]
        HRESULT ValidateWithDebug(
            IDxcBlob pShader,
            [NativeTypeName("UINT32")] uint Flags,
            DxcBuffer* pOptDebugBitcode,
            IDxcOperationResult* ppResult
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
            "HRESULT (IDxcBlob *, UINT32, IDxcOperationResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDxcBlob, uint, IDxcOperationResult*, int> Validate;

        [NativeTypeName(
            "HRESULT (IDxcBlob *, UINT32, DxcBuffer *, IDxcOperationResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDxcBlob,
            uint,
            DxcBuffer*,
            IDxcOperationResult*,
            int> ValidateWithDebug;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcValidator2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcValidator2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcValidator"/> to <see cref = "IDxcValidator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcValidator"/> instance to be converted </param>
    public static explicit operator IDxcValidator2(Silk.NET.DirectX.IDxcValidator value)
    {
        return new IDxcValidator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcValidator2"/> to <see cref = "Silk.NET.DirectX.IDxcValidator"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcValidator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcValidator(IDxcValidator2 value)
    {
        return new Silk.NET.DirectX.IDxcValidator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcValidator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcValidator2(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcValidator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcValidator2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcValidator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcValidator2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
