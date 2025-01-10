// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct ICustomAction2ResultCallback : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct ICustomAction2ResultCallback : ICustomAction2ResultCallback.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICustomAction2ResultCallback*, uint>)((*lpVtbl)[0]))(
            (ICustomAction2ResultCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICustomAction2ResultCallback*, uint>)((*lpVtbl)[1]))(
            (ICustomAction2ResultCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ReportResult(
        HRESULT hrStatus,
        BOOL fFinalResponse,
        [NativeTypeName("PBYTE")] byte* pbResponse,
        [NativeTypeName("DWORD")] uint cbResponse
    )
    {
        return (
            (delegate* unmanaged<ICustomAction2ResultCallback*, HRESULT, BOOL, byte*, uint, int>)(
                (*lpVtbl)[2]
            )
        )(
            (ICustomAction2ResultCallback*)Unsafe.AsPointer(ref this),
            hrStatus,
            fFinalResponse,
            pbResponse,
            cbResponse
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT ReportResult(
            HRESULT hrStatus,
            BOOL fFinalResponse,
            [NativeTypeName("PBYTE")] byte* pbResponse,
            [NativeTypeName("DWORD")] uint cbResponse
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT, BOOL, PBYTE, DWORD)")]
        public delegate* unmanaged<TSelf*, HRESULT, BOOL, byte*, uint, int> ReportResult;
    }
}
