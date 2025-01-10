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

[Guid("D61C904C-A495-487F-9A6F-971548C5BC9F")]
[NativeTypeName("struct ISmsTextMessage : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
)]
public unsafe partial struct ISmsTextMessage : ISmsTextMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsTextMessage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsTextMessage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsTextMessage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsTextMessage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsTextMessage, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_Timestamp(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage, WinRTDateTime*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_PartReferenceId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, uint*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_PartNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, uint*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_PartCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT put_To(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT put_From(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsTextMessage, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT get_Encoding(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage, SmsEncoding*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT put_Encoding(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value
    )
    {
        return ((delegate* unmanaged<ISmsTextMessage, SmsEncoding, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public HRESULT ToBinaryMessages(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **"
        )]
            IVectorView<IntPtr>** messages
    )
    {
        return (
            (delegate* unmanaged<ISmsTextMessage, SmsDataFormat, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, format, messages);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_Timestamp(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_PartReferenceId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_PartNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_PartCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_To(HSTRING* value);

        [VtblIndex(11)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT put_To(HSTRING value);

        [VtblIndex(12)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(13)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT put_From(HSTRING value);

        [VtblIndex(14)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(15)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT put_Body(HSTRING value);

        [VtblIndex(16)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT get_Encoding(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value
        );

        [VtblIndex(17)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT put_Encoding(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value
        );

        [VtblIndex(18)]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        HRESULT ToBinaryMessages(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **"
            )]
                IVectorView<IntPtr>** messages
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, uint*, int> get_PartReferenceId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, uint*, int> get_PartNumber;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, uint*, int> get_PartCount;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_To;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_To;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_From;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Body;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsEncoding *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, SmsEncoding*, int> get_Encoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsEncoding) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<TSelf*, SmsEncoding, int> put_Encoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
        )]
        public delegate* unmanaged<
            TSelf*,
            SmsDataFormat,
            IVectorView<IntPtr>**,
            int> ToBinaryMessages;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsTextMessage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsTextMessage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsTextMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsTextMessage(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsTextMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsTextMessage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsTextMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsTextMessage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsTextMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsTextMessage(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsTextMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsTextMessage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsTextMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsTextMessage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
