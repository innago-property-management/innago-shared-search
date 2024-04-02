#! /usr/bin/env bash

# install if missing
dotnet tool list -g | (grep xmldocmd || true) | wc -l | xargs test 0 -eq && dotnet tool install xmldocmd -g

rm -rf docs/
~/repos/XmlDocMarkdown/src/xmldocmd/bin/Debug/net8.0/xmldocmd ./bin/Debug/netstandard2.0/Taazaa.Shared.DevKit.Framework.Search.dll docs/
