// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B84723B8-2C77-486A-900A-A3453EEDC15D")]
[NativeTypeName("struct ITextPredictionGenerator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextPredictionGenerator2
    : ITextPredictionGenerator2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextPredictionGenerator2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextPredictionGenerator2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextPredictionGenerator2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextPredictionGenerator2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITextPredictionGenerator2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITextPredictionGenerator2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITextPredictionGenerator2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCandidatesWithParametersAsync(
        HSTRING input,
        [NativeTypeName("UINT32")] uint maxCandidates,
        [NativeTypeName("ABI::Windows::Data::Text::TextPredictionOptions")]
            TextPredictionOptions predictionOptions,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* previousStrings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ITextPredictionGenerator2,
                HSTRING,
                uint,
                TextPredictionOptions,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, input, maxCandidates, predictionOptions, previousStrings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNextWordCandidatesAsync(
        [NativeTypeName("UINT32")] uint maxCandidates,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* previousStrings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ITextPredictionGenerator2,
                uint,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, maxCandidates, previousStrings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputScope(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")]
            CoreTextInputScope* value
    )
    {
        return (
            (delegate* unmanaged<ITextPredictionGenerator2, CoreTextInputScope*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InputScope(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")]
            CoreTextInputScope value
    )
    {
        return (
            (delegate* unmanaged<ITextPredictionGenerator2, CoreTextInputScope, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCandidatesWithParametersAsync(
            HSTRING input,
            [NativeTypeName("UINT32")] uint maxCandidates,
            [NativeTypeName("ABI::Windows::Data::Text::TextPredictionOptions")]
                TextPredictionOptions predictionOptions,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* previousStrings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetNextWordCandidatesAsync(
            [NativeTypeName("UINT32")] uint maxCandidates,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* previousStrings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT get_InputScope(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")]
                CoreTextInputScope* value
        );

        [VtblIndex(9)]
        HRESULT put_InputScope(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")]
                CoreTextInputScope value
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
            "HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::TextPredictionOptions, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            TextPredictionOptions,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> GetCandidatesWithParametersAsync;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> GetNextWordCandidatesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextInputScope*, int> get_InputScope;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextInputScope, int> put_InputScope;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextPredictionGenerator2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextPredictionGenerator2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITextPredictionGenerator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITextPredictionGenerator2(Silk.NET.WinRT.IInspectable value)
    {
        return new ITextPredictionGenerator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextPredictionGenerator2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITextPredictionGenerator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITextPredictionGenerator2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextPredictionGenerator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextPredictionGenerator2(Silk.NET.Windows.IUnknown value)
    {
        return new ITextPredictionGenerator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextPredictionGenerator2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextPredictionGenerator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextPredictionGenerator2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
