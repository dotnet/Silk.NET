// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog"]/*' />
[Guid("3050F216-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDialog : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDialog : IHTMLDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDialog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDialog*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDialog*, uint>)(lpVtbl[1]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDialog*, uint>)(lpVtbl[2]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDialog*, uint*, int>)(lpVtbl[3]))((IHTMLDialog*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDialog*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDialog*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDialog*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDialog*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDialog*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDialog*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.put_dialogTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_dialogTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[7]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_dialogTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_dialogTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.put_dialogLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_dialogLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[9]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_dialogLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_dialogLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.put_dialogWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_dialogWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[11]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_dialogWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_dialogWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.put_dialogHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_dialogHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[13]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_dialogHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_dialogHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_dialogArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_dialogArguments(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[15]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_menuArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_menuArguments(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[16]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.put_returnValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_returnValue(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[17]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.get_returnValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_returnValue(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[18]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT close()
    {
        return ((delegate* unmanaged<IHTMLDialog*, int>)(lpVtbl[19]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLDialog.xml' path='doc/member[@name="IHTMLDialog.toString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLDialog*, ushort**, int>)(lpVtbl[20]))((IHTMLDialog*)Unsafe.AsPointer(ref this), String);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_dialogTop(VARIANT v);

        [VtblIndex(8)]
        HRESULT get_dialogTop(VARIANT* p);

        [VtblIndex(9)]
        HRESULT put_dialogLeft(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_dialogLeft(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_dialogWidth(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_dialogWidth(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_dialogHeight(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_dialogHeight(VARIANT* p);

        [VtblIndex(15)]
        HRESULT get_dialogArguments(VARIANT* p);

        [VtblIndex(16)]
        HRESULT get_menuArguments(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_returnValue(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_returnValue(VARIANT* p);

        [VtblIndex(19)]
        HRESULT close();

        [VtblIndex(20)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);
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

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_dialogTop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dialogTop;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_dialogLeft;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dialogLeft;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_dialogWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dialogWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_dialogHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dialogHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dialogArguments;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_menuArguments;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_returnValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_returnValue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> close;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
    }
}
