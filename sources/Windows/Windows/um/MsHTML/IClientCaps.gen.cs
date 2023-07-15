// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps"]/*'/>
[Guid("7E8BC44D-AEFF-11D1-89C2-00C04FB6BFC4")]
[NativeTypeName("struct IClientCaps : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IClientCaps : IClientCaps.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClientCaps));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClientCaps*, Guid*, void**, int> )(lpVtbl[0]))((IClientCaps*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IClientCaps*, uint> )(lpVtbl[1]))((IClientCaps*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClientCaps*, uint> )(lpVtbl[2]))((IClientCaps*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IClientCaps*, uint*, int> )(lpVtbl[3]))((IClientCaps*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IClientCaps*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IClientCaps*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IClientCaps*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IClientCaps*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IClientCaps*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IClientCaps*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_javaEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IClientCaps*, short*, int> )(lpVtbl[7]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_cookieEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IClientCaps*, short*, int> )(lpVtbl[8]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_cpuClass"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_cpuClass([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort**, int> )(lpVtbl[9]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_systemLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_systemLanguage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort**, int> )(lpVtbl[10]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_userLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_userLanguage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort**, int> )(lpVtbl[11]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_platform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_platform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort**, int> )(lpVtbl[12]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_connectionSpeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_connectionSpeed([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[13]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_onLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IClientCaps*, short*, int> )(lpVtbl[14]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_colorDepth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_colorDepth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[15]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_bufferDepth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_bufferDepth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[16]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_width([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[17]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_height([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[18]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_availHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_availHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[19]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_availWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_availWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, int*, int> )(lpVtbl[20]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.get_connectionType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_connectionType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort**, int> )(lpVtbl[21]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.isComponentInstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT isComponentInstalled([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer, [NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort*, short*, int> )(lpVtbl[22]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, bStrVer, p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.getComponentVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT getComponentVersion([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrVer)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort**, int> )(lpVtbl[23]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, pbstrVer);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.compareVersions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT compareVersions([NativeTypeName("BSTR")] ushort* bstrVer1, [NativeTypeName("BSTR")] ushort* bstrVer2, [NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, int*, int> )(lpVtbl[24]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrVer1, bstrVer2, p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.addComponentRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT addComponentRequest([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer = null)
    {
        return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort*, int> )(lpVtbl[25]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, bStrVer);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.doComponentRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT doComponentRequest([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IClientCaps*, short*, int> )(lpVtbl[26]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IClientCaps.xml' path='doc/member[@name="IClientCaps.clearComponentRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT clearComponentRequest()
    {
        return ((delegate* unmanaged<IClientCaps*, int> )(lpVtbl[27]))((IClientCaps*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(8)]
        HRESULT get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(9)]
        HRESULT get_cpuClass([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_systemLanguage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT get_userLanguage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT get_platform([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT get_connectionSpeed([NativeTypeName("long *")] int* p);
        [VtblIndex(14)]
        HRESULT get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(15)]
        HRESULT get_colorDepth([NativeTypeName("long *")] int* p);
        [VtblIndex(16)]
        HRESULT get_bufferDepth([NativeTypeName("long *")] int* p);
        [VtblIndex(17)]
        HRESULT get_width([NativeTypeName("long *")] int* p);
        [VtblIndex(18)]
        HRESULT get_height([NativeTypeName("long *")] int* p);
        [VtblIndex(19)]
        HRESULT get_availHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(20)]
        HRESULT get_availWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(21)]
        HRESULT get_connectionType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT isComponentInstalled([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer, [NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(23)]
        HRESULT getComponentVersion([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrVer);
        [VtblIndex(24)]
        HRESULT compareVersions([NativeTypeName("BSTR")] ushort* bstrVer1, [NativeTypeName("BSTR")] ushort* bstrVer2, [NativeTypeName("long *")] int* p);
        [VtblIndex(25)]
        HRESULT addComponentRequest([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer = null);
        [VtblIndex(26)]
        HRESULT doComponentRequest([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(27)]
        HRESULT clearComponentRequest();
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
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_javaEnabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cookieEnabled;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cpuClass;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_systemLanguage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_userLanguage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_platform;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_connectionSpeed;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_onLine;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_colorDepth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_bufferDepth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_width;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_height;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_availHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_availWidth;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_connectionType;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, short*, int> isComponentInstalled;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, int> getComponentVersion;
        [NativeTypeName("HRESULT (BSTR, BSTR, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int*, int> compareVersions;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> addComponentRequest;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> doComponentRequest;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clearComponentRequest;
    }
}