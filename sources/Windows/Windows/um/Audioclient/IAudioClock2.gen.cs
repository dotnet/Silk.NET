// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioClock2.xml' path='doc/member[@name="IAudioClock2"]/*'/>
[Guid("6F49FF73-6727-49AC-A008-D98CF5E70048")]
[NativeTypeName("struct IAudioClock2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioClock2 : IAudioClock2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClock2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClock2*, Guid*, void**, int> )(lpVtbl[0]))((IAudioClock2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioClock2*, uint> )(lpVtbl[1]))((IAudioClock2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClock2*, uint> )(lpVtbl[2]))((IAudioClock2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioClock2.xml' path='doc/member[@name="IAudioClock2.GetDevicePosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevicePosition([NativeTypeName("UINT64 *")] ulong* DevicePosition, [NativeTypeName("UINT64 *")] ulong* QPCPosition)
    {
        return ((delegate* unmanaged<IAudioClock2*, ulong*, ulong*, int> )(lpVtbl[3]))((IAudioClock2*)Unsafe.AsPointer(ref this), DevicePosition, QPCPosition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevicePosition([NativeTypeName("UINT64 *")] ulong* DevicePosition, [NativeTypeName("UINT64 *")] ulong* QPCPosition);
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
        [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, int> GetDevicePosition;
    }
}