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

[Guid("86B4D4D1-B2FE-4E34-A81D-66640300454F")]
[NativeTypeName("struct IWordsSegmenter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWordsSegmenter : IWordsSegmenter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWordsSegmenter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWordsSegmenter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWordsSegmenter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWordsSegmenter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWordsSegmenter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWordsSegmenter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWordsSegmenter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged<IWordsSegmenter, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTokenAt(
        HSTRING text,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("ABI::Windows::Data::Text::IWordSegment **")] IWordSegment* result
    )
    {
        return (
            (delegate* unmanaged<IWordsSegmenter, HSTRING, uint, IWordSegment*, int>)((*lpVtbl)[7])
        )(this, text, startIndex, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTokens(
        HSTRING text,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CWordSegment_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IWordsSegmenter, HSTRING, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, text, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Tokenize(
        HSTRING text,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("ABI::Windows::Data::Text::IWordSegmentsTokenizingHandler *")]
            IWordSegmentsTokenizingHandler handler
    )
    {
        return (
            (delegate* unmanaged<
                IWordsSegmenter,
                HSTRING,
                uint,
                IWordSegmentsTokenizingHandler,
                int>)((*lpVtbl)[9])
        )(this, text, startIndex, handler);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolvedLanguage(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetTokenAt(
            HSTRING text,
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("ABI::Windows::Data::Text::IWordSegment **")] IWordSegment* result
        );

        [VtblIndex(8)]
        HRESULT GetTokens(
            HSTRING text,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CWordSegment_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT Tokenize(
            HSTRING text,
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("ABI::Windows::Data::Text::IWordSegmentsTokenizingHandler *")]
                IWordSegmentsTokenizingHandler handler
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

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::IWordSegment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, uint, IWordSegment*, int> GetTokenAt;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CWordSegment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IVectorView<IntPtr>**, int> GetTokens;

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::IWordSegmentsTokenizingHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            IWordSegmentsTokenizingHandler,
            int> Tokenize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWordsSegmenter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWordsSegmenter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWordsSegmenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWordsSegmenter(Silk.NET.WinRT.IInspectable value)
    {
        return new IWordsSegmenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWordsSegmenter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWordsSegmenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWordsSegmenter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWordsSegmenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWordsSegmenter(Silk.NET.Windows.IUnknown value)
    {
        return new IWordsSegmenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWordsSegmenter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWordsSegmenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWordsSegmenter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
