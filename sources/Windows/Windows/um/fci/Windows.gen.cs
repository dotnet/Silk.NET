// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fci.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCICreate"]/*' />
    [DllImport("cabinet", ExactSpelling = true)]
    [return: NativeTypeName("HFCI")]
    public static extern void* FCICreate([NativeTypeName("PERF")] ERF* perf, [NativeTypeName("PFNFCIFILEPLACED")] delegate* unmanaged<CCAB*, sbyte*, int, BOOL, void*, int> pfnfcifp, [NativeTypeName("PFNFCIALLOC")] delegate* unmanaged<uint, void*> pfna, [NativeTypeName("PFNFCIFREE")] delegate* unmanaged<void*, void> pfnf, [NativeTypeName("PFNFCIOPEN")] delegate* unmanaged<sbyte*, int, int, int*, void*, nint> pfnopen, [NativeTypeName("PFNFCIREAD")] delegate* unmanaged<nint, void*, uint, int*, void*, uint> pfnread, [NativeTypeName("PFNFCIWRITE")] delegate* unmanaged<nint, void*, uint, int*, void*, uint> pfnwrite, [NativeTypeName("PFNFCICLOSE")] delegate* unmanaged<nint, int*, void*, int> pfnclose, [NativeTypeName("PFNFCISEEK")] delegate* unmanaged<nint, int, int, int*, void*, int> pfnseek, [NativeTypeName("PFNFCIDELETE")] delegate* unmanaged<sbyte*, int*, void*, int> pfndelete, [NativeTypeName("PFNFCIGETTEMPFILE")] delegate* unmanaged<sbyte*, int, void*, BOOL> pfnfcigtf, [NativeTypeName("PCCAB")] CCAB* pccab, void* pv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCIAddFile"]/*' />
    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FCIAddFile([NativeTypeName("HFCI")] void* hfci, [NativeTypeName("LPSTR")] sbyte* pszSourceFile, [NativeTypeName("LPSTR")] sbyte* pszFileName, BOOL fExecute, [NativeTypeName("PFNFCIGETNEXTCABINET")] delegate* unmanaged<CCAB*, uint, void*, BOOL> pfnfcignc, [NativeTypeName("PFNFCISTATUS")] delegate* unmanaged<uint, uint, uint, void*, int> pfnfcis, [NativeTypeName("PFNFCIGETOPENINFO")] delegate* unmanaged<sbyte*, ushort*, ushort*, ushort*, int*, void*, nint> pfnfcigoi, [NativeTypeName("TCOMP")] ushort typeCompress);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCIFlushCabinet"]/*' />
    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FCIFlushCabinet([NativeTypeName("HFCI")] void* hfci, BOOL fGetNextCab, [NativeTypeName("PFNFCIGETNEXTCABINET")] delegate* unmanaged<CCAB*, uint, void*, BOOL> pfnfcignc, [NativeTypeName("PFNFCISTATUS")] delegate* unmanaged<uint, uint, uint, void*, int> pfnfcis);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCIFlushFolder"]/*' />
    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FCIFlushFolder([NativeTypeName("HFCI")] void* hfci, [NativeTypeName("PFNFCIGETNEXTCABINET")] delegate* unmanaged<CCAB*, uint, void*, BOOL> pfnfcignc, [NativeTypeName("PFNFCISTATUS")] delegate* unmanaged<uint, uint, uint, void*, int> pfnfcis);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCIDestroy"]/*' />
    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FCIDestroy([NativeTypeName("HFCI")] void* hfci);

    [NativeTypeName("#define INCLUDED_FCI 1")]
    public const int INCLUDED_FCI = 1;

    [NativeTypeName("#define _A_NAME_IS_UTF 0x80")]
    public const int _A_NAME_IS_UTF = 0x80;

    [NativeTypeName("#define _A_EXEC 0x40")]
    public const int _A_EXEC = 0x40;

    [NativeTypeName("#define statusFile 0")]
    public const int statusFile = 0;

    [NativeTypeName("#define statusFolder 1")]
    public const int statusFolder = 1;

    [NativeTypeName("#define statusCabinet 2")]
    public const int statusCabinet = 2;
}
