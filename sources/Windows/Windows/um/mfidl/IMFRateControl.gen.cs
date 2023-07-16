// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFRateControl.xml' path='doc/member[@name="IMFRateControl"]/*'/>
[Guid("88DDCD21-03C3-4275-91ED-55EE3929328F")]
[NativeTypeName("struct IMFRateControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRateControl : IMFRateControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRateControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRateControl*, Guid*, void**, int> )(lpVtbl[0]))((IMFRateControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRateControl*, uint> )(lpVtbl[1]))((IMFRateControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRateControl*, uint> )(lpVtbl[2]))((IMFRateControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRateControl.xml' path='doc/member[@name="IMFRateControl.SetRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRate(BOOL fThin, float flRate)
    {
        return ((delegate* unmanaged<IMFRateControl*, BOOL, float, int> )(lpVtbl[3]))((IMFRateControl*)Unsafe.AsPointer(ref this), fThin, flRate);
    }

    /// <include file='IMFRateControl.xml' path='doc/member[@name="IMFRateControl.GetRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRate(BOOL* pfThin, float* pflRate)
    {
        return ((delegate* unmanaged<IMFRateControl*, BOOL*, float*, int> )(lpVtbl[4]))((IMFRateControl*)Unsafe.AsPointer(ref this), pfThin, pflRate);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRate(BOOL fThin, float flRate);
        [VtblIndex(4)]
        HRESULT GetRate(BOOL* pfThin, float* pflRate);
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
        [NativeTypeName("HRESULT (BOOL, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, float, int> SetRate;
        [NativeTypeName("HRESULT (BOOL *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, float*, int> GetRate;
    }
}