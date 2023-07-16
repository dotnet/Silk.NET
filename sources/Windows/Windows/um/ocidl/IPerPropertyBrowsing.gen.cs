// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPerPropertyBrowsing.xml' path='doc/member[@name="IPerPropertyBrowsing"]/*'/>
[Guid("376BD3AA-3845-101B-84ED-08002B2EC713")]
[NativeTypeName("struct IPerPropertyBrowsing : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPerPropertyBrowsing : IPerPropertyBrowsing.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPerPropertyBrowsing));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, Guid*, void**, int> )(lpVtbl[0]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, uint> )(lpVtbl[1]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, uint> )(lpVtbl[2]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPerPropertyBrowsing.xml' path='doc/member[@name="IPerPropertyBrowsing.GetDisplayString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayString([NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, int, ushort**, int> )(lpVtbl[3]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pBstr);
    }

    /// <include file='IPerPropertyBrowsing.xml' path='doc/member[@name="IPerPropertyBrowsing.MapPropertyToPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MapPropertyToPage([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, int, Guid*, int> )(lpVtbl[4]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pClsid);
    }

    /// <include file='IPerPropertyBrowsing.xml' path='doc/member[@name="IPerPropertyBrowsing.GetPredefinedStrings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPredefinedStrings([NativeTypeName("DISPID")] int dispID, CALPOLESTR* pCaStringsOut, CADWORD* pCaCookiesOut)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int> )(lpVtbl[5]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pCaStringsOut, pCaCookiesOut);
    }

    /// <include file='IPerPropertyBrowsing.xml' path='doc/member[@name="IPerPropertyBrowsing.GetPredefinedValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPredefinedValue([NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, VARIANT* pVarOut)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing*, int, uint, VARIANT*, int> )(lpVtbl[6]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, dwCookie, pVarOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDisplayString([NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr);
        [VtblIndex(4)]
        HRESULT MapPropertyToPage([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid);
        [VtblIndex(5)]
        HRESULT GetPredefinedStrings([NativeTypeName("DISPID")] int dispID, CALPOLESTR* pCaStringsOut, CADWORD* pCaCookiesOut);
        [VtblIndex(6)]
        HRESULT GetPredefinedValue([NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, VARIANT* pVarOut);
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
        [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetDisplayString;
        [NativeTypeName("HRESULT (DISPID, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, int> MapPropertyToPage;
        [NativeTypeName("HRESULT (DISPID, CALPOLESTR *, CADWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, CALPOLESTR*, CADWORD*, int> GetPredefinedStrings;
        [NativeTypeName("HRESULT (DISPID, DWORD, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, VARIANT*, int> GetPredefinedValue;
    }
}