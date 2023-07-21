// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfDisplayAttributeMgr.xml' path='doc/member[@name="ITfDisplayAttributeMgr"]/*' />
[Guid("8DED7393-5DB1-475C-9E71-A39111B0FF67")]
[NativeTypeName("struct ITfDisplayAttributeMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDisplayAttributeMgr : ITfDisplayAttributeMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDisplayAttributeMgr));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, uint>)(lpVtbl[1]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, uint>)(lpVtbl[2]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfDisplayAttributeMgr.xml' path='doc/member[@name="ITfDisplayAttributeMgr.OnUpdateInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnUpdateInfo()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, int>)(lpVtbl[3]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfDisplayAttributeMgr.xml' path='doc/member[@name="ITfDisplayAttributeMgr.EnumDisplayAttributeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo** ppEnum)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[4]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='ITfDisplayAttributeMgr.xml' path='doc/member[@name="ITfDisplayAttributeMgr.GetDisplayAttributeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayAttributeInfo([NativeTypeName("const GUID &")] Guid* guid, ITfDisplayAttributeInfo** ppInfo, [NativeTypeName("CLSID *")] Guid* pclsidOwner)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeMgr*, Guid*, ITfDisplayAttributeInfo**, Guid*, int>)(lpVtbl[5]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), guid, ppInfo, pclsidOwner);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnUpdateInfo();

        [VtblIndex(4)]
        HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo** ppEnum);

        [VtblIndex(5)]
        HRESULT GetDisplayAttributeInfo([NativeTypeName("const GUID &")] Guid* guid, ITfDisplayAttributeInfo** ppInfo, [NativeTypeName("CLSID *")] Guid* pclsidOwner);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnUpdateInfo;

        [NativeTypeName("HRESULT (IEnumTfDisplayAttributeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfDisplayAttributeInfo**, int> EnumDisplayAttributeInfo;

        [NativeTypeName("HRESULT (const GUID &, ITfDisplayAttributeInfo **, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfDisplayAttributeInfo**, Guid*, int> GetDisplayAttributeInfo;
    }
}
