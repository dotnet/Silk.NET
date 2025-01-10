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

[Guid("ABA496DD-B617-4CB8-A866-BC44D7EB1FA2")]
[NativeTypeName("struct IDXGISurface2 : IDXGISurface1")]
[NativeInheritance("IDXGISurface1")]
public unsafe partial struct IDXGISurface2 : IDXGISurface2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISurface2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISurface2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGISurface2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISurface2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGISurface2, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGISurface2, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGISurface2, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGISurface2, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGISurface2, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDesc(DXGI_SURFACE_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGISurface2, DXGI_SURFACE_DESC*, int>)((*lpVtbl)[8]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Map(DXGI_MAPPED_RECT* pLockedRect, uint MapFlags)
    {
        return ((delegate* unmanaged<IDXGISurface2, DXGI_MAPPED_RECT*, uint, int>)((*lpVtbl)[9]))(
            this,
            pLockedRect,
            MapFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Unmap()
    {
        return ((delegate* unmanaged<IDXGISurface2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDC(BOOL Discard, HDC* phdc)
    {
        return ((delegate* unmanaged<IDXGISurface2, BOOL, HDC*, int>)((*lpVtbl)[11]))(
            this,
            Discard,
            phdc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReleaseDC(RECT* pDirtyRect)
    {
        return ((delegate* unmanaged<IDXGISurface2, RECT*, int>)((*lpVtbl)[12]))(this, pDirtyRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetResource(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppParentResource,
        uint* pSubresourceIndex
    )
    {
        return ((delegate* unmanaged<IDXGISurface2, Guid*, void**, uint*, int>)((*lpVtbl)[13]))(
            this,
            riid,
            ppParentResource,
            pSubresourceIndex
        );
    }

    public interface Interface : IDXGISurface1.Interface
    {
        [VtblIndex(13)]
        HRESULT GetResource(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppParentResource,
            uint* pSubresourceIndex
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

        [NativeTypeName("HRESULT (DXGI_SURFACE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SURFACE_DESC*, int> GetDesc;

        [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MAPPED_RECT*, uint, int> Map;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unmap;

        [NativeTypeName("HRESULT (BOOL, HDC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, HDC*, int> GetDC;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> ReleaseDC;

        [NativeTypeName("HRESULT (const IID &, void **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, uint*, int> GetResource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGISurface2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGISurface2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGISurface1"/> to <see cref = "IDXGISurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGISurface1"/> instance to be converted </param>
    public static explicit operator IDXGISurface2(Silk.NET.DirectX.IDXGISurface1 value)
    {
        return new IDXGISurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISurface2"/> to <see cref = "Silk.NET.DirectX.IDXGISurface1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGISurface1(IDXGISurface2 value)
    {
        return new Silk.NET.DirectX.IDXGISurface1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGISurface"/> to <see cref = "IDXGISurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGISurface"/> instance to be converted </param>
    public static explicit operator IDXGISurface2(Silk.NET.DirectX.IDXGISurface value)
    {
        return new IDXGISurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISurface2"/> to <see cref = "Silk.NET.DirectX.IDXGISurface"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGISurface(IDXGISurface2 value)
    {
        return new Silk.NET.DirectX.IDXGISurface(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> to <see cref = "IDXGISurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> instance to be converted </param>
    public static explicit operator IDXGISurface2(Silk.NET.DirectX.IDXGIDeviceSubObject value)
    {
        return new IDXGISurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISurface2"/> to <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDeviceSubObject(IDXGISurface2 value)
    {
        return new Silk.NET.DirectX.IDXGIDeviceSubObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGISurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGISurface2(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGISurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISurface2"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGISurface2 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGISurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGISurface2(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGISurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISurface2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGISurface2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
