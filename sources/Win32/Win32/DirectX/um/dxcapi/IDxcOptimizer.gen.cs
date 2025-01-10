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

[Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOptimizer : IDxcOptimizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOptimizer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcOptimizer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcOptimizer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcOptimizer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcOptimizer, uint*, int>)((*lpVtbl)[3]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAvailablePass(
        [NativeTypeName("UINT32")] uint index,
        IDxcOptimizerPass* ppResult
    )
    {
        return ((delegate* unmanaged<IDxcOptimizer, uint, IDxcOptimizerPass*, int>)((*lpVtbl)[4]))(
            this,
            index,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RunOptimizer(
        IDxcBlob pBlob,
        [NativeTypeName("LPCWSTR *")] ushort** ppOptions,
        [NativeTypeName("UINT32")] uint optionCount,
        IDxcBlob* pOutputModule,
        IDxcBlobEncoding* ppOutputText
    )
    {
        return (
            (delegate* unmanaged<
                IDxcOptimizer,
                IDxcBlob,
                ushort**,
                uint,
                IDxcBlob*,
                IDxcBlobEncoding*,
                int>)((*lpVtbl)[5])
        )(this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(4)]
        HRESULT GetAvailablePass(
            [NativeTypeName("UINT32")] uint index,
            IDxcOptimizerPass* ppResult
        );

        [VtblIndex(5)]
        HRESULT RunOptimizer(
            IDxcBlob pBlob,
            [NativeTypeName("LPCWSTR *")] ushort** ppOptions,
            [NativeTypeName("UINT32")] uint optionCount,
            IDxcBlob* pOutputModule,
            IDxcBlobEncoding* ppOutputText
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAvailablePassCount;

        [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcOptimizerPass*, int> GetAvailablePass;

        [NativeTypeName(
            "HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDxcBlob,
            ushort**,
            uint,
            IDxcBlob*,
            IDxcBlobEncoding*,
            int> RunOptimizer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcOptimizer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcOptimizer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcOptimizer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcOptimizer(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcOptimizer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcOptimizer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcOptimizer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcOptimizer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
