// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise"]/*'/>
[Guid("EC15E2E9-E36B-4F7C-8758-77D452EF4CE7")]
[NativeTypeName("struct IMFQualityAdvise : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFQualityAdvise : IMFQualityAdvise.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFQualityAdvise));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, Guid*, void**, int> )(lpVtbl[0]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, uint> )(lpVtbl[1]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, uint> )(lpVtbl[2]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise.SetDropMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_DROP_MODE, int> )(lpVtbl[3]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eDropMode);
    }

    /// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise.SetQualityLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_LEVEL, int> )(lpVtbl[4]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eQualityLevel);
    }

    /// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise.GetDropMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDropMode(MF_QUALITY_DROP_MODE* peDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_DROP_MODE*, int> )(lpVtbl[5]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peDropMode);
    }

    /// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise.GetQualityLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_LEVEL*, int> )(lpVtbl[6]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peQualityLevel);
    }

    /// <include file='IMFQualityAdvise.xml' path='doc/member[@name="IMFQualityAdvise.DropTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
    {
        return ((delegate* unmanaged<IMFQualityAdvise*, long, int> )(lpVtbl[7]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), hnsAmountToDrop);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode);
        [VtblIndex(4)]
        HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel);
        [VtblIndex(5)]
        HRESULT GetDropMode(MF_QUALITY_DROP_MODE* peDropMode);
        [VtblIndex(6)]
        HRESULT GetQualityLevel(MF_QUALITY_LEVEL* peQualityLevel);
        [VtblIndex(7)]
        HRESULT DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop);
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
        [NativeTypeName("HRESULT (MF_QUALITY_DROP_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_DROP_MODE, int> SetDropMode;
        [NativeTypeName("HRESULT (MF_QUALITY_LEVEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_LEVEL, int> SetQualityLevel;
        [NativeTypeName("HRESULT (MF_QUALITY_DROP_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_DROP_MODE*, int> GetDropMode;
        [NativeTypeName("HRESULT (MF_QUALITY_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_LEVEL*, int> GetQualityLevel;
        [NativeTypeName("HRESULT (LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> DropTime;
    }
}