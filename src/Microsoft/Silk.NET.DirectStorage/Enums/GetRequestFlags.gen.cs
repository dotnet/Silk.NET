// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAGS")]
    public enum GetRequestFlags : uint
    {
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_CUSTOM")]
        GetRequestFlagSelectCustom = 0x1,
        [Obsolete("Deprecated in favour of \"Builtin\"")]
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_BUILTIN")]
        GetRequestFlagSelectBuiltin = 0x2,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_ALL")]
        GetRequestFlagSelectAll = 0x3,
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_CUSTOM")]
        Custom = 0x1,
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_BUILTIN")]
        Builtin = 0x2,
        [NativeName("Name", "DSTORAGE_GET_REQUEST_FLAG_SELECT_ALL")]
        All = 0x3,
    }
}
