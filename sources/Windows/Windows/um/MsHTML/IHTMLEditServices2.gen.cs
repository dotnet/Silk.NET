// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLEditServices2.xml' path='doc/member[@name="IHTMLEditServices2"]/*'/>
[Guid("3050F812-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEditServices2 : IHTMLEditServices")]
[NativeInheritance("IHTMLEditServices")]
public unsafe partial struct IHTMLEditServices2 : IHTMLEditServices2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEditServices2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, uint> )(lpVtbl[1]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, uint> )(lpVtbl[2]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHTMLEditServices.AddDesigner"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddDesigner(IHTMLEditDesigner* pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IHTMLEditDesigner*, int> )(lpVtbl[3]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIDesigner);
    }

    /// <inheritdoc cref = "IHTMLEditServices.RemoveDesigner"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveDesigner(IHTMLEditDesigner* pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IHTMLEditDesigner*, int> )(lpVtbl[4]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIDesigner);
    }

    /// <inheritdoc cref = "IHTMLEditServices.GetSelectionServices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSelectionServices(IMarkupContainer* pIContainer, ISelectionServices** ppSelSvc)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupContainer*, ISelectionServices**, int> )(lpVtbl[5]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIContainer, ppSelSvc);
    }

    /// <inheritdoc cref = "IHTMLEditServices.MoveToSelectionAnchor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MoveToSelectionAnchor(IMarkupPointer* pIStartAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, int> )(lpVtbl[6]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIStartAnchor);
    }

    /// <inheritdoc cref = "IHTMLEditServices.MoveToSelectionEnd"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToSelectionEnd(IMarkupPointer* pIEndAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, int> )(lpVtbl[7]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIEndAnchor);
    }

    /// <inheritdoc cref = "IHTMLEditServices.SelectRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectRange(IMarkupPointer* pStart, IMarkupPointer* pEnd, SELECTION_TYPE eType)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, IMarkupPointer*, SELECTION_TYPE, int> )(lpVtbl[8]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pStart, pEnd, eType);
    }

    /// <include file='IHTMLEditServices2.xml' path='doc/member[@name="IHTMLEditServices2.MoveToSelectionAnchorEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MoveToSelectionAnchorEx(IDisplayPointer* pIStartAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IDisplayPointer*, int> )(lpVtbl[9]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIStartAnchor);
    }

    /// <include file='IHTMLEditServices2.xml' path='doc/member[@name="IHTMLEditServices2.MoveToSelectionEndEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT MoveToSelectionEndEx(IDisplayPointer* pIEndAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, IDisplayPointer*, int> )(lpVtbl[10]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIEndAnchor);
    }

    /// <include file='IHTMLEditServices2.xml' path='doc/member[@name="IHTMLEditServices2.FreezeVirtualCaretPos"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FreezeVirtualCaretPos(BOOL fReCompute)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, BOOL, int> )(lpVtbl[11]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), fReCompute);
    }

    /// <include file='IHTMLEditServices2.xml' path='doc/member[@name="IHTMLEditServices2.UnFreezeVirtualCaretPos"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnFreezeVirtualCaretPos(BOOL fReset)
    {
        return ((delegate* unmanaged<IHTMLEditServices2*, BOOL, int> )(lpVtbl[12]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), fReset);
    }

    public interface Interface : IHTMLEditServices.Interface
    {
        [VtblIndex(9)]
        HRESULT MoveToSelectionAnchorEx(IDisplayPointer* pIStartAnchor);
        [VtblIndex(10)]
        HRESULT MoveToSelectionEndEx(IDisplayPointer* pIEndAnchor);
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
        public delegate* unmanaged<TSelf*, IHTMLEditDesigner*, int> AddDesigner;
        [NativeTypeName("HRESULT (IHTMLEditDesigner *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEditDesigner*, int> RemoveDesigner;
        [NativeTypeName("HRESULT (IMarkupContainer *, ISelectionServices **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer*, ISelectionServices**, int> GetSelectionServices;
        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, int> MoveToSelectionAnchor;
        [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, int> MoveToSelectionEnd;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, SELECTION_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, SELECTION_TYPE, int> SelectRange;
        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer*, int> MoveToSelectionAnchorEx;
        [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDisplayPointer*, int> MoveToSelectionEndEx;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> FreezeVirtualCaretPos;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> UnFreezeVirtualCaretPos;
    }
}