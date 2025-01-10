// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9F4BA807-050E-4495-AE55-8870F7E9194A")]
[NativeTypeName("struct IHttpCachePolicy2 : IHttpCachePolicy")]
[NativeInheritance("IHttpCachePolicy")]
public unsafe partial struct IHttpCachePolicy2 : IHttpCachePolicy2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCachePolicy2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HTTP_CACHE_POLICY* GetKernelCachePolicy()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, HTTP_CACHE_POLICY*>)((*lpVtbl)[0]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void SetKernelCacheInvalidatorSet()
    {
        ((delegate* unmanaged<IHttpCachePolicy2*, void>)((*lpVtbl)[1]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HTTP_CACHE_POLICY* GetUserCachePolicy()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, HTTP_CACHE_POLICY*>)((*lpVtbl)[2]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AppendVaryByHeader([NativeTypeName("PCSTR")] sbyte* pszHeader)
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*, int>)((*lpVtbl)[3]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this),
            pszHeader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByHeaders()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*>)((*lpVtbl)[4]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendVaryByQueryString([NativeTypeName("PCSTR")] sbyte* pszParam)
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*, int>)((*lpVtbl)[5]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this),
            pszParam
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByQueryStrings()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*>)((*lpVtbl)[6]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVaryByValue([NativeTypeName("PCSTR")] sbyte* pszValue)
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*, int>)((*lpVtbl)[7]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this),
            pszValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByValue()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, sbyte*>)((*lpVtbl)[8]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public BOOL IsUserCacheEnabled()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, int>)((*lpVtbl)[9]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DisableUserCache()
    {
        ((delegate* unmanaged<IHttpCachePolicy2*, void>)((*lpVtbl)[10]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public BOOL IsCached()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, int>)((*lpVtbl)[11]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetIsCached()
    {
        ((delegate* unmanaged<IHttpCachePolicy2*, void>)((*lpVtbl)[12]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL GetKernelCacheInvalidatorSet()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, int>)((*lpVtbl)[13]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public BOOL IsForceUpdateSet()
    {
        return ((delegate* unmanaged<IHttpCachePolicy2*, int>)((*lpVtbl)[14]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void SetForceUpdate()
    {
        ((delegate* unmanaged<IHttpCachePolicy2*, void>)((*lpVtbl)[15]))(
            (IHttpCachePolicy2*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpCachePolicy.Interface
    {
        [VtblIndex(14)]
        BOOL IsForceUpdateSet();

        [VtblIndex(15)]
        void SetForceUpdate();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HTTP_CACHE_POLICY *()")]
        public delegate* unmanaged<TSelf*, HTTP_CACHE_POLICY*> GetKernelCachePolicy;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> SetKernelCacheInvalidatorSet;

        [NativeTypeName("HTTP_CACHE_POLICY *()")]
        public delegate* unmanaged<TSelf*, HTTP_CACHE_POLICY*> GetUserCachePolicy;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, int> AppendVaryByHeader;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetVaryByHeaders;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, int> AppendVaryByQueryString;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetVaryByQueryStrings;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetVaryByValue;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetVaryByValue;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsUserCacheEnabled;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> DisableUserCache;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsCached;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> SetIsCached;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetKernelCacheInvalidatorSet;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsForceUpdateSet;

        [NativeTypeName("void ()")]
        public delegate* unmanaged<TSelf*, void> SetForceUpdate;
    }
}
