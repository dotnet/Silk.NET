// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("16DB6F7C-1A94-47CA-A8E8-FEA6005FF3BA")]
public unsafe partial struct INamedContextContainer : INamedContextContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamedContextContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpStoredContext* GetNamedContext([NativeTypeName("LPCWSTR")] ushort* szName)
    {
        return (
            (delegate* unmanaged<INamedContextContainer*, ushort*, IHttpStoredContext*>)(
                (*lpVtbl)[0]
            )
        )((INamedContextContainer*)Unsafe.AsPointer(ref this), szName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetNamedContext(
        IHttpStoredContext* ppStoredContext,
        [NativeTypeName("LPCWSTR")] ushort* szName
    )
    {
        return (
            (delegate* unmanaged<INamedContextContainer*, IHttpStoredContext*, ushort*, int>)(
                (*lpVtbl)[1]
            )
        )((INamedContextContainer*)Unsafe.AsPointer(ref this), ppStoredContext, szName);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpStoredContext* GetNamedContext([NativeTypeName("LPCWSTR")] ushort* szName);

        [VtblIndex(1)]
        HRESULT SetNamedContext(
            IHttpStoredContext* ppStoredContext,
            [NativeTypeName("LPCWSTR")] ushort* szName
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpStoredContext *(LPCWSTR)")]
        public delegate* unmanaged<TSelf*, ushort*, IHttpStoredContext*> GetNamedContext;

        [NativeTypeName("HRESULT (IHttpStoredContext *, LPCWSTR)")]
        public delegate* unmanaged<TSelf*, IHttpStoredContext*, ushort*, int> SetNamedContext;
    }
}
