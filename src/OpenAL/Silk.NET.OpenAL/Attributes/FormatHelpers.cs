// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using System.Reflection;

namespace Silk.NET.OpenAL.Attributes
{
    /// <summary>
    /// Helper methods for buffer formats.
    /// </summary>
    public static class FormatHelpers
    {
        /// <summary>
        /// Gets the native byte size of the given format.
        /// </summary>
        /// <typeparam name="TFormat">The format type.</typeparam>
        /// <param name="format">The format.</param>
        /// <returns>The size.</returns>
        public static int GetFormatSize<TFormat>(TFormat format)
            where TFormat : struct, Enum
        {
            var enumType = typeof(TFormat);
            var member = enumType.GetMember(format.ToString()).First();

            if (!(member.GetCustomAttribute(typeof(FormatSizeAttribute)) is FormatSizeAttribute sizeAttribute))
            {
                throw new InvalidOperationException("The given buffer format doesn't have a format size set.");
            }

            return sizeAttribute.Size;
        }
    }
}