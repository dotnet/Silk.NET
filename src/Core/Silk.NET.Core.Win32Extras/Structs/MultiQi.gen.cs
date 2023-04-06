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
    [NativeName("Name", "tagMULTI_QI")]
    public unsafe partial struct MultiQi
    {
        public MultiQi
        (
            Guid* pIID = null,
            Silk.NET.Core.Native.IUnknown* pItf = null,
            int? hr = null
        ) : this()
        {
            if (pIID is not null)
            {
                PIID = pIID;
            }

            if (pItf is not null)
            {
                PItf = pItf;
            }

            if (hr is not null)
            {
                Hr = hr.Value;
            }
        }


        [NativeName("Type", "const IID *")]
        [NativeName("Type.Name", "const IID *")]
        [NativeName("Name", "pIID")]
        public Guid* PIID;

        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pItf")]
        public Silk.NET.Core.Native.IUnknown* PItf;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "hr")]
        public int Hr;
    }
}
