// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IACList2.xml' path='doc/member[@name="IACList2"]/*' />
[Guid("470141A0-5186-11D2-BBB6-0060977B464C")]
[NativeTypeName("struct IACList2 : IACList")]
[NativeInheritance("IACList")]
public unsafe partial struct IACList2 : IACList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IACList2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IACList2*, Guid*, void**, int>)(lpVtbl[0]))((IACList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IACList2*, uint>)(lpVtbl[1]))((IACList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IACList2*, uint>)(lpVtbl[2]))((IACList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IACList.Expand" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Expand([NativeTypeName("PCWSTR")] ushort* pszExpand)
    {
        return ((delegate* unmanaged<IACList2*, ushort*, int>)(lpVtbl[3]))((IACList2*)Unsafe.AsPointer(ref this), pszExpand);
    }

    /// <include file='IACList2.xml' path='doc/member[@name="IACList2.SetOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag)
    {
        return ((delegate* unmanaged<IACList2*, uint, int>)(lpVtbl[4]))((IACList2*)Unsafe.AsPointer(ref this), dwFlag);
    }

    /// <include file='IACList2.xml' path='doc/member[@name="IACList2.GetOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
    {
        return ((delegate* unmanaged<IACList2*, uint*, int>)(lpVtbl[5]))((IACList2*)Unsafe.AsPointer(ref this), pdwFlag);
    }

    public interface Interface : IACList.Interface
    {
        [VtblIndex(4)]
        HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag);

        [VtblIndex(5)]
        HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag);
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

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Expand;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptions;
    }
}
