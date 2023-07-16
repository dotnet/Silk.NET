// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost"]/*'/>
[Guid("18BCC359-4990-4BFB-B951-3C83702BE5F9")]
[NativeTypeName("struct IWebWizardHost : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWebWizardHost : IWebWizardHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebWizardHost));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebWizardHost*, Guid*, void**, int> )(lpVtbl[0]))((IWebWizardHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebWizardHost*, uint> )(lpVtbl[1]))((IWebWizardHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebWizardHost*, uint> )(lpVtbl[2]))((IWebWizardHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWebWizardHost*, uint*, int> )(lpVtbl[3]))((IWebWizardHost*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWebWizardHost*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IWebWizardHost*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWebWizardHost*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IWebWizardHost*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWebWizardHost*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IWebWizardHost*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.FinalBack"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FinalBack()
    {
        return ((delegate* unmanaged<IWebWizardHost*, int> )(lpVtbl[7]))((IWebWizardHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.FinalNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FinalNext()
    {
        return ((delegate* unmanaged<IWebWizardHost*, int> )(lpVtbl[8]))((IWebWizardHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.Cancel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged<IWebWizardHost*, int> )(lpVtbl[9]))((IWebWizardHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.put_Caption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Caption([NativeTypeName("BSTR")] ushort* bstrCaption)
    {
        return ((delegate* unmanaged<IWebWizardHost*, ushort*, int> )(lpVtbl[10]))((IWebWizardHost*)Unsafe.AsPointer(ref this), bstrCaption);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.get_Caption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** pbstrCaption)
    {
        return ((delegate* unmanaged<IWebWizardHost*, ushort**, int> )(lpVtbl[11]))((IWebWizardHost*)Unsafe.AsPointer(ref this), pbstrCaption);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.put_Property"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
    {
        return ((delegate* unmanaged<IWebWizardHost*, ushort*, VARIANT*, int> )(lpVtbl[12]))((IWebWizardHost*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.get_Property"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
    {
        return ((delegate* unmanaged<IWebWizardHost*, ushort*, VARIANT*, int> )(lpVtbl[13]))((IWebWizardHost*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.SetWizardButtons"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetWizardButtons([NativeTypeName("VARIANT_BOOL")] short vfEnableBack, [NativeTypeName("VARIANT_BOOL")] short vfEnableNext, [NativeTypeName("VARIANT_BOOL")] short vfLastPage)
    {
        return ((delegate* unmanaged<IWebWizardHost*, short, short, short, int> )(lpVtbl[14]))((IWebWizardHost*)Unsafe.AsPointer(ref this), vfEnableBack, vfEnableNext, vfLastPage);
    }

    /// <include file='IWebWizardHost.xml' path='doc/member[@name="IWebWizardHost.SetHeaderText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetHeaderText([NativeTypeName("BSTR")] ushort* bstrHeaderTitle, [NativeTypeName("BSTR")] ushort* bstrHeaderSubtitle)
    {
        return ((delegate* unmanaged<IWebWizardHost*, ushort*, ushort*, int> )(lpVtbl[15]))((IWebWizardHost*)Unsafe.AsPointer(ref this), bstrHeaderTitle, bstrHeaderSubtitle);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT FinalBack();
        [VtblIndex(8)]
        HRESULT FinalNext();
        [VtblIndex(9)]
        HRESULT Cancel();
        [VtblIndex(10)]
        HRESULT put_Caption([NativeTypeName("BSTR")] ushort* bstrCaption);
        [VtblIndex(11)]
        HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** pbstrCaption);
        [VtblIndex(12)]
        HRESULT put_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty);
        [VtblIndex(13)]
        HRESULT get_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty);
        [VtblIndex(14)]
        HRESULT SetWizardButtons([NativeTypeName("VARIANT_BOOL")] short vfEnableBack, [NativeTypeName("VARIANT_BOOL")] short vfEnableNext, [NativeTypeName("VARIANT_BOOL")] short vfLastPage);
        [VtblIndex(15)]
        HRESULT SetHeaderText([NativeTypeName("BSTR")] ushort* bstrHeaderTitle, [NativeTypeName("BSTR")] ushort* bstrHeaderSubtitle);
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
        public delegate* unmanaged<TSelf*, int> FinalBack;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FinalNext;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Cancel;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Caption;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Caption;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> put_Property;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> get_Property;
        [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, short, short, int> SetWizardButtons;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetHeaderText;
    }
}