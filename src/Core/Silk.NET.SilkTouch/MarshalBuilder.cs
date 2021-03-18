// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Silk.NET.SilkTouch
{
    public class MarshalBuilder
    {
        private readonly List<Middleware> _middleware = new List<Middleware>();
            
        public MarshalBuilder Use(Middleware middleware)
        {
            _middleware.Add(middleware);
            return this;
        }

        public void Run(MarshalContext context) => new MarshalRunner(context, _middleware).Run();
            
        public MarshalBuilder Clone()
        {
            var n = new MarshalBuilder();
            n._middleware.AddRange(_middleware);
            return n;
        }
        
        private class MarshalRunner
        {
            private readonly List<Middleware> _middleware;

            private IMarshalContext _context;

            public MarshalRunner(IMarshalContext context, List<Middleware> middleware)
            {
                _context = context;
                _middleware = middleware;
            }
            public void Run() => Run(0);

            private void Run(int index)
            {
                if (index >= _middleware.Count) throw new InvalidOperationException("One middleware has to be the terminating middleware");

                _middleware[index](ref _context, () => Run(index + 1));
            }
        }
    }
}
