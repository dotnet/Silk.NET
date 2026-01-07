// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Extensions.EXT.Enumeration;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the API in the CaptureEnumerationEnumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    [NativeApi(Prefix = "alc")]
    public partial class CaptureEnumerationEnumeration : ContextExtensionBase
    {
        /// <inheritdoc cref="ExtensionBase" />
        public CaptureEnumerationEnumeration(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public unsafe partial string GetString(Device* device, GetCaptureEnumerationContextString param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public unsafe partial byte* GetStringList(Device* device, GetCaptureContextStringList param);

        /// <inheritdoc cref="GetStringList(Silk.NET.OpenAL.Device*,GetCaptureContextStringList)" />
        public IEnumerable<string> GetStringList(GetCaptureContextStringList param)
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
