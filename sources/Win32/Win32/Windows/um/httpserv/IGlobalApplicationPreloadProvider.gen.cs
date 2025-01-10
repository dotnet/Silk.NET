// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2111F8D6-0C41-4FF7-BD45-5C04C7E91A73")]
[NativeTypeName("struct IGlobalApplicationPreloadProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalApplicationPreloadProvider
    : IGlobalApplicationPreloadProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalApplicationPreloadProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IGlobalApplicationPreloadProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IGlobalApplicationPreloadProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT CreateContext(IHttpContext** ppHttpContext)
    {
        return (
            (delegate* unmanaged<IGlobalApplicationPreloadProvider*, IHttpContext**, int>)(
                (*lpVtbl)[1]
            )
        )((IGlobalApplicationPreloadProvider*)Unsafe.AsPointer(ref this), ppHttpContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ExecuteRequest(IHttpContext* pHttpContext, IHttpUser* pHttpUser)
    {
        return (
            (delegate* unmanaged<
                IGlobalApplicationPreloadProvider*,
                IHttpContext*,
                IHttpUser*,
                int>)((*lpVtbl)[2])
        )((IGlobalApplicationPreloadProvider*)Unsafe.AsPointer(ref this), pHttpContext, pHttpUser);
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        HRESULT CreateContext(IHttpContext** ppHttpContext);

        [VtblIndex(2)]
        HRESULT ExecuteRequest(IHttpContext* pHttpContext, IHttpUser* pHttpUser);
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
    }
}
