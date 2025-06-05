#!/bin/sh
echo "Detecting if node_modules is not empty..."
if [ -z "$( ls -A 'node_modules' )" ]; then
    echo "Installing node dependencies..."
    npm i
    echo "Finished node depencies installation"
else
    echo "Node Dependencies already installed"
fi
if [ ! -z "$1" ]; then
    echo "Running command passed through arg: $@"
    exec $@
fi
