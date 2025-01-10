// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BB11C46F-EC28-493C-B88A-5DB88062CE98")]
[NativeTypeName("struct IAudioChannelConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioChannelConfig : IAudioChannelConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioChannelConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioChannelConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioChannelConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioChannelConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetChannelConfig(
        [NativeTypeName("DWORD")] uint dwConfig,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IAudioChannelConfig, uint, Guid*, int>)((*lpVtbl)[3]))(
            this,
            dwConfig,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetChannelConfig([NativeTypeName("DWORD *")] uint* pdwConfig)
    {
        return ((delegate* unmanaged<IAudioChannelConfig, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwConfig
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetChannelConfig(
            [NativeTypeName("DWORD")] uint dwConfig,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(4)]
        HRESULT GetChannelConfig([NativeTypeName("DWORD *")] uint* pdwConfig);
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

        [NativeTypeName("HRESULT (DWORD, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> SetChannelConfig;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelConfig;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioChannelConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioChannelConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioChannelConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioChannelConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioChannelConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioChannelConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioChannelConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioChannelConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
