#!/bin/bash

# Original script from https://github.com/ziglang/zig/issues/4911
# Modified to add SILKDOTNET_ paths in response to some issues with SwiftShader

args=""
for arg in "$@"; do
  currentArg="$arg"

  optionKey="${currentArg%=*}"
  optionValue="${currentArg#*=}"

  if [[ "$optionKey" == "-march" || "$optionKey" == "-mcpu" || "$optionKey" == "-mtune" ]]; then
    shouldRemove=0

    for replacement in $SILKDOTNET_ReplaceArchitectureZigCcFlags; do
      replacementValueFrom="${replacement%=*}"
      replacementValueTo="${replacement#*=}"

      if [[ "$replacementValueFrom" == "$optionValue" ]]; then
        if [[ "$replacementValueTo" == "" ]]; then
          shouldRemove=1
        else
          optionValue="$replacementValueTo"
        fi
      fi
    done

    if [[ "$shouldRemove" == "1" || "$SILKDOTNET_RemoveAllPotentiallyProblematicZigCcFlags" == "1" ]]; then
      continue
    else
      underscoredOptionValue="${optionValue//-/_}"
      currentArg="$optionKey=$underscoredOptionValue"
    fi
  fi

  args="$args $currentArg"
done
