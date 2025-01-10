// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4FD11CBF-8CC5-418E-8000-C9E765F88533")]
[NativeTypeName("struct IHttpModuleRegistrationInfo2 : IHttpModuleRegistrationInfo")]
[NativeInheritance("IHttpModuleRegistrationInfo")]
public unsafe partial struct IHttpModuleRegistrationInfo2
    : IHttpModuleRegistrationInfo2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpModuleRegistrationInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetName()
    {
        return ((delegate* unmanaged<IHttpModuleRegistrationInfo2*, ushort*>)((*lpVtbl)[0]))(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_MODULE_ID")]
    public void* GetId()
    {
        return ((delegate* unmanaged<IHttpModuleRegistrationInfo2*, void*>)((*lpVtbl)[1]))(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this)
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
                IHttpModuleRegistrationInfo2*,
                IHttpModuleFactory*,
                uint,
                uint,
                int>)((*lpVtbl)[2])
        )(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this),
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
            (delegate* unmanaged<IHttpModuleRegistrationInfo2*, CGlobalModule*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this),
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
            (delegate* unmanaged<IHttpModuleRegistrationInfo2*, uint, ushort*, int>)((*lpVtbl)[4])
        )(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this),
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
            (delegate* unmanaged<IHttpModuleRegistrationInfo2*, uint, ushort*, int>)((*lpVtbl)[5])
        )(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this),
            dwGlobalNotification,
            pszPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPriorityForPostRequestNotification(
        [NativeTypeName("DWORD")] uint dwPostRequestNotification,
        [NativeTypeName("PCWSTR")] ushort* pszPriority
    )
    {
        return (
            (delegate* unmanaged<IHttpModuleRegistrationInfo2*, uint, ushort*, int>)((*lpVtbl)[6])
        )(
            (IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this),
            dwPostRequestNotification,
            pszPriority
        );
    }

    public interface Interface : IHttpModuleRegistrationInfo.Interface
    {
        [VtblIndex(6)]
        HRESULT SetPriorityForPostRequestNotification(
            [NativeTypeName("DWORD")] uint dwPostRequestNotification,
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

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            int> SetPriorityForPostRequestNotification;
    }
}
