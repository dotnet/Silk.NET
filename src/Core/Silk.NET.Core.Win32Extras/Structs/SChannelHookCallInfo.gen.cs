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
    [NativeName("Name", "SChannelHookCallInfo")]
    public unsafe partial struct SChannelHookCallInfo
    {
        public SChannelHookCallInfo
        (
            Guid? iid = null,
            uint? cbSize = null,
            Guid? uCausality = null,
            uint? dwServerPid = null,
            uint? iMethod = null,
            void* pObject = null
        ) : this()
        {
            if (iid is not null)
            {
                Iid = iid.Value;
            }

            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (uCausality is not null)
            {
                UCausality = uCausality.Value;
            }

            if (dwServerPid is not null)
            {
                DwServerPid = dwServerPid.Value;
            }

            if (iMethod is not null)
            {
                IMethod = iMethod.Value;
            }

            if (pObject is not null)
            {
                PObject = pObject;
            }
        }


        [NativeName("Type", "IID")]
        [NativeName("Type.Name", "IID")]
        [NativeName("Name", "iid")]
        public Guid Iid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "uCausality")]
        public Guid UCausality;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwServerPid")]
        public uint DwServerPid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "iMethod")]
        public uint IMethod;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pObject")]
        public void* PObject;
    }
}
