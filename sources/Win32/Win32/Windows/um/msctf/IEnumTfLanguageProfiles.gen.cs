// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3D61BF11-AC5F-42C8-A4CB-931BCC28C744")]
[NativeTypeName("struct IEnumTfLanguageProfiles : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfLanguageProfiles
    : IEnumTfLanguageProfiles.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfLanguageProfiles));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfLanguageProfiles, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumTfLanguageProfiles, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfLanguageProfiles, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfLanguageProfiles* ppEnum)
    {
        return (
            (delegate* unmanaged<IEnumTfLanguageProfiles, IEnumTfLanguageProfiles*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint ulCount,
        TF_LANGUAGEPROFILE* pProfile,
        [NativeTypeName("ULONG *")] uint* pcFetch
    )
    {
        return (
            (delegate* unmanaged<IEnumTfLanguageProfiles, uint, TF_LANGUAGEPROFILE*, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ulCount, pProfile, pcFetch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfLanguageProfiles, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfLanguageProfiles, uint, int>)((*lpVtbl)[6]))(
            this,
            ulCount
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfLanguageProfiles* ppEnum);

        [VtblIndex(4)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint ulCount,
            TF_LANGUAGEPROFILE* pProfile,
            [NativeTypeName("ULONG *")] uint* pcFetch
        );

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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

        [NativeTypeName("HRESULT (IEnumTfLanguageProfiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfLanguageProfiles*, int> Clone;

        [NativeTypeName("HRESULT (ULONG, TF_LANGUAGEPROFILE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TF_LANGUAGEPROFILE*, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumTfLanguageProfiles"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumTfLanguageProfiles(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumTfLanguageProfiles"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumTfLanguageProfiles(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumTfLanguageProfiles(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumTfLanguageProfiles"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumTfLanguageProfiles"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumTfLanguageProfiles value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
