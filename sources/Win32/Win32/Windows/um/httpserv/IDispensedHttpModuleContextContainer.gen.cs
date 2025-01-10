// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2AE49359-95DD-4E48-AE20-C0CB9D0BC03A")]
[NativeTypeName("struct IDispensedHttpModuleContextContainer : IHttpModuleContextContainer")]
[NativeInheritance("IHttpModuleContextContainer")]
public unsafe partial struct IDispensedHttpModuleContextContainer
    : IDispensedHttpModuleContextContainer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDispensedHttpModuleContextContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpStoredContext* GetModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return (
            (delegate* unmanaged<
                IDispensedHttpModuleContextContainer*,
                void*,
                IHttpStoredContext*>)((*lpVtbl)[0])
        )((IDispensedHttpModuleContextContainer*)Unsafe.AsPointer(ref this), moduleId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetModuleContext(
        IHttpStoredContext* ppStoredContext,
        [NativeTypeName("HTTP_MODULE_ID")] void* moduleId
    )
    {
        return (
            (delegate* unmanaged<
                IDispensedHttpModuleContextContainer*,
                IHttpStoredContext*,
                void*,
                int>)((*lpVtbl)[1])
        )(
            (IDispensedHttpModuleContextContainer*)Unsafe.AsPointer(ref this),
            ppStoredContext,
            moduleId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void ReleaseContainer()
    {
        ((delegate* unmanaged<IDispensedHttpModuleContextContainer*, void>)((*lpVtbl)[2]))(
            (IDispensedHttpModuleContextContainer*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpModuleContextContainer.Interface
    {
        [VtblIndex(2)]
        void ReleaseContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpStoredContext *(HTTP_MODULE_ID)")]
        public delegate* unmanaged<TSelf*, void*, IHttpStoredContext*> GetModuleContext;

        [NativeTypeName("HRESULT (IHttpStoredContext *, HTTP_MODULE_ID)")]
        public delegate* unmanaged<TSelf*, IHttpStoredContext*, void*, int> SetModuleContext;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> ReleaseContainer;
    }
}
