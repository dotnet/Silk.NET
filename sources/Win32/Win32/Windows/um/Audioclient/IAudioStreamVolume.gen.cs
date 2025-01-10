// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("93014887-242D-4068-8A15-CF5E93B90FE3")]
[NativeTypeName("struct IAudioStreamVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioStreamVolume : IAudioStreamVolume.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioStreamVolume));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioStreamVolume, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioStreamVolume, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetChannelVolume(
        [NativeTypeName("UINT32")] uint dwIndex,
        [NativeTypeName("const float")] float fLevel
    )
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint, float, int>)((*lpVtbl)[4]))(
            this,
            dwIndex,
            fLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel)
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint, float*, int>)((*lpVtbl)[5]))(
            this,
            dwIndex,
            pfLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAllVolumes(
        [NativeTypeName("UINT32")] uint dwCount,
        [NativeTypeName("const float *")] float* pfVolumes
    )
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint, float*, int>)((*lpVtbl)[6]))(
            this,
            dwCount,
            pfVolumes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes)
    {
        return ((delegate* unmanaged<IAudioStreamVolume, uint, float*, int>)((*lpVtbl)[7]))(
            this,
            dwCount,
            pfVolumes
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT SetChannelVolume(
            [NativeTypeName("UINT32")] uint dwIndex,
            [NativeTypeName("const float")] float fLevel
        );

        [VtblIndex(5)]
        HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel);

        [VtblIndex(6)]
        HRESULT SetAllVolumes(
            [NativeTypeName("UINT32")] uint dwCount,
            [NativeTypeName("const float *")] float* pfVolumes
        );

        [VtblIndex(7)]
        HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (UINT32, const float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, const float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> SetAllVolumes;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetAllVolumes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioStreamVolume"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioStreamVolume(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioStreamVolume"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioStreamVolume(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioStreamVolume(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioStreamVolume"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioStreamVolume"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioStreamVolume value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
