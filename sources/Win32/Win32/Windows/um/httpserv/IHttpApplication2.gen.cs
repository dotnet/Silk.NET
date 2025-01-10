// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("311A3B7A-B673-4A1C-8349-2E98A23CADCB")]
[NativeTypeName("struct IHttpApplication2 : IHttpApplication")]
[NativeInheritance("IHttpApplication")]
public unsafe partial struct IHttpApplication2 : IHttpApplication2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpApplication2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetApplicationPhysicalPath()
    {
        return ((delegate* unmanaged<IHttpApplication2*, ushort*>)((*lpVtbl)[0]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetApplicationId()
    {
        return ((delegate* unmanaged<IHttpApplication2*, ushort*>)((*lpVtbl)[1]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetAppConfigPath()
    {
        return ((delegate* unmanaged<IHttpApplication2*, ushort*>)((*lpVtbl)[2]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return (
            (delegate* unmanaged<IHttpApplication2*, IHttpModuleContextContainer*>)((*lpVtbl)[3])
        )((IHttpApplication2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void BeginApplicationWarmup()
    {
        ((delegate* unmanaged<IHttpApplication2*, void>)((*lpVtbl)[4]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void EndApplicationWarmup()
    {
        ((delegate* unmanaged<IHttpApplication2*, void>)((*lpVtbl)[5]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL QueryIsWarmingUp()
    {
        return ((delegate* unmanaged<IHttpApplication2*, int>)((*lpVtbl)[6]))(
            (IHttpApplication2*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpApplication.Interface
    {
        [VtblIndex(4)]
        void BeginApplicationWarmup();

        [VtblIndex(5)]
        void EndApplicationWarmup();

        [VtblIndex(6)]
        BOOL QueryIsWarmingUp();
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

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> BeginApplicationWarmup;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> EndApplicationWarmup;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged<TSelf*, int> QueryIsWarmingUp;
    }
}
