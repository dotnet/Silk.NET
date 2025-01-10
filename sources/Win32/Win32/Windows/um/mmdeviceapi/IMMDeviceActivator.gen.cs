// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3B0D0EA4-D0A9-4B0E-935B-09516746FAC0")]
[NativeTypeName("struct IMMDeviceActivator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDeviceActivator : IMMDeviceActivator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDeviceActivator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDeviceActivator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMMDeviceActivator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDeviceActivator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate(
        [NativeTypeName("const IID &")] Guid* iid,
        IMMDevice pDevice,
        PROPVARIANT* pActivationParams,
        void** ppInterface
    )
    {
        return (
            (delegate* unmanaged<IMMDeviceActivator, Guid*, IMMDevice, PROPVARIANT*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iid, pDevice, pActivationParams, ppInterface);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate(
            [NativeTypeName("const IID &")] Guid* iid,
            IMMDevice pDevice,
            PROPVARIANT* pActivationParams,
            void** ppInterface
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
            "HRESULT (const IID &, IMMDevice *, PROPVARIANT *, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, IMMDevice, PROPVARIANT*, void**, int> Activate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMMDeviceActivator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMMDeviceActivator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMMDeviceActivator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMMDeviceActivator(Silk.NET.Windows.IUnknown value)
    {
        return new IMMDeviceActivator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMMDeviceActivator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMMDeviceActivator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMMDeviceActivator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
