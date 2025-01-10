// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D6B6A758-198D-5B80-977F-5FF73DA33118")]
[NativeTypeName("struct IStorageProviderStatusUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderStatusUI
    : IStorageProviderStatusUI.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderStatusUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageProviderStatusUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderState(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState *")]
            StorageProviderState* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, StorageProviderState*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProviderState(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState")]
            StorageProviderState value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, StorageProviderState, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProviderStateLabel(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProviderStateLabel(HSTRING value)
    {
        return ((delegate* unmanaged<IStorageProviderStatusUI, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProviderStateIcon(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IUriRuntimeClass*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProviderStateIcon(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IUriRuntimeClass, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SyncStatusCommand(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")]
            IStorageProviderUICommand* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderUICommand*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SyncStatusCommand(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")]
            IStorageProviderUICommand value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderUICommand, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_QuotaUI(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **")]
            IStorageProviderQuotaUI* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderQuotaUI*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_QuotaUI(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *")]
            IStorageProviderQuotaUI value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderQuotaUI, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MoreInfoUI(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **")]
            IStorageProviderMoreInfoUI* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderMoreInfoUI*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_MoreInfoUI(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *")]
            IStorageProviderMoreInfoUI value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderMoreInfoUI, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ProviderPrimaryCommand(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")]
            IStorageProviderUICommand* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderUICommand*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ProviderPrimaryCommand(
        [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")]
            IStorageProviderUICommand value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IStorageProviderUICommand, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ProviderSecondaryCommands(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IVector<IntPtr>**, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ProviderSecondaryCommands(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *"
        )]
            IVector<IntPtr>* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderStatusUI, IVector<IntPtr>*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderState(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState *")]
                StorageProviderState* value
        );

        [VtblIndex(7)]
        HRESULT put_ProviderState(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState")]
                StorageProviderState value
        );

        [VtblIndex(8)]
        HRESULT get_ProviderStateLabel(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ProviderStateLabel(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ProviderStateIcon(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(11)]
        HRESULT put_ProviderStateIcon(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(12)]
        HRESULT get_SyncStatusCommand(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")]
                IStorageProviderUICommand* value
        );

        [VtblIndex(13)]
        HRESULT put_SyncStatusCommand(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")]
                IStorageProviderUICommand value
        );

        [VtblIndex(14)]
        HRESULT get_QuotaUI(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **")]
                IStorageProviderQuotaUI* value
        );

        [VtblIndex(15)]
        HRESULT put_QuotaUI(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *")]
                IStorageProviderQuotaUI value
        );

        [VtblIndex(16)]
        HRESULT get_MoreInfoUI(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **")]
                IStorageProviderMoreInfoUI* value
        );

        [VtblIndex(17)]
        HRESULT put_MoreInfoUI(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *")]
                IStorageProviderMoreInfoUI value
        );

        [VtblIndex(18)]
        HRESULT get_ProviderPrimaryCommand(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")]
                IStorageProviderUICommand* value
        );

        [VtblIndex(19)]
        HRESULT put_ProviderPrimaryCommand(
            [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")]
                IStorageProviderUICommand value
        );

        [VtblIndex(20)]
        HRESULT get_ProviderSecondaryCommands(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(21)]
        HRESULT put_ProviderSecondaryCommands(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *"
            )]
                IVector<IntPtr>* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderState*, int> get_ProviderState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderState) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderState, int> put_ProviderState;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ProviderStateLabel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ProviderStateLabel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ProviderStateIcon;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_ProviderStateIcon;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderUICommand*, int> get_SyncStatusCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderUICommand, int> put_SyncStatusCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderQuotaUI*, int> get_QuotaUI;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderQuotaUI, int> put_QuotaUI;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderMoreInfoUI*, int> get_MoreInfoUI;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderMoreInfoUI, int> put_MoreInfoUI;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageProviderUICommand*,
            int> get_ProviderPrimaryCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageProviderUICommand,
            int> put_ProviderPrimaryCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_ProviderSecondaryCommands;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>*, int> put_ProviderSecondaryCommands;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderStatusUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderStatusUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderStatusUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderStatusUI(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageProviderStatusUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderStatusUI"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderStatusUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageProviderStatusUI value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderStatusUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderStatusUI(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderStatusUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderStatusUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderStatusUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderStatusUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
