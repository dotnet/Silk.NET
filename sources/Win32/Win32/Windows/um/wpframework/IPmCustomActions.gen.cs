// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IPmCustomActions : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmCustomActions : IPmCustomActions.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPmCustomActions*, uint>)((*lpVtbl)[0]))(
            (IPmCustomActions*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPmCustomActions*, uint>)((*lpVtbl)[1]))(
            (IPmCustomActions*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RunCustomAction(
        [NativeTypeName("PCWSTR")] ushort* pszFunctionName,
        [NativeTypeName("PCWSTR")] ushort* pszFunctionArgs,
        ICustomActionResultCallback* pCompletionCallbackClass
    )
    {
        return (
            (delegate* unmanaged<
                IPmCustomActions*,
                ushort*,
                ushort*,
                ICustomActionResultCallback*,
                int>)((*lpVtbl)[2])
        )(
            (IPmCustomActions*)Unsafe.AsPointer(ref this),
            pszFunctionName,
            pszFunctionArgs,
            pCompletionCallbackClass
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT RunCustomAction(
            [NativeTypeName("PCWSTR")] ushort* pszFunctionName,
            [NativeTypeName("PCWSTR")] ushort* pszFunctionArgs,
            ICustomActionResultCallback* pCompletionCallbackClass
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, ICustomActionResultCallback *)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ICustomActionResultCallback*,
            int> RunCustomAction;
    }
}
