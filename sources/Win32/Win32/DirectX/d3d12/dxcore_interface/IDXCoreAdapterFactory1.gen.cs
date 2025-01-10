// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("D5682E19-6D21-401C-827A-9A51A4EA35D7")]
[NativeTypeName("struct IDXCoreAdapterFactory1 : IDXCoreAdapterFactory")]
[NativeInheritance("IDXCoreAdapterFactory")]
public unsafe partial struct IDXCoreAdapterFactory1 : IDXCoreAdapterFactory1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXCoreAdapterFactory1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXCoreAdapterFactory1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXCoreAdapterFactory1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXCoreAdapterFactory1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateAdapterList(
        [NativeTypeName("uint32_t")] uint numAttributes,
        [NativeTypeName("const GUID *")] Guid* filterAttributes,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapterList
    )
    {
        return (
            (delegate* unmanaged<IDXCoreAdapterFactory1, uint, Guid*, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, numAttributes, filterAttributes, riid, ppvAdapterList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAdapterByLuid(
        [NativeTypeName("const LUID &")] LUID* adapterLUID,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapter
    )
    {
        return (
            (delegate* unmanaged<IDXCoreAdapterFactory1, LUID*, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, adapterLUID, riid, ppvAdapter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
    {
        return (
                (delegate* unmanaged<IDXCoreAdapterFactory1, DXCoreNotificationType, byte>)(
                    (*lpVtbl)[5]
                )
            )(this, notificationType) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterEventNotification(
        IUnknown dxCoreObject,
        DXCoreNotificationType notificationType,
        [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")]
            delegate* unmanaged<DXCoreNotificationType, IUnknown, void*, void> callbackFunction,
        void* callbackContext,
        [NativeTypeName("uint32_t *")] uint* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IDXCoreAdapterFactory1,
                IUnknown,
                DXCoreNotificationType,
                delegate* unmanaged<DXCoreNotificationType, IUnknown, void*, void>,
                void*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
    {
        return ((delegate* unmanaged<IDXCoreAdapterFactory1, uint, int>)((*lpVtbl)[7]))(
            this,
            eventCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAdapterListByWorkload(
        DXCoreWorkload workload,
        DXCoreRuntimeFilterFlags runtimeFilter,
        DXCoreHardwareTypeFilterFlags hardwareTypeFilter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapterList
    )
    {
        return (
            (delegate* unmanaged<
                IDXCoreAdapterFactory1,
                DXCoreWorkload,
                DXCoreRuntimeFilterFlags,
                DXCoreHardwareTypeFilterFlags,
                Guid*,
                void**,
                int>)((*lpVtbl)[8])
        )(this, workload, runtimeFilter, hardwareTypeFilter, riid, ppvAdapterList);
    }

    public interface Interface : IDXCoreAdapterFactory.Interface
    {
        [VtblIndex(8)]
        HRESULT CreateAdapterListByWorkload(
            DXCoreWorkload workload,
            DXCoreRuntimeFilterFlags runtimeFilter,
            DXCoreHardwareTypeFilterFlags hardwareTypeFilter,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapterList
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

        [NativeTypeName(
            "HRESULT (uint32_t, const GUID *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, int> CreateAdapterList;

        [NativeTypeName("HRESULT (const LUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID*, Guid*, void**, int> GetAdapterByLuid;

        [NativeTypeName("bool (DXCoreNotificationType) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DXCoreNotificationType,
            byte> IsNotificationTypeSupported;

        [NativeTypeName(
            "HRESULT (IUnknown *, DXCoreNotificationType, PFN_DXCORE_NOTIFICATION_CALLBACK, void *, uint32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            DXCoreNotificationType,
            delegate* unmanaged<DXCoreNotificationType, IUnknown, void*, void>,
            void*,
            uint*,
            int> RegisterEventNotification;

        [NativeTypeName("HRESULT (uint32_t) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterEventNotification;

        [NativeTypeName(
            "HRESULT (DXCoreWorkload, DXCoreRuntimeFilterFlags, DXCoreHardwareTypeFilterFlags, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXCoreWorkload,
            DXCoreRuntimeFilterFlags,
            DXCoreHardwareTypeFilterFlags,
            Guid*,
            void**,
            int> CreateAdapterListByWorkload;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterFactory1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterFactory1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXCoreAdapterFactory"/> to <see cref = "IDXCoreAdapterFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXCoreAdapterFactory"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory1(
        Silk.NET.DirectX.IDXCoreAdapterFactory value
    )
    {
        return new IDXCoreAdapterFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXCoreAdapterFactory1"/> to <see cref = "Silk.NET.DirectX.IDXCoreAdapterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXCoreAdapterFactory(
        IDXCoreAdapterFactory1 value
    )
    {
        return new Silk.NET.DirectX.IDXCoreAdapterFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXCoreAdapterFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterFactory1(Silk.NET.Windows.IUnknown value)
    {
        return new IDXCoreAdapterFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXCoreAdapterFactory1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXCoreAdapterFactory1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
