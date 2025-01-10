// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IPmCustomActions2 : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmCustomActions2 : IPmCustomActions2.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPmCustomActions2*, uint>)((*lpVtbl)[0]))(
            (IPmCustomActions2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPmCustomActions2*, uint>)((*lpVtbl)[1]))(
            (IPmCustomActions2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RegisterCustomActionCallback(
        [NativeTypeName("PCWSTR")] ushort* pszFunctionName,
        [NativeTypeName("PCWSTR")] ushort* pszFunctionArgs,
        ICustomAction2ResultCallback* pCompletionCallbackClass
    )
    {
        return (
            (delegate* unmanaged<
                IPmCustomActions2*,
                ushort*,
                ushort*,
                ICustomAction2ResultCallback*,
                int>)((*lpVtbl)[2])
        )(
            (IPmCustomActions2*)Unsafe.AsPointer(ref this),
            pszFunctionName,
            pszFunctionArgs,
            pCompletionCallbackClass
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UnregisterCustomActionCallback(
        [NativeTypeName("PCWSTR")] ushort* pszFunctionName
    )
    {
        return ((delegate* unmanaged<IPmCustomActions2*, ushort*, int>)((*lpVtbl)[3]))(
            (IPmCustomActions2*)Unsafe.AsPointer(ref this),
            pszFunctionName
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT RegisterCustomActionCallback(
            [NativeTypeName("PCWSTR")] ushort* pszFunctionName,
            [NativeTypeName("PCWSTR")] ushort* pszFunctionArgs,
            ICustomAction2ResultCallback* pCompletionCallbackClass
        );

        [VtblIndex(3)]
        HRESULT UnregisterCustomActionCallback([NativeTypeName("PCWSTR")] ushort* pszFunctionName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, ICustomAction2ResultCallback *)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ICustomAction2ResultCallback*,
            int> RegisterCustomActionCallback;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, int> UnregisterCustomActionCallback;
    }
}
