// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("364E018B-1E4E-411F-AB3E-92959844C156")]
[NativeTypeName("struct IAppBroadcastManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastManagerStatics
    : IAppBroadcastManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppBroadcastManagerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGlobalSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **")]
            IAppBroadcastGlobalSettings* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, IAppBroadcastGlobalSettings*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ApplyGlobalSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *")]
            IAppBroadcastGlobalSettings value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, IAppBroadcastGlobalSettings, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProviderSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")]
            IAppBroadcastProviderSettings* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, IAppBroadcastProviderSettings*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ApplyProviderSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *")]
            IAppBroadcastProviderSettings value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastManagerStatics, IAppBroadcastProviderSettings, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetGlobalSettings(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **")]
                IAppBroadcastGlobalSettings* value
        );

        [VtblIndex(7)]
        HRESULT ApplyGlobalSettings(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *")]
                IAppBroadcastGlobalSettings value
        );

        [VtblIndex(8)]
        HRESULT GetProviderSettings(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")]
                IAppBroadcastProviderSettings* value
        );

        [VtblIndex(9)]
        HRESULT ApplyProviderSettings(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *")]
                IAppBroadcastProviderSettings value
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
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastGlobalSettings*, int> GetGlobalSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastGlobalSettings, int> ApplyGlobalSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastProviderSettings*, int> GetProviderSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastProviderSettings,
            int> ApplyProviderSettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
