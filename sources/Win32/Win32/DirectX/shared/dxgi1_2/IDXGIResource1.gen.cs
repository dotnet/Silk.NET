// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("30961379-4609-4A41-998E-54FE567EE0C1")]
[NativeTypeName("struct IDXGIResource1 : IDXGIResource")]
[NativeInheritance("IDXGIResource")]
public unsafe partial struct IDXGIResource1 : IDXGIResource1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIResource1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIResource1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
            this,
            Name,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            Name,
            pUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
            this,
            Name,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGIResource1, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSharedHandle(HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged<IDXGIResource1, HANDLE*, int>)((*lpVtbl)[8]))(
            this,
            pSharedHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage)
    {
        return ((delegate* unmanaged<IDXGIResource1, uint*, int>)((*lpVtbl)[9]))(this, pUsage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEvictionPriority(uint EvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource1, uint, int>)((*lpVtbl)[10]))(
            this,
            EvictionPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvictionPriority(uint* pEvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource1, uint*, int>)((*lpVtbl)[11]))(
            this,
            pEvictionPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateSubresourceSurface(uint index, IDXGISurface2* ppSurface)
    {
        return ((delegate* unmanaged<IDXGIResource1, uint, IDXGISurface2*, int>)((*lpVtbl)[12]))(
            this,
            index,
            ppSurface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSharedHandle(
        [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes,
        [NativeTypeName("DWORD")] uint dwAccess,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        HANDLE* pHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIResource1,
                SECURITY_ATTRIBUTES*,
                uint,
                ushort*,
                HANDLE*,
                int>)((*lpVtbl)[13])
        )(this, pAttributes, dwAccess, lpName, pHandle);
    }

    public interface Interface : IDXGIResource.Interface
    {
        [VtblIndex(12)]
        HRESULT CreateSubresourceSurface(uint index, IDXGISurface2* ppSurface);

        [VtblIndex(13)]
        HRESULT CreateSharedHandle(
            [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes,
            [NativeTypeName("DWORD")] uint dwAccess,
            [NativeTypeName("LPCWSTR")] ushort* lpName,
            HANDLE* pHandle
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

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetSharedHandle;

        [NativeTypeName("HRESULT (DXGI_USAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUsage;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEvictionPriority;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetEvictionPriority;

        [NativeTypeName("HRESULT (UINT, IDXGISurface2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGISurface2*, int> CreateSubresourceSurface;

        [NativeTypeName(
            "HRESULT (const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SECURITY_ATTRIBUTES*,
            uint,
            ushort*,
            HANDLE*,
            int> CreateSharedHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIResource1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIResource1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIResource"/> to <see cref = "IDXGIResource1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIResource"/> instance to be converted </param>
    public static explicit operator IDXGIResource1(Silk.NET.DirectX.IDXGIResource value)
    {
        return new IDXGIResource1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIResource1"/> to <see cref = "Silk.NET.DirectX.IDXGIResource"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIResource1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIResource(IDXGIResource1 value)
    {
        return new Silk.NET.DirectX.IDXGIResource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> to <see cref = "IDXGIResource1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> instance to be converted </param>
    public static explicit operator IDXGIResource1(Silk.NET.DirectX.IDXGIDeviceSubObject value)
    {
        return new IDXGIResource1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIResource1"/> to <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIResource1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDeviceSubObject(IDXGIResource1 value)
    {
        return new Silk.NET.DirectX.IDXGIDeviceSubObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIResource1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIResource1(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIResource1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIResource1"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIResource1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIResource1 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIResource1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIResource1(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIResource1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIResource1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIResource1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIResource1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
