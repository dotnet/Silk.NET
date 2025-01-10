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

[Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
public unsafe partial struct IDxcResult : IDxcResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged<IDxcResult, HRESULT*, int>)((*lpVtbl)[3]))(this, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob* ppResult)
    {
        return ((delegate* unmanaged<IDxcResult, IDxcBlob*, int>)((*lpVtbl)[4]))(this, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding* ppErrors)
    {
        return ((delegate* unmanaged<IDxcResult, IDxcBlobEncoding*, int>)((*lpVtbl)[5]))(
            this,
            ppErrors
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        return ((delegate* unmanaged<IDxcResult, DXC_OUT_KIND, int>)((*lpVtbl)[6]))(
            this,
            dxcOutKind
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutput(
        DXC_OUT_KIND dxcOutKind,
        [NativeTypeName("const IID &")] Guid* iid,
        void** ppvObject,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputName
    )
    {
        return (
            (delegate* unmanaged<IDxcResult, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16*, int>)(
                (*lpVtbl)[7]
            )
        )(this, dxcOutKind, iid, ppvObject, ppOutputName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        return ((delegate* unmanaged<IDxcResult, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        return ((delegate* unmanaged<IDxcResult, uint, DXC_OUT_KIND>)((*lpVtbl)[9]))(this, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        return ((delegate* unmanaged<IDxcResult, DXC_OUT_KIND>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IDxcOperationResult.Interface
    {
        [VtblIndex(6)]
        BOOL HasOutput(DXC_OUT_KIND dxcOutKind);

        [VtblIndex(7)]
        HRESULT GetOutput(
            DXC_OUT_KIND dxcOutKind,
            [NativeTypeName("const IID &")] Guid* iid,
            void** ppvObject,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppOutputName
        );

        [VtblIndex(8)]
        [return: NativeTypeName("UINT32")]
        uint GetNumOutputs();

        [VtblIndex(9)]
        DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index);

        [VtblIndex(10)]
        DXC_OUT_KIND PrimaryOutput();
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

        [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXC_OUT_KIND, int> HasOutput;

        [NativeTypeName(
            "HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobWide **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXC_OUT_KIND,
            Guid*,
            void**,
            IDxcBlobUtf16*,
            int> GetOutput;

        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged<TSelf*, uint> GetNumOutputs;

        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public delegate* unmanaged<TSelf*, uint, DXC_OUT_KIND> GetOutputByIndex;

        [NativeTypeName("DXC_OUT_KIND ()")]
        public delegate* unmanaged<TSelf*, DXC_OUT_KIND> PrimaryOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcOperationResult"/> to <see cref = "IDxcResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcOperationResult"/> instance to be converted </param>
    public static explicit operator IDxcResult(Silk.NET.DirectX.IDxcOperationResult value)
    {
        return new IDxcResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcResult"/> to <see cref = "Silk.NET.DirectX.IDxcOperationResult"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcOperationResult(IDxcResult value)
    {
        return new Silk.NET.DirectX.IDxcOperationResult(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcResult(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
