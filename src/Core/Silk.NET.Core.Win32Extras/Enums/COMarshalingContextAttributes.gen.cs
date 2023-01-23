// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTES")]
    public enum COMarshalingContextAttributes : int
    {
        [Obsolete("Deprecated in favour of \"SourceIsAppContainer\"")]
        [NativeName("Name", "CO_MARSHALING_SOURCE_IS_APP_CONTAINER")]
        COMarshalingSourceIsAppContainer = 0x0,
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved1\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1")]
        COMarshalingContextAttributeReserved1 = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved2\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2")]
        COMarshalingContextAttributeReserved2 = unchecked((int) 0xFFFFFFFF80000001),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved3\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3")]
        COMarshalingContextAttributeReserved3 = unchecked((int) 0xFFFFFFFF80000002),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved4\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4")]
        COMarshalingContextAttributeReserved4 = unchecked((int) 0xFFFFFFFF80000003),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved5\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5")]
        COMarshalingContextAttributeReserved5 = unchecked((int) 0xFFFFFFFF80000004),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved6\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6")]
        COMarshalingContextAttributeReserved6 = unchecked((int) 0xFFFFFFFF80000005),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved7\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7")]
        COMarshalingContextAttributeReserved7 = unchecked((int) 0xFFFFFFFF80000006),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved8\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8")]
        COMarshalingContextAttributeReserved8 = unchecked((int) 0xFFFFFFFF80000007),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved9\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9")]
        COMarshalingContextAttributeReserved9 = unchecked((int) 0xFFFFFFFF80000008),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved10\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10")]
        COMarshalingContextAttributeReserved10 = unchecked((int) 0xFFFFFFFF80000009),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved11\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11")]
        COMarshalingContextAttributeReserved11 = unchecked((int) 0xFFFFFFFF8000000A),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved12\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12")]
        COMarshalingContextAttributeReserved12 = unchecked((int) 0xFFFFFFFF8000000B),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved13\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13")]
        COMarshalingContextAttributeReserved13 = unchecked((int) 0xFFFFFFFF8000000C),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved14\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14")]
        COMarshalingContextAttributeReserved14 = unchecked((int) 0xFFFFFFFF8000000D),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved15\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15")]
        COMarshalingContextAttributeReserved15 = unchecked((int) 0xFFFFFFFF8000000E),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved16\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16")]
        COMarshalingContextAttributeReserved16 = unchecked((int) 0xFFFFFFFF8000000F),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved17\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17")]
        COMarshalingContextAttributeReserved17 = unchecked((int) 0xFFFFFFFF80000010),
        [Obsolete("Deprecated in favour of \"ContextAttributeReserved18\"")]
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18")]
        COMarshalingContextAttributeReserved18 = unchecked((int) 0xFFFFFFFF80000011),
        [NativeName("Name", "CO_MARSHALING_SOURCE_IS_APP_CONTAINER")]
        SourceIsAppContainer = 0x0,
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1")]
        ContextAttributeReserved1 = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2")]
        ContextAttributeReserved2 = unchecked((int) 0xFFFFFFFF80000001),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3")]
        ContextAttributeReserved3 = unchecked((int) 0xFFFFFFFF80000002),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4")]
        ContextAttributeReserved4 = unchecked((int) 0xFFFFFFFF80000003),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5")]
        ContextAttributeReserved5 = unchecked((int) 0xFFFFFFFF80000004),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6")]
        ContextAttributeReserved6 = unchecked((int) 0xFFFFFFFF80000005),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7")]
        ContextAttributeReserved7 = unchecked((int) 0xFFFFFFFF80000006),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8")]
        ContextAttributeReserved8 = unchecked((int) 0xFFFFFFFF80000007),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9")]
        ContextAttributeReserved9 = unchecked((int) 0xFFFFFFFF80000008),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10")]
        ContextAttributeReserved10 = unchecked((int) 0xFFFFFFFF80000009),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11")]
        ContextAttributeReserved11 = unchecked((int) 0xFFFFFFFF8000000A),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12")]
        ContextAttributeReserved12 = unchecked((int) 0xFFFFFFFF8000000B),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13")]
        ContextAttributeReserved13 = unchecked((int) 0xFFFFFFFF8000000C),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14")]
        ContextAttributeReserved14 = unchecked((int) 0xFFFFFFFF8000000D),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15")]
        ContextAttributeReserved15 = unchecked((int) 0xFFFFFFFF8000000E),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16")]
        ContextAttributeReserved16 = unchecked((int) 0xFFFFFFFF8000000F),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17")]
        ContextAttributeReserved17 = unchecked((int) 0xFFFFFFFF80000010),
        [NativeName("Name", "CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18")]
        ContextAttributeReserved18 = unchecked((int) 0xFFFFFFFF80000011),
    }
}
