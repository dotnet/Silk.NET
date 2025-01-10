// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfActions : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfActions : IWpfActions.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWpfActions*, uint>)((*lpVtbl)[0]))(
            (IWpfActions*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWpfActions*, uint>)((*lpVtbl)[1]))(
            (IWpfActions*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void RecycleWorkerProcess([NativeTypeName("PCWSTR")] ushort* pszReason)
    {
        ((delegate* unmanaged<IWpfActions*, ushort*, void>)((*lpVtbl)[2]))(
            (IWpfActions*)Unsafe.AsPointer(ref this),
            pszReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void FailWorkerProcess(
        [NativeTypeName("PCWSTR")] ushort* pszReason,
        HRESULT hrFailureToReport,
        [Optional] BOOL fFailOnNextPing
    )
    {
        ((delegate* unmanaged<IWpfActions*, ushort*, HRESULT, BOOL, void>)((*lpVtbl)[3]))(
            (IWpfActions*)Unsafe.AsPointer(ref this),
            pszReason,
            hrFailureToReport,
            fFailOnNextPing
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        void RecycleWorkerProcess([NativeTypeName("PCWSTR")] ushort* pszReason);

        [VtblIndex(3)]
        void FailWorkerProcess(
            [NativeTypeName("PCWSTR")] ushort* pszReason,
            HRESULT hrFailureToReport,
            [Optional] BOOL fFailOnNextPing
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, void> RecycleWorkerProcess;

        [NativeTypeName("void (PCWSTR, HRESULT, BOOL)")]
        public delegate* unmanaged<TSelf*, ushort*, HRESULT, BOOL, void> FailWorkerProcess;
    }
}
