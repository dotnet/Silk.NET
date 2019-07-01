//
// CaptureEnumerationEnumeration.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Extensions.EXT.Capture.Enumeration;

namespace OpenToolkit.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the CaptureEnumerationEnumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    public abstract class CaptureEnumerationEnumeration : ContextExtensionBase, ICaptureEnumerationContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected CaptureEnumerationEnumeration(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe string GetString(Device* device, GetCaptureEnumerationContextString param);

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(Device* device, GetCaptureContextStringList param);

        /// <inheritdoc cref="GetStringList(OpenToolkit.OpenAL.Device*,OpenToolkit.OpenAL.Extensions.EXT.Capture.Enumeration.GetCaptureContextStringList)"/>
        public IEnumerable<string> GetStringList(GetCaptureContextStringList param)
        {
            unsafe
            {
                var result = GetStringList(null, param);
                if (result == (char*)0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (currentString is null)
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
