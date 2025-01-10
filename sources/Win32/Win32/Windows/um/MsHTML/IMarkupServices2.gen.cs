// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F682-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupServices2 : IMarkupServices")]
[NativeInheritance("IMarkupServices")]
public unsafe partial struct IMarkupServices2 : IMarkupServices2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupServices2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupServices2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMarkupServices2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupServices2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMarkupPointer(IMarkupPointer* ppPointer)
    {
        return ((delegate* unmanaged<IMarkupServices2, IMarkupPointer*, int>)((*lpVtbl)[3]))(
            this,
            ppPointer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateMarkupContainer(IMarkupContainer* ppMarkupContainer)
    {
        return ((delegate* unmanaged<IMarkupServices2, IMarkupContainer*, int>)((*lpVtbl)[4]))(
            this,
            ppMarkupContainer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateElement(
        ELEMENT_TAG_ID tagID,
        [NativeTypeName("OLECHAR *")] ushort* pchAttributes,
        IHTMLElement* ppElement
    )
    {
        return (
            (delegate* unmanaged<IMarkupServices2, ELEMENT_TAG_ID, ushort*, IHTMLElement*, int>)(
                (*lpVtbl)[5]
            )
        )(this, tagID, pchAttributes, ppElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloneElement(IHTMLElement pElemCloneThis, IHTMLElement* ppElementTheClone)
    {
        return (
            (delegate* unmanaged<IMarkupServices2, IHTMLElement, IHTMLElement*, int>)((*lpVtbl)[6])
        )(this, pElemCloneThis, ppElementTheClone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertElement(
        IHTMLElement pElementInsert,
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IHTMLElement,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[7])
        )(this, pElementInsert, pPointerStart, pPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveElement(IHTMLElement pElementRemove)
    {
        return ((delegate* unmanaged<IMarkupServices2, IHTMLElement, int>)((*lpVtbl)[8]))(
            this,
            pElementRemove
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Remove(IMarkupPointer pPointerStart, IMarkupPointer pPointerFinish)
    {
        return (
            (delegate* unmanaged<IMarkupServices2, IMarkupPointer, IMarkupPointer, int>)(
                (*lpVtbl)[9]
            )
        )(this, pPointerStart, pPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Copy(
        IMarkupPointer pPointerSourceStart,
        IMarkupPointer pPointerSourceFinish,
        IMarkupPointer pPointerTarget
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IMarkupPointer,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[10])
        )(this, pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Move(
        IMarkupPointer pPointerSourceStart,
        IMarkupPointer pPointerSourceFinish,
        IMarkupPointer pPointerTarget
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IMarkupPointer,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[11])
        )(this, pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT InsertText(
        [NativeTypeName("OLECHAR *")] ushort* pchText,
        [NativeTypeName("long")] int cch,
        IMarkupPointer pPointerTarget
    )
    {
        return (
            (delegate* unmanaged<IMarkupServices2, ushort*, int, IMarkupPointer, int>)(
                (*lpVtbl)[12]
            )
        )(this, pchText, cch, pPointerTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ParseString(
        [NativeTypeName("OLECHAR *")] ushort* pchHTML,
        [NativeTypeName("DWORD")] uint dwFlags,
        IMarkupContainer* ppContainerResult,
        IMarkupPointer ppPointerStart,
        IMarkupPointer ppPointerFinish
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                ushort*,
                uint,
                IMarkupContainer*,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[13])
        )(this, pchHTML, dwFlags, ppContainerResult, ppPointerStart, ppPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ParseGlobal(
        HGLOBAL hglobalHTML,
        [NativeTypeName("DWORD")] uint dwFlags,
        IMarkupContainer* ppContainerResult,
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                HGLOBAL,
                uint,
                IMarkupContainer*,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[14])
        )(this, hglobalHTML, dwFlags, ppContainerResult, pPointerStart, pPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsScopedElement(IHTMLElement pElement, BOOL* pfScoped)
    {
        return ((delegate* unmanaged<IMarkupServices2, IHTMLElement, BOOL*, int>)((*lpVtbl)[15]))(
            this,
            pElement,
            pfScoped
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetElementTagId(IHTMLElement pElement, ELEMENT_TAG_ID* ptagId)
    {
        return (
            (delegate* unmanaged<IMarkupServices2, IHTMLElement, ELEMENT_TAG_ID*, int>)(
                (*lpVtbl)[16]
            )
        )(this, pElement, ptagId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTagIDForName(
        [NativeTypeName("BSTR")] ushort* bstrName,
        ELEMENT_TAG_ID* ptagId
    )
    {
        return (
            (delegate* unmanaged<IMarkupServices2, ushort*, ELEMENT_TAG_ID*, int>)((*lpVtbl)[17])
        )(this, bstrName, ptagId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNameForTagID(
        ELEMENT_TAG_ID tagId,
        [NativeTypeName("BSTR *")] ushort** pbstrName
    )
    {
        return (
            (delegate* unmanaged<IMarkupServices2, ELEMENT_TAG_ID, ushort**, int>)((*lpVtbl)[18])
        )(this, tagId, pbstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MovePointersToRange(
        IHTMLTxtRange pIRange,
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IHTMLTxtRange,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[19])
        )(this, pIRange, pPointerStart, pPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT MoveRangeToPointers(
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish,
        IHTMLTxtRange pIRange
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IMarkupPointer,
                IMarkupPointer,
                IHTMLTxtRange,
                int>)((*lpVtbl)[20])
        )(this, pPointerStart, pPointerFinish, pIRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT BeginUndoUnit([NativeTypeName("OLECHAR *")] ushort* pchTitle)
    {
        return ((delegate* unmanaged<IMarkupServices2, ushort*, int>)((*lpVtbl)[21]))(
            this,
            pchTitle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EndUndoUnit()
    {
        return ((delegate* unmanaged<IMarkupServices2, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ParseGlobalEx(
        HGLOBAL hglobalHTML,
        [NativeTypeName("DWORD")] uint dwFlags,
        IMarkupContainer pContext,
        IMarkupContainer* ppContainerResult,
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                HGLOBAL,
                uint,
                IMarkupContainer,
                IMarkupContainer*,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[23])
        )(this, hglobalHTML, dwFlags, pContext, ppContainerResult, pPointerStart, pPointerFinish);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ValidateElements(
        IMarkupPointer pPointerStart,
        IMarkupPointer pPointerFinish,
        IMarkupPointer pPointerTarget,
        IMarkupPointer pPointerStatus,
        IHTMLElement* ppElemFailBottom,
        IHTMLElement* ppElemFailTop
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupServices2,
                IMarkupPointer,
                IMarkupPointer,
                IMarkupPointer,
                IMarkupPointer,
                IHTMLElement*,
                IHTMLElement*,
                int>)((*lpVtbl)[24])
        )(
            this,
            pPointerStart,
            pPointerFinish,
            pPointerTarget,
            pPointerStatus,
            ppElemFailBottom,
            ppElemFailTop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SaveSegmentsToClipboard(
        ISegmentList pSegmentList,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IMarkupServices2, ISegmentList, uint, int>)((*lpVtbl)[25]))(
            this,
            pSegmentList,
            dwFlags
        );
    }

    public interface Interface : IMarkupServices.Interface
    {
        [VtblIndex(23)]
        HRESULT ParseGlobalEx(
            HGLOBAL hglobalHTML,
            [NativeTypeName("DWORD")] uint dwFlags,
            IMarkupContainer pContext,
            IMarkupContainer* ppContainerResult,
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish
        );

        [VtblIndex(24)]
        HRESULT ValidateElements(
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish,
            IMarkupPointer pPointerTarget,
            IMarkupPointer pPointerStatus,
            IHTMLElement* ppElemFailBottom,
            IHTMLElement* ppElemFailTop
        );

        [VtblIndex(25)]
        HRESULT SaveSegmentsToClipboard(
            ISegmentList pSegmentList,
            [NativeTypeName("DWORD")] uint dwFlags
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

        [NativeTypeName("HRESULT (IMarkupPointer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, int> CreateMarkupPointer;

        [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer*, int> CreateMarkupContainer;

        [NativeTypeName(
            "HRESULT (ELEMENT_TAG_ID, OLECHAR *, IHTMLElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ELEMENT_TAG_ID,
            ushort*,
            IHTMLElement*,
            int> CreateElement;

        [NativeTypeName("HRESULT (IHTMLElement *, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, IHTMLElement*, int> CloneElement;

        [NativeTypeName(
            "HRESULT (IHTMLElement *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHTMLElement,
            IMarkupPointer,
            IMarkupPointer,
            int> InsertElement;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, int> RemoveElement;

        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, IMarkupPointer, int> Remove;

        [NativeTypeName(
            "HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupPointer,
            IMarkupPointer,
            IMarkupPointer,
            int> Copy;

        [NativeTypeName(
            "HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupPointer,
            IMarkupPointer,
            IMarkupPointer,
            int> Move;

        [NativeTypeName("HRESULT (OLECHAR *, long, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, IMarkupPointer, int> InsertText;

        [NativeTypeName(
            "HRESULT (OLECHAR *, DWORD, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IMarkupContainer*,
            IMarkupPointer,
            IMarkupPointer,
            int> ParseString;

        [NativeTypeName(
            "HRESULT (HGLOBAL, DWORD, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HGLOBAL,
            uint,
            IMarkupContainer*,
            IMarkupPointer,
            IMarkupPointer,
            int> ParseGlobal;

        [NativeTypeName("HRESULT (IHTMLElement *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, BOOL*, int> IsScopedElement;

        [NativeTypeName("HRESULT (IHTMLElement *, ELEMENT_TAG_ID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, ELEMENT_TAG_ID*, int> GetElementTagId;

        [NativeTypeName("HRESULT (BSTR, ELEMENT_TAG_ID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ELEMENT_TAG_ID*, int> GetTagIDForName;

        [NativeTypeName("HRESULT (ELEMENT_TAG_ID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ELEMENT_TAG_ID, ushort**, int> GetNameForTagID;

        [NativeTypeName(
            "HRESULT (IHTMLTxtRange *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHTMLTxtRange,
            IMarkupPointer,
            IMarkupPointer,
            int> MovePointersToRange;

        [NativeTypeName(
            "HRESULT (IMarkupPointer *, IMarkupPointer *, IHTMLTxtRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupPointer,
            IMarkupPointer,
            IHTMLTxtRange,
            int> MoveRangeToPointers;

        [NativeTypeName("HRESULT (OLECHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> BeginUndoUnit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndUndoUnit;

        [NativeTypeName(
            "HRESULT (HGLOBAL, DWORD, IMarkupContainer *, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HGLOBAL,
            uint,
            IMarkupContainer,
            IMarkupContainer*,
            IMarkupPointer,
            IMarkupPointer,
            int> ParseGlobalEx;

        [NativeTypeName(
            "HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IHTMLElement **, IHTMLElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupPointer,
            IMarkupPointer,
            IMarkupPointer,
            IMarkupPointer,
            IHTMLElement*,
            IHTMLElement*,
            int> ValidateElements;

        [NativeTypeName("HRESULT (ISegmentList *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegmentList, uint, int> SaveSegmentsToClipboard;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMarkupServices2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMarkupServices2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMarkupServices"/> to <see cref = "IMarkupServices2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMarkupServices"/> instance to be converted </param>
    public static explicit operator IMarkupServices2(Silk.NET.Windows.IMarkupServices value)
    {
        return new IMarkupServices2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMarkupServices2"/> to <see cref = "Silk.NET.Windows.IMarkupServices"/>.</summary>
    /// <param name = "value">The <see cref = "IMarkupServices2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMarkupServices(IMarkupServices2 value)
    {
        return new Silk.NET.Windows.IMarkupServices(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMarkupServices2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMarkupServices2(Silk.NET.Windows.IUnknown value)
    {
        return new IMarkupServices2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMarkupServices2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMarkupServices2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMarkupServices2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
