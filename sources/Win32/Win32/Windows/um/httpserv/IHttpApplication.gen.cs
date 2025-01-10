// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3F75D9E6-1075-422C-AD89-93A85F2D7BDC")]
public unsafe partial struct IHttpApplication : IHttpApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpApplication));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetApplicationPhysicalPath()
    {
        return ((delegate* unmanaged<IHttpApplication*, ushort*>)((*lpVtbl)[0]))(
            (IHttpApplication*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetApplicationId()
    {
        return ((delegate* unmanaged<IHttpApplication*, ushort*>)((*lpVtbl)[1]))(
            (IHttpApplication*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAppConfigPath()
    {
        return ((delegate* unmanaged<IHttpApplication*, ushort*>)((*lpVtbl)[2]))(
            (IHttpApplication*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return (
            (delegate* unmanaged<IHttpApplication*, IHttpModuleContextContainer*>)((*lpVtbl)[3])
        )((IHttpApplication*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetApplicationPhysicalPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetApplicationId();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetAppConfigPath();

        [VtblIndex(3)]
        IHttpModuleContextContainer* GetModuleContextContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetApplicationPhysicalPath;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetApplicationId;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetAppConfigPath;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;
    }
}
