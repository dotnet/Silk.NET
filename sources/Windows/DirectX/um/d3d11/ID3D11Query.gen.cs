// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D11Query.xml' path='doc/member[@name="ID3D11Query"]/*'/>
[Guid("D6C00747-87B7-425E-B84D-44D108560AFD")]
[NativeTypeName("struct ID3D11Query : ID3D11Asynchronous")]
[NativeInheritance("ID3D11Asynchronous")]
public unsafe partial struct ID3D11Query : ID3D11Query.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Query));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Query*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11Query*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11Query*, uint> )(lpVtbl[1]))((ID3D11Query*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Query*, uint> )(lpVtbl[2]))((ID3D11Query*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11Query*, ID3D11Device**, void> )(lpVtbl[3]))((ID3D11Query*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11Query*, Guid*, uint*, void*, int> )(lpVtbl[4]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11Query*, Guid*, uint, void*, int> )(lpVtbl[5]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11Query*, Guid*, IUnknown*, int> )(lpVtbl[6]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D11Asynchronous.GetDataSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetDataSize()
    {
        return ((delegate* unmanaged<ID3D11Query*, uint> )(lpVtbl[7]))((ID3D11Query*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11Query.xml' path='doc/member[@name="ID3D11Query.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDesc(D3D11_QUERY_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11Query*, D3D11_QUERY_DESC*, void> )(lpVtbl[8]))((ID3D11Query*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface : ID3D11Asynchronous.Interface
    {
        [VtblIndex(8)]
        void GetDesc(D3D11_QUERY_DESC* pDesc);
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
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDataSize;
        [NativeTypeName("void (D3D11_QUERY_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_QUERY_DESC*, void> GetDesc;
    }
}