// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAcousticEchoCancellationControl.xml' path='doc/member[@name="IAcousticEchoCancellationControl"]/*' />
[Guid("F4AE25B5-AAA3-437D-B6B3-DBBE2D0E9549")]
[NativeTypeName("struct IAcousticEchoCancellationControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAcousticEchoCancellationControl : IAcousticEchoCancellationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAcousticEchoCancellationControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAcousticEchoCancellationControl*, Guid*, void**, int>)(lpVtbl[0]))((IAcousticEchoCancellationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAcousticEchoCancellationControl*, uint>)(lpVtbl[1]))((IAcousticEchoCancellationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAcousticEchoCancellationControl*, uint>)(lpVtbl[2]))((IAcousticEchoCancellationControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAcousticEchoCancellationControl.xml' path='doc/member[@name="IAcousticEchoCancellationControl.SetEchoCancellationRenderEndpoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetEchoCancellationRenderEndpoint([NativeTypeName("LPCWSTR")] ushort* endpointId)
    {
        return ((delegate* unmanaged<IAcousticEchoCancellationControl*, ushort*, int>)(lpVtbl[3]))((IAcousticEchoCancellationControl*)Unsafe.AsPointer(ref this), endpointId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetEchoCancellationRenderEndpoint([NativeTypeName("LPCWSTR")] ushort* endpointId);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetEchoCancellationRenderEndpoint;
    }
}
