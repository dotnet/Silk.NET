// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Core
{
    public static class TemporarySuperInvokeClass
    {
        public static LibraryLoader GetLoader(INativeContext ctx) => new ContextLoader(ctx);
    }
}
