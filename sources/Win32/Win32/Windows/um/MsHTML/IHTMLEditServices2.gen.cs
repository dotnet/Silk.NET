// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F812-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEditServices2 : IHTMLEditServices")]
[NativeInheritance("IHTMLEditServices")]
public unsafe partial struct IHTMLEditServices2 : IHTMLEditServices2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEditServices2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLEditServices2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditServices2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddDesigner(IHTMLEditDesigner pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IHTMLEditDesigner, int>)((*lpVtbl)[3]))(
            this,
            pIDesigner
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveDesigner(IHTMLEditDesigner pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IHTMLEditDesigner, int>)((*lpVtbl)[4]))(
            this,
            pIDesigner
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSelectionServices(IMarkupContainer pIContainer, ISelectionServices* ppSelSvc)
    {
        return (
            (delegate* unmanaged<IHTMLEditServices2, IMarkupContainer, ISelectionServices*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pIContainer, ppSelSvc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MoveToSelectionAnchor(IMarkupPointer pIStartAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IMarkupPointer, int>)((*lpVtbl)[6]))(
            this,
            pIStartAnchor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToSelectionEnd(IMarkupPointer pIEndAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IMarkupPointer, int>)((*lpVtbl)[7]))(
            this,
            pIEndAnchor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectRange(IMarkupPointer pStart, IMarkupPointer pEnd, SELECTION_TYPE eType)
    {
        return (
            (delegate* unmanaged<
                IHTMLEditServices2,
                IMarkupPointer,
                IMarkupPointer,
                SELECTION_TYPE,
                int>)((*lpVtbl)[8])
        )(this, pStart, pEnd, eType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MoveToSelectionAnchorEx(IDisplayPointer pIStartAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IDisplayPointer, int>)((*lpVtbl)[9]))(
            this,
            pIStartAnchor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT MoveToSelectionEndEx(IDisplayPointer pIEndAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, IDisplayPointer, int>)((*lpVtbl)[10]))(
            this,
            pIEndAnchor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FreezeVirtualCaretPos(BOOL fReCompute)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, BOOL, int>)((*lpVtbl)[11]))(
            this,
            fReCompute
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnFreezeVirtualCaretPos(BOOL fReset)
    {
        return ((delegate* unmanaged<IHTMLEditServices2, BOOL, int>)((*lpVtbl)[12]))(this, fReset);
    }

    public interface Interface : IHTMLEditServices.Interface
    {
        [VtblIndex(9)]
        HRESULT MoveToSelectionAnchorEx(IDisplayPointer pIStartAnchor);

        [VtblIndex(10)]
        HRESULT MoveToSelectionEndEx(IDisplayPointer pIEndAnchor);

        [VtblIndex(11)]
        HRESULT FreezeVirtualCaretPos(BOOL fReCompute);

        [VtblIndex(12)]
        HRESULT UnFreezeVirtualCaretPos(BOOL fReset);
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

        [NativeTypeName("HRESULT (IHTMLEditDesigner *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEditDesigner, int> AddDesigner;

        [NativeTypeName("HRESULT (IHTMLEditDesigner *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEditDesigner, int> RemoveDesigner;

        [NativeTypeName(
            "HRESULT (IMarkupContainer *, ISelectionServices **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupContainer,
            ISelectionServices*,
            int> GetSelectionServices;

        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, int> MoveToSelectionAnchor;

        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, int> MoveToSelectionEnd;

        [NativeTypeName(
            "HRESULT (IMarkupPointer *, IMarkupPointer *, SELECTION_TYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMarkupPointer,
            IMarkupPointer,
            SELECTION_TYPE,
            int> SelectRange;

        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer, int> MoveToSelectionAnchorEx;

        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer, int> MoveToSelectionEndEx;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> FreezeVirtualCaretPos;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> UnFreezeVirtualCaretPos;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLEditServices2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLEditServices2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IHTMLEditServices"/> to <see cref = "IHTMLEditServices2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IHTMLEditServices"/> instance to be converted </param>
    public static explicit operator IHTMLEditServices2(Silk.NET.Windows.IHTMLEditServices value)
    {
        return new IHTMLEditServices2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEditServices2"/> to <see cref = "Silk.NET.Windows.IHTMLEditServices"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEditServices2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IHTMLEditServices(IHTMLEditServices2 value)
    {
        return new Silk.NET.Windows.IHTMLEditServices(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLEditServices2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLEditServices2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLEditServices2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEditServices2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEditServices2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLEditServices2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
