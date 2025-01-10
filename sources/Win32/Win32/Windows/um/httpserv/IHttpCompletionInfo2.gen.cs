// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("53129F70-0196-47EC-B16C-127906E2AFEB")]
[NativeTypeName("struct IHttpCompletionInfo2 : IHttpCompletionInfo")]
[NativeInheritance("IHttpCompletionInfo")]
public unsafe partial struct IHttpCompletionInfo2 : IHttpCompletionInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCompletionInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("DWORD")]
    public uint GetCompletionBytes()
    {
        return ((delegate* unmanaged<IHttpCompletionInfo2*, uint>)((*lpVtbl)[0]))(
            (IHttpCompletionInfo2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetCompletionStatus()
    {
        return ((delegate* unmanaged<IHttpCompletionInfo2*, int>)((*lpVtbl)[1]))(
            (IHttpCompletionInfo2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("DWORD")]
    public uint GetCompletedOperation()
    {
        return ((delegate* unmanaged<IHttpCompletionInfo2*, uint>)((*lpVtbl)[2]))(
            (IHttpCompletionInfo2*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpCompletionInfo.Interface
    {
        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        uint GetCompletedOperation();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetCompletionBytes;

        [NativeTypeName("HRESULT () const")]
        public delegate* unmanaged<TSelf*, int> GetCompletionStatus;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetCompletedOperation;
    }
}
