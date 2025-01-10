// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F604-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCaret : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLCaret : IHTMLCaret.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCaret));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCaret, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLCaret, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCaret, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MoveCaretToPointer(
        IDisplayPointer pDispPointer,
        BOOL fScrollIntoView,
        CARET_DIRECTION eDir
    )
    {
        return (
            (delegate* unmanaged<IHTMLCaret, IDisplayPointer, BOOL, CARET_DIRECTION, int>)(
                (*lpVtbl)[3]
            )
        )(this, pDispPointer, fScrollIntoView, eDir);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MoveCaretToPointerEx(
        IDisplayPointer pDispPointer,
        BOOL fVisible,
        BOOL fScrollIntoView,
        CARET_DIRECTION eDir
    )
    {
        return (
            (delegate* unmanaged<IHTMLCaret, IDisplayPointer, BOOL, BOOL, CARET_DIRECTION, int>)(
                (*lpVtbl)[4]
            )
        )(this, pDispPointer, fVisible, fScrollIntoView, eDir);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveMarkupPointerToCaret(IMarkupPointer pIMarkupPointer)
    {
        return ((delegate* unmanaged<IHTMLCaret, IMarkupPointer, int>)((*lpVtbl)[5]))(
            this,
            pIMarkupPointer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MoveDisplayPointerToCaret(IDisplayPointer pDispPointer)
    {
        return ((delegate* unmanaged<IHTMLCaret, IDisplayPointer, int>)((*lpVtbl)[6]))(
            this,
            pDispPointer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsVisible(BOOL* pIsVisible)
    {
        return ((delegate* unmanaged<IHTMLCaret, BOOL*, int>)((*lpVtbl)[7]))(this, pIsVisible);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Show(BOOL fScrollIntoView)
    {
        return ((delegate* unmanaged<IHTMLCaret, BOOL, int>)((*lpVtbl)[8]))(this, fScrollIntoView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged<IHTMLCaret, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertText(
        [NativeTypeName("OLECHAR *")] ushort* pText,
        [NativeTypeName("LONG")] int lLen
    )
    {
        return ((delegate* unmanaged<IHTMLCaret, ushort*, int, int>)((*lpVtbl)[10]))(
            this,
            pText,
            lLen
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ScrollIntoView()
    {
        return ((delegate* unmanaged<IHTMLCaret, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLocation(POINT* pPoint, BOOL fTranslate)
    {
        return ((delegate* unmanaged<IHTMLCaret, POINT*, BOOL, int>)((*lpVtbl)[12]))(
            this,
            pPoint,
            fTranslate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCaretDirection(CARET_DIRECTION* peDir)
    {
        return ((delegate* unmanaged<IHTMLCaret, CARET_DIRECTION*, int>)((*lpVtbl)[13]))(
            this,
            peDir
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCaretDirection(CARET_DIRECTION eDir)
    {
        return ((delegate* unmanaged<IHTMLCaret, CARET_DIRECTION, int>)((*lpVtbl)[14]))(this, eDir);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MoveCaretToPointer(
            IDisplayPointer pDispPointer,
            BOOL fScrollIntoView,
            CARET_DIRECTION eDir
        );

        [VtblIndex(4)]
        HRESULT MoveCaretToPointerEx(
            IDisplayPointer pDispPointer,
            BOOL fVisible,
            BOOL fScrollIntoView,
            CARET_DIRECTION eDir
        );

        [VtblIndex(5)]
        HRESULT MoveMarkupPointerToCaret(IMarkupPointer pIMarkupPointer);

        [VtblIndex(6)]
        HRESULT MoveDisplayPointerToCaret(IDisplayPointer pDispPointer);

        [VtblIndex(7)]
        HRESULT IsVisible(BOOL* pIsVisible);

        [VtblIndex(8)]
        HRESULT Show(BOOL fScrollIntoView);

        [VtblIndex(9)]
        HRESULT Hide();

        [VtblIndex(10)]
        HRESULT InsertText(
            [NativeTypeName("OLECHAR *")] ushort* pText,
            [NativeTypeName("LONG")] int lLen
        );

        [VtblIndex(11)]
        HRESULT ScrollIntoView();

        [VtblIndex(12)]
        HRESULT GetLocation(POINT* pPoint, BOOL fTranslate);

        [VtblIndex(13)]
        HRESULT GetCaretDirection(CARET_DIRECTION* peDir);

        [VtblIndex(14)]
        HRESULT SetCaretDirection(CARET_DIRECTION eDir);
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

        [NativeTypeName(
            "HRESULT (IDisplayPointer *, BOOL, CARET_DIRECTION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPointer,
            BOOL,
            CARET_DIRECTION,
            int> MoveCaretToPointer;

        [NativeTypeName(
            "HRESULT (IDisplayPointer *, BOOL, BOOL, CARET_DIRECTION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPointer,
            BOOL,
            BOOL,
            CARET_DIRECTION,
            int> MoveCaretToPointerEx;

        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, int> MoveMarkupPointerToCaret;

        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer, int> MoveDisplayPointerToCaret;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsVisible;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Hide;

        [NativeTypeName("HRESULT (OLECHAR *, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> InsertText;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ScrollIntoView;

        [NativeTypeName("HRESULT (POINT *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, BOOL, int> GetLocation;

        [NativeTypeName("HRESULT (CARET_DIRECTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CARET_DIRECTION*, int> GetCaretDirection;

        [NativeTypeName("HRESULT (CARET_DIRECTION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CARET_DIRECTION, int> SetCaretDirection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLCaret"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLCaret(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLCaret"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLCaret(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLCaret(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLCaret"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLCaret"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLCaret value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
