#!/bin/bash
. "$(dirname ${BASH_SOURCE[0]})/zig-rewrite-args.sh" $args
zig c++ $args
