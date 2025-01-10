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

[Guid("51E7F514-9C51-4D86-AE1B-B498FBAD8313")]
[NativeTypeName("struct ITextReverseConversionGenerator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextReverseConversionGenerator
    : ITextReverseConversionGenerator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextReverseConversionGenerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITextReverseConversionGenerator, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITextReverseConversionGenerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextReverseConversionGenerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ITextReverseConversionGenerator, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ITextReverseConversionGenerator, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ITextReverseConversionGenerator, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ITextReverseConversionGenerator, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LanguageAvailableButNotInstalled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITextReverseConversionGenerator, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertBackAsync(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                ITextReverseConversionGenerator,
                HSTRING,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[8])
        )(this, input, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolvedLanguage(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_LanguageAvailableButNotInstalled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT ConvertBackAsync(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ResolvedLanguage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_LanguageAvailableButNotInstalled;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<HSTRING>**,
            int> ConvertBackAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextReverseConversionGenerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextReverseConversionGenerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITextReverseConversionGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITextReverseConversionGenerator(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ITextReverseConversionGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextReverseConversionGenerator"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITextReverseConversionGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ITextReverseConversionGenerator value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextReverseConversionGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextReverseConversionGenerator(Silk.NET.Windows.IUnknown value)
    {
        return new ITextReverseConversionGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextReverseConversionGenerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextReverseConversionGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextReverseConversionGenerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
