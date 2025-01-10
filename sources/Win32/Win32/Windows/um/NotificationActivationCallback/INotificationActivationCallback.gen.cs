// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("53E31837-6600-4A81-9395-75CFFE746F94")]
[NativeTypeName("struct INotificationActivationCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct INotificationActivationCallback
    : INotificationActivationCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INotificationActivationCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INotificationActivationCallback, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INotificationActivationCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INotificationActivationCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [SupportedOSPlatform("windows10.0")]
    public HRESULT Activate(
        [NativeTypeName("LPCWSTR")] ushort* appUserModelId,
        [NativeTypeName("LPCWSTR")] ushort* invokedArgs,
        [NativeTypeName("const NOTIFICATION_USER_INPUT_DATA *")] NOTIFICATION_USER_INPUT_DATA* data,
        [NativeTypeName("ULONG")] uint count
    )
    {
        return (
            (delegate* unmanaged<
                INotificationActivationCallback,
                ushort*,
                ushort*,
                NOTIFICATION_USER_INPUT_DATA*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, appUserModelId, invokedArgs, data, count);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [SupportedOSPlatform("windows10.0")]
        HRESULT Activate(
            [NativeTypeName("LPCWSTR")] ushort* appUserModelId,
            [NativeTypeName("LPCWSTR")] ushort* invokedArgs,
            [NativeTypeName("const NOTIFICATION_USER_INPUT_DATA *")]
                NOTIFICATION_USER_INPUT_DATA* data,
            [NativeTypeName("ULONG")] uint count
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, const NOTIFICATION_USER_INPUT_DATA *, ULONG) __attribute__((stdcall))"
        )]
        [SupportedOSPlatform("windows10.0")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            NOTIFICATION_USER_INPUT_DATA*,
            uint,
            int> Activate;
    }

    /// <summary>Initializes a new instance of the <see cref = "INotificationActivationCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INotificationActivationCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INotificationActivationCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INotificationActivationCallback(Silk.NET.Windows.IUnknown value)
    {
        return new INotificationActivationCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INotificationActivationCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INotificationActivationCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INotificationActivationCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
