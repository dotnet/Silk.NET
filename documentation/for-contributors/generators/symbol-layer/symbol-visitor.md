# Symbol Visitor

A symbol visitor visits each symbol and then calls the appropriate methods to recursively visit all parts.
Each symbol visitor has access to a [type store](./type-store.md). It has to be provided in the constructor of every symbol visitor.
It's generally adviced to simply bubble up this constructor parameter to users of your type.

## Updating Symbols

Each method returns the same type it gets as parameter, so prefer to override the most specific method possible.
For example, if you wish to rename all `TypeSymbol`s, override `VisitTypeSymbol`. But if you want to add a field to every struct, override `VisitStructSymbol`. If you want to rewrite the type of a symbol, for example generate a class for every struct, again, override the most specific method that is compatible with both (in this case `VisitTypeSymbol`) and do type checks as necessary.

### Type IDs

See [type store](./type-store.md) for details on what type Ids are.
**Do not change type IDs when visiting symbols. This breaks all references to that type.**

## Managing State

While the base `SymbolVisitor` is stateless, derived types are free to introduce (mutable) state. This allow propagating state other then the new symbol up the tree.
