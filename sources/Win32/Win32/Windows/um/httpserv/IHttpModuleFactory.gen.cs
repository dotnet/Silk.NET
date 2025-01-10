// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BA32D330-9EA8-4B9E-89F1-8C76A323277F")]
public unsafe partial struct IHttpModuleFactory : IHttpModuleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpModuleFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetHttpModule(CHttpModule** ppModule, IModuleAllocator* pAllocator)
    {
        return (
            (delegate* unmanaged<IHttpModuleFactory*, CHttpModule**, IModuleAllocator*, int>)(
                (*lpVtbl)[0]
            )
        )((IHttpModuleFactory*)Unsafe.AsPointer(ref this), ppModule, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void Terminate()
    {
        ((delegate* unmanaged<IHttpModuleFactory*, void>)((*lpVtbl)[1]))(
            (IHttpModuleFactory*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetHttpModule(CHttpModule** ppModule, IModuleAllocator* pAllocator);

        [VtblIndex(1)]
        void Terminate();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (CHttpModule **, IModuleAllocator *)")]
        public delegate* unmanaged<TSelf*, CHttpModule**, IModuleAllocator*, int> GetHttpModule;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> Terminate;
    }
}
