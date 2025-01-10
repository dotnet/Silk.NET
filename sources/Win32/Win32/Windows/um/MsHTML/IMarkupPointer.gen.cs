// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F49F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupPointer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMarkupPointer : IMarkupPointer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupPointer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupPointer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMarkupPointer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupPointer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OwningDoc(IHTMLDocument2* ppDoc)
    {
        return ((delegate* unmanaged<IMarkupPointer, IHTMLDocument2*, int>)((*lpVtbl)[3]))(
            this,
            ppDoc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Gravity(POINTER_GRAVITY* pGravity)
    {
        return ((delegate* unmanaged<IMarkupPointer, POINTER_GRAVITY*, int>)((*lpVtbl)[4]))(
            this,
            pGravity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetGravity(POINTER_GRAVITY Gravity)
    {
        return ((delegate* unmanaged<IMarkupPointer, POINTER_GRAVITY, int>)((*lpVtbl)[5]))(
            this,
            Gravity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Cling(BOOL* pfCling)
    {
        return ((delegate* unmanaged<IMarkupPointer, BOOL*, int>)((*lpVtbl)[6]))(this, pfCling);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCling(BOOL fCLing)
    {
        return ((delegate* unmanaged<IMarkupPointer, BOOL, int>)((*lpVtbl)[7]))(this, fCLing);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unposition()
    {
        return ((delegate* unmanaged<IMarkupPointer, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsPositioned(BOOL* pfPositioned)
    {
        return ((delegate* unmanaged<IMarkupPointer, BOOL*, int>)((*lpVtbl)[9]))(
            this,
            pfPositioned
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetContainer(IMarkupContainer* ppContainer)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupContainer*, int>)((*lpVtbl)[10]))(
            this,
            ppContainer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT MoveAdjacentToElement(IHTMLElement pElement, ELEMENT_ADJACENCY eAdj)
    {
        return (
            (delegate* unmanaged<IMarkupPointer, IHTMLElement, ELEMENT_ADJACENCY, int>)(
                (*lpVtbl)[11]
            )
        )(this, pElement, eAdj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MoveToPointer(IMarkupPointer pPointer)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, int>)((*lpVtbl)[12]))(
            this,
            pPointer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT MoveToContainer(IMarkupContainer pContainer, BOOL fAtStart)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupContainer, BOOL, int>)((*lpVtbl)[13]))(
            this,
            pContainer,
            fAtStart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Left(
        BOOL fMove,
        MARKUP_CONTEXT_TYPE* pContext,
        IHTMLElement* ppElement,
        [NativeTypeName("long *")] int* pcch,
        [NativeTypeName("OLECHAR *")] ushort* pchText
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupPointer,
                BOOL,
                MARKUP_CONTEXT_TYPE*,
                IHTMLElement*,
                int*,
                ushort*,
                int>)((*lpVtbl)[14])
        )(this, fMove, pContext, ppElement, pcch, pchText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Right(
        BOOL fMove,
        MARKUP_CONTEXT_TYPE* pContext,
        IHTMLElement* ppElement,
        [NativeTypeName("long *")] int* pcch,
        [NativeTypeName("OLECHAR *")] ushort* pchText
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupPointer,
                BOOL,
                MARKUP_CONTEXT_TYPE*,
                IHTMLElement*,
                int*,
                ushort*,
                int>)((*lpVtbl)[15])
        )(this, fMove, pContext, ppElement, pcch, pchText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CurrentScope(IHTMLElement* ppElemCurrent)
    {
        return ((delegate* unmanaged<IMarkupPointer, IHTMLElement*, int>)((*lpVtbl)[16]))(
            this,
            ppElemCurrent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsLeftOf(IMarkupPointer pPointerThat, BOOL* pfResult)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, BOOL*, int>)((*lpVtbl)[17]))(
            this,
            pPointerThat,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT IsLeftOfOrEqualTo(IMarkupPointer pPointerThat, BOOL* pfResult)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, BOOL*, int>)((*lpVtbl)[18]))(
            this,
            pPointerThat,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT IsRightOf(IMarkupPointer pPointerThat, BOOL* pfResult)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, BOOL*, int>)((*lpVtbl)[19]))(
            this,
            pPointerThat,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsRightOfOrEqualTo(IMarkupPointer pPointerThat, BOOL* pfResult)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, BOOL*, int>)((*lpVtbl)[20]))(
            this,
            pPointerThat,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT IsEqualTo(IMarkupPointer pPointerThat, BOOL* pfAreEqual)
    {
        return ((delegate* unmanaged<IMarkupPointer, IMarkupPointer, BOOL*, int>)((*lpVtbl)[21]))(
            this,
            pPointerThat,
            pfAreEqual
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT MoveUnit(MOVEUNIT_ACTION muAction)
    {
        return ((delegate* unmanaged<IMarkupPointer, MOVEUNIT_ACTION, int>)((*lpVtbl)[22]))(
            this,
            muAction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT FindTextW(
        [NativeTypeName("OLECHAR *")] ushort* pchFindText,
        [NativeTypeName("DWORD")] uint dwFlags,
        IMarkupPointer pIEndMatch,
        IMarkupPointer pIEndSearch
    )
    {
        return (
            (delegate* unmanaged<
                IMarkupPointer,
                ushort*,
                uint,
                IMarkupPointer,
                IMarkupPointer,
                int>)((*lpVtbl)[23])
        )(this, pchFindText, dwFlags, pIEndMatch, pIEndSearch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OwningDoc(IHTMLDocument2* ppDoc);

        [VtblIndex(4)]
        HRESULT Gravity(POINTER_GRAVITY* pGravity);

        [VtblIndex(5)]
        HRESULT SetGravity(POINTER_GRAVITY Gravity);

        [VtblIndex(6)]
        HRESULT Cling(BOOL* pfCling);

        [VtblIndex(7)]
        HRESULT SetCling(BOOL fCLing);

        [VtblIndex(8)]
        HRESULT Unposition();

        [VtblIndex(9)]
        HRESULT IsPositioned(BOOL* pfPositioned);

        [VtblIndex(10)]
        HRESULT GetContainer(IMarkupContainer* ppContainer);

        [VtblIndex(11)]
        HRESULT MoveAdjacentToElement(IHTMLElement pElement, ELEMENT_ADJACENCY eAdj);

        [VtblIndex(12)]
        HRESULT MoveToPointer(IMarkupPointer pPointer);

        [VtblIndex(13)]
        HRESULT MoveToContainer(IMarkupContainer pContainer, BOOL fAtStart);

        [VtblIndex(14)]
        HRESULT Left(
            BOOL fMove,
            MARKUP_CONTEXT_TYPE* pContext,
            IHTMLElement* ppElement,
            [NativeTypeName("long *")] int* pcch,
            [NativeTypeName("OLECHAR *")] ushort* pchText
        );

        [VtblIndex(15)]
        HRESULT Right(
            BOOL fMove,
            MARKUP_CONTEXT_TYPE* pContext,
            IHTMLElement* ppElement,
            [NativeTypeName("long *")] int* pcch,
            [NativeTypeName("OLECHAR *")] ushort* pchText
        );

        [VtblIndex(16)]
        HRESULT CurrentScope(IHTMLElement* ppElemCurrent);

        [VtblIndex(17)]
        HRESULT IsLeftOf(IMarkupPointer pPointerThat, BOOL* pfResult);

        [VtblIndex(18)]
        HRESULT IsLeftOfOrEqualTo(IMarkupPointer pPointerThat, BOOL* pfResult);

        [VtblIndex(19)]
        HRESULT IsRightOf(IMarkupPointer pPointerThat, BOOL* pfResult);

        [VtblIndex(20)]
        HRESULT IsRightOfOrEqualTo(IMarkupPointer pPointerThat, BOOL* pfResult);

        [VtblIndex(21)]
        HRESULT IsEqualTo(IMarkupPointer pPointerThat, BOOL* pfAreEqual);

        [VtblIndex(22)]
        HRESULT MoveUnit(MOVEUNIT_ACTION muAction);

        [VtblIndex(23)]
        HRESULT FindTextW(
            [NativeTypeName("OLECHAR *")] ushort* pchFindText,
            [NativeTypeName("DWORD")] uint dwFlags,
            IMarkupPointer pIEndMatch,
            IMarkupPointer pIEndSearch
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

        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2*, int> OwningDoc;

        [NativeTypeName("HRESULT (POINTER_GRAVITY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINTER_GRAVITY*, int> Gravity;

        [NativeTypeName("HRESULT (POINTER_GRAVITY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINTER_GRAVITY, int> SetGravity;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> Cling;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetCling;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unposition;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsPositioned;

        [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer*, int> GetContainer;

        [NativeTypeName("HRESULT (IHTMLElement *, ELEMENT_ADJACENCY) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IHTMLElement,
            ELEMENT_ADJACENCY,
            int> MoveAdjacentToElement;

        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, int> MoveToPointer;

        [NativeTypeName("HRESULT (IMarkupContainer *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer, BOOL, int> MoveToContainer;

        [NativeTypeName(
            "HRESULT (BOOL, MARKUP_CONTEXT_TYPE *, IHTMLElement **, long *, OLECHAR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BOOL,
            MARKUP_CONTEXT_TYPE*,
            IHTMLElement*,
            int*,
            ushort*,
            int> Left;

        [NativeTypeName(
            "HRESULT (BOOL, MARKUP_CONTEXT_TYPE *, IHTMLElement **, long *, OLECHAR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BOOL,
            MARKUP_CONTEXT_TYPE*,
            IHTMLElement*,
            int*,
            ushort*,
            int> Right;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> CurrentScope;

        [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, BOOL*, int> IsLeftOf;

        [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, BOOL*, int> IsLeftOfOrEqualTo;

        [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, BOOL*, int> IsRightOf;

        [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, BOOL*, int> IsRightOfOrEqualTo;

        [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, BOOL*, int> IsEqualTo;

        [NativeTypeName("HRESULT (MOVEUNIT_ACTION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MOVEUNIT_ACTION, int> MoveUnit;

        [NativeTypeName(
            "HRESULT (OLECHAR *, DWORD, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IMarkupPointer,
            IMarkupPointer,
            int> FindTextW;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMarkupPointer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMarkupPointer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMarkupPointer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMarkupPointer(Silk.NET.Windows.IUnknown value)
    {
        return new IMarkupPointer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMarkupPointer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMarkupPointer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMarkupPointer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
