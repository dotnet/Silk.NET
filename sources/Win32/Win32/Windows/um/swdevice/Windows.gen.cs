// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/swdevice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SwDeviceCreate(
        [NativeTypeName("PCWSTR")] ushort* pszEnumeratorName,
        [NativeTypeName("PCWSTR")] ushort* pszParentDeviceInstance,
        [NativeTypeName("const SW_DEVICE_CREATE_INFO *")] SW_DEVICE_CREATE_INFO* pCreateInfo,
        [NativeTypeName("ULONG")] uint cPropertyCount,
        [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties,
        [NativeTypeName("SW_DEVICE_CREATE_CALLBACK")]
            delegate* unmanaged<HSWDEVICE, HRESULT, void*, ushort*, void> pCallback,
        [NativeTypeName("PVOID")] void* pContext,
        [NativeTypeName("PHSWDEVICE")] HSWDEVICE* phSwDevice
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void SwDeviceClose(HSWDEVICE hSwDevice);

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SwDeviceSetLifetime(
        HSWDEVICE hSwDevice,
        SW_DEVICE_LIFETIME Lifetime
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SwDeviceGetLifetime(
        HSWDEVICE hSwDevice,
        [NativeTypeName("PSW_DEVICE_LIFETIME")] SW_DEVICE_LIFETIME* pLifetime
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SwDevicePropertySet(
        HSWDEVICE hSwDevice,
        [NativeTypeName("ULONG")] uint cPropertyCount,
        [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SwDeviceInterfaceRegister(
        HSWDEVICE hSwDevice,
        [NativeTypeName("const GUID *")] Guid* pInterfaceClassGuid,
        [NativeTypeName("PCWSTR")] ushort* pszReferenceString,
        [NativeTypeName("ULONG")] uint cPropertyCount,
        [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties,
        BOOL fEnabled,
        [NativeTypeName("PWSTR *")] ushort** ppszDeviceInterfaceId
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void SwMemFree([NativeTypeName("PVOID")] void* pMem);

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SwDeviceInterfaceSetState(
        HSWDEVICE hSwDevice,
        [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId,
        BOOL fEnabled
    );

    [DllImport("cfgmgr32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SwDeviceInterfacePropertySet(
        HSWDEVICE hSwDevice,
        [NativeTypeName("PCWSTR")] ushort* pszDeviceInterfaceId,
        [NativeTypeName("ULONG")] uint cPropertyCount,
        [NativeTypeName("const DEVPROPERTY *")] DEVPROPERTY* pProperties
    );
}
