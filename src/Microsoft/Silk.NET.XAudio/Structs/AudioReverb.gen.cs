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

namespace Silk.NET.XAudio
{
    [Guid("c2633b16-471b-4498-b8c5-4f0959e2ec09")]
    [NativeName("Name", "AudioReverb")]
    public unsafe partial struct AudioReverb
    {
        public static readonly Guid Guid = new("c2633b16-471b-4498-b8c5-4f0959e2ec09");

    }
}
