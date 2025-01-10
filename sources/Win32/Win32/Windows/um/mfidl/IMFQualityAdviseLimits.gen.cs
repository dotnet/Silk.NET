// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DFCD8E4D-30B5-4567-ACAA-8EB5B7853DC9")]
[NativeTypeName("struct IMFQualityAdviseLimits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFQualityAdviseLimits : IMFQualityAdviseLimits.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFQualityAdviseLimits));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFQualityAdviseLimits, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMaximumDropMode(MF_QUALITY_DROP_MODE* peDropMode)
    {
        return (
            (delegate* unmanaged<IMFQualityAdviseLimits, MF_QUALITY_DROP_MODE*, int>)((*lpVtbl)[3])
        )(this, peDropMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMinimumQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
    {
        return (
            (delegate* unmanaged<IMFQualityAdviseLimits, MF_QUALITY_LEVEL*, int>)((*lpVtbl)[4])
        )(this, peQualityLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMaximumDropMode(MF_QUALITY_DROP_MODE* peDropMode);

        [VtblIndex(4)]
        HRESULT GetMinimumQualityLevel(MF_QUALITY_LEVEL* peQualityLevel);
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

        [NativeTypeName("HRESULT (MF_QUALITY_DROP_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_DROP_MODE*, int> GetMaximumDropMode;

        [NativeTypeName("HRESULT (MF_QUALITY_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_LEVEL*, int> GetMinimumQualityLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFQualityAdviseLimits"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFQualityAdviseLimits(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFQualityAdviseLimits"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFQualityAdviseLimits(Silk.NET.Windows.IUnknown value)
    {
        return new IMFQualityAdviseLimits(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFQualityAdviseLimits"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFQualityAdviseLimits"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFQualityAdviseLimits value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
