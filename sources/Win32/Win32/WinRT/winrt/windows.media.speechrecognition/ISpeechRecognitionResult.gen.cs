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

[Guid("4E303157-034E-4652-857E-D0454CC4BEEC")]
[NativeTypeName("struct ISpeechRecognitionResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionResult
    : ISpeechRecognitionResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechRecognitionResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *")]
            SpeechRecognitionResultStatus* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionResult, SpeechRecognitionResultStatus*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Confidence(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *")]
            SpeechRecognitionConfidence* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionResult, SpeechRecognitionConfidence*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SemanticInterpretation(
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **"
        )]
            ISpeechRecognitionSemanticInterpretation* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionResult,
                ISpeechRecognitionSemanticInterpretation*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAlternates(
        [NativeTypeName("UINT32")] uint maxAlternates,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
        )]
            IVectorView<IntPtr>** alternates
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionResult, uint, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, maxAlternates, alternates);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Constraint(
        [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **")]
            ISpeechRecognitionConstraint* value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionResult, ISpeechRecognitionConstraint*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RulePath(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionResult, IVectorView<HSTRING>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RawConfidence(double* value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionResult, double*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *"
            )]
                SpeechRecognitionResultStatus* value
        );

        [VtblIndex(7)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Confidence(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *"
            )]
                SpeechRecognitionConfidence* value
        );

        [VtblIndex(9)]
        HRESULT get_SemanticInterpretation(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **"
            )]
                ISpeechRecognitionSemanticInterpretation* value
        );

        [VtblIndex(10)]
        HRESULT GetAlternates(
            [NativeTypeName("UINT32")] uint maxAlternates,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **"
            )]
                IVectorView<IntPtr>** alternates
        );

        [VtblIndex(11)]
        HRESULT get_Constraint(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **"
            )]
                ISpeechRecognitionConstraint* value
        );

        [VtblIndex(12)]
        HRESULT get_RulePath(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(13)]
        HRESULT get_RawConfidence(double* value);
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
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechRecognitionResultStatus*, int> get_Status;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechRecognitionConfidence*, int> get_Confidence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpeechRecognitionSemanticInterpretation*,
            int> get_SemanticInterpretation;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IVectorView<IntPtr>**, int> GetAlternates;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpeechRecognitionConstraint*, int> get_Constraint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_RulePath;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RawConfidence;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechRecognitionResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechRecognitionResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpeechRecognitionResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionResult(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpeechRecognitionResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpeechRecognitionResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechRecognitionResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionResult(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechRecognitionResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechRecognitionResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
