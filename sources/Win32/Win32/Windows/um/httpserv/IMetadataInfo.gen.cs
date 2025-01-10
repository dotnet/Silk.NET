// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("48B10633-825D-495E-93B0-225380053E8E")]
public unsafe partial struct IMetadataInfo : IMetadataInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMetadataInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetMetaPath()
    {
        return ((delegate* unmanaged<IMetadataInfo*, ushort*>)((*lpVtbl)[0]))(
            (IMetadataInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetVrPath()
    {
        return ((delegate* unmanaged<IMetadataInfo*, ushort*>)((*lpVtbl)[1]))(
            (IMetadataInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpTokenEntry* GetVrToken()
    {
        return ((delegate* unmanaged<IMetadataInfo*, IHttpTokenEntry*>)((*lpVtbl)[2]))(
            (IMetadataInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged<IMetadataInfo*, IHttpModuleContextContainer*>)((*lpVtbl)[3]))(
            (IMetadataInfo*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetMetaPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetVrPath();

        [VtblIndex(2)]
        IHttpTokenEntry* GetVrToken();

        [VtblIndex(3)]
        IHttpModuleContextContainer* GetModuleContextContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetMetaPath;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetVrPath;

        [NativeTypeName("IHttpTokenEntry *()")]
        public delegate* unmanaged<TSelf*, IHttpTokenEntry*> GetVrToken;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;
    }
}
