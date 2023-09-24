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
    [NativeName("Name", "_userFLAG_STGMEDIUM")]
    public unsafe partial struct UserFLAGSTGMEDIUM
    {
        public UserFLAGSTGMEDIUM
        (
            int? contextFlags = null,
            int? fPassOwnership = null,
            UserSTGMEDIUM? stgmed = null
        ) : this()
        {
            if (contextFlags is not null)
            {
                ContextFlags = contextFlags.Value;
            }

            if (fPassOwnership is not null)
            {
                FPassOwnership = fPassOwnership.Value;
            }

            if (stgmed is not null)
            {
                Stgmed = stgmed.Value;
            }
        }


        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "ContextFlags")]
        public int ContextFlags;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "fPassOwnership")]
        public int FPassOwnership;

        [NativeName("Type", "userSTGMEDIUM")]
        [NativeName("Type.Name", "userSTGMEDIUM")]
        [NativeName("Name", "Stgmed")]
        public UserSTGMEDIUM Stgmed;
    }
}
