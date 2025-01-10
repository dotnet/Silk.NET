// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("93384E18-5014-43D5-ADBB-A78E055926BD")]
[NativeTypeName("struct ISpResourceManager : IServiceProvider")]
[NativeInheritance("IServiceProvider")]
public unsafe partial struct ISpResourceManager : ISpResourceManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpResourceManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpResourceManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpResourceManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpResourceManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryService(
        [NativeTypeName("const GUID &")] Guid* guidService,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObject
    )
    {
        return ((delegate* unmanaged<ISpResourceManager, Guid*, Guid*, void**, int>)((*lpVtbl)[3]))(
            this,
            guidService,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetObject(
        [NativeTypeName("const GUID &")] Guid* guidServiceId,
        IUnknown pUnkObject
    )
    {
        return ((delegate* unmanaged<ISpResourceManager, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            guidServiceId,
            pUnkObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObject(
        [NativeTypeName("const GUID &")] Guid* guidServiceId,
        [NativeTypeName("const IID &")] Guid* ObjectCLSID,
        [NativeTypeName("const IID &")] Guid* ObjectIID,
        BOOL fReleaseWhenLastExternalRefReleased,
        void** ppObject
    )
    {
        return (
            (delegate* unmanaged<ISpResourceManager, Guid*, Guid*, Guid*, BOOL, void**, int>)(
                (*lpVtbl)[5]
            )
        )(
            this,
            guidServiceId,
            ObjectCLSID,
            ObjectIID,
            fReleaseWhenLastExternalRefReleased,
            ppObject
        );
    }

    public interface Interface : IServiceProvider.Interface
    {
        [VtblIndex(4)]
        HRESULT SetObject(
            [NativeTypeName("const GUID &")] Guid* guidServiceId,
            IUnknown pUnkObject
        );

        [VtblIndex(5)]
        HRESULT GetObject(
            [NativeTypeName("const GUID &")] Guid* guidServiceId,
            [NativeTypeName("const IID &")] Guid* ObjectCLSID,
            [NativeTypeName("const IID &")] Guid* ObjectIID,
            BOOL fReleaseWhenLastExternalRefReleased,
            void** ppObject
        );
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

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> QueryService;

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetObject;

        [NativeTypeName(
            "HRESULT (const GUID &, const IID &, const IID &, BOOL, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, BOOL, void**, int> GetObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpResourceManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpResourceManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IServiceProvider"/> to <see cref = "ISpResourceManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IServiceProvider"/> instance to be converted </param>
    public static explicit operator ISpResourceManager(Silk.NET.Windows.IServiceProvider value)
    {
        return new ISpResourceManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpResourceManager"/> to <see cref = "Silk.NET.Windows.IServiceProvider"/>.</summary>
    /// <param name = "value">The <see cref = "ISpResourceManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IServiceProvider(ISpResourceManager value)
    {
        return new Silk.NET.Windows.IServiceProvider(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpResourceManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpResourceManager(Silk.NET.Windows.IUnknown value)
    {
        return new ISpResourceManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpResourceManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpResourceManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpResourceManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
