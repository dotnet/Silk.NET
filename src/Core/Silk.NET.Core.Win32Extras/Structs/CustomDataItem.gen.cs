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
    [NativeName("Name", "tagCUSTDATAITEM")]
    public unsafe partial struct CustomDataItem
    {
        public CustomDataItem
        (
            Guid? guid = null,
            Variant? varValue = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (varValue is not null)
            {
                VarValue = varValue.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guid")]
        public Guid Guid;

        [NativeName("Type", "VARIANTARG")]
        [NativeName("Type.Name", "VARIANTARG")]
        [NativeName("Name", "varValue")]
        public Variant VarValue;
    }
}
