// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink"]/*'/>
[Guid("F6696E82-74F7-4F3D-A178-8A5E09C3659F")]
[NativeTypeName("struct IMFClockStateSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFClockStateSink : IMFClockStateSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFClockStateSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, Guid*, void**, int> )(lpVtbl[0]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFClockStateSink*, uint> )(lpVtbl[1]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFClockStateSink*, uint> )(lpVtbl[2]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink.OnClockStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, long, long, int> )(lpVtbl[3]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
    }

    /// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink.OnClockStop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, long, int> )(lpVtbl[4]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink.OnClockPause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, long, int> )(lpVtbl[5]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink.OnClockRestart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, long, int> )(lpVtbl[6]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <include file='IMFClockStateSink.xml' path='doc/member[@name="IMFClockStateSink.OnClockSetRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
    {
        return ((delegate* unmanaged<IMFClockStateSink*, long, float, int> )(lpVtbl[7]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset);
        [VtblIndex(4)]
        HRESULT OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime);
        [VtblIndex(5)]
        HRESULT OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime);
        [VtblIndex(6)]
        HRESULT OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime);
        [VtblIndex(7)]
        HRESULT OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate);
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
        [NativeTypeName("HRESULT (MFTIME, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, long, int> OnClockStart;
        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockStop;
        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockPause;
        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockRestart;
        [NativeTypeName("HRESULT (MFTIME, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, float, int> OnClockSetRate;
    }
}