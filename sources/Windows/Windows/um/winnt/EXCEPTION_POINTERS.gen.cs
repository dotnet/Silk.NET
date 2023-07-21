// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EXCEPTION_POINTERS.xml' path='doc/member[@name="EXCEPTION_POINTERS"]/*' />
public unsafe partial struct EXCEPTION_POINTERS
{
    /// <include file='EXCEPTION_POINTERS.xml' path='doc/member[@name="EXCEPTION_POINTERS.ExceptionRecord"]/*' />
    [NativeTypeName("PEXCEPTION_RECORD")]
    public EXCEPTION_RECORD* ExceptionRecord;

    /// <include file='EXCEPTION_POINTERS.xml' path='doc/member[@name="EXCEPTION_POINTERS.ContextRecord"]/*' />
    [NativeTypeName("PCONTEXT")]
    public void* ContextRecord;
}
