// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7BE19E73-C9BF-468A-AC5A-A5E8653BEC87")]
[NativeTypeName("struct IMFNetSchemeHandlerConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetSchemeHandlerConfig
    : IMFNetSchemeHandlerConfig.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetSchemeHandlerConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumberOfSupportedProtocols([NativeTypeName("ULONG *")] uint* pcProtocols)
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcProtocols
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSupportedProtocolType(
        [NativeTypeName("ULONG")] uint nProtocolIndex,
        MFNETSOURCE_PROTOCOL_TYPE* pnProtocolType
    )
    {
        return (
            (delegate* unmanaged<IMFNetSchemeHandlerConfig, uint, MFNETSOURCE_PROTOCOL_TYPE*, int>)(
                (*lpVtbl)[4]
            )
        )(this, nProtocolIndex, pnProtocolType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ResetProtocolRolloverSettings()
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumberOfSupportedProtocols([NativeTypeName("ULONG *")] uint* pcProtocols);

        [VtblIndex(4)]
        HRESULT GetSupportedProtocolType(
            [NativeTypeName("ULONG")] uint nProtocolIndex,
            MFNETSOURCE_PROTOCOL_TYPE* pnProtocolType
        );

        [VtblIndex(5)]
        HRESULT ResetProtocolRolloverSettings();
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfSupportedProtocols;

        [NativeTypeName("HRESULT (ULONG, MFNETSOURCE_PROTOCOL_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            MFNETSOURCE_PROTOCOL_TYPE*,
            int> GetSupportedProtocolType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetProtocolRolloverSettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetSchemeHandlerConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetSchemeHandlerConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetSchemeHandlerConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetSchemeHandlerConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetSchemeHandlerConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetSchemeHandlerConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetSchemeHandlerConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetSchemeHandlerConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
