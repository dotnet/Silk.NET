// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("58925FB9-7C5E-4684-833B-4A04E1286690")]
[NativeTypeName("struct ICacheProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct ICacheProvider : ICacheProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICacheProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<ICacheProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public CACHE_OPERATION GetCacheOperation()
    {
        return ((delegate* unmanaged<ICacheProvider*, CACHE_OPERATION>)((*lpVtbl)[1]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged<ICacheProvider*, IHttpCacheKey*>)((*lpVtbl)[2]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpCacheSpecificData* GetCacheRecord()
    {
        return ((delegate* unmanaged<ICacheProvider*, IHttpCacheSpecificData*>)((*lpVtbl)[3]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetCacheRecord(IHttpCacheSpecificData* pCacheRecord)
    {
        ((delegate* unmanaged<ICacheProvider*, IHttpCacheSpecificData*, void>)((*lpVtbl)[4]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this),
            pCacheRecord
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged<ICacheProvider*, IHttpTraceContext*>)((*lpVtbl)[5]))(
            (ICacheProvider*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        CACHE_OPERATION GetCacheOperation();

        [VtblIndex(2)]
        IHttpCacheKey* GetCacheKey();

        [VtblIndex(3)]
        IHttpCacheSpecificData* GetCacheRecord();

        [VtblIndex(4)]
        void SetCacheRecord(IHttpCacheSpecificData* pCacheRecord);

        [VtblIndex(5)]
        IHttpTraceContext* GetTraceContext();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("CACHE_OPERATION () const")]
        public delegate* unmanaged<TSelf*, CACHE_OPERATION> GetCacheOperation;

        [NativeTypeName("IHttpCacheKey *() const")]
        public delegate* unmanaged<TSelf*, IHttpCacheKey*> GetCacheKey;

        [NativeTypeName("IHttpCacheSpecificData *() const")]
        public delegate* unmanaged<TSelf*, IHttpCacheSpecificData*> GetCacheRecord;

        [NativeTypeName("void (IHttpCacheSpecificData *)")]
        public delegate* unmanaged<TSelf*, IHttpCacheSpecificData*, void> SetCacheRecord;

        [NativeTypeName("IHttpTraceContext *() const")]
        public delegate* unmanaged<TSelf*, IHttpTraceContext*> GetTraceContext;
    }
}
