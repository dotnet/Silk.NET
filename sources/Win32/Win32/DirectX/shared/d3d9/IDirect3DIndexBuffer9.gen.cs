// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("7C9DD65E-D3F7-4529-ACEE-785830ACDE35")]
[NativeTypeName("struct IDirect3DIndexBuffer9 : IDirect3DResource9")]
[NativeInheritance("IDirect3DResource9")]
public unsafe partial struct IDirect3DIndexBuffer9 : IDirect3DIndexBuffer9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DIndexBuffer9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9* ppDevice)
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, IDirect3DDevice9*, int>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* refguid,
        [NativeTypeName("const void *")] void* pData,
        [NativeTypeName("DWORD")] uint SizeOfData,
        [NativeTypeName("DWORD")] uint Flags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DIndexBuffer9, Guid*, void*, uint, uint, int>)(
                (*lpVtbl)[4]
            )
        )(this, refguid, pData, SizeOfData, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* refguid,
        void* pData,
        [NativeTypeName("DWORD *")] uint* pSizeOfData
    )
    {
        return (
            (delegate* unmanaged<IDirect3DIndexBuffer9, Guid*, void*, uint*, int>)((*lpVtbl)[5])
        )(this, refguid, pData, pSizeOfData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, Guid*, int>)((*lpVtbl)[6]))(
            this,
            refguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, uint, uint>)((*lpVtbl)[7]))(
            this,
            PriorityNew
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetPriority()
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PreLoad()
    {
        ((delegate* unmanaged<IDirect3DIndexBuffer9, void>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3DRESOURCETYPE GetType()
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, D3DRESOURCETYPE>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Lock(
        uint OffsetToLock,
        uint SizeToLock,
        void** ppbData,
        [NativeTypeName("DWORD")] uint Flags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DIndexBuffer9, uint, uint, void**, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, OffsetToLock, SizeToLock, ppbData, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IDirect3DIndexBuffer9, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDesc(D3DINDEXBUFFER_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<IDirect3DIndexBuffer9, D3DINDEXBUFFER_DESC*, int>)((*lpVtbl)[13])
        )(this, pDesc);
    }

    public interface Interface : IDirect3DResource9.Interface
    {
        [VtblIndex(11)]
        HRESULT Lock(
            uint OffsetToLock,
            uint SizeToLock,
            void** ppbData,
            [NativeTypeName("DWORD")] uint Flags
        );

        [VtblIndex(12)]
        HRESULT Unlock();

        [VtblIndex(13)]
        HRESULT GetDesc(D3DINDEXBUFFER_DESC* pDesc);
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
            "HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DDevice9*, int> GetDevice;

        [NativeTypeName(
            "HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint, uint, int> SetPrivateData;

        [NativeTypeName(
            "HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> FreePrivateData;

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> SetPriority;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPriority;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PreLoad;

        [NativeTypeName("D3DRESOURCETYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3DRESOURCETYPE> GetType;

        [NativeTypeName(
            "HRESULT (UINT, UINT, void **, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, void**, uint, int> Lock;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;

        [NativeTypeName(
            "HRESULT (D3DINDEXBUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DINDEXBUFFER_DESC*, int> GetDesc;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DIndexBuffer9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DIndexBuffer9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirect3DResource9"/> to <see cref = "IDirect3DIndexBuffer9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirect3DResource9"/> instance to be converted </param>
    public static explicit operator IDirect3DIndexBuffer9(Silk.NET.DirectX.IDirect3DResource9 value)
    {
        return new IDirect3DIndexBuffer9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DIndexBuffer9"/> to <see cref = "Silk.NET.DirectX.IDirect3DResource9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DIndexBuffer9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirect3DResource9(IDirect3DIndexBuffer9 value)
    {
        return new Silk.NET.DirectX.IDirect3DResource9(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DIndexBuffer9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DIndexBuffer9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DIndexBuffer9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DIndexBuffer9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DIndexBuffer9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DIndexBuffer9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
