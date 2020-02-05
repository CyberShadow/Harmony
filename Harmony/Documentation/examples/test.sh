#!/bin/sh
set -eu

for f in *.cs
do
	csc /reference:../../obj/Debug/net35/0Harmony.dll /target:library /out:/dev/null "$f"
done
