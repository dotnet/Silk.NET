// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret"]/*'/>
[Guid("3050F604-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCaret : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLCaret : IHTMLCaret.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCaret));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCaret*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLCaret*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCaret*, uint> )(lpVtbl[1]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCaret*, uint> )(lpVtbl[2]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.MoveCaretToPointer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MoveCaretToPointer(IDisplayPointer* pDispPointer, BOOL fScrollIntoView, CARET_DIRECTION eDir)
    {
        return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, CARET_DIRECTION, int> )(lpVtbl[3]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fScrollIntoView, eDir);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.MoveCaretToPointerEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MoveCaretToPointerEx(IDisplayPointer* pDispPointer, BOOL fVisible, BOOL fScrollIntoView, CARET_DIRECTION eDir)
    {
        return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, BOOL, CARET_DIRECTION, int> )(lpVtbl[4]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fVisible, fScrollIntoView, eDir);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.MoveMarkupPointerToCaret"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveMarkupPointerToCaret(IMarkupPointer* pIMarkupPointer)
    {
        return ((delegate* unmanaged<IHTMLCaret*, IMarkupPointer*, int> )(lpVtbl[5]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIMarkupPointer);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.MoveDisplayPointerToCaret"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MoveDisplayPointerToCaret(IDisplayPointer* pDispPointer)
    {
        return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, int> )(lpVtbl[6]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.IsVisible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsVisible(BOOL* pIsVisible)
    {
        return ((delegate* unmanaged<IHTMLCaret*, BOOL*, int> )(lpVtbl[7]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIsVisible);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Show(BOOL fScrollIntoView)
    {
        return ((delegate* unmanaged<IHTMLCaret*, BOOL, int> )(lpVtbl[8]))((IHTMLCaret*)Unsafe.AsPointer(ref this), fScrollIntoView);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.Hide"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged<IHTMLCaret*, int> )(lpVtbl[9]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.InsertText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertText([NativeTypeName("OLECHAR *")] ushort* pText, [NativeTypeName("LONG")] int lLen)
    {
        return ((delegate* unmanaged<IHTMLCaret*, ushort*, int, int> )(lpVtbl[10]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pText, lLen);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.ScrollIntoView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ScrollIntoView()
    {
        return ((delegate* unmanaged<IHTMLCaret*, int> )(lpVtbl[11]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.GetLocation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLocation(POINT* pPoint, BOOL fTranslate)
    {
        return ((delegate* unmanaged<IHTMLCaret*, POINT*, BOOL, int> )(lpVtbl[12]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pPoint, fTranslate);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.GetCaretDirection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCaretDirection(CARET_DIRECTION* peDir)
    {
        return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION*, int> )(lpVtbl[13]))((IHTMLCaret*)Unsafe.AsPointer(ref this), peDir);
    }

    /// <include file='IHTMLCaret.xml' path='doc/member[@name="IHTMLCaret.SetCaretDirection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCaretDirection(CARET_DIRECTION eDir)
    {
        return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION, int> )(lpVtbl[14]))((IHTMLCaret*)Unsafe.AsPointer(ref this), eDir);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MoveCaretToPointer(IDisplayPointer* pDispPointer, BOOL fScrollIntoView, CARET_DIRECTION eDir);
        [VtblIndex(4)]
        HRESULT MoveCaretToPointerEx(IDisplayPointer* pDispPointer, BOOL fVisible, BOOL fScrollIntoView, CARET_DIRECTION eDir);
        [VtblIndex(5)]
        HRESULT MoveMarkupPointerToCaret(IMarkupPointer* pIMarkupPointer);
        [VtblIndex(6)]
        HRESULT MoveDisplayPointerToCaret(IDisplayPointer* pDispPointer);
        [VtblIndex(7)]
        HRESULT IsVisible(BOOL* pIsVisible);
        [VtblIndex(8)]
        HRESULT Show(BOOL fScrollIntoView);
        [VtblIndex(9)]
        HRESULT Hide();
        [VtblIndex(10)]
        HRESULT InsertText([NativeTypeName("OLECHAR *")] ushort* pText, [NativeTypeName("LONG")] int lLen);
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
        [NativeTypeName("HRESULT (IDisplayPointer *, BOOL, CARET_DIRECTION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer*, BOOL, CARET_DIRECTION, int> MoveCaretToPointer;
        [NativeTypeName("HRESULT (IDisplayPointer *, BOOL, BOOL, CARET_DIRECTION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer*, BOOL, BOOL, CARET_DIRECTION, int> MoveCaretToPointerEx;
        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, int> MoveMarkupPointerToCaret;
        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer*, int> MoveDisplayPointerToCaret;
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
}