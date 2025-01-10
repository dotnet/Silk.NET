// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("841D9A71-75F4-4626-8B97-66046CA7E45B")]
[NativeTypeName("struct IHttpConnectionStoredContext : IHttpStoredContext")]
[NativeInheritance("IHttpStoredContext")]
public unsafe partial struct IHttpConnectionStoredContext
    : IHttpConnectionStoredContext.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpConnectionStoredContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void CleanupStoredContext()
    {
        ((delegate* unmanaged<IHttpConnectionStoredContext*, void>)((*lpVtbl)[0]))(
            (IHttpConnectionStoredContext*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void NotifyDisconnect()
    {
        ((delegate* unmanaged<IHttpConnectionStoredContext*, void>)((*lpVtbl)[1]))(
            (IHttpConnectionStoredContext*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpStoredContext.Interface
    {
        [VtblIndex(1)]
        void NotifyDisconnect();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> CleanupStoredContext;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> NotifyDisconnect;
    }
}
