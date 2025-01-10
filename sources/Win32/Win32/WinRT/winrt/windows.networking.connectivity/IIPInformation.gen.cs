// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D85145E0-138F-47D7-9B3A-36BB488CEF33")]
[NativeTypeName("struct IIPInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIPInformation : IIPInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIPInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIPInformation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIPInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIPInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIPInformation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIPInformation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIPInformation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NetworkAdapter(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")]
            INetworkAdapter* value
    )
    {
        return ((delegate* unmanaged<IIPInformation, INetworkAdapter*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrefixLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")]
            IReference<byte>** value
    )
    {
        return ((delegate* unmanaged<IIPInformation, IReference<byte>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NetworkAdapter(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")]
                INetworkAdapter* value
        );

        [VtblIndex(7)]
        HRESULT get_PrefixLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")]
                IReference<byte>** value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::INetworkAdapter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, INetworkAdapter*, int> get_NetworkAdapter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> get_PrefixLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIPInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIPInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIPInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIPInformation(Silk.NET.WinRT.IInspectable value)
    {
        return new IIPInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIPInformation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIPInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIPInformation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIPInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIPInformation(Silk.NET.Windows.IUnknown value)
    {
        return new IIPInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIPInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIPInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIPInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
