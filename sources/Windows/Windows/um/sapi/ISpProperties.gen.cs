// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpProperties.xml' path='doc/member[@name="ISpProperties"]/*' />
[Guid("5B4FB971-B115-4DE1-AD97-E482E3BF6EE4")]
[NativeTypeName("struct ISpProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpProperties : ISpProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISpProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpProperties*, uint>)(lpVtbl[1]))((ISpProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpProperties*, uint>)(lpVtbl[2]))((ISpProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpProperties.xml' path='doc/member[@name="ISpProperties.SetPropertyNum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int lValue)
    {
        return ((delegate* unmanaged<ISpProperties*, ushort*, int, int>)(lpVtbl[3]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, lValue);
    }

    /// <include file='ISpProperties.xml' path='doc/member[@name="ISpProperties.GetPropertyNum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG *")] int* plValue)
    {
        return ((delegate* unmanaged<ISpProperties*, ushort*, int*, int>)(lpVtbl[4]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, plValue);
    }

    /// <include file='ISpProperties.xml' path='doc/member[@name="ISpProperties.SetPropertyString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPCWSTR")] ushort* pValue)
    {
        return ((delegate* unmanaged<ISpProperties*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, pValue);
    }

    /// <include file='ISpProperties.xml' path='doc/member[@name="ISpProperties.GetPropertyString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue)
    {
        return ((delegate* unmanaged<ISpProperties*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, ppCoMemValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int lValue);

        [VtblIndex(4)]
        HRESULT GetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG *")] int* plValue);

        [VtblIndex(5)]
        HRESULT SetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPCWSTR")] ushort* pValue);

        [VtblIndex(6)]
        HRESULT GetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue);
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

        [NativeTypeName("HRESULT (LPCWSTR, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> SetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetPropertyString;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetPropertyString;
    }
}
