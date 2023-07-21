// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellTaskScheduler.xml' path='doc/member[@name="IShellTaskScheduler"]/*' />
[Guid("6CCB7BE0-6807-11D0-B810-00C04FD706EC")]
[NativeTypeName("struct IShellTaskScheduler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellTaskScheduler : IShellTaskScheduler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellTaskScheduler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, void**, int>)(lpVtbl[0]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, uint>)(lpVtbl[1]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, uint>)(lpVtbl[2]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellTaskScheduler.xml' path='doc/member[@name="IShellTaskScheduler.AddTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddTask(IRunnableTask* prt, [NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, [NativeTypeName("DWORD")] uint dwPriority)
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, IRunnableTask*, Guid*, nuint, uint, int>)(lpVtbl[3]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), prt, rtoid, lParam, dwPriority);
    }

    /// <include file='IShellTaskScheduler.xml' path='doc/member[@name="IShellTaskScheduler.RemoveTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, BOOL bWaitIfRunning)
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, nuint, BOOL, int>)(lpVtbl[4]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), rtoid, lParam, bWaitIfRunning);
    }

    /// <include file='IShellTaskScheduler.xml' path='doc/member[@name="IShellTaskScheduler.CountTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public uint CountTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid)
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, uint>)(lpVtbl[5]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), rtoid);
    }

    /// <include file='IShellTaskScheduler.xml' path='doc/member[@name="IShellTaskScheduler.Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Status([NativeTypeName("DWORD")] uint dwReleaseStatus, [NativeTypeName("DWORD")] uint dwThreadTimeout)
    {
        return ((delegate* unmanaged<IShellTaskScheduler*, uint, uint, int>)(lpVtbl[6]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), dwReleaseStatus, dwThreadTimeout);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddTask(IRunnableTask* prt, [NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, [NativeTypeName("DWORD")] uint dwPriority);

        [VtblIndex(4)]
        HRESULT RemoveTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, BOOL bWaitIfRunning);

        [VtblIndex(5)]
        uint CountTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid);

        [VtblIndex(6)]
        HRESULT Status([NativeTypeName("DWORD")] uint dwReleaseStatus, [NativeTypeName("DWORD")] uint dwThreadTimeout);
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

        [NativeTypeName("HRESULT (IRunnableTask *, const TASKOWNERID &, DWORD_PTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRunnableTask*, Guid*, nuint, uint, int> AddTask;

        [NativeTypeName("HRESULT (const TASKOWNERID &, DWORD_PTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, nuint, BOOL, int> RemoveTasks;

        [NativeTypeName("UINT (const TASKOWNERID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint> CountTasks;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Status;
    }
}
