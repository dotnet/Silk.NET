# Type Store

The type store is a simple helper to resolve type identifier to the latest instance.
It's available from inside every [Symbol Visitor](./symbol-visitor.md).

## Type IDs

`TypeId`s are a small `struct` intended to help reference types across trees.
This is useful because all symbols are immutable, and this makes it impossible to have loops in the symbol tree.
To allow loops, the type store is mutable and resolves each type id to the latest immutable version.

## Updating

The type store needs updating when changing a type. Usually [Symbol Visitors](./symbol-visitor) will do this automatically after visiting a type (`VisitType`), but inheritors overriding this should do this manually using
`Store(TypeSymbol)`.
