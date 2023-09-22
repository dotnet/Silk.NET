// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifCommentExtensionProperties")]
    public enum WICGifCommentExtensionProperties : int
    {
        [Obsolete("Deprecated in favour of \"Text\"")]
        [NativeName("Name", "WICGifCommentExtensionText")]
        WicgifCommentExtensionText = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICGifCommentExtensionProperties_FORCE_DWORD")]
        WicgifCommentExtensionPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICGifCommentExtensionText")]
        Text = 0x1,
        [NativeName("Name", "WICGifCommentExtensionProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
