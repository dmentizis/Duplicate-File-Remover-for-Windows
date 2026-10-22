# Duplicate File Remover for Windows

A .NET 10 Windows Forms application that groups files by SHA-256 content, regardless of filename or extension.

## Run

Install the .NET 10 SDK on Windows, then run:

```powershell
dotnet run --project DuplicateRemover
```

Choose or enter a folder, select whether to include subfolders, and click **Scan files**. Discovery and hashing run on a background worker. **Cancel scan** interrupts discovery or hashing between 1 MB reads, including within large files. Cancelled scans discard partial results. Inaccessible files/folders are logged and skipped; links and reparse points are excluded.

The results show one entry per distinct content hash with its copy count. Use the dropdown to show all distinct files, duplicates, or single instances. Selecting an entry displays all full paths in ordinal, case-insensitive order. Select a path and click **Open in Explorer** to open its containing folder. The interface uses a dark slate palette with rounded buttons and input panels.

- **Auto clean all groups** keeps the first sorted full path for each distinct file across the entire scan, regardless of the active filter.
- **Keep first path** does the same for the selected group.
- **Keep only selected** deletes every other instance of the selected group.
- **Delete selected path** deletes just that instance, including a last remaining copy if confirmed.

Deletion requires confirmation and is permanent (it does not use the Recycle Bin). Cleanup rehashes the retained and target files to reject missing or changed scan results. Failures are logged individually and unsuccessful paths stay in the results. Avoid modifying or moving files externally while scanning or cleaning; validation cannot make external filesystem changes transactional. Scan again after external changes.

The interface shows overall file progress, current-file hashing percentage, result totals, and timestamped activity with severity. **Save log** exports the current activity buffer; the in-app buffer is bounded to keep long sessions responsive. Cleanup also runs off the UI thread and reports progress. Closing during a scan requests cancellation; closing during cleanup waits for it to finish.

## Validation

```powershell
dotnet build DuplicateRemover.sln
dotnet run --project DuplicateRemover.Tests
```

The dependency-free test executable creates its own temporary files and checks grouping, recursion, progress, cancellation, safe retention, stale-file rejection, deletion model updates, form initialization, and filters. It deletes only its own temporary test directory.

Implementation is separated into the WinForms presentation, content scan and deletion logic (`LogicMethods`), and file group models (`Objects`).
