// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ECE31EE5-0486-4FB0-A875-6739A2D7DAF5")]
[NativeTypeName("struct IGlobalFileChangeProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalFileChangeProvider
    : IGlobalFileChangeProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalFileChangeProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IGlobalFileChangeProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IGlobalFileChangeProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetFileName()
    {
        return ((delegate* unmanaged<IGlobalFileChangeProvider*, ushort*>)((*lpVtbl)[1]))(
            (IGlobalFileChangeProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpFileMonitor* GetFileMonitor()
    {
        return ((delegate* unmanaged<IGlobalFileChangeProvider*, IHttpFileMonitor*>)((*lpVtbl)[2]))(
            (IGlobalFileChangeProvider*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetFileName();

        [VtblIndex(2)]
        IHttpFileMonitor* GetFileMonitor();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetFileName;

        [NativeTypeName("IHttpFileMonitor *()")]
        public delegate* unmanaged<TSelf*, IHttpFileMonitor*> GetFileMonitor;
    }
}
