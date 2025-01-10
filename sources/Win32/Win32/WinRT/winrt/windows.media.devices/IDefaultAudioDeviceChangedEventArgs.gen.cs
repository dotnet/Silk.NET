// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("110F882F-1C05-4657-A18E-47C9B69F07AB")]
[NativeTypeName("struct IDefaultAudioDeviceChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDefaultAudioDeviceChangedEventArgs
    : IDefaultAudioDeviceChangedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDefaultAudioDeviceChangedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Role(
        [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole *")] AudioDeviceRole* value
    )
    {
        return (
            (delegate* unmanaged<IDefaultAudioDeviceChangedEventArgs, AudioDeviceRole*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Role(
            [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole *")]
                AudioDeviceRole* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioDeviceRole*, int> get_Role;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDefaultAudioDeviceChangedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDefaultAudioDeviceChangedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDefaultAudioDeviceChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDefaultAudioDeviceChangedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDefaultAudioDeviceChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDefaultAudioDeviceChangedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDefaultAudioDeviceChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDefaultAudioDeviceChangedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDefaultAudioDeviceChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDefaultAudioDeviceChangedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDefaultAudioDeviceChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDefaultAudioDeviceChangedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDefaultAudioDeviceChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDefaultAudioDeviceChangedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
