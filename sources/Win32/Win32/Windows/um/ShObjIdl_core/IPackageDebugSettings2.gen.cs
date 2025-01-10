// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6E3194BB-AB82-4D22-93F5-FABDA40E7B16")]
[NativeTypeName("struct IPackageDebugSettings2 : IPackageDebugSettings")]
[NativeInheritance("IPackageDebugSettings")]
public unsafe partial struct IPackageDebugSettings2 : IPackageDebugSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageDebugSettings2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackageDebugSettings2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableDebugging(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        [NativeTypeName("LPCWSTR")] ushort* debuggerCommandLine,
        [NativeTypeName("PZZWSTR")] ushort* environment
    )
    {
        return (
            (delegate* unmanaged<IPackageDebugSettings2, ushort*, ushort*, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(this, packageFullName, debuggerCommandLine, environment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[4]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Suspend([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[5]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[6]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[7]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, uint, int>)((*lpVtbl)[8]))(
            this,
            sessionId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumerateBackgroundTasks(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        [NativeTypeName("ULONG *")] uint* taskCount,
        [NativeTypeName("LPCGUID *")] Guid** taskIds,
        [NativeTypeName("LPCWSTR **")] ushort*** taskNames
    )
    {
        return (
            (delegate* unmanaged<IPackageDebugSettings2, ushort*, uint*, Guid**, ushort***, int>)(
                (*lpVtbl)[9]
            )
        )(this, packageFullName, taskCount, taskIds, taskNames);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, Guid*, int>)((*lpVtbl)[10]))(
            this,
            taskId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[11]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[12]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartSessionRedirection(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        [NativeTypeName("ULONG")] uint sessionId
    )
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, uint, int>)((*lpVtbl)[13]))(
            this,
            packageFullName,
            sessionId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, ushort*, int>)((*lpVtbl)[14]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPackageExecutionState(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        PACKAGE_EXECUTION_STATE* packageExecutionState
    )
    {
        return (
            (delegate* unmanaged<IPackageDebugSettings2, ushort*, PACKAGE_EXECUTION_STATE*, int>)(
                (*lpVtbl)[15]
            )
        )(this, packageFullName, packageExecutionState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterForPackageStateChanges(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        IPackageExecutionStateChangeNotification pPackageExecutionStateChangeNotification,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<
                IPackageDebugSettings2,
                ushort*,
                IPackageExecutionStateChangeNotification,
                uint*,
                int>)((*lpVtbl)[16])
        )(this, packageFullName, pPackageExecutionStateChangeNotification, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2, uint, int>)((*lpVtbl)[17]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumerateApps(
        [NativeTypeName("LPCWSTR")] ushort* packageFullName,
        [NativeTypeName("ULONG *")] uint* appCount,
        [NativeTypeName("LPWSTR **")] ushort*** appUserModelIds,
        [NativeTypeName("LPWSTR **")] ushort*** appDisplayNames
    )
    {
        return (
            (delegate* unmanaged<
                IPackageDebugSettings2,
                ushort*,
                uint*,
                ushort***,
                ushort***,
                int>)((*lpVtbl)[18])
        )(this, packageFullName, appCount, appUserModelIds, appDisplayNames);
    }

    public interface Interface : IPackageDebugSettings.Interface
    {
        [VtblIndex(18)]
        HRESULT EnumerateApps(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            [NativeTypeName("ULONG *")] uint* appCount,
            [NativeTypeName("LPWSTR **")] ushort*** appUserModelIds,
            [NativeTypeName("LPWSTR **")] ushort*** appDisplayNames
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, PZZWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> EnableDebugging;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DisableDebugging;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Suspend;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Resume;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> TerminateAllProcesses;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetTargetSessionId;

        [NativeTypeName(
            "HRESULT (LPCWSTR, ULONG *, LPCGUID *, LPCWSTR **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint*,
            Guid**,
            ushort***,
            int> EnumerateBackgroundTasks;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> ActivateBackgroundTask;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> StartServicing;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> StopServicing;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> StartSessionRedirection;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> StopSessionRedirection;

        [NativeTypeName("HRESULT (LPCWSTR, PACKAGE_EXECUTION_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            PACKAGE_EXECUTION_STATE*,
            int> GetPackageExecutionState;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IPackageExecutionStateChangeNotification *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IPackageExecutionStateChangeNotification,
            uint*,
            int> RegisterForPackageStateChanges;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterForPackageStateChanges;

        [NativeTypeName(
            "HRESULT (LPCWSTR, ULONG *, LPWSTR **, LPWSTR **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint*, ushort***, ushort***, int> EnumerateApps;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageDebugSettings2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageDebugSettings2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPackageDebugSettings"/> to <see cref = "IPackageDebugSettings2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPackageDebugSettings"/> instance to be converted </param>
    public static explicit operator IPackageDebugSettings2(
        Silk.NET.Windows.IPackageDebugSettings value
    )
    {
        return new IPackageDebugSettings2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageDebugSettings2"/> to <see cref = "Silk.NET.Windows.IPackageDebugSettings"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageDebugSettings2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPackageDebugSettings(
        IPackageDebugSettings2 value
    )
    {
        return new Silk.NET.Windows.IPackageDebugSettings(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageDebugSettings2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageDebugSettings2(Silk.NET.Windows.IUnknown value)
    {
        return new IPackageDebugSettings2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageDebugSettings2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageDebugSettings2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackageDebugSettings2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
