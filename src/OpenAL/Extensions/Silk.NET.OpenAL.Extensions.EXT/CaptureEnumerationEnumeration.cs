// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
                if (result == (byte*) 0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi((nint) currentPos);
                    if (string.IsNullOrEmpty(currentString))
                    {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }
    }
}
