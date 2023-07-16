// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand"]/*'/>
[Guid("2D91EEA1-9932-11D2-BE86-00A0C9A83DA1")]
[NativeTypeName("struct IFileSearchBand : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IFileSearchBand : IFileSearchBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSearchBand));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSearchBand*, Guid*, void**, int> )(lpVtbl[0]))((IFileSearchBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSearchBand*, uint> )(lpVtbl[1]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSearchBand*, uint> )(lpVtbl[2]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFileSearchBand*, uint*, int> )(lpVtbl[3]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFileSearchBand*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFileSearchBand*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFileSearchBand*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFileSearchBand*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFileSearchBand*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFileSearchBand*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand.SetFocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFocus()
    {
        return ((delegate* unmanaged<IFileSearchBand*, int> )(lpVtbl[7]))((IFileSearchBand*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand.SetSearchParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSearchParameters([NativeTypeName("BSTR *")] ushort** pbstrSearchID, [NativeTypeName("VARIANT_BOOL")] short bNavToResults, VARIANT* pvarScope, VARIANT* pvarQueryFile)
    {
        return ((delegate* unmanaged<IFileSearchBand*, ushort**, short, VARIANT*, VARIANT*, int> )(lpVtbl[8]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pbstrSearchID, bNavToResults, pvarScope, pvarQueryFile);
    }

    /// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand.get_SearchID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SearchID([NativeTypeName("BSTR *")] ushort** pbstrSearchID)
    {
        return ((delegate* unmanaged<IFileSearchBand*, ushort**, int> )(lpVtbl[9]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pbstrSearchID);
    }

    /// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand.get_Scope"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Scope(VARIANT* pvarScope)
    {
        return ((delegate* unmanaged<IFileSearchBand*, VARIANT*, int> )(lpVtbl[10]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pvarScope);
    }

    /// <include file='IFileSearchBand.xml' path='doc/member[@name="IFileSearchBand.get_QueryFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_QueryFile(VARIANT* pvarFile)
    {
        return ((delegate* unmanaged<IFileSearchBand*, VARIANT*, int> )(lpVtbl[11]))((IFileSearchBand*)Unsafe.AsPointer(ref this), pvarFile);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT SetFocus();
        [VtblIndex(8)]
        HRESULT SetSearchParameters([NativeTypeName("BSTR *")] ushort** pbstrSearchID, [NativeTypeName("VARIANT_BOOL")] short bNavToResults, VARIANT* pvarScope, VARIANT* pvarQueryFile);
        [VtblIndex(9)]
        HRESULT get_SearchID([NativeTypeName("BSTR *")] ushort** pbstrSearchID);
        [VtblIndex(10)]
        HRESULT get_Scope(VARIANT* pvarScope);
        [VtblIndex(11)]
        HRESULT get_QueryFile(VARIANT* pvarFile);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetFocus;
        [NativeTypeName("HRESULT (BSTR *, VARIANT_BOOL, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, short, VARIANT*, VARIANT*, int> SetSearchParameters;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SearchID;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Scope;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_QueryFile;
    }
}