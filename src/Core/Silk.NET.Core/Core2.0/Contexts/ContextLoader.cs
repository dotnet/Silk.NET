// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Contexts
{
    internal sealed class ContextLoader : GLSymbolLoader
    {
        private INativeContext _ctx;

        public ContextLoader(INativeContext ctx)
        {
            _ctx = ctx;
        }

        protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
            => _ctx.GetProcAddress(functionName);
    }
}
