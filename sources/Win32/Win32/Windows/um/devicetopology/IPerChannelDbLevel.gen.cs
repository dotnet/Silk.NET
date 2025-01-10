// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C2F8E001-F205-4BC9-99BC-C13B1E048CCB")]
[NativeTypeName("struct IPerChannelDbLevel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPerChannelDbLevel : IPerChannelDbLevel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPerChannelDbLevel));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPerChannelDbLevel, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount(uint* pcChannels)
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcChannels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLevelRange(
        uint nChannel,
        float* pfMinLevelDB,
        float* pfMaxLevelDB,
        float* pfStepping
    )
    {
        return (
            (delegate* unmanaged<IPerChannelDbLevel, uint, float*, float*, float*, int>)(
                (*lpVtbl)[4]
            )
        )(this, nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, uint, float*, int>)((*lpVtbl)[5]))(
            this,
            nChannel,
            pfLevelDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetLevel(
        uint nChannel,
        float fLevelDB,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, uint, float, Guid*, int>)((*lpVtbl)[6]))(
            this,
            nChannel,
            fLevelDB,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetLevelUniform(
        float fLevelDB,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, float, Guid*, int>)((*lpVtbl)[7]))(
            this,
            fLevelDB,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetLevelAllChannels(
        [NativeTypeName("float[]")] float* aLevelsDB,
        [NativeTypeName("ULONG")] uint cChannels,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IPerChannelDbLevel, float*, uint, Guid*, int>)((*lpVtbl)[8]))(
            this,
            aLevelsDB,
            cChannels,
            pguidEventContext
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetChannelCount(uint* pcChannels);

        [VtblIndex(4)]
        HRESULT GetLevelRange(
            uint nChannel,
            float* pfMinLevelDB,
            float* pfMaxLevelDB,
            float* pfStepping
        );

        [VtblIndex(5)]
        HRESULT GetLevel(uint nChannel, float* pfLevelDB);

        [VtblIndex(6)]
        HRESULT SetLevel(
            uint nChannel,
            float fLevelDB,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(7)]
        HRESULT SetLevelUniform(
            float fLevelDB,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(8)]
        HRESULT SetLevelAllChannels(
            [NativeTypeName("float[]")] float* aLevelsDB,
            [NativeTypeName("ULONG")] uint cChannels,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (UINT, float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, float*, float*, int> GetLevelRange;

        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetLevel;

        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, Guid*, int> SetLevel;

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Guid*, int> SetLevelUniform;

        [NativeTypeName("HRESULT (float *, ULONG, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, Guid*, int> SetLevelAllChannels;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPerChannelDbLevel"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPerChannelDbLevel(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPerChannelDbLevel"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPerChannelDbLevel(Silk.NET.Windows.IUnknown value)
    {
        return new IPerChannelDbLevel(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPerChannelDbLevel"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPerChannelDbLevel"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPerChannelDbLevel value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
