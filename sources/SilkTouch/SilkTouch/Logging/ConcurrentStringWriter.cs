// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;

namespace Silk.NET.SilkTouch.Logging
{
    internal class ConcurrentStringWriter : StringWriter
    {
        private readonly object _lockObject = new object();

        public ConcurrentStringWriter() { }

        public ConcurrentStringWriter(IFormatProvider? formatProvider)
            : base(formatProvider) { }

        public ConcurrentStringWriter(StringBuilder sb)
            : base(sb) { }

        public ConcurrentStringWriter(StringBuilder sb, IFormatProvider? formatProvider)
            : base(sb, formatProvider) { }

        // Writes a character to the underlying string buffer.
        //
        public override void Write(char value)
        {
            lock (_lockObject)
            {
                base.Write(value);
            }
        }

        // Writes a range of a character array to the underlying string buffer.
        // This method will write count characters of data into this
        // StringWriter from the buffer character array starting at position
        // index.
        //
        public override void Write(char[] buffer, int index, int count)
        {
            lock (_lockObject)
            {
                base.Write(buffer, index, count);
            }
        }

        public override void Write(ReadOnlySpan<char> buffer)
        {
            lock (_lockObject)
            {
                base.Write(buffer);
            }
        }

        // Writes a string to the underlying string buffer. If the given string is
        // null, nothing is written.
        //
        public override void Write(string? value)
        {
            lock (_lockObject)
            {
                base.Write(value);
            }
        }

        public override void Write(StringBuilder? value)
        {
            lock (_lockObject)
            {
                base.Write(value);
            }
        }

        public override void WriteLine(ReadOnlySpan<char> buffer)
        {
            lock (_lockObject)
            {
                base.WriteLine(buffer);
            }
        }

        public override void WriteLine(StringBuilder? value)
        {
            lock (_lockObject)
            {
                base.WriteLine(value);
            }
        }

        public override Task WriteAsync(
            StringBuilder? value,
            CancellationToken cancellationToken = default
        )
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            lock (_lockObject)
            {
                base.Write(value);
            }

            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(
            StringBuilder? value,
            CancellationToken cancellationToken = default
        )
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            lock (_lockObject)
            {
                base.WriteLine(value);
            }
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(
            ReadOnlyMemory<char> buffer,
            CancellationToken cancellationToken = default
        )
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            WriteLine(buffer.Span);
            return Task.CompletedTask;
        }

        public string FlushText()
        {
            string val = string.Empty;
            lock (_lockObject)
            {
                StringBuilder builder = GetStringBuilder();
                val = builder.ToString();
                builder.Clear();
            }
            return val;
        }
    }
}
