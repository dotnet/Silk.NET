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
    public class ConcurrentDictionaryVTable : IVTable
    {
        private const int ConcurrencyLevel = 1;
        private ConcurrentDictionary<int, nint> _entryPoints;
        private INativeContext _ctx;
#if DEBUG
        private bool _initialized = false;
#endif

        public void Dispose()
        {
            _entryPoints = null;
        }

        public void Initialize(INativeContext ctx, int maxSlots)
        {
#if DEBUG
            Debug.Assert(!_initialized, "Do not re-initialize VTable");
            _initialized = true;
#endif
            _entryPoints = new ConcurrentDictionary<int, nint>(ConcurrencyLevel, maxSlots);
            _ctx = ctx;
        }

        public nint Load(int slot, string entryPoint)
        {
#if DEBUG
            Debug.Assert(_initialized, "Cannot load from uninitialized VTable");
#endif
            return _entryPoints.GetOrAdd(slot, i =>
            {
                var v = _ctx.GetProcAddress(entryPoint);

                if (v == 0)
                    ThrowEntryPointNotFound(entryPoint, i);

                return v;
            });
        }

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
