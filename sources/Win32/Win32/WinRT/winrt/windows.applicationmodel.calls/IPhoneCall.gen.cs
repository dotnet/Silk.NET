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

[Guid("C14ED0F8-C17D-59D2-9628-66E545B6CD21")]
[NativeTypeName("struct IPhoneCall : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCall : IPhoneCall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCall));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneCall, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneCall, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneCall, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneCall, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneCall, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneCall, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_StatusChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_AudioDeviceChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_AudioDeviceChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[9]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_IsMutedChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_IsMutedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IPhoneCall, EventRegistrationToken, int>)((*lpVtbl)[11]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CallId(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneCall, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPhoneCall, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *")]
            PhoneCallStatus* value
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallStatus*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AudioDevice(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *")]
            PhoneCallAudioDevice* value
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallAudioDevice*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPhoneCallInfo(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **")]
            IPhoneCallInfo* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, IPhoneCallInfo*, int>)((*lpVtbl)[16]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPhoneCallInfoAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return ((delegate* unmanaged<IPhoneCall, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[17]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT End(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[18]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EndAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[19]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SendDtmfKey(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")]
            DtmfToneAudioPlayback dtmfToneAudioPlayback,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                DtmfKey,
                DtmfToneAudioPlayback,
                PhoneCallOperationStatus*,
                int>)((*lpVtbl)[20])
        )(this, key, dtmfToneAudioPlayback, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SendDtmfKeyAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")]
            DtmfToneAudioPlayback dtmfToneAudioPlayback,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                DtmfKey,
                DtmfToneAudioPlayback,
                IAsyncOperation<PhoneCallOperationStatus>**,
                int>)((*lpVtbl)[21])
        )(this, key, dtmfToneAudioPlayback, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT AcceptIncoming(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[22]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT AcceptIncomingAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[23]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Hold(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[24]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT HoldAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[25]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ResumeFromHold(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[26]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ResumeFromHoldAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[27]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT Mute(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[28]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT MuteAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[29]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Unmute(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[30]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT UnmuteAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[31]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RejectIncoming(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return ((delegate* unmanaged<IPhoneCall, PhoneCallOperationStatus*, int>)((*lpVtbl)[32]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RejectIncomingAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, IAsyncOperation<PhoneCallOperationStatus>**, int>)(
                (*lpVtbl)[33]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT ChangeAudioDevice(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")]
            PhoneCallAudioDevice endpoint,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
            PhoneCallOperationStatus* result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCall, PhoneCallAudioDevice, PhoneCallOperationStatus*, int>)(
                (*lpVtbl)[34]
            )
        )(this, endpoint, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ChangeAudioDeviceAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")]
            PhoneCallAudioDevice endpoint,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
        )]
            IAsyncOperation<PhoneCallOperationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCall,
                PhoneCallAudioDevice,
                IAsyncOperation<PhoneCallOperationStatus>**,
                int>)((*lpVtbl)[35])
        )(this, endpoint, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_StatusChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_AudioDeviceChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_AudioDeviceChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_IsMutedChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_IsMutedChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_CallId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_Status(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *")]
                PhoneCallStatus* value
        );

        [VtblIndex(15)]
        HRESULT get_AudioDevice(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *")]
                PhoneCallAudioDevice* value
        );

        [VtblIndex(16)]
        HRESULT GetPhoneCallInfo(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **")]
                IPhoneCallInfo* result
        );

        [VtblIndex(17)]
        HRESULT GetPhoneCallInfoAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(18)]
        HRESULT End(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(19)]
        HRESULT EndAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(20)]
        HRESULT SendDtmfKey(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")]
                DtmfToneAudioPlayback dtmfToneAudioPlayback,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(21)]
        HRESULT SendDtmfKeyAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")]
                DtmfToneAudioPlayback dtmfToneAudioPlayback,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(22)]
        HRESULT AcceptIncoming(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(23)]
        HRESULT AcceptIncomingAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(24)]
        HRESULT Hold(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(25)]
        HRESULT HoldAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(26)]
        HRESULT ResumeFromHold(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(27)]
        HRESULT ResumeFromHoldAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(28)]
        HRESULT Mute(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(29)]
        HRESULT MuteAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(30)]
        HRESULT Unmute(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(31)]
        HRESULT UnmuteAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(32)]
        HRESULT RejectIncoming(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(33)]
        HRESULT RejectIncomingAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
        );

        [VtblIndex(34)]
        HRESULT ChangeAudioDevice(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")]
                PhoneCallAudioDevice endpoint,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")]
                PhoneCallOperationStatus* result
        );

        [VtblIndex(35)]
        HRESULT ChangeAudioDeviceAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")]
                PhoneCallAudioDevice endpoint,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **"
            )]
                IAsyncOperation<PhoneCallOperationStatus>** operation
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StatusChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_AudioDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_AudioDeviceChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_IsMutedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_IsMutedChanged;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CallId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMuted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallStatus*, int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallAudioDevice*, int> get_AudioDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneCallInfo*, int> GetPhoneCallInfo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetPhoneCallInfoAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> End;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> EndAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::DtmfKey, ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback, ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DtmfKey,
            DtmfToneAudioPlayback,
            PhoneCallOperationStatus*,
            int> SendDtmfKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::DtmfKey, ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DtmfKey,
            DtmfToneAudioPlayback,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> SendDtmfKeyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> AcceptIncoming;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> AcceptIncomingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> Hold;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> HoldAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> ResumeFromHold;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> ResumeFromHoldAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> Mute;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> MuteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> Unmute;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> UnmuteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneCallOperationStatus*, int> RejectIncoming;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> RejectIncomingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice, ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneCallAudioDevice,
            PhoneCallOperationStatus*,
            int> ChangeAudioDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneCallAudioDevice,
            IAsyncOperation<PhoneCallOperationStatus>**,
            int> ChangeAudioDeviceAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneCall"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneCall(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneCall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneCall(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneCall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCall"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCall"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneCall value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneCall"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneCall(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneCall(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCall"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCall"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneCall value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
