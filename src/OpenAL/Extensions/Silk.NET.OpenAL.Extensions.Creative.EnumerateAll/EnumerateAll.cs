//
// EnumerateAll.cs
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

namespace OpenToolkit.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Exposes the API in the EnumerateAll extension.
    /// </summary>
    [Extension("ALC_ENUMERATE_ALL_EXT")]
    public abstract class EnumerateAll : ContextExtensionBase, IEnumerateAllContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected EnumerateAll(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe string GetString(Device* device, GetEnumerateAllContextString param);

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(Device* device, GetEnumerateAllContextStringList param);

        /// <inheritdoc cref="GetStringList(Device*, GetEnumerateAllContextStringList)"/>
        public IEnumerable<string> GetStringList(GetEnumerateAllContextStringList param)
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
