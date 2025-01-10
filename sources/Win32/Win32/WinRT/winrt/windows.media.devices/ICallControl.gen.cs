// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A520D0D6-AE8D-45DB-8011-CA49D3B3E578")]
[NativeTypeName("struct ICallControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICallControl : ICallControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICallControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICallControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICallControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICallControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICallControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICallControl, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICallControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IndicateNewIncomingCall(
        [NativeTypeName("boolean")] byte enableRinger,
        HSTRING callerId,
        [NativeTypeName("UINT64 *")] ulong* callToken
    )
    {
        return ((delegate* unmanaged<ICallControl, byte, HSTRING, ulong*, int>)((*lpVtbl)[6]))(
            this,
            enableRinger,
            callerId,
            callToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IndicateNewOutgoingCall([NativeTypeName("UINT64 *")] ulong* callToken)
    {
        return ((delegate* unmanaged<ICallControl, ulong*, int>)((*lpVtbl)[7]))(this, callToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IndicateActiveCall([NativeTypeName("UINT64")] ulong callToken)
    {
        return ((delegate* unmanaged<ICallControl, ulong, int>)((*lpVtbl)[8]))(this, callToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndCall([NativeTypeName("UINT64")] ulong callToken)
    {
        return ((delegate* unmanaged<ICallControl, ulong, int>)((*lpVtbl)[9]))(this, callToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HasRinger([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICallControl, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_AnswerRequested(
        [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
            ICallControlEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                ICallControlEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_AnswerRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[12]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_HangUpRequested(
        [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
            ICallControlEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                ICallControlEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_HangUpRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[14]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_DialRequested(
        [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventHandler *")]
            IDialRequestedEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                IDialRequestedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_DialRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[16]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_RedialRequested(
        [NativeTypeName("ABI::Windows::Media::Devices::IRedialRequestedEventHandler *")]
            IRedialRequestedEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                IRedialRequestedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_RedialRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[18]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_KeypadPressed(
        [NativeTypeName("ABI::Windows::Media::Devices::IKeypadPressedEventHandler *")]
            IKeypadPressedEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                IKeypadPressedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_KeypadPressed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[20]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_AudioTransferRequested(
        [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
            ICallControlEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICallControl,
                ICallControlEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[21])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_AudioTransferRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ICallControl, EventRegistrationToken, int>)((*lpVtbl)[22]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IndicateNewIncomingCall(
            [NativeTypeName("boolean")] byte enableRinger,
            HSTRING callerId,
            [NativeTypeName("UINT64 *")] ulong* callToken
        );

        [VtblIndex(7)]
        HRESULT IndicateNewOutgoingCall([NativeTypeName("UINT64 *")] ulong* callToken);

        [VtblIndex(8)]
        HRESULT IndicateActiveCall([NativeTypeName("UINT64")] ulong callToken);

        [VtblIndex(9)]
        HRESULT EndCall([NativeTypeName("UINT64")] ulong callToken);

        [VtblIndex(10)]
        HRESULT get_HasRinger([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT add_AnswerRequested(
            [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
                ICallControlEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_AnswerRequested(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_HangUpRequested(
            [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
                ICallControlEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_HangUpRequested(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_DialRequested(
            [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventHandler *")]
                IDialRequestedEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_DialRequested(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_RedialRequested(
            [NativeTypeName("ABI::Windows::Media::Devices::IRedialRequestedEventHandler *")]
                IRedialRequestedEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_RedialRequested(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT add_KeypadPressed(
            [NativeTypeName("ABI::Windows::Media::Devices::IKeypadPressedEventHandler *")]
                IKeypadPressedEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(20)]
        HRESULT remove_KeypadPressed(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_AudioTransferRequested(
            [NativeTypeName("ABI::Windows::Media::Devices::ICallControlEventHandler *")]
                ICallControlEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(22)]
        HRESULT remove_AudioTransferRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean, HSTRING, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, HSTRING, ulong*, int> IndicateNewIncomingCall;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> IndicateNewOutgoingCall;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> IndicateActiveCall;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> EndCall;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasRinger;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ICallControlEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICallControlEventHandler,
            EventRegistrationToken*,
            int> add_AnswerRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_AnswerRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ICallControlEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICallControlEventHandler,
            EventRegistrationToken*,
            int> add_HangUpRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_HangUpRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IDialRequestedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDialRequestedEventHandler,
            EventRegistrationToken*,
            int> add_DialRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DialRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IRedialRequestedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRedialRequestedEventHandler,
            EventRegistrationToken*,
            int> add_RedialRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RedialRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IKeypadPressedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IKeypadPressedEventHandler,
            EventRegistrationToken*,
            int> add_KeypadPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_KeypadPressed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ICallControlEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICallControlEventHandler,
            EventRegistrationToken*,
            int> add_AudioTransferRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AudioTransferRequested;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICallControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICallControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICallControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICallControl(Silk.NET.WinRT.IInspectable value)
    {
        return new ICallControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICallControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICallControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICallControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICallControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICallControl(Silk.NET.Windows.IUnknown value)
    {
        return new ICallControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICallControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICallControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICallControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
