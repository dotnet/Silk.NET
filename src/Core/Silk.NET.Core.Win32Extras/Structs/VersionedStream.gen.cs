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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagVersionedStream")]
    public unsafe partial struct VersionedStream
    {
        public VersionedStream
        (
            Guid? guidVersion = null,
            Silk.NET.Core.Win32Extras.IStream* pStream = null
        ) : this()
        {
            if (guidVersion is not null)
            {
                GuidVersion = guidVersion.Value;
            }

            if (pStream is not null)
            {
                PStream = pStream;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidVersion")]
        public Guid GuidVersion;

        [NativeName("Type", "IStream *")]
        [NativeName("Type.Name", "IStream *")]
        [NativeName("Name", "pStream")]
        public Silk.NET.Core.Win32Extras.IStream* PStream;
    }
}
