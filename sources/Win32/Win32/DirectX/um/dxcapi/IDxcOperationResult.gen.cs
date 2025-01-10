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

[Guid("CEDB484A-D4E9-445A-B991-CA21CA157DC2")]
[NativeTypeName("struct IDxcOperationResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOperationResult : IDxcOperationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOperationResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcOperationResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcOperationResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcOperationResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged<IDxcOperationResult, HRESULT*, int>)((*lpVtbl)[3]))(
            this,
            pStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob* ppResult)
    {
        return ((delegate* unmanaged<IDxcOperationResult, IDxcBlob*, int>)((*lpVtbl)[4]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding* ppErrors)
    {
        return ((delegate* unmanaged<IDxcOperationResult, IDxcBlobEncoding*, int>)((*lpVtbl)[5]))(
            this,
            ppErrors
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStatus(HRESULT* pStatus);

        [VtblIndex(4)]
        HRESULT GetResult(IDxcBlob* ppResult);

        [VtblIndex(5)]
        HRESULT GetErrorBuffer(IDxcBlobEncoding* ppErrors);
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

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobEncoding*, int> GetErrorBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcOperationResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcOperationResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcOperationResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcOperationResult(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcOperationResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcOperationResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcOperationResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcOperationResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
