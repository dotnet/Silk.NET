// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Exposes the API in the EnumerateAll extension.
    /// </summary>
    [Extension("ALC_ENUMERATE_ALL_EXT")]
    [NativeApi(Prefix = "alc")]
    public partial class EnumerateAll : ContextExtensionBase
    {
        /// <inheritdoc cref="ExtensionBase" />
        public EnumerateAll(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public unsafe partial string GetString(Device* device, GetEnumerateAllContextString param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public unsafe partial byte* GetStringList(Device* device, GetEnumerateAllContextStringList param);

        /// <inheritdoc cref="GetStringList(Device*, GetEnumerateAllContextStringList)" />
        public IEnumerable<string> GetStringList(GetEnumerateAllContextStringList param)
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
