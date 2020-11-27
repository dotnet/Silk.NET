// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenAL.Attributes
{
    /// <summary>
    /// Specifies the native size of one sample of a given buffer format.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FormatSizeAttribute : Attribute
    {
        private int _size = 1;

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
    }
}