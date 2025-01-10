// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IPmApplicationPreload : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmApplicationPreload : IPmApplicationPreload.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPmApplicationPreload*, uint>)((*lpVtbl)[0]))(
            (IPmApplicationPreload*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPmApplicationPreload*, uint>)((*lpVtbl)[1]))(
            (IPmApplicationPreload*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT PreloadApplication(
        [NativeTypeName("DWORD")] uint dwSiteId,
        [NativeTypeName("PCWSTR")] ushort* pszAppConfigPath,
        [Optional] BOOL fRecycledWorkerProcess
    )
    {
        return (
            (delegate* unmanaged<IPmApplicationPreload*, uint, ushort*, BOOL, int>)((*lpVtbl)[2])
        )(
            (IPmApplicationPreload*)Unsafe.AsPointer(ref this),
            dwSiteId,
            pszAppConfigPath,
            fRecycledWorkerProcess
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT PreloadApplication(
            [NativeTypeName("DWORD")] uint dwSiteId,
            [NativeTypeName("PCWSTR")] ushort* pszAppConfigPath,
            [Optional] BOOL fRecycledWorkerProcess
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, PCWSTR, BOOL)")]
        public delegate* unmanaged<TSelf*, uint, ushort*, BOOL, int> PreloadApplication;
    }
}
