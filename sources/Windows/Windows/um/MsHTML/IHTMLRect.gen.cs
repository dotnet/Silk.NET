// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect"]/*'/>
[Guid("3050F4A3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLRect : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLRect : IHTMLRect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLRect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLRect*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLRect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLRect*, uint> )(lpVtbl[1]))((IHTMLRect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLRect*, uint> )(lpVtbl[2]))((IHTMLRect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLRect*, uint*, int> )(lpVtbl[3]))((IHTMLRect*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLRect*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLRect*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLRect*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLRect*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLRect*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLRect*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.put_left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_left([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLRect*, int, int> )(lpVtbl[7]))((IHTMLRect*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.get_left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_left([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLRect*, int*, int> )(lpVtbl[8]))((IHTMLRect*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.put_top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_top([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLRect*, int, int> )(lpVtbl[9]))((IHTMLRect*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.get_top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_top([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLRect*, int*, int> )(lpVtbl[10]))((IHTMLRect*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.put_right"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_right([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLRect*, int, int> )(lpVtbl[11]))((IHTMLRect*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.get_right"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_right([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLRect*, int*, int> )(lpVtbl[12]))((IHTMLRect*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.put_bottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_bottom([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLRect*, int, int> )(lpVtbl[13]))((IHTMLRect*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRect.xml' path='doc/member[@name="IHTMLRect.get_bottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_bottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLRect*, int*, int> )(lpVtbl[14]))((IHTMLRect*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_left([NativeTypeName("long")] int v);
        [VtblIndex(8)]
        HRESULT get_left([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT put_top([NativeTypeName("long")] int v);
        [VtblIndex(10)]
        HRESULT get_top([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT put_right([NativeTypeName("long")] int v);
        [VtblIndex(12)]
        HRESULT get_right([NativeTypeName("long *")] int* p);
        [VtblIndex(13)]
        HRESULT put_bottom([NativeTypeName("long")] int v);
        [VtblIndex(14)]
        HRESULT get_bottom([NativeTypeName("long *")] int* p);
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
        public delegate* unmanaged<TSelf*, int, int> put_left;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_left;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_top;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_top;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_right;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_right;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_bottom;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_bottom;
    }
}