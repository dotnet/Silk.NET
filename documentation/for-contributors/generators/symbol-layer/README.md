# Symbol Layer

The symbol layer is a set of types in the Silk.NET.SilkTouch.Symbols, all inheriting from the central Silk.NET.SilkTouch.Symbols.Symbol type.

The symbol layer is intended as a way to represent data passed between components of SilkTouch and is entirely immutable, with the only exception being the [Type Store](./type-store.md).

The way to update & iterate symbols is using a [Symbol Visitor](./symbol-visitor.md).

See [symbols](./symbols/README.md) for a list of all symbols, their visitor method, test details, etc.

See [type references](./type-references.md) for an explanation of type references.
