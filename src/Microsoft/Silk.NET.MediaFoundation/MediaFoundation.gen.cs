// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    public unsafe partial class MediaFoundation
    {
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "MF_INVALID_PRESENTATION_TIME")]
        public const ulong InvalidPresentationTime = unchecked((ulong) 0x8000000000000000);

    }
}

