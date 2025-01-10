// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
[NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SwapChainAssistant
    : ID3D12SwapChainAssistant.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SwapChainAssistant));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12SwapChainAssistant, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public LUID GetLUID()
    {
        LUID result;
        return *((delegate* unmanaged<ID3D12SwapChainAssistant, LUID*, LUID*>)((*lpVtbl)[3]))(
            this,
            &result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant, Guid*, void**, int>)((*lpVtbl)[4]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentResourceAndCommandQueue(
        [NativeTypeName("const IID &")] Guid* riidResource,
        void** ppvResource,
        [NativeTypeName("const IID &")] Guid* riidQueue,
        void** ppvQueue
    )
    {
        return (
            (delegate* unmanaged<ID3D12SwapChainAssistant, Guid*, void**, Guid*, void**, int>)(
                (*lpVtbl)[5]
            )
        )(this, riidResource, ppvResource, riidQueue, ppvQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertImplicitSync()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        LUID GetLUID();

        [VtblIndex(4)]
        HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT GetCurrentResourceAndCommandQueue(
            [NativeTypeName("const IID &")] Guid* riidResource,
            void** ppvResource,
            [NativeTypeName("const IID &")] Guid* riidQueue,
            void** ppvQueue
        );

        [VtblIndex(6)]
        HRESULT InsertImplicitSync();
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

        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID*, LUID*> GetLUID;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetSwapChainObject;

        [NativeTypeName(
            "HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            void**,
            Guid*,
            void**,
            int> GetCurrentResourceAndCommandQueue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InsertImplicitSync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12SwapChainAssistant"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12SwapChainAssistant(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12SwapChainAssistant"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12SwapChainAssistant(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12SwapChainAssistant(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12SwapChainAssistant"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12SwapChainAssistant"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12SwapChainAssistant value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
