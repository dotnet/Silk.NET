// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.WinRT.RO_INIT_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoInitialize(RO_INIT_TYPE initType);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void RoUninitialize();

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoActivateInstance(
        HSTRING activatableClassId,
        IInspectable* instance
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoRegisterActivationFactories(
        HSTRING* activatableClassIds,
        [NativeTypeName("PFNGETACTIVATIONFACTORY *")]
            delegate* unmanaged<HSTRING, IActivationFactory*, HRESULT>* activationFactoryCallbacks,
        [NativeTypeName("UINT32")] uint count,
        RO_REGISTRATION_COOKIE* cookie
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void RoRevokeActivationFactories(RO_REGISTRATION_COOKIE cookie);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoGetActivationFactory(
        HSTRING activatableClassId,
        [NativeTypeName("const IID &")] Guid* iid,
        void** factory
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoRegisterForApartmentShutdown(
        IApartmentShutdown callbackObject,
        [NativeTypeName("UINT64 *")] ulong* apartmentIdentifier,
        APARTMENT_SHUTDOWN_REGISTRATION_COOKIE* regCookie
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoUnregisterForApartmentShutdown(
        APARTMENT_SHUTDOWN_REGISTRATION_COOKIE regCookie
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoGetApartmentIdentifier(
        [NativeTypeName("UINT64 *")] ulong* apartmentIdentifier
    );

    [SupportedOSPlatform("windows6.2")]
    public static HRESULT Initialize(RO_INIT_TYPE initType = RO_INIT_SINGLETHREADED)
    {
        return RoInitialize(initType);
    }

    [SupportedOSPlatform("windows6.2")]
    public static void Uninitialize()
    {
        RoUninitialize();
    }

    [SupportedOSPlatform("windows6.2")]
    public static HRESULT RegisterActivationFactories(
        HSTRING* activatableClassIds,
        [NativeTypeName("PFNGETACTIVATIONFACTORY *")]
            delegate* unmanaged<HSTRING, IActivationFactory*, HRESULT>* activationFactoryCallbacks,
        [NativeTypeName("UINT32")] uint count,
        RO_REGISTRATION_COOKIE* cookie
    )
    {
        return RoRegisterActivationFactories(
            activatableClassIds,
            activationFactoryCallbacks,
            count,
            cookie
        );
    }

    [SupportedOSPlatform("windows6.2")]
    public static void RevokeActivationFactories(RO_REGISTRATION_COOKIE cookie)
    {
        RoRevokeActivationFactories(cookie);
    }
}
