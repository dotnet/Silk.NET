// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FD86E6DE-FB0E-47DD-820A-E0DA12BE46E9")]
[NativeTypeName("struct IHttpTokenEntry : IHttpCacheSpecificData")]
[NativeInheritance("IHttpCacheSpecificData")]
public unsafe partial struct IHttpTokenEntry : IHttpTokenEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpTokenEntry));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged<IHttpTokenEntry*, IHttpCacheKey*>)((*lpVtbl)[0]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void ReferenceCacheData()
    {
        ((delegate* unmanaged<IHttpTokenEntry*, void>)((*lpVtbl)[1]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void DereferenceCacheData()
    {
        ((delegate* unmanaged<IHttpTokenEntry*, void>)((*lpVtbl)[2]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ResetTTL()
    {
        ((delegate* unmanaged<IHttpTokenEntry*, void>)((*lpVtbl)[3]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementTTL(BOOL* pfTTLExpired)
    {
        ((delegate* unmanaged<IHttpTokenEntry*, BOOL*, void>)((*lpVtbl)[4]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this),
            pfTTLExpired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetFlushed()
    {
        ((delegate* unmanaged<IHttpTokenEntry*, void>)((*lpVtbl)[5]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetFlushed()
    {
        return ((delegate* unmanaged<IHttpTokenEntry*, int>)((*lpVtbl)[6]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HANDLE GetImpersonationToken()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpTokenEntry*, void*>)((*lpVtbl)[7]))(
                    (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HANDLE GetPrimaryToken()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpTokenEntry*, void*>)((*lpVtbl)[8]))(
                    (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("PSID")]
    public void* GetSid()
    {
        return ((delegate* unmanaged<IHttpTokenEntry*, void*>)((*lpVtbl)[9]))(
            (IHttpTokenEntry*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpCacheSpecificData.Interface
    {
        [VtblIndex(7)]
        HANDLE GetImpersonationToken();

        [VtblIndex(8)]
        HANDLE GetPrimaryToken();

        [VtblIndex(9)]
        [return: NativeTypeName("PSID")]
        void* GetSid();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpCacheKey *() const")]
        public delegate* unmanaged<TSelf*, IHttpCacheKey*> GetCacheKey;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> ReferenceCacheData;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> DereferenceCacheData;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> ResetTTL;

        [NativeTypeName("void (BOOL *)")]
        public delegate* unmanaged<TSelf*, BOOL*, void> DecrementTTL;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> SetFlushed;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetFlushed;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged<TSelf*, void*> GetImpersonationToken;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged<TSelf*, void*> GetPrimaryToken;

        [NativeTypeName("PSID ()")]
        public delegate* unmanaged<TSelf*, void*> GetSid;
    }
}
