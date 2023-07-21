// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY
{
    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.BeginAddress"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong BeginAddress;

    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.EndAddress"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EndAddress;

    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.ExceptionHandler"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ExceptionHandler;

    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.HandlerData"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong HandlerData;

    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.PrologEndAddress"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong PrologEndAddress;
}
