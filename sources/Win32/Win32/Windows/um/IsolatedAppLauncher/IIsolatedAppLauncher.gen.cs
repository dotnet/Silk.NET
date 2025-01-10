// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F686878F-7B42-4CC4-96FB-F4F3B6E3D24D")]
[NativeTypeName("struct IIsolatedAppLauncher : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIsolatedAppLauncher : IIsolatedAppLauncher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIsolatedAppLauncher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIsolatedAppLauncher, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIsolatedAppLauncher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIsolatedAppLauncher, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Launch(
        [NativeTypeName("LPCWSTR")] ushort* appUserModelId,
        [NativeTypeName("LPCWSTR")] ushort* arguments,
        [NativeTypeName("const IsolatedAppLauncherTelemetryParameters *")]
            IsolatedAppLauncherTelemetryParameters* telemetryParameters
    )
    {
        return (
            (delegate* unmanaged<
                IIsolatedAppLauncher,
                ushort*,
                ushort*,
                IsolatedAppLauncherTelemetryParameters*,
                int>)((*lpVtbl)[3])
        )(this, appUserModelId, arguments, telemetryParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Launch(
            [NativeTypeName("LPCWSTR")] ushort* appUserModelId,
            [NativeTypeName("LPCWSTR")] ushort* arguments,
            [NativeTypeName("const IsolatedAppLauncherTelemetryParameters *")]
                IsolatedAppLauncherTelemetryParameters* telemetryParameters
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
            "HRESULT (LPCWSTR, LPCWSTR, const IsolatedAppLauncherTelemetryParameters *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            IsolatedAppLauncherTelemetryParameters*,
            int> Launch;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIsolatedAppLauncher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIsolatedAppLauncher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIsolatedAppLauncher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIsolatedAppLauncher(Silk.NET.Windows.IUnknown value)
    {
        return new IIsolatedAppLauncher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsolatedAppLauncher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIsolatedAppLauncher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIsolatedAppLauncher value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
