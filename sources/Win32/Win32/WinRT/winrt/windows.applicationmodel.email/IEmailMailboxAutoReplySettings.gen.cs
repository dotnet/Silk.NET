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

[Guid("A87A9FA8-0AC6-4B77-BA77-A6B99E9A27B8")]
[NativeTypeName("struct IEmailMailboxAutoReplySettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxAutoReplySettings
    : IEmailMailboxAutoReplySettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxAutoReplySettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEmailMailboxAutoReplySettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailboxAutoReplySettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailboxAutoReplySettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailMailboxAutoReplySettings, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxAutoReplySettings, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseKind(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *"
        )]
            EmailMailboxAutoReplyMessageResponseKind* value
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailboxAutoReplySettings,
                EmailMailboxAutoReplyMessageResponseKind*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ResponseKind(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind"
        )]
            EmailMailboxAutoReplyMessageResponseKind value
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailboxAutoReplySettings,
                EmailMailboxAutoReplyMessageResponseKind,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StartTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IReference<DateTime>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StartTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IReference<DateTime>*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EndTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IReference<DateTime>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_EndTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IReference<DateTime>*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_InternalReply(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
            IEmailMailboxAutoReply* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IEmailMailboxAutoReply*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_KnownExternalReply(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
            IEmailMailboxAutoReply* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IEmailMailboxAutoReply*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UnknownExternalReply(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
            IEmailMailboxAutoReply* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxAutoReplySettings, IEmailMailboxAutoReply*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_ResponseKind(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *"
            )]
                EmailMailboxAutoReplyMessageResponseKind* value
        );

        [VtblIndex(9)]
        HRESULT put_ResponseKind(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind"
            )]
                EmailMailboxAutoReplyMessageResponseKind value
        );

        [VtblIndex(10)]
        HRESULT get_StartTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(11)]
        HRESULT put_StartTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(12)]
        HRESULT get_EndTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(13)]
        HRESULT put_EndTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(14)]
        HRESULT get_InternalReply(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
                IEmailMailboxAutoReply* value
        );

        [VtblIndex(15)]
        HRESULT get_KnownExternalReply(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
                IEmailMailboxAutoReply* value
        );

        [VtblIndex(16)]
        HRESULT get_UnknownExternalReply(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")]
                IEmailMailboxAutoReply* value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxAutoReplyMessageResponseKind*,
            int> get_ResponseKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxAutoReplyMessageResponseKind,
            int> put_ResponseKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_StartTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_StartTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_EndTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_EndTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxAutoReply*, int> get_InternalReply;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxAutoReply*, int> get_KnownExternalReply;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxAutoReply*, int> get_UnknownExternalReply;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailboxAutoReplySettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailboxAutoReplySettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailboxAutoReplySettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailboxAutoReplySettings(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IEmailMailboxAutoReplySettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxAutoReplySettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxAutoReplySettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IEmailMailboxAutoReplySettings value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailboxAutoReplySettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailboxAutoReplySettings(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailboxAutoReplySettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxAutoReplySettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxAutoReplySettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailboxAutoReplySettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
