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

namespace Silk.NET.Shaderc
{
    [NativeName("Name", "shaderc_include_result")]
    public unsafe partial struct IncludeResult
    {
        public IncludeResult
        (
            byte* sourceName = null,
            nuint? sourceNameLength = null,
            byte* content = null,
            nuint? contentLength = null,
            void* userData = null
        ) : this()
        {
            if (sourceName is not null)
            {
                SourceName = sourceName;
            }

            if (sourceNameLength is not null)
            {
                SourceNameLength = sourceNameLength.Value;
            }

            if (content is not null)
            {
                Content = content;
            }

            if (contentLength is not null)
            {
                ContentLength = contentLength.Value;
            }

            if (userData is not null)
            {
                UserData = userData;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "source_name")]
        public byte* SourceName;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "source_name_length")]
        public nuint SourceNameLength;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "content")]
        public byte* Content;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "content_length")]
        public nuint ContentLength;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "user_data")]
        public void* UserData;
    }
}
