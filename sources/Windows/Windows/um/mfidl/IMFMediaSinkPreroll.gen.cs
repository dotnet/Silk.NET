// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaSinkPreroll.xml' path='doc/member[@name="IMFMediaSinkPreroll"]/*'/>
[Guid("5DFD4B2A-7674-4110-A4E6-8A68FD5F3688")]
[NativeTypeName("struct IMFMediaSinkPreroll : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSinkPreroll : IMFMediaSinkPreroll.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSinkPreroll));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll*, uint> )(lpVtbl[1]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll*, uint> )(lpVtbl[2]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSinkPreroll.xml' path='doc/member[@name="IMFMediaSinkPreroll.NotifyPreroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyPreroll([NativeTypeName("MFTIME")] long hnsUpcomingStartTime)
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll*, long, int> )(lpVtbl[3]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this), hnsUpcomingStartTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT NotifyPreroll([NativeTypeName("MFTIME")] long hnsUpcomingStartTime);
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
        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> NotifyPreroll;
    }
}