// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A6D36724-F28F-430A-B2CF-C343671EC0E9")]
[NativeTypeName("struct ITextSelection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextSelection : ITextSelection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextSelection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextSelection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextSelection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextSelection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITextSelection, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITextSelection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITextSelection, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Options(
        [NativeTypeName("ABI::Windows::UI::Text::SelectionOptions *")] SelectionOptions* value
    )
    {
        return ((delegate* unmanaged<ITextSelection, SelectionOptions*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Options(
        [NativeTypeName("ABI::Windows::UI::Text::SelectionOptions")] SelectionOptions value
    )
    {
        return ((delegate* unmanaged<ITextSelection, SelectionOptions, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::UI::Text::SelectionType *")] SelectionType* value
    )
    {
        return ((delegate* unmanaged<ITextSelection, SelectionType*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndKey(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, byte, int*, int>)((*lpVtbl)[9])
        )(this, unit, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT HomeKey(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, byte, int*, int>)((*lpVtbl)[10])
        )(this, unit, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT MoveDown(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("INT32")] int count,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, int, byte, int*, int>)(
                (*lpVtbl)[11]
            )
        )(this, unit, count, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MoveLeft(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("INT32")] int count,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, int, byte, int*, int>)(
                (*lpVtbl)[12]
            )
        )(this, unit, count, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT MoveRight(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("INT32")] int count,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, int, byte, int*, int>)(
                (*lpVtbl)[13]
            )
        )(this, unit, count, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveUp(
        [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
        [NativeTypeName("INT32")] int count,
        [NativeTypeName("boolean")] byte extend,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return (
            (delegate* unmanaged<ITextSelection, TextRangeUnit, int, byte, int*, int>)(
                (*lpVtbl)[14]
            )
        )(this, unit, count, extend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TypeText(HSTRING value)
    {
        return ((delegate* unmanaged<ITextSelection, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Options(
            [NativeTypeName("ABI::Windows::UI::Text::SelectionOptions *")] SelectionOptions* value
        );

        [VtblIndex(7)]
        HRESULT put_Options(
            [NativeTypeName("ABI::Windows::UI::Text::SelectionOptions")] SelectionOptions value
        );

        [VtblIndex(8)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::UI::Text::SelectionType *")] SelectionType* value
        );

        [VtblIndex(9)]
        HRESULT EndKey(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(10)]
        HRESULT HomeKey(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(11)]
        HRESULT MoveDown(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("INT32")] int count,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(12)]
        HRESULT MoveLeft(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("INT32")] int count,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(13)]
        HRESULT MoveRight(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("INT32")] int count,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(14)]
        HRESULT MoveUp(
            [NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit,
            [NativeTypeName("INT32")] int count,
            [NativeTypeName("boolean")] byte extend,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(15)]
        HRESULT TypeText(HSTRING value);
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
            "HRESULT (ABI::Windows::UI::Text::SelectionOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SelectionOptions*, int> get_Options;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::SelectionOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SelectionOptions, int> put_Options;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::SelectionType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SelectionType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, byte, int*, int> EndKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, byte, int*, int> HomeKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, int, byte, int*, int> MoveDown;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, int, byte, int*, int> MoveLeft;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, int, byte, int*, int> MoveRight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextRangeUnit, int, byte, int*, int> MoveUp;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> TypeText;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextSelection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextSelection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITextSelection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITextSelection(Silk.NET.WinRT.IInspectable value)
    {
        return new ITextSelection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextSelection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITextSelection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITextSelection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextSelection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextSelection(Silk.NET.Windows.IUnknown value)
    {
        return new ITextSelection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextSelection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextSelection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextSelection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
