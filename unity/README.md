# The Unity project of the fixture repository

The Unity project the DSL platform's build journeys compile: `unity/` inside the ONE fixture
repository, `brentDSL/dslp-e2e-buildproof` (ADR 0133). One empty scene carrying `DslpBuildProof`:
on its first frame the built player writes the declared marker to the declared marker file in its
working directory, logs the same line, and quits — so a headless run of the player is the evidence
that a real, working player came out of the build (P-22).

**These bytes were authored by the real editor** (Unity 6000.0.65f1, `-createProject` plus
`Assets/Editor/DslpFixtureAuthor.cs`, which is kept here so the origin is reproducible), then
trimmed to built-in modules, and then OPENED BY THE FLEET'S BASELINE EDITOR, Unity 6000.3.20f1
(`[components.unity]` in `config/env/<env>/third_party.toml`), which upgraded the project in place
and wrote `ProjectVersion.txt`, `ProjectSettings.asset`, `Packages/manifest.json` and
`Packages/packages-lock.json` as they are committed now. A fixture follows the pin: the agent
selects the editor by `ProjectVersion.txt`, and the fleet is converged to one baseline editor
(coordinator ruling R1, 2026-09-27; run `-batchmode -quit -projectPath` on the entitled datacenter
build host casting-sauce, whose editor carried no Linux module, so the upgrade dropped the
`com.unity.toolchain.win-x86_64-linux-x86_64` IL2CPP cross-compile package the 6000.0.65f1 import
had added — the project builds its Linux player on the default Mono backend, which needs none).
Nothing here is written from memory: a Unity
project typed out as YAML by hand would be a fake of the editor's output, and a fixture that is a
fake proves nothing when a journey builds it. Everything but this README is byte-for-byte what the
editor wrote — including `ProjectSettings/ProjectSettings.asset`'s `productName`, which still
carries the name of the repository the project was authored in, because changing editor output by
hand is the very thing this fixture must not do *(2026-09-20)*.

The project is PLACED into a clone of the fixture repository by
`tools/e2e/unity_fixture.py` / `tools/e2e/fixture_seed.py --engine unity`; what its program says
and writes is declared once, in `tools/e2e/fixture_projects.json`, and
`tools/e2e/tests/test_unity_fixture.py` fails if these bytes and that declaration disagree.

No live data of any kind. Synthesized in full.
