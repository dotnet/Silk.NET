// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0617D9B9-E20F-4A9F-94F9-35403B3BE01E")]
[NativeTypeName("struct IHttpApplicationResolveModulesProvider : IHttpApplicationProvider")]
[NativeInheritance("IHttpApplicationProvider")]
public unsafe partial struct IHttpApplicationResolveModulesProvider
    : IHttpApplicationResolveModulesProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpApplicationResolveModulesProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        (
            (delegate* unmanaged<IHttpApplicationResolveModulesProvider*, HRESULT, void>)(
                (*lpVtbl)[0]
            )
        )((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return (
            (delegate* unmanaged<IHttpApplicationResolveModulesProvider*, IHttpApplication*>)(
                (*lpVtbl)[1]
            )
        )((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RegisterModule(
        [NativeTypeName("HTTP_MODULE_ID")] void* parentModuleId,
        IHttpModuleFactory* pModuleFactory,
        [NativeTypeName("PCWSTR")] ushort* pszModuleName,
        [NativeTypeName("PCWSTR")] ushort* pszModuleType,
        [NativeTypeName("PCWSTR")] ushort* pszModulePreCondition,
        [NativeTypeName("DWORD")] uint dwRequestNotifications,
        [NativeTypeName("DWORD")] uint dwPostRequestNotifications
    )
    {
        return (
            (delegate* unmanaged<
                IHttpApplicationResolveModulesProvider*,
                void*,
                IHttpModuleFactory*,
                ushort*,
                ushort*,
                ushort*,
                uint,
                uint,
                int>)((*lpVtbl)[2])
        )(
            (IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this),
            parentModuleId,
            pModuleFactory,
            pszModuleName,
            pszModuleType,
            pszModulePreCondition,
            dwRequestNotifications,
            dwPostRequestNotifications
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPriorityForRequestNotification(
        [NativeTypeName("PCWSTR")] ushort* pszModuleName,
        [NativeTypeName("DWORD")] uint dwRequestNotification,
        [NativeTypeName("PCWSTR")] ushort* pszPriorityAlias
    )
    {
        return (
            (delegate* unmanaged<
                IHttpApplicationResolveModulesProvider*,
                ushort*,
                uint,
                ushort*,
                int>)((*lpVtbl)[3])
        )(
            (IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this),
            pszModuleName,
            dwRequestNotification,
            pszPriorityAlias
        );
    }

    public interface Interface : IHttpApplicationProvider.Interface
    {
        [VtblIndex(2)]
        HRESULT RegisterModule(
            [NativeTypeName("HTTP_MODULE_ID")] void* parentModuleId,
            IHttpModuleFactory* pModuleFactory,
            [NativeTypeName("PCWSTR")] ushort* pszModuleName,
            [NativeTypeName("PCWSTR")] ushort* pszModuleType,
            [NativeTypeName("PCWSTR")] ushort* pszModulePreCondition,
            [NativeTypeName("DWORD")] uint dwRequestNotifications,
            [NativeTypeName("DWORD")] uint dwPostRequestNotifications
        );

        [VtblIndex(3)]
        HRESULT SetPriorityForRequestNotification(
            [NativeTypeName("PCWSTR")] ushort* pszModuleName,
            [NativeTypeName("DWORD")] uint dwRequestNotification,
            [NativeTypeName("PCWSTR")] ushort* pszPriorityAlias
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("IHttpApplication *()")]
        public delegate* unmanaged<TSelf*, IHttpApplication*> GetApplication;

        [NativeTypeName(
            "HRESULT (HTTP_MODULE_ID, IHttpModuleFactory *, PCWSTR, PCWSTR, PCWSTR, DWORD, DWORD)"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            IHttpModuleFactory*,
            ushort*,
            ushort*,
            ushort*,
            uint,
            uint,
            int> RegisterModule;

        [NativeTypeName("HRESULT (PCWSTR, DWORD, PCWSTR)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ushort*,
            int> SetPriorityForRequestNotification;
    }
}
