// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FB0FADBA-C7F0-4BB6-9F6B-BA5D73209ACA")]
[NativeTypeName("struct IPhoneCallHistoryEntryAddressFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntryAddressFactory
    : IPhoneCallHistoryEntryAddressFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryEntryAddressFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryAddressFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        HSTRING rawAddress,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind"
        )]
            PhoneCallHistoryEntryRawAddressKind rawAddressKind,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **")]
            IPhoneCallHistoryEntryAddress* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryEntryAddressFactory,
                HSTRING,
                PhoneCallHistoryEntryRawAddressKind,
                IPhoneCallHistoryEntryAddress*,
                int>)((*lpVtbl)[6])
        )(this, rawAddress, rawAddressKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            HSTRING rawAddress,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind"
            )]
                PhoneCallHistoryEntryRawAddressKind rawAddressKind,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **"
            )]
                IPhoneCallHistoryEntryAddress* result
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind, ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            PhoneCallHistoryEntryRawAddressKind,
            IPhoneCallHistoryEntryAddress*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneCallHistoryEntryAddressFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneCallHistoryEntryAddressFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneCallHistoryEntryAddressFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryEntryAddressFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPhoneCallHistoryEntryAddressFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryEntryAddressFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryEntryAddressFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPhoneCallHistoryEntryAddressFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneCallHistoryEntryAddressFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryEntryAddressFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPhoneCallHistoryEntryAddressFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryEntryAddressFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryEntryAddressFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPhoneCallHistoryEntryAddressFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
