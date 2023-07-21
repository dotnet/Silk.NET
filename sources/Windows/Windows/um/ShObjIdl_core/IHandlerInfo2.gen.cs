// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHandlerInfo2.xml' path='doc/member[@name="IHandlerInfo2"]/*' />
[Guid("31CCA04C-04D3-4EA9-90DE-97B15E87A532")]
[NativeTypeName("struct IHandlerInfo2 : IHandlerInfo")]
[NativeInheritance("IHandlerInfo")]
public unsafe partial struct IHandlerInfo2 : IHandlerInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHandlerInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHandlerInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IHandlerInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHandlerInfo2*, uint>)(lpVtbl[1]))((IHandlerInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHandlerInfo2*, uint>)(lpVtbl[2]))((IHandlerInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHandlerInfo.GetApplicationDisplayName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetApplicationDisplayName([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo2*, ushort**, int>)(lpVtbl[3]))((IHandlerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IHandlerInfo.GetApplicationPublisher" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetApplicationPublisher([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo2*, ushort**, int>)(lpVtbl[4]))((IHandlerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IHandlerInfo.GetApplicationIconReference" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetApplicationIconReference([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo2*, ushort**, int>)(lpVtbl[5]))((IHandlerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHandlerInfo2.xml' path='doc/member[@name="IHandlerInfo2.GetApplicationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetApplicationId([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IHandlerInfo2*, ushort**, int>)(lpVtbl[6]))((IHandlerInfo2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IHandlerInfo.Interface
    {
        [VtblIndex(6)]
        HRESULT GetApplicationId([NativeTypeName("LPWSTR *")] ushort** value);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationDisplayName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationPublisher;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationIconReference;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetApplicationId;
    }
}
