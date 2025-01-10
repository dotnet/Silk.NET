// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A2B1A1D9-4DB3-425D-A2B2-BD335CB3E2E5")]
[NativeTypeName("struct IAudioBass : IPerChannelDbLevel")]
[NativeInheritance("IPerChannelDbLevel")]
public unsafe partial struct IAudioBass : IAudioBass.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioBass));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioBass, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioBass, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioBass, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount(uint* pcChannels)
    {
        return ((delegate* unmanaged<IAudioBass, uint*, int>)((*lpVtbl)[3]))(this, pcChannels);
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
        return ((delegate* unmanaged<IAudioBass, uint, float*, float*, float*, int>)((*lpVtbl)[4]))(
            this,
            nChannel,
            pfMinLevelDB,
            pfMaxLevelDB,
            pfStepping
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioBass, uint, float*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IAudioBass, uint, float, Guid*, int>)((*lpVtbl)[6]))(
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
        return ((delegate* unmanaged<IAudioBass, float, Guid*, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IAudioBass, float*, uint, Guid*, int>)((*lpVtbl)[8]))(
            this,
            aLevelsDB,
            cChannels,
            pguidEventContext
        );
    }

    public interface Interface : IPerChannelDbLevel.Interface { }

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

    /// <summary>Initializes a new instance of the <see cref = "IAudioBass"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioBass(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPerChannelDbLevel"/> to <see cref = "IAudioBass"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPerChannelDbLevel"/> instance to be converted </param>
    public static explicit operator IAudioBass(Silk.NET.Windows.IPerChannelDbLevel value)
    {
        return new IAudioBass(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioBass"/> to <see cref = "Silk.NET.Windows.IPerChannelDbLevel"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioBass"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPerChannelDbLevel(IAudioBass value)
    {
        return new Silk.NET.Windows.IPerChannelDbLevel(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioBass"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioBass(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioBass(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioBass"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioBass"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioBass value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
