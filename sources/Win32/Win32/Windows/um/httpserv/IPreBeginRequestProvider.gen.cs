// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FB715D26-AFF9-476A-8FC0-6B1ACB3D1098")]
[NativeTypeName("struct IPreBeginRequestProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IPreBeginRequestProvider
    : IPreBeginRequestProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreBeginRequestProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IPreBeginRequestProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IPreBeginRequestProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpContext* GetHttpContext()
    {
        return ((delegate* unmanaged<IPreBeginRequestProvider*, IHttpContext*>)((*lpVtbl)[1]))(
            (IPreBeginRequestProvider*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        IHttpContext* GetHttpContext();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("IHttpContext *()")]
        public delegate* unmanaged<TSelf*, IHttpContext*> GetHttpContext;
    }
}
