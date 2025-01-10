// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SIGNER_SUBJECT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD *")]
    public uint* pdwIndex;

    [NativeTypeName("DWORD")]
    public uint dwSubjectChoice;

    [NativeTypeName("__AnonymousRecord_mssign32_L30_C9")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref SIGNER_FILE_INFO* pSignerFileInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerFileInfo; }
    }

    [UnscopedRef]
    public ref SIGNER_BLOB_INFO* pSignerBlobInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerBlobInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public SIGNER_FILE_INFO* pSignerFileInfo;

        [FieldOffset(0)]
        public SIGNER_BLOB_INFO* pSignerBlobInfo;
    }
}
