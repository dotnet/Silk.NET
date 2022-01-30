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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_COPPSetProtectionLevelCmdData")]
    public unsafe partial struct COPPSetProtectionLevelCmdData
    {
        public COPPSetProtectionLevelCmdData
        (
            uint? protType = null,
            uint? protLevel = null,
            uint? extendedInfoChangeMask = null,
            uint? extendedInfoData = null
        ) : this()
        {
            if (protType is not null)
            {
                ProtType = protType.Value;
            }

            if (protLevel is not null)
            {
                ProtLevel = protLevel.Value;
            }

            if (extendedInfoChangeMask is not null)
            {
                ExtendedInfoChangeMask = extendedInfoChangeMask.Value;
            }

            if (extendedInfoData is not null)
            {
                ExtendedInfoData = extendedInfoData.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProtType")]
        public uint ProtType;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProtLevel")]
        public uint ProtLevel;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ExtendedInfoChangeMask")]
        public uint ExtendedInfoChangeMask;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ExtendedInfoData")]
        public uint ExtendedInfoData;
    }
}
