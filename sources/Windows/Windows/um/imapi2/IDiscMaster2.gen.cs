// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDiscMaster2.xml' path='doc/member[@name="IDiscMaster2"]/*'/>
[Guid("27354130-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscMaster2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDiscMaster2 : IDiscMaster2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscMaster2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscMaster2*, Guid*, void**, int> )(lpVtbl[0]))((IDiscMaster2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscMaster2*, uint> )(lpVtbl[1]))((IDiscMaster2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscMaster2*, uint> )(lpVtbl[2]))((IDiscMaster2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscMaster2*, uint*, int> )(lpVtbl[3]))((IDiscMaster2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDiscMaster2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IDiscMaster2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDiscMaster2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDiscMaster2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDiscMaster2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDiscMaster2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDiscMaster2.xml' path='doc/member[@name="IDiscMaster2.get__NewEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get__NewEnum(IEnumVARIANT** ppunk)
    {
        return ((delegate* unmanaged<IDiscMaster2*, IEnumVARIANT**, int> )(lpVtbl[7]))((IDiscMaster2*)Unsafe.AsPointer(ref this), ppunk);
    }

    /// <include file='IDiscMaster2.xml' path='doc/member[@name="IDiscMaster2.get_Item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Item([NativeTypeName("LONG")] int index, [NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscMaster2*, int, ushort**, int> )(lpVtbl[8]))((IDiscMaster2*)Unsafe.AsPointer(ref this), index, value);
    }

    /// <include file='IDiscMaster2.xml' path='doc/member[@name="IDiscMaster2.get_Count"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscMaster2*, int*, int> )(lpVtbl[9]))((IDiscMaster2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscMaster2.xml' path='doc/member[@name="IDiscMaster2.get_IsSupportedEnvironment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsSupportedEnvironment([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscMaster2*, short*, int> )(lpVtbl[10]))((IDiscMaster2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get__NewEnum(IEnumVARIANT** ppunk);
        [VtblIndex(8)]
        HRESULT get_Item([NativeTypeName("LONG")] int index, [NativeTypeName("BSTR *")] ushort** value);
        [VtblIndex(9)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* value);
        [VtblIndex(10)]
        HRESULT get_IsSupportedEnvironment([NativeTypeName("VARIANT_BOOL *")] short* value);
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
        [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumVARIANT**, int> get__NewEnum;
        [NativeTypeName("HRESULT (LONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> get_Item;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsSupportedEnvironment;
    }
}