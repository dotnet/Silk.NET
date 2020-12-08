// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// Implementation of <see cref="INativeContext"/> using a lambda.
    /// </summary>
    public struct LamdaNativeContext : INativeContext
    {
        private readonly Func<string, IntPtr> _getProcAddress;

        /// <summary>
        /// Creates a <see cref="LamdaNativeContext"/> using the given lambda.
        /// </summary>
        /// <param name="getProcAddress">The lambda to use.</param>
        public LamdaNativeContext(Func<string, IntPtr> getProcAddress)
        {
            _getProcAddress = getProcAddress;
        }
        
        /// <inheritdoc />
        public IntPtr GetProcAddress(string proc, int? slot = default)
        {
            return _getProcAddress(proc);
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}
