// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D0046A44-61A1-41AA-B259-A5610AB5D575")]
[NativeTypeName("struct IWalletItemCustomPropertyFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletItemCustomPropertyFactory
    : IWalletItemCustomPropertyFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemCustomPropertyFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWalletItemCustomPropertyFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWalletItemCustomPropertyFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletItemCustomPropertyFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWalletItemCustomPropertyFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWalletItemCustomPropertyFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWalletItemCustomPropertyFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT CreateWalletItemCustomProperty(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **")]
            IWalletItemCustomProperty* walletItemCustomProperty
    )
    {
        return (
            (delegate* unmanaged<
                IWalletItemCustomPropertyFactory,
                HSTRING,
                HSTRING,
                IWalletItemCustomProperty*,
                int>)((*lpVtbl)[6])
        )(this, name, value, walletItemCustomProperty);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT CreateWalletItemCustomProperty(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **")]
                IWalletItemCustomProperty* walletItemCustomProperty
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IWalletItemCustomProperty*,
            int> CreateWalletItemCustomProperty;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletItemCustomPropertyFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletItemCustomPropertyFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletItemCustomPropertyFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletItemCustomPropertyFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWalletItemCustomPropertyFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemCustomPropertyFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemCustomPropertyFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWalletItemCustomPropertyFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletItemCustomPropertyFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletItemCustomPropertyFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWalletItemCustomPropertyFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemCustomPropertyFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemCustomPropertyFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWalletItemCustomPropertyFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
