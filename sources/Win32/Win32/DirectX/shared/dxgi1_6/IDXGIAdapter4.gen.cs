// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("3C8D99D1-4FBF-4181-A82C-AF66BF7BD24E")]
[NativeTypeName("struct IDXGIAdapter4 : IDXGIAdapter3")]
[NativeInheritance("IDXGIAdapter3")]
public unsafe partial struct IDXGIAdapter4 : IDXGIAdapter4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIAdapter4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIAdapter4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIAdapter4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumOutputs(uint Output, IDXGIOutput* ppOutput)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, uint, IDXGIOutput*, int>)((*lpVtbl)[7]))(
            this,
            Output,
            ppOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDesc(DXGI_ADAPTER_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, DXGI_ADAPTER_DESC*, int>)((*lpVtbl)[8]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CheckInterfaceSupport(
        [NativeTypeName("const GUID &")] Guid* InterfaceName,
        LARGE_INTEGER* pUMDVersion
    )
    {
        return ((delegate* unmanaged<IDXGIAdapter4, Guid*, LARGE_INTEGER*, int>)((*lpVtbl)[9]))(
            this,
            InterfaceName,
            pUMDVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesc1(DXGI_ADAPTER_DESC1* pDesc)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, DXGI_ADAPTER_DESC1*, int>)((*lpVtbl)[10]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDesc2(DXGI_ADAPTER_DESC2* pDesc)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, DXGI_ADAPTER_DESC2*, int>)((*lpVtbl)[11]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIAdapter4, HANDLE, uint*, int>)((*lpVtbl)[12]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void UnregisterHardwareContentProtectionTeardownStatus(
        [NativeTypeName("DWORD")] uint dwCookie
    )
    {
        ((delegate* unmanaged<IDXGIAdapter4, uint, void>)((*lpVtbl)[13]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT QueryVideoMemoryInfo(
        uint NodeIndex,
        DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
        DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIAdapter4,
                uint,
                DXGI_MEMORY_SEGMENT_GROUP,
                DXGI_QUERY_VIDEO_MEMORY_INFO*,
                int>)((*lpVtbl)[14])
        )(this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetVideoMemoryReservation(
        uint NodeIndex,
        DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
        [NativeTypeName("UINT64")] ulong Reservation
    )
    {
        return (
            (delegate* unmanaged<IDXGIAdapter4, uint, DXGI_MEMORY_SEGMENT_GROUP, ulong, int>)(
                (*lpVtbl)[15]
            )
        )(this, NodeIndex, MemorySegmentGroup, Reservation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIAdapter4, HANDLE, uint*, int>)((*lpVtbl)[16]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void UnregisterVideoMemoryBudgetChangeNotification(
        [NativeTypeName("DWORD")] uint dwCookie
    )
    {
        ((delegate* unmanaged<IDXGIAdapter4, uint, void>)((*lpVtbl)[17]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetDesc3(DXGI_ADAPTER_DESC3* pDesc)
    {
        return ((delegate* unmanaged<IDXGIAdapter4, DXGI_ADAPTER_DESC3*, int>)((*lpVtbl)[18]))(
            this,
            pDesc
        );
    }

    public interface Interface : IDXGIAdapter3.Interface
    {
        [VtblIndex(18)]
        HRESULT GetDesc3(DXGI_ADAPTER_DESC3* pDesc);
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

        [NativeTypeName("HRESULT (UINT, IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIOutput*, int> EnumOutputs;

        [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_ADAPTER_DESC*, int> GetDesc;

        [NativeTypeName("HRESULT (const GUID &, LARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, LARGE_INTEGER*, int> CheckInterfaceSupport;

        [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_ADAPTER_DESC1*, int> GetDesc1;

        [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_ADAPTER_DESC2*, int> GetDesc2;

        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            uint*,
            int> RegisterHardwareContentProtectionTeardownStatusEvent;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            void> UnregisterHardwareContentProtectionTeardownStatus;

        [NativeTypeName(
            "HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, DXGI_QUERY_VIDEO_MEMORY_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DXGI_MEMORY_SEGMENT_GROUP,
            DXGI_QUERY_VIDEO_MEMORY_INFO*,
            int> QueryVideoMemoryInfo;

        [NativeTypeName(
            "HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DXGI_MEMORY_SEGMENT_GROUP,
            ulong,
            int> SetVideoMemoryReservation;

        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            uint*,
            int> RegisterVideoMemoryBudgetChangeNotificationEvent;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            void> UnregisterVideoMemoryBudgetChangeNotification;

        [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC3 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_ADAPTER_DESC3*, int> GetDesc3;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIAdapter4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIAdapter4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIAdapter3"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIAdapter3"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.DirectX.IDXGIAdapter3 value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.DirectX.IDXGIAdapter3"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIAdapter3(IDXGIAdapter4 value)
    {
        return new Silk.NET.DirectX.IDXGIAdapter3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIAdapter2"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIAdapter2"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.DirectX.IDXGIAdapter2 value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.DirectX.IDXGIAdapter2"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIAdapter2(IDXGIAdapter4 value)
    {
        return new Silk.NET.DirectX.IDXGIAdapter2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIAdapter1"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIAdapter1"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.DirectX.IDXGIAdapter1 value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.DirectX.IDXGIAdapter1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIAdapter1(IDXGIAdapter4 value)
    {
        return new Silk.NET.DirectX.IDXGIAdapter1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIAdapter"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIAdapter"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.DirectX.IDXGIAdapter value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.DirectX.IDXGIAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIAdapter(IDXGIAdapter4 value)
    {
        return new Silk.NET.DirectX.IDXGIAdapter(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIAdapter4 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIAdapter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIAdapter4(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIAdapter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIAdapter4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIAdapter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIAdapter4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
