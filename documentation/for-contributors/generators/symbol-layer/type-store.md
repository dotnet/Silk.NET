# Type Store

The type store is a simple helper to resolve type identifier to the latest instance.
It's available from inside every [Symbol Visitor](./symbol-visitor.md).

## Updating

The type store needs updating when changing a type. Usually [Symbol Visitors](./symbol-visitor) will do this automatically after visiting a type (`VisitType`), but inheritors overriding this should do this manually using
`Store(TypeSymbol)`.
