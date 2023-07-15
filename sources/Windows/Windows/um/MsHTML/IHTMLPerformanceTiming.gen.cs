// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming"]/*'/>
[Guid("30510752-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLPerformanceTiming : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLPerformanceTiming : IHTMLPerformanceTiming.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLPerformanceTiming));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint> )(lpVtbl[1]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint> )(lpVtbl[2]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint*, int> )(lpVtbl[3]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_navigationStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_navigationStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[7]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_unloadEventStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_unloadEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[8]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_unloadEventEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_unloadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[9]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_redirectStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_redirectStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[10]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_redirectEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_redirectEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[11]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_fetchStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_fetchStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[12]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domainLookupStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_domainLookupStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[13]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domainLookupEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_domainLookupEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[14]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_connectStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_connectStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[15]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_connectEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_connectEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[16]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_requestStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_requestStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[17]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_responseStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_responseStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[18]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_responseEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_responseEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[19]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domLoading"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_domLoading([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[20]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domInteractive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_domInteractive([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[21]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domContentLoadedEventStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_domContentLoadedEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[22]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domContentLoadedEventEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_domContentLoadedEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[23]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_domComplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_domComplete([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[24]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_loadEventStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_loadEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[25]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_loadEventEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_loadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[26]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.get_msFirstPaint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_msFirstPaint([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int> )(lpVtbl[27]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** @string)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, ushort**, int> )(lpVtbl[28]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), @string);
    }

    /// <include file='IHTMLPerformanceTiming.xml' path='doc/member[@name="IHTMLPerformanceTiming.toJSON"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT toJSON(VARIANT* pVar)
    {
        return ((delegate* unmanaged<IHTMLPerformanceTiming*, VARIANT*, int> )(lpVtbl[29]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), pVar);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_navigationStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(8)]
        HRESULT get_unloadEventStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(9)]
        HRESULT get_unloadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(10)]
        HRESULT get_redirectStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(11)]
        HRESULT get_redirectEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(12)]
        HRESULT get_fetchStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(13)]
        HRESULT get_domainLookupStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(14)]
        HRESULT get_domainLookupEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(15)]
        HRESULT get_connectStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(16)]
        HRESULT get_connectEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(17)]
        HRESULT get_requestStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(18)]
        HRESULT get_responseStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(19)]
        HRESULT get_responseEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(20)]
        HRESULT get_domLoading([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(21)]
        HRESULT get_domInteractive([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(22)]
        HRESULT get_domContentLoadedEventStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(23)]
        HRESULT get_domContentLoadedEventEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(24)]
        HRESULT get_domComplete([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(25)]
        HRESULT get_loadEventStart([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(26)]
        HRESULT get_loadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(27)]
        HRESULT get_msFirstPaint([NativeTypeName("ULONGLONG *")] ulong* p);
        [VtblIndex(28)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** @string);
        [VtblIndex(29)]
        HRESULT toJSON(VARIANT* pVar);
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
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_navigationStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_unloadEventStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_unloadEventEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_redirectStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_redirectEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_fetchStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domainLookupStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domainLookupEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_connectStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_connectEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_requestStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_responseStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_responseEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domLoading;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domInteractive;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domContentLoadedEventStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domContentLoadedEventEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_domComplete;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_loadEventStart;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_loadEventEnd;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_msFirstPaint;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> toJSON;
    }
}