// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
[NativeTypeName("struct ID3D12SharingContract : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SharingContract : ID3D12SharingContract.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SharingContract));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SharingContract, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12SharingContract, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SharingContract, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Present(ID3D12Resource pResource, uint Subresource, HWND window)
    {
        (
            (delegate* unmanaged<ID3D12SharingContract, ID3D12Resource, uint, HWND, void>)(
                (*lpVtbl)[3]
            )
        )(this, pResource, Subresource, window);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SharedFenceSignal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue)
    {
        ((delegate* unmanaged<ID3D12SharingContract, ID3D12Fence, ulong, void>)((*lpVtbl)[4]))(
            this,
            pFence,
            FenceValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
    {
        ((delegate* unmanaged<ID3D12SharingContract, Guid*, void>)((*lpVtbl)[5]))(this, guid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
    {
        ((delegate* unmanaged<ID3D12SharingContract, Guid*, void>)((*lpVtbl)[6]))(this, guid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Present(ID3D12Resource pResource, uint Subresource, HWND window);

        [VtblIndex(4)]
        void SharedFenceSignal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong FenceValue);

        [VtblIndex(5)]
        void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid);

        [VtblIndex(6)]
        void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid);
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

        [NativeTypeName("void (ID3D12Resource *, UINT, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, uint, HWND, void> Present;

        [NativeTypeName("void (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence, ulong, void> SharedFenceSignal;

        [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> BeginCapturableWork;

        [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> EndCapturableWork;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SharingContract"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SharingContract(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12SharingContract"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12SharingContract(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12SharingContract(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12SharingContract"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SharingContract"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12SharingContract value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
