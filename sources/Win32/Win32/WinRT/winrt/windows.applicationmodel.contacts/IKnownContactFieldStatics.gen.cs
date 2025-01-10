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

[Guid("2E0E1B12-D627-4FCA-BAD4-1FAF168C7D14")]
[NativeTypeName("struct IKnownContactFieldStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
)]
public unsafe partial struct IKnownContactFieldStatics
    : IKnownContactFieldStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownContactFieldStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKnownContactFieldStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT get_Email(HSTRING* value)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT get_Location(HSTRING* value)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT get_InstantMessage(HSTRING* value)
    {
        return ((delegate* unmanaged<IKnownContactFieldStatics, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT ConvertNameToType(
        HSTRING name,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")]
            ContactFieldType* type
    )
    {
        return (
            (delegate* unmanaged<IKnownContactFieldStatics, HSTRING, ContactFieldType*, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
    )]
    public HRESULT ConvertTypeToName(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
            ContactFieldType type,
        HSTRING* name
    )
    {
        return (
            (delegate* unmanaged<IKnownContactFieldStatics, ContactFieldType, HSTRING*, int>)(
                (*lpVtbl)[11]
            )
        )(this, type, name);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT get_Email(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT get_Location(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT get_InstantMessage(HSTRING* value);

        [VtblIndex(10)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT ConvertNameToType(
            HSTRING name,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")]
                ContactFieldType* type
        );

        [VtblIndex(11)]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        HRESULT ConvertTypeToName(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
                ContactFieldType type,
            HSTRING* name
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
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Email;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Location;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_InstantMessage;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ContactFieldType*, int> ConvertNameToType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactFieldType, HSTRING *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail."
        )]
        public delegate* unmanaged<TSelf*, ContactFieldType, HSTRING*, int> ConvertTypeToName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKnownContactFieldStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKnownContactFieldStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKnownContactFieldStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKnownContactFieldStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IKnownContactFieldStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownContactFieldStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownContactFieldStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IKnownContactFieldStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKnownContactFieldStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKnownContactFieldStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IKnownContactFieldStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownContactFieldStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownContactFieldStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKnownContactFieldStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
