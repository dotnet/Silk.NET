# Visitor

To Transform our internal symbol layer to C# code a visitor is used.

## State

To communicate produced syntax nodes with the levels above the current one the state variables are used.
Therefore its important to enshure that this state is clear at all times.

## Depth First

In general we try to push symbols down as far as possible to avoid code duplication and increase testable surface area.

## Trivia

The visitor is intended to produce "valid" code, that means it can be formatted using .ToFullString and the resulting code is valid and can be parsed back by roslyn.
In addition we try to avoid elastic trivia wherever possible. For performance reasons we don't want to normalize our trivia / syntax internally, but elastic trivia would be thrown away when doing so, therefore we try to avoid generating elastic trivia in the first place.
Integration tests should test for elastic trivia, although their primary purpose is to check the resulting formatted string.
