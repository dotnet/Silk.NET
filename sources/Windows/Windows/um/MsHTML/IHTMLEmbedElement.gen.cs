// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement"]/*' />
[Guid("3050F25F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEmbedElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLEmbedElement : IHTMLEmbedElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEmbedElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, uint>)(lpVtbl[1]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, uint>)(lpVtbl[2]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, uint*, int>)(lpVtbl[3]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_hidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_hidden([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort*, int>)(lpVtbl[7]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_hidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_hidden([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[8]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_palette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_palette([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[9]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_pluginspage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_pluginspage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[10]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort*, int>)(lpVtbl[11]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[12]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_units"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_units([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort*, int>)(lpVtbl[13]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_units"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_units([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[14]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort*, int>)(lpVtbl[15]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, ushort**, int>)(lpVtbl[16]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.put_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, VARIANT, int>)(lpVtbl[19]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLEmbedElement.xml' path='doc/member[@name="IHTMLEmbedElement.get_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLEmbedElement*, VARIANT*, int>)(lpVtbl[20]))((IHTMLEmbedElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_hidden([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_hidden([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_palette([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_pluginspage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_units([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_units([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_width(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_width(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_height(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_height(VARIANT* p);
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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_hidden;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_hidden;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_palette;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pluginspage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_units;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_units;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;
    }
}
