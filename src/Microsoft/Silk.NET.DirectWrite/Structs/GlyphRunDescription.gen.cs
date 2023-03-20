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

namespace Silk.NET.DirectWrite
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DWRITE_GLYPH_RUN_DESCRIPTION")]
    public unsafe partial struct GlyphRunDescription
    {
        public GlyphRunDescription
        (
            char* localeName = null,
            char* @string = null,
            uint? stringLength = null,
            ushort* clusterMap = null,
            uint? textPosition = null
        ) : this()
        {
            if (localeName is not null)
            {
                LocaleName = localeName;
            }

            if (@string is not null)
            {
                String = @string;
            }

            if (stringLength is not null)
            {
                StringLength = stringLength.Value;
            }

            if (clusterMap is not null)
            {
                ClusterMap = clusterMap;
            }

            if (textPosition is not null)
            {
                TextPosition = textPosition.Value;
            }
        }


        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "localeName")]
        public char* LocaleName;

        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "string")]
        public char* String;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "stringLength")]
        public uint StringLength;

        [NativeName("Type", "const UINT16 *")]
        [NativeName("Type.Name", "const UINT16 *")]
        [NativeName("Name", "clusterMap")]
        public ushort* ClusterMap;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "textPosition")]
        public uint TextPosition;
    }
}
