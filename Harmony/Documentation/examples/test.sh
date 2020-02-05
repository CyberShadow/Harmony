#!/bin/sh
exec find . -name '*.cs' -print0 | xargs -P 0 -0 -n 1 ./test-one.sh
