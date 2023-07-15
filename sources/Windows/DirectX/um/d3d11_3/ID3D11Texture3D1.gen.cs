// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11Texture3D1.xml' path='doc/member[@name="ID3D11Texture3D1"]/*'/>
[Guid("0C711683-2853-4846-9BB0-F3E60639E46A")]
[NativeTypeName("struct ID3D11Texture3D1 : ID3D11Texture3D")]
[NativeInheritance("ID3D11Texture3D")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID3D11Texture3D1 : ID3D11Texture3D1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture3D1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, uint> )(lpVtbl[1]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, uint> )(lpVtbl[2]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11Texture3D1*, ID3D11Device**, void> )(lpVtbl[3]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, Guid*, uint*, void*, int> )(lpVtbl[4]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, Guid*, uint, void*, int> )(lpVtbl[5]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, Guid*, IUnknown*, int> )(lpVtbl[6]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D11Resource.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetType(D3D11_RESOURCE_DIMENSION* pResourceDimension)
    {
        ((delegate* unmanaged<ID3D11Texture3D1*, D3D11_RESOURCE_DIMENSION*, void> )(lpVtbl[7]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pResourceDimension);
    }

    /// <inheritdoc cref = "ID3D11Resource.SetEvictionPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetEvictionPriority(uint EvictionPriority)
    {
        ((delegate* unmanaged<ID3D11Texture3D1*, uint, void> )(lpVtbl[8]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), EvictionPriority);
    }

    /// <inheritdoc cref = "ID3D11Resource.GetEvictionPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetEvictionPriority()
    {
        return ((delegate* unmanaged<ID3D11Texture3D1*, uint> )(lpVtbl[9]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11Texture3D.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void GetDesc(D3D11_TEXTURE3D_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11Texture3D1*, D3D11_TEXTURE3D_DESC*, void> )(lpVtbl[10]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11Texture3D1.xml' path='doc/member[@name="ID3D11Texture3D1.GetDesc1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetDesc1(D3D11_TEXTURE3D_DESC1* pDesc)
    {
        ((delegate* unmanaged<ID3D11Texture3D1*, D3D11_TEXTURE3D_DESC1*, void> )(lpVtbl[11]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface : ID3D11Texture3D.Interface
    {
        [VtblIndex(11)]
        void GetDesc1(D3D11_TEXTURE3D_DESC1* pDesc);
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
        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("void (D3D11_RESOURCE_DIMENSION *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D11_RESOURCE_DIMENSION*, void> GetType;
        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetEvictionPriority;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetEvictionPriority;
        [NativeTypeName("void (D3D11_TEXTURE3D_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_TEXTURE3D_DESC*, void> GetDesc;
        [NativeTypeName("void (D3D11_TEXTURE3D_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_TEXTURE3D_DESC1*, void> GetDesc1;
    }
}