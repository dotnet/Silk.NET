//
// FormatSizeAttribute.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace Silk.NET.OpenAL.Attributes
{
    /// <summary>
    /// Specifies the native size of one sample of a given buffer format.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FormatSizeAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the native size of the buffer format. Defaults to one byte.
        /// </summary>
        public int Size
        {
            get => _size;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The size must be a nonzero positive value.");
                }

                _size = value;
            }
        }

        private int _size = 1;
    }
}
