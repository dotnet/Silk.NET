// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("07E5BEB3-B798-459D-A98A-E6C485B2B3BC")]
public unsafe partial struct IHttpModuleRegistrationInfo
    : IHttpModuleRegistrationInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpModuleRegistrationInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetName()
    {
        return ((delegate* unmanaged<IHttpModuleRegistrationInfo*, ushort*>)((*lpVtbl)[0]))(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_MODULE_ID")]
    public void* GetId()
    {
        return ((delegate* unmanaged<IHttpModuleRegistrationInfo*, void*>)((*lpVtbl)[1]))(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetRequestNotifications(
        IHttpModuleFactory* pModuleFactory,
        [NativeTypeName("DWORD")] uint dwRequestNotifications,
        [NativeTypeName("DWORD")] uint dwPostRequestNotifications
    )
    {
        return (
            (delegate* unmanaged<
                IHttpModuleRegistrationInfo*,
                IHttpModuleFactory*,
                uint,
                uint,
                int>)((*lpVtbl)[2])
        )(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this),
            pModuleFactory,
            dwRequestNotifications,
            dwPostRequestNotifications
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGlobalNotifications(
        CGlobalModule* pGlobalModule,
        [NativeTypeName("DWORD")] uint dwGlobalNotifications
    )
    {
        return (
            (delegate* unmanaged<IHttpModuleRegistrationInfo*, CGlobalModule*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this),
            pGlobalModule,
            dwGlobalNotifications
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPriorityForRequestNotification(
        [NativeTypeName("DWORD")] uint dwRequestNotification,
        [NativeTypeName("PCWSTR")] ushort* pszPriority
    )
    {
        return (
            (delegate* unmanaged<IHttpModuleRegistrationInfo*, uint, ushort*, int>)((*lpVtbl)[4])
        )(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this),
            dwRequestNotification,
            pszPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPriorityForGlobalNotification(
        [NativeTypeName("DWORD")] uint dwGlobalNotification,
        [NativeTypeName("PCWSTR")] ushort* pszPriority
    )
    {
        return (
            (delegate* unmanaged<IHttpModuleRegistrationInfo*, uint, ushort*, int>)((*lpVtbl)[5])
        )(
            (IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this),
            dwGlobalNotification,
            pszPriority
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetName();

        [VtblIndex(1)]
        [return: NativeTypeName("HTTP_MODULE_ID")]
        void* GetId();

        [VtblIndex(2)]
        HRESULT SetRequestNotifications(
            IHttpModuleFactory* pModuleFactory,
            [NativeTypeName("DWORD")] uint dwRequestNotifications,
            [NativeTypeName("DWORD")] uint dwPostRequestNotifications
        );

        [VtblIndex(3)]
        HRESULT SetGlobalNotifications(
            CGlobalModule* pGlobalModule,
            [NativeTypeName("DWORD")] uint dwGlobalNotifications
        );

        [VtblIndex(4)]
        HRESULT SetPriorityForRequestNotification(
            [NativeTypeName("DWORD")] uint dwRequestNotification,
            [NativeTypeName("PCWSTR")] ushort* pszPriority
        );

        [VtblIndex(5)]
        HRESULT SetPriorityForGlobalNotification(
            [NativeTypeName("DWORD")] uint dwGlobalNotification,
            [NativeTypeName("PCWSTR")] ushort* pszPriority
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetName;

        [NativeTypeName("HTTP_MODULE_ID () const")]
        public delegate* unmanaged<TSelf*, void*> GetId;

        [NativeTypeName("HRESULT (IHttpModuleFactory *, DWORD, DWORD)")]
        public delegate* unmanaged<
            TSelf*,
            IHttpModuleFactory*,
            uint,
            uint,
            int> SetRequestNotifications;

        [NativeTypeName("HRESULT (CGlobalModule *, DWORD)")]
        public delegate* unmanaged<TSelf*, CGlobalModule*, uint, int> SetGlobalNotifications;

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetPriorityForRequestNotification;

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetPriorityForGlobalNotification;
    }
}
