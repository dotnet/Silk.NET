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

[Guid("5BB50F15-E46D-4C82-847D-5A0304C1D53D")]
[NativeTypeName("struct ISmsReceivedEventDetails : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
)]
public unsafe partial struct ISmsReceivedEventDetails
    : ISmsReceivedEventDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsReceivedEventDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsReceivedEventDetails, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
    )]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
    )]
    public HRESULT get_MessageIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmsReceivedEventDetails, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
        )]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
        )]
        HRESULT get_MessageIndex([NativeTypeName("UINT32 *")] uint* value);
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
        [Obsolete(
            "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
        )]
        public delegate* unmanaged<TSelf*, uint*, int> get_MessageIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsReceivedEventDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsReceivedEventDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsReceivedEventDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsReceivedEventDetails(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsReceivedEventDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsReceivedEventDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsReceivedEventDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsReceivedEventDetails value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsReceivedEventDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsReceivedEventDetails(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsReceivedEventDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsReceivedEventDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsReceivedEventDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsReceivedEventDetails value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
