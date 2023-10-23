// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegCommentProperties")]
    public enum JpegCommentProperties : int
    {
        [NativeName("Name", "WICJpegCommentText")]
        Text = 0x1,
        [NativeName("Name", "WICJpegCommentProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
