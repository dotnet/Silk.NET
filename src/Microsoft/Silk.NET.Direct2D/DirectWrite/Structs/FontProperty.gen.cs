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
    [NativeName("Name", "DWRITE_FONT_PROPERTY")]
    public unsafe partial struct FontProperty
    {
        public FontProperty
        (
            FontPropertyID? propertyId = null,
            char* propertyValue = null,
            char* localeName = null
        ) : this()
        {
            if (propertyId is not null)
            {
                PropertyId = propertyId.Value;
            }

            if (propertyValue is not null)
            {
                PropertyValue = propertyValue;
            }

            if (localeName is not null)
            {
                LocaleName = localeName;
            }
        }


        [NativeName("Type", "DWRITE_FONT_PROPERTY_ID")]
        [NativeName("Type.Name", "DWRITE_FONT_PROPERTY_ID")]
        [NativeName("Name", "propertyId")]
        public FontPropertyID PropertyId;

        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "propertyValue")]
        public char* PropertyValue;

        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "localeName")]
        public char* LocaleName;
    }
}
