// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFQualityAdvise2.xml' path='doc/member[@name="IMFQualityAdvise2"]/*'/>
[Guid("F3706F0D-8EA2-4886-8000-7155E9EC2EAE")]
[NativeTypeName("struct IMFQualityAdvise2 : IMFQualityAdvise")]
[NativeInheritance("IMFQualityAdvise")]
public unsafe partial struct IMFQualityAdvise2 : IMFQualityAdvise2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFQualityAdvise2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, Guid*, void**, int> )(lpVtbl[0]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, uint> )(lpVtbl[1]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, uint> )(lpVtbl[2]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFQualityAdvise.SetDropMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, MF_QUALITY_DROP_MODE, int> )(lpVtbl[3]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), eDropMode);
    }

    /// <inheritdoc cref = "IMFQualityAdvise.SetQualityLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, MF_QUALITY_LEVEL, int> )(lpVtbl[4]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), eQualityLevel);
    }

    /// <inheritdoc cref = "IMFQualityAdvise.GetDropMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDropMode(MF_QUALITY_DROP_MODE* peDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, MF_QUALITY_DROP_MODE*, int> )(lpVtbl[5]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), peDropMode);
    }

    /// <inheritdoc cref = "IMFQualityAdvise.GetQualityLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, MF_QUALITY_LEVEL*, int> )(lpVtbl[6]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), peQualityLevel);
    }

    /// <inheritdoc cref = "IMFQualityAdvise.DropTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, long, int> )(lpVtbl[7]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), hnsAmountToDrop);
    }

    /// <include file='IMFQualityAdvise2.xml' path='doc/member[@name="IMFQualityAdvise2.NotifyQualityEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT NotifyQualityEvent(IMFMediaEvent* pEvent, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2*, IMFMediaEvent*, uint*, int> )(lpVtbl[8]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), pEvent, pdwFlags);
    }

    public interface Interface : IMFQualityAdvise.Interface
    {
        [VtblIndex(8)]
        HRESULT NotifyQualityEvent(IMFMediaEvent* pEvent, [NativeTypeName("DWORD *")] uint* pdwFlags);
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
        [NativeTypeName("HRESULT (IMFMediaEvent *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEvent*, uint*, int> NotifyQualityEvent;
    }
}