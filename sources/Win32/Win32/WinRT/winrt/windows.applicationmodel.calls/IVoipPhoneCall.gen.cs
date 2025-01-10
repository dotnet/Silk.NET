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

[Guid("6CF1F19A-7794-4A5A-8C68-AE87947A6990")]
[NativeTypeName("struct IVoipPhoneCall : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipPhoneCall : IVoipPhoneCall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipPhoneCall));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVoipPhoneCall, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVoipPhoneCall, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVoipPhoneCall, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_EndRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_EndRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_HoldRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_HoldRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[9]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ResumeRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ResumeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[11]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_AnswerRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* acceptHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, acceptHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_AnswerRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[13]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_RejectRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* rejectHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, rejectHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_RejectRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[15]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT NotifyCallHeld()
    {
        return ((delegate* unmanaged<IVoipPhoneCall, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT NotifyCallActive()
    {
        return ((delegate* unmanaged<IVoipPhoneCall, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT NotifyCallEnded()
    {
        return ((delegate* unmanaged<IVoipPhoneCall, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ContactName(HSTRING* value)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, HSTRING*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ContactName(HSTRING value)
    {
        return ((delegate* unmanaged<IVoipPhoneCall, HSTRING, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_StartTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IVoipPhoneCall, WinRTDateTime*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_StartTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return ((delegate* unmanaged<IVoipPhoneCall, WinRTDateTime, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CallMedia(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")]
            VoipPhoneCallMedia* value
    )
    {
        return ((delegate* unmanaged<IVoipPhoneCall, VoipPhoneCallMedia*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_CallMedia(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
            VoipPhoneCallMedia value
    )
    {
        return ((delegate* unmanaged<IVoipPhoneCall, VoipPhoneCallMedia, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT NotifyCallReady()
    {
        return ((delegate* unmanaged<IVoipPhoneCall, int>)((*lpVtbl)[25]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_EndRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_EndRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_HoldRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_HoldRequested(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_ResumeRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_ResumeRequested(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_AnswerRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* acceptHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_AnswerRequested(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_RejectRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* rejectHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        HRESULT remove_RejectRequested(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT NotifyCallHeld();

        [VtblIndex(17)]
        HRESULT NotifyCallActive();

        [VtblIndex(18)]
        HRESULT NotifyCallEnded();

        [VtblIndex(19)]
        HRESULT get_ContactName(HSTRING* value);

        [VtblIndex(20)]
        HRESULT put_ContactName(HSTRING value);

        [VtblIndex(21)]
        HRESULT get_StartTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(22)]
        HRESULT put_StartTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(23)]
        HRESULT get_CallMedia(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")]
                VoipPhoneCallMedia* value
        );

        [VtblIndex(24)]
        HRESULT put_CallMedia(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
                VoipPhoneCallMedia value
        );

        [VtblIndex(25)]
        HRESULT NotifyCallReady();
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_EndRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_EndRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_HoldRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_HoldRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ResumeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ResumeRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_AnswerRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_AnswerRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RejectRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RejectRequested;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyCallHeld;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyCallActive;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyCallEnded;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContactName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContactName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> put_StartTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VoipPhoneCallMedia*, int> get_CallMedia;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VoipPhoneCallMedia, int> put_CallMedia;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyCallReady;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVoipPhoneCall"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVoipPhoneCall(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVoipPhoneCall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVoipPhoneCall(Silk.NET.WinRT.IInspectable value)
    {
        return new IVoipPhoneCall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipPhoneCall"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipPhoneCall"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVoipPhoneCall value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVoipPhoneCall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVoipPhoneCall(Silk.NET.Windows.IUnknown value)
    {
        return new IVoipPhoneCall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipPhoneCall"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipPhoneCall"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVoipPhoneCall value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
