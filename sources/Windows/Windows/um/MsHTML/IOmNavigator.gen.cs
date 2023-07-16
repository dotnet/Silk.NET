// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator"]/*'/>
[Guid("FECEAAA5-8405-11CF-8BA1-00AA00476DA6")]
[NativeTypeName("struct IOmNavigator : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IOmNavigator : IOmNavigator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOmNavigator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOmNavigator*, Guid*, void**, int> )(lpVtbl[0]))((IOmNavigator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOmNavigator*, uint> )(lpVtbl[1]))((IOmNavigator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOmNavigator*, uint> )(lpVtbl[2]))((IOmNavigator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IOmNavigator*, uint*, int> )(lpVtbl[3]))((IOmNavigator*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IOmNavigator*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IOmNavigator*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IOmNavigator*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IOmNavigator*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IOmNavigator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IOmNavigator*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_appCodeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_appCodeName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[7]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_appName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_appName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[8]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_appVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_appVersion([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[9]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_userAgent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_userAgent([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[10]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.javaEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled)
    {
        return ((delegate* unmanaged<IOmNavigator*, short*, int> )(lpVtbl[11]))((IOmNavigator*)Unsafe.AsPointer(ref this), enabled);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.taintEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT taintEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled)
    {
        return ((delegate* unmanaged<IOmNavigator*, short*, int> )(lpVtbl[12]))((IOmNavigator*)Unsafe.AsPointer(ref this), enabled);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_mimeTypes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_mimeTypes(IHTMLMimeTypesCollection** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, IHTMLMimeTypesCollection**, int> )(lpVtbl[13]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_plugins"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_plugins(IHTMLPluginsCollection** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, IHTMLPluginsCollection**, int> )(lpVtbl[14]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_cookieEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IOmNavigator*, short*, int> )(lpVtbl[15]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_opsProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_opsProfile(IHTMLOpsProfile** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, IHTMLOpsProfile**, int> )(lpVtbl[16]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** @string)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[17]))((IOmNavigator*)Unsafe.AsPointer(ref this), @string);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_cpuClass"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_cpuClass([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[18]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_systemLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_systemLanguage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[19]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_browserLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_browserLanguage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[20]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_userLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_userLanguage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[21]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_platform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_platform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[22]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_appMinorVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_appMinorVersion([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, ushort**, int> )(lpVtbl[23]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_connectionSpeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_connectionSpeed([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IOmNavigator*, int*, int> )(lpVtbl[24]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_onLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IOmNavigator*, short*, int> )(lpVtbl[25]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IOmNavigator.xml' path='doc/member[@name="IOmNavigator.get_userProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_userProfile(IHTMLOpsProfile** p)
    {
        return ((delegate* unmanaged<IOmNavigator*, IHTMLOpsProfile**, int> )(lpVtbl[26]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_appCodeName([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(8)]
        HRESULT get_appName([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT get_appVersion([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(10)]
        HRESULT get_userAgent([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled);
        [VtblIndex(12)]
        HRESULT taintEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled);
        [VtblIndex(13)]
        HRESULT get_mimeTypes(IHTMLMimeTypesCollection** p);
        [VtblIndex(14)]
        HRESULT get_plugins(IHTMLPluginsCollection** p);
        [VtblIndex(15)]
        HRESULT get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(16)]
        HRESULT get_opsProfile(IHTMLOpsProfile** p);
        [VtblIndex(17)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** @string);
        [VtblIndex(18)]
        HRESULT get_cpuClass([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT get_systemLanguage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(20)]
        HRESULT get_browserLanguage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT get_userLanguage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT get_platform([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT get_appMinorVersion([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(24)]
        HRESULT get_connectionSpeed([NativeTypeName("long *")] int* p);
        [VtblIndex(25)]
        HRESULT get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(26)]
        HRESULT get_userProfile(IHTMLOpsProfile** p);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_appCodeName;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_appName;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_appVersion;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_userAgent;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> javaEnabled;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> taintEnabled;
        [NativeTypeName("HRESULT (IHTMLMimeTypesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLMimeTypesCollection**, int> get_mimeTypes;
        [NativeTypeName("HRESULT (IHTMLPluginsCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLPluginsCollection**, int> get_plugins;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cookieEnabled;
        [NativeTypeName("HRESULT (IHTMLOpsProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLOpsProfile**, int> get_opsProfile;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cpuClass;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_systemLanguage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_browserLanguage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_userLanguage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_platform;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_appMinorVersion;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_connectionSpeed;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_onLine;
        [NativeTypeName("HRESULT (IHTMLOpsProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLOpsProfile**, int> get_userProfile;
    }
}