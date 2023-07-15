// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop"]/*'/>
[Guid("CFA688F0-639E-4A47-83D7-6B7F5EBF7FED")]
[NativeTypeName("struct IHolographicQuadLayerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IHolographicQuadLayerInterop : IHolographicQuadLayerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHolographicQuadLayerInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, Guid*, void**, int> )(lpVtbl[0]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint> )(lpVtbl[1]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint> )(lpVtbl[2]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, HSTRING*, int> )(lpVtbl[4]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, TrustLevel*, int> )(lpVtbl[5]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop.CreateDirect3D12ContentBufferResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDirect3D12ContentBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12Resource** ppTexture2DResource)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12Resource**, int> )(lpVtbl[6]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, ppTexture2DResource);
    }

    /// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop.CreateDirect3D12HardwareProtectedContentBufferResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDirect3D12HardwareProtectedContentBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ID3D12Resource** ppCreatedTexture2DResource)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12ProtectedResourceSession*, ID3D12Resource**, int> )(lpVtbl[7]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, pProtectedResourceSession, ppCreatedTexture2DResource);
    }

    /// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop.AcquireDirect3D12BufferResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AcquireDirect3D12BufferResource(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, ID3D12CommandQueue*, int> )(lpVtbl[8]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue);
    }

    /// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop.AcquireDirect3D12BufferResourceWithTimeout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AcquireDirect3D12BufferResourceWithTimeout(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue, [NativeTypeName("UINT64")] ulong duration)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, ID3D12CommandQueue*, ulong, int> )(lpVtbl[9]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue, duration);
    }

    /// <include file='IHolographicQuadLayerInterop.xml' path='doc/member[@name="IHolographicQuadLayerInterop.UnacquireDirect3D12BufferResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UnacquireDirect3D12BufferResource(ID3D12Resource* pResourceToUnacquire)
    {
        return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, int> )(lpVtbl[10]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToUnacquire);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDirect3D12ContentBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12Resource** ppTexture2DResource);
        [VtblIndex(7)]
        HRESULT CreateDirect3D12HardwareProtectedContentBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ID3D12Resource** ppCreatedTexture2DResource);
        [VtblIndex(8)]
        HRESULT AcquireDirect3D12BufferResource(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue);
        [VtblIndex(9)]
        HRESULT AcquireDirect3D12BufferResourceWithTimeout(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue, [NativeTypeName("UINT64")] ulong duration);
        [VtblIndex(10)]
        HRESULT UnacquireDirect3D12BufferResource(ID3D12Resource* pResourceToUnacquire);
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
        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;
        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;
        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;
        [NativeTypeName("HRESULT (ID3D12Device *, D3D12_RESOURCE_DESC *, ID3D12Resource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12Resource**, int> CreateDirect3D12ContentBufferResource;
        [NativeTypeName("HRESULT (ID3D12Device *, D3D12_RESOURCE_DESC *, ID3D12ProtectedResourceSession *, ID3D12Resource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12ProtectedResourceSession*, ID3D12Resource**, int> CreateDirect3D12HardwareProtectedContentBufferResource;
        [NativeTypeName("HRESULT (ID3D12Resource *, ID3D12CommandQueue *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ID3D12CommandQueue*, int> AcquireDirect3D12BufferResource;
        [NativeTypeName("HRESULT (ID3D12Resource *, ID3D12CommandQueue *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ID3D12CommandQueue*, ulong, int> AcquireDirect3D12BufferResourceWithTimeout;
        [NativeTypeName("HRESULT (ID3D12Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, int> UnacquireDirect3D12BufferResource;
    }
}