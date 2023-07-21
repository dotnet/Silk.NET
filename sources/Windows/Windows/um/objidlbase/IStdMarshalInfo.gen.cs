// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IStdMarshalInfo.xml' path='doc/member[@name="IStdMarshalInfo"]/*' />
[Guid("00000018-0000-0000-C000-000000000046")]
[NativeTypeName("struct IStdMarshalInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStdMarshalInfo : IStdMarshalInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStdMarshalInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStdMarshalInfo*, Guid*, void**, int>)(lpVtbl[0]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStdMarshalInfo*, uint>)(lpVtbl[1]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStdMarshalInfo*, uint>)(lpVtbl[2]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStdMarshalInfo.xml' path='doc/member[@name="IStdMarshalInfo.GetClassForHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassForHandler([NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("CLSID *")] Guid* pClsid)
    {
        return ((delegate* unmanaged<IStdMarshalInfo*, uint, void*, Guid*, int>)(lpVtbl[3]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this), dwDestContext, pvDestContext, pClsid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClassForHandler([NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("CLSID *")] Guid* pClsid);
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

        [NativeTypeName("HRESULT (DWORD, void *, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, Guid*, int> GetClassForHandler;
    }
}
