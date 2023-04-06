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
    [NativeName("Name", "DWRITE_FONT_FEATURE")]
    public unsafe partial struct FontFeature
    {
        public FontFeature
        (
            FontFeatureTag? nameTag = null,
            uint? parameter = null
        ) : this()
        {
            if (nameTag is not null)
            {
                NameTag = nameTag.Value;
            }

            if (parameter is not null)
            {
                Parameter = parameter.Value;
            }
        }


        [NativeName("Type", "DWRITE_FONT_FEATURE_TAG")]
        [NativeName("Type.Name", "DWRITE_FONT_FEATURE_TAG")]
        [NativeName("Name", "nameTag")]
        public FontFeatureTag NameTag;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "parameter")]
        public uint Parameter;
    }
}
