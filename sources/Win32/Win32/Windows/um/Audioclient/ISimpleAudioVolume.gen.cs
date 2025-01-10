// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8")]
[NativeTypeName("struct ISimpleAudioVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISimpleAudioVolume : ISimpleAudioVolume.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISimpleAudioVolume));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISimpleAudioVolume, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMasterVolume(float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, float, Guid*, int>)((*lpVtbl)[3]))(
            this,
            fLevel,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMasterVolume(float* pfLevel)
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, float*, int>)((*lpVtbl)[4]))(
            this,
            pfLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMute(
        [NativeTypeName("const BOOL")] BOOL bMute,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, BOOL, Guid*, int>)((*lpVtbl)[5]))(
            this,
            bMute,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMute(BOOL* pbMute)
    {
        return ((delegate* unmanaged<ISimpleAudioVolume, BOOL*, int>)((*lpVtbl)[6]))(this, pbMute);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMasterVolume(float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext);

        [VtblIndex(4)]
        HRESULT GetMasterVolume(float* pfLevel);

        [VtblIndex(5)]
        HRESULT SetMute(
            [NativeTypeName("const BOOL")] BOOL bMute,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(6)]
        HRESULT GetMute(BOOL* pbMute);
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

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Guid*, int> SetMasterVolume;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMasterVolume;

        [NativeTypeName("HRESULT (const BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, Guid*, int> SetMute;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMute;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISimpleAudioVolume"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISimpleAudioVolume(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISimpleAudioVolume"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISimpleAudioVolume(Silk.NET.Windows.IUnknown value)
    {
        return new ISimpleAudioVolume(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISimpleAudioVolume"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISimpleAudioVolume"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISimpleAudioVolume value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
