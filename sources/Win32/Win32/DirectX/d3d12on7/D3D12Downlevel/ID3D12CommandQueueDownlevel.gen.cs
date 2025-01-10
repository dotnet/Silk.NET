// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12Downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("38A8C5EF-7CCB-4E81-914F-A6E9D072C494")]
[NativeTypeName("struct ID3D12CommandQueueDownlevel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CommandQueueDownlevel
    : ID3D12CommandQueueDownlevel.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12CommandQueueDownlevel));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12CommandQueueDownlevel, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12CommandQueueDownlevel, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present(
        ID3D12GraphicsCommandList pOpenCommandList,
        ID3D12Resource pSourceTex2D,
        HWND hWindow,
        D3D12_DOWNLEVEL_PRESENT_FLAGS Flags
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12CommandQueueDownlevel,
                ID3D12GraphicsCommandList,
                ID3D12Resource,
                HWND,
                D3D12_DOWNLEVEL_PRESENT_FLAGS,
                int>)((*lpVtbl)[3])
        )(this, pOpenCommandList, pSourceTex2D, hWindow, Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Present(
            ID3D12GraphicsCommandList pOpenCommandList,
            ID3D12Resource pSourceTex2D,
            HWND hWindow,
            D3D12_DOWNLEVEL_PRESENT_FLAGS Flags
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
            "HRESULT (ID3D12GraphicsCommandList *, ID3D12Resource *, HWND, D3D12_DOWNLEVEL_PRESENT_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12GraphicsCommandList,
            ID3D12Resource,
            HWND,
            D3D12_DOWNLEVEL_PRESENT_FLAGS,
            int> Present;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12CommandQueueDownlevel"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CommandQueueDownlevel(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12CommandQueueDownlevel"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueueDownlevel(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12CommandQueueDownlevel(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12CommandQueueDownlevel"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueueDownlevel"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12CommandQueueDownlevel value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
