// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// A simple implementation of a <see cref="IVTable" /> using a concurrent dictionary.
    /// See https://ultz.co.uk/blog/silktouch-slots-vtables/ for an in-depth explanation.
    /// </summary>
    public class ConcurrentDictionaryVTable : IVTable
    {
        private const int ConcurrencyLevel = 1;
        private ConcurrentDictionary<int, IntPtr> _entryPoints;
        private INativeContext _ctx;
#if DEBUG
        private bool _initialized = false;
#endif

        /// <inheritdoc />
        public void Dispose()
        {
            _entryPoints = null;
        }

        /// <inheritdoc />
        public void Initialize(INativeContext ctx, int maxSlots)
        {
#if DEBUG
            Debug.Assert(!_initialized, "Do not re-initialize VTable");
            _initialized = true;
#endif
            _entryPoints = new ConcurrentDictionary<int, IntPtr>(ConcurrencyLevel, maxSlots);
            _ctx = ctx;
        }

        /// <inheritdoc />
        public IntPtr Load(int slot, string entryPoint)
        {
#if DEBUG
            Debug.Assert(_initialized, "Cannot load from uninitialized VTable");
#endif
            return _entryPoints.GetOrAdd(slot, i =>
            {
                var v = _ctx.GetProcAddress(entryPoint);

                if (v == IntPtr.Zero)
                    ThrowEntryPointNotFound(entryPoint, i);

                return v;
            });
        }

        /// <inheritdoc />
        public void Purge()
        {
            _entryPoints.Clear();
        }
        
        private void ThrowEntryPointNotFound(string entryPoint, int slot)
        {
            throw new EntryPointNotFoundException($"Native symbol \"{entryPoint}\" not found (slot {slot})");
        }
    }
}
