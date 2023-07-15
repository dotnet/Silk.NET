// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo"]/*'/>
[Guid("56A868BA-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFilterInfo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IFilterInfo : IFilterInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterInfo*, Guid*, void**, int> )(lpVtbl[0]))((IFilterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFilterInfo*, uint> )(lpVtbl[1]))((IFilterInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterInfo*, uint> )(lpVtbl[2]))((IFilterInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFilterInfo*, uint*, int> )(lpVtbl[3]))((IFilterInfo*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFilterInfo*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFilterInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFilterInfo*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFilterInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFilterInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFilterInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.FindPin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindPin([NativeTypeName("BSTR")] ushort* strPinID, IDispatch** ppUnk)
    {
        return ((delegate* unmanaged<IFilterInfo*, ushort*, IDispatch**, int> )(lpVtbl[7]))((IFilterInfo*)Unsafe.AsPointer(ref this), strPinID, ppUnk);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_Name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** strName)
    {
        return ((delegate* unmanaged<IFilterInfo*, ushort**, int> )(lpVtbl[8]))((IFilterInfo*)Unsafe.AsPointer(ref this), strName);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_VendorInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VendorInfo([NativeTypeName("BSTR *")] ushort** strVendorInfo)
    {
        return ((delegate* unmanaged<IFilterInfo*, ushort**, int> )(lpVtbl[9]))((IFilterInfo*)Unsafe.AsPointer(ref this), strVendorInfo);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_Filter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Filter(IUnknown** ppUnk)
    {
        return ((delegate* unmanaged<IFilterInfo*, IUnknown**, int> )(lpVtbl[10]))((IFilterInfo*)Unsafe.AsPointer(ref this), ppUnk);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_Pins"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Pins(IDispatch** ppUnk)
    {
        return ((delegate* unmanaged<IFilterInfo*, IDispatch**, int> )(lpVtbl[11]))((IFilterInfo*)Unsafe.AsPointer(ref this), ppUnk);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_IsFileSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsFileSource([NativeTypeName("LONG *")] int* pbIsSource)
    {
        return ((delegate* unmanaged<IFilterInfo*, int*, int> )(lpVtbl[12]))((IFilterInfo*)Unsafe.AsPointer(ref this), pbIsSource);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.get_Filename"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Filename([NativeTypeName("BSTR *")] ushort** pstrFilename)
    {
        return ((delegate* unmanaged<IFilterInfo*, ushort**, int> )(lpVtbl[13]))((IFilterInfo*)Unsafe.AsPointer(ref this), pstrFilename);
    }

    /// <include file='IFilterInfo.xml' path='doc/member[@name="IFilterInfo.put_Filename"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Filename([NativeTypeName("BSTR")] ushort* strFilename)
    {
        return ((delegate* unmanaged<IFilterInfo*, ushort*, int> )(lpVtbl[14]))((IFilterInfo*)Unsafe.AsPointer(ref this), strFilename);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT FindPin([NativeTypeName("BSTR")] ushort* strPinID, IDispatch** ppUnk);
        [VtblIndex(8)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** strName);
        [VtblIndex(9)]
        HRESULT get_VendorInfo([NativeTypeName("BSTR *")] ushort** strVendorInfo);
        [VtblIndex(10)]
        HRESULT get_Filter(IUnknown** ppUnk);
        [VtblIndex(11)]
        HRESULT get_Pins(IDispatch** ppUnk);
        [VtblIndex(12)]
        HRESULT get_IsFileSource([NativeTypeName("LONG *")] int* pbIsSource);
        [VtblIndex(13)]
        HRESULT get_Filename([NativeTypeName("BSTR *")] ushort** pstrFilename);
        [VtblIndex(14)]
        HRESULT put_Filename([NativeTypeName("BSTR")] ushort* strFilename);
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
        [NativeTypeName("HRESULT (BSTR, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch**, int> FindPin;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VendorInfo;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get_Filter;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Pins;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_IsFileSource;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Filename;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Filename;
    }
}