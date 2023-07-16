// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices"]/*'/>
[Guid("3050F663-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEditServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLEditServices : IHTMLEditServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEditServices));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEditServices*, uint> )(lpVtbl[1]))((IHTMLEditServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditServices*, uint> )(lpVtbl[2]))((IHTMLEditServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.AddDesigner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddDesigner(IHTMLEditDesigner* pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IHTMLEditDesigner*, int> )(lpVtbl[3]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pIDesigner);
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.RemoveDesigner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveDesigner(IHTMLEditDesigner* pIDesigner)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IHTMLEditDesigner*, int> )(lpVtbl[4]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pIDesigner);
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.GetSelectionServices"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSelectionServices(IMarkupContainer* pIContainer, ISelectionServices** ppSelSvc)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IMarkupContainer*, ISelectionServices**, int> )(lpVtbl[5]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pIContainer, ppSelSvc);
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.MoveToSelectionAnchor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MoveToSelectionAnchor(IMarkupPointer* pIStartAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IMarkupPointer*, int> )(lpVtbl[6]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pIStartAnchor);
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.MoveToSelectionEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToSelectionEnd(IMarkupPointer* pIEndAnchor)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IMarkupPointer*, int> )(lpVtbl[7]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pIEndAnchor);
    }

    /// <include file='IHTMLEditServices.xml' path='doc/member[@name="IHTMLEditServices.SelectRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectRange(IMarkupPointer* pStart, IMarkupPointer* pEnd, SELECTION_TYPE eType)
    {
        return ((delegate* unmanaged<IHTMLEditServices*, IMarkupPointer*, IMarkupPointer*, SELECTION_TYPE, int> )(lpVtbl[8]))((IHTMLEditServices*)Unsafe.AsPointer(ref this), pStart, pEnd, eType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddDesigner(IHTMLEditDesigner* pIDesigner);
        [VtblIndex(4)]
        HRESULT RemoveDesigner(IHTMLEditDesigner* pIDesigner);
        [VtblIndex(5)]
        HRESULT GetSelectionServices(IMarkupContainer* pIContainer, ISelectionServices** ppSelSvc);
        [VtblIndex(6)]
        HRESULT MoveToSelectionAnchor(IMarkupPointer* pIStartAnchor);
        [VtblIndex(7)]
        HRESULT MoveToSelectionEnd(IMarkupPointer* pIEndAnchor);
        [VtblIndex(8)]
        HRESULT SelectRange(IMarkupPointer* pStart, IMarkupPointer* pEnd, SELECTION_TYPE eType);
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
    }
}