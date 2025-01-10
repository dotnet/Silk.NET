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

[Guid("578C2528-4CD9-4161-8045-201CFD5B115C")]
[NativeTypeName("struct IConnectionProfile3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile3 : IConnectionProfile3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfile3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionProfile3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionProfile3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionProfile3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IConnectionProfile3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IConnectionProfile3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IConnectionProfile3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAttributedNetworkUsageAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
            NetworkUsageStates states,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IConnectionProfile3,
                WinRTDateTime,
                WinRTDateTime,
                NetworkUsageStates,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, startTime, endTime, states, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAttributedNetworkUsageAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
                NetworkUsageStates states,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **"
            )]
                IAsyncOperation<IntPtr>** value
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
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CAttributedNetworkUsage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            WinRTDateTime,
            NetworkUsageStates,
            IAsyncOperation<IntPtr>**,
            int> GetAttributedNetworkUsageAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionProfile3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionProfile3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IConnectionProfile3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IConnectionProfile3(Silk.NET.WinRT.IInspectable value)
    {
        return new IConnectionProfile3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IConnectionProfile3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionProfile3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionProfile3(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionProfile3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionProfile3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
