// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IIE70DispatchEx.xml' path='doc/member[@name="IIE70DispatchEx"]/*'/>
[Guid("3051046B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IIE70DispatchEx : IDispatchEx")]
[NativeInheritance("IDispatchEx")]
public unsafe partial struct IIE70DispatchEx : IIE70DispatchEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIE70DispatchEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, Guid*, void**, int> )(lpVtbl[0]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, uint> )(lpVtbl[1]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, uint> )(lpVtbl[2]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, uint*, int> )(lpVtbl[3]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IDispatchEx.GetDispID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, ushort*, uint, int*, int> )(lpVtbl[7]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex, pid);
    }

    /// <inheritdoc cref = "IDispatchEx.InvokeEx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider* pspCaller)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider*, int> )(lpVtbl[8]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), id, lcid, wFlags, pdp, pvarRes, pei, pspCaller);
    }

    /// <inheritdoc cref = "IDispatchEx.DeleteMemberByName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, ushort*, uint, int> )(lpVtbl[9]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex);
    }

    /// <inheritdoc cref = "IDispatchEx.DeleteMemberByDispID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, int, int> )(lpVtbl[10]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), id);
    }

    /// <inheritdoc cref = "IDispatchEx.GetMemberProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, int, uint, uint*, int> )(lpVtbl[11]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), id, grfdexFetch, pgrfdex);
    }

    /// <inheritdoc cref = "IDispatchEx.GetMemberName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, int, ushort**, int> )(lpVtbl[12]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), id, pbstrName);
    }

    /// <inheritdoc cref = "IDispatchEx.GetNextDispID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, uint, int, int*, int> )(lpVtbl[13]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), grfdex, id, pid);
    }

    /// <inheritdoc cref = "IDispatchEx.GetNameSpaceParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNameSpaceParent(IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IIE70DispatchEx*, IUnknown**, int> )(lpVtbl[14]))((IIE70DispatchEx*)Unsafe.AsPointer(ref this), ppunk);
    }

    public interface Interface : IDispatchEx.Interface
    {
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
        [NativeTypeName("HRESULT (BSTR, DWORD, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int*, int> GetDispID;
        [NativeTypeName("HRESULT (DISPID, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, IServiceProvider *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider*, int> InvokeEx;
        [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> DeleteMemberByName;
        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> DeleteMemberByDispID;
        [NativeTypeName("HRESULT (DISPID, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, uint*, int> GetMemberProperties;
        [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetMemberName;
        [NativeTypeName("HRESULT (DWORD, DISPID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int*, int> GetNextDispID;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetNameSpaceParent;
    }
}