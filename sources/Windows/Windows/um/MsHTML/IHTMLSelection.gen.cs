// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection"]/*'/>
[Guid("305104B6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLSelection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLSelection : IHTMLSelection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLSelection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLSelection*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLSelection*, uint> )(lpVtbl[1]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLSelection*, uint> )(lpVtbl[2]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLSelection*, uint*, int> )(lpVtbl[3]))((IHTMLSelection*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLSelection*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLSelection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLSelection*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLSelection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLSelection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLSelection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_anchorNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_anchorNode(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int> )(lpVtbl[7]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_anchorOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_anchorOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, int*, int> )(lpVtbl[8]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_focusNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_focusNode(IHTMLDOMNode** p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IHTMLDOMNode**, int> )(lpVtbl[9]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_focusOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_focusOffset([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, int*, int> )(lpVtbl[10]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_isCollapsed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_isCollapsed([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, short*, int> )(lpVtbl[11]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.collapse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT collapse(IDispatch* parentNode, [NativeTypeName("long")] int offfset)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int, int> )(lpVtbl[12]))((IHTMLSelection*)Unsafe.AsPointer(ref this), parentNode, offfset);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.collapseToStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT collapseToStart()
    {
        return ((delegate* unmanaged<IHTMLSelection*, int> )(lpVtbl[13]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.collapseToEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT collapseToEnd()
    {
        return ((delegate* unmanaged<IHTMLSelection*, int> )(lpVtbl[14]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.selectAllChildren"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT selectAllChildren(IDispatch* parentNode)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int> )(lpVtbl[15]))((IHTMLSelection*)Unsafe.AsPointer(ref this), parentNode);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.deleteFromDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT deleteFromDocument()
    {
        return ((delegate* unmanaged<IHTMLSelection*, int> )(lpVtbl[16]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.get_rangeCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_rangeCount([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLSelection*, int*, int> )(lpVtbl[17]))((IHTMLSelection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.getRangeAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getRangeAt([NativeTypeName("long")] int index, IHTMLDOMRange** ppRange)
    {
        return ((delegate* unmanaged<IHTMLSelection*, int, IHTMLDOMRange**, int> )(lpVtbl[18]))((IHTMLSelection*)Unsafe.AsPointer(ref this), index, ppRange);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.addRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT addRange(IDispatch* range)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int> )(lpVtbl[19]))((IHTMLSelection*)Unsafe.AsPointer(ref this), range);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.removeRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeRange(IDispatch* range)
    {
        return ((delegate* unmanaged<IHTMLSelection*, IDispatch*, int> )(lpVtbl[20]))((IHTMLSelection*)Unsafe.AsPointer(ref this), range);
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.removeAllRanges"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT removeAllRanges()
    {
        return ((delegate* unmanaged<IHTMLSelection*, int> )(lpVtbl[21]))((IHTMLSelection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLSelection.xml' path='doc/member[@name="IHTMLSelection.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** pSelectionString)
    {
        return ((delegate* unmanaged<IHTMLSelection*, ushort**, int> )(lpVtbl[22]))((IHTMLSelection*)Unsafe.AsPointer(ref this), pSelectionString);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_anchorNode(IHTMLDOMNode** p);
        [VtblIndex(8)]
        HRESULT get_anchorOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT get_focusNode(IHTMLDOMNode** p);
        [VtblIndex(10)]
        HRESULT get_focusOffset([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_isCollapsed([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(12)]
        HRESULT collapse(IDispatch* parentNode, [NativeTypeName("long")] int offfset);
        [VtblIndex(13)]
        HRESULT collapseToStart();
        [VtblIndex(14)]
        HRESULT collapseToEnd();
        [VtblIndex(15)]
        HRESULT selectAllChildren(IDispatch* parentNode);
        [VtblIndex(16)]
        HRESULT deleteFromDocument();
        [VtblIndex(17)]
        HRESULT get_rangeCount([NativeTypeName("long *")] int* p);
        [VtblIndex(18)]
        HRESULT getRangeAt([NativeTypeName("long")] int index, IHTMLDOMRange** ppRange);
        [VtblIndex(19)]
        HRESULT addRange(IDispatch* range);
        [VtblIndex(20)]
        HRESULT removeRange(IDispatch* range);
        [VtblIndex(21)]
        HRESULT removeAllRanges();
        [VtblIndex(22)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** pSelectionString);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_anchorNode;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_anchorOffset;
        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode**, int> get_focusNode;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_focusOffset;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isCollapsed;
        [NativeTypeName("HRESULT (IDispatch *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int, int> collapse;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> collapseToStart;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> collapseToEnd;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> selectAllChildren;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteFromDocument;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_rangeCount;
        [NativeTypeName("HRESULT (long, IHTMLDOMRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IHTMLDOMRange**, int> getRangeAt;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> addRange;
        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> removeRange;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> removeAllRanges;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
    }
}