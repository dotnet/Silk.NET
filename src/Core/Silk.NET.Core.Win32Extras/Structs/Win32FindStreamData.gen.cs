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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "_WIN32_FIND_STREAM_DATA")]
    public unsafe partial struct Win32FindStreamData
    {
        public Win32FindStreamData
        (
            long? streamSize = null
        ) : this()
        {
            if (streamSize is not null)
            {
                StreamSize = streamSize.Value;
            }
        }


        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "StreamSize")]
        public long StreamSize;
        [NativeName("Type", "WCHAR[296]")]
        [NativeName("Type.Name", "WCHAR[296]")]
        [NativeName("Name", "cStreamName")]
        public fixed char CStreamName[296];
    }
}
