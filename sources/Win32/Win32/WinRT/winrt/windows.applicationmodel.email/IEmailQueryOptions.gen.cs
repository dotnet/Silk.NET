// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("45504B9B-3E7F-4D52-B6DD-D6FD4E1FBD9A")]
[NativeTypeName("struct IEmailQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailQueryOptions : IEmailQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailQueryOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailQueryOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailQueryOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailQueryOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailQueryOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailQueryOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailQueryOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextSearch(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **")]
            IEmailQueryTextSearch* value
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptions, IEmailQueryTextSearch*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SortDirection(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *")]
            EmailQuerySortDirection* value
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptions, EmailQuerySortDirection*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SortDirection(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection")]
            EmailQuerySortDirection value
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptions, EmailQuerySortDirection, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SortProperty(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *")]
            EmailQuerySortProperty* value
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptions, EmailQuerySortProperty*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SortProperty(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty")]
            EmailQuerySortProperty value
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptions, EmailQuerySortProperty, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind *")]
            EmailQueryKind* value
    )
    {
        return ((delegate* unmanaged<IEmailQueryOptions, EmailQueryKind*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind")]
            EmailQueryKind value
    )
    {
        return ((delegate* unmanaged<IEmailQueryOptions, EmailQueryKind, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FolderIds(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IEmailQueryOptions, IVector<HSTRING>**, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextSearch(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **")]
                IEmailQueryTextSearch* value
        );

        [VtblIndex(7)]
        HRESULT get_SortDirection(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *")]
                EmailQuerySortDirection* value
        );

        [VtblIndex(8)]
        HRESULT put_SortDirection(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection")]
                EmailQuerySortDirection value
        );

        [VtblIndex(9)]
        HRESULT get_SortProperty(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *")]
                EmailQuerySortProperty* value
        );

        [VtblIndex(10)]
        HRESULT put_SortProperty(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty")]
                EmailQuerySortProperty value
        );

        [VtblIndex(11)]
        HRESULT get_Kind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind *")]
                EmailQueryKind* value
        );

        [VtblIndex(12)]
        HRESULT put_Kind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQueryKind")]
                EmailQueryKind value
        );

        [VtblIndex(13)]
        HRESULT get_FolderIds(
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
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryTextSearch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailQueryTextSearch*, int> get_TextSearch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQuerySortDirection*, int> get_SortDirection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortDirection) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQuerySortDirection, int> put_SortDirection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQuerySortProperty*, int> get_SortProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQuerySortProperty) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQuerySortProperty, int> put_SortProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQueryKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQueryKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailQueryKind) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailQueryKind, int> put_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_FolderIds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailQueryOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailQueryOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailQueryOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailQueryOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailQueryOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailQueryOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailQueryOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailQueryOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
