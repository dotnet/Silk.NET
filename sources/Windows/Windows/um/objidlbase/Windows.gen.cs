// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define COLE_DEFAULT_PRINCIPAL ( ( OLECHAR * )( INT_PTR  )-1 )")]
    public static ushort* COLE_DEFAULT_PRINCIPAL => unchecked((ushort*)((nint)(-1)));

    [NativeTypeName("#define COLE_DEFAULT_AUTHINFO ( ( void * )( INT_PTR  )-1 )")]
    public static void* COLE_DEFAULT_AUTHINFO => unchecked((void*)((nint)(-1)));
}
