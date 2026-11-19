#!/bin/bash

# Original script from https://github.com/ziglang/zig/issues/4911
# Modified to add SILKDOTNET_ paths in response to some issues with SwiftShader

args=""
for arg in "$@"
do
    outputArg="$arg"

    optionKey=${arg%=*}
    optionValue=${arg#*=}

    if [[ $optionKey == "-march" || $optionKey == "-mcpu" || $optionKey == "-mtune" ]]; then
        shouldRemove=0

        for replacement in $SILKDOTNET_ReplaceArchitectureZigCcFlags
        do
            replacementValueFrom=${replacement%=*}
            replacementValueTo=${replacement#*=}

            if [[ $replacementValueFrom == $optionValue ]]; then
                if [[ "$replacementValueTo" == "" ]]; then
                    shouldRemove=1
                else
                    optionValue="$replacementValueTo"
                fi
            fi
        done

        if [[ $shouldRemove == 1 || "$SILKDOTNET_RemoveAllPotentiallyProblematicZigCcFlags" == "1" ]]; then
            continue
        else
            underscoredOptionValue=${optionValue//-/_}
            outputArg="$optionKey=$underscoredOptionValue"
        fi
    fi

    args="$args $outputArg"
done
