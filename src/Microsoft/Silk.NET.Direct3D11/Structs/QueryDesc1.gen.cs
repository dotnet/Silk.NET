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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY_DESC1")]
    public unsafe partial struct QueryDesc1
    {
        public QueryDesc1
        (
            Query? query = null,
            uint? miscFlags = null,
            ContextType? contextType = null
        ) : this()
        {
            if (query is not null)
            {
                Query = query.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }

            if (contextType is not null)
            {
                ContextType = contextType.Value;
            }
        }


        [NativeName("Type", "D3D11_QUERY")]
        [NativeName("Type.Name", "D3D11_QUERY")]
        [NativeName("Name", "Query")]
        public Query Query;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;

        [NativeName("Type", "D3D11_CONTEXT_TYPE")]
        [NativeName("Type.Name", "D3D11_CONTEXT_TYPE")]
        [NativeName("Name", "ContextType")]
        public ContextType ContextType;
    }
}
