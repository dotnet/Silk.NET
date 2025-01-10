// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F7E3F9CB-A957-439B-A0B7-1C02A1963FF0")]
[NativeTypeName("struct IContactQueryTextSearch : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactQueryTextSearch
    : IContactQueryTextSearch.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactQueryTextSearch));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactQueryTextSearch, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Fields(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *")]
            ContactQuerySearchFields* value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryTextSearch, ContactQuerySearchFields*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Fields(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields")]
            ContactQuerySearchFields value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryTextSearch, ContactQuerySearchFields, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged<IContactQueryTextSearch, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SearchScope(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *")]
            ContactQuerySearchScope* value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryTextSearch, ContactQuerySearchScope*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SearchScope(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope")]
            ContactQuerySearchScope value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryTextSearch, ContactQuerySearchScope, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Fields(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *")]
                ContactQuerySearchFields* value
        );

        [VtblIndex(7)]
        HRESULT put_Fields(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields")]
                ContactQuerySearchFields value
        );

        [VtblIndex(8)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SearchScope(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *")]
                ContactQuerySearchScope* value
        );

        [VtblIndex(11)]
        HRESULT put_SearchScope(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope")]
                ContactQuerySearchScope value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQuerySearchFields*, int> get_Fields;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchFields) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQuerySearchFields, int> put_Fields;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQuerySearchScope*, int> get_SearchScope;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQuerySearchScope) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQuerySearchScope, int> put_SearchScope;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactQueryTextSearch"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactQueryTextSearch(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactQueryTextSearch"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactQueryTextSearch(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactQueryTextSearch(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactQueryTextSearch"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactQueryTextSearch"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactQueryTextSearch value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactQueryTextSearch"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactQueryTextSearch(Silk.NET.Windows.IUnknown value)
    {
        return new IContactQueryTextSearch(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactQueryTextSearch"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactQueryTextSearch"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactQueryTextSearch value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
