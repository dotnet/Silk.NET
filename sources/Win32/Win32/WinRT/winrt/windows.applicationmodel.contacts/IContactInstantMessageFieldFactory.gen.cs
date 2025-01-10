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

[Guid("BA0B6794-91A3-4BB2-B1B9-69A5DFF0BA09")]
[NativeTypeName("struct IContactInstantMessageFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactInstantMessageFieldFactory
    : IContactInstantMessageFieldFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactInstantMessageFieldFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IContactInstantMessageFieldFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContactInstantMessageFieldFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactInstantMessageFieldFactory, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IContactInstantMessageFieldFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IContactInstantMessageFieldFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IContactInstantMessageFieldFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstantMessage_Default(
        HSTRING userName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")]
            IContactInstantMessageField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactInstantMessageFieldFactory,
                HSTRING,
                IContactInstantMessageField*,
                int>)((*lpVtbl)[6])
        )(this, userName, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateInstantMessage_Category(
        HSTRING userName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")]
            IContactInstantMessageField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactInstantMessageFieldFactory,
                HSTRING,
                ContactFieldCategory,
                IContactInstantMessageField*,
                int>)((*lpVtbl)[7])
        )(this, userName, category, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateInstantMessage_All(
        HSTRING userName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        HSTRING service,
        HSTRING displayText,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass verb,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")]
            IContactInstantMessageField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactInstantMessageFieldFactory,
                HSTRING,
                ContactFieldCategory,
                HSTRING,
                HSTRING,
                IUriRuntimeClass,
                IContactInstantMessageField*,
                int>)((*lpVtbl)[8])
        )(this, userName, category, service, displayText, verb, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstantMessage_Default(
            HSTRING userName,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **"
            )]
                IContactInstantMessageField* field
        );

        [VtblIndex(7)]
        HRESULT CreateInstantMessage_Category(
            HSTRING userName,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **"
            )]
                IContactInstantMessageField* field
        );

        [VtblIndex(8)]
        HRESULT CreateInstantMessage_All(
            HSTRING userName,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            HSTRING service,
            HSTRING displayText,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass verb,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **"
            )]
                IContactInstantMessageField* field
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IContactInstantMessageField*,
            int> CreateInstantMessage_Default;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldCategory,
            IContactInstantMessageField*,
            int> CreateInstantMessage_Category;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldCategory,
            HSTRING,
            HSTRING,
            IUriRuntimeClass,
            IContactInstantMessageField*,
            int> CreateInstantMessage_All;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactInstantMessageFieldFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactInstantMessageFieldFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactInstantMessageFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactInstantMessageFieldFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IContactInstantMessageFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactInstantMessageFieldFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactInstantMessageFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IContactInstantMessageFieldFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactInstantMessageFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactInstantMessageFieldFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IContactInstantMessageFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactInstantMessageFieldFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactInstantMessageFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IContactInstantMessageFieldFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
