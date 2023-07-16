// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPackageDebugSettings2.xml' path='doc/member[@name="IPackageDebugSettings2"]/*'/>
[Guid("6E3194BB-AB82-4D22-93F5-FABDA40E7B16")]
[NativeTypeName("struct IPackageDebugSettings2 : IPackageDebugSettings")]
[NativeInheritance("IPackageDebugSettings")]
public unsafe partial struct IPackageDebugSettings2 : IPackageDebugSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageDebugSettings2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, Guid*, void**, int> )(lpVtbl[0]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, uint> )(lpVtbl[1]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, uint> )(lpVtbl[2]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPackageDebugSettings.EnableDebugging"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("LPCWSTR")] ushort* debuggerCommandLine, [NativeTypeName("PZZWSTR")] ushort* environment)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, ushort*, ushort*, int> )(lpVtbl[3]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, debuggerCommandLine, environment);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.DisableDebugging"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableDebugging([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[4]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.Suspend"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Suspend([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[5]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.Resume"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[6]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.TerminateAllProcesses"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateAllProcesses([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[7]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.SetTargetSessionId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTargetSessionId([NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, uint, int> )(lpVtbl[8]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), sessionId);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.EnumerateBackgroundTasks"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumerateBackgroundTasks([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG *")] uint* taskCount, [NativeTypeName("LPCGUID *")] Guid** taskIds, [NativeTypeName("LPCWSTR **")] ushort*** taskNames)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, uint*, Guid**, ushort***, int> )(lpVtbl[9]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, taskCount, taskIds, taskNames);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.ActivateBackgroundTask"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateBackgroundTask([NativeTypeName("LPCGUID")] Guid* taskId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, Guid*, int> )(lpVtbl[10]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), taskId);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.StartServicing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[11]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.StopServicing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopServicing([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[12]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.StartSessionRedirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG")] uint sessionId)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, uint, int> )(lpVtbl[13]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, sessionId);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.StopSessionRedirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopSessionRedirection([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, int> )(lpVtbl[14]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.GetPackageExecutionState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPackageExecutionState([NativeTypeName("LPCWSTR")] ushort* packageFullName, PACKAGE_EXECUTION_STATE* packageExecutionState)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, PACKAGE_EXECUTION_STATE*, int> )(lpVtbl[15]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, packageExecutionState);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.RegisterForPackageStateChanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterForPackageStateChanges([NativeTypeName("LPCWSTR")] ushort* packageFullName, IPackageExecutionStateChangeNotification* pPackageExecutionStateChangeNotification, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, IPackageExecutionStateChangeNotification*, uint*, int> )(lpVtbl[16]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, pPackageExecutionStateChangeNotification, pdwCookie);
    }

    /// <inheritdoc cref = "IPackageDebugSettings.UnregisterForPackageStateChanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnregisterForPackageStateChanges([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, uint, int> )(lpVtbl[17]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IPackageDebugSettings2.xml' path='doc/member[@name="IPackageDebugSettings2.EnumerateApps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumerateApps([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG *")] uint* appCount, [NativeTypeName("LPWSTR **")] ushort*** appUserModelIds, [NativeTypeName("LPWSTR **")] ushort*** appDisplayNames)
    {
        return ((delegate* unmanaged<IPackageDebugSettings2*, ushort*, uint*, ushort***, ushort***, int> )(lpVtbl[18]))((IPackageDebugSettings2*)Unsafe.AsPointer(ref this), packageFullName, appCount, appUserModelIds, appDisplayNames);
    }

    public interface Interface : IPackageDebugSettings.Interface
    {
        [VtblIndex(18)]
        HRESULT EnumerateApps([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("ULONG *")] uint* appCount, [NativeTypeName("LPWSTR **")] ushort*** appUserModelIds, [NativeTypeName("LPWSTR **")] ushort*** appDisplayNames);
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
        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, LPCGUID *, LPCWSTR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, Guid**, ushort***, int> EnumerateBackgroundTasks;
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
        public delegate* unmanaged<TSelf*, ushort*, PACKAGE_EXECUTION_STATE*, int> GetPackageExecutionState;
        [NativeTypeName("HRESULT (LPCWSTR, IPackageExecutionStateChangeNotification *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IPackageExecutionStateChangeNotification*, uint*, int> RegisterForPackageStateChanges;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterForPackageStateChanges;
        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, LPWSTR **, LPWSTR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, ushort***, ushort***, int> EnumerateApps;
    }
}