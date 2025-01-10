// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1AA24232-9A91-4201-88CB-122F9D6522E0")]
[NativeTypeName("struct IIsolatedProcessLauncher : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIsolatedProcessLauncher
    : IIsolatedProcessLauncher.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIsolatedProcessLauncher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIsolatedProcessLauncher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IIsolatedProcessLauncher, ushort*, ushort*, ushort*, int>)(
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
            (delegate* unmanaged<IIsolatedProcessLauncher, ushort*, ushort*, BOOL, int>)(
                (*lpVtbl)[4]
            )
        )(this, hostPath, containerPath, readOnly);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerGuid(Guid* guid)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher, Guid*, int>)((*lpVtbl)[5]))(
            this,
            guid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllowSetForegroundAccess(uint pid)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher, uint, int>)((*lpVtbl)[6]))(
            this,
            pid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsContainerRunning(BOOL* running)
    {
        return ((delegate* unmanaged<IIsolatedProcessLauncher, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            running
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LaunchProcess(
            [NativeTypeName("LPCWSTR")] ushort* process,
            [NativeTypeName("LPCWSTR")] ushort* arguments,
            [NativeTypeName("LPCWSTR")] ushort* workingDirectory
        );

        [VtblIndex(4)]
        HRESULT ShareDirectory(
            [NativeTypeName("LPCWSTR")] ushort* hostPath,
            [NativeTypeName("LPCWSTR")] ushort* containerPath,
            BOOL readOnly
        );

        [VtblIndex(5)]
        HRESULT GetContainerGuid(Guid* guid);

        [VtblIndex(6)]
        HRESULT AllowSetForegroundAccess(uint pid);

        [VtblIndex(7)]
        HRESULT IsContainerRunning(BOOL* running);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IIsolatedProcessLauncher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIsolatedProcessLauncher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIsolatedProcessLauncher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIsolatedProcessLauncher(Silk.NET.Windows.IUnknown value)
    {
        return new IIsolatedProcessLauncher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsolatedProcessLauncher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIsolatedProcessLauncher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIsolatedProcessLauncher value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
