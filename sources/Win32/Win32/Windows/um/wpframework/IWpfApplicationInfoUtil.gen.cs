// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfApplicationInfoUtil : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfApplicationInfoUtil : IWpfApplicationInfoUtil.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWpfApplicationInfoUtil*, uint>)((*lpVtbl)[0]))(
            (IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWpfApplicationInfoUtil*, uint>)((*lpVtbl)[1]))(
            (IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetApplicationPropertiesFromAppId(
        [NativeTypeName("PCWSTR")] ushort* pszAppId,
        [NativeTypeName("PWSTR")] ushort* pszVirtualPath,
        [NativeTypeName("DWORD *")] uint* pcchVirtualPath,
        [NativeTypeName("DWORD *")] uint* pdwSiteId
    )
    {
        return (
            (delegate* unmanaged<IWpfApplicationInfoUtil*, ushort*, ushort*, uint*, uint*, int>)(
                (*lpVtbl)[2]
            )
        )(
            (IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this),
            pszAppId,
            pszVirtualPath,
            pcchVirtualPath,
            pdwSiteId
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetApplicationPropertiesFromAppId(
            [NativeTypeName("PCWSTR")] ushort* pszAppId,
            [NativeTypeName("PWSTR")] ushort* pszVirtualPath,
            [NativeTypeName("DWORD *")] uint* pcchVirtualPath,
            [NativeTypeName("DWORD *")] uint* pdwSiteId
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PWSTR, DWORD *, DWORD *)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint*,
            uint*,
            int> GetApplicationPropertiesFromAppId;
    }
}
