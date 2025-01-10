// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F4A0-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMarkupServices : IMarkupServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMarkupServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMarkupPointer(IMarkupPointer* ppPointer)
    {
        return ((delegate* unmanaged<IMarkupServices, IMarkupPointer*, int>)((*lpVtbl)[3]))(
            this,
            ppPointer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateMarkupContainer(IMarkupContainer* ppMarkupContainer)
    {
        return ((delegate* unmanaged<IMarkupServices, IMarkupContainer*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IMarkupServices, ELEMENT_TAG_ID, ushort*, IHTMLElement*, int>)(
                (*lpVtbl)[5]
            )
        )(this, tagID, pchAttributes, ppElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloneElement(IHTMLElement pElemCloneThis, IHTMLElement* ppElementTheClone)
    {
        return (
            (delegate* unmanaged<IMarkupServices, IHTMLElement, IHTMLElement*, int>)((*lpVtbl)[6])
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
                IMarkupServices,
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
        return ((delegate* unmanaged<IMarkupServices, IHTMLElement, int>)((*lpVtbl)[8]))(
            this,
            pElementRemove
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Remove(IMarkupPointer pPointerStart, IMarkupPointer pPointerFinish)
    {
        return (
            (delegate* unmanaged<IMarkupServices, IMarkupPointer, IMarkupPointer, int>)(
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
                IMarkupServices,
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
                IMarkupServices,
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
            (delegate* unmanaged<IMarkupServices, ushort*, int, IMarkupPointer, int>)((*lpVtbl)[12])
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
                IMarkupServices,
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
                IMarkupServices,
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
        return ((delegate* unmanaged<IMarkupServices, IHTMLElement, BOOL*, int>)((*lpVtbl)[15]))(
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
            (delegate* unmanaged<IMarkupServices, IHTMLElement, ELEMENT_TAG_ID*, int>)(
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
            (delegate* unmanaged<IMarkupServices, ushort*, ELEMENT_TAG_ID*, int>)((*lpVtbl)[17])
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
            (delegate* unmanaged<IMarkupServices, ELEMENT_TAG_ID, ushort**, int>)((*lpVtbl)[18])
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
                IMarkupServices,
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
                IMarkupServices,
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
        return ((delegate* unmanaged<IMarkupServices, ushort*, int>)((*lpVtbl)[21]))(
            this,
            pchTitle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EndUndoUnit()
    {
        return ((delegate* unmanaged<IMarkupServices, int>)((*lpVtbl)[22]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMarkupPointer(IMarkupPointer* ppPointer);

        [VtblIndex(4)]
        HRESULT CreateMarkupContainer(IMarkupContainer* ppMarkupContainer);

        [VtblIndex(5)]
        HRESULT CreateElement(
            ELEMENT_TAG_ID tagID,
            [NativeTypeName("OLECHAR *")] ushort* pchAttributes,
            IHTMLElement* ppElement
        );

        [VtblIndex(6)]
        HRESULT CloneElement(IHTMLElement pElemCloneThis, IHTMLElement* ppElementTheClone);

        [VtblIndex(7)]
        HRESULT InsertElement(
            IHTMLElement pElementInsert,
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish
        );

        [VtblIndex(8)]
        HRESULT RemoveElement(IHTMLElement pElementRemove);

        [VtblIndex(9)]
        HRESULT Remove(IMarkupPointer pPointerStart, IMarkupPointer pPointerFinish);

        [VtblIndex(10)]
        HRESULT Copy(
            IMarkupPointer pPointerSourceStart,
            IMarkupPointer pPointerSourceFinish,
            IMarkupPointer pPointerTarget
        );

        [VtblIndex(11)]
        HRESULT Move(
            IMarkupPointer pPointerSourceStart,
            IMarkupPointer pPointerSourceFinish,
            IMarkupPointer pPointerTarget
        );

        [VtblIndex(12)]
        HRESULT InsertText(
            [NativeTypeName("OLECHAR *")] ushort* pchText,
            [NativeTypeName("long")] int cch,
            IMarkupPointer pPointerTarget
        );

        [VtblIndex(13)]
        HRESULT ParseString(
            [NativeTypeName("OLECHAR *")] ushort* pchHTML,
            [NativeTypeName("DWORD")] uint dwFlags,
            IMarkupContainer* ppContainerResult,
            IMarkupPointer ppPointerStart,
            IMarkupPointer ppPointerFinish
        );

        [VtblIndex(14)]
        HRESULT ParseGlobal(
            HGLOBAL hglobalHTML,
            [NativeTypeName("DWORD")] uint dwFlags,
            IMarkupContainer* ppContainerResult,
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish
        );

        [VtblIndex(15)]
        HRESULT IsScopedElement(IHTMLElement pElement, BOOL* pfScoped);

        [VtblIndex(16)]
        HRESULT GetElementTagId(IHTMLElement pElement, ELEMENT_TAG_ID* ptagId);

        [VtblIndex(17)]
        HRESULT GetTagIDForName([NativeTypeName("BSTR")] ushort* bstrName, ELEMENT_TAG_ID* ptagId);

        [VtblIndex(18)]
        HRESULT GetNameForTagID(
            ELEMENT_TAG_ID tagId,
            [NativeTypeName("BSTR *")] ushort** pbstrName
        );

        [VtblIndex(19)]
        HRESULT MovePointersToRange(
            IHTMLTxtRange pIRange,
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish
        );

        [VtblIndex(20)]
        HRESULT MoveRangeToPointers(
            IMarkupPointer pPointerStart,
            IMarkupPointer pPointerFinish,
            IHTMLTxtRange pIRange
        );

        [VtblIndex(21)]
        HRESULT BeginUndoUnit([NativeTypeName("OLECHAR *")] ushort* pchTitle);

        [VtblIndex(22)]
        HRESULT EndUndoUnit();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMarkupServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMarkupServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMarkupServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMarkupServices(Silk.NET.Windows.IUnknown value)
    {
        return new IMarkupServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMarkupServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMarkupServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMarkupServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
