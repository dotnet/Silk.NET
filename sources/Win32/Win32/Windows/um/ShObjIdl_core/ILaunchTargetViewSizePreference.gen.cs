// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2F0666C6-12F7-4360-B511-A394A0553725")]
[NativeTypeName("struct ILaunchTargetViewSizePreference : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ILaunchTargetViewSizePreference
    : ILaunchTargetViewSizePreference.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchTargetViewSizePreference));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILaunchTargetViewSizePreference, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILaunchTargetViewSizePreference, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILaunchTargetViewSizePreference, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTargetViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* targetSizeOnLaunch)
    {
        return (
            (delegate* unmanaged<
                ILaunchTargetViewSizePreference,
                APPLICATION_VIEW_SIZE_PREFERENCE*,
                int>)((*lpVtbl)[3])
        )(this, targetSizeOnLaunch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTargetViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* targetSizeOnLaunch);
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

        [NativeTypeName("HRESULT (APPLICATION_VIEW_SIZE_PREFERENCE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            APPLICATION_VIEW_SIZE_PREFERENCE*,
            int> GetTargetViewSizePreference;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILaunchTargetViewSizePreference"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILaunchTargetViewSizePreference(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILaunchTargetViewSizePreference"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILaunchTargetViewSizePreference(Silk.NET.Windows.IUnknown value)
    {
        return new ILaunchTargetViewSizePreference(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILaunchTargetViewSizePreference"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILaunchTargetViewSizePreference"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILaunchTargetViewSizePreference value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
