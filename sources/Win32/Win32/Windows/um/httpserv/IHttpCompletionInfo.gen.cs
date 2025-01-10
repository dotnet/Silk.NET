// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("49DD20E3-D9C0-463C-8821-F3413B55CC00")]
public unsafe partial struct IHttpCompletionInfo : IHttpCompletionInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCompletionInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("DWORD")]
    public uint GetCompletionBytes()
    {
        return ((delegate* unmanaged<IHttpCompletionInfo*, uint>)((*lpVtbl)[0]))(
            (IHttpCompletionInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetCompletionStatus()
    {
        return ((delegate* unmanaged<IHttpCompletionInfo*, int>)((*lpVtbl)[1]))(
            (IHttpCompletionInfo*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("DWORD")]
        uint GetCompletionBytes();

        [VtblIndex(1)]
        HRESULT GetCompletionStatus();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetCompletionBytes;

        [NativeTypeName("HRESULT () const")]
        public delegate* unmanaged<TSelf*, int> GetCompletionStatus;
    }
}
