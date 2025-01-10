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

[Guid("0BC3C9CB-C26A-40F2-AEB5-8096B2E48073")]
[NativeTypeName("struct ISpeechRecognizer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizer : ISpeechRecognizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_WinRT_ISpeechRecognizer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechRecognizer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecognizer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentLanguage(
        [NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage* language
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ILanguage*, int>)((*lpVtbl)[6]))(
            this,
            language
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Constraints(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, IVector<IntPtr>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Timeouts(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **")]
            ISpeechRecognizerTimeouts* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ISpeechRecognizerTimeouts*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UIOptions(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **")]
            ISpeechRecognizerUIOptions* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ISpeechRecognizerUIOptions*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CompileConstraintsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[10])
        )(this, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RecognizeAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RecognizeWithUIAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[12])
        )(this, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_RecognitionQualityDegrading(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* speechRecognitionQualityDegradingHandler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognizer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, speechRecognitionQualityDegradingHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_RecognitionQualityDegrading(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_StateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* stateChangedHandler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognizer,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, stateChangedHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_StateChanged(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, EventRegistrationToken, int>)((*lpVtbl)[16])
        )(this, cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentLanguage(
            [NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage* language
        );

        [VtblIndex(7)]
        HRESULT get_Constraints(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT get_Timeouts(
            [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **")]
                ISpeechRecognizerTimeouts* value
        );

        [VtblIndex(9)]
        HRESULT get_UIOptions(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **"
            )]
                ISpeechRecognizerUIOptions* value
        );

        [VtblIndex(10)]
        HRESULT CompileConstraintsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOperation
        );

        [VtblIndex(11)]
        HRESULT RecognizeAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOperation
        );

        [VtblIndex(12)]
        HRESULT RecognizeWithUIAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOperation
        );

        [VtblIndex(13)]
        HRESULT add_RecognitionQualityDegrading(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* speechRecognitionQualityDegradingHandler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(14)]
        HRESULT remove_RecognitionQualityDegrading(EventRegistrationToken cookie);

        [VtblIndex(15)]
        HRESULT add_StateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* stateChangedHandler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(16)]
        HRESULT remove_StateChanged(EventRegistrationToken cookie);
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
            "HRESULT (ABI::Windows::Globalization::ILanguage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ILanguage*, int> get_CurrentLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Constraints;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpeechRecognizerTimeouts*, int> get_Timeouts;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpeechRecognizerUIOptions*, int> get_UIOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> CompileConstraintsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> RecognizeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> RecognizeWithUIAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RecognitionQualityDegrading;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RecognitionQualityDegrading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechRecognizer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechRecognizer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechRecognizer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechRecognizer(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechRecognizer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognizer"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognizer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechRecognizer value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechRecognizer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechRecognizer(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechRecognizer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognizer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognizer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechRecognizer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
