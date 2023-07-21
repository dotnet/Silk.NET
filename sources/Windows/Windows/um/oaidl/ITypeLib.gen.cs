// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib"]/*' />
[Guid("00020402-0000-0000-C000-000000000046")]
[NativeTypeName("struct ITypeLib : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeLib : ITypeLib.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeLib));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeLib*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[1]))((ITypeLib*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[2]))((ITypeLib*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetTypeInfoCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetTypeInfoCount()
    {
        return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[3]))((ITypeLib*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetTypeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint index, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ITypeLib*, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITypeLib*)Unsafe.AsPointer(ref this), index, ppTInfo);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetTypeInfoType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTypeInfoType(uint index, TYPEKIND* pTKind)
    {
        return ((delegate* unmanaged<ITypeLib*, uint, TYPEKIND*, int>)(lpVtbl[5]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pTKind);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetTypeInfoOfGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, ITypeInfo** ppTinfo)
    {
        return ((delegate* unmanaged<ITypeLib*, Guid*, ITypeInfo**, int>)(lpVtbl[6]))((ITypeLib*)Unsafe.AsPointer(ref this), guid, ppTinfo);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetLibAttr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLibAttr(TLIBATTR** ppTLibAttr)
    {
        return ((delegate* unmanaged<ITypeLib*, TLIBATTR**, int>)(lpVtbl[7]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTLibAttr);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetTypeComp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTypeComp(ITypeComp** ppTComp)
    {
        return ((delegate* unmanaged<ITypeLib*, ITypeComp**, int>)(lpVtbl[8]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTComp);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.GetDocumentation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDocumentation(int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
    {
        return ((delegate* unmanaged<ITypeLib*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[9]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.IsName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, BOOL* pfName)
    {
        return ((delegate* unmanaged<ITypeLib*, ushort*, uint, BOOL*, int>)(lpVtbl[10]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.FindName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, ushort* pcFound)
    {
        return ((delegate* unmanaged<ITypeLib*, ushort*, uint, ITypeInfo**, int*, ushort*, int>)(lpVtbl[11]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
    }

    /// <include file='ITypeLib.xml' path='doc/member[@name="ITypeLib.ReleaseTLibAttr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseTLibAttr(TLIBATTR* pTLibAttr)
    {
        ((delegate* unmanaged<ITypeLib*, TLIBATTR*, void>)(lpVtbl[12]))((ITypeLib*)Unsafe.AsPointer(ref this), pTLibAttr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint GetTypeInfoCount();

        [VtblIndex(4)]
        HRESULT GetTypeInfo(uint index, ITypeInfo** ppTInfo);

        [VtblIndex(5)]
        HRESULT GetTypeInfoType(uint index, TYPEKIND* pTKind);

        [VtblIndex(6)]
        HRESULT GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, ITypeInfo** ppTinfo);

        [VtblIndex(7)]
        HRESULT GetLibAttr(TLIBATTR** ppTLibAttr);

        [VtblIndex(8)]
        HRESULT GetTypeComp(ITypeComp** ppTComp);

        [VtblIndex(9)]
        HRESULT GetDocumentation(int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [VtblIndex(10)]
        HRESULT IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, BOOL* pfName);

        [VtblIndex(11)]
        HRESULT FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, ushort* pcFound);

        [VtblIndex(12)]
        void ReleaseTLibAttr(TLIBATTR* pTLibAttr);
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (UINT, TYPEKIND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TYPEKIND*, int> GetTypeInfoType;

        [NativeTypeName("HRESULT (const GUID &, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITypeInfo**, int> GetTypeInfoOfGuid;

        [NativeTypeName("HRESULT (TLIBATTR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TLIBATTR**, int> GetLibAttr;

        [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeComp**, int> GetTypeComp;

        [NativeTypeName("HRESULT (INT, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

        [NativeTypeName("HRESULT (LPOLESTR, ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL*, int> IsName;

        [NativeTypeName("HRESULT (LPOLESTR, ULONG, ITypeInfo **, MEMBERID *, USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ITypeInfo**, int*, ushort*, int> FindName;

        [NativeTypeName("void (TLIBATTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TLIBATTR*, void> ReleaseTLibAttr;
    }
}
