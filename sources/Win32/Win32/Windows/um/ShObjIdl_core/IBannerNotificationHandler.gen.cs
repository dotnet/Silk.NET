// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8D7B2BA7-DB05-46A8-823C-D2B6DE08EE91")]
[NativeTypeName("struct IBannerNotificationHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBannerNotificationHandler
    : IBannerNotificationHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBannerNotificationHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBannerNotificationHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBannerNotificationHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBannerNotificationHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnBannerEvent(
        [NativeTypeName("const BANNER_NOTIFICATION *")] BANNER_NOTIFICATION* notification
    )
    {
        return (
            (delegate* unmanaged<IBannerNotificationHandler, BANNER_NOTIFICATION*, int>)(
                (*lpVtbl)[3]
            )
        )(this, notification);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnBannerEvent(
            [NativeTypeName("const BANNER_NOTIFICATION *")] BANNER_NOTIFICATION* notification
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

        [NativeTypeName("HRESULT (const BANNER_NOTIFICATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANNER_NOTIFICATION*, int> OnBannerEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBannerNotificationHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBannerNotificationHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBannerNotificationHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBannerNotificationHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IBannerNotificationHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBannerNotificationHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBannerNotificationHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBannerNotificationHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
