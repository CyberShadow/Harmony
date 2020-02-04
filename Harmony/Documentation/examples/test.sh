#!/bin/sh
set -eu

find . -mindepth 1 -maxdepth 1 -type d | \
	while read -r dir
	do
		csc /reference:../../obj/Debug/net35/0Harmony.dll /target:library /out:/dev/null ./*.cs "$dir"/*.cs
	done
