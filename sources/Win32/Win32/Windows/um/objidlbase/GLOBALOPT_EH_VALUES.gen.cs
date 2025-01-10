// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum GLOBALOPT_EH_VALUES
{
    COMGLB_EXCEPTION_HANDLE = 0,
    COMGLB_EXCEPTION_DONOT_HANDLE_FATAL = 1,
    COMGLB_EXCEPTION_DONOT_HANDLE = COMGLB_EXCEPTION_DONOT_HANDLE_FATAL,
    COMGLB_EXCEPTION_DONOT_HANDLE_ANY = 2,
}
