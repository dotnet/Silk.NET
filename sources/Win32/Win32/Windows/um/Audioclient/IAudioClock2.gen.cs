// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6F49FF73-6727-49AC-A008-D98CF5E70048")]
[NativeTypeName("struct IAudioClock2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioClock2 : IAudioClock2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClock2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClock2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioClock2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClock2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevicePosition(
        [NativeTypeName("UINT64 *")] ulong* DevicePosition,
        [NativeTypeName("UINT64 *")] ulong* QPCPosition
    )
    {
        return ((delegate* unmanaged<IAudioClock2, ulong*, ulong*, int>)((*lpVtbl)[3]))(
            this,
            DevicePosition,
            QPCPosition
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevicePosition(
            [NativeTypeName("UINT64 *")] ulong* DevicePosition,
            [NativeTypeName("UINT64 *")] ulong* QPCPosition
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

        [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, int> GetDevicePosition;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioClock2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioClock2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioClock2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioClock2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioClock2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioClock2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioClock2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioClock2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
