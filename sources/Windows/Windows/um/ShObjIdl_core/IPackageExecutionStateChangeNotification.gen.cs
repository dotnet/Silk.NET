// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPackageExecutionStateChangeNotification.xml' path='doc/member[@name="IPackageExecutionStateChangeNotification"]/*'/>
[Guid("1BB12A62-2AD8-432B-8CCF-0C2C52AFCD5B")]
[NativeTypeName("struct IPackageExecutionStateChangeNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPackageExecutionStateChangeNotification : IPackageExecutionStateChangeNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageExecutionStateChangeNotification));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, Guid*, void**, int> )(lpVtbl[0]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint> )(lpVtbl[1]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, uint> )(lpVtbl[2]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPackageExecutionStateChangeNotification.xml' path='doc/member[@name="IPackageExecutionStateChangeNotification.OnStateChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStateChanged([NativeTypeName("LPCWSTR")] ushort* pszPackageFullName, PACKAGE_EXECUTION_STATE pesNewState)
    {
        return ((delegate* unmanaged<IPackageExecutionStateChangeNotification*, ushort*, PACKAGE_EXECUTION_STATE, int> )(lpVtbl[3]))((IPackageExecutionStateChangeNotification*)Unsafe.AsPointer(ref this), pszPackageFullName, pesNewState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStateChanged([NativeTypeName("LPCWSTR")] ushort* pszPackageFullName, PACKAGE_EXECUTION_STATE pesNewState);
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
}