// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("780E4416-5E72-4123-808E-66DC6479FEEF")]
[NativeTypeName("struct IIsolatedProcessLauncher2 : IIsolatedProcessLauncher")]
[NativeInheritance("IIsolatedProcessLauncher")]
public unsafe partial struct IIsolatedProcessLauncher2
    : IIsolatedProcessLauncher2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIsolatedProcessLauncher2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchProcess(
        [NativeTypeName("LPCWSTR")] ushort* process,
        [NativeTypeName("LPCWSTR")] ushort* arguments,
        [NativeTypeName("LPCWSTR")] ushort* workingDirectory
    )
    {
        return (
            (delegate* unmanaged<IIsolatedProcessLauncher2, ushort*, ushort*, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(this, process, arguments, workingDirectory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShareDirectory(
        [NativeTypeName("LPCWSTR")] ushort* hostPath,
        [NativeTypeName("LPCWSTR")] ushort* containerPath,
        BOOL readOnly
    )
    {
        return (
            (delegate* unmanaged<IIsolatedProcessLauncher2, ushort*, ushort*, BOOL, int>)(
                (*lpVtbl)[4]
            )
        )(this, hostPath, containerPath, readOnly);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerGuid(Guid* guid)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, Guid*, int>)((*lpVtbl)[5]))(
            this,
            guid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllowSetForegroundAccess(uint pid)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, uint, int>)((*lpVtbl)[6]))(
            this,
            pid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsContainerRunning(BOOL* running)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher2, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            running
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchProcess2(
        [NativeTypeName("LPCWSTR")] ushort* process,
        [NativeTypeName("LPCWSTR")] ushort* arguments,
        [NativeTypeName("LPCWSTR")] ushort* workingDirectory,
        [NativeTypeName("const GUID &")] Guid* correlationGuid
    )
    {
        return (
            (delegate* unmanaged<IIsolatedProcessLauncher2, ushort*, ushort*, ushort*, Guid*, int>)(
                (*lpVtbl)[8]
            )
        )(this, process, arguments, workingDirectory, correlationGuid);
    }

    public interface Interface : IIsolatedProcessLauncher.Interface
    {
        [VtblIndex(8)]
        HRESULT LaunchProcess2(
            [NativeTypeName("LPCWSTR")] ushort* process,
            [NativeTypeName("LPCWSTR")] ushort* arguments,
            [NativeTypeName("LPCWSTR")] ushort* workingDirectory,
            [NativeTypeName("const GUID &")] Guid* correlationGuid
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> LaunchProcess;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, BOOL, int> ShareDirectory;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerGuid;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AllowSetForegroundAccess;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsContainerRunning;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, const GUID &) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, Guid*, int> LaunchProcess2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIsolatedProcessLauncher2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIsolatedProcessLauncher2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IIsolatedProcessLauncher"/> to <see cref = "IIsolatedProcessLauncher2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IIsolatedProcessLauncher"/> instance to be converted </param>
    public static explicit operator IIsolatedProcessLauncher2(
        Silk.NET.Windows.IIsolatedProcessLauncher value
    )
    {
        return new IIsolatedProcessLauncher2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsolatedProcessLauncher2"/> to <see cref = "Silk.NET.Windows.IIsolatedProcessLauncher"/>.</summary>
    /// <param name = "value">The <see cref = "IIsolatedProcessLauncher2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IIsolatedProcessLauncher(
        IIsolatedProcessLauncher2 value
    )
    {
        return new Silk.NET.Windows.IIsolatedProcessLauncher(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIsolatedProcessLauncher2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIsolatedProcessLauncher2(Silk.NET.Windows.IUnknown value)
    {
        return new IIsolatedProcessLauncher2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsolatedProcessLauncher2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIsolatedProcessLauncher2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIsolatedProcessLauncher2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
