// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("37776AFF-852E-4EEC-93A5-B85A285A95B8")]
public unsafe partial struct IHttpCacheSpecificData : IHttpCacheSpecificData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCacheSpecificData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged<IHttpCacheSpecificData*, IHttpCacheKey*>)((*lpVtbl)[0]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void ReferenceCacheData()
    {
        ((delegate* unmanaged<IHttpCacheSpecificData*, void>)((*lpVtbl)[1]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void DereferenceCacheData()
    {
        ((delegate* unmanaged<IHttpCacheSpecificData*, void>)((*lpVtbl)[2]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ResetTTL()
    {
        ((delegate* unmanaged<IHttpCacheSpecificData*, void>)((*lpVtbl)[3]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementTTL(BOOL* pfTTLExpired)
    {
        ((delegate* unmanaged<IHttpCacheSpecificData*, BOOL*, void>)((*lpVtbl)[4]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this),
            pfTTLExpired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetFlushed()
    {
        ((delegate* unmanaged<IHttpCacheSpecificData*, void>)((*lpVtbl)[5]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetFlushed()
    {
        return ((delegate* unmanaged<IHttpCacheSpecificData*, int>)((*lpVtbl)[6]))(
            (IHttpCacheSpecificData*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpCacheKey* GetCacheKey();

        [VtblIndex(1)]
        void ReferenceCacheData();

        [VtblIndex(2)]
        void DereferenceCacheData();

        [VtblIndex(3)]
        void ResetTTL();

        [VtblIndex(4)]
        void DecrementTTL(BOOL* pfTTLExpired);

        [VtblIndex(5)]
        void SetFlushed();

        [VtblIndex(6)]
        BOOL GetFlushed();
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
    }
}
