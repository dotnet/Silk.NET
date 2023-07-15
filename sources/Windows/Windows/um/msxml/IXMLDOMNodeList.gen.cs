// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList"]/*'/>
[Guid("2933BF82-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMNodeList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDOMNodeList : IXMLDOMNodeList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNodeList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, Guid*, void**, int> )(lpVtbl[0]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, uint> )(lpVtbl[1]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, uint> )(lpVtbl[2]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, uint*, int> )(lpVtbl[3]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList.get_item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, int, IXMLDOMNode**, int> )(lpVtbl[7]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), index, listItem);
    }

    /// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList.get_length"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_length([NativeTypeName("long *")] int* listLength)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, int*, int> )(lpVtbl[8]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), listLength);
    }

    /// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList.nextNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT nextNode(IXMLDOMNode** nextItem)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, IXMLDOMNode**, int> )(lpVtbl[9]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), nextItem);
    }

    /// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList.reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT reset()
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, int> )(lpVtbl[10]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXMLDOMNodeList.xml' path='doc/member[@name="IXMLDOMNodeList.get__newEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get__newEnum(IUnknown** ppUnk)
    {
        return ((delegate* unmanaged<IXMLDOMNodeList*, IUnknown**, int> )(lpVtbl[11]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), ppUnk);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem);
        [VtblIndex(8)]
        HRESULT get_length([NativeTypeName("long *")] int* listLength);
        [VtblIndex(9)]
        HRESULT nextNode(IXMLDOMNode** nextItem);
        [VtblIndex(10)]
        HRESULT reset();
        [VtblIndex(11)]
        HRESULT get__newEnum(IUnknown** ppUnk);
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
        [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IXMLDOMNode**, int> get_item;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;
        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> nextNode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> reset;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__newEnum;
    }
}