// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D10DeviceChild.xml' path='doc/member[@name="ID3D10DeviceChild"]/*' />
[Guid("9B7E4C00-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10DeviceChild : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10DeviceChild : ID3D10DeviceChild.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10DeviceChild));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, uint>)(lpVtbl[1]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, uint>)(lpVtbl[2]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10DeviceChild.xml' path='doc/member[@name="ID3D10DeviceChild.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D10Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D10DeviceChild*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='ID3D10DeviceChild.xml' path='doc/member[@name="ID3D10DeviceChild.GetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <include file='ID3D10DeviceChild.xml' path='doc/member[@name="ID3D10DeviceChild.SetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <include file='ID3D10DeviceChild.xml' path='doc/member[@name="ID3D10DeviceChild.SetPrivateDataInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, pData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void GetDevice(ID3D10Device** ppDevice);

        [VtblIndex(4)]
        HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData);

        [VtblIndex(5)]
        HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData);

        [VtblIndex(6)]
        HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);
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

        [NativeTypeName("void (ID3D10Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
    }
}
