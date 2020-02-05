#!/bin/sh
exec csc /nologo /reference:../../obj/Debug/net35/0Harmony.dll /target:library /out:/dev/null "$1" $(sed -n 's/.*extra-arg: \(.*\)$/\1/p' "$1")
