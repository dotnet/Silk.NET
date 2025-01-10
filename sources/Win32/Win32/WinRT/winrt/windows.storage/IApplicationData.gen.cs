// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C3DA6FB7-B744-4B45-B0B8-223A0938D0DC")]
[NativeTypeName("struct IApplicationData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationData : IApplicationData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationData, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationData, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationData, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Version([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IApplicationData, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVersionAsync(
        [NativeTypeName("UINT32")] uint desiredVersion,
        [NativeTypeName("ABI::Windows::Storage::IApplicationDataSetVersionHandler *")]
            IApplicationDataSetVersionHandler handler,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
            IAsyncAction* setVersionOperation
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationData,
                uint,
                IApplicationDataSetVersionHandler,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, desiredVersion, handler, setVersionOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearAllAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* clearOperation
    )
    {
        return ((delegate* unmanaged<IApplicationData, IAsyncAction*, int>)((*lpVtbl)[8]))(
            this,
            clearOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearAsync(
        [NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality")]
            ApplicationDataLocality locality,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* clearOperation
    )
    {
        return (
            (delegate* unmanaged<IApplicationData, ApplicationDataLocality, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, locality, clearOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LocalSettings(
        [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
            IApplicationDataContainer* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationData, IApplicationDataContainer*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RoamingSettings(
        [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
            IApplicationDataContainer* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationData, IApplicationDataContainer*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LocalFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IApplicationData, IStorageFolder*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RoamingFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IApplicationData, IStorageFolder*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TemporaryFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IApplicationData, IStorageFolder*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_DataChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationData,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_DataChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IApplicationData, EventRegistrationToken, int>)((*lpVtbl)[16])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SignalDataChanged()
    {
        return ((delegate* unmanaged<IApplicationData, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RoamingStorageQuota([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IApplicationData, ulong*, int>)((*lpVtbl)[18]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Version([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT SetVersionAsync(
            [NativeTypeName("UINT32")] uint desiredVersion,
            [NativeTypeName("ABI::Windows::Storage::IApplicationDataSetVersionHandler *")]
                IApplicationDataSetVersionHandler handler,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* setVersionOperation
        );

        [VtblIndex(8)]
        HRESULT ClearAllAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* clearOperation
        );

        [VtblIndex(9)]
        HRESULT ClearAsync(
            [NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality")]
                ApplicationDataLocality locality,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* clearOperation
        );

        [VtblIndex(10)]
        HRESULT get_LocalSettings(
            [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
                IApplicationDataContainer* value
        );

        [VtblIndex(11)]
        HRESULT get_RoamingSettings(
            [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
                IApplicationDataContainer* value
        );

        [VtblIndex(12)]
        HRESULT get_LocalFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(13)]
        HRESULT get_RoamingFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(14)]
        HRESULT get_TemporaryFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(15)]
        HRESULT add_DataChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_DataChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT SignalDataChanged();

        [VtblIndex(18)]
        HRESULT get_RoamingStorageQuota([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Version;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Storage::IApplicationDataSetVersionHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IApplicationDataSetVersionHandler,
            IAsyncAction*,
            int> SetVersionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> ClearAllAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ApplicationDataLocality, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ApplicationDataLocality, IAsyncAction*, int> ClearAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IApplicationDataContainer*, int> get_LocalSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IApplicationDataContainer*, int> get_RoamingSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_LocalFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_RoamingFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_TemporaryFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DataChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DataChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SignalDataChanged;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_RoamingStorageQuota;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationData(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationData"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationData"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationData value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationData(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
