#!/bin/sh
set -eu

find . -name '*.cs' -print0 | xargs -P 0 -0 -n 1 csc /nologo /reference:../../obj/Debug/net35/0Harmony.dll /target:library /out:/dev/null
