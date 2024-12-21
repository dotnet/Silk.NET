// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagGLOBALOPT_EH_VALUES")]
    public enum GlobalOptEHValues : int
    {
        [Obsolete("Deprecated in favour of \"Handle\"")]
        [NativeName("Name", "COMGLB_EXCEPTION_HANDLE")]
        ComglbExceptionHandle = 0x0,
        [Obsolete("Deprecated in favour of \"DonotHandleFatal\"")]
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE_FATAL")]
        ComglbExceptionDonotHandleFatal = 0x1,
        [Obsolete("Deprecated in favour of \"DonotHandle\"")]
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE")]
        ComglbExceptionDonotHandle = 0x1,
        [Obsolete("Deprecated in favour of \"DonotHandleAny\"")]
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE_ANY")]
        ComglbExceptionDonotHandleAny = 0x2,
        [NativeName("Name", "COMGLB_EXCEPTION_HANDLE")]
        Handle = 0x0,
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE_FATAL")]
        DonotHandleFatal = 0x1,
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE")]
        DonotHandle = 0x1,
        [NativeName("Name", "COMGLB_EXCEPTION_DONOT_HANDLE_ANY")]
        DonotHandleAny = 0x2,
    }
}
