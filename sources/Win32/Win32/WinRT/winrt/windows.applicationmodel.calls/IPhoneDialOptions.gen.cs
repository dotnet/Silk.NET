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

[Guid("B639C4B8-F06F-36CB-A863-823742B5F2D4")]
[NativeTypeName("struct IPhoneDialOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneDialOptions : IPhoneDialOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneDialOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneDialOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneDialOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Number(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Number(HSTRING value)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IPhoneDialOptions, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Contact(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")] IContact* value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, IContact*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Contact(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, IContact, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ContactPhone(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone **")]
            IContactPhone* value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, IContactPhone*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ContactPhone(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone *")]
            IContactPhone value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, IContactPhone, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Media(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *")]
            PhoneCallMedia* value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, PhoneCallMedia*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Media(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia")]
            PhoneCallMedia value
    )
    {
        return ((delegate* unmanaged<IPhoneDialOptions, PhoneCallMedia, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AudioEndpoint(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *")]
            PhoneAudioRoutingEndpoint* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneDialOptions, PhoneAudioRoutingEndpoint*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_AudioEndpoint(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint")]
            PhoneAudioRoutingEndpoint value
    )
    {
        return (
            (delegate* unmanaged<IPhoneDialOptions, PhoneAudioRoutingEndpoint, int>)((*lpVtbl)[17])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Number(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Number(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Contact(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact **")]
                IContact* value
        );

        [VtblIndex(11)]
        HRESULT put_Contact(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact value
        );

        [VtblIndex(12)]
        HRESULT get_ContactPhone(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone **")]
                IContactPhone* value
        );

        [VtblIndex(13)]
        HRESULT put_ContactPhone(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactPhone *")]
                IContactPhone value
        );

        [VtblIndex(14)]
        HRESULT get_Media(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *")]
                PhoneCallMedia* value
        );

        [VtblIndex(15)]
        HRESULT put_Media(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallMedia")]
                PhoneCallMedia value
        );

        [VtblIndex(16)]
        HRESULT get_AudioEndpoint(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *")]
                PhoneAudioRoutingEndpoint* value
        );

        [VtblIndex(17)]
        HRESULT put_AudioEndpoint(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint")]
                PhoneAudioRoutingEndpoint value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Number;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Number;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact*, int> get_Contact;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, int> put_Contact;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactPhone **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactPhone*, int> get_ContactPhone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactPhone *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactPhone, int> put_ContactPhone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallMedia *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallMedia*, int> get_Media;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallMedia) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallMedia, int> put_Media;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneAudioRoutingEndpoint*, int> get_AudioEndpoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneAudioRoutingEndpoint) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneAudioRoutingEndpoint, int> put_AudioEndpoint;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneDialOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneDialOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneDialOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneDialOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneDialOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneDialOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneDialOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneDialOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneDialOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneDialOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneDialOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneDialOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneDialOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneDialOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
