// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8EFDF557-A8F1-4BC9-B462-6DF3B038A59A")]
[NativeTypeName("struct IMapPathProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IMapPathProvider : IMapPathProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMapPathProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IMapPathProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IMapPathProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetUrl()
    {
        return ((delegate* unmanaged<IMapPathProvider*, ushort*>)((*lpVtbl)[1]))(
            (IMapPathProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetPhysicalPath()
    {
        return ((delegate* unmanaged<IMapPathProvider*, ushort*>)((*lpVtbl)[2]))(
            (IMapPathProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPhysicalPath(
        [NativeTypeName("PCWSTR")] ushort* pszPhysicalPath,
        [NativeTypeName("DWORD")] uint cchPhysicalPath
    )
    {
        return ((delegate* unmanaged<IMapPathProvider*, ushort*, uint, int>)((*lpVtbl)[3]))(
            (IMapPathProvider*)Unsafe.AsPointer(ref this),
            pszPhysicalPath,
            cchPhysicalPath
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetUrl();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetPhysicalPath();

        [VtblIndex(3)]
        HRESULT SetPhysicalPath(
            [NativeTypeName("PCWSTR")] ushort* pszPhysicalPath,
            [NativeTypeName("DWORD")] uint cchPhysicalPath
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetUrl;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetPhysicalPath;

        [NativeTypeName("HRESULT (PCWSTR, DWORD)")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetPhysicalPath;
    }
}
