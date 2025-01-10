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

[Guid("F6DC31E7-4B13-45C5-8897-7D71269E085D")]
[NativeTypeName("struct ISelectableWordsSegmenter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISelectableWordsSegmenter
    : ISelectableWordsSegmenter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISelectableWordsSegmenter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISelectableWordsSegmenter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged<ISelectableWordsSegmenter, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTokenAt(
        HSTRING text,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegment **")]
            ISelectableWordSegment* result
    )
    {
        return (
            (delegate* unmanaged<
                ISelectableWordsSegmenter,
                HSTRING,
                uint,
                ISelectableWordSegment*,
                int>)((*lpVtbl)[7])
        )(this, text, startIndex, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTokens(
        HSTRING text,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<ISelectableWordsSegmenter, HSTRING, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, text, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Tokenize(
        HSTRING text,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *")]
            ISelectableWordSegmentsTokenizingHandler handler
    )
    {
        return (
            (delegate* unmanaged<
                ISelectableWordsSegmenter,
                HSTRING,
                uint,
                ISelectableWordSegmentsTokenizingHandler,
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
            [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegment **")]
                ISelectableWordSegment* result
        );

        [VtblIndex(8)]
        HRESULT GetTokens(
            HSTRING text,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT Tokenize(
            HSTRING text,
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *")]
                ISelectableWordSegmentsTokenizingHandler handler
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
            "HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::ISelectableWordSegment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, uint, ISelectableWordSegment*, int> GetTokenAt;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IVectorView<IntPtr>**, int> GetTokens;

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            ISelectableWordSegmentsTokenizingHandler,
            int> Tokenize;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISelectableWordsSegmenter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISelectableWordsSegmenter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISelectableWordsSegmenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISelectableWordsSegmenter(Silk.NET.WinRT.IInspectable value)
    {
        return new ISelectableWordsSegmenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISelectableWordsSegmenter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISelectableWordsSegmenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISelectableWordsSegmenter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISelectableWordsSegmenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISelectableWordsSegmenter(Silk.NET.Windows.IUnknown value)
    {
        return new ISelectableWordsSegmenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISelectableWordsSegmenter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISelectableWordsSegmenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISelectableWordsSegmenter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
