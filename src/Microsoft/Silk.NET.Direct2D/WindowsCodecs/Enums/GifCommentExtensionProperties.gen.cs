// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifCommentExtensionProperties")]
    public enum GifCommentExtensionProperties : int
    {
        [NativeName("Name", "WICGifCommentExtensionText")]
        Text = 0x1,
        [NativeName("Name", "WICGifCommentExtensionProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
