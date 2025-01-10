// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A6C4BAC0-51F8-4C57-AC3F-156DD1680C4F")]
[NativeTypeName("struct IBackgroundTaskCanceledEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBackgroundTaskCanceledEventHandler
    : IBackgroundTaskCanceledEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskCanceledEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskCanceledEventHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundTaskCanceledEventHandler, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskCanceledEventHandler, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *")]
            IBackgroundTaskInstance sender,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason"
        )]
            BackgroundTaskCancellationReason reason
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskCanceledEventHandler,
                IBackgroundTaskInstance,
                BackgroundTaskCancellationReason,
                int>)((*lpVtbl)[3])
        )(this, sender, reason);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *"
            )]
                IBackgroundTaskInstance sender,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason"
            )]
                BackgroundTaskCancellationReason reason
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
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskInstance *, ABI::Windows::ApplicationModel::Background::BackgroundTaskCancellationReason) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBackgroundTaskInstance,
            BackgroundTaskCancellationReason,
            int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskCanceledEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskCanceledEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskCanceledEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskCanceledEventHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBackgroundTaskCanceledEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskCanceledEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskCanceledEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBackgroundTaskCanceledEventHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
