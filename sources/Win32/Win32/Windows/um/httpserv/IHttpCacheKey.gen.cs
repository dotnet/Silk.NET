// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CDEF2AAD-20B3-4512-B1B1-094B3844AEB2")]
public unsafe partial struct IHttpCacheKey : IHttpCacheKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCacheKey));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("DWORD")]
    public uint GetHash()
    {
        return ((delegate* unmanaged<IHttpCacheKey*, uint>)((*lpVtbl)[0]))(
            (IHttpCacheKey*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetCacheName()
    {
        return ((delegate* unmanaged<IHttpCacheKey*, ushort*>)((*lpVtbl)[1]))(
            (IHttpCacheKey*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public bool GetIsEqual(IHttpCacheKey* pCacheCompareKey)
    {
        return ((delegate* unmanaged<IHttpCacheKey*, IHttpCacheKey*, byte>)((*lpVtbl)[2]))(
                (IHttpCacheKey*)Unsafe.AsPointer(ref this),
                pCacheCompareKey
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool GetIsPrefix(IHttpCacheKey* pCacheCompareKey)
    {
        return ((delegate* unmanaged<IHttpCacheKey*, IHttpCacheKey*, byte>)((*lpVtbl)[3]))(
                (IHttpCacheKey*)Unsafe.AsPointer(ref this),
                pCacheCompareKey
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Enum(IHttpCacheSpecificData* pCacheData)
    {
        ((delegate* unmanaged<IHttpCacheKey*, IHttpCacheSpecificData*, void>)((*lpVtbl)[4]))(
            (IHttpCacheKey*)Unsafe.AsPointer(ref this),
            pCacheData
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("DWORD")]
        uint GetHash();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetCacheName();

        [VtblIndex(2)]
        bool GetIsEqual(IHttpCacheKey* pCacheCompareKey);

        [VtblIndex(3)]
        bool GetIsPrefix(IHttpCacheKey* pCacheCompareKey);

        [VtblIndex(4)]
        void Enum(IHttpCacheSpecificData* pCacheData);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetHash;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetCacheName;

        [NativeTypeName("bool (IHttpCacheKey *) const")]
        public delegate* unmanaged<TSelf*, IHttpCacheKey*, byte> GetIsEqual;

        [NativeTypeName("bool (IHttpCacheKey *) const")]
        public delegate* unmanaged<TSelf*, IHttpCacheKey*, byte> GetIsPrefix;

        [NativeTypeName("void (IHttpCacheSpecificData *)")]
        public delegate* unmanaged<TSelf*, IHttpCacheSpecificData*, void> Enum;
    }
}
