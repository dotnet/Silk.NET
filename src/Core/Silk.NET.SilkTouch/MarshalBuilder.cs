// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.SilkTouch
{
    public class MarshalBuilder
    {
        private readonly List<Middleware> _middlewares = new List<Middleware>();
            
        public MarshalBuilder Use(Middleware middleware)
        {
            _middlewares.Add(middleware);
            return this;
        }

        public void Run(MarshalContext context) => new MarshalRunner(context, _middlewares).Run();
            
        public MarshalBuilder Clone()
        {
            var n = new MarshalBuilder();
            n._middlewares.AddRange(_middlewares);
            return n;
        }
        
        private class MarshalRunner
        {
            private readonly List<Middleware> _middlewares;

            private MarshalContext _context;


            public MarshalRunner(MarshalContext context, List<Middleware> middlewares)
            {
                _context = context;
                _middlewares = middlewares;
            }
            public void Run() => Run(0);

            private void Run(int index)
            {
                if (index >= _middlewares.Count) throw new InvalidOperationException("One middleware has to be the terminating middleware");

                _middlewares[index](ref _context, () => Run(index + 1));
            }
        }
    }
}
