// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAudioMeterInformation.xml' path='doc/member[@name="IAudioMeterInformation"]/*' />
[Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
[NativeTypeName("struct IAudioMeterInformation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioMeterInformation : IAudioMeterInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioMeterInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, uint>)(lpVtbl[1]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, uint>)(lpVtbl[2]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioMeterInformation.xml' path='doc/member[@name="IAudioMeterInformation.GetPeakValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPeakValue(float* pfPeak)
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, float*, int>)(lpVtbl[3]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pfPeak);
    }

    /// <include file='IAudioMeterInformation.xml' path='doc/member[@name="IAudioMeterInformation.GetMeteringChannelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMeteringChannelCount(uint* pnChannelCount)
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, uint*, int>)(lpVtbl[4]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pnChannelCount);
    }

    /// <include file='IAudioMeterInformation.xml' path='doc/member[@name="IAudioMeterInformation.GetChannelsPeakValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelsPeakValues([NativeTypeName("UINT32")] uint u32ChannelCount, float* afPeakValues)
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, uint, float*, int>)(lpVtbl[5]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), u32ChannelCount, afPeakValues);
    }

    /// <include file='IAudioMeterInformation.xml' path='doc/member[@name="IAudioMeterInformation.QueryHardwareSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
    {
        return ((delegate* unmanaged<IAudioMeterInformation*, uint*, int>)(lpVtbl[6]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPeakValue(float* pfPeak);

        [VtblIndex(4)]
        HRESULT GetMeteringChannelCount(uint* pnChannelCount);

        [VtblIndex(5)]
        HRESULT GetChannelsPeakValues([NativeTypeName("UINT32")] uint u32ChannelCount, float* afPeakValues);

        [VtblIndex(6)]
        HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask);
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

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetPeakValue;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMeteringChannelCount;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetChannelsPeakValues;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> QueryHardwareSupport;
    }
}
