// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHtmlDlgSafeHelper.xml' path='doc/member[@name="IHtmlDlgSafeHelper"]/*'/>
[Guid("3050F81A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHtmlDlgSafeHelper : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHtmlDlgSafeHelper : IHtmlDlgSafeHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHtmlDlgSafeHelper));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, Guid*, void**, int> )(lpVtbl[0]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, uint> )(lpVtbl[1]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, uint> )(lpVtbl[2]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, uint*, int> )(lpVtbl[3]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHtmlDlgSafeHelper.xml' path='doc/member[@name="IHtmlDlgSafeHelper.choosecolordlg"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT choosecolordlg(VARIANT initColor, VARIANT* rgbColor)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, VARIANT, VARIANT*, int> )(lpVtbl[7]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), initColor, rgbColor);
    }

    /// <include file='IHtmlDlgSafeHelper.xml' path='doc/member[@name="IHtmlDlgSafeHelper.getCharset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT getCharset([NativeTypeName("BSTR")] ushort* fontName, VARIANT* charset)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, ushort*, VARIANT*, int> )(lpVtbl[8]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), fontName, charset);
    }

    /// <include file='IHtmlDlgSafeHelper.xml' path='doc/member[@name="IHtmlDlgSafeHelper.get_Fonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Fonts(IDispatch** p)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, IDispatch**, int> )(lpVtbl[9]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHtmlDlgSafeHelper.xml' path='doc/member[@name="IHtmlDlgSafeHelper.get_BlockFormats"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BlockFormats(IDispatch** p)
    {
        return ((delegate* unmanaged<IHtmlDlgSafeHelper*, IDispatch**, int> )(lpVtbl[10]))((IHtmlDlgSafeHelper*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT choosecolordlg(VARIANT initColor, VARIANT* rgbColor);
        [VtblIndex(8)]
        HRESULT getCharset([NativeTypeName("BSTR")] ushort* fontName, VARIANT* charset);
        [VtblIndex(9)]
        HRESULT get_Fonts(IDispatch** p);
        [VtblIndex(10)]
        HRESULT get_BlockFormats(IDispatch** p);
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
        [NativeTypeName("HRESULT (VARIANT, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT*, int> choosecolordlg;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getCharset;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Fonts;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_BlockFormats;
    }
}