// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IClassFactory2.xml' path='doc/member[@name="IClassFactory2"]/*'/>
[Guid("B196B28F-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IClassFactory2 : IClassFactory")]
[NativeInheritance("IClassFactory")]
public unsafe partial struct IClassFactory2 : IClassFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClassFactory2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClassFactory2*, Guid*, void**, int> )(lpVtbl[0]))((IClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IClassFactory2*, uint> )(lpVtbl[1]))((IClassFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClassFactory2*, uint> )(lpVtbl[2]))((IClassFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IClassFactory.CreateInstance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClassFactory2*, IUnknown*, Guid*, void**, int> )(lpVtbl[3]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
    }

    /// <inheritdoc cref = "IClassFactory.LockServer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockServer(BOOL fLock)
    {
        return ((delegate* unmanaged<IClassFactory2*, BOOL, int> )(lpVtbl[4]))((IClassFactory2*)Unsafe.AsPointer(ref this), fLock);
    }

    /// <include file='IClassFactory2.xml' path='doc/member[@name="IClassFactory2.GetLicInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLicInfo(LICINFO* pLicInfo)
    {
        return ((delegate* unmanaged<IClassFactory2*, LICINFO*, int> )(lpVtbl[5]))((IClassFactory2*)Unsafe.AsPointer(ref this), pLicInfo);
    }

    /// <include file='IClassFactory2.xml' path='doc/member[@name="IClassFactory2.RequestLicKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey)
    {
        return ((delegate* unmanaged<IClassFactory2*, uint, ushort**, int> )(lpVtbl[6]))((IClassFactory2*)Unsafe.AsPointer(ref this), dwReserved, pBstrKey);
    }

    /// <include file='IClassFactory2.xml' path='doc/member[@name="IClassFactory2.CreateInstanceLic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateInstanceLic(IUnknown* pUnkOuter, IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj)
    {
        return ((delegate* unmanaged<IClassFactory2*, IUnknown*, IUnknown*, Guid*, ushort*, void**, int> )(lpVtbl[7]))((IClassFactory2*)Unsafe.AsPointer(ref this), pUnkOuter, pUnkReserved, riid, bstrKey, ppvObj);
    }

    public interface Interface : IClassFactory.Interface
    {
        [VtblIndex(5)]
        HRESULT GetLicInfo(LICINFO* pLicInfo);
        [VtblIndex(6)]
        HRESULT RequestLicKey([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("BSTR *")] ushort** pBstrKey);
        [VtblIndex(7)]
        HRESULT CreateInstanceLic(IUnknown* pUnkOuter, IUnknown* pUnkReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("PVOID *")] void** ppvObj);
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
        [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, Guid*, void**, int> CreateInstance;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> LockServer;
        [NativeTypeName("HRESULT (LICINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LICINFO*, int> GetLicInfo;
        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> RequestLicKey;
        [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const IID &, BSTR, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown*, Guid*, ushort*, void**, int> CreateInstanceLic;
    }
}