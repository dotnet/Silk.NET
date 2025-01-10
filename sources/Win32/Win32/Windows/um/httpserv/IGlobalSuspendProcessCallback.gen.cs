// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7FD8F303-1031-4E50-918A-B7B916FD6C54")]
[NativeTypeName("struct IGlobalSuspendProcessCallback : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalSuspendProcessCallback
    : IGlobalSuspendProcessCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalSuspendProcessCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IGlobalSuspendProcessCallback*, HRESULT, void>)((*lpVtbl)[0]))(
            (IGlobalSuspendProcessCallback*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IGlobalSuspendProcessCallback*, int>)((*lpVtbl)[1]))(
            (IGlobalSuspendProcessCallback*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        HRESULT Resume();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged<TSelf*, int> Resume;
    }
}
