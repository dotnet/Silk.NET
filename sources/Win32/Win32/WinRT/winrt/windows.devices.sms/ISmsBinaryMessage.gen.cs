// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5BF4E813-3B53-4C6E-B61A-D86A63755650")]
[NativeTypeName("struct ISmsBinaryMessage : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
)]
public unsafe partial struct ISmsBinaryMessage : ISmsBinaryMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsBinaryMessage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsBinaryMessage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
    )]
    public HRESULT get_Format(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat *")] SmsDataFormat* value
    )
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, SmsDataFormat*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
    )]
    public HRESULT put_Format(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat value
    )
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, SmsDataFormat, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
    )]
    public HRESULT GetData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, uint*, byte**, int>)((*lpVtbl)[8]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
    )]
    public HRESULT SetData([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged<ISmsBinaryMessage, uint, byte*, int>)((*lpVtbl)[9]))(
            this,
            valueLength,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        HRESULT get_Format(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat *")] SmsDataFormat* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        HRESULT put_Format(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat value
        );

        [VtblIndex(8)]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        HRESULT GetData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(9)]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        HRESULT SetData([NativeTypeName("UINT32")] uint valueLength, byte* value);
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
            "HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        public delegate* unmanaged<TSelf*, SmsDataFormat*, int> get_Format;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        public delegate* unmanaged<TSelf*, SmsDataFormat, int> put_Format;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetData;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, int> SetData;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsBinaryMessage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsBinaryMessage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsBinaryMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsBinaryMessage(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsBinaryMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsBinaryMessage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsBinaryMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsBinaryMessage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsBinaryMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsBinaryMessage(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsBinaryMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsBinaryMessage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsBinaryMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsBinaryMessage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
