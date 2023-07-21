// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer"]/*' />
[Guid("61DED640-E912-11CE-A099-00AA00479A58")]
[NativeTypeName("struct IBaseVideoMixer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBaseVideoMixer : IBaseVideoMixer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBaseVideoMixer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, Guid*, void**, int>)(lpVtbl[0]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, uint>)(lpVtbl[1]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, uint>)(lpVtbl[2]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.SetLeadPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetLeadPin(int iPin)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[3]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), iPin);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.GetLeadPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLeadPin(int* piPin)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[4]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPin);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.GetInputPinCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInputPinCount(int* piPinCount)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[5]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPinCount);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.IsUsingClock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsUsingClock(int* pbValue)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[6]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.SetUsingClock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetUsingClock(int bValue)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[7]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.GetClockPeriod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetClockPeriod(int* pbValue)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int*, int>)(lpVtbl[8]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
    }

    /// <include file='IBaseVideoMixer.xml' path='doc/member[@name="IBaseVideoMixer.SetClockPeriod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetClockPeriod(int bValue)
    {
        return ((delegate* unmanaged<IBaseVideoMixer*, int, int>)(lpVtbl[9]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetLeadPin(int iPin);

        [VtblIndex(4)]
        HRESULT GetLeadPin(int* piPin);

        [VtblIndex(5)]
        HRESULT GetInputPinCount(int* piPinCount);

        [VtblIndex(6)]
        HRESULT IsUsingClock(int* pbValue);

        [VtblIndex(7)]
        HRESULT SetUsingClock(int bValue);

        [VtblIndex(8)]
        HRESULT GetClockPeriod(int* pbValue);

        [VtblIndex(9)]
        HRESULT SetClockPeriod(int bValue);
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

        [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetLeadPin;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetLeadPin;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetInputPinCount;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> IsUsingClock;

        [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetUsingClock;

        [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetClockPeriod;

        [NativeTypeName("HRESULT (int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetClockPeriod;
    }
}
