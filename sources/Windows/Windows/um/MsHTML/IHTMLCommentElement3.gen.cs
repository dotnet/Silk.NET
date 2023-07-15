// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLCommentElement3.xml' path='doc/member[@name="IHTMLCommentElement3"]/*'/>
[Guid("3051073F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCommentElement3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCommentElement3 : IHTMLCommentElement3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCommentElement3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, uint> )(lpVtbl[1]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, uint> )(lpVtbl[2]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, uint*, int> )(lpVtbl[3]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCommentElement3.xml' path='doc/member[@name="IHTMLCommentElement3.substringData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR *")] ushort** pbstrsubString)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, int, int, ushort**, int> )(lpVtbl[7]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), offset, Count, pbstrsubString);
    }

    /// <include file='IHTMLCommentElement3.xml' path='doc/member[@name="IHTMLCommentElement3.insertData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* bstrstring)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, int, ushort*, int> )(lpVtbl[8]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), offset, bstrstring);
    }

    /// <include file='IHTMLCommentElement3.xml' path='doc/member[@name="IHTMLCommentElement3.deleteData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, int, int, int> )(lpVtbl[9]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), offset, Count);
    }

    /// <include file='IHTMLCommentElement3.xml' path='doc/member[@name="IHTMLCommentElement3.replaceData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR")] ushort* bstrstring)
    {
        return ((delegate* unmanaged<IHTMLCommentElement3*, int, int, ushort*, int> )(lpVtbl[10]))((IHTMLCommentElement3*)Unsafe.AsPointer(ref this), offset, Count, bstrstring);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR *")] ushort** pbstrsubString);
        [VtblIndex(8)]
        HRESULT insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* bstrstring);
        [VtblIndex(9)]
        HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count);
        [VtblIndex(10)]
        HRESULT replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR")] ushort* bstrstring);
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
        [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort**, int> substringData;
        [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, int> insertData;
        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> deleteData;
        [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort*, int> replaceData;
    }
}