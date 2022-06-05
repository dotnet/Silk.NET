// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_ASYNC_GETDATA_FLAG")]
    public enum AsyncGetdataFlag : int
    {
        [Obsolete("Deprecated in favour of \"Donotflush\"")]
        [NativeName("Name", "D3D11_ASYNC_GETDATA_DONOTFLUSH")]
        AsyncGetdataDonotflush = 0x1,
        [NativeName("Name", "D3D11_ASYNC_GETDATA_DONOTFLUSH")]
        Donotflush = 0x1,
    }
}
