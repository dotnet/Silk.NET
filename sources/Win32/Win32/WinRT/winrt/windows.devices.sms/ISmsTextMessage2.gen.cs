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

[Guid("22A0D893-4555-4755-B5A1-E7FD84955F8D")]
[NativeTypeName("struct ISmsTextMessage2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsTextMessage2 : ISmsTextMessage2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsTextMessage2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsTextMessage2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsTextMessage2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage2, WinRTDateTime*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_To(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Encoding(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage2, SmsEncoding*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Encoding(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage2, SmsEncoding, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CallbackNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CallbackNumber(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, byte, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, int*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, int, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, int*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage2, int*, int>)((*lpVtbl)[21]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT get_To(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_To(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Body(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Encoding(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value
        );

        [VtblIndex(13)]
        HRESULT put_Encoding(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value
        );

        [VtblIndex(14)]
        HRESULT get_CallbackNumber(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_CallbackNumber(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_IsDeliveryNotificationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsDeliveryNotificationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_RetryAttemptCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT put_RetryAttemptCount([NativeTypeName("INT32")] int value);

        [VtblIndex(20)]
        HRESULT get_TeleserviceId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT get_ProtocolId([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_To;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_To;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Body;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsEncoding *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmsEncoding*, int> get_Encoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsEncoding) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmsEncoding, int> put_Encoding;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CallbackNumber;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CallbackNumber;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDeliveryNotificationEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsDeliveryNotificationEnabled;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_RetryAttemptCount;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_RetryAttemptCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TeleserviceId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ProtocolId;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsTextMessage2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsTextMessage2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsTextMessage2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsTextMessage2(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsTextMessage2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsTextMessage2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsTextMessage2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsTextMessage2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsTextMessage2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsTextMessage2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsTextMessage2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsTextMessage2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsTextMessage2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsTextMessage2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
