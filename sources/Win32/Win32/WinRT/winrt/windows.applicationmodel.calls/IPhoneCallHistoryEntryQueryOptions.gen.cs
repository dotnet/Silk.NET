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

[Guid("9C5FE15C-8BED-40CA-B06E-C4CA8EAE5C87")]
[NativeTypeName("struct IPhoneCallHistoryEntryQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntryQueryOptions
    : IPhoneCallHistoryEntryQueryOptions.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryEntryQueryOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredMedia(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *"
        )]
            PhoneCallHistoryEntryQueryDesiredMedia* value
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryEntryQueryOptions,
                PhoneCallHistoryEntryQueryDesiredMedia*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredMedia(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia"
        )]
            PhoneCallHistoryEntryQueryDesiredMedia value
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryEntryQueryOptions,
                PhoneCallHistoryEntryQueryDesiredMedia,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceIds(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryEntryQueryOptions, IVector<HSTRING>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredMedia(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *"
            )]
                PhoneCallHistoryEntryQueryDesiredMedia* value
        );

        [VtblIndex(7)]
        HRESULT put_DesiredMedia(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia"
            )]
                PhoneCallHistoryEntryQueryDesiredMedia value
        );

        [VtblIndex(8)]
        HRESULT get_SourceIds(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
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
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneCallHistoryEntryQueryDesiredMedia*,
            int> get_DesiredMedia;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneCallHistoryEntryQueryDesiredMedia,
            int> put_DesiredMedia;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_SourceIds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneCallHistoryEntryQueryOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneCallHistoryEntryQueryOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneCallHistoryEntryQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryEntryQueryOptions(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPhoneCallHistoryEntryQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryEntryQueryOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryEntryQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPhoneCallHistoryEntryQueryOptions value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneCallHistoryEntryQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryEntryQueryOptions(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPhoneCallHistoryEntryQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryEntryQueryOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryEntryQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPhoneCallHistoryEntryQueryOptions value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
