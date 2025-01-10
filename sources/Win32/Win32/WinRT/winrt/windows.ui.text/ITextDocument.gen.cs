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

[Guid("BEEE4DDB-90B2-408C-A2F6-0A0AC31E33E4")]
[NativeTypeName("struct ITextDocument : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextDocument : ITextDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextDocument));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextDocument, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextDocument, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextDocument, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITextDocument, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITextDocument, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITextDocument, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CaretType(
        [NativeTypeName("ABI::Windows::UI::Text::CaretType *")] CaretType* value
    )
    {
        return ((delegate* unmanaged<ITextDocument, CaretType*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CaretType(
        [NativeTypeName("ABI::Windows::UI::Text::CaretType")] CaretType value
    )
    {
        return ((delegate* unmanaged<ITextDocument, CaretType, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DefaultTabStop(float* value)
    {
        return ((delegate* unmanaged<ITextDocument, float*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DefaultTabStop(float value)
    {
        return ((delegate* unmanaged<ITextDocument, float, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Selection(
        [NativeTypeName("ABI::Windows::UI::Text::ITextSelection **")] ITextSelection* value
    )
    {
        return ((delegate* unmanaged<ITextDocument, ITextSelection*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UndoLimit([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ITextDocument, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_UndoLimit([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ITextDocument, uint, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CanCopy([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<ITextDocument, byte*, int>)((*lpVtbl)[13]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CanPaste([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<ITextDocument, byte*, int>)((*lpVtbl)[14]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CanRedo([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<ITextDocument, byte*, int>)((*lpVtbl)[15]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanUndo([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<ITextDocument, byte*, int>)((*lpVtbl)[16]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ApplyDisplayUpdates([NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged<ITextDocument, int*, int>)((*lpVtbl)[17]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT BatchDisplayUpdates([NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged<ITextDocument, int*, int>)((*lpVtbl)[18]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT BeginUndoGroup()
    {
        return ((delegate* unmanaged<ITextDocument, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT EndUndoGroup()
    {
        return ((delegate* unmanaged<ITextDocument, int>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDefaultCharacterFormat(
        [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")]
            ITextCharacterFormat* result
    )
    {
        return ((delegate* unmanaged<ITextDocument, ITextCharacterFormat*, int>)((*lpVtbl)[21]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetDefaultParagraphFormat(
        [NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")]
            ITextParagraphFormat* result
    )
    {
        return ((delegate* unmanaged<ITextDocument, ITextParagraphFormat*, int>)((*lpVtbl)[22]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetRange(
        [NativeTypeName("INT32")] int startPosition,
        [NativeTypeName("INT32")] int endPosition,
        [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange* result
    )
    {
        return ((delegate* unmanaged<ITextDocument, int, int, ITextRange*, int>)((*lpVtbl)[23]))(
            this,
            startPosition,
            endPosition,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRangeFromPoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point point,
        [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options,
        [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange* result
    )
    {
        return (
            (delegate* unmanaged<ITextDocument, Point, PointOptions, ITextRange*, int>)(
                (*lpVtbl)[24]
            )
        )(this, point, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetText(
        [NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options,
        HSTRING* value
    )
    {
        return ((delegate* unmanaged<ITextDocument, TextGetOptions, HSTRING*, int>)((*lpVtbl)[25]))(
            this,
            options,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT LoadFromStream(
        [NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream value
    )
    {
        return (
            (delegate* unmanaged<ITextDocument, TextSetOptions, IRandomAccessStream, int>)(
                (*lpVtbl)[26]
            )
        )(this, options, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Redo()
    {
        return ((delegate* unmanaged<ITextDocument, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveToStream(
        [NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream value
    )
    {
        return (
            (delegate* unmanaged<ITextDocument, TextGetOptions, IRandomAccessStream, int>)(
                (*lpVtbl)[28]
            )
        )(this, options, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetDefaultCharacterFormat(
        [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
            ITextCharacterFormat value
    )
    {
        return ((delegate* unmanaged<ITextDocument, ITextCharacterFormat, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetDefaultParagraphFormat(
        [NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")]
            ITextParagraphFormat value
    )
    {
        return ((delegate* unmanaged<ITextDocument, ITextParagraphFormat, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetText(
        [NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options,
        HSTRING value
    )
    {
        return ((delegate* unmanaged<ITextDocument, TextSetOptions, HSTRING, int>)((*lpVtbl)[31]))(
            this,
            options,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Undo()
    {
        return ((delegate* unmanaged<ITextDocument, int>)((*lpVtbl)[32]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CaretType(
            [NativeTypeName("ABI::Windows::UI::Text::CaretType *")] CaretType* value
        );

        [VtblIndex(7)]
        HRESULT put_CaretType(
            [NativeTypeName("ABI::Windows::UI::Text::CaretType")] CaretType value
        );

        [VtblIndex(8)]
        HRESULT get_DefaultTabStop(float* value);

        [VtblIndex(9)]
        HRESULT put_DefaultTabStop(float value);

        [VtblIndex(10)]
        HRESULT get_Selection(
            [NativeTypeName("ABI::Windows::UI::Text::ITextSelection **")] ITextSelection* value
        );

        [VtblIndex(11)]
        HRESULT get_UndoLimit([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_UndoLimit([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT CanCopy([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT CanPaste([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(15)]
        HRESULT CanRedo([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(16)]
        HRESULT CanUndo([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(17)]
        HRESULT ApplyDisplayUpdates([NativeTypeName("INT32 *")] int* result);

        [VtblIndex(18)]
        HRESULT BatchDisplayUpdates([NativeTypeName("INT32 *")] int* result);

        [VtblIndex(19)]
        HRESULT BeginUndoGroup();

        [VtblIndex(20)]
        HRESULT EndUndoGroup();

        [VtblIndex(21)]
        HRESULT GetDefaultCharacterFormat(
            [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")]
                ITextCharacterFormat* result
        );

        [VtblIndex(22)]
        HRESULT GetDefaultParagraphFormat(
            [NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")]
                ITextParagraphFormat* result
        );

        [VtblIndex(23)]
        HRESULT GetRange(
            [NativeTypeName("INT32")] int startPosition,
            [NativeTypeName("INT32")] int endPosition,
            [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange* result
        );

        [VtblIndex(24)]
        HRESULT GetRangeFromPoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point point,
            [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options,
            [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange* result
        );

        [VtblIndex(25)]
        HRESULT GetText(
            [NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options,
            HSTRING* value
        );

        [VtblIndex(26)]
        HRESULT LoadFromStream(
            [NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream value
        );

        [VtblIndex(27)]
        HRESULT Redo();

        [VtblIndex(28)]
        HRESULT SaveToStream(
            [NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream value
        );

        [VtblIndex(29)]
        HRESULT SetDefaultCharacterFormat(
            [NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")]
                ITextCharacterFormat value
        );

        [VtblIndex(30)]
        HRESULT SetDefaultParagraphFormat(
            [NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")]
                ITextParagraphFormat value
        );

        [VtblIndex(31)]
        HRESULT SetText(
            [NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options,
            HSTRING value
        );

        [VtblIndex(32)]
        HRESULT Undo();
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::CaretType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CaretType*, int> get_CaretType;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::CaretType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CaretType, int> put_CaretType;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DefaultTabStop;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DefaultTabStop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextSelection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextSelection*, int> get_Selection;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_UndoLimit;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_UndoLimit;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> CanCopy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> CanPaste;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> CanRedo;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> CanUndo;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> ApplyDisplayUpdates;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> BatchDisplayUpdates;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginUndoGroup;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndUndoGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextCharacterFormat*, int> GetDefaultCharacterFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextParagraphFormat*, int> GetDefaultParagraphFormat;

        [NativeTypeName(
            "HRESULT (INT32, INT32, ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, ITextRange*, int> GetRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::UI::Text::PointOptions, ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, PointOptions, ITextRange*, int> GetRangeFromPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextGetOptions, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextGetOptions, HSTRING*, int> GetText;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextSetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextSetOptions, IRandomAccessStream, int> LoadFromStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Redo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextGetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextGetOptions, IRandomAccessStream, int> SaveToStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextCharacterFormat, int> SetDefaultCharacterFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITextParagraphFormat, int> SetDefaultParagraphFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::TextSetOptions, HSTRING) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TextSetOptions, HSTRING, int> SetText;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Undo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextDocument"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextDocument(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITextDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITextDocument(Silk.NET.WinRT.IInspectable value)
    {
        return new ITextDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextDocument"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITextDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITextDocument value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextDocument(Silk.NET.Windows.IUnknown value)
    {
        return new ITextDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextDocument"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextDocument value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
