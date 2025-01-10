// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2CA11C87-0873-4CAF-8A7D-BD471E8586D1")]
[NativeTypeName("struct ISmsDeviceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceStatics2 : ISmsDeviceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDeviceStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsDeviceStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsDeviceStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsDeviceStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsDeviceStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsDeviceStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsDeviceStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
    public HRESULT FromNetworkAccountIdAsync(
        HSTRING networkAccountId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISmsDeviceStatics2, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, networkAccountId, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT FromNetworkAccountIdAsync(
            HSTRING networkAccountId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FromNetworkAccountIdAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsDeviceStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsDeviceStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsDeviceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsDeviceStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsDeviceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDeviceStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDeviceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsDeviceStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsDeviceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsDeviceStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsDeviceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDeviceStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDeviceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsDeviceStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
