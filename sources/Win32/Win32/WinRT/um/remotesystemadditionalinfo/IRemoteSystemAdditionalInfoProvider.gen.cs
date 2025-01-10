// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/remotesystemadditionalinfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EEAA3D5F-EC63-4D27-AF38-E86B1D7292CB")]
[NativeTypeName("struct IRemoteSystemAdditionalInfoProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRemoteSystemAdditionalInfoProvider
    : IRemoteSystemAdditionalInfoProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemAdditionalInfoProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRemoteSystemAdditionalInfoProvider, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdditionalInfo(
        HSTRING* deduplicationId,
        [NativeTypeName("const IID &")] Guid* riid,
        void** mapView
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemAdditionalInfoProvider,
                HSTRING*,
                Guid*,
                void**,
                int>)((*lpVtbl)[3])
        )(this, deduplicationId, riid, mapView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdditionalInfo(
            HSTRING* deduplicationId,
            [NativeTypeName("const IID &")] Guid* riid,
            void** mapView
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

        [NativeTypeName("HRESULT (HSTRING *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, Guid*, void**, int> GetAdditionalInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemAdditionalInfoProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemAdditionalInfoProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemAdditionalInfoProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemAdditionalInfoProvider(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRemoteSystemAdditionalInfoProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemAdditionalInfoProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemAdditionalInfoProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRemoteSystemAdditionalInfoProvider value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
