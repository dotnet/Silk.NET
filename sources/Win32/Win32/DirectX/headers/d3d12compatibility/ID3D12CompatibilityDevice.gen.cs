// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice"]/*'/>
[Guid("8F1C0E3C-FAE3-4A82-B098-BFE1708207FF")]
[NativeTypeName("struct ID3D12CompatibilityDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CompatibilityDevice
    : ID3D12CompatibilityDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12CompatibilityDevice));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12CompatibilityDevice*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<ID3D12CompatibilityDevice*, uint>)(lpVtbl[1]))(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12CompatibilityDevice*, uint>)(lpVtbl[2]))(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedResource"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSharedResource(
        [NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties,
        D3D12_HEAP_FLAGS HeapFlags,
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc,
        D3D12_RESOURCE_STATES InitialResourceState,
        [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue,
        [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11,
        D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags,
        ID3D12LifetimeTracker* pLifetimeTracker,
        ID3D12SwapChainAssistant* pOwningSwapchain,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppResource
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12CompatibilityDevice*,
                D3D12_HEAP_PROPERTIES*,
                D3D12_HEAP_FLAGS,
                D3D12_RESOURCE_DESC*,
                D3D12_RESOURCE_STATES,
                D3D12_CLEAR_VALUE*,
                D3D11_RESOURCE_FLAGS*,
                D3D12_COMPATIBILITY_SHARED_FLAGS,
                ID3D12LifetimeTracker*,
                ID3D12SwapChainAssistant*,
                Guid*,
                void**,
                int>)(lpVtbl[3])
        )(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this),
            pHeapProperties,
            HeapFlags,
            pDesc,
            InitialResourceState,
            pOptimizedClearValue,
            pFlags11,
            CompatibilityFlags,
            pLifetimeTracker,
            pOwningSwapchain,
            riid,
            ppResource
        );
    }

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.CreateSharedHeap"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateSharedHeap(
        [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pHeapDesc,
        D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppHeap
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12CompatibilityDevice*,
                D3D12_HEAP_DESC*,
                D3D12_COMPATIBILITY_SHARED_FLAGS,
                Guid*,
                void**,
                int>)(lpVtbl[4])
        )(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this),
            pHeapDesc,
            CompatibilityFlags,
            riid,
            ppHeap
        );
    }

    /// <include file='ID3D12CompatibilityDevice.xml' path='doc/member[@name="ID3D12CompatibilityDevice.ReflectSharedProperties"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReflectSharedProperties(
        ID3D12Object* pHeapOrResource,
        D3D12_REFLECT_SHARED_PROPERTY ReflectType,
        void* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12CompatibilityDevice*,
                ID3D12Object*,
                D3D12_REFLECT_SHARED_PROPERTY,
                void*,
                uint,
                int>)(lpVtbl[5])
        )(
            (ID3D12CompatibilityDevice*)Unsafe.AsPointer(ref this),
            pHeapOrResource,
            ReflectType,
            pData,
            DataSize
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSharedResource(
            [NativeTypeName("const D3D12_HEAP_PROPERTIES *")]
                D3D12_HEAP_PROPERTIES* pHeapProperties,
            D3D12_HEAP_FLAGS HeapFlags,
            [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc,
            D3D12_RESOURCE_STATES InitialResourceState,
            [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11,
            D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags,
            ID3D12LifetimeTracker* pLifetimeTracker,
            ID3D12SwapChainAssistant* pOwningSwapchain,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppResource
        );

        [VtblIndex(4)]
        HRESULT CreateSharedHeap(
            [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pHeapDesc,
            D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppHeap
        );

        [VtblIndex(5)]
        HRESULT ReflectSharedProperties(
            ID3D12Object* pHeapOrResource,
            D3D12_REFLECT_SHARED_PROPERTY ReflectType,
            void* pData,
            uint DataSize
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
            "HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const D3D11_RESOURCE_FLAGS *, D3D12_COMPATIBILITY_SHARED_FLAGS, ID3D12LifetimeTracker *, ID3D12SwapChainAssistant *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_HEAP_PROPERTIES*,
            D3D12_HEAP_FLAGS,
            D3D12_RESOURCE_DESC*,
            D3D12_RESOURCE_STATES,
            D3D12_CLEAR_VALUE*,
            D3D11_RESOURCE_FLAGS*,
            D3D12_COMPATIBILITY_SHARED_FLAGS,
            ID3D12LifetimeTracker*,
            ID3D12SwapChainAssistant*,
            Guid*,
            void**,
            int> CreateSharedResource;

        [NativeTypeName(
            "HRESULT (const D3D12_HEAP_DESC *, D3D12_COMPATIBILITY_SHARED_FLAGS, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_HEAP_DESC*,
            D3D12_COMPATIBILITY_SHARED_FLAGS,
            Guid*,
            void**,
            int> CreateSharedHeap;

        [NativeTypeName(
            "HRESULT (ID3D12Object *, D3D12_REFLECT_SHARED_PROPERTY, void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Object*,
            D3D12_REFLECT_SHARED_PROPERTY,
            void*,
            uint,
            int> ReflectSharedProperties;
    }
}
