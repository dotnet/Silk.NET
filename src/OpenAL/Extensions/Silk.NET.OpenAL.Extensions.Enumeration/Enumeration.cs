// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the Enumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    [NativeApi(Prefix = "alc")]
    public partial class Enumeration : ContextExtensionBase
    {
        /// <inheritdoc cref="ExtensionBase" />
        public Enumeration(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public unsafe partial string GetString(Device* device, GetEnumerationContextString param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public unsafe partial byte* GetStringList(Device* device, GetEnumerationContextStringList param);

        /// <inheritdoc cref="GetString(Device*, GetEnumerationContextString)" />
        public IEnumerable<string> GetStringList(GetEnumerationContextStringList param)
        {
            unsafe
            {
                var result = GetStringList(null, param);
                if (result is null) return Enumerable.Empty<string>();

                var strings = new List<string>();

                var currentPos = result;
                while (*currentPos != '\0')
                {
                    var currentLength = (int) SilkMarshal.StringLength((nint) currentPos, NativeStringEncoding.UTF8);
                    var currentString = Encoding.UTF8.GetString(currentPos, currentLength);

                    strings.Add(currentString);
                    currentPos += currentLength + 1;
                }

                return strings;
            }
        }
    }
}
