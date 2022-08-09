# Type References

Type references are a special kind of symbol used to reference types.

There are several kinds of type references.
During scraping (see [scraper](../scraper.md)) `UnresolvedTypeReference`s are created.
These should be resolved right after, in a process called [type resolution](../type-resolution.md).

Type resolution leads to a variety of more specialized type references, with the two base ones being

-   `InternalTypeReference`, referencing another newly defined type somewhere in the tree. (Note that it's generally not adviced to define types this way, they should already occur somewhere higher up in the tree)
-   `ExternalTypeReference`, referencing some external type, usually well known types from the standard library

There are several other type reference types, but they are wrappers around other references, for example `PointerTypeReference`.
