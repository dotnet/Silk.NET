// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6A213C04-6614-49F8-99A2-B5E9B3A085C8")]
[NativeTypeName("struct ISpeechContinuousRecognitionSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechContinuousRecognitionSession
    : ISpeechContinuousRecognitionSession.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechContinuousRecognitionSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechContinuousRecognitionSession, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechContinuousRecognitionSession, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoStopSilenceTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, TimeSpan*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoStopSilenceTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, TimeSpan, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartWithModeAsync(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode")]
            SpeechContinuousRecognitionMode mode,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechContinuousRecognitionSession,
                SpeechContinuousRecognitionMode,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, mode, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, IAsyncAction*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CancelAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, IAsyncAction*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PauseAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, IAsyncAction*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<ISpeechContinuousRecognitionSession, int>)((*lpVtbl)[13]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_Completed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechContinuousRecognitionSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, value, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_Completed(EventRegistrationToken value)
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, EventRegistrationToken, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_ResultGenerated(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechContinuousRecognitionSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, value, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_ResultGenerated(EventRegistrationToken value)
    {
        return (
            (delegate* unmanaged<ISpeechContinuousRecognitionSession, EventRegistrationToken, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoStopSilenceTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(7)]
        HRESULT put_AutoStopSilenceTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(8)]
        HRESULT StartAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(9)]
        HRESULT StartWithModeAsync(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode"
            )]
                SpeechContinuousRecognitionMode mode,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(10)]
        HRESULT StopAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(11)]
        HRESULT CancelAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(12)]
        HRESULT PauseAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(13)]
        HRESULT Resume();

        [VtblIndex(14)]
        HRESULT add_Completed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* returnValue
        );

        [VtblIndex(15)]
        HRESULT remove_Completed(EventRegistrationToken value);

        [VtblIndex(16)]
        HRESULT add_ResultGenerated(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* returnValue
        );

        [VtblIndex(17)]
        HRESULT remove_ResultGenerated(EventRegistrationToken value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_AutoStopSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_AutoStopSilenceTimeout;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StartAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SpeechContinuousRecognitionMode,
            IAsyncAction*,
            int> StartWithModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StopAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> CancelAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> PauseAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Completed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ResultGenerated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ResultGenerated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechContinuousRecognitionSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechContinuousRecognitionSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpeechContinuousRecognitionSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpeechContinuousRecognitionSession(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISpeechContinuousRecognitionSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechContinuousRecognitionSession"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechContinuousRecognitionSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISpeechContinuousRecognitionSession value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechContinuousRecognitionSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechContinuousRecognitionSession(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpeechContinuousRecognitionSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechContinuousRecognitionSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechContinuousRecognitionSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpeechContinuousRecognitionSession value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
