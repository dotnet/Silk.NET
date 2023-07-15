// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2"]/*'/>
[Guid("3050F2D3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTextAreaElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTextAreaElement2 : IHTMLTextAreaElement2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTextAreaElement2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, uint> )(lpVtbl[1]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, uint> )(lpVtbl[2]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, uint*, int> )(lpVtbl[3]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2.put_selectionStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_selectionStart([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int, int> )(lpVtbl[7]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2.get_selectionStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_selectionStart([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int*, int> )(lpVtbl[8]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2.put_selectionEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_selectionEnd([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int, int> )(lpVtbl[9]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2.get_selectionEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_selectionEnd([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int*, int> )(lpVtbl[10]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextAreaElement2.xml' path='doc/member[@name="IHTMLTextAreaElement2.setSelectionRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setSelectionRange([NativeTypeName("long")] int start, [NativeTypeName("long")] int end)
    {
        return ((delegate* unmanaged<IHTMLTextAreaElement2*, int, int, int> )(lpVtbl[11]))((IHTMLTextAreaElement2*)Unsafe.AsPointer(ref this), start, end);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_selectionStart([NativeTypeName("long")] int v);
        [VtblIndex(8)]
        HRESULT get_selectionStart([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT put_selectionEnd([NativeTypeName("long")] int v);
        [VtblIndex(10)]
        HRESULT get_selectionEnd([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT setSelectionRange([NativeTypeName("long")] int start, [NativeTypeName("long")] int end);
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
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_selectionStart;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_selectionStart;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_selectionEnd;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_selectionEnd;
        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> setSelectionRange;
    }
}