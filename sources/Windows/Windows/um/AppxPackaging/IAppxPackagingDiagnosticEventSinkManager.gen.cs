// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxPackagingDiagnosticEventSinkManager.xml' path='doc/member[@name="IAppxPackagingDiagnosticEventSinkManager"]/*'/>
[Guid("369648FA-A7EB-4909-A15D-6954A078F18A")]
[NativeTypeName("struct IAppxPackagingDiagnosticEventSinkManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxPackagingDiagnosticEventSinkManager : IAppxPackagingDiagnosticEventSinkManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackagingDiagnosticEventSinkManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, Guid*, void**, int> )(lpVtbl[0]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint> )(lpVtbl[1]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint> )(lpVtbl[2]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxPackagingDiagnosticEventSinkManager.xml' path='doc/member[@name="IAppxPackagingDiagnosticEventSinkManager.SetSinkForProcess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSinkForProcess(IAppxPackagingDiagnosticEventSink* sink)
    {
        return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, IAppxPackagingDiagnosticEventSink*, int> )(lpVtbl[3]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this), sink);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSinkForProcess(IAppxPackagingDiagnosticEventSink* sink);
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
        [NativeTypeName("HRESULT (IAppxPackagingDiagnosticEventSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxPackagingDiagnosticEventSink*, int> SetSinkForProcess;
    }
}