// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71E95595-8C74-44D9-88A9-F5112D5F5900")]
[NativeTypeName("struct IHttpFileInfo : IHttpCacheSpecificData")]
[NativeInheritance("IHttpCacheSpecificData")]
public unsafe partial struct IHttpFileInfo : IHttpFileInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpFileInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, IHttpCacheKey*>)((*lpVtbl)[0]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void ReferenceCacheData()
    {
        ((delegate* unmanaged<IHttpFileInfo*, void>)((*lpVtbl)[1]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void DereferenceCacheData()
    {
        ((delegate* unmanaged<IHttpFileInfo*, void>)((*lpVtbl)[2]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ResetTTL()
    {
        ((delegate* unmanaged<IHttpFileInfo*, void>)((*lpVtbl)[3]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementTTL(BOOL* pfTTLExpired)
    {
        ((delegate* unmanaged<IHttpFileInfo*, BOOL*, void>)((*lpVtbl)[4]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            pfTTLExpired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetFlushed()
    {
        ((delegate* unmanaged<IHttpFileInfo*, void>)((*lpVtbl)[5]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetFlushed()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, int>)((*lpVtbl)[6]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint GetAttributes()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, uint>)((*lpVtbl)[7]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetSize(ULARGE_INTEGER* pliSize)
    {
        ((delegate* unmanaged<IHttpFileInfo*, ULARGE_INTEGER*, void>)((*lpVtbl)[8]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            pliSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("const BYTE *")]
    public byte* GetFileBuffer()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, byte*>)((*lpVtbl)[9]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HANDLE GetFileHandle()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpFileInfo*, void*>)((*lpVtbl)[10]))(
                    (IHttpFileInfo*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetFilePath()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, ushort*>)((*lpVtbl)[11]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetETag(ushort* pcchETag = null)
    {
        return ((delegate* unmanaged<IHttpFileInfo*, ushort*, sbyte*>)((*lpVtbl)[12]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            pcchETag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void GetLastModifiedTime(FILETIME* pFileTime)
    {
        ((delegate* unmanaged<IHttpFileInfo*, FILETIME*, void>)((*lpVtbl)[13]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            pFileTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetLastModifiedString()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, sbyte*>)((*lpVtbl)[14]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL GetHttpCacheAllowed([NativeTypeName("DWORD *")] uint* pSecondsToLive)
    {
        return ((delegate* unmanaged<IHttpFileInfo*, uint*, int>)((*lpVtbl)[15]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            pSecondsToLive
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AccessCheck(HANDLE hUserToken, [NativeTypeName("PSID")] void* pUserSid)
    {
        return ((delegate* unmanaged<IHttpFileInfo*, HANDLE, void*, int>)((*lpVtbl)[16]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            hUserToken,
            pUserSid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HANDLE GetVrToken()
    {
        return (
            (HANDLE)(
                ((delegate* unmanaged<IHttpFileInfo*, void*>)((*lpVtbl)[17]))(
                    (IHttpFileInfo*)Unsafe.AsPointer(ref this)
                )
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetVrPath()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, ushort*>)((*lpVtbl)[18]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged<IHttpFileInfo*, IHttpModuleContextContainer*>)((*lpVtbl)[19]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL CheckIfFileHasChanged(HANDLE hUserToken)
    {
        return ((delegate* unmanaged<IHttpFileInfo*, HANDLE, int>)((*lpVtbl)[20]))(
            (IHttpFileInfo*)Unsafe.AsPointer(ref this),
            hUserToken
        );
    }

    public interface Interface : IHttpCacheSpecificData.Interface
    {
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        uint GetAttributes();

        [VtblIndex(8)]
        void GetSize(ULARGE_INTEGER* pliSize);

        [VtblIndex(9)]
        [return: NativeTypeName("const BYTE *")]
        byte* GetFileBuffer();

        [VtblIndex(10)]
        HANDLE GetFileHandle();

        [VtblIndex(11)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetFilePath();

        [VtblIndex(12)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetETag(ushort* pcchETag = null);

        [VtblIndex(13)]
        void GetLastModifiedTime(FILETIME* pFileTime);

        [VtblIndex(14)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetLastModifiedString();

        [VtblIndex(15)]
        BOOL GetHttpCacheAllowed([NativeTypeName("DWORD *")] uint* pSecondsToLive);

        [VtblIndex(16)]
        HRESULT AccessCheck(HANDLE hUserToken, [NativeTypeName("PSID")] void* pUserSid);

        [VtblIndex(17)]
        HANDLE GetVrToken();

        [VtblIndex(18)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetVrPath();

        [VtblIndex(19)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(20)]
        BOOL CheckIfFileHasChanged(HANDLE hUserToken);
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

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetAttributes;

        [NativeTypeName("void (ULARGE_INTEGER *) const")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, void> GetSize;

        [NativeTypeName("const BYTE *() const")]
        public delegate* unmanaged<TSelf*, byte*> GetFileBuffer;

        [NativeTypeName("HANDLE () const")]
        public delegate* unmanaged<TSelf*, void*> GetFileHandle;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetFilePath;

        [NativeTypeName("PCSTR (USHORT *) const")]
        public delegate* unmanaged<TSelf*, ushort*, sbyte*> GetETag;

        [NativeTypeName("void (FILETIME *) const")]
        public delegate* unmanaged<TSelf*, FILETIME*, void> GetLastModifiedTime;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetLastModifiedString;

        [NativeTypeName("BOOL (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, int> GetHttpCacheAllowed;

        [NativeTypeName("HRESULT (HANDLE, PSID)")]
        public delegate* unmanaged<TSelf*, HANDLE, void*, int> AccessCheck;

        [NativeTypeName("HANDLE () const")]
        public delegate* unmanaged<TSelf*, void*> GetVrToken;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetVrPath;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("BOOL (HANDLE)")]
        public delegate* unmanaged<TSelf*, HANDLE, int> CheckIfFileHasChanged;
    }
}
