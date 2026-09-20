# The MSBuild project

Synthesized fixture for the DSL platform's customer journey J25
(`--engine msbuild`) — one project of this repository, beside the other
engines'. Authored by `tools/e2e/msbuild_fixture.py`; nothing here is customer
code.

* `csharp/AnyCpuApp.sln` — SDK-style C#,
  declares `Any CPU` and nothing else.
  Prints `dslp msbuildproof csharp ok` and writes `dslp_msbuildproof_csharp.txt`.
* `cpp/NativeApp.sln` — classic `.vcxproj`
  C++, declares `x64`.
  Prints `dslp msbuildproof cpp ok` and writes `dslp_msbuildproof_cpp.txt`.

Each solution is built by its own build configuration, which names it through
`msbuild_settings.solution` from the repository root.
