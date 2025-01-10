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

[Guid("F27C3930-8029-4AD1-94E3-3DBA417810C1")]
[NativeTypeName("struct IPackageDebugSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPackageDebugSettings : IPackageDebugSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageDebugSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackageDebugSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageDebugSettings, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IPackageDebugSettings, ushort*, ushort*, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(this, packageFullName, debuggerCommandLine, environment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[4]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Suspend([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[5]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[6]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[7]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, uint, int>)((*lpVtbl)[8]))(
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
            (delegate* unmanaged<IPackageDebugSettings, ushort*, uint*, Guid**, ushort***, int>)(
                (*lpVtbl)[9]
            )
        )(this, packageFullName, taskCount, taskIds, taskNames);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, Guid*, int>)((*lpVtbl)[10]))(
            this,
            taskId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[11]))(
            this,
            packageFullName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[12]))(
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
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, uint, int>)((*lpVtbl)[13]))(
            this,
            packageFullName,
            sessionId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings, ushort*, int>)((*lpVtbl)[14]))(
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
            (delegate* unmanaged<IPackageDebugSettings, ushort*, PACKAGE_EXECUTION_STATE*, int>)(
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
                IPackageDebugSettings,
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
        return ((delegate* unmanaged<IPackageDebugSettings, uint, int>)((*lpVtbl)[17]))(
            this,
            dwCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnableDebugging(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            [NativeTypeName("LPCWSTR")] ushort* debuggerCommandLine,
            [NativeTypeName("PZZWSTR")] ushort* environment
        );

        [VtblIndex(4)]
        HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(5)]
        HRESULT Suspend([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(6)]
        HRESULT Resume([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(7)]
        HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(8)]
        HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId);

        [VtblIndex(9)]
        HRESULT EnumerateBackgroundTasks(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            [NativeTypeName("ULONG *")] uint* taskCount,
            [NativeTypeName("LPCGUID *")] Guid** taskIds,
            [NativeTypeName("LPCWSTR **")] ushort*** taskNames
        );

        [VtblIndex(10)]
        HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId);

        [VtblIndex(11)]
        HRESULT StartServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(12)]
        HRESULT StopServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(13)]
        HRESULT StartSessionRedirection(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            [NativeTypeName("ULONG")] uint sessionId
        );

        [VtblIndex(14)]
        HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName);

        [VtblIndex(15)]
        HRESULT GetPackageExecutionState(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            PACKAGE_EXECUTION_STATE* packageExecutionState
        );

        [VtblIndex(16)]
        HRESULT RegisterForPackageStateChanges(
            [NativeTypeName("LPCWSTR")] ushort* packageFullName,
            IPackageExecutionStateChangeNotification pPackageExecutionStateChangeNotification,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(17)]
        HRESULT UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageDebugSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageDebugSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageDebugSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageDebugSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IPackageDebugSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageDebugSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageDebugSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackageDebugSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
