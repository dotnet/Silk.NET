// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask"]/*'/>
[Guid("85788D00-6807-11D0-B810-00C04FD706EC")]
[NativeTypeName("struct IRunnableTask : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRunnableTask : IRunnableTask.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRunnableTask));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRunnableTask*, Guid*, void**, int> )(lpVtbl[0]))((IRunnableTask*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRunnableTask*, uint> )(lpVtbl[1]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRunnableTask*, uint> )(lpVtbl[2]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask.Run"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Run()
    {
        return ((delegate* unmanaged<IRunnableTask*, int> )(lpVtbl[3]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask.Kill"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Kill(BOOL bWait)
    {
        return ((delegate* unmanaged<IRunnableTask*, BOOL, int> )(lpVtbl[4]))((IRunnableTask*)Unsafe.AsPointer(ref this), bWait);
    }

    /// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask.Suspend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged<IRunnableTask*, int> )(lpVtbl[5]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask.Resume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IRunnableTask*, int> )(lpVtbl[6]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRunnableTask.xml' path='doc/member[@name="IRunnableTask.IsRunning"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("ULONG")]
    public uint IsRunning()
    {
        return ((delegate* unmanaged<IRunnableTask*, uint> )(lpVtbl[7]))((IRunnableTask*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Run();
        [VtblIndex(4)]
        HRESULT Kill(BOOL bWait);
        [VtblIndex(5)]
        HRESULT Suspend();
        [VtblIndex(6)]
        HRESULT Resume();
        [VtblIndex(7)]
        [return: NativeTypeName("ULONG")]
        uint IsRunning();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Run;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Kill;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Suspend;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> IsRunning;
    }
}