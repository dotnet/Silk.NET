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
    [Guid("4fc3b166-972a-40cf-bc37-7db03db2fba3")]
    [NativeName("Name", "AudioVolumeMeter")]
    public unsafe partial struct AudioVolumeMeter
    {
        public static readonly Guid Guid = new("4fc3b166-972a-40cf-bc37-7db03db2fba3");

    }
}
