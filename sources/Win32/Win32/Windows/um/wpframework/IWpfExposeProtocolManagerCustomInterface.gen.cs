// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfExposeProtocolManagerCustomInterface : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfExposeProtocolManagerCustomInterface
    : IWpfExposeProtocolManagerCustomInterface.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IWpfExposeProtocolManagerCustomInterface*, uint>)((*lpVtbl)[0])
        )((IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IWpfExposeProtocolManagerCustomInterface*, uint>)((*lpVtbl)[1])
        )((IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT LoadProtocolManagerAndGetCustomInterface(
        [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDll,
        [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDllInitFunction,
        [NativeTypeName("DWORD")] uint dwCustomInterfaceId,
        [NativeTypeName("PVOID *")] void** ppCustomInterface
    )
    {
        return (
            (delegate* unmanaged<
                IWpfExposeProtocolManagerCustomInterface*,
                ushort*,
                ushort*,
                uint,
                void**,
                int>)((*lpVtbl)[2])
        )(
            (IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this),
            pProtocolManagerDll,
            pProtocolManagerDllInitFunction,
            dwCustomInterfaceId,
            ppCustomInterface
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT LoadProtocolManagerAndGetCustomInterface(
            [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDll,
            [NativeTypeName("PCWSTR")] ushort* pProtocolManagerDllInitFunction,
            [NativeTypeName("DWORD")] uint dwCustomInterfaceId,
            [NativeTypeName("PVOID *")] void** ppCustomInterface
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, DWORD, PVOID *)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            void**,
            int> LoadProtocolManagerAndGetCustomInterface;
    }
}
