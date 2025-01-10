// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C3B284D4-6D39-4359-B3CF-B56DDB3BB39C")]
[NativeTypeName("struct IAudioVolumeDuckNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioVolumeDuckNotification
    : IAudioVolumeDuckNotification.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioVolumeDuckNotification));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioVolumeDuckNotification, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioVolumeDuckNotification, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioVolumeDuckNotification, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnVolumeDuckNotification(
        [NativeTypeName("LPCWSTR")] ushort* sessionID,
        [NativeTypeName("UINT32")] uint countCommunicationSessions
    )
    {
        return (
            (delegate* unmanaged<IAudioVolumeDuckNotification, ushort*, uint, int>)((*lpVtbl)[3])
        )(this, sessionID, countCommunicationSessions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID)
    {
        return ((delegate* unmanaged<IAudioVolumeDuckNotification, ushort*, int>)((*lpVtbl)[4]))(
            this,
            sessionID
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnVolumeDuckNotification(
            [NativeTypeName("LPCWSTR")] ushort* sessionID,
            [NativeTypeName("UINT32")] uint countCommunicationSessions
        );

        [VtblIndex(4)]
        HRESULT OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID);
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

        [NativeTypeName("HRESULT (LPCWSTR, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> OnVolumeDuckNotification;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OnVolumeUnduckNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioVolumeDuckNotification"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioVolumeDuckNotification(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioVolumeDuckNotification"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioVolumeDuckNotification(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioVolumeDuckNotification(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioVolumeDuckNotification"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioVolumeDuckNotification"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioVolumeDuckNotification value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
