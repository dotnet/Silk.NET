// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB16A6EC-BA5D-436F-BF24-3EDE13906450")]
public unsafe partial struct IHttpSite : IHttpSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("DWORD")]
    public uint GetSiteId()
    {
        return ((delegate* unmanaged<IHttpSite*, uint>)((*lpVtbl)[0]))(
            (IHttpSite*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetSiteName()
    {
        return ((delegate* unmanaged<IHttpSite*, ushort*>)((*lpVtbl)[1]))(
            (IHttpSite*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged<IHttpSite*, IHttpModuleContextContainer*>)((*lpVtbl)[2]))(
            (IHttpSite*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged<IHttpSite*, IHttpPerfCounterInfo*>)((*lpVtbl)[3]))(
            (IHttpSite*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("DWORD")]
        uint GetSiteId();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetSiteName();

        [VtblIndex(2)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(3)]
        IHttpPerfCounterInfo* GetPerfCounterInfo();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetSiteId;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetSiteName;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("IHttpPerfCounterInfo *()")]
        public delegate* unmanaged<TSelf*, IHttpPerfCounterInfo*> GetPerfCounterInfo;
    }
}
