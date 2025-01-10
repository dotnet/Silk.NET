// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("251DB2DD-81E7-44CE-AE02-46529F2D71EA")]
[NativeTypeName("struct IGlobalApplicationPreloadProvider2 : IGlobalApplicationPreloadProvider")]
[NativeInheritance("IGlobalApplicationPreloadProvider")]
public unsafe partial struct IGlobalApplicationPreloadProvider2
    : IGlobalApplicationPreloadProvider2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalApplicationPreloadProvider2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IGlobalApplicationPreloadProvider2*, HRESULT, void>)((*lpVtbl)[0]))(
            (IGlobalApplicationPreloadProvider2*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT CreateContext(IHttpContext** ppHttpContext)
    {
        return (
            (delegate* unmanaged<IGlobalApplicationPreloadProvider2*, IHttpContext**, int>)(
                (*lpVtbl)[1]
            )
        )((IGlobalApplicationPreloadProvider2*)Unsafe.AsPointer(ref this), ppHttpContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ExecuteRequest(IHttpContext* pHttpContext, IHttpUser* pHttpUser)
    {
        return (
            (delegate* unmanaged<
                IGlobalApplicationPreloadProvider2*,
                IHttpContext*,
                IHttpUser*,
                int>)((*lpVtbl)[2])
        )((IGlobalApplicationPreloadProvider2*)Unsafe.AsPointer(ref this), pHttpContext, pHttpUser);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsProcessRecycled()
    {
        return ((delegate* unmanaged<IGlobalApplicationPreloadProvider2*, int>)((*lpVtbl)[3]))(
            (IGlobalApplicationPreloadProvider2*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IGlobalApplicationPreloadProvider.Interface
    {
        [VtblIndex(3)]
        BOOL IsProcessRecycled();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("HRESULT (IHttpContext **)")]
        public delegate* unmanaged<TSelf*, IHttpContext**, int> CreateContext;

        [NativeTypeName("HRESULT (IHttpContext *, IHttpUser *)")]
        public delegate* unmanaged<TSelf*, IHttpContext*, IHttpUser*, int> ExecuteRequest;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsProcessRecycled;
    }
}
