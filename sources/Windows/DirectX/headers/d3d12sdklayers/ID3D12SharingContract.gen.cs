// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract"]/*'/>
[Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
[NativeTypeName("struct ID3D12SharingContract : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SharingContract : ID3D12SharingContract.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SharingContract));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[1]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[2]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.Present"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Present(ID3D12Resource* pResource, uint Subresource, HWND window)
    {
        (
            (delegate* unmanaged<ID3D12SharingContract*, ID3D12Resource*, uint, HWND, void>)(
                lpVtbl[3]
            )
        )((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.SharedFenceSignal"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SharedFenceSignal(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue)
    {
        ((delegate* unmanaged<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this),
            pFence,
            FenceValue
        );
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.BeginCapturableWork"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
    {
        ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this),
            guid
        );
    }

    /// <include file='ID3D12SharingContract.xml' path='doc/member[@name="ID3D12SharingContract.EndCapturableWork"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
    {
        ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))(
            (ID3D12SharingContract*)Unsafe.AsPointer(ref this),
            guid
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Present(ID3D12Resource* pResource, uint Subresource, HWND window);

        [VtblIndex(4)]
        void SharedFenceSignal(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue);

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
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, HWND, void> Present;

        [NativeTypeName("void (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence*, ulong, void> SharedFenceSignal;

        [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> BeginCapturableWork;

        [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> EndCapturableWork;
    }
}
