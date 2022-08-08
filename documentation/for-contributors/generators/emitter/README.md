# Emitter

The emitter is responsible for creating Roslyn C# Code Symbols from our symbol layer.

See [here](./about%20formatting.md) for how formatting works, and [here](./visitor.md) for details on the visitor implementation.

In general the emitter tries it's best to be very basic doing only the job of 1:1 translating shared symbol layer into C# roslyn symbols.
