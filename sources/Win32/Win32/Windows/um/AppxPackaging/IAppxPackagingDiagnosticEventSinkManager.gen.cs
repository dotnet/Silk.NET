// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("369648FA-A7EB-4909-A15D-6954A078F18A")]
[NativeTypeName("struct IAppxPackagingDiagnosticEventSinkManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxPackagingDiagnosticEventSinkManager
    : IAppxPackagingDiagnosticEventSinkManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackagingDiagnosticEventSinkManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager, Guid*, void**, int>)(
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
            (delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSinkForProcess(IAppxPackagingDiagnosticEventSink sink)
    {
        return (
            (delegate* unmanaged<
                IAppxPackagingDiagnosticEventSinkManager,
                IAppxPackagingDiagnosticEventSink,
                int>)((*lpVtbl)[3])
        )(this, sink);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSinkForProcess(IAppxPackagingDiagnosticEventSink sink);
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
        public delegate* unmanaged<
            TSelf*,
            IAppxPackagingDiagnosticEventSink,
            int> SetSinkForProcess;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxPackagingDiagnosticEventSinkManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxPackagingDiagnosticEventSinkManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxPackagingDiagnosticEventSinkManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxPackagingDiagnosticEventSinkManager(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxPackagingDiagnosticEventSinkManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxPackagingDiagnosticEventSinkManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxPackagingDiagnosticEventSinkManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxPackagingDiagnosticEventSinkManager value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
