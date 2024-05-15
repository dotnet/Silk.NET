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
    [NativeName("Name", "tagLICINFO")]
    public unsafe partial struct LICInfo
    {
        public LICInfo
        (
            int? cbLicInfo = null,
            Silk.NET.Core.Bool32? fRuntimeKeyAvail = null,
            Silk.NET.Core.Bool32? fLicVerified = null
        ) : this()
        {
            if (cbLicInfo is not null)
            {
                CbLicInfo = cbLicInfo.Value;
            }

            if (fRuntimeKeyAvail is not null)
            {
                FRuntimeKeyAvail = fRuntimeKeyAvail.Value;
            }

            if (fLicVerified is not null)
            {
                FLicVerified = fLicVerified.Value;
            }
        }


        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "cbLicInfo")]
        public int CbLicInfo;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "fRuntimeKeyAvail")]
        public Silk.NET.Core.Bool32 FRuntimeKeyAvail;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "fLicVerified")]
        public Silk.NET.Core.Bool32 FLicVerified;
    }
}
