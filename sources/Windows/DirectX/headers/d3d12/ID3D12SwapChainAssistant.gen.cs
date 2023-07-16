// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant"]/*'/>
[Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
[NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SwapChainAssistant : ID3D12SwapChainAssistant.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SwapChainAssistant));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint> )(lpVtbl[1]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint> )(lpVtbl[2]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetLUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public LUID GetLUID()
    {
        LUID result;
        return *((delegate* unmanaged<ID3D12SwapChainAssistant*, LUID*, LUID*> )(lpVtbl[3]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetSwapChainObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int> )(lpVtbl[4]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.GetCurrentResourceAndCommandQueue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int> )(lpVtbl[5]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
    }

    /// <include file='ID3D12SwapChainAssistant.xml' path='doc/member[@name="ID3D12SwapChainAssistant.InsertImplicitSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertImplicitSync()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, int> )(lpVtbl[6]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        LUID GetLUID();
        [VtblIndex(4)]
        HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(5)]
        HRESULT GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue);
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
        [NativeTypeName("HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, Guid*, void**, int> GetCurrentResourceAndCommandQueue;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InsertImplicitSync;
    }
}