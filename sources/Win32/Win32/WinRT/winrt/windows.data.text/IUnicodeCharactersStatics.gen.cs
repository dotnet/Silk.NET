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

[Guid("97909E87-9291-4F91-B6C8-B6E359D7A7FB")]
[NativeTypeName("struct IUnicodeCharactersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUnicodeCharactersStatics
    : IUnicodeCharactersStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnicodeCharactersStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCodepointFromSurrogatePair(
        [NativeTypeName("UINT32")] uint highSurrogate,
        [NativeTypeName("UINT32")] uint lowSurrogate,
        [NativeTypeName("UINT32 *")] uint* codepoint
    )
    {
        return (
            (delegate* unmanaged<IUnicodeCharactersStatics, uint, uint, uint*, int>)((*lpVtbl)[6])
        )(this, highSurrogate, lowSurrogate, codepoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSurrogatePairFromCodepoint(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("WCHAR *")] ushort* highSurrogate,
        [NativeTypeName("WCHAR *")] ushort* lowSurrogate
    )
    {
        return (
            (delegate* unmanaged<IUnicodeCharactersStatics, uint, ushort*, ushort*, int>)(
                (*lpVtbl)[7]
            )
        )(this, codepoint, highSurrogate, lowSurrogate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsHighSurrogate(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[8]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsLowSurrogate(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[9]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsSupplementary(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[10]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsNoncharacter(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[11]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsWhitespace(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[12]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsAlphabetic(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[13]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsCased(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[14]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsUppercase(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[15]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsLowercase(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[16]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsIdStart(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[17]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT IsIdContinue(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[18]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT IsGraphemeBase(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[19]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsGraphemeExtend(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IUnicodeCharactersStatics, uint, byte*, int>)((*lpVtbl)[20]))(
            this,
            codepoint,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetNumericType(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("ABI::Windows::Data::Text::UnicodeNumericType *")] UnicodeNumericType* value
    )
    {
        return (
            (delegate* unmanaged<IUnicodeCharactersStatics, uint, UnicodeNumericType*, int>)(
                (*lpVtbl)[21]
            )
        )(this, codepoint, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetGeneralCategory(
        [NativeTypeName("UINT32")] uint codepoint,
        [NativeTypeName("ABI::Windows::Data::Text::UnicodeGeneralCategory *")]
            UnicodeGeneralCategory* value
    )
    {
        return (
            (delegate* unmanaged<IUnicodeCharactersStatics, uint, UnicodeGeneralCategory*, int>)(
                (*lpVtbl)[22]
            )
        )(this, codepoint, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCodepointFromSurrogatePair(
            [NativeTypeName("UINT32")] uint highSurrogate,
            [NativeTypeName("UINT32")] uint lowSurrogate,
            [NativeTypeName("UINT32 *")] uint* codepoint
        );

        [VtblIndex(7)]
        HRESULT GetSurrogatePairFromCodepoint(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("WCHAR *")] ushort* highSurrogate,
            [NativeTypeName("WCHAR *")] ushort* lowSurrogate
        );

        [VtblIndex(8)]
        HRESULT IsHighSurrogate(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(9)]
        HRESULT IsLowSurrogate(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(10)]
        HRESULT IsSupplementary(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(11)]
        HRESULT IsNoncharacter(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(12)]
        HRESULT IsWhitespace(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(13)]
        HRESULT IsAlphabetic(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(14)]
        HRESULT IsCased(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(15)]
        HRESULT IsUppercase(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(16)]
        HRESULT IsLowercase(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(17)]
        HRESULT IsIdStart(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(18)]
        HRESULT IsIdContinue(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(19)]
        HRESULT IsGraphemeBase(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(20)]
        HRESULT IsGraphemeExtend(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(21)]
        HRESULT GetNumericType(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("ABI::Windows::Data::Text::UnicodeNumericType *")]
                UnicodeNumericType* value
        );

        [VtblIndex(22)]
        HRESULT GetGeneralCategory(
            [NativeTypeName("UINT32")] uint codepoint,
            [NativeTypeName("ABI::Windows::Data::Text::UnicodeGeneralCategory *")]
                UnicodeGeneralCategory* value
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

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> GetCodepointFromSurrogatePair;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            ushort*,
            int> GetSurrogatePairFromCodepoint;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsHighSurrogate;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsLowSurrogate;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsSupplementary;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsNoncharacter;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsWhitespace;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsAlphabetic;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsCased;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsUppercase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsLowercase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsIdStart;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsIdContinue;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsGraphemeBase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> IsGraphemeExtend;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Data::Text::UnicodeNumericType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, UnicodeNumericType*, int> GetNumericType;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Data::Text::UnicodeGeneralCategory *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, UnicodeGeneralCategory*, int> GetGeneralCategory;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUnicodeCharactersStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUnicodeCharactersStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUnicodeCharactersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUnicodeCharactersStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IUnicodeCharactersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUnicodeCharactersStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUnicodeCharactersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUnicodeCharactersStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUnicodeCharactersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUnicodeCharactersStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IUnicodeCharactersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUnicodeCharactersStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUnicodeCharactersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUnicodeCharactersStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
