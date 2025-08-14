#!/bin/bash

# Origignal script from https://github.com/ziglang/zig/issues/4911
# Modified to add SILKDOTNET_ paths in response to some issues with SwiftShader

args=""
for arg in "$@"
do
    parg="$arg"

    option=${arg%=*}
    target=${arg#*=}
    if [[ $option == "-march" || $option == "-mcpu" || $option == "-mtune" ]]; then
        moveon=0
        for replace in $SILKDOTNET_ReplaceArchitectureZigCcFlags
        do
            replacetarget=${replace%=*}
            replacement=${replace#*=}
            # echo $replacetarget A $replacement B $target END
            if [[ $replacetarget == $target ]]; then
                if [[ "$replacement" == "" ]]; then
                    moveon=1
                else
                    target="$replacement"
                fi
            fi
        done
        if [[ $moveon == 1 || "$SILKDOTNET_RemoveAllPotentiallyProblematicZigCcFlags" == "1" ]]; then
            continue
        else
            fixedTarget=${target//-/_}
            parg="$option=$fixedTarget"
        fi
    fi
    args="$args $parg"
done
