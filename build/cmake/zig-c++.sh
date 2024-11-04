#!/bin/bash
. "$(dirname ${BASH_SOURCE[0]})/fudge.sh" $args
zig c++ $args
