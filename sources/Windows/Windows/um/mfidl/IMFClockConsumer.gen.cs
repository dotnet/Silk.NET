// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFClockConsumer.xml' path='doc/member[@name="IMFClockConsumer"]/*'/>
[Guid("6EF2A662-47C0-4666-B13D-CBB717F2FA2C")]
[NativeTypeName("struct IMFClockConsumer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFClockConsumer : IMFClockConsumer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFClockConsumer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFClockConsumer*, Guid*, void**, int> )(lpVtbl[0]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFClockConsumer*, uint> )(lpVtbl[1]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFClockConsumer*, uint> )(lpVtbl[2]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFClockConsumer.xml' path='doc/member[@name="IMFClockConsumer.SetPresentationClock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock)
    {
        return ((delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock*, int> )(lpVtbl[3]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), pPresentationClock);
    }

    /// <include file='IMFClockConsumer.xml' path='doc/member[@name="IMFClockConsumer.GetPresentationClock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock)
    {
        return ((delegate* unmanaged<IMFClockConsumer*, IMFPresentationClock**, int> )(lpVtbl[4]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), ppPresentationClock);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock);
        [VtblIndex(4)]
        HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock);
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
        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock*, int> SetPresentationClock;
        [NativeTypeName("HRESULT (IMFPresentationClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock**, int> GetPresentationClock;
    }
}