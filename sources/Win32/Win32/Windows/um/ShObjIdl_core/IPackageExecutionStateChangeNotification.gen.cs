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

[Guid("1BB12A62-2AD8-432B-8CCF-0C2C52AFCD5B")]
[NativeTypeName("struct IPackageExecutionStateChangeNotification : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPackageExecutionStateChangeNotification
    : IPackageExecutionStateChangeNotification.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageExecutionStateChangeNotification));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPackageExecutionStateChangeNotification, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IPackageExecutionStateChangeNotification, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IPackageExecutionStateChangeNotification, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStateChanged(
        [NativeTypeName("LPCWSTR")] ushort* pszPackageFullName,
        PACKAGE_EXECUTION_STATE pesNewState
    )
    {
        return (
            (delegate* unmanaged<
                IPackageExecutionStateChangeNotification,
                ushort*,
                PACKAGE_EXECUTION_STATE,
                int>)((*lpVtbl)[3])
        )(this, pszPackageFullName, pesNewState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStateChanged(
            [NativeTypeName("LPCWSTR")] ushort* pszPackageFullName,
            PACKAGE_EXECUTION_STATE pesNewState
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

        [NativeTypeName("HRESULT (LPCWSTR, PACKAGE_EXECUTION_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PACKAGE_EXECUTION_STATE, int> OnStateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageExecutionStateChangeNotification"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageExecutionStateChangeNotification(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageExecutionStateChangeNotification"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageExecutionStateChangeNotification(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPackageExecutionStateChangeNotification(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageExecutionStateChangeNotification"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageExecutionStateChangeNotification"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPackageExecutionStateChangeNotification value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
