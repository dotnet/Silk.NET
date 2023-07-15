// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex"]/*'/>
[Guid("9D8E1289-D7B3-465F-8126-250E349AF85D")]
[NativeTypeName("struct IDXGIKeyedMutex : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGIKeyedMutex : IDXGIKeyedMutex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIKeyedMutex));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, uint> )(lpVtbl[1]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, uint> )(lpVtbl[2]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIDeviceSubObject.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int> )(lpVtbl[7]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppDevice);
    }

    /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.AcquireSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AcquireSync([NativeTypeName("UINT64")] ulong Key, [NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, ulong, uint, int> )(lpVtbl[8]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key, dwMilliseconds);
    }

    /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.ReleaseSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReleaseSync([NativeTypeName("UINT64")] ulong Key)
    {
        return ((delegate* unmanaged<IDXGIKeyedMutex*, ulong, int> )(lpVtbl[9]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key);
    }

    public interface Interface : IDXGIDeviceSubObject.Interface
    {
        [VtblIndex(8)]
        HRESULT AcquireSync([NativeTypeName("UINT64")] ulong Key, [NativeTypeName("DWORD")] uint dwMilliseconds);
        [VtblIndex(9)]
        HRESULT ReleaseSync([NativeTypeName("UINT64")] ulong Key);
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
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("HRESULT (UINT64, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, int> AcquireSync;
        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> ReleaseSync;
    }
}