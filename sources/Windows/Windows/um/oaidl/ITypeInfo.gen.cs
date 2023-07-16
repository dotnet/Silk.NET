// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo"]/*'/>
[Guid("00020401-0000-0000-C000-000000000046")]
[NativeTypeName("struct ITypeInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeInfo : ITypeInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeInfo*, Guid*, void**, int> )(lpVtbl[0]))((ITypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITypeInfo*, uint> )(lpVtbl[1]))((ITypeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeInfo*, uint> )(lpVtbl[2]))((ITypeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetTypeAttr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeAttr(TYPEATTR** ppTypeAttr)
    {
        return ((delegate* unmanaged<ITypeInfo*, TYPEATTR**, int> )(lpVtbl[3]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTypeAttr);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetTypeComp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeComp(ITypeComp** ppTComp)
    {
        return ((delegate* unmanaged<ITypeInfo*, ITypeComp**, int> )(lpVtbl[4]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTComp);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetFuncDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFuncDesc(uint index, FUNCDESC** ppFuncDesc)
    {
        return ((delegate* unmanaged<ITypeInfo*, uint, FUNCDESC**, int> )(lpVtbl[5]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetVarDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetVarDesc(uint index, VARDESC** ppVarDesc)
    {
        return ((delegate* unmanaged<ITypeInfo*, uint, VARDESC**, int> )(lpVtbl[6]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppVarDesc);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, uint cMaxNames, uint* pcNames)
    {
        return ((delegate* unmanaged<ITypeInfo*, int, ushort**, uint, uint*, int> )(lpVtbl[7]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetRefTypeOfImplType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRefTypeOfImplType(uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
    {
        return ((delegate* unmanaged<ITypeInfo*, uint, uint*, int> )(lpVtbl[8]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, pRefType);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetImplTypeFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetImplTypeFlags(uint index, int* pImplTypeFlags)
    {
        return ((delegate* unmanaged<ITypeInfo*, uint, int*, int> )(lpVtbl[9]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetIDsOfNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
    {
        return ((delegate* unmanaged<ITypeInfo*, ushort**, uint, int*, int> )(lpVtbl[10]))((ITypeInfo*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.Invoke"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ITypeInfo*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[11]))((ITypeInfo*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetDocumentation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
    {
        return ((delegate* unmanaged<ITypeInfo*, int, ushort**, ushort**, uint*, ushort**, int> )(lpVtbl[12]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetDllEntry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
    {
        return ((delegate* unmanaged<ITypeInfo*, int, INVOKEKIND, ushort**, ushort**, ushort*, int> )(lpVtbl[13]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetRefTypeInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ITypeInfo*, uint, ITypeInfo**, int> )(lpVtbl[14]))((ITypeInfo*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.AddressOfMember"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<ITypeInfo*, int, INVOKEKIND, void**, int> )(lpVtbl[15]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
    {
        return ((delegate* unmanaged<ITypeInfo*, IUnknown*, Guid*, void**, int> )(lpVtbl[16]))((ITypeInfo*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetMops"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
    {
        return ((delegate* unmanaged<ITypeInfo*, int, ushort**, int> )(lpVtbl[17]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrMops);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.GetContainingTypeLib"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetContainingTypeLib(ITypeLib** ppTLib, uint* pIndex)
    {
        return ((delegate* unmanaged<ITypeInfo*, ITypeLib**, uint*, int> )(lpVtbl[18]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.ReleaseTypeAttr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void ReleaseTypeAttr(TYPEATTR* pTypeAttr)
    {
        ((delegate* unmanaged<ITypeInfo*, TYPEATTR*, void> )(lpVtbl[19]))((ITypeInfo*)Unsafe.AsPointer(ref this), pTypeAttr);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.ReleaseFuncDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void ReleaseFuncDesc(FUNCDESC* pFuncDesc)
    {
        ((delegate* unmanaged<ITypeInfo*, FUNCDESC*, void> )(lpVtbl[20]))((ITypeInfo*)Unsafe.AsPointer(ref this), pFuncDesc);
    }

    /// <include file='ITypeInfo.xml' path='doc/member[@name="ITypeInfo.ReleaseVarDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void ReleaseVarDesc(VARDESC* pVarDesc)
    {
        ((delegate* unmanaged<ITypeInfo*, VARDESC*, void> )(lpVtbl[21]))((ITypeInfo*)Unsafe.AsPointer(ref this), pVarDesc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTypeAttr(TYPEATTR** ppTypeAttr);
        [VtblIndex(4)]
        HRESULT GetTypeComp(ITypeComp** ppTComp);
        [VtblIndex(5)]
        HRESULT GetFuncDesc(uint index, FUNCDESC** ppFuncDesc);
        [VtblIndex(6)]
        HRESULT GetVarDesc(uint index, VARDESC** ppVarDesc);
        [VtblIndex(7)]
        HRESULT GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, uint cMaxNames, uint* pcNames);
        [VtblIndex(8)]
        HRESULT GetRefTypeOfImplType(uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType);
        [VtblIndex(9)]
        HRESULT GetImplTypeFlags(uint index, int* pImplTypeFlags);
        [VtblIndex(10)]
        HRESULT GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId);
        [VtblIndex(11)]
        HRESULT Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr);
        [VtblIndex(12)]
        HRESULT GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);
        [VtblIndex(13)]
        HRESULT GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal);
        [VtblIndex(14)]
        HRESULT GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, ITypeInfo** ppTInfo);
        [VtblIndex(15)]
        HRESULT AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv);
        [VtblIndex(16)]
        HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj);
        [VtblIndex(17)]
        HRESULT GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops);
        [VtblIndex(18)]
        HRESULT GetContainingTypeLib(ITypeLib** ppTLib, uint* pIndex);
        [VtblIndex(19)]
        void ReleaseTypeAttr(TYPEATTR* pTypeAttr);
        [VtblIndex(20)]
        void ReleaseFuncDesc(FUNCDESC* pFuncDesc);
        [VtblIndex(21)]
        void ReleaseVarDesc(VARDESC* pVarDesc);
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
        [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TYPEATTR**, int> GetTypeAttr;
        [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeComp**, int> GetTypeComp;
        [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, FUNCDESC**, int> GetFuncDesc;
        [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, VARDESC**, int> GetVarDesc;
        [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, uint, uint*, int> GetNames;
        [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetRefTypeOfImplType;
        [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> GetImplTypeFlags;
        [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;
        [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, INVOKEKIND, ushort**, ushort**, ushort*, int> GetDllEntry;
        [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITypeInfo**, int> GetRefTypeInfo;
        [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, INVOKEKIND, void**, int> AddressOfMember;
        [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, Guid*, void**, int> CreateInstance;
        [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetMops;
        [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeLib**, uint*, int> GetContainingTypeLib;
        [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TYPEATTR*, void> ReleaseTypeAttr;
        [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FUNCDESC*, void> ReleaseFuncDesc;
        [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARDESC*, void> ReleaseVarDesc;
    }
}