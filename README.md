# TRLogDecrypt

<img width="520" height="196" alt="image" src="https://github.com/user-attachments/assets/66b5e727-208c-4cee-a4c3-02d5ee57eb76" />


Windows GUI for decrypting **TalesRunner** client logs so you can read them as plain text.

![.NET Framework 4.8](https://img.shields.io/badge/.NET_Framework-4.8-512BD4)
![Windows](https://img.shields.io/badge/platform-Windows-blue)
![WinForms](https://img.shields.io/badge/UI-WinForms-0e7c86)

## What it decrypts

| Encrypted log | Typical location | Output |
|---|---|---|
| `dbgtrace.txt` | `%AppData%\TalesRunner\dbgtrace.txt` | `dbgtrace_de.txt` |
| `patchlog.txt` | `%AppData%\TalesRunner\patchlog.txt` | `patchlog_de.txt` |

Output is always written **next to `TRLogDecrypt.exe`**, named `{input}_de.txt`.

These files are XOR-encrypted client traces. TRLogDecrypt only handles `dbgtrace` / `patchlog` style logs.

## Features

- Default path set to `%AppData%\TalesRunner\dbgtrace.txt`
- Browse, drag-and-drop, or decrypt immediately after picking a file
- Rejects files that are not TalesRunner encrypted logs

## Usage

1. Build or copy `TRLogDecrypt.exe` to a folder where you want the decrypted files.
2. Run `TRLogDecrypt.exe`.
3. Confirm the log path, or **Browse** / drop `dbgtrace.txt` or `patchlog.txt`.
4. Click **Decrypt**.

The status line shows the full output path on success.

## Build

Requirements:

- Windows
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- .NET Framework 4.8 targeting pack (installed with that workload)

Open the solution:

```text
TRLogDecrypt.sln
```

Set **TRLogDecrypt** as the startup project, then press F5.

Release output:

```text
bin\Release\TRLogDecrypt.exe
```

## How decryption works

Encrypted logs start with a 34-byte header. After XOR it must decode to:

```text
TALESRUNNER-B5389169-5DAD-412E-9:<
```

The body is XOR'd with a 32-byte repeating ASCII key. The key index resets to `0` after every newline (`\n`). The saved `*_de.txt` file is the decrypted body only (header stripped).

If the header magic does not match, the file is not a TalesRunner encrypted log and the app stops.
