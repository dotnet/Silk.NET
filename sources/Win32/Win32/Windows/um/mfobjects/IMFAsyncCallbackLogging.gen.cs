// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C7A4DCA1-F5F0-47B6-B92B-BF0106D25791")]
[NativeTypeName("struct IMFAsyncCallbackLogging : IMFAsyncCallback")]
[NativeInheritance("IMFAsyncCallback")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFAsyncCallbackLogging
    : IMFAsyncCallbackLogging.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAsyncCallbackLogging));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParameters(
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("DWORD *")] uint* pdwQueue
    )
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwFlags,
            pdwQueue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Invoke(IMFAsyncResult pAsyncResult)
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, IMFAsyncResult, int>)((*lpVtbl)[4]))(
            this,
            pAsyncResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void* GetObjectPointer()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, void*>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("DWORD")]
    public uint GetObjectTag()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging, uint>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IMFAsyncCallback.Interface
    {
        [VtblIndex(5)]
        void* GetObjectPointer();

        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        uint GetObjectTag();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetParameters;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, int> Invoke;

        [NativeTypeName("void *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetObjectPointer;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetObjectTag;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFAsyncCallbackLogging"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFAsyncCallbackLogging(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFAsyncCallback"/> to <see cref = "IMFAsyncCallbackLogging"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFAsyncCallback"/> instance to be converted </param>
    public static explicit operator IMFAsyncCallbackLogging(Silk.NET.Windows.IMFAsyncCallback value)
    {
        return new IMFAsyncCallbackLogging(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFAsyncCallbackLogging"/> to <see cref = "Silk.NET.Windows.IMFAsyncCallback"/>.</summary>
    /// <param name = "value">The <see cref = "IMFAsyncCallbackLogging"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFAsyncCallback(IMFAsyncCallbackLogging value)
    {
        return new Silk.NET.Windows.IMFAsyncCallback(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFAsyncCallbackLogging"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFAsyncCallbackLogging(Silk.NET.Windows.IUnknown value)
    {
        return new IMFAsyncCallbackLogging(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFAsyncCallbackLogging"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFAsyncCallbackLogging"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFAsyncCallbackLogging value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
