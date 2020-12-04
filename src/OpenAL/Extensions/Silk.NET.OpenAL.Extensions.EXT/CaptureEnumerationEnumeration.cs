// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        protected CaptureEnumerationEnumeration(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public unsafe partial string GetString(Device* device, GetCaptureEnumerationContextString param);

        /// <inheritdoc />
        public unsafe partial byte* GetStringList(Device* device, GetCaptureContextStringList param);

        /// <inheritdoc cref="GetStringList(Silk.NET.OpenAL.Device*,GetCaptureContextStringList)" />
        public IEnumerable<string> GetStringList(GetCaptureContextStringList param)
        {
            unsafe
            {
                var result = GetStringList(null, param);
<<<<<<< HEAD
                if (result == (byte*) 0)
=======
                if (result == (char*) 0)
>>>>>>> master
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
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
