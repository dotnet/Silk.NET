// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpatialAudioObjectRenderStreamNotify.xml' path='doc/member[@name="ISpatialAudioObjectRenderStreamNotify"]/*'/>
[Guid("DDDF83E6-68D7-4C70-883F-A1836AFB4A50")]
[NativeTypeName("struct ISpatialAudioObjectRenderStreamNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpatialAudioObjectRenderStreamNotify : ISpatialAudioObjectRenderStreamNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStreamNotify));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, uint> )(lpVtbl[1]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, uint> )(lpVtbl[2]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioObjectRenderStreamNotify.xml' path='doc/member[@name="ISpatialAudioObjectRenderStreamNotify.OnAvailableDynamicObjectCountChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnAvailableDynamicObjectCountChange(ISpatialAudioObjectRenderStreamBase* sender, [NativeTypeName("LONGLONG")] long hnsComplianceDeadlineTime, [NativeTypeName("UINT32")] uint availableDynamicObjectCountChange)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, ISpatialAudioObjectRenderStreamBase*, long, uint, int> )(lpVtbl[3]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this), sender, hnsComplianceDeadlineTime, availableDynamicObjectCountChange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnAvailableDynamicObjectCountChange(ISpatialAudioObjectRenderStreamBase* sender, [NativeTypeName("LONGLONG")] long hnsComplianceDeadlineTime, [NativeTypeName("UINT32")] uint availableDynamicObjectCountChange);
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
        [NativeTypeName("HRESULT (ISpatialAudioObjectRenderStreamBase *, LONGLONG, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioObjectRenderStreamBase*, long, uint, int> OnAvailableDynamicObjectCountChange;
    }
}