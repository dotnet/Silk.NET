// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F3706F0D-8EA2-4886-8000-7155E9EC2EAE")]
[NativeTypeName("struct IMFQualityAdvise2 : IMFQualityAdvise")]
[NativeInheritance("IMFQualityAdvise")]
public unsafe partial struct IMFQualityAdvise2 : IMFQualityAdvise2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFQualityAdvise2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, MF_QUALITY_DROP_MODE, int>)((*lpVtbl)[3]))(
            this,
            eDropMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, MF_QUALITY_LEVEL, int>)((*lpVtbl)[4]))(
            this,
            eQualityLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDropMode(MF_QUALITY_DROP_MODE* peDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, MF_QUALITY_DROP_MODE*, int>)((*lpVtbl)[5]))(
            this,
            peDropMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, MF_QUALITY_LEVEL*, int>)((*lpVtbl)[6]))(
            this,
            peQualityLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, long, int>)((*lpVtbl)[7]))(
            this,
            hnsAmountToDrop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT NotifyQualityEvent(
        IMFMediaEvent pEvent,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    )
    {
        return ((delegate* unmanaged<IMFQualityAdvise2, IMFMediaEvent, uint*, int>)((*lpVtbl)[8]))(
            this,
            pEvent,
            pdwFlags
        );
    }

    public interface Interface : IMFQualityAdvise.Interface
    {
        [VtblIndex(8)]
        HRESULT NotifyQualityEvent(
            IMFMediaEvent pEvent,
            [NativeTypeName("DWORD *")] uint* pdwFlags
        );
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
        public delegate* unmanaged<TSelf*, IMFMediaEvent, uint*, int> NotifyQualityEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFQualityAdvise2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFQualityAdvise2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFQualityAdvise"/> to <see cref = "IMFQualityAdvise2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFQualityAdvise"/> instance to be converted </param>
    public static explicit operator IMFQualityAdvise2(Silk.NET.Windows.IMFQualityAdvise value)
    {
        return new IMFQualityAdvise2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFQualityAdvise2"/> to <see cref = "Silk.NET.Windows.IMFQualityAdvise"/>.</summary>
    /// <param name = "value">The <see cref = "IMFQualityAdvise2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFQualityAdvise(IMFQualityAdvise2 value)
    {
        return new Silk.NET.Windows.IMFQualityAdvise(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFQualityAdvise2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFQualityAdvise2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFQualityAdvise2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFQualityAdvise2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFQualityAdvise2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFQualityAdvise2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
