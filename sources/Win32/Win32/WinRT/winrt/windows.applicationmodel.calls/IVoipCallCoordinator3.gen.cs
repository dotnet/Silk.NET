// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("338D0CBF-9B55-4021-87CA-E64B9BD666C7")]
[NativeTypeName("struct IVoipCallCoordinator3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator3 : IVoipCallCoordinator3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipCallCoordinator3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVoipCallCoordinator3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVoipCallCoordinator3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVoipCallCoordinator3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestNewAppInitiatedCall(
        HSTRING context,
        HSTRING contactName,
        HSTRING contactNumber,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
            VoipPhoneCallMedia media,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator3,
                HSTRING,
                HSTRING,
                HSTRING,
                HSTRING,
                VoipPhoneCallMedia,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[6])
        )(this, context, contactName, contactNumber, serviceName, media, call);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestNewIncomingCallWithContactRemoteId(
        HSTRING context,
        HSTRING contactName,
        HSTRING contactNumber,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass contactImage,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass brandingImage,
        HSTRING callDetails,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass ringtone,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
            VoipPhoneCallMedia media,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
        HSTRING contactRemoteId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator3,
                HSTRING,
                HSTRING,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                VoipPhoneCallMedia,
                TimeSpan,
                HSTRING,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[7])
        )(
            this,
            context,
            contactName,
            contactNumber,
            contactImage,
            serviceName,
            brandingImage,
            callDetails,
            ringtone,
            media,
            ringTimeout,
            contactRemoteId,
            call
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestNewAppInitiatedCall(
            HSTRING context,
            HSTRING contactName,
            HSTRING contactNumber,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
                VoipPhoneCallMedia media,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
        );

        [VtblIndex(7)]
        HRESULT RequestNewIncomingCallWithContactRemoteId(
            HSTRING context,
            HSTRING contactName,
            HSTRING contactNumber,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass contactImage,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass brandingImage,
            HSTRING callDetails,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass ringtone,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
                VoipPhoneCallMedia media,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
            HSTRING contactRemoteId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
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
            "HRESULT (HSTRING, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            HSTRING,
            VoipPhoneCallMedia,
            IVoipPhoneCall*,
            int> RequestNewAppInitiatedCall;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::Foundation::TimeSpan, HSTRING, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            VoipPhoneCallMedia,
            TimeSpan,
            HSTRING,
            IVoipPhoneCall*,
            int> RequestNewIncomingCallWithContactRemoteId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVoipCallCoordinator3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVoipCallCoordinator3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVoipCallCoordinator3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVoipCallCoordinator3(Silk.NET.WinRT.IInspectable value)
    {
        return new IVoipCallCoordinator3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipCallCoordinator3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipCallCoordinator3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVoipCallCoordinator3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVoipCallCoordinator3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVoipCallCoordinator3(Silk.NET.Windows.IUnknown value)
    {
        return new IVoipCallCoordinator3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipCallCoordinator3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipCallCoordinator3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVoipCallCoordinator3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
