// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9B2077B0-5F18-4DEC-BEE9-3CC722F5DFE0")]
[NativeTypeName("struct ITextStoreAnchor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreAnchor : ITextStoreAnchor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreAnchor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextStoreAnchor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseSink(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown punk,
        [NativeTypeName("DWORD")] uint dwMask
    )
    {
        return ((delegate* unmanaged<ITextStoreAnchor, Guid*, IUnknown, uint, int>)((*lpVtbl)[3]))(
            this,
            riid,
            punk,
            dwMask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseSink(IUnknown punk)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, IUnknown, int>)((*lpVtbl)[4]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint, HRESULT*, int>)((*lpVtbl)[5]))(
            this,
            dwLockFlags,
            phrSession
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStatus(TS_STATUS* pdcs)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, TS_STATUS*, int>)((*lpVtbl)[6]))(this, pdcs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryInsert(
        IAnchor paTestStart,
        IAnchor paTestEnd,
        [NativeTypeName("ULONG")] uint cch,
        IAnchor* ppaResultStart,
        IAnchor* ppaResultEnd
    )
    {
        return (
            (delegate* unmanaged<
                ITextStoreAnchor,
                IAnchor,
                IAnchor,
                uint,
                IAnchor*,
                IAnchor*,
                int>)((*lpVtbl)[7])
        )(this, paTestStart, paTestEnd, cch, ppaResultStart, ppaResultEnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSelection(
        [NativeTypeName("ULONG")] uint ulIndex,
        [NativeTypeName("ULONG")] uint ulCount,
        TS_SELECTION_ANCHOR* pSelection,
        [NativeTypeName("ULONG *")] uint* pcFetched
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, uint, TS_SELECTION_ANCHOR*, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, ulIndex, ulCount, pSelection, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSelection(
        [NativeTypeName("ULONG")] uint ulCount,
        [NativeTypeName("const TS_SELECTION_ANCHOR *")] TS_SELECTION_ANCHOR* pSelection
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, TS_SELECTION_ANCHOR*, int>)((*lpVtbl)[9])
        )(this, ulCount, pSelection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetText(
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor paStart,
        IAnchor paEnd,
        [NativeTypeName("WCHAR *")] ushort* pchText,
        [NativeTypeName("ULONG")] uint cchReq,
        [NativeTypeName("ULONG *")] uint* pcch,
        BOOL fUpdateAnchor
    )
    {
        return (
            (delegate* unmanaged<
                ITextStoreAnchor,
                uint,
                IAnchor,
                IAnchor,
                ushort*,
                uint,
                uint*,
                BOOL,
                int>)((*lpVtbl)[10])
        )(this, dwFlags, paStart, paEnd, pchText, cchReq, pcch, fUpdateAnchor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetText(
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor paStart,
        IAnchor paEnd,
        [NativeTypeName("const WCHAR *")] ushort* pchText,
        [NativeTypeName("ULONG")] uint cch
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, IAnchor, IAnchor, ushort*, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, dwFlags, paStart, paEnd, pchText, cch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFormattedText(IAnchor paStart, IAnchor paEnd, IDataObject* ppDataObject)
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, IAnchor, IAnchor, IDataObject*, int>)(
                (*lpVtbl)[12]
            )
        )(this, paStart, paEnd, ppDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetEmbedded(
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor paPos,
        [NativeTypeName("const GUID &")] Guid* rguidService,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppunk
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, IAnchor, Guid*, Guid*, IUnknown*, int>)(
                (*lpVtbl)[13]
            )
        )(this, dwFlags, paPos, rguidService, riid, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InsertEmbedded(
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor paStart,
        IAnchor paEnd,
        IDataObject pDataObject
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, IAnchor, IAnchor, IDataObject, int>)(
                (*lpVtbl)[14]
            )
        )(this, dwFlags, paStart, paEnd, pDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RequestSupportedAttrs(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG")] uint cFilterAttrs,
        [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs
    )
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint, uint, Guid*, int>)((*lpVtbl)[15]))(
            this,
            dwFlags,
            cFilterAttrs,
            paFilterAttrs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RequestAttrsAtPosition(
        IAnchor paPos,
        [NativeTypeName("ULONG")] uint cFilterAttrs,
        [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, IAnchor, uint, Guid*, uint, int>)((*lpVtbl)[16])
        )(this, paPos, cFilterAttrs, paFilterAttrs, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RequestAttrsTransitioningAtPosition(
        IAnchor paPos,
        [NativeTypeName("ULONG")] uint cFilterAttrs,
        [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, IAnchor, uint, Guid*, uint, int>)((*lpVtbl)[17])
        )(this, paPos, cFilterAttrs, paFilterAttrs, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FindNextAttrTransition(
        IAnchor paStart,
        IAnchor paHalt,
        [NativeTypeName("ULONG")] uint cFilterAttrs,
        [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
        [NativeTypeName("DWORD")] uint dwFlags,
        BOOL* pfFound,
        [NativeTypeName("LONG *")] int* plFoundOffset
    )
    {
        return (
            (delegate* unmanaged<
                ITextStoreAnchor,
                IAnchor,
                IAnchor,
                uint,
                Guid*,
                uint,
                BOOL*,
                int*,
                int>)((*lpVtbl)[18])
        )(this, paStart, paHalt, cFilterAttrs, paFilterAttrs, dwFlags, pfFound, plFoundOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RetrieveRequestedAttrs(
        [NativeTypeName("ULONG")] uint ulCount,
        TS_ATTRVAL* paAttrVals,
        [NativeTypeName("ULONG *")] uint* pcFetched
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, TS_ATTRVAL*, uint*, int>)((*lpVtbl)[19])
        )(this, ulCount, paAttrVals, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetStart(IAnchor* ppaStart)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, IAnchor*, int>)((*lpVtbl)[20]))(
            this,
            ppaStart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetEnd(IAnchor* ppaEnd)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, IAnchor*, int>)((*lpVtbl)[21]))(
            this,
            ppaEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint*, int>)((*lpVtbl)[22]))(this, pvcView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetAnchorFromPoint(
        [NativeTypeName("TsViewCookie")] uint vcView,
        [NativeTypeName("const POINT *")] POINT* ptScreen,
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor* ppaSite
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, POINT*, uint, IAnchor*, int>)(
                (*lpVtbl)[23]
            )
        )(this, vcView, ptScreen, dwFlags, ppaSite);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetTextExt(
        [NativeTypeName("TsViewCookie")] uint vcView,
        IAnchor paStart,
        IAnchor paEnd,
        RECT* prc,
        BOOL* pfClipped
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, IAnchor, IAnchor, RECT*, BOOL*, int>)(
                (*lpVtbl)[24]
            )
        )(this, vcView, paStart, paEnd, prc, pfClipped);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint, RECT*, int>)((*lpVtbl)[25]))(
            this,
            vcView,
            prc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetWnd([NativeTypeName("TsViewCookie")] uint vcView, HWND* phwnd)
    {
        return ((delegate* unmanaged<ITextStoreAnchor, uint, HWND*, int>)((*lpVtbl)[26]))(
            this,
            vcView,
            phwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT QueryInsertEmbedded(
        [NativeTypeName("const GUID *")] Guid* pguidService,
        [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc,
        BOOL* pfInsertable
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, Guid*, FORMATETC*, BOOL*, int>)((*lpVtbl)[27])
        )(this, pguidService, pFormatEtc, pfInsertable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT InsertTextAtSelection(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const WCHAR *")] ushort* pchText,
        [NativeTypeName("ULONG")] uint cch,
        IAnchor* ppaStart,
        IAnchor* ppaEnd
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, ushort*, uint, IAnchor*, IAnchor*, int>)(
                (*lpVtbl)[28]
            )
        )(this, dwFlags, pchText, cch, ppaStart, ppaEnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT InsertEmbeddedAtSelection(
        [NativeTypeName("DWORD")] uint dwFlags,
        IDataObject pDataObject,
        IAnchor* ppaStart,
        IAnchor* ppaEnd
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchor, uint, IDataObject, IAnchor*, IAnchor*, int>)(
                (*lpVtbl)[29]
            )
        )(this, dwFlags, pDataObject, ppaStart, ppaEnd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseSink(
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown punk,
            [NativeTypeName("DWORD")] uint dwMask
        );

        [VtblIndex(4)]
        HRESULT UnadviseSink(IUnknown punk);

        [VtblIndex(5)]
        HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession);

        [VtblIndex(6)]
        HRESULT GetStatus(TS_STATUS* pdcs);

        [VtblIndex(7)]
        HRESULT QueryInsert(
            IAnchor paTestStart,
            IAnchor paTestEnd,
            [NativeTypeName("ULONG")] uint cch,
            IAnchor* ppaResultStart,
            IAnchor* ppaResultEnd
        );

        [VtblIndex(8)]
        HRESULT GetSelection(
            [NativeTypeName("ULONG")] uint ulIndex,
            [NativeTypeName("ULONG")] uint ulCount,
            TS_SELECTION_ANCHOR* pSelection,
            [NativeTypeName("ULONG *")] uint* pcFetched
        );

        [VtblIndex(9)]
        HRESULT SetSelection(
            [NativeTypeName("ULONG")] uint ulCount,
            [NativeTypeName("const TS_SELECTION_ANCHOR *")] TS_SELECTION_ANCHOR* pSelection
        );

        [VtblIndex(10)]
        HRESULT GetText(
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor paStart,
            IAnchor paEnd,
            [NativeTypeName("WCHAR *")] ushort* pchText,
            [NativeTypeName("ULONG")] uint cchReq,
            [NativeTypeName("ULONG *")] uint* pcch,
            BOOL fUpdateAnchor
        );

        [VtblIndex(11)]
        HRESULT SetText(
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor paStart,
            IAnchor paEnd,
            [NativeTypeName("const WCHAR *")] ushort* pchText,
            [NativeTypeName("ULONG")] uint cch
        );

        [VtblIndex(12)]
        HRESULT GetFormattedText(IAnchor paStart, IAnchor paEnd, IDataObject* ppDataObject);

        [VtblIndex(13)]
        HRESULT GetEmbedded(
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor paPos,
            [NativeTypeName("const GUID &")] Guid* rguidService,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppunk
        );

        [VtblIndex(14)]
        HRESULT InsertEmbedded(
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor paStart,
            IAnchor paEnd,
            IDataObject pDataObject
        );

        [VtblIndex(15)]
        HRESULT RequestSupportedAttrs(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("ULONG")] uint cFilterAttrs,
            [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs
        );

        [VtblIndex(16)]
        HRESULT RequestAttrsAtPosition(
            IAnchor paPos,
            [NativeTypeName("ULONG")] uint cFilterAttrs,
            [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(17)]
        HRESULT RequestAttrsTransitioningAtPosition(
            IAnchor paPos,
            [NativeTypeName("ULONG")] uint cFilterAttrs,
            [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(18)]
        HRESULT FindNextAttrTransition(
            IAnchor paStart,
            IAnchor paHalt,
            [NativeTypeName("ULONG")] uint cFilterAttrs,
            [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs,
            [NativeTypeName("DWORD")] uint dwFlags,
            BOOL* pfFound,
            [NativeTypeName("LONG *")] int* plFoundOffset
        );

        [VtblIndex(19)]
        HRESULT RetrieveRequestedAttrs(
            [NativeTypeName("ULONG")] uint ulCount,
            TS_ATTRVAL* paAttrVals,
            [NativeTypeName("ULONG *")] uint* pcFetched
        );

        [VtblIndex(20)]
        HRESULT GetStart(IAnchor* ppaStart);

        [VtblIndex(21)]
        HRESULT GetEnd(IAnchor* ppaEnd);

        [VtblIndex(22)]
        HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView);

        [VtblIndex(23)]
        HRESULT GetAnchorFromPoint(
            [NativeTypeName("TsViewCookie")] uint vcView,
            [NativeTypeName("const POINT *")] POINT* ptScreen,
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor* ppaSite
        );

        [VtblIndex(24)]
        HRESULT GetTextExt(
            [NativeTypeName("TsViewCookie")] uint vcView,
            IAnchor paStart,
            IAnchor paEnd,
            RECT* prc,
            BOOL* pfClipped
        );

        [VtblIndex(25)]
        HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc);

        [VtblIndex(26)]
        HRESULT GetWnd([NativeTypeName("TsViewCookie")] uint vcView, HWND* phwnd);

        [VtblIndex(27)]
        HRESULT QueryInsertEmbedded(
            [NativeTypeName("const GUID *")] Guid* pguidService,
            [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc,
            BOOL* pfInsertable
        );

        [VtblIndex(28)]
        HRESULT InsertTextAtSelection(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("const WCHAR *")] ushort* pchText,
            [NativeTypeName("ULONG")] uint cch,
            IAnchor* ppaStart,
            IAnchor* ppaEnd
        );

        [VtblIndex(29)]
        HRESULT InsertEmbeddedAtSelection(
            [NativeTypeName("DWORD")] uint dwFlags,
            IDataObject pDataObject,
            IAnchor* ppaStart,
            IAnchor* ppaEnd
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

        [NativeTypeName("HRESULT (const IID &, IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, uint, int> AdviseSink;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> UnadviseSink;

        [NativeTypeName("HRESULT (DWORD, HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HRESULT*, int> RequestLock;

        [NativeTypeName("HRESULT (TS_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TS_STATUS*, int> GetStatus;

        [NativeTypeName(
            "HRESULT (IAnchor *, IAnchor *, ULONG, IAnchor **, IAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAnchor,
            IAnchor,
            uint,
            IAnchor*,
            IAnchor*,
            int> QueryInsert;

        [NativeTypeName(
            "HRESULT (ULONG, ULONG, TS_SELECTION_ANCHOR *, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            TS_SELECTION_ANCHOR*,
            uint*,
            int> GetSelection;

        [NativeTypeName("HRESULT (ULONG, const TS_SELECTION_ANCHOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TS_SELECTION_ANCHOR*, int> SetSelection;

        [NativeTypeName(
            "HRESULT (DWORD, IAnchor *, IAnchor *, WCHAR *, ULONG, ULONG *, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IAnchor,
            IAnchor,
            ushort*,
            uint,
            uint*,
            BOOL,
            int> GetText;

        [NativeTypeName(
            "HRESULT (DWORD, IAnchor *, IAnchor *, const WCHAR *, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAnchor, IAnchor, ushort*, uint, int> SetText;

        [NativeTypeName("HRESULT (IAnchor *, IAnchor *, IDataObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAnchor, IAnchor, IDataObject*, int> GetFormattedText;

        [NativeTypeName(
            "HRESULT (DWORD, IAnchor *, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAnchor, Guid*, Guid*, IUnknown*, int> GetEmbedded;

        [NativeTypeName(
            "HRESULT (DWORD, IAnchor *, IAnchor *, IDataObject *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAnchor, IAnchor, IDataObject, int> InsertEmbedded;

        [NativeTypeName("HRESULT (DWORD, ULONG, const TS_ATTRID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, int> RequestSupportedAttrs;

        [NativeTypeName(
            "HRESULT (IAnchor *, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAnchor, uint, Guid*, uint, int> RequestAttrsAtPosition;

        [NativeTypeName(
            "HRESULT (IAnchor *, ULONG, const TS_ATTRID *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAnchor,
            uint,
            Guid*,
            uint,
            int> RequestAttrsTransitioningAtPosition;

        [NativeTypeName(
            "HRESULT (IAnchor *, IAnchor *, ULONG, const TS_ATTRID *, DWORD, BOOL *, LONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAnchor,
            IAnchor,
            uint,
            Guid*,
            uint,
            BOOL*,
            int*,
            int> FindNextAttrTransition;

        [NativeTypeName("HRESULT (ULONG, TS_ATTRVAL *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TS_ATTRVAL*, uint*, int> RetrieveRequestedAttrs;

        [NativeTypeName("HRESULT (IAnchor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAnchor*, int> GetStart;

        [NativeTypeName("HRESULT (IAnchor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAnchor*, int> GetEnd;

        [NativeTypeName("HRESULT (TsViewCookie *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetActiveView;

        [NativeTypeName(
            "HRESULT (TsViewCookie, const POINT *, DWORD, IAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, POINT*, uint, IAnchor*, int> GetAnchorFromPoint;

        [NativeTypeName(
            "HRESULT (TsViewCookie, IAnchor *, IAnchor *, RECT *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAnchor, IAnchor, RECT*, BOOL*, int> GetTextExt;

        [NativeTypeName("HRESULT (TsViewCookie, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, int> GetScreenExt;

        [NativeTypeName("HRESULT (TsViewCookie, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HWND*, int> GetWnd;

        [NativeTypeName(
            "HRESULT (const GUID *, const FORMATETC *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, FORMATETC*, BOOL*, int> QueryInsertEmbedded;

        [NativeTypeName(
            "HRESULT (DWORD, const WCHAR *, ULONG, IAnchor **, IAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint,
            IAnchor*,
            IAnchor*,
            int> InsertTextAtSelection;

        [NativeTypeName(
            "HRESULT (DWORD, IDataObject *, IAnchor **, IAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDataObject,
            IAnchor*,
            IAnchor*,
            int> InsertEmbeddedAtSelection;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextStoreAnchor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextStoreAnchor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextStoreAnchor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextStoreAnchor(Silk.NET.Windows.IUnknown value)
    {
        return new ITextStoreAnchor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextStoreAnchor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextStoreAnchor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextStoreAnchor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
